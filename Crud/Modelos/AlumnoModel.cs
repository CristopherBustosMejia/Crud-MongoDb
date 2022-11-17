using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Bson.Serialization.Attributes;

namespace Crud.Modelos
{
    public class AlumnoModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id;
        [BsonElement]
        public String EnrolledNum;
        [BsonElement]
        public String Name;
        [BsonElement]
        public String LastNameP;
        [BsonElement]
        public String LastNameM;
        [BsonElement]
        public String Group;
        [BsonElement]
        public String Company;

    }
}
