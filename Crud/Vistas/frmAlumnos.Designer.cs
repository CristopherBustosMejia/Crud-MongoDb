namespace Crud
{
    partial class frmAlumnos
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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.EnrolledNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxDatos = new System.Windows.Forms.GroupBox();
            this.txtBoxEmpresa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxGrupo = new System.Windows.Forms.TextBox();
            this.txtBoxApellidoM = new System.Windows.Forms.TextBox();
            this.txtBoxApellidoP = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtBoxMatricula = new System.Windows.Forms.TextBox();
            this.grpBoxObtenido = new System.Windows.Forms.GroupBox();
            this.txtBoxEmpresaOb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxGrupoOb = new System.Windows.Forms.TextBox();
            this.txtBoxApellidoMOb = new System.Windows.Forms.TextBox();
            this.txtBoxApellidoPOb = new System.Windows.Forms.TextBox();
            this.txtBoxNombreOb = new System.Windows.Forms.TextBox();
            this.txtBoxMatriculaOb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnActualzar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizarGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.grpBoxDatos.SuspendLayout();
            this.grpBoxObtenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnrolledNum,
            this.Nombre,
            this.LastNameP,
            this.LastNameM,
            this.Group,
            this.Company});
            this.dgvAlumnos.Location = new System.Drawing.Point(382, 12);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(643, 376);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumns_CellDoubleClick);
            // 
            // EnrolledNum
            // 
            this.EnrolledNum.HeaderText = "Matricula";
            this.EnrolledNum.Name = "EnrolledNum";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // LastNameP
            // 
            this.LastNameP.HeaderText = "Apellido Paterno";
            this.LastNameP.Name = "LastNameP";
            // 
            // LastNameM
            // 
            this.LastNameM.HeaderText = "Apellido Materno";
            this.LastNameM.Name = "LastNameM";
            // 
            // Group
            // 
            this.Group.HeaderText = "Grupo";
            this.Group.Name = "Group";
            // 
            // Company
            // 
            this.Company.HeaderText = "Empresa";
            this.Company.Name = "Company";
            // 
            // grpBoxDatos
            // 
            this.grpBoxDatos.Controls.Add(this.txtBoxEmpresa);
            this.grpBoxDatos.Controls.Add(this.label11);
            this.grpBoxDatos.Controls.Add(this.txtBoxGrupo);
            this.grpBoxDatos.Controls.Add(this.txtBoxApellidoM);
            this.grpBoxDatos.Controls.Add(this.txtBoxApellidoP);
            this.grpBoxDatos.Controls.Add(this.txtBoxNombre);
            this.grpBoxDatos.Controls.Add(this.label4);
            this.grpBoxDatos.Controls.Add(this.label3);
            this.grpBoxDatos.Controls.Add(this.label2);
            this.grpBoxDatos.Controls.Add(this.label1);
            this.grpBoxDatos.Controls.Add(this.lblMatricula);
            this.grpBoxDatos.Controls.Add(this.txtBoxMatricula);
            this.grpBoxDatos.Location = new System.Drawing.Point(12, 12);
            this.grpBoxDatos.Name = "grpBoxDatos";
            this.grpBoxDatos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpBoxDatos.Size = new System.Drawing.Size(364, 198);
            this.grpBoxDatos.TabIndex = 1;
            this.grpBoxDatos.TabStop = false;
            this.grpBoxDatos.Text = "Datos ";
            // 
            // txtBoxEmpresa
            // 
            this.txtBoxEmpresa.Location = new System.Drawing.Point(164, 167);
            this.txtBoxEmpresa.Name = "txtBoxEmpresa";
            this.txtBoxEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmpresa.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Empresa:";
            // 
            // txtBoxGrupo
            // 
            this.txtBoxGrupo.Location = new System.Drawing.Point(164, 139);
            this.txtBoxGrupo.Name = "txtBoxGrupo";
            this.txtBoxGrupo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxGrupo.TabIndex = 9;
            // 
            // txtBoxApellidoM
            // 
            this.txtBoxApellidoM.Location = new System.Drawing.Point(164, 115);
            this.txtBoxApellidoM.Name = "txtBoxApellidoM";
            this.txtBoxApellidoM.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellidoM.TabIndex = 8;
            // 
            // txtBoxApellidoP
            // 
            this.txtBoxApellidoP.Location = new System.Drawing.Point(164, 88);
            this.txtBoxApellidoP.Name = "txtBoxApellidoP";
            this.txtBoxApellidoP.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellidoP.TabIndex = 7;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(164, 59);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grupo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(10, 37);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matricula:";
            // 
            // txtBoxMatricula
            // 
            this.txtBoxMatricula.Location = new System.Drawing.Point(164, 34);
            this.txtBoxMatricula.Name = "txtBoxMatricula";
            this.txtBoxMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMatricula.TabIndex = 0;
            // 
            // grpBoxObtenido
            // 
            this.grpBoxObtenido.Controls.Add(this.txtBoxEmpresaOb);
            this.grpBoxObtenido.Controls.Add(this.label10);
            this.grpBoxObtenido.Controls.Add(this.txtBoxGrupoOb);
            this.grpBoxObtenido.Controls.Add(this.txtBoxApellidoMOb);
            this.grpBoxObtenido.Controls.Add(this.txtBoxApellidoPOb);
            this.grpBoxObtenido.Controls.Add(this.txtBoxNombreOb);
            this.grpBoxObtenido.Controls.Add(this.txtBoxMatriculaOb);
            this.grpBoxObtenido.Controls.Add(this.label9);
            this.grpBoxObtenido.Controls.Add(this.label8);
            this.grpBoxObtenido.Controls.Add(this.label7);
            this.grpBoxObtenido.Controls.Add(this.label6);
            this.grpBoxObtenido.Controls.Add(this.label5);
            this.grpBoxObtenido.Location = new System.Drawing.Point(12, 216);
            this.grpBoxObtenido.Name = "grpBoxObtenido";
            this.grpBoxObtenido.Size = new System.Drawing.Size(364, 207);
            this.grpBoxObtenido.TabIndex = 2;
            this.grpBoxObtenido.TabStop = false;
            this.grpBoxObtenido.Text = "Datos Registrados";
            // 
            // txtBoxEmpresaOb
            // 
            this.txtBoxEmpresaOb.Enabled = false;
            this.txtBoxEmpresaOb.Location = new System.Drawing.Point(164, 181);
            this.txtBoxEmpresaOb.Name = "txtBoxEmpresaOb";
            this.txtBoxEmpresaOb.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmpresaOb.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Empresa";
            // 
            // txtBoxGrupoOb
            // 
            this.txtBoxGrupoOb.Enabled = false;
            this.txtBoxGrupoOb.Location = new System.Drawing.Point(164, 152);
            this.txtBoxGrupoOb.Name = "txtBoxGrupoOb";
            this.txtBoxGrupoOb.Size = new System.Drawing.Size(100, 20);
            this.txtBoxGrupoOb.TabIndex = 9;
            // 
            // txtBoxApellidoMOb
            // 
            this.txtBoxApellidoMOb.Enabled = false;
            this.txtBoxApellidoMOb.Location = new System.Drawing.Point(164, 121);
            this.txtBoxApellidoMOb.Name = "txtBoxApellidoMOb";
            this.txtBoxApellidoMOb.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellidoMOb.TabIndex = 8;
            // 
            // txtBoxApellidoPOb
            // 
            this.txtBoxApellidoPOb.Enabled = false;
            this.txtBoxApellidoPOb.Location = new System.Drawing.Point(164, 89);
            this.txtBoxApellidoPOb.Name = "txtBoxApellidoPOb";
            this.txtBoxApellidoPOb.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellidoPOb.TabIndex = 7;
            // 
            // txtBoxNombreOb
            // 
            this.txtBoxNombreOb.Enabled = false;
            this.txtBoxNombreOb.Location = new System.Drawing.Point(164, 53);
            this.txtBoxNombreOb.Name = "txtBoxNombreOb";
            this.txtBoxNombreOb.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombreOb.TabIndex = 6;
            // 
            // txtBoxMatriculaOb
            // 
            this.txtBoxMatriculaOb.Enabled = false;
            this.txtBoxMatriculaOb.Location = new System.Drawing.Point(164, 30);
            this.txtBoxMatriculaOb.Name = "txtBoxMatriculaOb";
            this.txtBoxMatriculaOb.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMatriculaOb.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Grupo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Apellido Materno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido Paterno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Matricula:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(382, 424);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(102, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Agregar Nuevo";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnActualzar
            // 
            this.btnActualzar.Location = new System.Drawing.Point(656, 424);
            this.btnActualzar.Name = "btnActualzar";
            this.btnActualzar.Size = new System.Drawing.Size(102, 23);
            this.btnActualzar.TabIndex = 4;
            this.btnActualzar.Text = "Actualizar";
            this.btnActualzar.UseVisualStyleBackColor = true;
            this.btnActualzar.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(919, 424);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnActualizarGrid
            // 
            this.btnActualizarGrid.Location = new System.Drawing.Point(382, 395);
            this.btnActualizarGrid.Name = "btnActualizarGrid";
            this.btnActualizarGrid.Size = new System.Drawing.Size(639, 23);
            this.btnActualizarGrid.TabIndex = 15;
            this.btnActualizarGrid.Text = "Actualizar Tabla";
            this.btnActualizarGrid.UseVisualStyleBackColor = true;
            this.btnActualizarGrid.Click += new System.EventHandler(this.btnUpdateGrid_Click);
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 468);
            this.Controls.Add(this.btnActualizarGrid);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualzar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.grpBoxObtenido);
            this.Controls.Add(this.grpBoxDatos);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "frmAlumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.grpBoxDatos.ResumeLayout(false);
            this.grpBoxDatos.PerformLayout();
            this.grpBoxObtenido.ResumeLayout(false);
            this.grpBoxObtenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.GroupBox grpBoxDatos;
        private System.Windows.Forms.TextBox txtBoxGrupo;
        private System.Windows.Forms.TextBox txtBoxApellidoM;
        private System.Windows.Forms.TextBox txtBoxApellidoP;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtBoxMatricula;
        private System.Windows.Forms.GroupBox grpBoxObtenido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxGrupoOb;
        private System.Windows.Forms.TextBox txtBoxApellidoMOb;
        private System.Windows.Forms.TextBox txtBoxApellidoPOb;
        private System.Windows.Forms.TextBox txtBoxNombreOb;
        private System.Windows.Forms.TextBox txtBoxMatriculaOb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnActualzar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBoxEmpresaOb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxEmpresa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrolledNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.Button btnActualizarGrid;
    }
}