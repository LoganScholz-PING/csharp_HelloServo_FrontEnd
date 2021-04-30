using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace ServoAndEncoderHello_FrontEnd
{
    
    public partial class Form1 : Form
    {
        public SerialPort _serialPortMEGA = new SerialPort();

        
        public Form1()
        {
            InitializeComponent();

            /***************** START SERIAL INITIALIZATION *****************/
            // Initialize our MEGA 2560 serial communication
            // (Note that COM generically initializes to COM1)
            _serialPortMEGA.BaudRate = 9600;
            _serialPortMEGA.DataBits = 8;
            _serialPortMEGA.Parity = System.IO.Ports.Parity.None;
            _serialPortMEGA.Encoding = System.Text.Encoding.Default;
            _serialPortMEGA.StopBits = StopBits.One;
            _serialPortMEGA.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            // Populate a list of active serial ports:
            string[] COMports = SerialPort.GetPortNames();
            Array.Sort(COMports);

            // Add this list to the serial port drop-down box:
            foreach (string port in COMports)
            {
                comboBoxSerialPorts.Items.Add(port);
            }
            /***************** END SERIAL INITIALIZATION *****************/

        }

        public delegate void SetTextDelegate(string text);
        private void si_DataReceived(string data) 
        {
            textBoxSerialData.AppendText(DateTime.Now.ToString("MM-dd-yyyy_HH:mm:ss: ") + data + "\n");
        }

        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            // This function will crash the program if you perfectly kill
            // COM communication during a read operation (you have to get
            // lucky, but it can happen). Thus we must try/catch:
            try
            {
                string inSerialData = _serialPortMEGA.ReadLine();
                // incoming serial data may come with its own newlines or carriage
                // returns. If so, get rid of them so we can add our own in the
                // correct areas
                inSerialData.Trim('\r', '\n');

                // Serial reads happen in a different thread, so we have to do fancy
                // stuff to get the main thread (which controls the textBoxSerialData)
                // to update its controls using data coming from a different thread
                //
                // Note: using BeginInvoke() is better than using Invoke() because Invoke
                // can hang your program upon exit because windows is waiting for threads
                // to close (or so I hear from stack exchange)
                this.BeginInvoke(new SetTextDelegate(si_DataReceived), new object[] { inSerialData });
            }
            catch (Exception ex)
            {
                // Probably killed the COM port in the middle of a read operation
                MessageBox.Show("Error in Serial Read Function: " + ex.ToString());
            }          
        }

        /*
         * 
         * DEFINITION OF SERIAL DATA PACKETS:
         *  SEND:
         *  '<1>' - btnMTRSTART_Click()
         *          Start motor infinitiely spinning until commanded to stop
         *  '<2>' - btnMTRSTOP_Click()
         *          Stop motor (and also stop any PWM)
         *  '<3>' - btnMTRDIRCCW_Click()
         *          Change motor direction to CCW
         *  '<4>' - btnMTRDIRCW_Click()
         *          Change motor direction to CW
         *  '<5>' - btnSingleRotation_Click()
         *          Perform a single motor rotation
         *  '<6>' - btnPulsePerSec_Click()
         *          Perform a one pulse per second motor test
         *  '<7>' - btn400Pulse_Click()
         *          Pulse the motor pulse pin 800 times (800 pulses = 1 complete revolution)
         *  '<8xxx>' - btnRotateDeg_Click()
         *          Turn the motor xxx degrees, if xxx is not a valid number from 0-999 this 
         *          command will be ignored)
         *  '<9>' - btnLoadCellCalib_Click()
         *          Perform load cell calibration (determine calibration as well as zero factors)
         *  '<0>' - btnLoadCellTare_Click()
         *          Tare the load cell to 0
         *  '<a>' - btnLoadCellRead_Click()
         *          Read the current load cell value and print to serial window
         * 
         */

        private void btnMTRSTART_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPortMEGA.Write("<1>");
                lblSTATUS.Text = "MOTOR TEST STARTED";
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR STARTING MOTOR TEST - CHECK CONNECTION AND COM PORT";
            }
        }

        private void btnMTRSTOP_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPortMEGA.Write("<2>");
                lblSTATUS.Text = "MOTOR TEST STOPPED";
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR STOPPING MOTOR TEST - CHECK CONNECTION AND COM PORT";
            }
        }

        private void btnMTRDIRCW_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPortMEGA.Write("<4>");
                lblSTATUS.Text = "MOTOR DIRECTION CHANGED TO CLOCKWISE";
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR CHANGE MOTOR DIRECTION TO CW - CHECK CONNECTION AND COM PORT";
            }
        }

        private void btnMTRDIRCCW_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPortMEGA.Write("<3>");
                lblSTATUS.Text = "MOTOR DIRECTION CHANGED TO COUNTER-CLOCKWISE";
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR CHANGE MOTOR DIRECTION TO CCW - CHECK CONNECTION AND COM PORT";
            }
        }

        private void btnSingleRotation_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure no motor test is in progress
                _serialPortMEGA.Write("<2>");

                // Start single motor rotation
                _serialPortMEGA.Write("<5>");
                lblSTATUS.Text = "STARTING SINGLE MOTOR ROTATION";
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR STARTING SINGLE MOTOR ROTATION - CHECK CONNECTION";
            }
        }
        
        private void btnPulsePerSec_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure no motor test is in progress
                _serialPortMEGA.Write("<2>");

                // Start single motor rotation
                _serialPortMEGA.Write("<6>");
                lblSTATUS.Text = "STARTING SINGLE PULSE PER SECOND";
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR STARTING SINGLE PULSE PER SEC - CHECK CONNECTION";
            }
        }

        private void btn400Pulse_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure no motor test is in progress
                _serialPortMEGA.Write("<2>");

                // Start single motor rotation
                _serialPortMEGA.Write("<7>");
                lblSTATUS.Text = "STARTING 800 PULSE TEST";
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR STARTING 800 PULSE TEST - CHECK CONNECTION";
            }
        }


        private void btnRotateDeg_Click(object sender, EventArgs e)
        {
            string val = "UNK";
            try
            {
                // Make sure text box isn't empty and that it's also a parsable integer value
                if ( (txtRotateDeg.Text.Length > 0) & (int.TryParse(txtRotateDeg.Text, out int parsedValue)) )
                {
                    // Make sure no motor test is in progress
                    _serialPortMEGA.Write("<2>");

                    // .ToString("D3"); means to force the value to a minimum of 3 characters total
                    // and then left-pad with 0s if the value is < 3 characters
                    val = parsedValue.ToString("D3");
                    
                    // Start single motor rotation
                    _serialPortMEGA.Write(string.Format("<8{0}>", val));
                    lblSTATUS.Text = string.Format("Rotating {0} degrees", val);
                } 
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = string.Format("ERROR SETTING DEGREES, CHECK CONN AND DEG VALUE {0}", val);
            }
        }


        /********** start load cell calibration functions **********/
        private void btnLoadCellCalib_Click(object sender, EventArgs e)
        {
            try
            {
                // Start load cell calibration
                _serialPortMEGA.Write("<9>");
                lblSTATUS.Text = "STARTING LOAD CELL CALIBRATION";
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR STARTING LOAD CELL CALIBRATION - CHECK CONNECTION";
            }
        }

        private void btnLoadCellTare_Click(object sender, EventArgs e)
        {
            try
            {
                // Start load cell calibration
                _serialPortMEGA.Write("<0>");
                lblSTATUS.Text = "STARTING LOAD CELL TARE";
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR STARTING LOAD CELL TARE - CHECK CONNECTION";
            }
        }

        private void btnLoadCellRead_Click(object sender, EventArgs e)
        {
            try
            {
                // Start load cell calibration
                _serialPortMEGA.Write("<a>");
                lblSTATUS.Text = "READING LOAD CELL DATA";
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR READING LOAD CELL DATA - CHECK CONNECTION";
            }
        }

        private void btnLoadCellPlus10_Click(object sender, EventArgs e)
        {
            try
            {
                // During load cell calibration, add 10 to calibration factor
                _serialPortMEGA.Write("+");
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR LOAD CELL CALIB +10 - CHECK CONNECTION";
            }
        }

        private void btnLoadCellPlus100_Click(object sender, EventArgs e)
        {
            try
            {
                // During load cell calibration, add 100 to calibration factor
                _serialPortMEGA.Write("a");
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR LOAD CELL CALIB +100 - CHECK CONNECTION";
            }
        }

        private void btnLoadCellMinus10_Click(object sender, EventArgs e)
        {
            try
            {
                // During load cell calibration, subtract 10 from calibration factor
                _serialPortMEGA.Write("-");
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR LOAD CELL CALIB -10 - CHECK CONNECTION";
            }
        }

        private void btnLoadCellMinus100_Click(object sender, EventArgs e)
        {
            try
            {
                // During load cell calibration, subtract 100 from calibration factor
                _serialPortMEGA.Write("z");
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR LOAD CELL CALIB -100 - CHECK CONNECTION";
            }
        }

        private void btnLoadCellPlus1000_Click(object sender, EventArgs e)
        {
            try
            {
                // During load cell calibration, add 1000 to calibration factor
                _serialPortMEGA.Write("d");
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR LOAD CELL CALIB +1000 - CHECK CONNECTION";
            }
        }

        private void btnLoadCellMinus1000_Click(object sender, EventArgs e)
        {
            try
            {
                // During load cell calibration, subtract 1000 from calibration factor
                _serialPortMEGA.Write("f");
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR LOAD CELL CALIB -1000 - CHECK CONNECTION";
            }
        }

        private void btnLoadCellEndCalib_Click(object sender, EventArgs e)
        {
            try
            {
                // Manually end load cell calibration procedure
                _serialPortMEGA.Write("x");
            }
            catch
            {
                //MessageBox.Show(ex.Message); // to use this add "Exception ex" to the catch ()
                lblSTATUS.Text = "ERROR ENDING LOAD CELL CALIB - CHECK CONNECTION";
            }
        }
        /********** end load cell calibration functions **********/


        private void comboBoxSerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check to make sure some previous communication did not leave
            // the MEGA's serial port in use. If it did, close it
            if (_serialPortMEGA.IsOpen)
            {
                _serialPortMEGA.Close();
            }

            // Set the MEGA's serial COM port to the chosen port in the comboBox
            _serialPortMEGA.PortName = comboBoxSerialPorts.SelectedItem.ToString();
            
            // We intend to fully monopolize the Mega's COM port..
            // ..So selfishly keep it open forever
            try
            {
                _serialPortMEGA.Open();
                
                textBoxSerialData.AppendText(string.Format("\r\nOPENED {0} Serial Comm Port.\r\n", _serialPortMEGA.PortName));
                lblSTATUS.Text = string.Format("Connected to {0} Serial Communication Port.", _serialPortMEGA.PortName);
            }
            catch
            {
                textBoxSerialData.AppendText(string.Format("\r\nERROR OPENING {0} Serial Comm Port.\r\n", _serialPortMEGA.PortName));
                lblSTATUS.Text = string.Format("ERROR OPENING {0} Serial Communication Port.", _serialPortMEGA.PortName);
            }
        }

        private void btnDumpOutput_Click(object sender, EventArgs e)
        {
            try
            {
                // note that AppDomain.CurrentDomain.BaseDirectory returns a path that ends with a "\"
                // so there is no need to add it to the start of @"Logs\"
                string build_dir_string = AppDomain.CurrentDomain.BaseDirectory + @"Logs\";

                string current_time = DateTime.Now.ToString("HH-mm-ss_MM-dd-yyyy");
                string build_file_name = string.Format(@"ServoLog_{0}.txt", current_time);

                // The line below creates the folder if the folder does not exist.
                // if the folder exists, it returns a DirectoryInfo object for the
                // existing object.
                System.IO.Directory.CreateDirectory(build_dir_string);
                TextWriter tw = new StreamWriter(build_dir_string + build_file_name);
                tw.WriteLine(textBoxSerialData.Text);
                tw.Close();

                //MessageBox.Show("Saved to: " + build_dir_string + build_file_name);
                textBoxSerialData.AppendText("\r\nLog dump successful: " + build_dir_string + build_file_name + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating log file, see details: \n" + ex.ToString());
            }           
        }

        private void btnToggleCOM_Click(object sender, EventArgs e)
        {
            if (_serialPortMEGA.IsOpen)
            {
                _serialPortMEGA.Close();
                lblSTATUS.Text = string.Format("CLOSED {0} Serial Comm Port.", _serialPortMEGA.PortName);
                textBoxSerialData.AppendText(string.Format("\r\nCLOSED {0} Serial Comm Port.\r\n", _serialPortMEGA.PortName));
            }
            else if (!_serialPortMEGA.IsOpen)
            {
                try
                {
                    _serialPortMEGA.Open();
                    lblSTATUS.Text = string.Format("OPENED {0} Serial Comm Port.", _serialPortMEGA.PortName);
                    textBoxSerialData.AppendText(string.Format("\r\nOPENED {0} Serial Comm Port.\r\n", _serialPortMEGA.PortName));
                }
                catch
                {
                    lblSTATUS.Text = "ERROR TOGGLING COM PORT - Check that valid COM port is chosen.";
                    textBoxSerialData.AppendText("\r\nERROR TOGGLING COM PORT - Check that valid COM port is chosen.\r\n");
                }              
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Clear all text from logging window?", 
                                                        "Clear Logging Window?", 
                                                        MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                textBoxSerialData.Clear();
            }           
        }

        
    }
}
