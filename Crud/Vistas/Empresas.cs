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
    public partial class Empresas : Form
    {
        public Empresas()
        {
            InitializeComponent();
        }
        private void Empresas_Load(object sender, EventArgs e)
        {
            var dbCollection = MongoConnection.GetCompanyCollection();
            List<EmpresaModel> Collection = dbCollection.Find(D => true).ToList();
            UpdateGrid(Collection);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtBoxAddress.Text != "" && txtBoxMentor.Text != "" && txtBoxName.Text != "" && txtBoxPhone.Text != "")
                {
                    EmpresaModel company = new EmpresaModel
                    {
                        Name = txtBoxName.Text,
                        Mentor = txtBoxMentor.Text,
                        Address = txtBoxAddress.Text,
                        Phone = txtBoxPhone.Text
                    };
                    Queries_Methods.CreateCompany(company);
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
                if (txtBoxAddress.Text != "" && txtBoxMentor.Text != "" && txtBoxName.Text != "" && txtBoxPhone.Text != "" && txtBoxAddressO.Text != "" && txtBoxMentorO.Text != "" && txtBoxNameO.Text != "" && txtBoxPhoneO.Text != "")
                {
                    var dbCollection = MongoConnection.GetCompanyCollection();
                    EmpresaModel originCompany = dbCollection.Find(D => D.Name == txtBoxNameO.Text).First();
                    EmpresaModel company = new EmpresaModel
                    {
                        Id = originCompany.Id,
                        Name = txtBoxName.Text,
                        Mentor = txtBoxMentor.Text,
                        Address = txtBoxAddress.Text,
                        Phone = txtBoxPhone.Text
                    };
                    Queries_Methods.ReplaceCompany(originCompany, company);
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
                if(txtBoxAddressO.Text != "" && txtBoxMentorO.Text != "" && txtBoxNameO.Text != "" && txtBoxPhoneO.Text != "")
                {
                    EmpresaModel company = new EmpresaModel
                    {
                        Name = txtBoxNameO.Text,
                        Mentor = txtBoxMentorO.Text,
                        Address = txtBoxAddressO.Text,
                        Phone = txtBoxPhoneO.Text
                    };
                    Queries_Methods.DeleteCompany(company);
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
        private void UpdateGrid(List<EmpresaModel> dbCollection)
        {
            dgvEmpresas.Rows.Clear();
            foreach (EmpresaModel db in dbCollection)
            {
                dgvEmpresas.Rows.Add(db.Name,db.Mentor,db.Address,db.Phone);
            }
        }

        private void btnUpdateGrid_Click(object sender, EventArgs e)
        {
            var dbCollection = MongoConnection.GetCompanyCollection();
            List<EmpresaModel> Collection = dbCollection.Find(D => true).ToList();
            UpdateGrid(Collection);
        }

        private void dgvEmpresas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dbCollection = MongoConnection.GetCompanyCollection();
                EmpresaModel company = dbCollection.Find(D => D.Name == dgvEmpresas.CurrentRow.Cells[0].Value.ToString()).First();
                txtBoxNameO.Text = company.Name;
                txtBoxMentorO.Text = company.Mentor;
                txtBoxAddressO.Text = company.Address;
                txtBoxPhoneO.Text = company.Phone;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error:");
            }
        }
    }
}
