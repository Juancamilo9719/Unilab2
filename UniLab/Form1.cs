using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {


            var usersAndPasswords = new Dictionary<string, string>();
            Enumerable.Range(0, 10).ToList().ForEach((x) => 
            {
                usersAndPasswords.Add($"juancsolano0{x}", $"4116100{x}");
                usersAndPasswords.Add($"calarcon5{x}", $"4116125{x}");
                usersAndPasswords.Add($"lcadena8{x}", $"41161083{x}");

            });

            if (usersAndPasswords.TryGetValue(UserNameTxtB.Text, out string passwrd) && passwrd == PasswordTxtB.Text)
            {
                this.Hide();
                var newMenu = new menu();
                newMenu.Show();

                MessageBox.Show("ahorraste 5 metros cubicos de agua, felicitaciones");

            }
            else 
            { 
                MessageBox.Show("Tu clave o usuario son incorrectos, intenta de nuevo");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    
}
