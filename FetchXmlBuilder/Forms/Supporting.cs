﻿using Rappen.XTB.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using XrmToolBox.AppCode.AppInsights;
using XrmToolBox.Extensibility;
using XrmToolBox.ToolLibrary.AppCode;

namespace Rappen.XTB
{
    public partial class Supporting : Form
    {
        private const string formidcorporate = "wpf17273";
        private const string formidpersonal = "wpf17612";
        private const string formidcontribute = "wpf17677";

        private const string urlcorp =
            "https://jonasr.app/supporting-prefilled/" +
            "?{formid}_1_first={firstname}" +
            "&{formid}_1_last={lastname}" +
            "&{formid}_27={company}" +
            "&{formid}_3={companycountry}" +
            "&{formid}_4={invoiceemail}" +
            "&{formid}_19={size}" +
            "&{formid}_24={amount}" +
            "&{formid}_13={tool}" +
            "&{formid}_31={tool}" +
            "&{formid}_32={version}" +
            "&{formid}_33={instid}";

        private const string urlpersmonetary =
            "https://jonasr.app/supporting/personal-prefilled/" +
            "?{formid}_1_first={firstname}" +
            "&{formid}_1_last={lastname}" +
            "&{formid}_3={country}" +
            "&{formid}_4={email}" +
            "&{formid}_13={tool}" +
            "&{formid}_31={tool}" +
            "&{formid}_32={version}" +
            "&{formid}_33={instid}";

        private const string urlperscontr =
            "https://jonasr.app/supporting/contribute-prefilled/" +
            "?{formid}_1_first={firstname}" +
            "&{formid}_1_last={lastname}" +
            "&{formid}_3={country}" +
            "&{formid}_4={email}" +
            "&{formid}_13={tool}" +
            "&{formid}_31={tool}" +
            "&{formid}_32={version}" +
            "&{formid}_33={instid}";

        private static RappenXTB tools;
        private static Tool tool;
        private static Supporters supporters;
        private static ToolSettings settings;
        private static Random random = new Random();

        private readonly AppInsights appinsights;
        private readonly Stopwatch sw = new Stopwatch();
        private readonly Stopwatch swInfo = new Stopwatch();

        #region Static Public Methods

        public static void ShowIf(PluginControlBase plugin, bool manual, bool reload, AppInsights appinsights)
        {
            try
            {
                var display = manual;
                if (reload || settings == null)
                {
                    settings = ToolSettings.Get();
                    display = ShowSupporting(plugin.ToolName);
                }
                if (!display)
                {
                    return;
                }
                new Supporting(appinsights, manual).ShowDialog(plugin);
                if (!manual)
                {
                    tool.DisplayDate = DateTime.Now;
                    tool.DisplayCount++;
                }
                tools.Save();
            }
            catch (Exception ex)
            {
                plugin.LogError($"ToolSupporting error:\n{ex}");
            }
        }

        #endregion Static Public Methods

        #region Constructors

        private Supporting(AppInsights appinsights, bool manual)
        {
            InitializeComponent();
            lblHeader.Text = tool.ToolName;
            helpTitle.Text = settings.HelpTitle;
            helpText.Text = settings.HelpText.Replace("\r\n", "\n").Replace("\n", "\r\n");
            helpLink.Text = settings.HelpLink;
            helpLink.Tag = settings.HelpLink;
            helpLink.Visible = !string.IsNullOrEmpty(settings.HelpLink);
            if (supporters.Any())
            {
                lblAlready.Text = lblAlready.Text.Replace("{tool}", tool.ToolName);
                lblAlready.Visible = true;
                toolTip1.SetToolTip(lblLater, "Close this window.");
            }
            txtCompanyName.Text = tools.CompanyName;
            txtCompanyEmail.Text = tools.CompanyEmail;
            cmbCompanyUsers.SelectedIndex = tool.UsersIndex;
            txtCompanyCountry.Text = tools.CompanyCountry;
            txtPersonalFirst.Text = tools.PersonalFirstName;
            txtPersonalLast.Text = tools.PersonalLastName;
            txtPersonalEmail.Text = tools.PersonalEmail;
            txtPersonalCountry.Text = tools.PersonalCountry;
            if (tool.SupportType == SupportType.Personal)
            {
                rbPersonal.Checked = true;
            }
            else
            {
                rbCompany.Checked = true;
            }
            appinsights?.WriteEvent($"Supporting-Open-{(manual ? "Manual" : "Auto")}");
        }

