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
    public partial class frmAlumnos : Form
    {
        
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            var dbCollection = clsConexionMongo.GetAlumnCollection();
            List<clsAlumnoModelo> Collection = dbCollection.Find(D => true).ToList();
            UpdateGrid(Collection);
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNombre.Text != "" && txtBoxMatricula.Text != "" && txtBoxApellidoP.Text != "" && txtBoxApellidoM.Text != "" && txtBoxGrupo.Text != "" && txtBoxEmpresa.Text != "")
                {
                    clsAlumnoModelo oAlumno = new clsAlumnoModelo()
                    {
                        Name = txtBoxNombre.Text,
                        EnrolledNum = txtBoxMatricula.Text,
                        LastNameP = txtBoxApellidoP.Text,
                        LastNameM = txtBoxApellidoM.Text,
                        Group = txtBoxGrupo.Text,
                        Company = txtBoxEmpresa.Text
                    };
                    if (clsMetodos.VerificarEmpresa(txtBoxEmpresa.Text))
                    {
                        clsMetodos.InsertarAlumno(oAlumno);
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
                if (txtBoxNombre.Text != "" && txtBoxMatricula.Text != "" && txtBoxApellidoP.Text != "" && txtBoxApellidoM.Text != "" && txtBoxGrupo.Text != "" && txtBoxEmpresa.Text != "" && txtBoxNombreOb.Text != "" && txtBoxMatriculaOb.Text != "" && txtBoxApellidoPOb.Text != "" && txtBoxApellidoMOb.Text != "" && txtBoxGrupoOb.Text != "" && txtBoxEmpresaOb.Text != "")
                {
                    var dbCollection = clsConexionMongo.GetAlumnCollection();
                    clsAlumnoModelo oAlumnoOriginal = dbCollection.Find(D => D.EnrolledNum == dgvAlumnos.CurrentRow.Cells[0].Value.ToString()).First();
                    clsAlumnoModelo oAlumno = new clsAlumnoModelo()
                    {
                        Id = oAlumnoOriginal.Id,
                        Name = txtBoxNombre.Text,
                        EnrolledNum = txtBoxMatricula.Text,
                        LastNameP = txtBoxApellidoP.Text,
                        LastNameM = txtBoxApellidoM.Text,
                        Group = txtBoxGrupo.Text,
                        Company = txtBoxEmpresa.Text
                    };
                    
                    if (clsMetodos.VerificarEmpresa(txtBoxEmpresa.Text))
                    {
                        clsMetodos.ReemplazarAlumno(oAlumnoOriginal,oAlumno);
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
                if (txtBoxNombreOb.Text != "" && txtBoxMatriculaOb.Text != "" && txtBoxApellidoPOb.Text != "" && txtBoxApellidoMOb.Text != "" && txtBoxGrupoOb.Text != "" && txtBoxEmpresaOb.Text != "")
                {
                    clsAlumnoModelo oAlumno = new clsAlumnoModelo()
                    {
                        Name = txtBoxNombreOb.Text,
                        EnrolledNum = txtBoxMatriculaOb.Text,
                        LastNameP = txtBoxApellidoPOb.Text,
                        LastNameM = txtBoxApellidoMOb.Text,
                        Group = txtBoxGrupoOb.Text,
                        Company = txtBoxEmpresaOb.Text
                    };
                    clsMetodos.EliminarAlumno(oAlumno);
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
        private void UpdateGrid(List<clsAlumnoModelo> db)
        {
            dgvAlumnos.Rows.Clear();
            foreach(clsAlumnoModelo oAlumno in db)
            {
                dgvAlumnos.Rows.Add(oAlumno.EnrolledNum, oAlumno.Name, oAlumno.LastNameP, oAlumno.LastNameM,oAlumno.Group, oAlumno.Company);
            }
        }

        private void btnUpdateGrid_Click(object sender, EventArgs e)
        {
            var dbCollection = clsConexionMongo.GetAlumnCollection();
            List<clsAlumnoModelo> lstColeccion = dbCollection.Find(D => true).ToList();
            UpdateGrid(lstColeccion);
        }

        private void dgvAlumns_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dbCollection = clsConexionMongo.GetAlumnCollection();
                clsAlumnoModelo alumn = dbCollection.Find(D => D.EnrolledNum == dgvAlumnos.CurrentRow.Cells[0].Value.ToString()).First();
                txtBoxNombreOb.Text = alumn.Name;
                txtBoxMatriculaOb.Text = alumn.EnrolledNum;
                txtBoxApellidoPOb.Text = alumn.LastNameP;
                txtBoxApellidoMOb.Text = alumn.LastNameM;
                txtBoxGrupoOb.Text = alumn.Group;
                txtBoxEmpresaOb.Text = alumn.Company;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:");
            }
        }
    }
}
