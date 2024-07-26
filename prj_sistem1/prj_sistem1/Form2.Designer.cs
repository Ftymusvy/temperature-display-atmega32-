namespace prj_sistem1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.STbtn = new System.Windows.Forms.Button();
            this.stopBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.INTROlbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Degreelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // STbtn
            // 
            this.STbtn.BackColor = System.Drawing.Color.Navy;
            this.STbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("STbtn.BackgroundImage")));
            this.STbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.STbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STbtn.ForeColor = System.Drawing.Color.Navy;
            this.STbtn.Location = new System.Drawing.Point(495, 417);
            this.STbtn.Name = "STbtn";
            this.STbtn.Size = new System.Drawing.Size(92, 86);
            this.STbtn.TabIndex = 0;
            this.STbtn.UseVisualStyleBackColor = false;
            this.STbtn.Click += new System.EventHandler(this.STbtn_Click);
            // 
            // stopBTN
            // 
            this.stopBTN.BackColor = System.Drawing.Color.Navy;
            this.stopBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopBTN.BackgroundImage")));
            this.stopBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBTN.ForeColor = System.Drawing.Color.Navy;
            this.stopBTN.Location = new System.Drawing.Point(400, 418);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(89, 86);
            this.stopBTN.TabIndex = 1;
            this.stopBTN.Text = " ";
            this.stopBTN.UseVisualStyleBackColor = false;
            this.stopBTN.Click += new System.EventHandler(this.stopBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.BackColor = System.Drawing.Color.Navy;
            this.exitBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBTN.BackgroundImage")));
            this.exitBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBTN.ForeColor = System.Drawing.Color.Navy;
            this.exitBTN.Location = new System.Drawing.Point(12, 417);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(89, 87);
            this.exitBTN.TabIndex = 2;
            this.exitBTN.Text = " ";
            this.exitBTN.UseVisualStyleBackColor = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // INTROlbl
            // 
            this.INTROlbl.AutoSize = true;
            this.INTROlbl.BackColor = System.Drawing.Color.Navy;
            this.INTROlbl.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.INTROlbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.INTROlbl.Location = new System.Drawing.Point(197, 9);
            this.INTROlbl.Name = "INTROlbl";
            this.INTROlbl.Size = new System.Drawing.Size(220, 53);
            this.INTROlbl.TabIndex = 3;
            this.INTROlbl.Text = "نمایش دمای محیط";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            this.serialPort1.ReadTimeout = 1000;
            this.serialPort1.WriteTimeout = 1000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Degreelbl
            // 
            this.Degreelbl.AutoSize = true;
            this.Degreelbl.BackColor = System.Drawing.Color.RoyalBlue;
            this.Degreelbl.Font = new System.Drawing.Font("B Titr", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Degreelbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Degreelbl.Location = new System.Drawing.Point(261, 215);
            this.Degreelbl.Name = "Degreelbl";
            this.Degreelbl.Size = new System.Drawing.Size(93, 85);
            this.Degreelbl.TabIndex = 4;
            this.Degreelbl.Text = "27";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 516);
            this.Controls.Add(this.Degreelbl);
            this.Controls.Add(this.INTROlbl);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.STbtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button STbtn;
        private System.Windows.Forms.Button stopBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label INTROlbl;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label Degreelbl;
    }
}