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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            var dbCollection = MongoConnection.GetReportCollection();
            List<ReporteModel> Collection = dbCollection.Find(D => true).ToList();
            UpdateGrid(Collection);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxCompanyName.Text != "" && txtBoxEnrolledNum.Text != "" && txtBoxProject.Text != "" && txtBoxReportNum.Text != "" && txtBoxWeek.Text != "")
                {
                    ReporteModel report = new ReporteModel()
                    {
                        numReport = txtBoxReportNum.Text,
                        alumnEnrolledN = txtBoxEnrolledNum.Text,
                        companyName = txtBoxCompanyName.Text,
                        week = txtBoxWeek.Text,
                        project = txtBoxProject.Text,
                    };
                    if (Queries_Methods.VerifyAlumn(txtBoxEnrolledNum.Text) && Queries_Methods.VerifyCompany(txtBoxCompanyName.Text))
                    {
                        Queries_Methods.CreateReport(report);
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
                    var dbCollection = MongoConnection.GetReportCollection();
                    ReporteModel originReport = dbCollection.Find(D => D.numReport == txtBoxReportNumO.Text && D.alumnEnrolledN == txtBoxEnrolledNumO.Text).First();
                    ReporteModel report = new ReporteModel()
                    {
                        Id = originReport.Id,
                        numReport = txtBoxReportNum.Text,
                        alumnEnrolledN = txtBoxEnrolledNum.Text,
                        companyName = txtBoxCompanyName.Text,
                        week = txtBoxWeek.Text,
                        project = txtBoxProject.Text,
                    };
                    
                    if (Queries_Methods.VerifyAlumn(txtBoxEnrolledNum.Text))
                    {
                        if (Queries_Methods.VerifyCompany(txtBoxCompanyName.Text))
                        {
                            Queries_Methods.ReplaceReport(originReport, report);
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
                    ReporteModel report = new ReporteModel()
                    {
                        numReport = txtBoxReportNumO.Text,
                        alumnEnrolledN = txtBoxEnrolledNumO.Text,
                        companyName = txtBoxCompanyNameO.Text,
                        week = txtBoxWeekO.Text,
                        project = txtBoxProjectO.Text,
                    };
                    Queries_Methods.DeleteReport(report);
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
            var dbCollection = MongoConnection.GetReportCollection();
            List<ReporteModel> Collection = dbCollection.Find(D => true).ToList();
            UpdateGrid(Collection);
        }
        private void UpdateGrid(List<ReporteModel> dbCollection)
        {
            dgvReports.Rows.Clear();
            foreach(ReporteModel db in dbCollection)
            {
                dgvReports.Rows.Add(db.numReport,db.alumnEnrolledN,db.companyName,db.week,db.project);
            }
        }

        private void dgvReports_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dbCollection = MongoConnection.GetReportCollection();
                ReporteModel report = dbCollection.Find(D => D.numReport == dgvReports.CurrentRow.Cells[0].Value.ToString() && D.alumnEnrolledN == dgvReports.CurrentRow.Cells[1].Value.ToString()).First();
                txtBoxReportNumO.Text = report.numReport;
                txtBoxEnrolledNumO.Text = report.alumnEnrolledN;
                txtBoxCompanyNameO.Text = report.companyName;
                txtBoxWeekO.Text = report.week;
                txtBoxProjectO.Text = report.project;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:");
            }
        }
    }
}
