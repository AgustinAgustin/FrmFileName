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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String[] data = {"Student Number: " + txtStudentNumber.Text ,"Full name: " + txtLastName.Text, " " + txtFirstName.Text, " " +txtMiddleName.Text,
            "Program: " +  cbProgram.Text, "Gender: " + cbGender.Text, "Age: " + txtAge.Text, 
            "Birthday: " + dtimePickerBirthday.Text, "Contact Number: " + txtContact.Text
            };
            using (StreamWriter writer = new StreamWriter($"{Path}\\{txtStudentNumber.Text}.txt")){
                foreach (var items in data) { 
                    writer.WriteLine(items);
                } 
                };
        }
    }
}
