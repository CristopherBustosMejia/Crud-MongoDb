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
    public static class Queries_Methods
    {
        public static void CreateAlumn(AlumnoModel alumn)
        {
            var dbCollection = MongoConnection.GetAlumnCollection();
            dbCollection.InsertOne(alumn);
        }
        public static void ReplaceAlumn(AlumnoModel originAlumn, AlumnoModel newAlumn)
        {
            var dbCollection = MongoConnection.GetAlumnCollection();
            dbCollection.ReplaceOne(D => D.EnrolledNum == originAlumn.EnrolledNum, newAlumn);
        }
        public static void DeleteAlumn(AlumnoModel alumn)
        {
            var dbCollection = MongoConnection.GetAlumnCollection();
            dbCollection.DeleteOne(D => D.EnrolledNum == alumn.EnrolledNum);
        }
        public static bool VerifyAlumn(String alumnEnrolledNum)
        {
            var dbCollection = MongoConnection.GetAlumnCollection();
            var Exist = dbCollection.Find(D => D.Name == alumnEnrolledNum).First();
            if (Exist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void CreateCompany(EmpresaModel company)
        {
            var dbCollection = MongoConnection.GetCompanyCollection();
            dbCollection.InsertOne(company);
        }
        public static void ReplaceCompany(EmpresaModel originCompany, EmpresaModel newCompany)
        {
            var dbCollection = MongoConnection.GetCompanyCollection();
            dbCollection.ReplaceOne(D => D.Name == originCompany.Name, newCompany);
        }
        public static void DeleteCompany(EmpresaModel company)
        {
            var dbCollection = MongoConnection.GetCompanyCollection();
            dbCollection.DeleteOne(D => D.Name == company.Name);
        }
        public static bool VerifyCompany(String companyName)
        {
            var dbCollection = MongoConnection.GetCompanyCollection();
            var Exist = dbCollection.Find(D => D.Name == companyName).First();
            if(Exist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void CreateReport(ReporteModel report)
        {
            var dbCollection = MongoConnection.GetReportCollection();
            dbCollection.InsertOne(report);
        }
        public static void ReplaceReport(ReporteModel originReport, ReporteModel newReport)
        {
            var dbCollection = MongoConnection.GetReportCollection();
            dbCollection.ReplaceOne(D => D.numReport == originReport.numReport && D.alumnEnrolledN == originReport.alumnEnrolledN, newReport);
        }
        public static void DeleteReport(ReporteModel report)
        {
            var dbCollection = MongoConnection.GetReportCollection();
            dbCollection.DeleteOne(D => D.numReport == report.numReport && D.alumnEnrolledN == report.alumnEnrolledN);
        }
    }
}
