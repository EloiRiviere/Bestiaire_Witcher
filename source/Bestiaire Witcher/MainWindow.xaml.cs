using System.ComponentModel;
using System.Windows;

namespace Bestiaire_Witcher
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int compteurRaces;
        private bool isLogged;

        public MainWindow()
        {
            //this.ResizeMode = ResizeMode.NoResize;
            InitializeComponent();
            UCContent.MyMainWindow = this;
            UCFooter.MyMainWindow = this;
            DataContext = this;
            IsLogged=false;
        }


        public int CompteurRaces
        {
            get
            {
                return compteurRaces;
            }

            set
            {
                compteurRaces = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CompteurRaces)));
            }
        }


        /// <summary>
        /// Gère la visibilité en fonction de si l'utilisateur est loggé
        /// </summary>
        public bool IsLogged
        {
            get { return isLogged; }
            set
            {
                isLogged = value;
                if(isLogged)
                {
                    UCContent.Login.Visibility = Visibility.Collapsed;
                    UCContent.Disconnect.Visibility = Visibility.Visible;
                    UCContent.Creation.Visibility = Visibility.Visible;
                    UCContent.MesMonstres.Visibility = Visibility.Visible;
                }
                else
                {
                    UCContent.Login.Visibility = Visibility.Visible;
                    UCContent.Disconnect.Visibility = Visibility.Collapsed;
                    UCContent.Creation.Visibility = Visibility.Collapsed;
                    UCContent.MesMonstres.Visibility = Visibility.Collapsed;
                    UCContent.Delete.Visibility = Visibility.Collapsed;
                }
            }
        }

    }
}
