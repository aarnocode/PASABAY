using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.Projections;
using GMap.NET.CacheProviders;
using GMap.NET.Internals;
using GMap.NET.ObjectModel;
using GMap.NET.WindowsPresentation;

namespace PASABAY_CSharp
{
    public partial class frmDriver : Form
    {
        public frmDriver()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void frmDriver_Load(object sender, EventArgs e)
        {
            panel2.Visible=false;
            pctSettings2.Visible = false;
            panel3.Visible = false;
            pctProfile2.Visible = false;

            timer1.Start();
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyA2yOciCrtfmt8Gt7290nUFBqfptsSuo9I";
            gMap.DragButton = MouseButtons.Left;
            gMap.MapProvider = GMapProviders.GoogleMap;
            double lat = 14.526587;
            double longt = 121.056003;
            gMap.Position = new GMap.NET.PointLatLng(lat, longt);
            gMap.MinZoom = 1;
            gMap.MaxZoom = 18;
            gMap.Zoom = 25;

            //new marker
            Bitmap studmarker = (Bitmap)Image.FromFile("img/stusdiyer.png");
            Bitmap studmarker2 = (Bitmap)Image.FromFile("img/stusdiyer2.png");
            

            GMap.NET.PointLatLng point = new GMap.NET.PointLatLng(lat, longt);

            GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(point, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker);
            gMap.Overlays.Add(markers);

            //destination
            GMap.NET.PointLatLng pointD = new GMap.NET.PointLatLng(14.555360, 121.043873);

            GMap.NET.WindowsForms.GMapOverlay markersD = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker markerD = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(pointD, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(markerD);
            gMap.Overlays.Add(markersD);

            //route
            GMap.NET.PointLatLng pointR = new GMap.NET.PointLatLng(14.555360, 121.043873);
            var route = GoogleMapProvider.Instance.GetRoute(point, pointR, false, false, 10);
            var r = new GMap.NET.WindowsForms.GMapRoute(route.Points, "My Route")
            {
                Stroke = new Pen(Color.Blue,5)
                
            };
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            gMap.Overlays.Add(routes);

            //student1
            GMap.NET.PointLatLng point1 = new GMap.NET.PointLatLng(14.527394, 121.056395);

            GMap.NET.WindowsForms.GMapOverlay markers1 = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker1 = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(point1, studmarker);
            markers.Markers.Add(marker1);
            gMap.Overlays.Add(markers1);


            //student1.1
            GMap.NET.PointLatLng point11 = new GMap.NET.PointLatLng(14.527005, 121.056209);

            GMap.NET.WindowsForms.GMapOverlay markers11 = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker11 = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(point11, studmarker);
            markers.Markers.Add(marker11);
            gMap.Overlays.Add(markers11);

            //student1.2
            GMap.NET.PointLatLng point12 = new GMap.NET.PointLatLng(14.528199, 121.056666);

            GMap.NET.WindowsForms.GMapOverlay markers12 = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker12 = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(point12, studmarker2);
            markers.Markers.Add(marker12);
            gMap.Overlays.Add(markers12);


            //student2
            GMap.NET.PointLatLng point2 = new GMap.NET.PointLatLng(14.535635, 121.057739);

            GMap.NET.WindowsForms.GMapOverlay markers2 = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker2 = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(point2, studmarker);
            markers.Markers.Add(marker2);
            gMap.Overlays.Add(markers2);

            //student21
            GMap.NET.PointLatLng point21 = new GMap.NET.PointLatLng(14.535594, 121.057733);

            GMap.NET.WindowsForms.GMapOverlay markers21 = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker21 = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(point21, studmarker2);
            markers.Markers.Add(marker21);
            gMap.Overlays.Add(markers21);

            //student21
            GMap.NET.PointLatLng point22 = new GMap.NET.PointLatLng(14.536337, 121.057685);

            GMap.NET.WindowsForms.GMapOverlay markers22 = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker22 = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(point22, studmarker2);
            markers.Markers.Add(marker22);
            gMap.Overlays.Add(markers22);

           

        }

        private void btnZoomin_Click(object sender, EventArgs e)
        {
            gMap.Zoom += 1;
        }

        private void btnZoomout_Click(object sender, EventArgs e)
        {
            gMap.Zoom -= 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            gMap.Zoom += 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = DateTime.Now.ToShortTimeString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pctSettings_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            pctSettings.Visible = false;
            pctSettings2.Visible = true;

            pctProfile.Visible = true;
            panel3.Visible = false;
            pctProfile2.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pctSettings.Visible = true;
            pctSettings2.Visible = false;
        }

        private void pctExit_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctProfile_Click(object sender, EventArgs e)
        {
            pctProfile.Visible = false;
            panel3.Visible = true;
            pctProfile2.Visible = true;

            panel2.Visible = false;
            pctSettings.Visible = true;
            pctSettings2.Visible = false;
        }

        private void pctProfile2_Click(object sender, EventArgs e)
        {
            pctProfile.Visible = true;
            panel3.Visible = false;
            pctProfile2.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form_LoginScreen ss = new Form_LoginScreen();
            ss.Show();
            this.Hide();
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LoginScreen ss = new Form_LoginScreen();
            ss.Show();
        }
    }
}