        #endregion Constructors

        #region Private Methods

        private static bool ShowSupporting(string toolname)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            tools = RappenXTB.Load();
            tool = tools[toolname];
            if (tool.Version != version)
            {
                tool.Version = version;
                tool.VersionRunDate = DateTime.Now;
                tools.Save();
            }
            supporters = Supporters.DownloadMy(tools.InstallationId, toolname, settings.ContributionCounts);
            if (supporters.Count > 0)
            {   // I have supportings!
                return false;
            }
            else if (settings.ShowOnlyManual)
            {   // Centerally stopping showing automatically
                return false;
            }
            else if (tool.SupportType == SupportType.Never)
            {   // You will never want to support this tool
                return false;
            }
            else if (tool.FirstRunDate.AddMinutes(settings.ShowMinutesAfterInstall) > DateTime.Now)
            {   // Installed it too soon
                return false;
            }
            else if (tool.VersionRunDate > tool.FirstRunDate && tool.VersionRunDate.AddMinutes(settings.ShowMinutesAfterNewVersion) > DateTime.Now)
            {   // Installed this version too soon
                return false;
            }
            else if (tool.DisplayDate.AddMinutes(settings.ShowMinutesAfterShown) > DateTime.Now)
            {   // Seen this form to soon
                return false;
            }
            else if (tool.DisplayCount >= settings.ShowAutoRepeatTimes)
            {   // Seen this too many times
                return false;
            }
            else if (tool.SubmittedDate.AddMinutes(settings.ShowMinutesAfterSubmittingButNotCompleted) > DateTime.Now)
            {   // Submitted too soon for JR to handle it
                return false;
            }
            else if (settings.ShowAutoPercentChance < 1)
            {
                return false;
            }
            else
            {
                var rand = random.Next(1, 100);
                return rand <= settings.ShowAutoPercentChance;
            }
        }

        private string GetUrlCorp()
        {
            if (string.IsNullOrEmpty(tools.CompanyName) ||
                string.IsNullOrEmpty(tools.CompanyEmail) ||
                string.IsNullOrEmpty(tools.CompanyCountry) ||
                tool.UsersIndex < 1)
            {
                return null;
            }
            return GenerateUrl(urlcorp, formidcorporate);
        }

        private string GetUrlPersonal(bool contribute)
        {
            if (string.IsNullOrEmpty(tools.PersonalFirstName) ||
                string.IsNullOrEmpty(tools.PersonalLastName) ||
                string.IsNullOrEmpty(tools.PersonalEmail) ||
                string.IsNullOrEmpty(tools.PersonalCountry))
            {
                return null;
            }
            return GenerateUrl(contribute ? urlperscontr : urlpersmonetary, contribute ? formidcontribute : formidpersonal);
        }

        private string GenerateUrl(string template, string form)
        {
            return template
                .Replace("{formid}", form)
                .Replace("{company}", tools.CompanyName)
                .Replace("{invoiceemail}", tools.CompanyEmail)
                .Replace("{companycountry}", tools.CompanyCountry)
                .Replace("{amount}", tool.Amount)
                .Replace("{size}", cmbCompanyUsers.Items[tool.UsersIndex].ToString())
                .Replace("{firstname}", tools.PersonalFirstName)
                .Replace("{lastname}", tools.PersonalLastName)
                .Replace("{email}", tools.PersonalEmail)
                .Replace("{country}", tools.PersonalCountry)
                .Replace("{tool}", tool.ToolName)
                .Replace("{version}", tool.Version.ToString())
                .Replace("{instid}", tools.InstallationId.ToString());
        }

        #endregion Private Methods

        #region Private Event Methods

        private void Supporting_Shown(object sender, EventArgs e)
        {
            sw.Restart();
        }

