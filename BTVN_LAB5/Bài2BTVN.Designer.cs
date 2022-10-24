
namespace BTVN_LAB5
{
    partial class Bài2BTVN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChonle = new System.Windows.Forms.Button();
            this.btnChonchan = new System.Windows.Forms.Button();
            this.btnBinhphuong = new System.Windows.Forms.Button();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDelDaucuoi = new System.Windows.Forms.Button();
            this.btnTonglist = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnnhap = new System.Windows.Forms.Button();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listbox";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(38, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(135, 259);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChonle);
            this.groupBox1.Controls.Add(this.btnChonchan);
            this.groupBox1.Controls.Add(this.btnBinhphuong);
            this.groupBox1.Controls.Add(this.btnUp2);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnDelDaucuoi);
            this.groupBox1.Controls.Add(this.btnTonglist);
            this.groupBox1.Location = new System.Drawing.Point(199, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 247);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử lý listbox";
            // 
            // btnChonle
            // 
            this.btnChonle.Location = new System.Drawing.Point(7, 212);
            this.btnChonle.Name = "btnChonle";
            this.btnChonle.Size = new System.Drawing.Size(234, 23);
            this.btnChonle.TabIndex = 0;
            this.btnChonle.Text = "Chọn số lẻ";
            this.btnChonle.UseVisualStyleBackColor = true;
            this.btnChonle.Click += new System.EventHandler(this.btnChonle_Click);
            // 
            // btnChonchan
            // 
            this.btnChonchan.Location = new System.Drawing.Point(7, 183);
            this.btnChonchan.Name = "btnChonchan";
            this.btnChonchan.Size = new System.Drawing.Size(234, 23);
            this.btnChonchan.TabIndex = 0;
            this.btnChonchan.Text = "Chọn số chẵn";
            this.btnChonchan.UseVisualStyleBackColor = true;
            this.btnChonchan.Click += new System.EventHandler(this.btnChonchan_Click);
            // 
            // btnBinhphuong
            // 
            this.btnBinhphuong.Location = new System.Drawing.Point(7, 154);
            this.btnBinhphuong.Name = "btnBinhphuong";
            this.btnBinhphuong.Size = new System.Drawing.Size(234, 23);
            this.btnBinhphuong.TabIndex = 0;
            this.btnBinhphuong.Text = "Thay bằng bình phương";
            this.btnBinhphuong.UseVisualStyleBackColor = true;
            this.btnBinhphuong.Click += new System.EventHandler(this.btnBinhphuong_Click);
            // 
            // btnUp2
            // 
            this.btnUp2.Location = new System.Drawing.Point(7, 125);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(234, 23);
            this.btnUp2.TabIndex = 0;
            this.btnUp2.Text = "Tăng mỗi phần tử lên 2";
            this.btnUp2.UseVisualStyleBackColor = true;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(8, 96);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(234, 23);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Xóa phần tử đang chọn";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDelDaucuoi
            // 
            this.btnDelDaucuoi.Location = new System.Drawing.Point(7, 67);
            this.btnDelDaucuoi.Name = "btnDelDaucuoi";
            this.btnDelDaucuoi.Size = new System.Drawing.Size(234, 23);
            this.btnDelDaucuoi.TabIndex = 0;
            this.btnDelDaucuoi.Text = "Xóa phần tử đầu và cuối";
            this.btnDelDaucuoi.UseVisualStyleBackColor = true;
            this.btnDelDaucuoi.Click += new System.EventHandler(this.btnDelDaucuoi_Click);
            // 
            // btnTonglist
            // 
            this.btnTonglist.Location = new System.Drawing.Point(7, 38);
            this.btnTonglist.Name = "btnTonglist";
            this.btnTonglist.Size = new System.Drawing.Size(234, 23);
            this.btnTonglist.TabIndex = 0;
            this.btnTonglist.Text = "Tổng các phần tử trong List";
            this.btnTonglist.UseVisualStyleBackColor = true;
            this.btnTonglist.Click += new System.EventHandler(this.btnTonglist_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kết thúc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(64, 104);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(75, 23);
            this.btnnhap.TabIndex = 4;
            this.btnnhap.Text = "Nhập";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(38, 75);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(135, 23);
            this.txtnhap.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "LISTBOX";
            // 
            // Bài2BTVN
            // 
            this.AcceptButton = this.btnnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.btnnhap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Bài2BTVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChonle;
        private System.Windows.Forms.Button btnChonchan;
        private System.Windows.Forms.Button btnBinhphuong;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDelDaucuoi;
        private System.Windows.Forms.Button btnTonglist;
    }
}

