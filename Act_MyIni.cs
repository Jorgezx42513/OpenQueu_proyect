using submitCommad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQueu
{
    internal class Act_MyIni : ReadWriteIni
    {
        public Act_MyIni()
        {
            string[,,] DataInifile = new string[,,] { 
                { 
                    {"client", "socket", $"\"{submit_commad_dev.getDir_Ini("OpenQueu")}/mysql/mysql.sock\""},
                    {"mysqld", "socket", $"\"{submit_commad_dev.getDir_Ini("OpenQueu")}/mysql/mysql.sock \""},
                    {"mysqld", "basedir", $"\"{submit_commad_dev.getDir_Ini("OpenQueu")}/mysql\""},
                    {"mysqld", "tmpdir", $"\"{submit_commad_dev.getDir_Ini("OpenQueu")}/mysql/tmp\""},
                    {"mysqld", "datadir", $"\"{submit_commad_dev.getDir_Ini("OpenQueu")}/mysql/data\""},
                    {"mysqld", "plugin_dir", $"\"{submit_commad_dev.getDir_Ini("OpenQueu")}/mysql/lib/plugin/\""},
                    {"mysqld", "innodb_data_home_dir", $"\"{submit_commad_dev.getDir_Ini("OpenQueu")}/mysql/data\""},
                    {"mysqld", "innodb_log_group_home_dir", $"\"{submit_commad_dev.getDir_Ini("OpenQueu")}/mysql/data\""}
                }
            };
            for (int i = 0; i < 8; i++)
            {
                WriteINI(DataInifile[0,i,0], DataInifile[0, i, 1], DataInifile[0, i, 2]);
            }
        }
    }
}
