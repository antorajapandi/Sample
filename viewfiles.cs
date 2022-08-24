using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Xml;


namespace DESTINATION
{
    public partial class viewfiles : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=packethiding;integrated security=true;");

        public viewfiles()
        {
            InitializeComponent();
        }

        private void btngetfile_Click(object sender, EventArgs e)
        {
            string XMLFilePath = Application.StartupPath + "\\PACKET HIDING.xml"; //@"D:\Suresh IEEE 2012\PACKET HIDING\DESTINATION\DESTINATION\bin\Debug\PACKET HIDING.xml";


            DataSet ds = new DataSet();
            ds.ReadXml(XMLFilePath);
 
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox3.Text = dr["FileName"].ToString().Trim();
                // textBox4.Text = dr["FileType"].ToString().Trim();



                if (textBox1.Text == textBox3.Text)
                {
                    string dot = ".";
                    StreamReader sr = new StreamReader(@"c:\PACKET HIDING pro\SERVER NODE\SERVER NODE\bin\Debug\files\" + textBox1.Text + "");
                 //   StreamReader sr = new StreamReader(Application.StartupPath +"\\files\\" + textBox1.Text);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    TcpClient tc = new TcpClient(Environment.MachineName, 1000);
                    NetworkStream ns = tc.GetStream();
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ns, "Destination");

                    tc.Close();
                    ns.Close();

                }
                else
                {
                    MessageBox.Show("Enter The correct Format", "Wrong Format");
                }
            }
        }
    }
}
        
                