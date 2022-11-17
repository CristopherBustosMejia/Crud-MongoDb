namespace Crud.Vistas
{
    partial class Empresas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBoxDatos = new System.Windows.Forms.GroupBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxMentor = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpBoxOriginInfo = new System.Windows.Forms.GroupBox();
            this.lblNameO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxNameO = new System.Windows.Forms.TextBox();
            this.txtBoxMentorO = new System.Windows.Forms.TextBox();
            this.txtBoxAddressO = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBoxDatos.SuspendLayout();
            this.grpBoxOriginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 281);
            this.dataGridView1.TabIndex = 0;
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
            this.grpBoxDatos.Controls.Add(this.txtBoxPhone);
            this.grpBoxDatos.Controls.Add(this.txtBoxAddress);
            this.grpBoxDatos.Controls.Add(this.txtBoxMentor);
            this.grpBoxDatos.Controls.Add(this.txtBoxName);
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
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(175, 132);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPhone.TabIndex = 8;
            this.txtBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyValidate);
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(175, 96);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAddress.TabIndex = 7;
            // 
            // txtBoxMentor
            // 
            this.txtBoxMentor.Location = new System.Drawing.Point(175, 56);
            this.txtBoxMentor.Name = "txtBoxMentor";
            this.txtBoxMentor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMentor.TabIndex = 6;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(175, 20);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(374, 314);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(107, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Nuevo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(528, 314);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(681, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpBoxOriginInfo
            // 
            this.grpBoxOriginInfo.Controls.Add(this.txtBoxPhoneO);
            this.grpBoxOriginInfo.Controls.Add(this.txtBoxAddressO);
            this.grpBoxOriginInfo.Controls.Add(this.txtBoxMentorO);
            this.grpBoxOriginInfo.Controls.Add(this.txtBoxNameO);
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
            // lblNameO
            // 
            this.lblNameO.AutoSize = true;
            this.lblNameO.Location = new System.Drawing.Point(15, 34);
            this.lblNameO.Name = "lblNameO";
            this.lblNameO.Size = new System.Drawing.Size(47, 13);
            this.lblNameO.TabIndex = 0;
            this.lblNameO.Text = "Nombre:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Direccion";
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
            // txtBoxNameO
            // 
            this.txtBoxNameO.Enabled = false;
            this.txtBoxNameO.Location = new System.Drawing.Point(175, 31);
            this.txtBoxNameO.Name = "txtBoxNameO";
            this.txtBoxNameO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNameO.TabIndex = 4;
            // 
            // txtBoxMentorO
            // 
            this.txtBoxMentorO.Enabled = false;
            this.txtBoxMentorO.Location = new System.Drawing.Point(175, 57);
            this.txtBoxMentorO.Name = "txtBoxMentorO";
            this.txtBoxMentorO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMentorO.TabIndex = 5;
            // 
            // txtBoxAddressO
            // 
            this.txtBoxAddressO.Enabled = false;
            this.txtBoxAddressO.Location = new System.Drawing.Point(175, 83);
            this.txtBoxAddressO.Name = "txtBoxAddressO";
            this.txtBoxAddressO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAddressO.TabIndex = 6;
            // 
            // txtBoxPhoneO
            // 
            this.txtBoxPhoneO.Enabled = false;
            this.txtBoxPhoneO.Location = new System.Drawing.Point(175, 112);
            this.txtBoxPhoneO.Name = "txtBoxPhoneO";
            this.txtBoxPhoneO.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPhoneO.TabIndex = 7;
            // 
            // Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.grpBoxOriginInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.grpBoxDatos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Empresas";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Empresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBoxDatos.ResumeLayout(false);
            this.grpBoxDatos.PerformLayout();
            this.grpBoxOriginInfo.ResumeLayout(false);
            this.grpBoxOriginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBoxDatos;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxMentor;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpBoxOriginInfo;
        private System.Windows.Forms.TextBox txtBoxPhoneO;
        private System.Windows.Forms.TextBox txtBoxAddressO;
        private System.Windows.Forms.TextBox txtBoxMentorO;
        private System.Windows.Forms.TextBox txtBoxNameO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNameO;
    }
}