        private void Supporting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Yes && DialogResult != DialogResult.OK && DialogResult != DialogResult.Retry)
            {
                e.Cancel = true;
            }
            else
            {
                sw.Stop();
                appinsights?.WriteEvent("Supporting-Close", duration: sw.ElapsedMilliseconds);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ctrl_Validating();
            var url = rbPersonal.Checked ? GetUrlPersonal(rbPersonalContributing.Checked) : GetUrlCorp();

            if (!string.IsNullOrEmpty(url))
            {
                if (MessageBoxEx.Show(this, @"You will now be redirected to the website form
to finish your support.
Remember, it has to be submitted at the next step!", "Supporting", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.OK)
                {
                    return;
                }
                tool.SupportType = rbPersonal.Checked ? rbPersonalContributing.Checked ? SupportType.Contribute : SupportType.Personal : SupportType.Company;
                tool.SubmittedDate = DateTime.Now;
                appinsights?.WriteEvent($"Supporting-{tool.SupportType}");
                Process.Start(url);
                DialogResult = DialogResult.Yes;
            }
        }

        private void ctrl_Validating(object sender = null, System.ComponentModel.CancelEventArgs e = null)
        {
            if (sender == null || sender == txtCompanyName)
            {
                tools.CompanyName = txtCompanyName.Text.Trim().Length >= 3 ? txtCompanyName.Text.Trim() : "";
                txtCompanyName.BackColor = string.IsNullOrEmpty(tools.CompanyName) ? settings.clrBgInvalid : settings.clrBgNormal;
            }
            if (sender == null || sender == txtCompanyEmail)
            {
                try
                {
                    tools.CompanyEmail = new MailAddress(txtCompanyEmail.Text).Address.Trim();
                }
                catch { }
                txtCompanyEmail.BackColor = string.IsNullOrEmpty(tools.CompanyEmail) ? settings.clrBgInvalid : settings.clrBgNormal;
            }
            if (sender == null || sender == txtCompanyCountry)
            {
                tools.CompanyCountry = txtCompanyCountry.Text.Trim().Length >= 2 ? txtCompanyCountry.Text.Trim() : "";
                txtCompanyCountry.BackColor = string.IsNullOrEmpty(tools.CompanyCountry) ? settings.clrBgInvalid : settings.clrBgNormal;
            }
            if (sender == null || sender == cmbCompanyUsers)
            {
                tool.UsersIndex = cmbCompanyUsers.SelectedIndex;
                tool.UsersCount = cmbCompanyUsers.Text;
                cmbCompanyUsers.BackColor = tool.UsersIndex < 1 ? settings.clrBgInvalid : settings.clrBgNormal;
            }
            if (sender == null || sender == txtPersonalFirst)
            {
                tools.PersonalFirstName = txtPersonalFirst.Text.Trim().Length >= 1 ? txtPersonalFirst.Text.Trim() : "";
                txtPersonalFirst.BackColor = string.IsNullOrEmpty(tools.PersonalFirstName) ? settings.clrBgInvalid : settings.clrBgNormal;
            }
            if (sender == null || sender == txtPersonalLast)
            {
                tools.PersonalLastName = txtPersonalLast.Text.Trim().Length >= 2 ? txtPersonalLast.Text.Trim() : "";
                txtPersonalLast.BackColor = string.IsNullOrEmpty(tools.PersonalLastName) ? settings.clrBgInvalid : settings.clrBgNormal;
            }
            if (sender == null || sender == txtPersonalEmail)
            {
                try
                {
                    tools.PersonalEmail = new MailAddress(txtPersonalEmail.Text).Address.Trim();
                }
                catch { }
                txtPersonalEmail.BackColor = string.IsNullOrEmpty(tools.PersonalEmail) ? settings.clrBgInvalid : settings.clrBgNormal;
            }
            if (sender == null || sender == txtPersonalCountry)
            {
                tools.PersonalCountry = txtPersonalCountry.Text.Trim().Length >= 2 ? txtPersonalCountry.Text.Trim() : "";
                txtPersonalCountry.BackColor = string.IsNullOrEmpty(tools.PersonalCountry) ? settings.clrBgInvalid : settings.clrBgNormal;
            }
        }

        private void lblLater_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void rbType_CheckedChanged(object sender, EventArgs e)
        {
            SuspendLayout();
            rbCompany.ForeColor = rbPersonal.Checked ? settings.clrFgDimmed : settings.clrFgNormal;
            rbPersonal.ForeColor = rbPersonal.Checked ? settings.clrFgNormal : settings.clrFgDimmed;
            panPersonal.Left = panCorp.Left;
            panPersonal.Top = panCorp.Top;
            panPersonal.Visible = rbPersonal.Checked;
            panCorp.Visible = !panPersonal.Visible;
            btnSubmit.ImageIndex = rbPersonal.Checked ? rbPersonalContributing.Checked ? 2 : 1 : 0;
            ResumeLayout();
        }

        private void rbPersonalMonetary_CheckedChanged(object sender, EventArgs e)
        {
            rbPersonalSupporting.ForeColor = rbPersonalContributing.Checked ? settings.clrFgDimmed : settings.clrFgNormal;
            rbPersonalContributing.ForeColor = rbPersonalContributing.Checked ? settings.clrFgNormal : settings.clrFgDimmed;
            btnSubmit.ImageIndex = rbPersonalContributing.Checked ? 2 : 1;
        }

        private void linkHelping_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UrlUtils.OpenUrl(sender);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            panInfo.Left = 50;
            panInfo.Top = 25;
            panInfo.Visible = !panInfo.Visible;
        }

        private void btnInfoClose_Click(object sender, EventArgs e)
        {
            panInfo.Visible = false;
        }

        private void panInfo_VisibleChanged(object sender, EventArgs e)
        {
            if (panInfo.Visible)
            {
                swInfo.Restart();
            }
            else
            {
                swInfo.Stop();
                appinsights?.WriteEvent("Supporting-Info", duration: swInfo.ElapsedMilliseconds);
            }
        }

        private void laterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void neverWillBeSupportingThisToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tool.SupportType = SupportType.Never;
            DialogResult = DialogResult.Yes;
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                rb.ForeColor = settings.clrFgNormal;
            }
            if (sender is Label lbl)
            {
                lbl.ForeColor = settings.clrFgNormal;
            }
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                if (!rb.Checked)
                {
                    rb.ForeColor = settings.clrFgDimmed;
                }
            }
            else if (sender is Label lbl)
            {
                lbl.ForeColor = settings.clrFgDimmed;
            }
        }

        private void lblAlready_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("Thanks! ❤️", "Supporting");
        }

        #endregion Private Event Methods
    }

    public class ToolSettings
    {
        private const string ToolSettingsURL = "https://jonasr.app/xtb/toolsettings.xml";

        public bool ShowOnlyManual = true;  // false
        public bool ContributionCounts = true;  // false
        public int ShowMinutesAfterInstall = int.MaxValue;    // 60
        public int ShowMinutesAfterNewVersion = int.MaxValue; // 120
        public int ShowMinutesAfterShown = int.MaxValue; // 2880m / 48h / 2d
        public int ShowMinutesAfterSubmittingButNotCompleted = int.MaxValue; // 2880m / 48h / 2d
        public int ShowAutoPercentChance = 0;   // 25 (0-100)
        public int ShowAutoRepeatTimes = 0; // 10
        public string ColorFgNormal { get; set; } = "FFFFFF00";
        public string ColorFgDimmed { get; set; } = "FFD2B48C";
        public string ColorBgNormal { get; set; } = "FF0063FF";
        public string ColorBgInvalid { get; set; } = "FF6495ED";

        public Color clrFgNormal => Color.FromArgb(int.Parse(ColorFgNormal, System.Globalization.NumberStyles.HexNumber));
        public Color clrFgDimmed => Color.FromArgb(int.Parse(ColorFgDimmed, System.Globalization.NumberStyles.HexNumber));
        public Color clrBgNormal => Color.FromArgb(int.Parse(ColorBgNormal, System.Globalization.NumberStyles.HexNumber));
        public Color clrBgInvalid => Color.FromArgb(int.Parse(ColorBgInvalid, System.Globalization.NumberStyles.HexNumber));

        public string HelpTitle { get; set; } = "This is a Community Thing.";
        public string HelpLink { get; set; } = "https://jonasr.app/helping/";

        public string HelpText { get; set; } = @"Some of us in the Power Platform Community are creating tools.
Some contribute by sharing new ideas, finding problems, and documenting; some are even solving our bugs.
Thousands and thousands in this community are only consumers. Just using open-source tools. It's very similar to just watching TV. Do you pay for channels, Netflix, Amazon Prime, Spotify etc...?
To be part of the community, you can now pay instead.

Especially when you work in a big corporation, exploiting free tools only to increase your income, you have a responsibility to participate actively in the community - or pay.
It's good to be able to sleep with a good conscience. Right?

There should be a license called ""Conscienceware"".
But technically, it is simply free to use them.

If you say that you are not part of the community, that is incorrect—just using these tools makes you a part of it.

You and your company can now more formally support tools rather than just donating via PayPal or 'Buy Me a Coffee.'

Supporting is not just giving money; it means that you or your company know you have gained in time and improved your quality by using these tools. If you get something and want to give back—support the development and maintenance of the tools.

You will receive an official receipt immediately and, if needed, an invoice. Supporting can be done with a credit card. Other options will be available depending on your location. Stripe handles the payment.

To read more about my thoughts, click the link below!";

        private ToolSettings()
        { }

        public static ToolSettings Get() => new Uri(ToolSettingsURL).DownloadXml(new ToolSettings());
    }

    public class Supporters : List<Supporter>
    {
        private const string SupportersURL = "https://jonasr.app/xtb/supporters.xml";

        private Supporters()
        { }

        public static Supporters DownloadMy(Guid InstallationId, string toolname, bool contributionCounts)
        {
            var result = new Uri(SupportersURL).DownloadXml(new Supporters());
            result.Where(s =>
                s.InstallationId != InstallationId ||
                s.ToolName != toolname ||
                s.SupportType == SupportType.None ||
                (!contributionCounts && s.SupportType == SupportType.Contribute))
                .ToList().ForEach(s => result.Remove(s));
            return result;
        }
    }

    public class Supporter
    {
        public Guid InstallationId { get; set; }
        public string ToolName { get; set; }
        public SupportType SupportType { get; set; }
    }

    public class RappenXTB
    {
        public Guid InstallationId { get; set; } = Guid.Empty;
        public List<Tool> Tools { get; set; } = new List<Tool>();
        public string PersonalFirstName { get; set; }
        public string PersonalLastName { get; set; }
        public string PersonalEmail { get; set; }
        public string PersonalCountry { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyCountry { get; set; }

        private RappenXTB()
        { }

        public static RappenXTB Load()
        {
            string path = Path.Combine(Paths.SettingsPath, "Rappen.XTB.Tools.xml");
            var result = new RappenXTB();
            if (File.Exists(path))
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(path);
                    result = (RappenXTB)XmlSerializerHelper.Deserialize(xmlDocument.OuterXml, typeof(RappenXTB));
                }
                catch { }
            }
            if (result.InstallationId.Equals(Guid.Empty))
            {
                result.InstallationId = InstallationInfo.Instance.InstallationId;
            }
            return result;
        }

        public void Save()
        {
            if (!Directory.Exists(Paths.SettingsPath))
            {
                Directory.CreateDirectory(Paths.SettingsPath);
            }
            string path = Path.Combine(Paths.SettingsPath, "Rappen.XTB.Tools.xml");
            XmlSerializerHelper.SerializeToFile(this, path);
        }

        public Tool this[string name]
        {
            get
            {
                if (!Tools.Any(t => t.ToolName == name))
                {
                    Tools.Add(new Tool { ToolName = name });
                }
                return Tools.FirstOrDefault(t => t.ToolName == name);
            }
        }
    }

    public class Tool
    {
        private Version version;

        public string ToolName { get; set; }

        [XmlIgnore]
        public Version Version
        {
            get => version;
            set
            {
                if (value != version)
                {
                    DisplayCount = 0;
                }
                version = value;
            }
        }

        public string VersionStr
        {
            get => version.ToString();
            set { version = new Version(value ?? "0.0.0.0"); }
        }

        public DateTime FirstRunDate { get; set; } = DateTime.Now;
        public DateTime VersionRunDate { get; set; }
        public DateTime DisplayDate { get; set; } = DateTime.MinValue;
        public int DisplayCount { get; set; } = 0;
        public DateTime SubmittedDate { get; set; }
        public SupportType SupportType { get; set; } = SupportType.None;
        public int UsersIndex { get; set; }
        public string UsersCount { get; set; }

        public string Amount
        {
            get
            {
                switch (UsersIndex)
                {
                    case 1: return "X-Small";
                    case 2: return "Small";
                    case 4: return "Large";
                    case 5: return "X-Large";
                    default: return "Medium";
                }
            }
        }
    }

    public enum SupportType
    {
        None,
        Personal,
        Company,
        Contribute,
        Never
    }
}