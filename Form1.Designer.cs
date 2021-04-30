
namespace ServoAndEncoderHello_FrontEnd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMTRSTART = new System.Windows.Forms.Button();
            this.btnMTRSTOP = new System.Windows.Forms.Button();
            this.btnMTRDIRCW = new System.Windows.Forms.Button();
            this.btnMTRDIRCCW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSTATUS = new System.Windows.Forms.Label();
            this.comboBoxSerialPorts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSerialData = new System.Windows.Forms.TextBox();
            this.btnDumpOutput = new System.Windows.Forms.Button();
            this.btnToggleCOM = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnSingleRotation = new System.Windows.Forms.Button();
            this.btnPulsePerSec = new System.Windows.Forms.Button();
            this.btn400Pulse = new System.Windows.Forms.Button();
            this.btnRotateDeg = new System.Windows.Forms.Button();
            this.txtRotateDeg = new System.Windows.Forms.TextBox();
            this.btnLoadCellTare = new System.Windows.Forms.Button();
            this.btnLoadCellCalib = new System.Windows.Forms.Button();
            this.btnLoadCellRead = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoadCellPlus10 = new System.Windows.Forms.Button();
            this.btnLoadCellMinus10 = new System.Windows.Forms.Button();
            this.btnLoadCellPlus100 = new System.Windows.Forms.Button();
            this.btnLoadCellMinus100 = new System.Windows.Forms.Button();
            this.btnLoadCellEndCalib = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoadCellPlus1000 = new System.Windows.Forms.Button();
            this.btnLoadCellMinus1000 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMTRSTART
            // 
            this.btnMTRSTART.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMTRSTART.Location = new System.Drawing.Point(9, 9);
            this.btnMTRSTART.Name = "btnMTRSTART";
            this.btnMTRSTART.Size = new System.Drawing.Size(150, 75);
            this.btnMTRSTART.TabIndex = 0;
            this.btnMTRSTART.Text = "MOTOR ON";
            this.btnMTRSTART.UseVisualStyleBackColor = true;
            this.btnMTRSTART.Click += new System.EventHandler(this.btnMTRSTART_Click);
            // 
            // btnMTRSTOP
            // 
            this.btnMTRSTOP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMTRSTOP.Location = new System.Drawing.Point(9, 98);
            this.btnMTRSTOP.Name = "btnMTRSTOP";
            this.btnMTRSTOP.Size = new System.Drawing.Size(150, 75);
            this.btnMTRSTOP.TabIndex = 1;
            this.btnMTRSTOP.Text = "MOTOR OFF";
            this.btnMTRSTOP.UseVisualStyleBackColor = true;
            this.btnMTRSTOP.Click += new System.EventHandler(this.btnMTRSTOP_Click);
            // 
            // btnMTRDIRCW
            // 
            this.btnMTRDIRCW.Location = new System.Drawing.Point(171, 9);
            this.btnMTRDIRCW.Name = "btnMTRDIRCW";
            this.btnMTRDIRCW.Size = new System.Drawing.Size(75, 75);
            this.btnMTRDIRCW.TabIndex = 2;
            this.btnMTRDIRCW.Text = "MOTOR: CW";
            this.btnMTRDIRCW.UseVisualStyleBackColor = true;
            this.btnMTRDIRCW.Click += new System.EventHandler(this.btnMTRDIRCW_Click);
            // 
            // btnMTRDIRCCW
            // 
            this.btnMTRDIRCCW.Location = new System.Drawing.Point(172, 98);
            this.btnMTRDIRCCW.Name = "btnMTRDIRCCW";
            this.btnMTRDIRCCW.Size = new System.Drawing.Size(75, 75);
            this.btnMTRDIRCCW.TabIndex = 3;
            this.btnMTRDIRCCW.Text = "MOTOR: CCW";
            this.btnMTRDIRCCW.UseVisualStyleBackColor = true;
            this.btnMTRDIRCCW.Click += new System.EventHandler(this.btnMTRDIRCCW_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 673);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "STATUS:";
            // 
            // lblSTATUS
            // 
            this.lblSTATUS.AutoSize = true;
            this.lblSTATUS.Location = new System.Drawing.Point(60, 673);
            this.lblSTATUS.Name = "lblSTATUS";
            this.lblSTATUS.Size = new System.Drawing.Size(66, 15);
            this.lblSTATUS.TabIndex = 5;
            this.lblSTATUS.Text = "NO STATUS";
            // 
            // comboBoxSerialPorts
            // 
            this.comboBoxSerialPorts.FormattingEnabled = true;
            this.comboBoxSerialPorts.Location = new System.Drawing.Point(7, 637);
            this.comboBoxSerialPorts.Name = "comboBoxSerialPorts";
            this.comboBoxSerialPorts.Size = new System.Drawing.Size(150, 23);
            this.comboBoxSerialPorts.TabIndex = 7;
            this.comboBoxSerialPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPorts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select COM Port:";
            // 
            // textBoxSerialData
            // 
            this.textBoxSerialData.Location = new System.Drawing.Point(255, 9);
            this.textBoxSerialData.Multiline = true;
            this.textBoxSerialData.Name = "textBoxSerialData";
            this.textBoxSerialData.ReadOnly = true;
            this.textBoxSerialData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSerialData.Size = new System.Drawing.Size(428, 604);
            this.textBoxSerialData.TabIndex = 9;
            // 
            // btnDumpOutput
            // 
            this.btnDumpOutput.Location = new System.Drawing.Point(511, 619);
            this.btnDumpOutput.Name = "btnDumpOutput";
            this.btnDumpOutput.Size = new System.Drawing.Size(87, 46);
            this.btnDumpOutput.TabIndex = 10;
            this.btnDumpOutput.Text = "OUTPUT LOG TO FILE";
            this.btnDumpOutput.UseVisualStyleBackColor = true;
            this.btnDumpOutput.Click += new System.EventHandler(this.btnDumpOutput_Click);
            // 
            // btnToggleCOM
            // 
            this.btnToggleCOM.Location = new System.Drawing.Point(166, 620);
            this.btnToggleCOM.Name = "btnToggleCOM";
            this.btnToggleCOM.Size = new System.Drawing.Size(74, 45);
            this.btnToggleCOM.TabIndex = 11;
            this.btnToggleCOM.Text = "TOGGLE COM";
            this.btnToggleCOM.UseVisualStyleBackColor = true;
            this.btnToggleCOM.Click += new System.EventHandler(this.btnToggleCOM_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(604, 619);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(79, 46);
            this.btnClearLog.TabIndex = 12;
            this.btnClearLog.Text = "CLEAR LOG WINDOW";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnSingleRotation
            // 
            this.btnSingleRotation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSingleRotation.Location = new System.Drawing.Point(9, 201);
            this.btnSingleRotation.Name = "btnSingleRotation";
            this.btnSingleRotation.Size = new System.Drawing.Size(150, 50);
            this.btnSingleRotation.TabIndex = 13;
            this.btnSingleRotation.Text = "SINGLE MOTOR ROTATION";
            this.btnSingleRotation.UseVisualStyleBackColor = true;
            this.btnSingleRotation.Click += new System.EventHandler(this.btnSingleRotation_Click);
            // 
            // btnPulsePerSec
            // 
            this.btnPulsePerSec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPulsePerSec.Location = new System.Drawing.Point(9, 257);
            this.btnPulsePerSec.Name = "btnPulsePerSec";
            this.btnPulsePerSec.Size = new System.Drawing.Size(150, 50);
            this.btnPulsePerSec.TabIndex = 14;
            this.btnPulsePerSec.Text = "SINGLE PULSE PER SECOND";
            this.btnPulsePerSec.UseVisualStyleBackColor = true;
            this.btnPulsePerSec.Click += new System.EventHandler(this.btnPulsePerSec_Click);
            // 
            // btn400Pulse
            // 
            this.btn400Pulse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn400Pulse.Location = new System.Drawing.Point(9, 313);
            this.btn400Pulse.Name = "btn400Pulse";
            this.btn400Pulse.Size = new System.Drawing.Size(150, 50);
            this.btn400Pulse.TabIndex = 15;
            this.btn400Pulse.Text = "800 PULSES";
            this.btn400Pulse.UseVisualStyleBackColor = true;
            this.btn400Pulse.Click += new System.EventHandler(this.btn400Pulse_Click);
            // 
            // btnRotateDeg
            // 
            this.btnRotateDeg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRotateDeg.Location = new System.Drawing.Point(9, 369);
            this.btnRotateDeg.Name = "btnRotateDeg";
            this.btnRotateDeg.Size = new System.Drawing.Size(150, 50);
            this.btnRotateDeg.TabIndex = 16;
            this.btnRotateDeg.Text = "ROTATE DEFINED DEGREE AMOUNT";
            this.btnRotateDeg.UseVisualStyleBackColor = true;
            this.btnRotateDeg.Click += new System.EventHandler(this.btnRotateDeg_Click);
            // 
            // txtRotateDeg
            // 
            this.txtRotateDeg.Location = new System.Drawing.Point(170, 393);
            this.txtRotateDeg.MaxLength = 3;
            this.txtRotateDeg.Name = "txtRotateDeg";
            this.txtRotateDeg.Size = new System.Drawing.Size(74, 23);
            this.txtRotateDeg.TabIndex = 17;
            // 
            // btnLoadCellTare
            // 
            this.btnLoadCellTare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadCellTare.Location = new System.Drawing.Point(9, 503);
            this.btnLoadCellTare.Name = "btnLoadCellTare";
            this.btnLoadCellTare.Size = new System.Drawing.Size(150, 23);
            this.btnLoadCellTare.TabIndex = 18;
            this.btnLoadCellTare.Text = "TARE load cell";
            this.btnLoadCellTare.UseVisualStyleBackColor = true;
            this.btnLoadCellTare.Click += new System.EventHandler(this.btnLoadCellTare_Click);
            // 
            // btnLoadCellCalib
            // 
            this.btnLoadCellCalib.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadCellCalib.Location = new System.Drawing.Point(9, 458);
            this.btnLoadCellCalib.Name = "btnLoadCellCalib";
            this.btnLoadCellCalib.Size = new System.Drawing.Size(150, 23);
            this.btnLoadCellCalib.TabIndex = 19;
            this.btnLoadCellCalib.Text = "CALIBRATE load cell";
            this.btnLoadCellCalib.UseVisualStyleBackColor = true;
            this.btnLoadCellCalib.Click += new System.EventHandler(this.btnLoadCellCalib_Click);
            // 
            // btnLoadCellRead
            // 
            this.btnLoadCellRead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadCellRead.Location = new System.Drawing.Point(9, 548);
            this.btnLoadCellRead.Name = "btnLoadCellRead";
            this.btnLoadCellRead.Size = new System.Drawing.Size(150, 23);
            this.btnLoadCellRead.TabIndex = 20;
            this.btnLoadCellRead.Text = "READ load cell";
            this.btnLoadCellRead.UseVisualStyleBackColor = true;
            this.btnLoadCellRead.Click += new System.EventHandler(this.btnLoadCellRead_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(165, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "CALIBRATION:";
            // 
            // btnLoadCellPlus10
            // 
            this.btnLoadCellPlus10.Location = new System.Drawing.Point(169, 458);
            this.btnLoadCellPlus10.Name = "btnLoadCellPlus10";
            this.btnLoadCellPlus10.Size = new System.Drawing.Size(35, 23);
            this.btnLoadCellPlus10.TabIndex = 22;
            this.btnLoadCellPlus10.Text = "+10";
            this.btnLoadCellPlus10.UseVisualStyleBackColor = true;
            this.btnLoadCellPlus10.Click += new System.EventHandler(this.btnLoadCellPlus10_Click);
            // 
            // btnLoadCellMinus10
            // 
            this.btnLoadCellMinus10.Location = new System.Drawing.Point(169, 487);
            this.btnLoadCellMinus10.Name = "btnLoadCellMinus10";
            this.btnLoadCellMinus10.Size = new System.Drawing.Size(35, 23);
            this.btnLoadCellMinus10.TabIndex = 23;
            this.btnLoadCellMinus10.Text = "-10";
            this.btnLoadCellMinus10.UseVisualStyleBackColor = true;
            this.btnLoadCellMinus10.Click += new System.EventHandler(this.btnLoadCellMinus10_Click);
            // 
            // btnLoadCellPlus100
            // 
            this.btnLoadCellPlus100.Location = new System.Drawing.Point(206, 458);
            this.btnLoadCellPlus100.Name = "btnLoadCellPlus100";
            this.btnLoadCellPlus100.Size = new System.Drawing.Size(41, 23);
            this.btnLoadCellPlus100.TabIndex = 24;
            this.btnLoadCellPlus100.Text = "+100";
            this.btnLoadCellPlus100.UseVisualStyleBackColor = true;
            this.btnLoadCellPlus100.Click += new System.EventHandler(this.btnLoadCellPlus100_Click);
            // 
            // btnLoadCellMinus100
            // 
            this.btnLoadCellMinus100.Location = new System.Drawing.Point(206, 487);
            this.btnLoadCellMinus100.Name = "btnLoadCellMinus100";
            this.btnLoadCellMinus100.Size = new System.Drawing.Size(41, 23);
            this.btnLoadCellMinus100.TabIndex = 25;
            this.btnLoadCellMinus100.Text = "-100";
            this.btnLoadCellMinus100.UseVisualStyleBackColor = true;
            this.btnLoadCellMinus100.Click += new System.EventHandler(this.btnLoadCellMinus100_Click);
            // 
            // btnLoadCellEndCalib
            // 
            this.btnLoadCellEndCalib.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadCellEndCalib.Location = new System.Drawing.Point(180, 567);
            this.btnLoadCellEndCalib.Name = "btnLoadCellEndCalib";
            this.btnLoadCellEndCalib.Size = new System.Drawing.Size(55, 23);
            this.btnLoadCellEndCalib.TabIndex = 26;
            this.btnLoadCellEndCalib.Text = "end cal";
            this.btnLoadCellEndCalib.UseVisualStyleBackColor = true;
            this.btnLoadCellEndCalib.Click += new System.EventHandler(this.btnLoadCellEndCalib_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(169, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "DEGREES:";
            // 
            // btnLoadCellPlus1000
            // 
            this.btnLoadCellPlus1000.Location = new System.Drawing.Point(169, 516);
            this.btnLoadCellPlus1000.Name = "btnLoadCellPlus1000";
            this.btnLoadCellPlus1000.Size = new System.Drawing.Size(77, 23);
            this.btnLoadCellPlus1000.TabIndex = 28;
            this.btnLoadCellPlus1000.Text = "+1000";
            this.btnLoadCellPlus1000.UseVisualStyleBackColor = true;
            this.btnLoadCellPlus1000.Click += new System.EventHandler(this.btnLoadCellPlus1000_Click);
            // 
            // btnLoadCellMinus1000
            // 
            this.btnLoadCellMinus1000.Location = new System.Drawing.Point(169, 541);
            this.btnLoadCellMinus1000.Name = "btnLoadCellMinus1000";
            this.btnLoadCellMinus1000.Size = new System.Drawing.Size(77, 23);
            this.btnLoadCellMinus1000.TabIndex = 29;
            this.btnLoadCellMinus1000.Text = "-1000";
            this.btnLoadCellMinus1000.UseVisualStyleBackColor = true;
            this.btnLoadCellMinus1000.Click += new System.EventHandler(this.btnLoadCellMinus1000_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 689);
            this.Controls.Add(this.btnLoadCellMinus1000);
            this.Controls.Add(this.btnLoadCellPlus1000);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoadCellEndCalib);
            this.Controls.Add(this.btnLoadCellMinus100);
            this.Controls.Add(this.btnLoadCellPlus100);
            this.Controls.Add(this.btnLoadCellMinus10);
            this.Controls.Add(this.btnLoadCellPlus10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoadCellRead);
            this.Controls.Add(this.btnLoadCellCalib);
            this.Controls.Add(this.btnLoadCellTare);
            this.Controls.Add(this.txtRotateDeg);
            this.Controls.Add(this.btnRotateDeg);
            this.Controls.Add(this.btn400Pulse);
            this.Controls.Add(this.btnPulsePerSec);
            this.Controls.Add(this.btnSingleRotation);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnToggleCOM);
            this.Controls.Add(this.btnDumpOutput);
            this.Controls.Add(this.textBoxSerialData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSerialPorts);
            this.Controls.Add(this.lblSTATUS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMTRDIRCCW);
            this.Controls.Add(this.btnMTRDIRCW);
            this.Controls.Add(this.btnMTRSTOP);
            this.Controls.Add(this.btnMTRSTART);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMTRSTART;
        private System.Windows.Forms.Button btnMTRSTOP;
        private System.Windows.Forms.Button btnMTRDIRCW;
        private System.Windows.Forms.Button btnMTRDIRCCW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSTATUS;
        private System.Windows.Forms.ComboBox comboBoxSerialPorts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSerialData;
        private System.Windows.Forms.Button btnDumpOutput;
        private System.Windows.Forms.Button btnToggleCOM;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnSingleRotation;
        private System.Windows.Forms.Button btnPulsePerSec;
        private System.Windows.Forms.Button btn400Pulse;
        private System.Windows.Forms.Button btnRotateDeg;
        private System.Windows.Forms.TextBox txtRotateDeg;
        private System.Windows.Forms.Button btnLoadCellTare;
        private System.Windows.Forms.Button btnLoadCellCalib;
        private System.Windows.Forms.Button btnLoadCellRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadCellPlus10;
        private System.Windows.Forms.Button btnLoadCellMinus10;
        private System.Windows.Forms.Button btnLoadCellPlus100;
        private System.Windows.Forms.Button btnLoadCellMinus100;
        private System.Windows.Forms.Button btnLoadCellEndCalib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadCellPlus1000;
        private System.Windows.Forms.Button btnLoadCellMinus1000;
    }
}

