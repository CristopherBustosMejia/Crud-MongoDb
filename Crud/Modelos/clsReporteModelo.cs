using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Crud.Modelos
{
    public class clsReporteModelo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id;
        [BsonElement]
        public String numReport;
        [BsonElement]
        public String alumnEnrolledN;
        [BsonElement]
        public String companyName;
        [BsonElement]
        public String week;
        [BsonElement]
        public String project;
    }
}
