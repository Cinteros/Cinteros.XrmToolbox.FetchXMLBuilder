﻿using Rappen.XRM.Helpers.FetchXML;
using Rappen.XTB.FetchXmlBuilder.DockControls;
using Rappen.XTB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Rappen.XTB.FetchXmlBuilder.Controls
{
    public partial class fetchControl : FetchXmlElementControlBase
    {
        public fetchControl() : this(null, null, null)
        {
        }

        public fetchControl(Dictionary<string, string> collection, FetchXmlBuilder fetchXmlBuilder, TreeBuilderControl tree)
        {
            InitializeComponent();
            InitializeFXB(collection, fetchXmlBuilder, tree, null);
        }

        protected override void PopulateControls()
        {
            base.PopulateControls();

            dataSourceComboBox.Items.Add("");
            dataSourceComboBox.Items.Add("archive");
        }

        private void textPagingCookie_Leave(object sender, EventArgs e)
        {
            textPagingCookie.Text = textPagingCookie.Text.Replace("&lt;", "<").Replace("&gt;", ">").Replace("&quot;", "\"");
        }

        protected override ControlValidationResult ValidateControl(Control control)
        {
            if (control == textTop)
            {
                if (!string.IsNullOrEmpty(textTop.Text) && !int.TryParse(textTop.Text, out int p))
                {
                    return new ControlValidationResult(ControlValidationLevel.Error, "Top must be a whole number");
                }
            }
            if (control == textPageSize)
            {
                if (!string.IsNullOrEmpty(textPageSize.Text) && !int.TryParse(textPageSize.Text, out int p))
                {
                    return new ControlValidationResult(ControlValidationLevel.Error, "Page Size must be a whole number");
                }
            }
            if (control == textPage)
            {
                if (!string.IsNullOrEmpty(textPage.Text) && !int.TryParse(textPage.Text, out int p))
                {
                    return new ControlValidationResult(ControlValidationLevel.Error, "Page must be a whole number");
                }
            }
            return base.ValidateControl(control);
        }

        private void helpIcon_Click(object sender, EventArgs e)
        {
            fxb.OpenUrl(sender);
        }

        public override void Focus()
        {
            textTop.Focus();
        }

        private void cmbOptionsAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var option = cmbOptionsAdd.Text;
            cmbOptionsAdd.SelectedIndex = -1;
            if (string.IsNullOrWhiteSpace(option))
            {
                return;
            }
            if (txtOptions.Text.Contains(option))
            {
                MessageBox.Show($"Options already has {option}. Only one can be added.");
                return;
            }
            var ops = txtOptions.Text.Split(',').ToList();
            ops.Add(option);
            txtOptions.Text = string.Join(",", ops.Where(o => !string.IsNullOrWhiteSpace(o)));
        }
    }
}