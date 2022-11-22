using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace Crud.Modelos
{
    public class clsEmpresaModelo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id;
        [BsonElement]
        public String Name;
        [BsonElement]
        public String Mentor;
        [BsonElement]
        public String Address;
        [BsonElement]
        public String Phone;
    }
}
