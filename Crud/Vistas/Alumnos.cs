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

namespace Crud
{
    public partial class Alumnos : Form
    {
        
        public Alumnos()
        {
            InitializeComponent();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNombre.Text != "" && txtBoxMatricula.Text != "" && txtBoxApellidoP.Text != "" && txtBoxApellidoM.Text != "" && txtBoxGrupo.Text != "" && txtBoxCompany.Text != "")
                {
                    AlumnoModel alumn = new AlumnoModel()
                    {
                        Name = txtBoxNombre.Text,
                        EnrolledNum = txtBoxMatricula.Text,
                        LastNameP = txtBoxApellidoP.Text,
                        LastNameM = txtBoxApellidoM.Text,
                        Group = txtBoxGrupo.Text,
                        Company = txtBoxCompany.Text
                    };
                    if (Queries_Methods.VerifyCompany(txtBoxCompany.Text))
                    {
                        Queries_Methods.CreateAlumn(alumn);
                        MessageBox.Show("Operacion Exitosa");
                    }
                    else
                    {
                        MessageBox.Show("No se encontro una empresa con el nombre ingresado");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor asegurese de que todos los campos estan llenos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNombre.Text != "" && txtBoxMatricula.Text != "" && txtBoxApellidoP.Text != "" && txtBoxApellidoM.Text != "" && txtBoxGrupo.Text != "" && txtBoxCompany.Text != "" && txtBoxNombreOb.Text != "" && txtBoxMatriculaOb.Text != "" && txtBoxApellidoPOb.Text != "" && txtBoxApellidoMOb.Text != "" && txtBoxGrupoOb.Text != "" && txtBoxCompanyOb.Text != "")
                {
                    AlumnoModel alumn = new AlumnoModel()
                    {
                        Name = txtBoxNombre.Text,
                        EnrolledNum = txtBoxMatricula.Text,
                        LastNameP = txtBoxApellidoP.Text,
                        LastNameM = txtBoxApellidoM.Text,
                        Group = txtBoxGrupo.Text,
                        Company = txtBoxCompany.Text
                    };
                    AlumnoModel originAlumn = new AlumnoModel()
                    {
                        Name = txtBoxNombreOb.Text,
                        EnrolledNum = txtBoxMatriculaOb.Text,
                        LastNameP = txtBoxApellidoPOb.Text,
                        LastNameM = txtBoxApellidoMOb.Text,
                        Group = txtBoxGrupoOb.Text,
                        Company = txtBoxCompanyOb.Text
                    };
                    if (Queries_Methods.VerifyCompany(txtBoxCompany.Text))
                    {
                        Queries_Methods.ReplaceAlumn(originAlumn,alumn);
                        MessageBox.Show("Operacion Exitosa");
                    }
                    else
                    {
                        MessageBox.Show("No se encontro una empresa con el nombre ingresado");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor asegurese de que todos los campos estan llenos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNombreOb.Text != "" && txtBoxMatriculaOb.Text != "" && txtBoxApellidoPOb.Text != "" && txtBoxApellidoMOb.Text != "" && txtBoxGrupoOb.Text != "" && txtBoxCompanyOb.Text != "")
                {
                    AlumnoModel alumn = new AlumnoModel()
                    {
                        Name = txtBoxNombreOb.Text,
                        EnrolledNum = txtBoxMatriculaOb.Text,
                        LastNameP = txtBoxApellidoPOb.Text,
                        LastNameM = txtBoxApellidoMOb.Text,
                        Group = txtBoxGrupoOb.Text,
                        Company = txtBoxCompanyOb.Text
                    };
                    Queries_Methods.DeleteAlumn(alumn);
                    MessageBox.Show("Operacion Exitosa");
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningun registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:");
            }
        }
    }
}
