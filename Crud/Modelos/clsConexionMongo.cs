using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Crud.Modelos
{
    public static class clsConexionMongo 
    {
        /// <summary>
        /// Busca la coleccion de alumnos
        /// </summary>
        /// <returns>IMongoCollection<clsAlumnoModelo></returns>
        public static IMongoCollection<clsAlumnoModelo> GetAlumnCollection()
        {
            MongoClient ClienteMongo = new MongoClient("mongodb://localhost");
            var db = ClienteMongo.GetDatabase("Dual");
            return db.GetCollection<clsAlumnoModelo>("Alumnos");
        }
        /// <summary>
        /// Busca la coleccion de empresas
        /// </summary>
        /// <returns>IMongoCollection<clsEmpresaModelo></returns>
        public static IMongoCollection<clsEmpresaModelo> GetCompanyCollection()
        {
            MongoClient clienteMongo = new MongoClient("mongodb://localhost");
            var db = clienteMongo.GetDatabase("Dual");
            return db.GetCollection<clsEmpresaModelo>("Empresas");
        }
        /// <summary>
        /// Busca la coleccion de reportes
        /// </summary>
        /// <returns>IMongoCollection<clsReporteModelo></returns>
        public static IMongoCollection<clsReporteModelo> GetReportCollection()
        {
            MongoClient clienteMongo = new MongoClient("mongodb://localhost");
            var db = clienteMongo.GetDatabase("Dual");
            return db.GetCollection<clsReporteModelo>("Reportes");
        }

    }
    
}
