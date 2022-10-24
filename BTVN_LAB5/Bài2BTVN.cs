using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_LAB5
{
    public partial class Bài2BTVN : Form
    {
        public Bài2BTVN()
        {
            InitializeComponent();
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnhap.Text))
            {
                listBox1.Items.Add(txtnhap.Text);
                txtnhap.Clear();
                txtnhap.Focus();
            }
        }
        private void btnTonglist_Click(object sender, EventArgs e)
        {
            double tong = 0;
            foreach (string s in listBox1.Items)
            {
                tong += double.Parse(s);
            }
            MessageBox.Show("Tổng các phần tử trong listbox:" + " " + tong.ToString());
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
        }

        private void btnDelDaucuoi_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 2)
                listBox1.Items.RemoveAt(0);
            else
            {
                listBox1.Items.RemoveAt(0);
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
        
        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            for(int i = listBox1.Items.Count -1; i >=0; i--)
            {
                if(!string.IsNullOrEmpty(listBox1.Items[i] as string))
                {
                    double t = double.Parse((listBox1.Items[i].ToString()));
                    t = t + 2;
                    listBox1.Items[i] = t.ToString();
                }
            }
        }

        private void btnBinhphuong_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(listBox1.Items[i] as string))
                {
                    double t = double.Parse((listBox1.Items[i].ToString()));
                    t = Math.Pow(t, 2);
                    listBox1.Items[i] = t.ToString();
                }
            }
        }

        private void btnChonchan_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(listBox1.Items[i] as string))
                {
                    double t = double.Parse((listBox1.Items[i].ToString()));
                    if (t % 2 == 0)
                        listBox1.SetSelected(i, true);
                }
            }
        }

        private void btnChonle_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(listBox1.Items[i] as string))
                {
                    double t = double.Parse((listBox1.Items[i].ToString()));
                    if (t % 2 == 1)
                        listBox1.SetSelected(i, true);
                }
            }
        }
    }
}
