using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LowisChartApp.lw.Map
{
    public partial class MapUserControl : UserControl
    {
        float langitude = 0f;
        float latitude = 0f;
        bool formLoaded = false;

        public MapUserControl()
        {
            InitializeComponent();
        }

        private void MapUserControl_Load(object sender, EventArgs e)
        {
            mapControl1.CacheFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "lw/Map/Cache");
            mapControl1.TileServer = new System.Windows.Forms.OpenStreetMapTileServer(userAgent: "DemoApp for WinFormsMapControl 1.0 contact example@example.com");
            mapControl1.ClearCache();   
            mapControl1.ClearAll();
            
            var orange = new MarkerStyle(10, Brushes.Orange, Pens.Orange, Brushes.Black, SystemFonts.DefaultFont, StringFormat.GenericDefault);
            var biru = new MarkerStyle(10, Brushes.Blue, Pens.Blue, Brushes.Black, SystemFonts.DefaultFont, StringFormat.GenericDefault);
            var hitam = new MarkerStyle(10, Brushes.Black, Pens.Black, Brushes.Black, SystemFonts.DefaultFont, StringFormat.GenericDefault);

            //mapControl1.Markers.Add(new Marker(mapControl1.Center, style, ""));

            ds.Map.MapDataSet.TMapDataTable dt = mapDataTableAdapter1.GetData();
            
            foreach (ds.Map.MapDataSet.MapDataTableRow r in dt.Rows)
            {
                if (!r.IsX_LATITUDENull() && !r.IsY_LONGITUDENull())
                {
                    var str = r.X_LATITUDE.ToString();  
                    langitude = Decimal.ToSingle(r.X_LATITUDE);
                    latitude = Decimal.ToSingle(r.Y_LONGITUDE);
                    if (!r.IsMotorStatusNull() && (r.MotorStatus.Trim() == "Running"))
                    {
                        mapControl1.Markers.Add(new Marker(new GeoPoint(langitude, latitude), biru, ""));
                    }
                    else
                    {
                        mapControl1.Markers.Add(new Marker(new GeoPoint(langitude, latitude), orange, ""));
                    };

                    //mapControl1.Center = new GeoPoint(langitude, latitude);
                    //mapControl1.Markers.Add(new Marker(mapControl1.Center, hitam, ""));
                };
            };

            mapControl1.ZoomLevel = 5;
            //mapControl1.Markers.Add(new Marker(mapControl1.Center, hitam, ""));
            //mapControl1.Refresh();
        }

        private void mapControl1_DoubleClick(object sender, EventArgs e)
        {
            GeoPoint g = mapControl1.Mouse;
            //MessageBox.Show(g.ToString());
            mapControl1.Center = new GeoPoint(langitude, latitude);
            //MessageBox.Show(mapControl1.Center.ToString());
            mapControl1.ZoomLevel = 10;
            mapControl1.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string konfig = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "lw\\Map\\Cache\\konfig.cfg");
            string[] data = System.IO.File.ReadAllLines(konfig);

            if (data.Length < 3)
            {
                mapControl1.Center = new GeoPoint(langitude, latitude);
                mapControl1.ZoomLevel = 13;
            } else
            {
                mapControl1.Center = new GeoPoint(float.Parse(data[0]), float.Parse(data[1]));
                mapControl1.ZoomLevel = int.Parse(data[2]);
            }
            mapControl1.Refresh();

            formLoaded = true;
        }

        private void mapControl1_CenterChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                GeoPoint g = mapControl1.Center;
                //MessageBox.Show(g.ToString());

                string konfig = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "lw\\Map\\Cache\\konfig.cfg");
                string[] data = { g.Longitude.ToString(), g.Latitude.ToString(), mapControl1.ZoomLevel.ToString() };
                System.IO.File.WriteAllLines(konfig, data);
            }
        }
    }
}
