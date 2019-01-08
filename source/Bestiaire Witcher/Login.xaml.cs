using Bestiaire.Services;
using System.Windows;

namespace Bestiaire_Witcher
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>

    public partial class Login : Window
    {

        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// myMainWindow contient la référence de l'instance de la MainWindow
        /// </summary>
        private MainWindow myMainWindow;
        public MainWindow MyMainWindow
        {
            get
            {
                return myMainWindow;
            }

            set
            {
                myMainWindow = value;
            }
        }

        /// <summary>
        /// Gère la connexion, vérifie le couple login/mot de passe et permet ou non la connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeConnecter_Click(object sender, RoutedEventArgs e)
        {
            if(ServicesConnexion.Connexion(Id.Text,Passwd.Text))
            {
                ServicesConnexion.IdSpy(Id.Text);
                MyMainWindow.IsLogged = true;
                Close();
            }
            else
            {
                Passwd.Text = "";
                Id.Background = System.Windows.Media.Brushes.DarkRed;
                Passwd.Background = System.Windows.Media.Brushes.DarkRed;
                Error.Visibility = Visibility.Visible;
            }
            
        }
    }
}
