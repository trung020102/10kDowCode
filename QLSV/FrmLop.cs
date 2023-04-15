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
    public partial class FrmLop : Form
    {
        int Id;
        Lop lopModel = new Lop();
        public FrmLop()
        {
            InitializeComponent();
            loadDataTable();
        }
        void loadDataTable()
        {
            dataGrVLop.AutoGenerateColumns = false;
            using (QLSVEntities db = new QLSVEntities()) {
                dataGrVLop.DataSource = Luu.CreateDataTable<Lop>(db.Lops.ToList<Lop>());
            };
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            lopModel.tenlop = txtClassname.Text;
            using (QLSVEntities db = new QLSVEntities()) {
                db.Lops.Add(lopModel);
                db.SaveChanges();
                MessageBox.Show("Thêm lớp thành công!", "Thông báo");
                txtClassname.Text = "";
                loadDataTable();
            };
        }

        private void btnEnableTxtAdd_Click(object sender, EventArgs e)
        {
            txtClassname.Enabled = !txtClassname.Enabled;
        }

        private void btnCancelClass_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGrVLop_Click(object sender, EventArgs e)
        {
            int i = dataGrVLop.CurrentRow.Index;
            Id = int.Parse(dataGrVLop[1, i].Value.ToString());
            txtClassname.Text = dataGrVLop[2, i].Value.ToString();
            btnDeleteClass.Enabled = btnUpdateClass.Enabled = true;
            btnAddClass.Enabled = false;
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            lopModel.id = Id;
            lopModel.tenlop = txtClassname.Text;
            using (QLSVEntities db = new QLSVEntities())
            {
                db.Entry(lopModel).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Cập nhật lớp thành công!", "Thông báo");
                txtClassname.Text = "";
                btnDeleteClass.Enabled = btnUpdateClass.Enabled = false;
                btnAddClass.Enabled = true;
                loadDataTable();
            };
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            lopModel.id = Id;
            lopModel.tenlop = txtClassname.Text;
            using (QLSVEntities db = new QLSVEntities())
            {
                db.Entry(lopModel).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("Xóa lớp thành công!", "Thông báo");
                txtClassname.Text = "";
                btnDeleteClass.Enabled = btnUpdateClass.Enabled = false;
                btnAddClass.Enabled = true;
                loadDataTable();
            };
        }
    }
}
