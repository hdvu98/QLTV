namespace LibraryManagement
{
    partial class UC_Stat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabStat = new MetroFramework.Controls.MetroTabControl();
            this.tabTableStat = new MetroFramework.Controls.MetroTabPage();
            this.tabChart = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnNgayXB = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuImageButton8 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDatepicker3 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDatepicker4 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuDatepicker5 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.tabStat.SuspendLayout();
            this.tabTableStat.SuspendLayout();
            this.tabChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStat
            // 
            this.tabStat.Controls.Add(this.tabTableStat);
            this.tabStat.Controls.Add(this.tabChart);
            this.tabStat.Location = new System.Drawing.Point(0, 0);
            this.tabStat.Name = "tabStat";
            this.tabStat.SelectedIndex = 0;
            this.tabStat.Size = new System.Drawing.Size(984, 554);
            this.tabStat.TabIndex = 0;
            this.tabStat.UseSelectable = true;
            // 
            // tabTableStat
            // 
            this.tabTableStat.Controls.Add(this.dataGridView1);
            this.tabTableStat.Controls.Add(this.panel3);
            this.tabTableStat.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTableStat.HorizontalScrollbarBarColor = true;
            this.tabTableStat.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTableStat.HorizontalScrollbarSize = 10;
            this.tabTableStat.Location = new System.Drawing.Point(4, 38);
            this.tabTableStat.Name = "tabTableStat";
            this.tabTableStat.Size = new System.Drawing.Size(976, 512);
            this.tabTableStat.TabIndex = 0;
            this.tabTableStat.Text = "Thống kê";
            this.tabTableStat.VerticalScrollbarBarColor = true;
            this.tabTableStat.VerticalScrollbarHighlightOnWheel = false;
            this.tabTableStat.VerticalScrollbarSize = 10;
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.cartesianChart1);
            this.tabChart.Controls.Add(this.panel1);
            this.tabChart.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabChart.HorizontalScrollbarBarColor = true;
            this.tabChart.HorizontalScrollbarHighlightOnWheel = false;
            this.tabChart.HorizontalScrollbarSize = 10;
            this.tabChart.Location = new System.Drawing.Point(4, 38);
            this.tabChart.Name = "tabChart";
            this.tabChart.Size = new System.Drawing.Size(976, 512);
            this.tabChart.TabIndex = 1;
            this.tabChart.Text = "Biểu đồ";
            this.tabChart.VerticalScrollbarBarColor = true;
            this.tabChart.VerticalScrollbarHighlightOnWheel = false;
            this.tabChart.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(970, 365);
            this.dataGridView1.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel3.Controls.Add(this.bunifuImageButton8);
            this.panel3.Controls.Add(this.bunifuDatepicker2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bunifuDatepicker1);
            this.panel3.Controls.Add(this.btnNgayXB);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 126);
            this.panel3.TabIndex = 33;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Lọc theo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(36, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 19);
            this.radioButton1.TabIndex = 40;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ngày";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(36, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 19);
            this.radioButton2.TabIndex = 41;
            this.radioButton2.Text = "Tháng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnNgayXB
            // 
            this.btnNgayXB.BackColor = System.Drawing.Color.White;
            this.btnNgayXB.BorderRadius = 0;
            this.btnNgayXB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNgayXB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.btnNgayXB.FormatCustom = null;
            this.btnNgayXB.Location = new System.Drawing.Point(117, 29);
            this.btnNgayXB.Name = "btnNgayXB";
            this.btnNgayXB.Size = new System.Drawing.Size(200, 35);
            this.btnNgayXB.TabIndex = 42;
            this.btnNgayXB.Value = new System.DateTime(2019, 5, 31, 2, 48, 44, 547);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(365, 29);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(200, 35);
            this.bunifuDatepicker1.TabIndex = 43;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 5, 31, 2, 48, 44, 547);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(323, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Đến";
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.BorderRadius = 0;
            this.bunifuDatepicker2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker2.FormatCustom = null;
            this.bunifuDatepicker2.Location = new System.Drawing.Point(117, 70);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(200, 35);
            this.bunifuDatepicker2.TabIndex = 45;
            this.bunifuDatepicker2.Value = new System.DateTime(2019, 5, 31, 2, 48, 44, 547);
            // 
            // bunifuImageButton8
            // 
            this.bunifuImageButton8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton8.Image = global::LibraryManagement.Properties.Resources.search_480px;
            this.bunifuImageButton8.ImageActive = null;
            this.bunifuImageButton8.Location = new System.Drawing.Point(616, 29);
            this.bunifuImageButton8.Name = "bunifuImageButton8";
            this.bunifuImageButton8.Size = new System.Drawing.Size(35, 34);
            this.bunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton8.TabIndex = 46;
            this.bunifuImageButton8.TabStop = false;
            this.bunifuImageButton8.Zoom = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.bunifuDatepicker3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bunifuDatepicker4);
            this.panel1.Controls.Add(this.bunifuDatepicker5);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 126);
            this.panel1.TabIndex = 34;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::LibraryManagement.Properties.Resources.search_480px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(616, 29);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 46;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuDatepicker3
            // 
            this.bunifuDatepicker3.BackColor = System.Drawing.Color.White;
            this.bunifuDatepicker3.BorderRadius = 0;
            this.bunifuDatepicker3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuDatepicker3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker3.FormatCustom = null;
            this.bunifuDatepicker3.Location = new System.Drawing.Point(117, 70);
            this.bunifuDatepicker3.Name = "bunifuDatepicker3";
            this.bunifuDatepicker3.Size = new System.Drawing.Size(200, 35);
            this.bunifuDatepicker3.TabIndex = 45;
            this.bunifuDatepicker3.Value = new System.DateTime(2019, 5, 31, 2, 48, 44, 547);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(323, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Đến";
            // 
            // bunifuDatepicker4
            // 
            this.bunifuDatepicker4.BackColor = System.Drawing.Color.White;
            this.bunifuDatepicker4.BorderRadius = 0;
            this.bunifuDatepicker4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuDatepicker4.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker4.FormatCustom = null;
            this.bunifuDatepicker4.Location = new System.Drawing.Point(365, 29);
            this.bunifuDatepicker4.Name = "bunifuDatepicker4";
            this.bunifuDatepicker4.Size = new System.Drawing.Size(200, 35);
            this.bunifuDatepicker4.TabIndex = 43;
            this.bunifuDatepicker4.Value = new System.DateTime(2019, 5, 31, 2, 48, 44, 547);
            // 
            // bunifuDatepicker5
            // 
            this.bunifuDatepicker5.BackColor = System.Drawing.Color.White;
            this.bunifuDatepicker5.BorderRadius = 0;
            this.bunifuDatepicker5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuDatepicker5.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker5.FormatCustom = null;
            this.bunifuDatepicker5.Location = new System.Drawing.Point(117, 29);
            this.bunifuDatepicker5.Name = "bunifuDatepicker5";
            this.bunifuDatepicker5.Size = new System.Drawing.Size(200, 35);
            this.bunifuDatepicker5.TabIndex = 42;
            this.bunifuDatepicker5.Value = new System.DateTime(2019, 5, 31, 2, 48, 44, 547);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(36, 79);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 19);
            this.radioButton3.TabIndex = 41;
            this.radioButton3.Text = "Tháng";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(36, 38);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(54, 19);
            this.radioButton4.TabIndex = 40;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ngày";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Lọc theo";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(3, 135);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(970, 374);
            this.cartesianChart1.TabIndex = 35;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // UC_Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabStat);
            this.Name = "UC_Stat";
            this.Size = new System.Drawing.Size(984, 554);
            this.tabStat.ResumeLayout(false);
            this.tabTableStat.ResumeLayout(false);
            this.tabChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabStat;
        private MetroFramework.Controls.MetroTabPage tabTableStat;
        private MetroFramework.Controls.MetroTabPage tabChart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuDatepicker btnNgayXB;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton8;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker3;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker4;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label4;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}
