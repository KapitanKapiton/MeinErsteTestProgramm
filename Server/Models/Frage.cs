using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klient.Models
{
    internal class Frage
    {
        public int Id {  get; set; }
        public string Thema { get; set; }
        public string Frage_ { get; set; }
        public string A1 { get; set; }
        public string A2 { get; set; }
        public string A3 { get; set; }
        public int WieVielFragen { get; set; }
        public int AntwortCode { get; set; }

        
    }
}
