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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonThang = new System.Windows.Forms.RadioButton();
            this.radioButtonNgay = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabChart = new MetroFramework.Controls.MetroTabPage();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.DatePickerToStat = new System.Windows.Forms.DateTimePicker();
            this.DatePickerFromStat = new System.Windows.Forms.DateTimePicker();
            this.MonthPickerStat = new System.Windows.Forms.DateTimePicker();
            this.tableName = new System.Windows.Forms.Label();
            this.MonthPickerChart = new System.Windows.Forms.DateTimePicker();
            this.DatePickerFromChart = new System.Windows.Forms.DateTimePicker();
            this.DatePickerToChart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonThang2 = new System.Windows.Forms.RadioButton();
            this.radioButtonNgay2 = new System.Windows.Forms.RadioButton();
            this.tabStat.SuspendLayout();
            this.tabTableStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch1)).BeginInit();
            this.tabChart.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStat
            // 
            this.tabStat.Controls.Add(this.tabTableStat);
            this.tabStat.Controls.Add(this.tabChart);
            this.tabStat.Location = new System.Drawing.Point(0, 0);
            this.tabStat.Name = "tabStat";
            this.tabStat.SelectedIndex = 1;
            this.tabStat.Size = new System.Drawing.Size(984, 554);
            this.tabStat.TabIndex = 0;
            this.tabStat.UseSelectable = true;
            // 
            // tabTableStat
            // 
            this.tabTableStat.Controls.Add(this.tableName);
            this.tabTableStat.Controls.Add(this.dataGridView1);
            this.tabTableStat.Controls.Add(this.panel3);
            this.tabTableStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(970, 323);
            this.dataGridView1.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel3.Controls.Add(this.MonthPickerStat);
            this.panel3.Controls.Add(this.DatePickerFromStat);
            this.panel3.Controls.Add(this.DatePickerToStat);
            this.panel3.Controls.Add(this.btnSearch1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.radioButtonThang);
            this.panel3.Controls.Add(this.radioButtonNgay);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 126);
            this.panel3.TabIndex = 33;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch1.Image = global::LibraryManagement.Properties.Resources.search_480px;
            this.btnSearch1.ImageActive = null;
            this.btnSearch1.Location = new System.Drawing.Point(616, 29);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(35, 34);
            this.btnSearch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch1.TabIndex = 46;
            this.btnSearch1.TabStop = false;
            this.btnSearch1.Zoom = 10;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(323, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Đến";
            // 
            // radioButtonThang
            // 
            this.radioButtonThang.AutoSize = true;
            this.radioButtonThang.ForeColor = System.Drawing.Color.White;
            this.radioButtonThang.Location = new System.Drawing.Point(36, 79);
            this.radioButtonThang.Name = "radioButtonThang";
            this.radioButtonThang.Size = new System.Drawing.Size(65, 20);
            this.radioButtonThang.TabIndex = 41;
            this.radioButtonThang.Text = "Tháng";
            this.radioButtonThang.UseVisualStyleBackColor = true;
            // 
            // radioButtonNgay
            // 
            this.radioButtonNgay.AutoSize = true;
            this.radioButtonNgay.Checked = true;
            this.radioButtonNgay.ForeColor = System.Drawing.Color.White;
            this.radioButtonNgay.Location = new System.Drawing.Point(36, 38);
            this.radioButtonNgay.Name = "radioButtonNgay";
            this.radioButtonNgay.Size = new System.Drawing.Size(59, 20);
            this.radioButtonNgay.TabIndex = 40;
            this.radioButtonNgay.TabStop = true;
            this.radioButtonNgay.Text = "Ngày";
            this.radioButtonNgay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Lọc theo";
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.cartesianChart1);
            this.tabChart.Controls.Add(this.panel1);
            this.tabChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(3, 135);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(970, 374);
            this.cartesianChart1.TabIndex = 35;
            this.cartesianChart1.Text = "chart";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.MonthPickerChart);
            this.panel1.Controls.Add(this.DatePickerFromChart);
            this.panel1.Controls.Add(this.DatePickerToChart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButtonThang2);
            this.panel1.Controls.Add(this.radioButtonNgay2);
            this.panel1.Controls.Add(this.btnSearch2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 126);
            this.panel1.TabIndex = 34;
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch2.Image = global::LibraryManagement.Properties.Resources.search_480px;
            this.btnSearch2.ImageActive = null;
            this.btnSearch2.Location = new System.Drawing.Point(616, 29);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(35, 34);
            this.btnSearch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch2.TabIndex = 46;
            this.btnSearch2.TabStop = false;
            this.btnSearch2.Zoom = 10;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Lọc theo";
            // 
            // DatePickerToStat
            // 
            this.DatePickerToStat.Location = new System.Drawing.Point(375, 37);
            this.DatePickerToStat.Name = "DatePickerToStat";
            this.DatePickerToStat.Size = new System.Drawing.Size(200, 22);
            this.DatePickerToStat.TabIndex = 47;
            // 
            // DatePickerFromStat
            // 
            this.DatePickerFromStat.Location = new System.Drawing.Point(101, 37);
            this.DatePickerFromStat.Name = "DatePickerFromStat";
            this.DatePickerFromStat.Size = new System.Drawing.Size(200, 22);
            this.DatePickerFromStat.TabIndex = 48;
            // 
            // MonthPickerStat
            // 
            this.MonthPickerStat.Location = new System.Drawing.Point(101, 76);
            this.MonthPickerStat.Name = "MonthPickerStat";
            this.MonthPickerStat.Size = new System.Drawing.Size(200, 22);
            this.MonthPickerStat.TabIndex = 49;
            // 
            // tableName
            // 
            this.tableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableName.Location = new System.Drawing.Point(3, 141);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(959, 42);
            this.tableName.TabIndex = 34;
            this.tableName.Text = "THỐNG KÊ";
            this.tableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonthPickerChart
            // 
            this.MonthPickerChart.Location = new System.Drawing.Point(84, 75);
            this.MonthPickerChart.Name = "MonthPickerChart";
            this.MonthPickerChart.Size = new System.Drawing.Size(200, 22);
            this.MonthPickerChart.TabIndex = 55;
            // 
            // DatePickerFromChart
            // 
            this.DatePickerFromChart.Location = new System.Drawing.Point(84, 36);
            this.DatePickerFromChart.Name = "DatePickerFromChart";
            this.DatePickerFromChart.Size = new System.Drawing.Size(200, 22);
            this.DatePickerFromChart.TabIndex = 54;
            // 
            // DatePickerToChart
            // 
            this.DatePickerToChart.Location = new System.Drawing.Point(358, 36);
            this.DatePickerToChart.Name = "DatePickerToChart";
            this.DatePickerToChart.Size = new System.Drawing.Size(200, 22);
            this.DatePickerToChart.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(306, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Đến";
            // 
            // radioButtonThang2
            // 
            this.radioButtonThang2.AutoSize = true;
            this.radioButtonThang2.ForeColor = System.Drawing.Color.White;
            this.radioButtonThang2.Location = new System.Drawing.Point(19, 78);
            this.radioButtonThang2.Name = "radioButtonThang2";
            this.radioButtonThang2.Size = new System.Drawing.Size(65, 20);
            this.radioButtonThang2.TabIndex = 51;
            this.radioButtonThang2.Text = "Tháng";
            this.radioButtonThang2.UseVisualStyleBackColor = true;
            // 
            // radioButtonNgay2
            // 
            this.radioButtonNgay2.AutoSize = true;
            this.radioButtonNgay2.Checked = true;
            this.radioButtonNgay2.ForeColor = System.Drawing.Color.White;
            this.radioButtonNgay2.Location = new System.Drawing.Point(19, 37);
            this.radioButtonNgay2.Name = "radioButtonNgay2";
            this.radioButtonNgay2.Size = new System.Drawing.Size(59, 20);
            this.radioButtonNgay2.TabIndex = 50;
            this.radioButtonNgay2.TabStop = true;
            this.radioButtonNgay2.Text = "Ngày";
            this.radioButtonNgay2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch1)).EndInit();
            this.tabChart.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabStat;
        private MetroFramework.Controls.MetroTabPage tabTableStat;
        private MetroFramework.Controls.MetroTabPage tabChart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonThang;
        private System.Windows.Forms.RadioButton radioButtonNgay;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch2;
        private System.Windows.Forms.Label label4;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.DateTimePicker MonthPickerStat;
        private System.Windows.Forms.DateTimePicker DatePickerFromStat;
        private System.Windows.Forms.DateTimePicker DatePickerToStat;
        private System.Windows.Forms.Label tableName;
        private System.Windows.Forms.DateTimePicker MonthPickerChart;
        private System.Windows.Forms.DateTimePicker DatePickerFromChart;
        private System.Windows.Forms.DateTimePicker DatePickerToChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonThang2;
        private System.Windows.Forms.RadioButton radioButtonNgay2;
    }
}
