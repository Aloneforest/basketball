namespace WindowsFormsApplication1
{
    partial class 比赛统计
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.l1_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l2_1 = new System.Windows.Forms.Label();
            this.l1_2 = new System.Windows.Forms.Label();
            this.l2_2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lb3 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 12;
            this.lb1.Location = new System.Drawing.Point(30, 26);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(88, 328);
            this.lb1.TabIndex = 23;
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(29, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 415);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.l2_2);
            this.tabPage1.Controls.Add(this.l1_2);
            this.tabPage1.Controls.Add(this.l2_1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.l1_1);
            this.tabPage1.Controls.Add(this.lb1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "比赛列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.lb2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "球队战绩";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // l1_1
            // 
            this.l1_1.AutoSize = true;
            this.l1_1.Location = new System.Drawing.Point(297, 62);
            this.l1_1.Name = "l1_1";
            this.l1_1.Size = new System.Drawing.Size(35, 12);
            this.l1_1.TabIndex = 24;
            this.l1_1.Text = "球队1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "vs";
            // 
            // l2_1
            // 
            this.l2_1.AutoSize = true;
            this.l2_1.Location = new System.Drawing.Point(391, 62);
            this.l2_1.Name = "l2_1";
            this.l2_1.Size = new System.Drawing.Size(35, 12);
            this.l2_1.TabIndex = 26;
            this.l2_1.Text = "球队2";
            // 
            // l1_2
            // 
            this.l1_2.AutoSize = true;
            this.l1_2.Location = new System.Drawing.Point(297, 112);
            this.l1_2.Name = "l1_2";
            this.l1_2.Size = new System.Drawing.Size(41, 12);
            this.l1_2.TabIndex = 27;
            this.l1_2.Text = "label5";
            // 
            // l2_2
            // 
            this.l2_2.AutoSize = true;
            this.l2_2.Location = new System.Drawing.Point(391, 112);
            this.l2_2.Name = "l2_2";
            this.l2_2.Size = new System.Drawing.Size(41, 12);
            this.l2_2.TabIndex = 28;
            this.l2_2.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "球队";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "比分";
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 12;
            this.lb2.Location = new System.Drawing.Point(25, 22);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(88, 328);
            this.lb2.TabIndex = 31;
            this.lb2.Click += new System.EventHandler(this.lb2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(125, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(316, 328);
            this.dataGridView1.TabIndex = 32;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.lb3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(486, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "球员战绩";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(135, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(316, 328);
            this.dataGridView2.TabIndex = 34;
            // 
            // lb3
            // 
            this.lb3.FormattingEnabled = true;
            this.lb3.ItemHeight = 12;
            this.lb3.Location = new System.Drawing.Point(35, 30);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(88, 328);
            this.lb3.TabIndex = 33;
            this.lb3.Click += new System.EventHandler(this.lb3_Click);
            // 
            // 比赛统计
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 501);
            this.Controls.Add(this.tabControl1);
            this.Name = "比赛统计";
            this.Text = "比赛统计";
            this.Load += new System.EventHandler(this.比赛统计_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l2_2;
        private System.Windows.Forms.Label l1_2;
        private System.Windows.Forms.Label l2_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l1_1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ListBox lb3;

    }
}