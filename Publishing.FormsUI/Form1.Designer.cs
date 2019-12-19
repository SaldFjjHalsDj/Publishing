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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveInfo = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.BookBox = new System.Windows.Forms.TextBox();
            this.AgeComboBox = new System.Windows.Forms.ComboBox();
            this.ThemeComboBox = new System.Windows.Forms.ComboBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.CirculationBox = new System.Windows.Forms.TextBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.MonthComboBox);
            this.tabPage1.Controls.Add(this.CirculationBox);
            this.tabPage1.Controls.Add(this.PriceBox);
            this.tabPage1.Controls.Add(this.ThemeComboBox);
            this.tabPage1.Controls.Add(this.AgeComboBox);
            this.tabPage1.Controls.Add(this.BookBox);
            this.tabPage1.Controls.Add(this.NameBox);
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
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(584, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить новые данные";
            // 
            // SaveInfo
            // 
            this.SaveInfo.Location = new System.Drawing.Point(588, 333);
            this.SaveInfo.Name = "SaveInfo";
            this.SaveInfo.Size = new System.Drawing.Size(142, 35);
            this.SaveInfo.TabIndex = 1;
            this.SaveInfo.Text = "Save";
            this.SaveInfo.UseVisualStyleBackColor = true;
            this.SaveInfo.Click += new System.EventHandler(this.SaveInfo_Click);
            // 
            // Information
            // 
            this.Information.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Information.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Information.Location = new System.Drawing.Point(9, 28);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(562, 445);
            this.Information.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(584, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Автор:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(584, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Книга:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(584, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Возрастная категория:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(584, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Жанр:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(584, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Цена:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(584, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Тираж:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(584, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Месяц издания:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(678, 44);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(237, 20);
            this.NameBox.TabIndex = 12;
            // 
            // BookBox
            // 
            this.BookBox.Location = new System.Drawing.Point(677, 80);
            this.BookBox.Name = "BookBox";
            this.BookBox.Size = new System.Drawing.Size(237, 20);
            this.BookBox.TabIndex = 13;
            // 
            // AgeComboBox
            // 
            this.AgeComboBox.FormattingEnabled = true;
            this.AgeComboBox.Location = new System.Drawing.Point(741, 113);
            this.AgeComboBox.Name = "AgeComboBox";
            this.AgeComboBox.Size = new System.Drawing.Size(173, 21);
            this.AgeComboBox.TabIndex = 14;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.Location = new System.Drawing.Point(678, 148);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(236, 21);
            this.ThemeComboBox.TabIndex = 15;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(677, 185);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(237, 20);
            this.PriceBox.TabIndex = 16;
            // 
            // CirculationBox
            // 
            this.CirculationBox.Location = new System.Drawing.Point(677, 220);
            this.CirculationBox.Name = "CirculationBox";
            this.CirculationBox.Size = new System.Drawing.Size(237, 20);
            this.CirculationBox.TabIndex = 17;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Location = new System.Drawing.Point(741, 254);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(173, 21);
            this.MonthComboBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Information;
        private System.Windows.Forms.Button SaveInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.TextBox CirculationBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.ComboBox ThemeComboBox;
        private System.Windows.Forms.ComboBox AgeComboBox;
        private System.Windows.Forms.TextBox BookBox;
        private System.Windows.Forms.Button button1;
    }
}

