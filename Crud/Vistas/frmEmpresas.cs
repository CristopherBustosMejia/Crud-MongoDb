using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud.Modelos;

namespace Crud.Vistas
{
    public partial class frmEmpresas : Form
    {
        public frmEmpresas()
        {
            InitializeComponent();
        }
        private void Empresas_Load(object sender, EventArgs e)
        {
            var dbCollection = clsConexionMongo.GetCompanyCollection();
            List<clsEmpresaModelo> lstColeccion = dbCollection.Find(D => true).ToList();
            UpdateGrid(lstColeccion);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtBoxDireccion.Text != "" && txtBoxMentor.Text != "" && txtBoxNombre.Text != "" && txtBoxTelefono.Text != "")
                {
                    clsEmpresaModelo oEmpresa = new clsEmpresaModelo
                    {
                        Name = txtBoxNombre.Text,
                        Mentor = txtBoxMentor.Text,
                        Address = txtBoxDireccion.Text,
                        Phone = txtBoxTelefono.Text
                    };
                    clsMetodos.InsertarEmpresa(oEmpresa);
                    MessageBox.Show("Operacion Exitosa");
                }
                else
                {
                    MessageBox.Show("Porfavor asegurese de que todos los campos estan llenos");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error:");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxDireccion.Text != "" && txtBoxMentor.Text != "" && txtBoxNombre.Text != "" && txtBoxTelefono.Text != "" && txtBoxDireccionO.Text != "" && txtBoxMentorO.Text != "" && txtBoxNombreO.Text != "" && txtBoxTelefonoO.Text != "")
                {
                    var dbCollection = clsConexionMongo.GetCompanyCollection();
                    clsEmpresaModelo oEmpresaOriginal = dbCollection.Find(D => D.Name == txtBoxNombreO.Text).First();
                    clsEmpresaModelo oEmpresa = new clsEmpresaModelo
                    {
                        Id = oEmpresaOriginal.Id,
                        Name = txtBoxNombre.Text,
                        Mentor = txtBoxMentor.Text,
                        Address = txtBoxDireccion.Text,
                        Phone = txtBoxTelefono.Text
                    };
                    clsMetodos.ReemplazarEmpresa(oEmpresaOriginal, oEmpresa);
                    MessageBox.Show("Operacion Exitosa");
                }
                else
                {
                    MessageBox.Show("Porfavor asegurese de que todos los campos estan llenos");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtBoxDireccionO.Text != "" && txtBoxMentorO.Text != "" && txtBoxNombreO.Text != "" && txtBoxTelefonoO.Text != "")
                {
                    clsEmpresaModelo oEmpresa = new clsEmpresaModelo
                    {
                        Name = txtBoxNombreO.Text,
                        Mentor = txtBoxMentorO.Text,
                        Address = txtBoxDireccionO.Text,
                        Phone = txtBoxTelefonoO.Text
                    };
                    clsMetodos.EliminarEmpresa(oEmpresa);
                    MessageBox.Show("Operacion exitosa");
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningun registro");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:");
            }
        }

        private void KeyValidate(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void UpdateGrid(List<clsEmpresaModelo> dbCollection)
        {
            dgvEmpresas.Rows.Clear();
            foreach (clsEmpresaModelo db in dbCollection)
            {
                dgvEmpresas.Rows.Add(db.Name,db.Mentor,db.Address,db.Phone);
            }
        }

        private void btnUpdateGrid_Click(object sender, EventArgs e)
        {
            var dbCollection = clsConexionMongo.GetCompanyCollection();
            List<clsEmpresaModelo> lstColeccion = dbCollection.Find(D => true).ToList();
            UpdateGrid(lstColeccion);
        }

        private void dgvEmpresas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dbCollection = clsConexionMongo.GetCompanyCollection();
                clsEmpresaModelo oEmpresa = dbCollection.Find(D => D.Name == dgvEmpresas.CurrentRow.Cells[0].Value.ToString()).First();
                txtBoxNombreO.Text = oEmpresa.Name;
                txtBoxMentorO.Text = oEmpresa.Mentor;
                txtBoxDireccionO.Text = oEmpresa.Address;
                txtBoxTelefonoO.Text = oEmpresa.Phone;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error:");
            }
        }
    }
}
