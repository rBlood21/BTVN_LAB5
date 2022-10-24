using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTVN_LAB5
{
    public partial class BTNangCao : Form
    {
        string[] ho = {"Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai","Huỳnh", "La"};
        string[] tenlot = {"Quang","Thành","Ngọc","Anh", "Xuân", "Bảo","Cẩm","Thị","Kim","Thái","Hồng"};
        string[] ten = {"Hà","Danh","Sơn","Mai","Thắng","Kỳ","Thành","Lâm","Tâm","Phụng","Thắm"};


public BTNangCao()
        {
            InitializeComponent();
        }

        private void btnNhaprandom_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 50; i++)
            {
                string hovaten = ho[r.Next(0, ho.Length)] + " " + tenlot[r.Next(0, tenlot.Length)] + " " + ten[r.Next(0, ten.Length)];
                if (!listBox1.Items.Contains(hovaten))
                    listBox1.Items.Add(hovaten);
            }
        }
        private void btnDeldangchon_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
        }

        private void btnXoaSon_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                if (listBox1.Items[i].ToString().EndsWith("Sơn"))
                    listBox1.Items.RemoveAt(i);
        }

        private void BtnXoaLe_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                if (listBox1.Items[i].ToString().StartsWith("Lê"))
                    listBox1.Items.RemoveAt(i);
        }
        private void btnChuyenclickHoa_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Insert(i, listBox1.Items[i].ToString().ToUpper());
                listBox1.Items.RemoveAt(i + 1);
                listBox1.SetSelected(i, true);
            }
        }
        private void btnChuyenclickThuong_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Insert(i, listBox1.Items[i].ToString().ToLower());
                listBox1.Items.RemoveAt(i + 1);
                listBox1.SetSelected(i, true);
            }
        }
        private void btnXoatatca_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
