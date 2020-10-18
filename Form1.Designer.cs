namespace Convert_money
{
    partial class convert_money
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
            this.txtn = new System.Windows.Forms.TextBox();
            this.btconvert = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btabout = new System.Windows.Forms.Button();
            this.txtusd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUSD2 = new System.Windows.Forms.TextBox();
            this.btconvert2 = new System.Windows.Forms.Button();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtalt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtn
            // 
            this.txtn.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtn.Location = new System.Drawing.Point(10, 37);
            this.txtn.Margin = new System.Windows.Forms.Padding(4);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(235, 26);
            this.txtn.TabIndex = 0;
            this.txtn.TextChanged += new System.EventHandler(this.txtn_TextChanged);
            // 
            // btconvert
            // 
            this.btconvert.Location = new System.Drawing.Point(270, 34);
            this.btconvert.Margin = new System.Windows.Forms.Padding(4);
            this.btconvert.Name = "btconvert";
            this.btconvert.Size = new System.Drawing.Size(160, 28);
            this.btconvert.TabIndex = 1;
            this.btconvert.Text = "Convert";
            this.btconvert.UseVisualStyleBackColor = true;
            this.btconvert.Click += new System.EventHandler(this.btconvert_Click);
            // 
            // txtkq
            // 
            this.txtkq.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtkq.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtkq.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtkq.Location = new System.Drawing.Point(10, 92);
            this.txtkq.Margin = new System.Windows.Forms.Padding(4);
            this.txtkq.Multiline = true;
            this.txtkq.Name = "txtkq";
            this.txtkq.ReadOnly = true;
            this.txtkq.Size = new System.Drawing.Size(420, 75);
            this.txtkq.TabIndex = 2;
            this.txtkq.TextChanged += new System.EventHandler(this.txtkq_TextChanged);
            // 
            // btabout
            // 
            this.btabout.Location = new System.Drawing.Point(297, 365);
            this.btabout.Margin = new System.Windows.Forms.Padding(4);
            this.btabout.Name = "btabout";
            this.btabout.Size = new System.Drawing.Size(155, 28);
            this.btabout.TabIndex = 3;
            this.btabout.Text = "Close";
            this.btabout.UseVisualStyleBackColor = true;
            this.btabout.Click += new System.EventHandler(this.btabout_Click);
            // 
            // txtusd
            // 
            this.txtusd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtusd.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtusd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtusd.Location = new System.Drawing.Point(9, 97);
            this.txtusd.Margin = new System.Windows.Forms.Padding(4);
            this.txtusd.Multiline = true;
            this.txtusd.Name = "txtusd";
            this.txtusd.ReadOnly = true;
            this.txtusd.Size = new System.Drawing.Size(420, 75);
            this.txtusd.TabIndex = 4;
            this.txtusd.TextChanged += new System.EventHandler(this.txtusd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vietnam Dong amount in Words";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "USD amount in Words (Vietnamese)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "USD amount in Words (English)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUSD2
            // 
            this.txtUSD2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUSD2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUSD2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUSD2.Location = new System.Drawing.Point(9, 208);
            this.txtUSD2.Margin = new System.Windows.Forms.Padding(4);
            this.txtUSD2.Multiline = true;
            this.txtUSD2.Name = "txtUSD2";
            this.txtUSD2.ReadOnly = true;
            this.txtUSD2.Size = new System.Drawing.Size(420, 75);
            this.txtUSD2.TabIndex = 7;
            // 
            // btconvert2
            // 
            this.btconvert2.Location = new System.Drawing.Point(269, 34);
            this.btconvert2.Margin = new System.Windows.Forms.Padding(4);
            this.btconvert2.Name = "btconvert2";
            this.btconvert2.Size = new System.Drawing.Size(160, 28);
            this.btconvert2.TabIndex = 10;
            this.btconvert2.Text = "Convert";
            this.btconvert2.UseVisualStyleBackColor = true;
            this.btconvert2.Click += new System.EventHandler(this.btconvert2_Click);
            // 
            // txtn2
            // 
            this.txtn2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtn2.Location = new System.Drawing.Point(9, 36);
            this.txtn2.Margin = new System.Windows.Forms.Padding(4);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(235, 26);
            this.txtn2.TabIndex = 9;
            this.txtn2.TextChanged += new System.EventHandler(this.txtn2_TextChanged);
            // 
            // txtalt
            // 
            this.txtalt.AutoSize = true;
            this.txtalt.ForeColor = System.Drawing.Color.Red;
            this.txtalt.Location = new System.Drawing.Point(8, 15);
            this.txtalt.Name = "txtalt";
            this.txtalt.Size = new System.Drawing.Size(339, 18);
            this.txtalt.TabIndex = 11;
            this.txtalt.Text = "Input USD amount, use dot . as decimal separator";
            this.txtalt.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Input the amount w/o decimal";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(7, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 346);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.txtkq);
            this.tabPage1.Controls.Add(this.txtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btconvert);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(457, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read VND";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btconvert2);
            this.tabPage2.Controls.Add(this.txtUSD2);
            this.tabPage2.Controls.Add(this.txtn2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtalt);
            this.tabPage2.Controls.Add(this.txtusd);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Read USD";
            // 
            // convert_money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 402);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btabout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "convert_money";
            this.Text = "Convert Money";
            this.Load += new System.EventHandler(this.convert_money_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button btconvert;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btabout;
        private System.Windows.Forms.TextBox txtusd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUSD2;
        private System.Windows.Forms.Button btconvert2;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label txtalt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

