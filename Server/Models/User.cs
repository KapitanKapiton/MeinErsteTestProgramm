using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Http;

namespace Server
{
    public class User
    {
   
        public string Header {  get; set; }
        public string Login { get; set; }
        public string Passwort { get; set; }
    }
}
