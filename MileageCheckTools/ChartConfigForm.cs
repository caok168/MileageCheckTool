
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MileageCheckTools
{
    public partial class ChartConfigForm : Form
    {
        private ChartConfig _chartConfigData = null;
        public ChartConfigForm(ChartConfig config)
        {
            InitializeComponent();
            _chartConfigData = config;
        }

        private void ChartConfigForm_Load(object sender, EventArgs e)
        {
            txtTitle.Text = _chartConfigData.ChartTitle;
            labFontTitle.Text = _chartConfigData.ChartTitleFont.Name + "-" + _chartConfigData.ChartTitleFont.Size;

            txtAxesY.Text = _chartConfigData.AxesYTitle;
            labFontAxesY.Text = _chartConfigData.AxesYFont.Name + "-" + _chartConfigData.AxesYFont.Size;
            nudAxesYMin.Value = (int)_chartConfigData.AxesYMin;
            nudAxesYStep.Value = (int)_chartConfigData.AxesYStep;
            nudAxesYMax.Value = (int)_chartConfigData.AxesYMax;

            txtAxesX.Text = _chartConfigData.AxesXTitle;
            labFontAxesX.Text = _chartConfigData.AxesXFont.Name + "-" + _chartConfigData.AxesXFont.Size;
            nudAxesXMin.Value = (int)_chartConfigData.AxesXMin;
            nudAxesXStep.Value = (int)_chartConfigData.AxesXStep;
            nudAxesXMax.Value = (int)_chartConfigData.AxesXMax;
        }

        private void btnTiltleFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                _chartConfigData.ChartTitleFont = fontDialog.Font;
                labFontTitle.Text = _chartConfigData.ChartTitleFont.Name + "-" + _chartConfigData.ChartTitleFont.Size;
            }
        }

        private void btnAxesYFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                _chartConfigData.AxesYFont = fontDialog.Font;
                labFontAxesY.Text = _chartConfigData.AxesYFont.Name + "-" + _chartConfigData.AxesYFont.Size;
            }
        }

        private void btnAxesXFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                _chartConfigData.AxesXFont = fontDialog.Font;
                labFontAxesX.Text = _chartConfigData.AxesXFont.Name + "-" + _chartConfigData.AxesXFont.Size;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            _chartConfigData.ChartTitle = txtTitle.Text;

            _chartConfigData.AxesYTitle = txtAxesY.Text;
            _chartConfigData.AxesYMin = (int)nudAxesYMin.Value;
            _chartConfigData.AxesYStep = (int)nudAxesYStep.Value;
            _chartConfigData.AxesYMax = (int)nudAxesYMax.Value;

            _chartConfigData.AxesXTitle = txtAxesX.Text;
            _chartConfigData.AxesXMin = (int)nudAxesXMin.Value;
            _chartConfigData.AxesXStep = (int)nudAxesXStep.Value;
            _chartConfigData.AxesXMax = (int)nudAxesXMax.Value;
            this.Tag = _chartConfigData;
            this.Close();
        }
    }
}
