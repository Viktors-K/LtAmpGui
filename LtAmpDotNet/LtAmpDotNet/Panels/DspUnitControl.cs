﻿using LtAmpDotNet.Base;
using LtAmpDotNet.Lib.Model.Preset;
using LtAmpDotNet.Lib.Model.Profile;
using LtAmpDotNet.Panels.DspUnitControlViews;
using LtAmpDotNet.ViewModels;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LtAmpDotNet.Panels
{
    public partial class DspUnitControl : UserControl
    {
        private DspUnitControlViewBase unitControl;
        private DspUnitControlViewModel viewModel = new DspUnitControlViewModel();

        public DspUnitControlViewModel ViewModel
        {
            get => viewModel;
            set
            {
                viewModel = value;
                if (viewModel != null)
                {
                    unitControl.Node = viewModel.Node;
                    viewModel.ValueChanged += viewModel_ValueChanged;
                }
            }
        }

        public DspUnitControl()
        {
            InitializeComponent();
            unitControl = new JsonDspUnitControlView();
            panelControl.Controls.Add(unitControl);
            
        }

        private void viewModel_ValueChanged(object? sender, ValueChangedEventArgs e)
        {
            unitControl.Node = viewModel.Node;
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void checkBoxBypass_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBypass.ForeColor = checkBoxBypass.Checked ? Color.Green : Color.FromKnownColor(KnownColor.ControlText);
            ViewModel.Bypass = checkBoxBypass.Checked;
            unitControl.Refresh();
        }
    }
}
