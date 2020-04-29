using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UniLab
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Esto es un comentario de test para git 
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LogInBtn_Click(object sender, EventArgs e)
        {


            var usersAndPasswords = new Dictionary<string, string>();
            Enumerable.Range(0, 10).ToList().ForEach((x) =>
            {
                usersAndPasswords.Add($"usuario{x}", $"clave{x}");
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
    }
}
