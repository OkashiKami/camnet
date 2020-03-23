using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Linq;
using System.Net;

namespace Camsnet
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "flILcOcSz2Evxn0pNR0xgYUn1sXcBeOi9dnWvqYi",
            BasePath = "https://camsnet-1d14b.firebaseio.com/"
        };
        FirebaseClient client;
        public int status;
        private Server server;

        public T GetSettings<T>(string fieldName) { if (client == null) return default(T); return client.Get($"camsnet/settings/{fieldName}").ResultAs<T>(); }
        public void SetSettings<T>(string fieldName, T value) { if (client == null) return; client.Set<T>($"camsnet/settings/{fieldName}", value); }

        public Form1()
        {
            InitializeComponent();
            ConnectToFireStore();
            InitializeFireStore();
            server = new Server();
            server.SetClient(client);

            var hostip = IPAddress.Any.ToString();
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                   hostip =  ip.ToString();
                    break;
                }
            }


            if (iptextbox.Text == IPAddress.Any.ToString() || iptextbox.Text != hostip)
            {
                iptextbox.Text = hostip;
            }
        }

        private void ConnectToFireStore()
        {
            client = new FirebaseClient(config);
            connectionIndicator.BackColor = client != null ? Color.Green : Color.Red;
        }
        private void InitializeFireStore()
        {
            iptextbox.Text = GetSettings<string>("ip");
            porttextbox.Text = GetSettings<string>("port");
            xAxis.Value = GetSettings<int>("xAxis");
            yAxis.Value = GetSettings<int>("yAxis");
            zoomAxis.Value = GetSettings<int>("zoom");

        }

        private void iptextbox_TextChanged(object sender, EventArgs e) => SetSettings("ip", iptextbox.Text);
        private void porttextbox_TextChanged(object sender, EventArgs e) => SetSettings("port", porttextbox.Text);
        private void xAxis_ValueChanged(object sender, EventArgs e) => SetSettings("xAxis", xAxis.Value);
        private void yAxis_ValueChanged(object sender, EventArgs e) => SetSettings("yAxis", yAxis.Value);
        private void zoom_ValueChanged(object sender, EventArgs e) => SetSettings("zoom", zoomAxis.Value);

        private void Tick(object sender, EventArgs e)
        {
            xAxisLabel.Text = xAxis.Value + "%";
            yAxisLabel.Text = xAxis.Value + "%";
            zoomLabel.Text = zoomAxis.Value + "%";
        }

        private void resetX(object sender, EventArgs e) => xAxis.Value = 0;
        private void resetY(object sender, EventArgs e) => yAxis.Value = 0;
        private void resetZ(object sender, EventArgs e) => zoomAxis.Value = 0;

        private void actionbutton_Click(object sender, EventArgs e)
        {
            switch(status)
            {
                case 0:
                    // Update UI
                    actionbutton.Text = "Stop";
                    actionbutton.ForeColor = Color.Red;
                    status = 1;
                    // Start Server
                    server.Start();
                    break;
                case 1:
                    // Stop Server
                    server.Stop();
                    // Update UI
                    actionbutton.Text = "Start";
                    actionbutton.ForeColor = Color.Green;
                    status = 0;
                    break;

            }
        }
    }
}

public class Server
{
    private FirebaseClient client;

    public Server()
    {
       
    }
    internal void SetClient(FirebaseClient client) => this.client = client;
    public T GetSettings<T>(string fieldName) { if (client == null) return default(T); return client.Get($"camsnet/settings/{fieldName}").ResultAs<T>(); }
    public void SetSettings<T>(string fieldName, T value) { if (client == null) return; client.Set<T>($"camsnet/settings/{fieldName}", value); }

    internal void Start()
    {
       
    }

    internal void Stop()
    {
        
    }
}