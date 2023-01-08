using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQueu
{
    class State_ports
    {
        public bool _MyMySQL_port;
        public bool MySQL_port { 
            get{ return _MyMySQL_port; }
            set { _MyMySQL_port = value; }
        }
        public bool _filezilla_port;
        public bool Filezilla_port
        {
            get { return _filezilla_port;}
            set { _filezilla_port = value;}
        }
        public bool _Apache_port;
        public bool Apache_port
        {
            get { return _Apache_port;}
            set { _Apache_port = value;}
        }
    }
}
