using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    internal class SendRes
    {
        public string Header { get; set; }
        public int UserId { get; set; }
        public string Login { get; set; }
        public DateTime DateTime { get; set; }
        public bool ResYaNein { get; set; }
    }
}
