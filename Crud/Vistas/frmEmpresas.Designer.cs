namespace Crud.Vistas
{
    partial class frmEmpresas
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
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mentor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBoxDatos = new System.Windows.Forms.GroupBox();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.txtBoxMentor = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grpBoxOriginInfo = new System.Windows.Forms.GroupBox();
            this.txtBoxTelefonoO = new System.Windows.Forms.TextBox();
            this.txtBoxDireccionO = new System.Windows.Forms.TextBox();
            this.txtBoxMentorO = new System.Windows.Forms.TextBox();
            this.txtBoxNombreO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNameO = new System.Windows.Forms.Label();
            this.btnActualizarGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            this.grpBoxDatos.SuspendLayout();
            this.grpBoxOriginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Mentor,
            this.Address,
            this.Phone});
            this.dgvEmpresas.Location = new System.Drawing.Point(374, 12);
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.Size = new System.Drawing.Size(444, 281);
            this.dgvEmpresas.TabIndex = 0;
            this.dgvEmpresas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresas_CellContentDoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Mentor
            // 
            this.Mentor.HeaderText = "Mentor";
            this.Mentor.Name = "Mentor";
            // 
            // Address
            // 
            this.Address.HeaderText = "Direccion";
            this.Address.Name = "Address";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Telefono";
            this.Phone.Name = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mentor Asignado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefono:";
            // 
            // grpBoxDatos
            // 
            this.grpBoxDatos.Controls.Add(this.txtBoxTelefono);
            this.grpBoxDatos.Controls.Add(this.txtBoxDireccion);
            this.grpBoxDatos.Controls.Add(this.txtBoxMentor);
            this.grpBoxDatos.Controls.Add(this.txtBoxNombre);
            this.grpBoxDatos.Controls.Add(this.label1);
            this.grpBoxDatos.Controls.Add(this.label4);
            this.grpBoxDatos.Controls.Add(this.label2);
            this.grpBoxDatos.Controls.Add(this.label3);
            this.grpBoxDatos.Location = new System.Drawing.Point(12, 12);
            this.grpBoxDatos.Name = "grpBoxDatos";
            this.grpBoxDatos.Size = new System.Drawing.Size(343, 162);
            this.grpBoxDatos.TabIndex = 5;
            this.grpBoxDatos.TabStop = false;
            this.grpBoxDatos.Text = "Datos:";
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Location = new System.Drawing.Point(175, 132);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTelefono.TabIndex = 8;
            this.txtBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyValidate);
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(175, 96);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDireccion.TabIndex = 7;
            // 
            // txtBoxMentor
            // 
            this.txtBoxMentor.Location = new System.Drawing.Point(175, 56);
            this.txtBoxMentor.Name = "txtBoxMentor";
            this.txtBoxMentor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMentor.TabIndex = 6;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(175, 20);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 5;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(374, 330);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(107, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Nuevo";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(552, 330);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(107, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(709, 330);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpBoxOriginInfo
            // 
            this.grpBoxOriginInfo.Controls.Add(this.txtBoxTelefonoO);
            this.grpBoxOriginInfo.Controls.Add(this.txtBoxDireccionO);
            this.grpBoxOriginInfo.Controls.Add(this.txtBoxMentorO);
            this.grpBoxOriginInfo.Controls.Add(this.txtBoxNombreO);
            this.grpBoxOriginInfo.Controls.Add(this.label8);
            this.grpBoxOriginInfo.Controls.Add(this.label7);
            this.grpBoxOriginInfo.Controls.Add(this.label6);
            this.grpBoxOriginInfo.Controls.Add(this.lblNameO);
            this.grpBoxOriginInfo.Location = new System.Drawing.Point(12, 204);
            this.grpBoxOriginInfo.Name = "grpBoxOriginInfo";
            this.grpBoxOriginInfo.Size = new System.Drawing.Size(343, 174);
            this.grpBoxOriginInfo.TabIndex = 9;
            this.grpBoxOriginInfo.TabStop = false;
            this.grpBoxOriginInfo.Text = "Datos Existentes";
            // 
            // txtBoxTelefonoO
            // 
            this.txtBoxTelefonoO.Enabled = false;
            this.txtBoxTelefonoO.Location = new System.Drawing.Point(175, 112);
            this.txtBoxTelefonoO.Name = "txtBoxTelefonoO";
            this.txtBoxTelefonoO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTelefonoO.TabIndex = 7;
            // 
            // txtBoxDireccionO
            // 
            this.txtBoxDireccionO.Enabled = false;
            this.txtBoxDireccionO.Location = new System.Drawing.Point(175, 83);
            this.txtBoxDireccionO.Name = "txtBoxDireccionO";
            this.txtBoxDireccionO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDireccionO.TabIndex = 6;
            // 
            // txtBoxMentorO
            // 
            this.txtBoxMentorO.Enabled = false;
            this.txtBoxMentorO.Location = new System.Drawing.Point(175, 57);
            this.txtBoxMentorO.Name = "txtBoxMentorO";
            this.txtBoxMentorO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMentorO.TabIndex = 5;
            // 
            // txtBoxNombreO
            // 
            this.txtBoxNombreO.Enabled = false;
            this.txtBoxNombreO.Location = new System.Drawing.Point(175, 31);
            this.txtBoxNombreO.Name = "txtBoxNombreO";
            this.txtBoxNombreO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombreO.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mentor:";
            // 
            // lblNameO
            // 
            this.lblNameO.AutoSize = true;
            this.lblNameO.Location = new System.Drawing.Point(15, 34);
            this.lblNameO.Name = "lblNameO";
            this.lblNameO.Size = new System.Drawing.Size(47, 13);
            this.lblNameO.TabIndex = 0;
            this.lblNameO.Text = "Nombre:";
            // 
            // btnActualizarGrid
            // 
            this.btnActualizarGrid.Location = new System.Drawing.Point(374, 301);
            this.btnActualizarGrid.Name = "btnActualizarGrid";
            this.btnActualizarGrid.Size = new System.Drawing.Size(442, 23);
            this.btnActualizarGrid.TabIndex = 15;
            this.btnActualizarGrid.Text = "Actualizar Tabla";
            this.btnActualizarGrid.UseVisualStyleBackColor = true;
            this.btnActualizarGrid.Click += new System.EventHandler(this.btnUpdateGrid_Click);
            // 
            // frmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 391);
            this.Controls.Add(this.btnActualizarGrid);
            this.Controls.Add(this.grpBoxOriginInfo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.grpBoxDatos);
            this.Controls.Add(this.dgvEmpresas);
            this.Name = "frmEmpresas";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Empresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            this.grpBoxDatos.ResumeLayout(false);
            this.grpBoxDatos.PerformLayout();
            this.grpBoxOriginInfo.ResumeLayout(false);
            this.grpBoxOriginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBoxDatos;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.TextBox txtBoxMentor;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grpBoxOriginInfo;
        private System.Windows.Forms.TextBox txtBoxTelefonoO;
        private System.Windows.Forms.TextBox txtBoxDireccionO;
        private System.Windows.Forms.TextBox txtBoxMentorO;
        private System.Windows.Forms.TextBox txtBoxNombreO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNameO;
        private System.Windows.Forms.Button btnActualizarGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mentor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}