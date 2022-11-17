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
            var dbCollection = MongoConnection.GetAlumnCollection();
            List<AlumnoModel> Collection = dbCollection.Find(D => true).ToList();
            UpdateGrid(Collection);
            
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
                    var dbCollection = MongoConnection.GetAlumnCollection();
                    AlumnoModel originAlumn = dbCollection.Find(D => D.EnrolledNum == dgvAlumns.CurrentRow.Cells[0].Value.ToString()).First();
                    AlumnoModel alumn = new AlumnoModel()
                    {
                        Id = originAlumn.Id,
                        Name = txtBoxNombre.Text,
                        EnrolledNum = txtBoxMatricula.Text,
                        LastNameP = txtBoxApellidoP.Text,
                        LastNameM = txtBoxApellidoM.Text,
                        Group = txtBoxGrupo.Text,
                        Company = txtBoxCompany.Text
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
        private void UpdateGrid(List<AlumnoModel> db)
        {
            dgvAlumns.Rows.Clear();
            foreach(AlumnoModel alumn in db)
            {
                dgvAlumns.Rows.Add(alumn.EnrolledNum, alumn.Name, alumn.LastNameP, alumn.LastNameM,alumn.Group, alumn.Company);
            }
        }

        private void btnUpdateGrid_Click(object sender, EventArgs e)
        {
            var dbCollection = MongoConnection.GetAlumnCollection();
            List<AlumnoModel> Collection = dbCollection.Find(D => true).ToList();
            UpdateGrid(Collection);
        }

        private void dgvAlumns_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dbCollection = MongoConnection.GetAlumnCollection();
                AlumnoModel alumn = dbCollection.Find(D => D.EnrolledNum == dgvAlumns.CurrentRow.Cells[0].Value.ToString()).First();
                txtBoxNombreOb.Text = alumn.Name;
                txtBoxMatriculaOb.Text = alumn.EnrolledNum;
                txtBoxApellidoPOb.Text = alumn.LastNameP;
                txtBoxApellidoMOb.Text = alumn.LastNameM;
                txtBoxGrupoOb.Text = alumn.Group;
                txtBoxCompanyOb.Text = alumn.Company;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:");
            }
        }
    }
}
