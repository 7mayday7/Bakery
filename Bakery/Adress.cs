using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;

namespace Bakery
{
    public partial class Adress : Form
    {
        public Adress()
        {
            InitializeComponent();
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; 
            gMapControl1.MinZoom = 2; 
            gMapControl1.MaxZoom = 16; 
            gMapControl1.Zoom = 3; 
            gMapControl1.Position = new GMap.NET.PointLatLng(56.98576005714678, 64.51451770789286);
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; 
            gMapControl1.CanDragMap = true; 
            gMapControl1.DragButton = MouseButtons.Left; 
            gMapControl1.ShowCenter = false; 
            gMapControl1.ShowTileGridLines = false; 
            gMapControl1.Dock = DockStyle.Right;

            GMapOverlay markerOverlay = new GMapOverlay("marker");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(45.05104159532123, 38.97928094594705), GMarkerGoogleType.purple_pushpin);
            GMarkerGoogle marker2 = new GMarkerGoogle(new PointLatLng(55.79096274642899, 37.53417599829798), GMarkerGoogleType.purple_pushpin);
            GMarkerGoogle marker3 = new GMarkerGoogle(new PointLatLng(54.99225186261956, 73.37341894363254), GMarkerGoogleType.purple_pushpin);
            GMarkerGoogle marker4 = new GMarkerGoogle(new PointLatLng(59.927684428704566, 30.36056619846857), GMarkerGoogleType.purple_pushpin);
            marker.ToolTipText = "Краснодар, ТЦ «Центр Города»";
            marker2.ToolTipText = "Москва, ТЦ «АвиаПарк»";
            marker3.ToolTipText = "Омск, ТЦ «Омский»";
            marker4.ToolTipText = "Санкт-Петербург, ТЦ «Галерея»";
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker2.ToolTipMode = MarkerTooltipMode.Always;
            marker3.ToolTipMode = MarkerTooltipMode.Always;
            marker4.ToolTipMode = MarkerTooltipMode.Always;
            markerOverlay.Markers.Add(marker);
            markerOverlay.Markers.Add(marker2);
            markerOverlay.Markers.Add(marker3);
            markerOverlay.Markers.Add(marker4);
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            PointLatLng point = item.Position;
            string address = string.Format("\n{0}, {1}", point.Lat, point.Lng);

            // Copy the address to clipboard
            Clipboard.SetText(address);
            MessageBox.Show("Адрес, скопированный в буфер обмена: " + address);
        }
    }
}

