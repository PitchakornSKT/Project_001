using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class formInformation : UserControl
    {
        public formInformation()
        {
            InitializeComponent();


            private void button2_Click(object sender, EventArgs e)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV (*.csv) | *.csv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                    string readAllText = File.ReadAllText(openFileDialog.FileName);
                    for (int i = 0; i < readAllLine.Length; i++)
                    {
                        string allDATARAW = readAllLine[i];
                        string[] allDATASplited = allDATARAW.Split(',');
                        this.dataGridView1.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2], allDATASplited[3], allDATASplited[4], allDATASplited[5], allDATASplited[6], allDATASplited[7], allDATASplited[8]);
                    }
                }
            }
        }
    }
}
