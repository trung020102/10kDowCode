using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FrmSV : Form
    {
        int Id;
        SV svModel = new SV();
        public FrmSV()
        {
            InitializeComponent();
            loadDataTable();
            loadDataToCombobox();
        }
        void loadDataTable(string s = "*")
        {
            dataGrVSV.AutoGenerateColumns = false;
            using (QLSVEntities db = new QLSVEntities())
            {
                if (s == "*")
                {
                    dataGrVSV.DataSource = Luu.CreateDataTable<SV>(db.SVs.ToList<SV>());
                } else
                {
                    string sql = "SELECT * FROM sv WHERE id__lop="+s;
                    dataGrVSV.DataSource = Luu.CreateDataTable<SV>(db.SVs.SqlQuery(sql).ToList());
                }
            };
        }
        void loadDataToCombobox()
        {
            using (QLSVEntities db = new QLSVEntities())
            {                
                var listClassroom = db.Lops.ToList<Lop>();
                foreach (var item in listClassroom)
                {
                    cbbClassId.Items.Add(item.id);
                    cbbClassname.Items.Add(item.tenlop);
                }
            };
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportDocument rptDoc = new ReportDocument();

            // tập tin .xsd

            //MyDataSample ds = new MyDataSample();

            DataTable dt = new DataTable();

            // Đặt tên cho DataTable

            dt.TableName = "Crystal Report Example";

            //dt = getAllGeres();//Gọi phương thức getAllGenres

            //ds.Tables[0].Merge(dt);

            // Lấy đường dẫn tập tin crystal report (CrystalReport.rpt)

            string reportPath = Application.StartupPath + "\\" + "CrystalReport.rpt";

            rptDoc.Load(reportPath);

            //gán dataset đến report viewer

            //rptDoc.SetDataSource(ds);

            //CrystalReportViewer1.ReportSource = rptDoc;

            //CrystalReportViewer1.DisplayToolbar = true;
        }

        private void btnEnableTxtAdd_Click(object sender, EventArgs e)
        {
            txtStudentname.Enabled = !txtStudentname.Enabled;
            txtScore.Enabled = !txtScore.Enabled;
            txtEmail.Enabled = !txtEmail.Enabled;

            btnUpdateStudent.Enabled = btnDeleteStudent.Enabled = !txtStudentname.Enabled;
            btnAddStudent.Enabled = txtStudentname.Enabled;
            btnCancelFilter.Enabled = false;
        }

        private void dataGrVSV_Click(object sender, EventArgs e)
        {
            int i = dataGrVSV.CurrentRow.Index;
            Id = int.Parse(dataGrVSV[1, i].Value.ToString());
            txtStudentname.Text = dataGrVSV[3, i].Value.ToString();
            txtScore.Text = dataGrVSV[4, i].Value.ToString();
            txtEmail.Text = dataGrVSV[5, i].Value.ToString();
            btnDeleteStudent.Enabled = btnUpdateStudent.Enabled = true;
            btnAddStudent.Enabled = false;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            svModel.id = Id;
            svModel.tensv = txtStudentname.Text;
            svModel.dtb = Decimal.Parse(txtScore.Text);
            svModel.email = txtEmail.Text;
            svModel.id__lop = int.Parse(cbbClassId.SelectedItem.ToString());
            using (QLSVEntities db = new QLSVEntities())
            {
                db.SVs.Add(svModel);
                db.SaveChanges();
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo");
                txtStudentname.Text = "";
                txtScore.Text = "";
                txtEmail.Text = "";
                loadDataTable();
            };
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            svModel.id = Id;
            svModel.tensv = txtStudentname.Text;
            svModel.dtb = Decimal.Parse(txtScore.Text);
            svModel.email = txtEmail.Text;
            using (QLSVEntities db = new QLSVEntities())
            {
                db.Entry(svModel).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo");
                txtStudentname.Text = "";
                txtScore.Text = "";
                txtEmail.Text = "";
                btnUpdateStudent.Enabled = btnDeleteStudent.Enabled = false;
                btnAddStudent.Enabled = true;
                loadDataTable();
            };
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            svModel.id = Id;
            svModel.tensv = txtStudentname.Text;
            svModel.dtb = Decimal.Parse(txtScore.Text);
            svModel.email = txtEmail.Text;
            using (QLSVEntities db = new QLSVEntities())
            {
                db.Entry(svModel).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
                txtStudentname.Text = "";
                txtScore.Text = "";
                txtEmail.Text = "";
                btnUpdateStudent.Enabled = btnDeleteStudent.Enabled = false;
                btnAddStudent.Enabled = true;
                loadDataTable();
            };
        }

        private void btnCancelStudent_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSV_Load(object sender, EventArgs e)
        {

        }

        private void cbbClassname_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbbClassId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadDataTable(cbbClassId.Items[cbbClassId.SelectedIndex].ToString());
            btnCancelFilter.Enabled = true;
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            loadDataTable();
            loadDataToCombobox();
        }
    }
}
