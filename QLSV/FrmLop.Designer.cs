
namespace QLSV
{
    partial class FrmLop
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
            this.dataGrVLop = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.txtClassname = new System.Windows.Forms.TextBox();
            this.lbClassname = new System.Windows.Forms.Label();
            this.btnEnableTxtAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrVLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrVLop
            // 
            this.dataGrVLop.AllowUserToDeleteRows = false;
            this.dataGrVLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrVLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.STTCol,
            this.ClassnameCol});
            this.dataGrVLop.Location = new System.Drawing.Point(25, 157);
            this.dataGrVLop.Name = "dataGrVLop";
            this.dataGrVLop.ReadOnly = true;
            this.dataGrVLop.RowHeadersWidth = 62;
            this.dataGrVLop.RowTemplate.Height = 28;
            this.dataGrVLop.Size = new System.Drawing.Size(756, 287);
            this.dataGrVLop.TabIndex = 10;
            this.dataGrVLop.Click += new System.EventHandler(this.dataGrVLop_Click);
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
            // ClassnameCol
            // 
            this.ClassnameCol.DataPropertyName = "tenlop";
            this.ClassnameCol.HeaderText = "Tên lớp";
            this.ClassnameCol.MinimumWidth = 8;
            this.ClassnameCol.Name = "ClassnameCol";
            this.ClassnameCol.ReadOnly = true;
            this.ClassnameCol.Width = 150;
            // 
            // btnCancelClass
            // 
            this.btnCancelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelClass.Location = new System.Drawing.Point(673, 62);
            this.btnCancelClass.Name = "btnCancelClass";
            this.btnCancelClass.Size = new System.Drawing.Size(109, 49);
            this.btnCancelClass.TabIndex = 6;
            this.btnCancelClass.Text = "Hủy bỏ";
            this.btnCancelClass.UseVisualStyleBackColor = true;
            this.btnCancelClass.Click += new System.EventHandler(this.btnCancelClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.Location = new System.Drawing.Point(558, 62);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(109, 49);
            this.btnDeleteClass.TabIndex = 7;
            this.btnDeleteClass.Text = "Xóa";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClass.Location = new System.Drawing.Point(673, 7);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(109, 49);
            this.btnUpdateClass.TabIndex = 8;
            this.btnUpdateClass.Text = "Cập nhật";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.Location = new System.Drawing.Point(558, 7);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(109, 49);
            this.btnAddClass.TabIndex = 9;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // txtClassname
            // 
            this.txtClassname.Enabled = false;
            this.txtClassname.Location = new System.Drawing.Point(135, 31);
            this.txtClassname.Name = "txtClassname";
            this.txtClassname.Size = new System.Drawing.Size(355, 26);
            this.txtClassname.TabIndex = 5;
            // 
            // lbClassname
            // 
            this.lbClassname.AutoSize = true;
            this.lbClassname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassname.Location = new System.Drawing.Point(19, 24);
            this.lbClassname.Name = "lbClassname";
            this.lbClassname.Size = new System.Drawing.Size(110, 32);
            this.lbClassname.TabIndex = 4;
            this.lbClassname.Text = "Tên lớp";
            // 
            // btnEnableTxtAdd
            // 
            this.btnEnableTxtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableTxtAdd.Location = new System.Drawing.Point(496, 31);
            this.btnEnableTxtAdd.Name = "btnEnableTxtAdd";
            this.btnEnableTxtAdd.Size = new System.Drawing.Size(56, 26);
            this.btnEnableTxtAdd.TabIndex = 11;
            this.btnEnableTxtAdd.Text = "+";
            this.btnEnableTxtAdd.UseVisualStyleBackColor = true;
            this.btnEnableTxtAdd.Click += new System.EventHandler(this.btnEnableTxtAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(25, 75);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 56);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "In ấn";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // FrmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEnableTxtAdd);
            this.Controls.Add(this.dataGrVLop);
            this.Controls.Add(this.btnCancelClass);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.txtClassname);
            this.Controls.Add(this.lbClassname);
            this.Name = "FrmLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrVLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrVLop;
        private System.Windows.Forms.Button btnCancelClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.TextBox txtClassname;
        private System.Windows.Forms.Label lbClassname;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassnameCol;
        private System.Windows.Forms.Button btnEnableTxtAdd;
        private System.Windows.Forms.Button btnPrint;
    }
}