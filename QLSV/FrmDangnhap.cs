﻿using System;
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
    public partial class FrmDangnhap : Form
    {
        public FrmDangnhap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (QLSVEntities db = new QLSVEntities())
            {
                string s = "SELECT * " +
                           "FROM _User WHERE " +
                            "username='"+ txtUsername.Text + "'" +
                            "AND password='" + txtPassword.Text + "'";
                var list = db.C_User.SqlQuery(s).ToList();
                if (list.Count > 0)
                {
                    //MessageBox.Show("Đăng nhập thành công nha!!!", "Thông báo");
                    Luu.KT = !Luu.KT;
                    Close();
                } else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông báo");
                }
            };
        }
    }
}
