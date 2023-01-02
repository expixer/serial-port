using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SeriPortProgrami
{
    public partial class Form1 : Form
    {
        string fileName = DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonDisconnect.Enabled = false;
            buttonSend.Enabled = false;
            foreach (var serialPort in SerialPort.GetPortNames()){
                comboBoxSeriPortlar.Items.Add(serialPort);
            }
            if (comboBoxSeriPortlar.Items.Count > 0){
                comboBoxSeriPortlar.SelectedIndex = 0;
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string dosya = path + "\\" + fileName + ".txt";
            File.AppendAllText(dosya, "tarih,sicaklik1,sicaklik2,sicaklik3,sicaklik4,sicaklik5 \n");


        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxSeriPortlar.Text;
            serialPort1.BaudRate = 57600;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;


            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Seri port bağlantısı yapılamadı\n Hata : {ex.Message}","Problem",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            if (serialPort1.IsOpen)
            {
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
                buttonSend.Enabled = true;
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                buttonSend.Enabled = false;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(textBoxMyMessage.Text);
                textBoxMyMessage.Clear();
            }
        }
        public delegate void veriGoster(String s);

        public void texteYaz(String s)
        {
            textBoxMessages.Text += s;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String gelenVeri = DateTime.Now.ToString("yy-MM-dd HH:mm:ss,") + serialPort1.ReadExisting();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosya = path + "\\"+ fileName + ".txt";
            string kayit = gelenVeri ;

                string[] bolunenKayit = kayit.Split(',');
                
                //label1.Text = kayit.Split(',')[0];
            File.AppendAllText(dosya, bolunenKayit.Length.ToString());
            //textBoxMessages.Text += gelenVeri;
            textBoxMessages.Invoke(new veriGoster(texteYaz), bolunenKayit.Length.ToString());
        }
    }
}
