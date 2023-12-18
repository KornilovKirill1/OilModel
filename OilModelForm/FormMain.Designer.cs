
namespace OilModelForm
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.toolStripUpperPanel = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonFileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonReference = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDone = new System.Windows.Forms.ToolStripButton();
            this.panelInput = new System.Windows.Forms.Panel();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxPz = new System.Windows.Forms.TextBox();
            this.labelPz = new System.Windows.Forms.Label();
            this.textBoxPpl = new System.Windows.Forms.TextBox();
            this.labelPpl = new System.Windows.Forms.Label();
            this.textBoxRc = new System.Windows.Forms.TextBox();
            this.labelRc = new System.Windows.Forms.Label();
            this.textBoxKv = new System.Windows.Forms.TextBox();
            this.labelKv = new System.Windows.Forms.Label();
            this.textBoxKh = new System.Windows.Forms.TextBox();
            this.labelKh = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.labelM = new System.Windows.Forms.Label();
            this.textBoxRk = new System.Windows.Forms.TextBox();
            this.labelRk = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.labelH = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.labelL = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxGeneral = new System.Windows.Forms.TextBox();
            this.textBoxBorisov = new System.Windows.Forms.TextBox();
            this.toolTipInputData = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripUpperPanel.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripUpperPanel
            // 
            this.toolStripUpperPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInfo,
            this.toolStripDropDownButtonFileButton,
            this.toolStripButtonReference,
            this.toolStripButtonDone});
            this.toolStripUpperPanel.Location = new System.Drawing.Point(0, 0);
            this.toolStripUpperPanel.Name = "toolStripUpperPanel";
            this.toolStripUpperPanel.Size = new System.Drawing.Size(644, 25);
            this.toolStripUpperPanel.TabIndex = 0;
            this.toolStripUpperPanel.Text = "toolStrip1";
            // 
            // toolStripButtonInfo
            // 
            this.toolStripButtonInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInfo.Image")));
            this.toolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInfo.Name = "toolStripButtonInfo";
            this.toolStripButtonInfo.Size = new System.Drawing.Size(86, 22);
            this.toolStripButtonInfo.Text = "О программе";
            this.toolStripButtonInfo.Click += new System.EventHandler(this.toolStripButtonInfo_Click);
            // 
            // toolStripDropDownButtonFileButton
            // 
            this.toolStripDropDownButtonFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.toolStripDropDownButtonFileButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFileButton.Image")));
            this.toolStripDropDownButtonFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFileButton.Name = "toolStripDropDownButtonFileButton";
            this.toolStripDropDownButtonFileButton.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButtonFileButton.Text = "Файл";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.файлToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // toolStripButtonReference
            // 
            this.toolStripButtonReference.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonReference.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReference.Image")));
            this.toolStripButtonReference.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReference.Name = "toolStripButtonReference";
            this.toolStripButtonReference.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonReference.Text = "Справка";
            this.toolStripButtonReference.Click += new System.EventHandler(this.toolStripButtonReference_Click);
            // 
            // toolStripButtonDone
            // 
            this.toolStripButtonDone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDone.Image = global::OilModelForm.Properties.Resources.accept;
            this.toolStripButtonDone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDone.Name = "toolStripButtonDone";
            this.toolStripButtonDone.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDone.Text = "Выполнить";
            this.toolStripButtonDone.Click += new System.EventHandler(this.toolStripButtonDone_Click);
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelInput.Controls.Add(this.groupBoxInput);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput.Location = new System.Drawing.Point(0, 25);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(5);
            this.panelInput.Size = new System.Drawing.Size(190, 476);
            this.panelInput.TabIndex = 1;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxPz);
            this.groupBoxInput.Controls.Add(this.labelPz);
            this.groupBoxInput.Controls.Add(this.textBoxPpl);
            this.groupBoxInput.Controls.Add(this.labelPpl);
            this.groupBoxInput.Controls.Add(this.textBoxRc);
            this.groupBoxInput.Controls.Add(this.labelRc);
            this.groupBoxInput.Controls.Add(this.textBoxKv);
            this.groupBoxInput.Controls.Add(this.labelKv);
            this.groupBoxInput.Controls.Add(this.textBoxKh);
            this.groupBoxInput.Controls.Add(this.labelKh);
            this.groupBoxInput.Controls.Add(this.textBoxM);
            this.groupBoxInput.Controls.Add(this.labelM);
            this.groupBoxInput.Controls.Add(this.textBoxRk);
            this.groupBoxInput.Controls.Add(this.labelRk);
            this.groupBoxInput.Controls.Add(this.textBoxH);
            this.groupBoxInput.Controls.Add(this.labelH);
            this.groupBoxInput.Controls.Add(this.textBoxN);
            this.groupBoxInput.Controls.Add(this.labelN);
            this.groupBoxInput.Controls.Add(this.textBoxL);
            this.groupBoxInput.Controls.Add(this.labelL);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.Location = new System.Drawing.Point(5, 5);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(180, 466);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод значений:";
            // 
            // textBoxPz
            // 
            this.textBoxPz.Location = new System.Drawing.Point(10, 433);
            this.textBoxPz.Name = "textBoxPz";
            this.textBoxPz.Size = new System.Drawing.Size(160, 20);
            this.textBoxPz.TabIndex = 19;
            this.toolTipInputData.SetToolTip(this.textBoxPz, "Забойное давление");
            this.textBoxPz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxL_KeyPress);
            // 
            // labelPz
            // 
            this.labelPz.AutoSize = true;
            this.labelPz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPz.Location = new System.Drawing.Point(13, 414);
            this.labelPz.Name = "labelPz";
            this.labelPz.Size = new System.Drawing.Size(63, 16);
            this.labelPz.TabIndex = 18;
            this.labelPz.Text = "Pз, МПа:";
            // 
            // textBoxPpl
            // 
            this.textBoxPpl.Location = new System.Drawing.Point(10, 389);
            this.textBoxPpl.Name = "textBoxPpl";
            this.textBoxPpl.Size = new System.Drawing.Size(160, 20);
            this.textBoxPpl.TabIndex = 17;
            this.toolTipInputData.SetToolTip(this.textBoxPpl, "Пластовое давление");
            this.textBoxPpl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxL_KeyPress);
            // 
            // labelPpl
            // 
            this.labelPpl.AutoSize = true;
            this.labelPpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPpl.Location = new System.Drawing.Point(13, 368);
            this.labelPpl.Name = "labelPpl";
            this.labelPpl.Size = new System.Drawing.Size(71, 16);
            this.labelPpl.TabIndex = 16;
            this.labelPpl.Text = "Pпл, МПа:";
            // 
            // textBoxRc
            // 
            this.textBoxRc.Location = new System.Drawing.Point(10, 345);
            this.textBoxRc.Name = "textBoxRc";
            this.textBoxRc.Size = new System.Drawing.Size(160, 20);
            this.textBoxRc.TabIndex = 15;
            this.toolTipInputData.SetToolTip(this.textBoxRc, "Радиус перфорационного отверстия");
            this.textBoxRc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxL_KeyPress);
            // 
            // labelRc
            // 
            this.labelRc.AutoSize = true;
            this.labelRc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRc.Location = new System.Drawing.Point(13, 326);
            this.labelRc.Name = "labelRc";
            this.labelRc.Size = new System.Drawing.Size(43, 16);
            this.labelRc.TabIndex = 14;
            this.labelRc.Text = "Rc, м:";
            // 
            // textBoxKv
            // 
            this.textBoxKv.Location = new System.Drawing.Point(10, 301);
            this.textBoxKv.Name = "textBoxKv";
            this.textBoxKv.Size = new System.Drawing.Size(160, 20);
            this.textBoxKv.TabIndex = 13;
            this.toolTipInputData.SetToolTip(this.textBoxKv, "Проницаемость в вертикальном направлении");
            this.textBoxKv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxL_KeyPress);
            // 
            // labelKv
            // 
            this.labelKv.AutoSize = true;
            this.labelKv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKv.Location = new System.Drawing.Point(13, 282);
            this.labelKv.Name = "labelKv";
            this.labelKv.Size = new System.Drawing.Size(50, 16);
            this.labelKv.TabIndex = 12;
            this.labelKv.Text = "Kv, мД:";
            // 
            // textBoxKh
            // 
            this.textBoxKh.Location = new System.Drawing.Point(10, 257);
            this.textBoxKh.Name = "textBoxKh";
            this.textBoxKh.Size = new System.Drawing.Size(160, 20);
            this.textBoxKh.TabIndex = 11;
            this.toolTipInputData.SetToolTip(this.textBoxKh, "Проницаемость в горизонтальном направлении");
            this.textBoxKh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxL_KeyPress);
            // 
            // labelKh
            // 
            this.labelKh.AutoSize = true;
            this.labelKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKh.Location = new System.Drawing.Point(13, 238);
            this.labelKh.Name = "labelKh";
            this.labelKh.Size = new System.Drawing.Size(50, 16);
            this.labelKh.TabIndex = 10;
            this.labelKh.Text = "Kh, мД:";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(10, 213);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(160, 20);
            this.textBoxM.TabIndex = 9;
            this.toolTipInputData.SetToolTip(this.textBoxM, "Вязкость нефти");
            this.textBoxM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxL_KeyPress);
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelM.Location = new System.Drawing.Point(13, 194);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(116, 16);
            this.labelM.TabIndex = 8;
            this.labelM.Text = "μ, коэффициент:";
            // 
            // textBoxRk
            // 
            this.textBoxRk.Location = new System.Drawing.Point(10, 169);
            this.textBoxRk.Name = "textBoxRk";
            this.textBoxRk.Size = new System.Drawing.Size(160, 20);
            this.textBoxRk.TabIndex = 7;
            this.toolTipInputData.SetToolTip(this.textBoxRk, "Радиус контура питания");
            this.textBoxRk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxL_KeyPress);
            // 
            // labelRk
            // 
            this.labelRk.AutoSize = true;
            this.labelRk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRk.Location = new System.Drawing.Point(13, 150);
            this.labelRk.Name = "labelRk";
            this.labelRk.Size = new System.Drawing.Size(43, 16);
            this.labelRk.TabIndex = 6;
            this.labelRk.Text = "Rk, м:";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(10, 124);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(160, 20);
            this.textBoxH.TabIndex = 5;
            this.toolTipInputData.SetToolTip(this.textBoxH, "Мощность пласта");
            this.textBoxH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxL_KeyPress);
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelH.Location = new System.Drawing.Point(13, 108);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(33, 16);
            this.labelH.TabIndex = 4;
            this.labelH.Text = "h, м:";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(10, 80);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(160, 20);
            this.textBoxN.TabIndex = 3;
            this.toolTipInputData.SetToolTip(this.textBoxN, "Количество участков скважины");
            this.textBoxN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxL_KeyPress);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(13, 64);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(160, 13);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "N, кол-во участков скважины:";
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(10, 37);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(160, 20);
            this.textBoxL.TabIndex = 1;
            this.toolTipInputData.SetToolTip(this.textBoxL, "Длина горизонтального участка пласта");
            this.textBoxL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxL_KeyPress);
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL.Location = new System.Drawing.Point(13, 18);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(33, 16);
            this.labelL.TabIndex = 0;
            this.labelL.Text = "L, м:";
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.Linen;
            this.panelResult.Controls.Add(this.groupBoxResult);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult.Location = new System.Drawing.Point(190, 25);
            this.panelResult.Name = "panelResult";
            this.panelResult.Padding = new System.Windows.Forms.Padding(5);
            this.panelResult.Size = new System.Drawing.Size(454, 476);
            this.panelResult.TabIndex = 2;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.chartGraph);
            this.groupBoxResult.Controls.Add(this.textBoxGeneral);
            this.groupBoxResult.Controls.Add(this.textBoxBorisov);
            this.groupBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult.Location = new System.Drawing.Point(5, 5);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(444, 466);
            this.groupBoxResult.TabIndex = 0;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат:";
            // 
            // chartGraph
            // 
            chartArea4.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartGraph.Legends.Add(legend4);
            this.chartGraph.Location = new System.Drawing.Point(7, 108);
            this.chartGraph.Name = "chartGraph";
            this.chartGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartGraph.Series.Add(series4);
            this.chartGraph.Size = new System.Drawing.Size(428, 345);
            this.chartGraph.TabIndex = 2;
            this.chartGraph.TabStop = false;
            this.chartGraph.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title1";
            title4.Text = "Профиль притока";
            this.chartGraph.Titles.Add(title4);
            // 
            // textBoxGeneral
            // 
            this.textBoxGeneral.BackColor = System.Drawing.Color.Linen;
            this.textBoxGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGeneral.Location = new System.Drawing.Point(6, 63);
            this.textBoxGeneral.Multiline = true;
            this.textBoxGeneral.Name = "textBoxGeneral";
            this.textBoxGeneral.ReadOnly = true;
            this.textBoxGeneral.Size = new System.Drawing.Size(429, 37);
            this.textBoxGeneral.TabIndex = 1;
            this.textBoxGeneral.TabStop = false;
            this.textBoxGeneral.Text = "Q общ = ";
            // 
            // textBoxBorisov
            // 
            this.textBoxBorisov.BackColor = System.Drawing.Color.Linen;
            this.textBoxBorisov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBorisov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBorisov.Location = new System.Drawing.Point(7, 20);
            this.textBoxBorisov.Multiline = true;
            this.textBoxBorisov.Name = "textBoxBorisov";
            this.textBoxBorisov.ReadOnly = true;
            this.textBoxBorisov.Size = new System.Drawing.Size(431, 37);
            this.textBoxBorisov.TabIndex = 0;
            this.textBoxBorisov.TabStop = false;
            this.textBoxBorisov.Text = "Q Борисов = ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 501);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.toolStripUpperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "НефтеМодель";
            this.toolStripUpperPanel.ResumeLayout(false);
            this.toolStripUpperPanel.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripUpperPanel;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfo;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFileButton;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonReference;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxPz;
        private System.Windows.Forms.Label labelPz;
        private System.Windows.Forms.TextBox textBoxPpl;
        private System.Windows.Forms.Label labelPpl;
        private System.Windows.Forms.TextBox textBoxRc;
        private System.Windows.Forms.Label labelRc;
        private System.Windows.Forms.TextBox textBoxKv;
        private System.Windows.Forms.Label labelKv;
        private System.Windows.Forms.TextBox textBoxKh;
        private System.Windows.Forms.Label labelKh;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.TextBox textBoxRk;
        private System.Windows.Forms.Label labelRk;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.ToolStripButton toolStripButtonDone;
        private System.Windows.Forms.TextBox textBoxBorisov;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.TextBox textBoxGeneral;
        private System.Windows.Forms.ToolTip toolTipInputData;
    }
}

