using System;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using submitCommad;

namespace OpenQueu
{
    internal class ReadWriteIni
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string name, string key, string val,string filepath );
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder relVal, int size, string filepath);

        public string path;

        public ReadWriteIni()
        {
            path = $@"{submit_commad_dev.getDir_Ini("OpenQueu")}\mysql\bin\my.ini";
        }
        public void WriteINI(string name, string key, string value)
        {
            WritePrivateProfileString(name, key, value, this.path);
        }
        public string ReadINI(string name, string key)
        {
            StringBuilder sb = new StringBuilder(255);
            int ini = GetPrivateProfileString(name, key, "", sb, 255, this.path);
            return sb.ToString();
        }
    }
}
