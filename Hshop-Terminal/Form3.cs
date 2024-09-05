using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hshop_Terminal_v1._0
{
    public partial class Form3 : Form
    {
        private Form1 parentForm;
        public Form3(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameBox.Text.Length == 0)
                {
                    MessageBox.Show("Nhập tên thiết bị");
                    return;
                }
                string appDirectory = Application.StartupPath + "\\devices";
                string nameDevice = nameBox.Text + ".txt";
                string thisPath = Path.Combine(appDirectory, nameDevice);
                if (!File.Exists(thisPath))
                {
                    using (FileStream fs = File.Create(thisPath))
                    {

                    }
                }
                
                using (StreamWriter writer = new StreamWriter(thisPath))
                {
                    writer.Write(noteBox.Text);
                }
                parentForm.setDevicesBox();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
