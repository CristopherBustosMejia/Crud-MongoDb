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
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Crud.Vistas
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            var Colleccion = clsConexionMongo.GetReportCollection();
            List<clsReporteModelo> lstColeccion = Colleccion.Find(D => true).ToList();
            UpdateGrid(lstColeccion);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxCompanyName.Text != "" && txtBoxEnrolledNum.Text != "" && txtBoxProject.Text != "" && txtBoxReportNum.Text != "" && txtBoxWeek.Text != "")
                {
                    clsReporteModelo oReporte = new clsReporteModelo()
                    {
                        numReport = txtBoxReportNum.Text,
                        alumnEnrolledN = txtBoxEnrolledNum.Text,
                        companyName = txtBoxCompanyName.Text,
                        week = txtBoxWeek.Text,
                        project = txtBoxProject.Text,
                    };
                    if (clsMetodos.VerificarAlumno(txtBoxEnrolledNum.Text) && clsMetodos.VerificarEmpresa(txtBoxCompanyName.Text))
                    {
                        clsMetodos.InsertarReporte(oReporte);
                        MessageBox.Show("Operacion Exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Verifique si el alumno y la empresa ingresados existen");
                    }
                }
                else
                {
                    MessageBox.Show("Asegurese de que todos los campos estan llenos");
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
                if (txtBoxCompanyName.Text != "" && txtBoxEnrolledNum.Text != "" && txtBoxProject.Text != "" && txtBoxReportNumO.Text != "" && txtBoxWeek.Text != "" && txtBoxCompanyNameO.Text != "" && txtBoxEnrolledNumO.Text != "" && txtBoxProjectO.Text != "" && txtBoxReportNumO.Text != "" && txtBoxWeekO.Text != "")
                {
                    var dbCollection = clsConexionMongo.GetReportCollection();
                    clsReporteModelo oReporteOriginal = dbCollection.Find(D => D.numReport == txtBoxReportNumO.Text && D.alumnEnrolledN == txtBoxEnrolledNumO.Text).First();
                    clsReporteModelo oReporte = new clsReporteModelo()
                    {
                        Id = oReporteOriginal.Id,
                        numReport = txtBoxReportNum.Text,
                        alumnEnrolledN = txtBoxEnrolledNum.Text,
                        companyName = txtBoxCompanyName.Text,
                        week = txtBoxWeek.Text,
                        project = txtBoxProject.Text,
                    };
                    
                    if (clsMetodos.VerificarAlumno(txtBoxEnrolledNum.Text))
                    {
                        if (clsMetodos.VerificarEmpresa(txtBoxCompanyName.Text))
                        {
                            clsMetodos.ReemplazarReporte(oReporteOriginal, oReporte);
                            MessageBox.Show("Operacion Exitosa");
                        }
                        else
                        {
                            MessageBox.Show("Verifique si la empresa ingresada existe");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Verifique si el alumno ingresado existen");
                    }
                }
                else
                {
                    MessageBox.Show("Asegurese de que todos los campos estan llenos");
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
                if (txtBoxCompanyNameO.Text != "" && txtBoxEnrolledNumO.Text != "" && txtBoxProjectO.Text != "" && txtBoxReportNumO.Text != "" && txtBoxWeekO.Text != "")
                {
                    clsReporteModelo oReporte = new clsReporteModelo()
                    {
                        numReport = txtBoxReportNumO.Text,
                        alumnEnrolledN = txtBoxEnrolledNumO.Text,
                        companyName = txtBoxCompanyNameO.Text,
                        week = txtBoxWeekO.Text,
                        project = txtBoxProjectO.Text,
                    };
                    clsMetodos.EliminarReporte(oReporte);
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

        private void btnUpdateGrid_Click(object sender, EventArgs e)
        {
            var dbCollection = clsConexionMongo.GetReportCollection();
            List<clsReporteModelo> lstColeccion = dbCollection.Find(D => true).ToList();
            UpdateGrid(lstColeccion);
        }
        private void UpdateGrid(List<clsReporteModelo> dbCollection)
        {
            dgvReports.Rows.Clear();
            foreach(clsReporteModelo db in dbCollection)
            {
                dgvReports.Rows.Add(db.numReport,db.alumnEnrolledN,db.companyName,db.week,db.project);
            }
        }

        private void dgvReports_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dbCollection = clsConexionMongo.GetReportCollection();
                clsReporteModelo oReporte = dbCollection.Find(D => D.numReport == dgvReports.CurrentRow.Cells[0].Value.ToString() && D.alumnEnrolledN == dgvReports.CurrentRow.Cells[1].Value.ToString()).First();
                txtBoxReportNumO.Text = oReporte.numReport;
                txtBoxEnrolledNumO.Text = oReporte.alumnEnrolledN;
                txtBoxCompanyNameO.Text = oReporte.companyName;
                txtBoxWeekO.Text = oReporte.week;
                txtBoxProjectO.Text = oReporte.project;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:");
            }
        }
    }
}
