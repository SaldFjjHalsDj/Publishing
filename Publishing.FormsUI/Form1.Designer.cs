namespace Publishing.FormsUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataSpaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.CirculationBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.BookBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ThemeComboBox = new System.Windows.Forms.ComboBox();
            this.AgeComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveInfo = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxForMonth = new System.Windows.Forms.ComboBox();
            this.buttonPieGraph = new System.Windows.Forms.Button();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonForColumn = new System.Windows.Forms.Button();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.chartColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpaceBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.MonthComboBox);
            this.tabPage1.Controls.Add(this.CirculationBox);
            this.tabPage1.Controls.Add(this.PriceBox);
            this.tabPage1.Controls.Add(this.BookBox);
            this.tabPage1.Controls.Add(this.NameBox);
            this.tabPage1.Controls.Add(this.ThemeComboBox);
            this.tabPage1.Controls.Add(this.AgeComboBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SaveInfo);
            this.tabPage1.Controls.Add(this.Information);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(926, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Location = new System.Drawing.Point(741, 254);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(173, 21);
            this.MonthComboBox.TabIndex = 18;
            this.MonthComboBox.UseWaitCursor = true;
            // 
            // CirculationBox
            // 
            this.CirculationBox.Location = new System.Drawing.Point(677, 220);
            this.CirculationBox.Name = "CirculationBox";
            this.CirculationBox.Size = new System.Drawing.Size(237, 20);
            this.CirculationBox.TabIndex = 17;
            this.CirculationBox.UseWaitCursor = true;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(677, 185);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(237, 20);
            this.PriceBox.TabIndex = 16;
            this.PriceBox.UseWaitCursor = true;
            // 
            // BookBox
            // 
            this.BookBox.Location = new System.Drawing.Point(677, 80);
            this.BookBox.Name = "BookBox";
            this.BookBox.Size = new System.Drawing.Size(237, 20);
            this.BookBox.TabIndex = 13;
            this.BookBox.UseWaitCursor = true;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(678, 44);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(237, 20);
            this.NameBox.TabIndex = 12;
            this.NameBox.UseWaitCursor = true;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.Location = new System.Drawing.Point(678, 148);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(236, 21);
            this.ThemeComboBox.TabIndex = 15;
            this.ThemeComboBox.UseWaitCursor = true;
            // 
            // AgeComboBox
            // 
            this.AgeComboBox.FormattingEnabled = true;
            this.AgeComboBox.Location = new System.Drawing.Point(741, 113);
            this.AgeComboBox.Name = "AgeComboBox";
            this.AgeComboBox.Size = new System.Drawing.Size(173, 21);
            this.AgeComboBox.TabIndex = 14;
            this.AgeComboBox.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(584, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Месяц издания:";
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(584, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Тираж:";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(584, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Цена:";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(584, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Жанр:";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(584, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Возрастная категория:";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(584, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Книга:";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(584, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Автор:";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(584, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить новые данные";
            this.label1.UseWaitCursor = true;
            // 
            // SaveInfo
            // 
            this.SaveInfo.Location = new System.Drawing.Point(588, 333);
            this.SaveInfo.Name = "SaveInfo";
            this.SaveInfo.Size = new System.Drawing.Size(142, 35);
            this.SaveInfo.TabIndex = 1;
            this.SaveInfo.Text = "Save";
            this.SaveInfo.UseVisualStyleBackColor = true;
            this.SaveInfo.UseWaitCursor = true;
            this.SaveInfo.Click += new System.EventHandler(this.SaveInfo_Click);
            // 
            // Information
            // 
            this.Information.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Information.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Information.Location = new System.Drawing.Point(9, 28);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(562, 425);
            this.Information.TabIndex = 0;
            this.Information.UseWaitCursor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 506);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonGraph);
            this.tabPage2.Controls.Add(this.chartGraph);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(926, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graph";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.UseWaitCursor = true;
            // 
            // buttonGraph
            // 
            this.buttonGraph.Location = new System.Drawing.Point(10, 17);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(219, 56);
            this.buttonGraph.TabIndex = 2;
            this.buttonGraph.Text = "Make graph";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.UseWaitCursor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // chartGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraph.Legends.Add(legend1);
            this.chartGraph.Location = new System.Drawing.Point(10, 92);
            this.chartGraph.Name = "chartGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraph.Series.Add(series1);
            this.chartGraph.Size = new System.Drawing.Size(905, 381);
            this.chartGraph.TabIndex = 0;
            this.chartGraph.UseWaitCursor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxForMonth);
            this.tabPage3.Controls.Add(this.buttonPieGraph);
            this.tabPage3.Controls.Add(this.chartPie);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(926, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pie Graph";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.UseWaitCursor = true;
            // 
            // comboBoxForMonth
            // 
            this.comboBoxForMonth.FormattingEnabled = true;
            this.comboBoxForMonth.Location = new System.Drawing.Point(734, 99);
            this.comboBoxForMonth.Name = "comboBoxForMonth";
            this.comboBoxForMonth.Size = new System.Drawing.Size(181, 21);
            this.comboBoxForMonth.TabIndex = 2;
            this.comboBoxForMonth.UseWaitCursor = true;
            // 
            // buttonPieGraph
            // 
            this.buttonPieGraph.Location = new System.Drawing.Point(734, 199);
            this.buttonPieGraph.Name = "buttonPieGraph";
            this.buttonPieGraph.Size = new System.Drawing.Size(181, 41);
            this.buttonPieGraph.TabIndex = 1;
            this.buttonPieGraph.Text = "Make pie";
            this.buttonPieGraph.UseVisualStyleBackColor = true;
            this.buttonPieGraph.UseWaitCursor = true;
            this.buttonPieGraph.Click += new System.EventHandler(this.buttonPieGraph_Click);
            // 
            // chartPie
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPie.Legends.Add(legend2);
            this.chartPie.Location = new System.Drawing.Point(10, 6);
            this.chartPie.Name = "chartPie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPie.Series.Add(series2);
            this.chartPie.Size = new System.Drawing.Size(549, 467);
            this.chartPie.TabIndex = 0;
            this.chartPie.UseWaitCursor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonForColumn);
            this.tabPage4.Controls.Add(this.comboBoxColumn);
            this.tabPage4.Controls.Add(this.chartColumn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(926, 480);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Column Graph";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.UseWaitCursor = true;
            // 
            // buttonForColumn
            // 
            this.buttonForColumn.Location = new System.Drawing.Point(233, 16);
            this.buttonForColumn.Name = "buttonForColumn";
            this.buttonForColumn.Size = new System.Drawing.Size(155, 24);
            this.buttonForColumn.TabIndex = 2;
            this.buttonForColumn.Text = "Make Column Graph";
            this.buttonForColumn.UseVisualStyleBackColor = true;
            this.buttonForColumn.UseWaitCursor = true;
            this.buttonForColumn.Click += new System.EventHandler(this.buttonForColumn_Click);
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.FormattingEnabled = true;
            this.comboBoxColumn.Location = new System.Drawing.Point(33, 19);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(155, 21);
            this.comboBoxColumn.TabIndex = 1;
            this.comboBoxColumn.UseWaitCursor = true;
            // 
            // chartColumn
            // 
            chartArea3.Name = "ChartArea1";
            this.chartColumn.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartColumn.Legends.Add(legend3);
            this.chartColumn.Location = new System.Drawing.Point(4, 61);
            this.chartColumn.Name = "chartColumn";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series3";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series4";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series5";
            this.chartColumn.Series.Add(series3);
            this.chartColumn.Series.Add(series4);
            this.chartColumn.Series.Add(series5);
            this.chartColumn.Series.Add(series6);
            this.chartColumn.Series.Add(series7);
            this.chartColumn.Size = new System.Drawing.Size(916, 416);
            this.chartColumn.TabIndex = 0;
            this.chartColumn.Text = "chart1";
            this.chartColumn.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSpaceBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSpaceBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.TextBox CirculationBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox BookBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ComboBox ThemeComboBox;
        private System.Windows.Forms.ComboBox AgeComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveInfo;
        private System.Windows.Forms.DataGridView Information;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBoxForMonth;
        private System.Windows.Forms.Button buttonPieGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColumn;
        private System.Windows.Forms.Button buttonForColumn;
    }
}

