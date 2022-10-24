
namespace BTVN_LAB5
{
    partial class Bai1BTVN
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxtEN = new System.Windows.Forms.RichTextBox();
            this.cbbVN = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtVN = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbEN = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtxtEN);
            this.tabPage2.Controls.Add(this.cbbVN);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(416, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VIỆT - ANH";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxtEN
            // 
            this.rtxtEN.Location = new System.Drawing.Point(232, 33);
            this.rtxtEN.Name = "rtxtEN";
            this.rtxtEN.Size = new System.Drawing.Size(150, 274);
            this.rtxtEN.TabIndex = 2;
            this.rtxtEN.Text = "";
            // 
            // cbbVN
            // 
            this.cbbVN.FormattingEnabled = true;
            this.cbbVN.Location = new System.Drawing.Point(15, 33);
            this.cbbVN.Name = "cbbVN";
            this.cbbVN.Size = new System.Drawing.Size(121, 23);
            this.cbbVN.TabIndex = 1;
            this.cbbVN.TextChanged += new System.EventHandler(this.cbbVN_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tiếng anh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiếng Việt";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtxtVN);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbbEN);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(416, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ANH - VIỆT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtVN
            // 
            this.rtxtVN.Location = new System.Drawing.Point(238, 36);
            this.rtxtVN.Name = "rtxtVN";
            this.rtxtVN.Size = new System.Drawing.Size(158, 262);
            this.rtxtVN.TabIndex = 3;
            this.rtxtVN.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiếng Việt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiếng Anh";
            // 
            // cbbEN
            // 
            this.cbbEN.FormattingEnabled = true;
            this.cbbEN.Location = new System.Drawing.Point(6, 36);
            this.cbbEN.Name = "cbbEN";
            this.cbbEN.Size = new System.Drawing.Size(153, 23);
            this.cbbEN.TabIndex = 0;
            this.cbbEN.TextChanged += new System.EventHandler(this.cbbEN_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(424, 376);
            this.tabControl1.TabIndex = 1;
            // 
            // Bai1BTVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 398);
            this.Controls.Add(this.tabControl1);
            this.Name = "Bai1BTVN";
            this.Text = "Bai1BTVN";
            this.Load += new System.EventHandler(this.Bai1BTVN_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEN;
        private System.Windows.Forms.ComboBox cbbVN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtVN;
        private System.Windows.Forms.RichTextBox rtxtEN;
    }
}