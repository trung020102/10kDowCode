using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lock_unlock(Luu.KT);
        }
        void lock_unlock(bool kt)
        {
            mnuDangnhap.Enabled = mnuThoat.Enabled = kt;
            mnuDangxuat.Enabled = mnuDanhmuc.Enabled = mnuTracuu.Enabled = mnuBaocao.Enabled = !kt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lock_unlock(Luu.KT);
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuDangnhap_Click(object sender, EventArgs e)
        {
            FrmDangnhap fLogin = new FrmDangnhap();
            fLogin.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDanhmucLop_Click(object sender, EventArgs e)
        {
            new FrmLop().Show();
        }

        private void mnuDanhmucSV_Click(object sender, EventArgs e)
        {
            new FrmSV().Show();
        }
    }
}
