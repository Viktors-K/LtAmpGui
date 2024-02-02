﻿using LtAmpDotNet.Base;
using LtAmpDotNet.Lib.Model.Preset;
using LtAmpDotNet.ViewModels;

namespace LtAmpDotNet.Panels.DspUnitControlViews
{
    public partial class PropertyGridUnitControlView : DspUnitControlViewBase, IDspUnitControlView
    {

        private DspUnitControlViewModel _viewModel = new DspUnitControlViewModel();

        public new DspUnitControlViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                _viewModel = value;
                propertyGrid1.SelectedObject = new ParameterPropertyGridAdapter(_viewModel?.Parameters);
            }
        }
        public PropertyGridUnitControlView() : base()
        {
            InitializeComponent();
        }

        public override Node Node
        {
            get => _viewModel.Node;
            set
            {
                _viewModel.Node = value;
                Refresh();
            }
        }

        public override void Refresh()
        {
            propertyGrid1.SelectedObject = new ParameterPropertyGridAdapter(_viewModel?.Parameters);
            propertyGrid1.Refresh();
            toolStrip1.Visible = false;
        }

        private void toolStripButtonApply_Click(object sender, EventArgs e)
        {
            try
            {
                OnChangesApplied(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot apply json: {ex.Message}", "Error applying node", MessageBoxButtons.OK);
            }
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            Refresh();
            toolStrip1.Visible = false;
        }

        private void propertyGrid1_ValueChanged(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
        }
    }
}
