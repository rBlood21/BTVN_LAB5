using BTVN_LAB5.Core.B1;
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
    public partial class Bai1BTVN : Form
    {
        ZDictionary dic;
        public Bai1BTVN()
        {
            InitializeComponent();
            dic = new ZDictionary();
            rtxtVN.ReadOnly = true;
            rtxtEN.ReadOnly = true;
        }

        private void Bai1BTVN_Load(object sender, EventArgs e)
        {
            cbbEN.Items.Clear();
            dic.Load();
            var tmpList = dic.dics.ToList();
            tmpList.ForEach(x => {
                cbbEN.Items.Add(x.Value.Trim());
                cbbVN.Items.Add(x.Key.Trim());
            });
        }
        private void cbbEN_TextChanged(object sender, EventArgs e)
        {

            rtxtVN.ResetText();
            var tmpList = dic.dics.ToList().Where(x => x.Value.Equals(cbbEN.Text)).ToList();
            if (!string.IsNullOrEmpty(cbbEN.Text) && tmpList.Count != 0)
            {
                tmpList.ForEach(x => rtxtVN.AppendText(x.Key + "\n"));
            }
        }
        private void cbbVN_TextChanged(object sender, EventArgs e)
        {

            rtxtEN.ResetText();
            var tmpList = dic.dics.ToList().Where(x => x.Key.Equals(cbbVN.Text)).ToList();
            if (!string.IsNullOrEmpty(cbbVN.Text) && tmpList.Count != 0)
            {
                tmpList.ForEach(x => rtxtEN.AppendText(x.Value + "\n"));
            }
        }
    }
}
