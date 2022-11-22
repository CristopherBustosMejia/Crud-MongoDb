using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Crud.Modelos;

namespace Crud.Modelos
{
    public static class clsMetodos
    {
        /// <summary>
        /// Inserta un alumno
        /// </summary>
        /// <param name="oAlumno"></param>
        public static void InsertarAlumno(clsAlumnoModelo oAlumno)
        {
            var dbCollection = clsConexionMongo.GetAlumnCollection();
            dbCollection.InsertOne(oAlumno);
        }
        /// <summary>
        /// Reemplaza un alumno
        /// </summary>
        /// <param name="oAlumnoOriginal"></param>
        /// <param name="oAlumnoNuevo"></param>
        public static void ReemplazarAlumno(clsAlumnoModelo oAlumnoOriginal, clsAlumnoModelo oAlumnoNuevo)
        {
            var dbCollection = clsConexionMongo.GetAlumnCollection();
            dbCollection.ReplaceOne(D => D.EnrolledNum == oAlumnoOriginal.EnrolledNum, oAlumnoNuevo);
        }
        /// <summary>
        /// Elimina un alumno
        /// </summary>
        /// <param name="oAlumno"></param>
        public static void EliminarAlumno(clsAlumnoModelo oAlumno)
        {
            var dbCollection = clsConexionMongo.GetAlumnCollection();
            dbCollection.DeleteOne(D => D.EnrolledNum == oAlumno.EnrolledNum);
        }
        /// <summary>
        /// Verifica la existencia de un alumno
        /// </summary>
        /// <param name="sMatricula"></param>
        /// <returns>bool</returns>
        public static bool VerificarAlumno(String sMatricula)
        {
            var dbCollection = clsConexionMongo.GetAlumnCollection();
            var Exist = dbCollection.Find(D => D.EnrolledNum == sMatricula).First();
            if (Exist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Inserta una empresa
        /// </summary>
        /// <param name="oEmpresa"></param>
        public static void InsertarEmpresa(clsEmpresaModelo oEmpresa)
        {
            var dbCollection = clsConexionMongo.GetCompanyCollection();
            dbCollection.InsertOne(oEmpresa);
        }
        /// <summary>
        /// Reemplaza una empresa
        /// </summary>
        /// <param name="oEmpresaOriginal"></param>
        /// <param name="oEmpresaNueva"></param>
        public static void ReemplazarEmpresa(clsEmpresaModelo oEmpresaOriginal, clsEmpresaModelo oEmpresaNueva)
        {
            var dbCollection = clsConexionMongo.GetCompanyCollection();
            dbCollection.ReplaceOne(D => D.Name == oEmpresaOriginal.Name, oEmpresaNueva);
        }
        /// <summary>
        /// Elimina una empresa
        /// </summary>
        /// <param name="oEmpresa"></param>
        public static void EliminarEmpresa(clsEmpresaModelo oEmpresa)
        {
            var dbCollection = clsConexionMongo.GetCompanyCollection();
            dbCollection.DeleteOne(D => D.Name == oEmpresa.Name);
        }
        /// <summary>
        /// Verifica la existencia de una empresa
        /// </summary>
        /// <param name="sNombreEmpresa"></param>
        /// <returns>bool</returns>
        public static bool VerificarEmpresa(String sNombreEmpresa)
        {
            var dbCollection = clsConexionMongo.GetCompanyCollection();
            var Exist = dbCollection.Find(D => D.Name == sNombreEmpresa).First();
            if(Exist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Inserta un reporte
        /// </summary>
        /// <param name="oReporte"></param>
        public static void InsertarReporte(clsReporteModelo oReporte)
        {
            var dbCollection = clsConexionMongo.GetReportCollection();
            dbCollection.InsertOne(oReporte);
        }
        /// <summary>
        /// Reemplaza un reporte
        /// </summary>
        /// <param name="oReporteOriginal"></param>
        /// <param name="oReporteNuevo"></param>
        public static void ReemplazarReporte(clsReporteModelo oReporteOriginal, clsReporteModelo oReporteNuevo)
        {
            var dbCollection = clsConexionMongo.GetReportCollection();
            dbCollection.ReplaceOne(D => D.numReport == oReporteOriginal.numReport && D.alumnEnrolledN == oReporteOriginal.alumnEnrolledN, oReporteNuevo);
        }
        /// <summary>
        /// Elimina un reporte
        /// </summary>
        /// <param name="oReporte"></param>
        public static void EliminarReporte(clsReporteModelo oReporte)
        {
            var dbCollection = clsConexionMongo.GetReportCollection();
            dbCollection.DeleteOne(D => D.numReport == oReporte.numReport && D.alumnEnrolledN == oReporte.alumnEnrolledN);
        }
    }
}
