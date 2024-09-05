using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hshop_Terminal_v1._0
{
    public partial class Form1 : Form
    {
        string curFileOpen = "";
        string fileOpen = "";
        string myPortName = "";
        public Form1()
        {
            InitializeComponent();
            sendBox.KeyPress += sendBox_KeyPress;
            sendBox1.KeyPress += sendBox1_KeyPress;
            sendBox2.KeyPress += sendBox2_KeyPress;
            searchTextBox.KeyPress += searchTextBox_KeyPress;
            serialPort1.DataReceived += SerialPort1_DataReceived;
            serialPort2.DataReceived += SerialPort2_DataReceived;
            serialPort3.DataReceived += SerialPort3_DataReceived;
            
        }
        public void setPathOpenFile(string value)
        {
            fileOpen = value;
        }
        void p1_connect()
        {
            try
            {

                serialPort1.PortName = cComBox.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBaudBox.Text);
                serialPort1.DataBits = Convert.ToInt32(cDataBox.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cParityBox.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cStopBox.Text);
                serialPort1.Encoding = Encoding.UTF8;
                serialPort1.DtrEnable = true;
                serialPort1.Open();
                progressBar1.Value = 100;
                connectBtn.Text = "Disconnect";
                connectBtn.BackColor = Color.Red;
                receiveBox.Text = "";

                myPortName = cComBox.Text;
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void p1_disconnect()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    serialPort1.Dispose();
                    progressBar1.Value = 0;
                    connectBtn.Text = "Connect";
                    connectBtn.BackColor = Color.Green;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                p1_connect();
            }
            else
            {
                p1_disconnect();
            }
        }
        private void DisplaySentData(string data)
        {
            receiveBox.Invoke(new Action(() =>
            {
                receiveBox.SelectionColor = System.Drawing.Color.Red;
                receiveBox.AppendText(data);
            }));
        }
        private void sendBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (serialPort1.IsOpen && e.KeyChar == (char)Keys.Enter)
            {
                if (sendBox.Text.Trim() == "")
                {
                    e.Handled = true;
                    return;
                }
                try
                {
                    if(appendBox.Text == "None")
                    {
                        serialPort1.Write(sendBox.Text);
                        DisplaySentData(sendBox.Text);
                    }
                    else if(appendBox.Text == "CR")
                    {
                        serialPort1.Write(sendBox.Text + "\r");
                        DisplaySentData(sendBox.Text + "\r");
                    }
                    else if (appendBox.Text == "LF")
                    {
                        serialPort1.Write(sendBox.Text + "\n");
                        DisplaySentData(sendBox.Text + "\n");
                    }
                    else
                    {
                        serialPort1.Write(sendBox.Text + "\r\n");
                        DisplaySentData(sendBox.Text + "\r\n");
                    }
                    
                    sendBox.Text = "";
                    e.Handled = true;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    serialPort1.Dispose();
                }
                if (serialPort2.IsOpen)
                {
                    serialPort2.Close();
                    serialPort2.Dispose();
                }
                if (serialPort3.IsOpen)
                {
                    serialPort3.Close();
                    serialPort3.Dispose();
                }
                string appDirectory = Application.StartupPath;
                appDirectory = Path.Combine(appDirectory, "path.txt");
                using (StreamWriter writer = new StreamWriter(appDirectory))
                {
                    if (fileOpen.Length != 0)
                    {
                        writer.Write(fileOpen);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string receivedData = serialPort1.ReadLine();
                Invoke(new Action(() =>
                {
                    receiveBox.AppendText(receivedData);
                }));

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (fileOpen.Length == 0)
                { MessageBox.Show("Vui lòng chọn đường dẫn thư mục.");
                    e.Handled = true;
                    return; }
                string folderName = searchTextBox.Text.Trim();
                if (!string.IsNullOrWhiteSpace(folderName))
                {
                    var directories = Directory.GetDirectories(fileOpen)
                                               .Where(path => Path.GetFileName(path).Contains(folderName))
                                               .ToArray();

                    if (directories.Length > 0)
                    {
                        string result = string.Join(Environment.NewLine, directories);
                        curFileOpen = result;
                        string filePath = Path.Combine(result, "ghi_chu.txt");
                        if (File.Exists(filePath))
                        {
                            try
                            {
                                using (StreamReader sr = new StreamReader(filePath))
                                {
                                    string content = sr.ReadToEnd();
                                    noteBox.Text = "";
                                    noteBox.Text = content;
                                }
                                label1.ForeColor = Color.Green;
                                devicesBox.Text = "";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Đã xảy ra lỗi khi mở tệp: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thư mục.");
                        label1.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên thư mục.");
                }
            }
        }

        private void imagesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string picturePath = Path.Combine(curFileOpen, "images");
                if (System.IO.Directory.Exists(picturePath))
                {
                    Process.Start(picturePath);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thư mục hình ảnh.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string appOpenPath = Path.Combine(curFileOpen, "firmware");
                string batchFilePath = ((String)Application.StartupPath + "\\tool_upload\\Upload_Uno.bat");
                string[] hexFiles = Directory.GetFiles(appOpenPath, "*.hex");
                using (StreamWriter writer = new StreamWriter(batchFilePath))
                    {

                        writer.WriteLine("@echo off");
                        writer.WriteLine("set avrdudePath=" + ((String)Application.StartupPath + "\\tool_upload\\bin\\avrdude.exe") +"\r\n" +
                                         "set programmer=arduino\r\n" +
                                         "set port=" + cComBox.Text +"\r\n" +
                                         "set baudrate=115200\r\n" +
                                         "set hexFile="+ hexFiles[0]);
                    writer.WriteLine("\"%avrdudePath%\" -C \"" + ((String)Application.StartupPath) + "\\tool_upload\\etc\\avrdude.conf\" " +
                                     "-v -patmega328p -c %programmer% -P %port% -b %baudrate% -D -U flash:w:\"%hexFile%\":i" +
                                     "\r\npause");
                    }
                if (System.IO.File.Exists(batchFilePath))
                {
                    Process.Start(batchFilePath);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ứng dụng.");
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string appDirectory = Application.StartupPath;
                string thisPath = Path.Combine(appDirectory, "path.txt");
                string folderPath = Path.Combine(appDirectory, "tool_upload");
                string devicesPath = Path.Combine(appDirectory, "devices");
                if (!File.Exists(thisPath))
                {
                    using (FileStream fs = File.Create(thisPath))
                    {
                       
                    }
                }
                using (StreamReader sr = new StreamReader(thisPath))
                {
                    string content = sr.ReadToEnd();
                    fileOpen = content;
                }
                if (!Directory.Exists(folderPath))
                {
                        Directory.CreateDirectory(folderPath);
                }
                if (!Directory.Exists(devicesPath))
                {
                    Directory.CreateDirectory(devicesPath);
                }
                setDevicesBox();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (curFileOpen != "")
                {
                    string fileNotePath = Path.Combine(curFileOpen, "ghi_chu.txt");
                    using (StreamWriter writer = new StreamWriter(fileNotePath))
                    {
                        writer.Write(noteBox.Text);
                    }
                }
                else
                {
                    string selectedFileName = devicesBox.SelectedItem.ToString();
                    string folderPath = Application.StartupPath + "\\devices";
                    string filePath = Path.Combine(folderPath, selectedFileName + ".txt");
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(noteBox.Text);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            TabPage currentTabPage = tabControl1.SelectedTab;
            if (currentTabPage == tabPage1)
            {
                if (serialPort2.IsOpen && serialPort3.IsOpen)
                    p2_DisConnect();
                receiveBox1.Text = "";
                receiveBox2.Text = "";
            }
            else if (currentTabPage == tabPage2)
            {
                try
                {
                    cBoxBaud1.Text = "9600";
                    cBoxBaud2.Text = "9600";
                    if (serialPort1.IsOpen)
                    {
                        while ((serialPort1.BytesToRead > 0 || serialPort1.BytesToWrite > 0))
                        {
                            Thread.Sleep(10);
                        }
                        serialPort1.Close();
                        serialPort1.Dispose();
                    }
                    progressBar1.Value = 0;
                    receiveBox.Text = "";
                    connectBtn.Text = "Connect";
                    connectBtn.BackColor = Color.Green;
                    string[] ports = SerialPort.GetPortNames();
                    if (ports.Length < 2) { return; }
                    cComBox1.Text = ports[0];
                    cComBox2.Text = ports[1];

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }
        private void p2_DisConnect()
        {
            try
            {
                timer1.Enabled = false;
                while (serialPort2.IsOpen && (serialPort2.BytesToRead > 0 || serialPort2.BytesToWrite > 0) && (serialPort3.BytesToRead > 0 || serialPort3.BytesToWrite > 0))
                {
                    Thread.Sleep(10);

                }
                serialPort2.Close();
                serialPort2.Dispose();
                while (serialPort3.IsOpen && (serialPort3.BytesToRead > 0 || serialPort3.BytesToWrite > 0))
                {
                    Thread.Sleep(10);

                }

                serialPort3.Close();

                serialPort3.Dispose();
                p2Connect.Text = "Connect";
                p2Connect.BackColor = Color.Lime;
                p2CheckConnect = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool p2_Connect()
        {
            try
            {
                if (cComBox1.Text == cComBox2.Text)
                {
                    MessageBox.Show(cComBox1.Text + " đã được chọn");
                    return false;
                }
                receiveBox1.Text = "";
                receiveBox2.Text = "";
                if (!serialPort2.IsOpen)
                {
                    serialPort2.PortName = cComBox1.Text;
                    serialPort2.BaudRate = Convert.ToInt32(cBoxBaud1.Text);
                    serialPort2.DataBits = 8;
                    serialPort2.Parity = Parity.None;
                    serialPort2.StopBits = StopBits.One;
                    serialPort2.Encoding = Encoding.UTF8;

                    serialPort2.Open();
                }

                if (!serialPort3.IsOpen)
                {
                    serialPort3.PortName = cComBox2.Text;
                    serialPort3.BaudRate = Convert.ToInt32(cBoxBaud2.Text);
                    serialPort3.DataBits = 8;
                    serialPort3.Parity = Parity.None;
                    serialPort3.StopBits = StopBits.One;
                    serialPort3.Encoding = Encoding.UTF8;

                    serialPort3.Open();
                }
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool p2CheckConnect = false;
        private void p2Connect_Click(object sender, EventArgs e)
        {

            if (!p2CheckConnect)
            {
                if (p2_Connect())
                {
                    p2Connect.Text = "Disconnect";
                    p2Connect.BackColor = Color.Red;
                    p2CheckConnect = true;
                }
            }
            else
            {
                p2_DisConnect();
                autoSendBtn.Text = "Auto Send";
                autoSendBtn.BackColor = Color.CornflowerBlue;
            }
        }
        private void cComBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                cComBox1.Items.Clear();
                cComBox1.Text = null;
                cComBox1.Items.AddRange(ports);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cComBox2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                cComBox2.Items.Clear();
                cComBox2.Text = null;
                cComBox2.Items.AddRange(ports);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void sendBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (serialPort2.IsOpen && e.KeyChar == (char)Keys.Enter)
                {
                    if (sendBox1.Text.Trim() == "")
                    {
                        e.Handled = true;
                        return;
                    }
                    serialPort2.WriteLine(sendBox1.Text);
                    sendBox1.Text = "";
                    e.Handled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sendBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (serialPort3.IsOpen && e.KeyChar == (char)Keys.Enter)
                {
                    if (sendBox2.Text.Trim() == "")
                    {
                        e.Handled = true;
                        return;
                    }
                    serialPort3.WriteLine(sendBox2.Text);
                    sendBox2.Text = "";
                    e.Handled = true;
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SerialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {

                string receivedData = serialPort2.ReadLine();

                receiveBox1.Invoke(new Action(() =>
                {
                    receiveBox1.SelectionColor = System.Drawing.Color.DarkOrange;
                    receiveBox1.AppendText(receivedData + Environment.NewLine);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhận dữ liệu từ cổng serial: " + ex.Message);
            }
        }

        private void SerialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {

                string receivedData = serialPort3.ReadLine();

                receiveBox2.Invoke(new Action(() =>
                {
                    receiveBox2.SelectionColor = System.Drawing.Color.DarkSlateBlue;
                    receiveBox2.AppendText(receivedData + Environment.NewLine);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhận dữ liệu từ cổng serial: " + ex.Message);
            }
        }

        UInt16 data1;
        UInt16 data2;
        private void autoSendBtn_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                if (!serialPort2.IsOpen && !serialPort3.IsOpen)
                {
                    MessageBox.Show("Chưa kết nối COM");
                    return;
                }
                timer1.Enabled = true;
                data1 = 1;
                data2 = 0;
                autoSendBtn.BackColor = Color.Red;
                autoSendBtn.Text = "Stop Send";
            }
            else
            {
                timer1.Enabled = false;
                autoSendBtn.Text = "Auto Send";
                autoSendBtn.BackColor = Color.CornflowerBlue;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort2.IsOpen && !serialPort3.IsOpen)
            {
                p2_DisConnect();
                return;
            }
            try
            {
                serialPort2.WriteLine(serialPort2.PortName + " gửi: " + data1);
                serialPort3.WriteLine(serialPort3.PortName + " gửi: " + data2);
            }
            catch(Exception err)
            {
                p2_DisConnect();
                MessageBox.Show(err.Message);
            }
            data1 += 2;
            data2 += 2;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            receiveBox1.Text = "";
            receiveBox2.Text = "";
        }
        
        private string[] lines;
        private int currentIndex;

        private void excuteBtn_Click(object sender, EventArgs e)
        {
            string dataSend = noteBox.Text;
            lines = dataSend.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            currentIndex = 0;

            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && currentIndex < lines.Length)
            {
                string line = lines[currentIndex];
                if (line.Trim().StartsWith("//"))
                {
                    currentIndex++;
                    return;
                }
                if (!string.IsNullOrWhiteSpace(line) && !string.IsNullOrEmpty(line))
                {
                    serialPort1.WriteLine(line);
                    DisplaySentData(line);
                    currentIndex++;
                }
            }
            else
            {
                timer2.Stop();
            }
        }

        private void newDeviceBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
        }
        public void setDevicesBox()
        {
            string deviceDirectory = Application.StartupPath + "\\devices";
            string[] listDevices = Directory.GetFiles(deviceDirectory, "*.txt");
            devicesBox.Items.Clear();
            foreach (string device in listDevices)
            {
                devicesBox.Items.Add(Path.GetFileNameWithoutExtension(device));
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string deviceDirectory = Application.StartupPath + "\\devices";
            string device = deviceDirectory + "\\" +devicesBox.Text + ".txt";
            try
            {
                if (File.Exists(device))
                {
                   File.Delete(device);
                    devicesBox.Items.Remove(devicesBox.Text);
                }
                devicesBox.Text = "";
                noteBox.Text = "";
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void devicesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedFileName = devicesBox.SelectedItem.ToString();
                string folderPath = Application.StartupPath + "\\devices";
                string filePath = Path.Combine(folderPath, selectedFileName + ".txt");
                curFileOpen = "";
                searchTextBox.Text = "";
                noteBox.Text = "";
                label1.ForeColor = Color.Black;
                string fileContent = File.ReadAllText(filePath);
                noteBox.Text = fileContent;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            string[] list = new string[cComBox.Items.Count];
            cComBox.Items.CopyTo(list, 0);
            if (!ports.SequenceEqual(list))
            {
                cComBox.Items.Clear();
                if (ports.Length > 0)
                {
                    cComBox.Items.AddRange(ports);
                    cComBox.Text = ports[0];
                }
                else
                {
                    cComBox.Text = "";
                }
                if (!serialPort1.IsOpen)
                {
                    progressBar1.Value = 0;
                    connectBtn.Text = "Connect";
                    connectBtn.BackColor = Color.Green;
                }
            }
        }
    }
}
