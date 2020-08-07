namespace CSCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.FsoniText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AlbatobaText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TqveniTanxaText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TanxaResultText = new System.Windows.Forms.TextBox();
            this.FsoniResultText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NextBetText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "გამოთვლა";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FsoniText
            // 
            this.FsoniText.Location = new System.Drawing.Point(14, 174);
            this.FsoniText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FsoniText.Name = "FsoniText";
            this.FsoniText.Size = new System.Drawing.Size(132, 26);
            this.FsoniText.TabIndex = 1;
            this.FsoniText.Text = "10";
            this.FsoniText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ფსონი:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AlbatobaText
            // 
            this.AlbatobaText.Location = new System.Drawing.Point(180, 53);
            this.AlbatobaText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AlbatobaText.Name = "AlbatobaText";
            this.AlbatobaText.Size = new System.Drawing.Size(132, 26);
            this.AlbatobaText.TabIndex = 3;
            this.AlbatobaText.Text = "8";
            this.AlbatobaText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(201, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ალბათობა";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "თქვენი თანხა:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TqveniTanxaText
            // 
            this.TqveniTanxaText.Location = new System.Drawing.Point(14, 330);
            this.TqveniTanxaText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TqveniTanxaText.Name = "TqveniTanxaText";
            this.TqveniTanxaText.Size = new System.Drawing.Size(132, 26);
            this.TqveniTanxaText.TabIndex = 6;
            this.TqveniTanxaText.Text = "10000";
            this.TqveniTanxaText.TextChanged += new System.EventHandler(this.TqveniTanxaText_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 326);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "გამოთვლა";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TanxaResultText
            // 
            this.TanxaResultText.Location = new System.Drawing.Point(335, 174);
            this.TanxaResultText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TanxaResultText.Multiline = true;
            this.TanxaResultText.Name = "TanxaResultText";
            this.TanxaResultText.ReadOnly = true;
            this.TanxaResultText.Size = new System.Drawing.Size(132, 25);
            this.TanxaResultText.TabIndex = 8;
            this.TanxaResultText.TextChanged += new System.EventHandler(this.TanxaResultText_TextChanged);
            // 
            // FsoniResultText
            // 
            this.FsoniResultText.Location = new System.Drawing.Point(335, 330);
            this.FsoniResultText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FsoniResultText.Multiline = true;
            this.FsoniResultText.Name = "FsoniResultText";
            this.FsoniResultText.ReadOnly = true;
            this.FsoniResultText.Size = new System.Drawing.Size(132, 25);
            this.FsoniResultText.TabIndex = 9;
            this.FsoniResultText.TextChanged += new System.EventHandler(this.FsoniResultText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(359, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "თანხა:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(359, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "ფსონი:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(90, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "ფსონის გაზრდისთვის საჭიროა:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NextBetText
            // 
            this.NextBetText.Location = new System.Drawing.Point(333, 371);
            this.NextBetText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextBetText.Multiline = true;
            this.NextBetText.Name = "NextBetText";
            this.NextBetText.ReadOnly = true;
            this.NextBetText.Size = new System.Drawing.Size(132, 25);
            this.NextBetText.TabIndex = 12;
            this.NextBetText.TextChanged += new System.EventHandler(this.NextBetText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(136, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "მაქსიმალური ფსონის გამოთვლა:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(149, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "საჭირო თანხის გამოთვლა:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 413);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NextBetText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FsoniResultText);
            this.Controls.Add(this.TanxaResultText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TqveniTanxaText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlbatobaText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FsoniText);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "CSGO500.Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FsoniText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AlbatobaText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TqveniTanxaText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TanxaResultText;
        private System.Windows.Forms.TextBox FsoniResultText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NextBetText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

