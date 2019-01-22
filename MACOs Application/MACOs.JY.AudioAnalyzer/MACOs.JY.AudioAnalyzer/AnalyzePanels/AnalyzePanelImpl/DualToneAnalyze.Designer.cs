﻿namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    partial class DualToneAnalyze
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_channelSelect = new System.Windows.Forms.GroupBox();
            this.comboBox_imdType = new System.Windows.Forms.ComboBox();
            this.label_imdType = new System.Windows.Forms.Label();
            this.label_sampleRate = new System.Windows.Forms.Label();
            this.comboBox_aoChannel = new System.Windows.Forms.ComboBox();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.label_aoChannel = new System.Windows.Forms.Label();
            this.comboBox_testChannel = new System.Windows.Forms.ComboBox();
            this.label_testChannel = new System.Windows.Forms.Label();
            this.groupBox_waveConfig = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_waveConfig = new System.Windows.Forms.TableLayoutPanel();
            this.label_Waveform = new System.Windows.Forms.Label();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
            this.label_analyzeResult = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_spectrum = new System.Windows.Forms.Label();
            this.easyChart_spectrum = new SeeSharpTools.JY.GUI.EasyChart();
            this.easyChart_testWaveform = new SeeSharpTools.JY.GUI.EasyChart();
            this.groupBox_channelSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.groupBox_waveConfig.SuspendLayout();
            this.groupBox_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_channelSelect
            // 
            this.groupBox_channelSelect.Controls.Add(this.comboBox_imdType);
            this.groupBox_channelSelect.Controls.Add(this.label_imdType);
            this.groupBox_channelSelect.Controls.Add(this.label_sampleRate);
            this.groupBox_channelSelect.Controls.Add(this.comboBox_aoChannel);
            this.groupBox_channelSelect.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox_channelSelect.Controls.Add(this.label_aoChannel);
            this.groupBox_channelSelect.Controls.Add(this.comboBox_testChannel);
            this.groupBox_channelSelect.Controls.Add(this.label_testChannel);
            this.groupBox_channelSelect.Location = new System.Drawing.Point(661, 321);
            this.groupBox_channelSelect.Name = "groupBox_channelSelect";
            this.groupBox_channelSelect.Size = new System.Drawing.Size(579, 111);
            this.groupBox_channelSelect.TabIndex = 3;
            this.groupBox_channelSelect.TabStop = false;
            this.groupBox_channelSelect.Text = "Channel Select";
            // 
            // comboBox_imdType
            // 
            this.comboBox_imdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_imdType.FormattingEnabled = true;
            this.comboBox_imdType.Location = new System.Drawing.Point(438, 76);
            this.comboBox_imdType.Name = "comboBox_imdType";
            this.comboBox_imdType.Size = new System.Drawing.Size(105, 20);
            this.comboBox_imdType.TabIndex = 13;
            // 
            // label_imdType
            // 
            this.label_imdType.AutoSize = true;
            this.label_imdType.Location = new System.Drawing.Point(340, 79);
            this.label_imdType.Name = "label_imdType";
            this.label_imdType.Size = new System.Drawing.Size(53, 12);
            this.label_imdType.TabIndex = 12;
            this.label_imdType.Text = "IMD Type";
            // 
            // label_sampleRate
            // 
            this.label_sampleRate.AutoSize = true;
            this.label_sampleRate.Location = new System.Drawing.Point(340, 36);
            this.label_sampleRate.Name = "label_sampleRate";
            this.label_sampleRate.Size = new System.Drawing.Size(65, 12);
            this.label_sampleRate.TabIndex = 11;
            this.label_sampleRate.Text = "SampleRate";
            // 
            // comboBox_aoChannel
            // 
            this.comboBox_aoChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_aoChannel.FormattingEnabled = true;
            this.comboBox_aoChannel.Location = new System.Drawing.Point(160, 33);
            this.comboBox_aoChannel.Name = "comboBox_aoChannel";
            this.comboBox_aoChannel.Size = new System.Drawing.Size(105, 20);
            this.comboBox_aoChannel.TabIndex = 5;
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(438, 32);
            this.numericUpDown_sampleRate.Maximum = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Name = "numericUpDown_sampleRate";
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(105, 21);
            this.numericUpDown_sampleRate.TabIndex = 10;
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            // 
            // label_aoChannel
            // 
            this.label_aoChannel.AutoSize = true;
            this.label_aoChannel.Location = new System.Drawing.Point(47, 36);
            this.label_aoChannel.Name = "label_aoChannel";
            this.label_aoChannel.Size = new System.Drawing.Size(89, 12);
            this.label_aoChannel.TabIndex = 4;
            this.label_aoChannel.Text = "Output Channel";
            // 
            // comboBox_testChannel
            // 
            this.comboBox_testChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_testChannel.FormattingEnabled = true;
            this.comboBox_testChannel.Location = new System.Drawing.Point(160, 76);
            this.comboBox_testChannel.Name = "comboBox_testChannel";
            this.comboBox_testChannel.Size = new System.Drawing.Size(105, 20);
            this.comboBox_testChannel.TabIndex = 3;
            // 
            // label_testChannel
            // 
            this.label_testChannel.AutoSize = true;
            this.label_testChannel.Location = new System.Drawing.Point(47, 79);
            this.label_testChannel.Name = "label_testChannel";
            this.label_testChannel.Size = new System.Drawing.Size(77, 12);
            this.label_testChannel.TabIndex = 2;
            this.label_testChannel.Text = "Test Channel";
            // 
            // groupBox_waveConfig
            // 
            this.groupBox_waveConfig.Controls.Add(this.tableLayoutPanel_waveConfig);
            this.groupBox_waveConfig.Location = new System.Drawing.Point(661, 438);
            this.groupBox_waveConfig.Name = "groupBox_waveConfig";
            this.groupBox_waveConfig.Size = new System.Drawing.Size(579, 185);
            this.groupBox_waveConfig.TabIndex = 4;
            this.groupBox_waveConfig.TabStop = false;
            this.groupBox_waveConfig.Text = "Wave Configuration";
            // 
            // tableLayoutPanel_waveConfig
            // 
            this.tableLayoutPanel_waveConfig.ColumnCount = 1;
            this.tableLayoutPanel_waveConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_waveConfig.Location = new System.Drawing.Point(15, 40);
            this.tableLayoutPanel_waveConfig.Name = "tableLayoutPanel_waveConfig";
            this.tableLayoutPanel_waveConfig.RowCount = 1;
            this.tableLayoutPanel_waveConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_waveConfig.Size = new System.Drawing.Size(550, 120);
            this.tableLayoutPanel_waveConfig.TabIndex = 0;
            // 
            // label_Waveform
            // 
            this.label_Waveform.AutoSize = true;
            this.label_Waveform.Location = new System.Drawing.Point(63, 29);
            this.label_Waveform.Name = "label_Waveform";
            this.label_Waveform.Size = new System.Drawing.Size(83, 12);
            this.label_Waveform.TabIndex = 7;
            this.label_Waveform.Text = "Test Waveform";
            // 
            // groupBox_result
            // 
            this.groupBox_result.Controls.Add(this.label_analyzeResult);
            this.groupBox_result.Controls.Add(this.textBox_result);
            this.groupBox_result.Controls.Add(this.label_spectrum);
            this.groupBox_result.Controls.Add(this.easyChart_spectrum);
            this.groupBox_result.Location = new System.Drawing.Point(60, 321);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(547, 302);
            this.groupBox_result.TabIndex = 10;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "Test result";
            // 
            // label_analyzeResult
            // 
            this.label_analyzeResult.AutoSize = true;
            this.label_analyzeResult.Location = new System.Drawing.Point(430, 23);
            this.label_analyzeResult.Name = "label_analyzeResult";
            this.label_analyzeResult.Size = new System.Drawing.Size(89, 12);
            this.label_analyzeResult.TabIndex = 12;
            this.label_analyzeResult.Text = "Analyze Result";
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.Color.Silver;
            this.textBox_result.Enabled = false;
            this.textBox_result.ForeColor = System.Drawing.Color.Green;
            this.textBox_result.Location = new System.Drawing.Point(427, 39);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(108, 256);
            this.textBox_result.TabIndex = 11;
            // 
            // label_spectrum
            // 
            this.label_spectrum.AutoSize = true;
            this.label_spectrum.Location = new System.Drawing.Point(15, 25);
            this.label_spectrum.Name = "label_spectrum";
            this.label_spectrum.Size = new System.Drawing.Size(113, 12);
            this.label_spectrum.TabIndex = 11;
            this.label_spectrum.Text = "Test Wave Specturm";
            // 
            // easyChart_spectrum
            // 
            this.easyChart_spectrum.AxisYMax = double.NaN;
            this.easyChart_spectrum.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_spectrum.ChartAreaBackColor = System.Drawing.Color.DimGray;
            this.easyChart_spectrum.EasyChartBackColor = System.Drawing.Color.DarkGray;
            this.easyChart_spectrum.FixAxisX = false;
            this.easyChart_spectrum.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_spectrum.LegendVisible = false;
            this.easyChart_spectrum.Location = new System.Drawing.Point(12, 39);
            this.easyChart_spectrum.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_spectrum.MajorGridEnabled = true;
            this.easyChart_spectrum.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_spectrum.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_spectrum.MinorGridEnabled = false;
            this.easyChart_spectrum.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart_spectrum.Name = "easyChart_spectrum";
            this.easyChart_spectrum.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_spectrum.SeriesNames = new string[] {
        "Source Waveform",
        "Test Waveform",
        "Series3",
        "Series4",
        "Series5",
        "Series6",
        "Series7",
        "Series8",
        "Series9",
        "Series10",
        "Series11",
        "Series12",
        "Series13",
        "Series14",
        "Series15",
        "Series16",
        "Series17",
        "Series18",
        "Series19",
        "Series20",
        "Series21",
        "Series22",
        "Series23",
        "Series24",
        "Series25",
        "Series26",
        "Series27",
        "Series28",
        "Series29",
        "Series30",
        "Series31",
        "Series32"};
            this.easyChart_spectrum.Size = new System.Drawing.Size(407, 256);
            this.easyChart_spectrum.TabIndex = 11;
            this.easyChart_spectrum.XAxisLogarithmic = false;
            this.easyChart_spectrum.YAutoEnable = true;
            this.easyChart_spectrum.YAxisLogarithmic = false;
            // 
            // easyChart_testWaveform
            // 
            this.easyChart_testWaveform.AxisYMax = double.NaN;
            this.easyChart_testWaveform.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_testWaveform.ChartAreaBackColor = System.Drawing.Color.DimGray;
            this.easyChart_testWaveform.EasyChartBackColor = System.Drawing.Color.DarkGray;
            this.easyChart_testWaveform.FixAxisX = false;
            this.easyChart_testWaveform.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_testWaveform.LegendVisible = false;
            this.easyChart_testWaveform.Location = new System.Drawing.Point(65, 43);
            this.easyChart_testWaveform.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_testWaveform.MajorGridEnabled = true;
            this.easyChart_testWaveform.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_testWaveform.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_testWaveform.MinorGridEnabled = false;
            this.easyChart_testWaveform.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart_testWaveform.Name = "easyChart_testWaveform";
            this.easyChart_testWaveform.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_testWaveform.SeriesNames = new string[] {
        "Series1",
        "Series2",
        "Series3",
        "Series4",
        "Series5",
        "Series6",
        "Series7",
        "Series8",
        "Series9",
        "Series10",
        "Series11",
        "Series12",
        "Series13",
        "Series14",
        "Series15",
        "Series16",
        "Series17",
        "Series18",
        "Series19",
        "Series20",
        "Series21",
        "Series22",
        "Series23",
        "Series24",
        "Series25",
        "Series26",
        "Series27",
        "Series28",
        "Series29",
        "Series30",
        "Series31",
        "Series32"};
            this.easyChart_testWaveform.Size = new System.Drawing.Size(1175, 259);
            this.easyChart_testWaveform.TabIndex = 11;
            this.easyChart_testWaveform.XAxisLogarithmic = false;
            this.easyChart_testWaveform.YAutoEnable = true;
            this.easyChart_testWaveform.YAxisLogarithmic = false;
            // 
            // DualToneAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.easyChart_testWaveform);
            this.Controls.Add(this.groupBox_result);
            this.Controls.Add(this.label_Waveform);
            this.Controls.Add(this.groupBox_waveConfig);
            this.Controls.Add(this.groupBox_channelSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "DualToneAnalyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SteppedSineWaveCrossTalkAnalyze";
            this.Load += new System.EventHandler(this.DualToneAnalyze_Load);
            this.groupBox_channelSelect.ResumeLayout(false);
            this.groupBox_channelSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.groupBox_waveConfig.ResumeLayout(false);
            this.groupBox_result.ResumeLayout(false);
            this.groupBox_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_channelSelect;
        private System.Windows.Forms.ComboBox comboBox_testChannel;
        private System.Windows.Forms.Label label_testChannel;
        private System.Windows.Forms.GroupBox groupBox_waveConfig;
        private System.Windows.Forms.Label label_Waveform;
        private System.Windows.Forms.ComboBox comboBox_aoChannel;
        private System.Windows.Forms.Label label_aoChannel;
        private System.Windows.Forms.Label label_sampleRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.GroupBox groupBox_result;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_spectrum;
        private System.Windows.Forms.Label label_spectrum;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_analyzeResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_waveConfig;
        private System.Windows.Forms.ComboBox comboBox_imdType;
        private System.Windows.Forms.Label label_imdType;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_testWaveform;
    }
}