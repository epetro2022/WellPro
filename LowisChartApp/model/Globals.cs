using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows;

namespace LowisChartApp.model
{
    class Globals
    {
        private string stringcon = "";
        public static string parameterid ="";
        public static int idsp = 0;
        public static string ForeignKey = "";
        public static string SelectListView = "";
        public static string formPilih = "";
        public static string judul = "";
        public static string treePilih = "";
        public static string userlogin = "Admin";
        public static string winformjudul = "";
        public static string getstringco() {
            string strcon = ConfigurationManager.ConnectionStrings["LowisChartApp.Properties.Settings.db_chartConnectionString"].ConnectionString;
            return strcon;
        }
        public static string getstringco2()
        {
            string strcon = ConfigurationManager.ConnectionStrings["LowisChartApp.Properties.Settings.lw2ConnectionString"].ConnectionString;
            return strcon;
        }
        public static void showfrm() {
            //private frmMain frm = new frmMain;

        }
    }
}
