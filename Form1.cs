using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace DESTINATION
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent(); 
        }

        private void btnserverrqu_Click(object sender, EventArgs e)
        {
           

            TcpClient tc = new TcpClient(Environment.MachineName, 2000);
            NetworkStream ns = tc.GetStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ns, txtfiletype.Text);
            bf.Serialize(ns, txtfilename.Text);
            tc.Close();
            ns.Close();
            

            //string name = "PACKET HIDING";
            string loadfiles = Application.StartupPath+"\\PACKET HIDING.xml";
            XmlDocument doc = new XmlDocument();
            XmlTextWriter tw = new XmlTextWriter(loadfiles, System.Text.Encoding.UTF8);
            tw.WriteStartElement("HIDING");
            tw.Close();
            doc.Load(loadfiles);
            XmlNode root = doc.DocumentElement;
            XmlElement chelnode1 = doc.CreateElement("FileName");
            XmlElement chelnode2 = doc.CreateElement("FileType");
            
            root.AppendChild(chelnode1);
            chelnode1.InnerText = txtfilename.Text;
            root.AppendChild(chelnode2);
            chelnode2.InnerText = txtfiletype.Text;
            doc.Save(loadfiles);

            Control.CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();
            

        }

        public void receivefile()
        {
            TcpListener tl = new TcpListener(IPAddress.Any, 4000);
            tl.Start();
            Socket soc = tl.AcceptSocket();
            NetworkStream ns = new NetworkStream(soc);
            BinaryFormatter bf = new BinaryFormatter();
            object identynode = bf.Deserialize(ns);
            object avilablenode = bf.Deserialize(ns);
            


            if (identynode.ToString() == "INTER 1")
            {
                textBox1.Text = avilablenode.ToString();
                button1.Visible = true;
            }
            if (identynode.ToString() == "INTER 2")
            {
                textBox1.Text = avilablenode.ToString();
                button1.Visible = true;
            }
            if (identynode.ToString() == "INTER 3")
            {
                textBox1.Text = avilablenode.ToString();
                button1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           button1.Visible = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewfiles form = new viewfiles();
            form.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            receivefile();
        }

        private void txtfilename_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
