using System.Windows;
using System.Windows.Controls;

namespace Bestiaire_Witcher
{
    /// <summary>
    /// Logique d'interaction pour UCHeader.xaml
    /// </summary>
    public partial class UCHeader : UserControl
    {
        public UCHeader()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login log = new Login
            {
                ResizeMode = ResizeMode.NoResize
            };
            log.Show();
        }
        
        private void Monstres_Click(object sender, RoutedEventArgs e)
        {
        }
        
    }
}
