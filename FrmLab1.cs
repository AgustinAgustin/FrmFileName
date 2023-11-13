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

namespace FrmFileName
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String getInput = txtInput.Text;
            FrmFileName file = new FrmFileName();
            file.ShowDialog();

            string docuPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFIle = new StreamWriter(Path.Combine(docuPath, FrmFileName.setFilename))) {
                outputFIle.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistration ilabasmo = new FrmRegistration();
            ilabasmo.ShowDialog();
        }
    }
}
