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
            var empresas = MongoConnection.GetCompanyCollection();
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
                    EmpresaModel company = new EmpresaModel
                    {
                        Name = txtBoxName.Text,
                        Mentor = txtBoxMentor.Text,
                        Address = txtBoxAddress.Text,
                        Phone = txtBoxPhone.Text
                    };
                    EmpresaModel companyOrigin = new EmpresaModel
                    {
                        Name = txtBoxNameO.Text,
                        Mentor = txtBoxMentorO.Text,
                        Address = txtBoxAddressO.Text,
                        Phone = txtBoxPhoneO.Text
                    };
                    Queries_Methods.ReplaceCompany(companyOrigin, company);
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
    }
}
