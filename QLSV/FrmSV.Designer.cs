
namespace QLSV
{
    partial class FrmSV
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
            this.dataGrVSV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLopCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEnableTxtAdd = new System.Windows.Forms.Button();
            this.btnCancelStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtStudentname = new System.Windows.Forms.TextBox();
            this.lbStudentname = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbClassname = new System.Windows.Forms.Label();
            this.cbbClassId = new System.Windows.Forms.ComboBox();
            this.cbbClassname = new System.Windows.Forms.ComboBox();
            this.btnCancelFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrVSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrVSV
            // 
            this.dataGrVSV.AllowUserToDeleteRows = false;
            this.dataGrVSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrVSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.STTCol,
            this.IDLopCol,
            this.StudentnameCol,
            this.StudentScore,
            this.StudentEmail});
            this.dataGrVSV.Location = new System.Drawing.Point(63, 179);
            this.dataGrVSV.Name = "dataGrVSV";
            this.dataGrVSV.ReadOnly = true;
            this.dataGrVSV.RowHeadersWidth = 62;
            this.dataGrVSV.RowTemplate.Height = 28;
            this.dataGrVSV.Size = new System.Drawing.Size(831, 273);
            this.dataGrVSV.TabIndex = 19;
            this.dataGrVSV.Click += new System.EventHandler(this.dataGrVSV_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "id";
            this.STT.HeaderText = "ID";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            this.STT.Width = 150;
            // 
            // STTCol
            // 
            this.STTCol.DataPropertyName = "STT";
            this.STTCol.HeaderText = "STT";
            this.STTCol.MinimumWidth = 8;
            this.STTCol.Name = "STTCol";
            this.STTCol.ReadOnly = true;
            this.STTCol.Width = 150;
            // 
            // IDLopCol
            // 
            this.IDLopCol.DataPropertyName = "id__lop";
            this.IDLopCol.HeaderText = "Mã lớp đang học";
            this.IDLopCol.MinimumWidth = 8;
            this.IDLopCol.Name = "IDLopCol";
            this.IDLopCol.ReadOnly = true;
            this.IDLopCol.Width = 150;
            // 
            // StudentnameCol
            // 
            this.StudentnameCol.DataPropertyName = "tensv";
            this.StudentnameCol.HeaderText = "Tên SV";
            this.StudentnameCol.MinimumWidth = 8;
            this.StudentnameCol.Name = "StudentnameCol";
            this.StudentnameCol.ReadOnly = true;
            this.StudentnameCol.Width = 150;
            // 
            // StudentScore
            // 
            this.StudentScore.DataPropertyName = "dtb";
            this.StudentScore.HeaderText = "Điểm TB";
            this.StudentScore.MinimumWidth = 8;
            this.StudentScore.Name = "StudentScore";
            this.StudentScore.ReadOnly = true;
            this.StudentScore.Width = 150;
            // 
            // StudentEmail
            // 
            this.StudentEmail.DataPropertyName = "email";
            this.StudentEmail.HeaderText = "Email";
            this.StudentEmail.MinimumWidth = 8;
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.ReadOnly = true;
            this.StudentEmail.Width = 150;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(754, 120);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 42);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "In ấn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnEnableTxtAdd
            // 
            this.btnEnableTxtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableTxtAdd.Location = new System.Drawing.Point(577, 28);
            this.btnEnableTxtAdd.Name = "btnEnableTxtAdd";
            this.btnEnableTxtAdd.Size = new System.Drawing.Size(56, 26);
            this.btnEnableTxtAdd.TabIndex = 20;
            this.btnEnableTxtAdd.Text = "+";
            this.btnEnableTxtAdd.UseVisualStyleBackColor = true;
            this.btnEnableTxtAdd.Click += new System.EventHandler(this.btnEnableTxtAdd_Click);
            // 
            // btnCancelStudent
            // 
            this.btnCancelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelStudent.Location = new System.Drawing.Point(754, 59);
            this.btnCancelStudent.Name = "btnCancelStudent";
            this.btnCancelStudent.Size = new System.Drawing.Size(109, 49);
            this.btnCancelStudent.TabIndex = 15;
            this.btnCancelStudent.Text = "Hủy bỏ";
            this.btnCancelStudent.UseVisualStyleBackColor = true;
            this.btnCancelStudent.Click += new System.EventHandler(this.btnCancelStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.Location = new System.Drawing.Point(639, 59);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(109, 49);
            this.btnDeleteStudent.TabIndex = 16;
            this.btnDeleteStudent.Text = "Xóa";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.Location = new System.Drawing.Point(754, 4);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(109, 49);
            this.btnUpdateStudent.TabIndex = 17;
            this.btnUpdateStudent.Text = "Cập nhật";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(639, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(109, 49);
            this.btnAddStudent.TabIndex = 18;
            this.btnAddStudent.Text = "Thêm";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtStudentname
            // 
            this.txtStudentname.Enabled = false;
            this.txtStudentname.Location = new System.Drawing.Point(216, 28);
            this.txtStudentname.Name = "txtStudentname";
            this.txtStudentname.Size = new System.Drawing.Size(355, 26);
            this.txtStudentname.TabIndex = 14;
            // 
            // lbStudentname
            // 
            this.lbStudentname.AutoSize = true;
            this.lbStudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentname.Location = new System.Drawing.Point(108, 29);
            this.lbStudentname.Name = "lbStudentname";
            this.lbStudentname.Size = new System.Drawing.Size(102, 25);
            this.lbStudentname.TabIndex = 13;
            this.lbStudentname.Text = "Họ tên SV";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(108, 59);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(88, 25);
            this.lbScore.TabIndex = 13;
            this.lbScore.Text = "Điểm TB";
            // 
            // txtScore
            // 
            this.txtScore.Enabled = false;
            this.txtScore.Location = new System.Drawing.Point(216, 58);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(355, 26);
            this.txtScore.TabIndex = 14;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(108, 92);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 25);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(216, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(355, 26);
            this.txtEmail.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email";
            // 
            // lbClassname
            // 
            this.lbClassname.AutoSize = true;
            this.lbClassname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassname.Location = new System.Drawing.Point(108, 137);
            this.lbClassname.Name = "lbClassname";
            this.lbClassname.Size = new System.Drawing.Size(131, 25);
            this.lbClassname.TabIndex = 13;
            this.lbClassname.Text = "Lớp đang học";
            // 
            // cbbClassId
            // 
            this.cbbClassId.FormattingEnabled = true;
            this.cbbClassId.Location = new System.Drawing.Point(247, 134);
            this.cbbClassId.Name = "cbbClassId";
            this.cbbClassId.Size = new System.Drawing.Size(82, 28);
            this.cbbClassId.TabIndex = 22;
            this.cbbClassId.SelectionChangeCommitted += new System.EventHandler(this.cbbClassId_SelectionChangeCommitted);
            // 
            // cbbClassname
            // 
            this.cbbClassname.FormattingEnabled = true;
            this.cbbClassname.Location = new System.Drawing.Point(335, 134);
            this.cbbClassname.Name = "cbbClassname";
            this.cbbClassname.Size = new System.Drawing.Size(236, 28);
            this.cbbClassname.TabIndex = 22;
            this.cbbClassname.SelectionChangeCommitted += new System.EventHandler(this.cbbClassname_SelectionChangeCommitted);
            // 
            // btnCancelFilter
            // 
            this.btnCancelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelFilter.Location = new System.Drawing.Point(639, 120);
            this.btnCancelFilter.Name = "btnCancelFilter";
            this.btnCancelFilter.Size = new System.Drawing.Size(109, 42);
            this.btnCancelFilter.TabIndex = 21;
            this.btnCancelFilter.Text = "Hủy Lọc";
            this.btnCancelFilter.UseVisualStyleBackColor = true;
            this.btnCancelFilter.Click += new System.EventHandler(this.btnCancelFilter_Click);
            // 
            // FrmSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 512);
            this.Controls.Add(this.cbbClassname);
            this.Controls.Add(this.cbbClassId);
            this.Controls.Add(this.dataGrVSV);
            this.Controls.Add(this.btnCancelFilter);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEnableTxtAdd);
            this.Controls.Add(this.btnCancelStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtStudentname);
            this.Controls.Add(this.lbClassname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbStudentname);
            this.Name = "FrmSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.FrmSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrVSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrVSV;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEnableTxtAdd;
        private System.Windows.Forms.Button btnCancelStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtStudentname;
        private System.Windows.Forms.Label lbStudentname;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLopCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbClassname;
        private System.Windows.Forms.ComboBox cbbClassId;
        private System.Windows.Forms.ComboBox cbbClassname;
        private System.Windows.Forms.Button btnCancelFilter;
    }
}