namespace Crud.Vistas
{
    partial class Reportes
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
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.NumReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnEnrolledN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxProject = new System.Windows.Forms.TextBox();
            this.txtBoxWeek = new System.Windows.Forms.TextBox();
            this.txtBoxCompanyName = new System.Windows.Forms.TextBox();
            this.txtBoxEnrolledNum = new System.Windows.Forms.TextBox();
            this.txtBoxReportNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxProjectO = new System.Windows.Forms.TextBox();
            this.txtBoxWeekO = new System.Windows.Forms.TextBox();
            this.txtBoxCompanyNameO = new System.Windows.Forms.TextBox();
            this.txtBoxEnrolledNumO = new System.Windows.Forms.TextBox();
            this.txtBoxReportNumO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumReport,
            this.alumnEnrolledN,
            this.companyName,
            this.week,
            this.project});
            this.dgvReports.Location = new System.Drawing.Point(333, 12);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(548, 303);
            this.dgvReports.TabIndex = 0;
            this.dgvReports.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReports_CellDoubleClick);
            // 
            // NumReport
            // 
            this.NumReport.HeaderText = "NumReporte";
            this.NumReport.Name = "NumReport";
            // 
            // alumnEnrolledN
            // 
            this.alumnEnrolledN.HeaderText = "Matricula Estudiante";
            this.alumnEnrolledN.Name = "alumnEnrolledN";
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Empresa";
            this.companyName.Name = "companyName";
            // 
            // week
            // 
            this.week.HeaderText = "Semana";
            this.week.Name = "week";
            // 
            // project
            // 
            this.project.HeaderText = "Proyecto";
            this.project.Name = "project";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxProject);
            this.groupBox1.Controls.Add(this.txtBoxWeek);
            this.groupBox1.Controls.Add(this.txtBoxCompanyName);
            this.groupBox1.Controls.Add(this.txtBoxEnrolledNum);
            this.groupBox1.Controls.Add(this.txtBoxReportNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtBoxProject
            // 
            this.txtBoxProject.Location = new System.Drawing.Point(164, 128);
            this.txtBoxProject.Name = "txtBoxProject";
            this.txtBoxProject.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProject.TabIndex = 9;
            // 
            // txtBoxWeek
            // 
            this.txtBoxWeek.Location = new System.Drawing.Point(164, 102);
            this.txtBoxWeek.Name = "txtBoxWeek";
            this.txtBoxWeek.Size = new System.Drawing.Size(100, 20);
            this.txtBoxWeek.TabIndex = 8;
            // 
            // txtBoxCompanyName
            // 
            this.txtBoxCompanyName.Location = new System.Drawing.Point(164, 78);
            this.txtBoxCompanyName.Name = "txtBoxCompanyName";
            this.txtBoxCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCompanyName.TabIndex = 7;
            // 
            // txtBoxEnrolledNum
            // 
            this.txtBoxEnrolledNum.Location = new System.Drawing.Point(164, 54);
            this.txtBoxEnrolledNum.Name = "txtBoxEnrolledNum";
            this.txtBoxEnrolledNum.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEnrolledNum.TabIndex = 6;
            // 
            // txtBoxReportNum
            // 
            this.txtBoxReportNum.Location = new System.Drawing.Point(164, 27);
            this.txtBoxReportNum.Name = "txtBoxReportNum";
            this.txtBoxReportNum.Size = new System.Drawing.Size(100, 20);
            this.txtBoxReportNum.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Proyecto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de la Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Matricula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero del Reporte:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxProjectO);
            this.groupBox2.Controls.Add(this.txtBoxWeekO);
            this.groupBox2.Controls.Add(this.txtBoxCompanyNameO);
            this.groupBox2.Controls.Add(this.txtBoxEnrolledNumO);
            this.groupBox2.Controls.Add(this.txtBoxReportNumO);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 167);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Existentes";
            // 
            // txtBoxProjectO
            // 
            this.txtBoxProjectO.Enabled = false;
            this.txtBoxProjectO.Location = new System.Drawing.Point(164, 128);
            this.txtBoxProjectO.Name = "txtBoxProjectO";
            this.txtBoxProjectO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProjectO.TabIndex = 9;
            // 
            // txtBoxWeekO
            // 
            this.txtBoxWeekO.Enabled = false;
            this.txtBoxWeekO.Location = new System.Drawing.Point(164, 102);
            this.txtBoxWeekO.Name = "txtBoxWeekO";
            this.txtBoxWeekO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxWeekO.TabIndex = 8;
            // 
            // txtBoxCompanyNameO
            // 
            this.txtBoxCompanyNameO.Enabled = false;
            this.txtBoxCompanyNameO.Location = new System.Drawing.Point(164, 78);
            this.txtBoxCompanyNameO.Name = "txtBoxCompanyNameO";
            this.txtBoxCompanyNameO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCompanyNameO.TabIndex = 7;
            // 
            // txtBoxEnrolledNumO
            // 
            this.txtBoxEnrolledNumO.Enabled = false;
            this.txtBoxEnrolledNumO.Location = new System.Drawing.Point(164, 54);
            this.txtBoxEnrolledNumO.Name = "txtBoxEnrolledNumO";
            this.txtBoxEnrolledNumO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEnrolledNumO.TabIndex = 6;
            // 
            // txtBoxReportNumO
            // 
            this.txtBoxReportNumO.Enabled = false;
            this.txtBoxReportNumO.Location = new System.Drawing.Point(164, 27);
            this.txtBoxReportNumO.Name = "txtBoxReportNumO";
            this.txtBoxReportNumO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxReportNumO.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Proyecto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Semana";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre de la Empresa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Numero de Matricula:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Numero del Reporte:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(333, 349);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Nuevo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(538, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(758, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateGrid
            // 
            this.btnUpdateGrid.Location = new System.Drawing.Point(333, 320);
            this.btnUpdateGrid.Name = "btnUpdateGrid";
            this.btnUpdateGrid.Size = new System.Drawing.Size(548, 23);
            this.btnUpdateGrid.TabIndex = 14;
            this.btnUpdateGrid.Text = "Actualizar Tabla";
            this.btnUpdateGrid.UseVisualStyleBackColor = true;
            this.btnUpdateGrid.Click += new System.EventHandler(this.btnUpdateGrid_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 384);
            this.Controls.Add(this.btnUpdateGrid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReports);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxProject;
        private System.Windows.Forms.TextBox txtBoxWeek;
        private System.Windows.Forms.TextBox txtBoxCompanyName;
        private System.Windows.Forms.TextBox txtBoxEnrolledNum;
        private System.Windows.Forms.TextBox txtBoxReportNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxProjectO;
        private System.Windows.Forms.TextBox txtBoxWeekO;
        private System.Windows.Forms.TextBox txtBoxCompanyNameO;
        private System.Windows.Forms.TextBox txtBoxEnrolledNumO;
        private System.Windows.Forms.TextBox txtBoxReportNumO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnEnrolledN;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn week;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.Button btnUpdateGrid;
    }
}