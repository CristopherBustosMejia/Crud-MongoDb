using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.Collections;
using Crud.Vistas;

namespace Crud
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAlumn_Click(object sender, EventArgs e)
        {
            Alumnos formAlumn = new Alumnos();
            formAlumn.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Empresas formCompany = new Empresas();
            formCompany.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes formReportes = new Reportes();
            formReportes.Show();
        }
    }
}
