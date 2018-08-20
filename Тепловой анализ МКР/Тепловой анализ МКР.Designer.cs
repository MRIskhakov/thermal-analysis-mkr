namespace Тепловой_анализ_МКР
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПараметрыТепловогоАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПараметрыБлокаЭСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewSurfaceTemp = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьБДToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.командаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьТепловойАнализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПараметрыТепловогоАнализаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxSwitchChart = new System.Windows.Forms.ComboBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSurfaceTemp)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // открытьБДToolStripMenuItem
            // 
            this.открытьБДToolStripMenuItem.Name = "открытьБДToolStripMenuItem";
            this.открытьБДToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // изменитьПараметрыТепловогоАнализаToolStripMenuItem
            // 
            this.изменитьПараметрыТепловогоАнализаToolStripMenuItem.Name = "изменитьПараметрыТепловогоАнализаToolStripMenuItem";
            this.изменитьПараметрыТепловогоАнализаToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // изменитьПараметрыБлокаЭСToolStripMenuItem
            // 
            this.изменитьПараметрыБлокаЭСToolStripMenuItem.Name = "изменитьПараметрыБлокаЭСToolStripMenuItem";
            this.изменитьПараметрыБлокаЭСToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // chart1
            // 
            this.chartMain.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(12, 82);
            this.chartMain.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Ось X";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Ось Y";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Ось Z";
            this.chartMain.Series.Add(series1);
            this.chartMain.Series.Add(series2);
            this.chartMain.Series.Add(series3);
            this.chartMain.Size = new System.Drawing.Size(429, 397);
            this.chartMain.TabIndex = 1;
            this.chartMain.Text = "chart1";
            this.chartMain.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridViewSurfaceTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSurfaceTemp.Location = new System.Drawing.Point(460, 55);
            this.dataGridViewSurfaceTemp.Name = "dataGridView1";
            this.dataGridViewSurfaceTemp.Size = new System.Drawing.Size(256, 194);
            this.dataGridViewSurfaceTemp.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButtonOpenDataBase_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButtonStartTA_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButtonQuit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.командаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьБДToolStripMenuItem1,
            this.выходToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // открытьБДToolStripMenuItem1
            // 
            this.открытьБДToolStripMenuItem1.Name = "открытьБДToolStripMenuItem1";
            this.открытьБДToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.открытьБДToolStripMenuItem1.Text = "Открыть БД";
            this.открытьБДToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItemOpenDataBase_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItemQuit_Click);
            // 
            // командаToolStripMenuItem
            // 
            this.командаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выполнитьТепловойАнализToolStripMenuItem,
            this.изменитьПараметрыТепловогоАнализаToolStripMenuItem1});
            this.командаToolStripMenuItem.Name = "командаToolStripMenuItem";
            this.командаToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.командаToolStripMenuItem.Text = "Команда";
            // 
            // выполнитьТепловойАнализToolStripMenuItem
            // 
            this.выполнитьТепловойАнализToolStripMenuItem.Name = "выполнитьТепловойАнализToolStripMenuItem";
            this.выполнитьТепловойАнализToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.выполнитьТепловойАнализToolStripMenuItem.Text = "Выполнить тепловой анализ";
            this.выполнитьТепловойАнализToolStripMenuItem.Click += new System.EventHandler(this.выполнитьТепловойАнализToolStripMenuItem_Click);
            // 
            // изменитьПараметрыТепловогоАнализаToolStripMenuItem1
            // 
            this.изменитьПараметрыТепловогоАнализаToolStripMenuItem1.Name = "изменитьПараметрыТепловогоАнализаToolStripMenuItem1";
            this.изменитьПараметрыТепловогоАнализаToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.изменитьПараметрыТепловогоАнализаToolStripMenuItem1.Text = "Изменить параметры...";
            this.изменитьПараметрыТепловогоАнализаToolStripMenuItem1.Click += new System.EventHandler(this.изменитьПараметрыТепловогоАнализаToolStripMenuItem1_Click);
            // 
            // comboBox2
            // 
            this.comboBoxSwitchChart.FormattingEnabled = true;
            this.comboBoxSwitchChart.Items.AddRange(new object[] {
            "Ось X",
            "Ось Y",
            "Ось Z"});
            this.comboBoxSwitchChart.Location = new System.Drawing.Point(12, 55);
            this.comboBoxSwitchChart.Name = "comboBox2";
            this.comboBoxSwitchChart.Size = new System.Drawing.Size(429, 21);
            this.comboBoxSwitchChart.TabIndex = 9;
            this.comboBoxSwitchChart.Text = "Выберите ось координат";
            this.comboBoxSwitchChart.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 491);
            this.Controls.Add(this.comboBoxSwitchChart);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewSurfaceTemp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chartMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Тепловой анализ МКР";
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSurfaceTemp)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьПараметрыТепловогоАнализаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьПараметрыБлокаЭСToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewSurfaceTemp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьБДToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem командаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьТепловойАнализToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьПараметрыТепловогоАнализаToolStripMenuItem1;
        private System.Windows.Forms.ComboBox comboBoxSwitchChart;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

