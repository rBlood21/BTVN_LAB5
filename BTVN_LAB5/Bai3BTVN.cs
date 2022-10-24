using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTVN_LAB5
{
    public partial class Bai3BTVN : Form
    {
        public Bai3BTVN()
        {
            InitializeComponent();
        }

        private void Bai3BTVN_Load(object sender, EventArgs e)
        {
            string[] danhBa = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            foreach (string s in danhBa)
            {
                treeView1.Nodes.Add(s);
            }
            btnAdd.Enabled = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (txtfirst.Text.ToLower().Substring(0, 1).Equals(node.Text.ToLower()))
                {
                    index = node.Index;
                    break;
                }
            }
            treeView1.Nodes[index].Nodes.Add(txtfirst.Text + " , " + txtlast.Text);
            treeView1.ExpandAll();
        }



        private void txtfirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider1.SetError(ctr, "không được nhập số");
            }
            else this.errorProvider1.Clear();
        }

        private void txtfirst_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "không được để trống");

            }
            else
            {
                this.errorProvider1.Clear();

            }
        }

        private void txtfirst_TextChanged(object sender, EventArgs e)
        {

            if (txtfirst.Text.Trim().Length != 0 && txtlast.Text.Trim().Length != 0)
                btnAdd.Enabled = true;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
                this.Close();
        }

        
    }
 }

