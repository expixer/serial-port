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
        static DateTime baslangic = DateTime.Now;
        static string fileName = baslangic.ToString("yyyy_MM_dd HH_mm_ss");
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string dosya = path + "\\" + fileName + ".csv";
        static DateTime ilkVeriTarihi = new DateTime();  

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
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

            File.AppendAllText(dosya, "zaman_ms;hiz_kmh;T_bat_C;V_bat_C;kalan_enerji_Wh \r\n");


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

                MessageBox.Show($"Seri port bağlantısı yapılamadı\n Hata : {ex.Message}"
                    ,"Sorun",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            DateTime zamanDamgasi = DateTime.Now;
            if (ilkVeriTarihi == DateTime.MinValue)
            {
                ilkVeriTarihi = zamanDamgasi;
            }
            Double zamanFarki = (zamanDamgasi - ilkVeriTarihi).TotalMilliseconds;
            String gelenVeri = (int)zamanFarki + ";" + serialPort1.ReadExisting();
            gelenVeri += Environment.NewLine;
            string kayit = gelenVeri ;
            if (kayit != "" && !String.IsNullOrEmpty(kayit))
            {
                string[] bolunenKayit = kayit.Split(';');

                if (bolunenKayit.Length >= 5)
                {

                    File.AppendAllText(dosya, kayit);
                    zamanText.Text = zamanDamgasi.ToString("HH:mm:ss");
                    hizText.Text = bolunenKayit[1];
                    sicaklikText.Text = bolunenKayit[2];
                    gerilimText.Text = bolunenKayit[3];
                    enerjiText.Text = bolunenKayit[4];
                    //textBoxMessages.Text += gelenVeri;
                    textBoxMessages.Invoke(new veriGoster(texteYaz), gelenVeri);
                }
            }
        }


    }
}
