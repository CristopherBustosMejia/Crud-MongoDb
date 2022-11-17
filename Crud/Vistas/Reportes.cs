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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            
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
                    ReporteModel report = new ReporteModel()
                    {
                        numReport = txtBoxReportNum.Text,
                        alumnEnrolledN = txtBoxEnrolledNum.Text,
                        companyName = txtBoxCompanyName.Text,
                        week = txtBoxWeek.Text,
                        project = txtBoxProject.Text,
                    };
                    ReporteModel originReport = new ReporteModel()
                    {
                        numReport = txtBoxReportNumO.Text,
                        alumnEnrolledN = txtBoxEnrolledNumO.Text,
                        companyName = txtBoxCompanyNameO.Text,
                        week = txtBoxWeekO.Text,
                        project = txtBoxProjectO.Text,
                    };
                    if (Queries_Methods.VerifyAlumn(txtBoxEnrolledNum.Text) && Queries_Methods.VerifyCompany(txtBoxCompanyName.Text))
                    {
                        Queries_Methods.ReplaceReport(originReport,report);
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
    }
}
