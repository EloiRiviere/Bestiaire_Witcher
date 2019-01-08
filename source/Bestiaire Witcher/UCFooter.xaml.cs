using System.Windows.Controls;

namespace Bestiaire_Witcher
{
    /// <summary>
    /// Logique d'interaction pour UCFooter.xaml
    /// </summary>
    public partial class UCFooter : UserControl
    {
        public MainWindow MyMainWindow { get; set; }
        public UCFooter()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
