namespace SeriPortProgrami
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxSeriPortlar = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.textBoxMyMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.zamanText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sicaklikText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hizText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gerilimText = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.enerjiText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSeriPortlar
            // 
            this.comboBoxSeriPortlar.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxSeriPortlar, "comboBoxSeriPortlar");
            this.comboBoxSeriPortlar.Name = "comboBoxSeriPortlar";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonConnect
            // 
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            resources.ApplyResources(this.buttonDisconnect, "buttonDisconnect");
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBoxMessages
            // 
            resources.ApplyResources(this.textBoxMessages, "textBoxMessages");
            this.textBoxMessages.Name = "textBoxMessages";
            // 
            // textBoxMyMessage
            // 
            resources.ApplyResources(this.textBoxMyMessage, "textBoxMyMessage");
            this.textBoxMyMessage.Name = "textBoxMyMessage";
            // 
            // buttonSend
            // 
            resources.ApplyResources(this.buttonSend, "buttonSend");
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // zamanText
            // 
            resources.ApplyResources(this.zamanText, "zamanText");
            this.zamanText.Name = "zamanText";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // sicaklikText
            // 
            resources.ApplyResources(this.sicaklikText, "sicaklikText");
            this.sicaklikText.Name = "sicaklikText";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // hizText
            // 
            resources.ApplyResources(this.hizText, "hizText");
            this.hizText.Name = "hizText";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // gerilimText
            // 
            resources.ApplyResources(this.gerilimText, "gerilimText");
            this.gerilimText.Name = "gerilimText";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // enerjiText
            // 
            resources.ApplyResources(this.enerjiText, "enerjiText");
            this.enerjiText.Name = "enerjiText";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.enerjiText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gerilimText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hizText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sicaklikText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zamanText);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMyMessage);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxSeriPortlar);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSeriPortlar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.TextBox textBoxMyMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label zamanText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sicaklikText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hizText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label gerilimText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label enerjiText;
    }
}

