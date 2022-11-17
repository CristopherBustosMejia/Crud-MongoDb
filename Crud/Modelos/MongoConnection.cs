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
    public static class MongoConnection 
    {
        public static IMongoCollection<AlumnoModel> GetAlumnCollection()
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost");
            var db = dbClient.GetDatabase("Dual");
            return db.GetCollection<AlumnoModel>("Alumnos");
        }
        public static IMongoCollection<EmpresaModel> GetCompanyCollection()
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost");
            var db = dbClient.GetDatabase("Dual");
            return db.GetCollection<EmpresaModel>("Empresas");
        }
        public static IMongoCollection<ReporteModel> GetReportCollection()
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost");
            var db = dbClient.GetDatabase("Dual");
            return db.GetCollection<ReporteModel>("Reportes");
        }

    }
    
}
