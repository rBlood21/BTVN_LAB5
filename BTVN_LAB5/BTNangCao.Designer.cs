
namespace BTVN_LAB5
{
    partial class BTNangCao
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
            this.btnNhaprandom = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDeldangchon = new System.Windows.Forms.Button();
            this.btnXoaSon = new System.Windows.Forms.Button();
            this.BtnXoaLe = new System.Windows.Forms.Button();
            this.btnChuyenclickHoa = new System.Windows.Forms.Button();
            this.btnChuyenclickThuong = new System.Windows.Forms.Button();
            this.btnClickHoachudau = new System.Windows.Forms.Button();
            this.btnXoatatca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhaprandom
            // 
            this.btnNhaprandom.Location = new System.Drawing.Point(13, 13);
            this.btnNhaprandom.Name = "btnNhaprandom";
            this.btnNhaprandom.Size = new System.Drawing.Size(139, 31);
            this.btnNhaprandom.TabIndex = 0;
            this.btnNhaprandom.Text = "Nhập tên ngẫu nhiên";
            this.btnNhaprandom.UseVisualStyleBackColor = true;
            this.btnNhaprandom.Click += new System.EventHandler(this.btnNhaprandom_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(13, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(139, 289);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnDeldangchon
            // 
            this.btnDeldangchon.Location = new System.Drawing.Point(192, 93);
            this.btnDeldangchon.Name = "btnDeldangchon";
            this.btnDeldangchon.Size = new System.Drawing.Size(236, 23);
            this.btnDeldangchon.TabIndex = 2;
            this.btnDeldangchon.Text = "Xóa phần tử đang chọn";
            this.btnDeldangchon.UseVisualStyleBackColor = true;
            this.btnDeldangchon.Click += new System.EventHandler(this.btnDeldangchon_Click);
            // 
            // btnXoaSon
            // 
            this.btnXoaSon.Location = new System.Drawing.Point(192, 122);
            this.btnXoaSon.Name = "btnXoaSon";
            this.btnXoaSon.Size = new System.Drawing.Size(236, 23);
            this.btnXoaSon.TabIndex = 2;
            this.btnXoaSon.Text = "Xóa phần tử có tên là Sơn";
            this.btnXoaSon.UseVisualStyleBackColor = true;
            this.btnXoaSon.Click += new System.EventHandler(this.btnXoaSon_Click);
            // 
            // BtnXoaLe
            // 
            this.BtnXoaLe.Location = new System.Drawing.Point(192, 151);
            this.BtnXoaLe.Name = "BtnXoaLe";
            this.BtnXoaLe.Size = new System.Drawing.Size(236, 23);
            this.BtnXoaLe.TabIndex = 2;
            this.BtnXoaLe.Text = "Xóa phần tử có họ là Lê";
            this.BtnXoaLe.UseVisualStyleBackColor = true;
            this.BtnXoaLe.Click += new System.EventHandler(this.BtnXoaLe_Click);
            // 
            // btnChuyenclickHoa
            // 
            this.btnChuyenclickHoa.Location = new System.Drawing.Point(192, 180);
            this.btnChuyenclickHoa.Name = "btnChuyenclickHoa";
            this.btnChuyenclickHoa.Size = new System.Drawing.Size(236, 23);
            this.btnChuyenclickHoa.TabIndex = 2;
            this.btnChuyenclickHoa.Text = "Chuyển PT đang chọn thành chữ Hoa";
            this.btnChuyenclickHoa.UseVisualStyleBackColor = true;
            this.btnChuyenclickHoa.Click += new System.EventHandler(this.btnChuyenclickHoa_Click);
            // 
            // btnChuyenclickThuong
            // 
            this.btnChuyenclickThuong.Location = new System.Drawing.Point(192, 209);
            this.btnChuyenclickThuong.Name = "btnChuyenclickThuong";
            this.btnChuyenclickThuong.Size = new System.Drawing.Size(236, 23);
            this.btnChuyenclickThuong.TabIndex = 2;
            this.btnChuyenclickThuong.Text = "Chuyển PT đang chọn thành chữ thường";
            this.btnChuyenclickThuong.UseVisualStyleBackColor = true;
            this.btnChuyenclickThuong.Click += new System.EventHandler(this.btnChuyenclickThuong_Click);
            // 
            // btnClickHoachudau
            // 
            this.btnClickHoachudau.Location = new System.Drawing.Point(192, 238);
            this.btnClickHoachudau.Name = "btnClickHoachudau";
            this.btnClickHoachudau.Size = new System.Drawing.Size(236, 23);
            this.btnClickHoachudau.TabIndex = 2;
            this.btnClickHoachudau.Text = "Chuyển PT đang chọn thành viết hoa mỗi từ";
            this.btnClickHoachudau.UseVisualStyleBackColor = true;
            // 
            // btnXoatatca
            // 
            this.btnXoatatca.Location = new System.Drawing.Point(192, 267);
            this.btnXoatatca.Name = "btnXoatatca";
            this.btnXoatatca.Size = new System.Drawing.Size(236, 23);
            this.btnXoatatca.TabIndex = 2;
            this.btnXoatatca.Text = "Xóa tất cả phần tử";
            this.btnXoatatca.UseVisualStyleBackColor = true;
            this.btnXoatatca.Click += new System.EventHandler(this.btnXoatatca_Click);
            // 
            // BTNangCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 384);
            this.Controls.Add(this.btnXoatatca);
            this.Controls.Add(this.btnClickHoachudau);
            this.Controls.Add(this.btnChuyenclickThuong);
            this.Controls.Add(this.btnChuyenclickHoa);
            this.Controls.Add(this.BtnXoaLe);
            this.Controls.Add(this.btnXoaSon);
            this.Controls.Add(this.btnDeldangchon);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnNhaprandom);
            this.Name = "BTNangCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTNangCao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhaprandom;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDeldangchon;
        private System.Windows.Forms.Button btnXoaSon;
        private System.Windows.Forms.Button BtnXoaLe;
        private System.Windows.Forms.Button btnChuyenclickHoa;
        private System.Windows.Forms.Button btnChuyenclickThuong;
        private System.Windows.Forms.Button btnClickHoachudau;
        private System.Windows.Forms.Button btnXoatatca;
    }
}