using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using submitCommad;

namespace OpenQueu
{
    class OpenPort
    {
        public bool openPort(string open_commad, string close_commad, bool type)
        {
            if(type == false)
            {
                open_port(open_commad);
                return true;
            }
            else
            {
                close_port(close_commad);
                return false;
            }
        }
        public void open_port(string Commad_open)
        {
            submit_commad_dev.pushCommad(Commad_open, submit_commad_dev.actual_path("OpenQueu"));
        }
        public void close_port(string Commad_Close) 
        {
            submit_commad_dev.pushCommad(Commad_Close, submit_commad_dev.actual_path("OpenQueu"));
        }    
    }
}
