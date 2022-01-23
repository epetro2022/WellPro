using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace NaveBarExample.model
{
    class Globals
    {
        private string stringcon="";
        public static string ForeignKey = "";
        public static string judul = "";
        public static string getstringco() {
            string strcon = ConfigurationManager.ConnectionStrings["NaveBarExample.Properties.Settings.db_chartConnectionString"].ConnectionString;
            return strcon;
        }
    }
}
