using Bestiaire.Monstres;
using Bestiaire.Services;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Bestiaire_Witcher
{
    /// <summary>
    /// Logique d'interaction pour Creation.xaml
    /// </summary>
    public partial class Creation : Window
    {
        public Creation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// myMainWindow contient la référence de l'nstance de la MainWindow
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
        /// Méthode de création de monstre
        /// Gestion de la création d'un monstre, empêche la création de 2 monstres identiques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Creer_Click(object sender, RoutedEventArgs e)
        {
            Monstre monstre = new Monstre(Race.Text,Nom.Text);
            monstre.AddDescription(Description.Text);
            monstre.AddImage("../../../Bestiaire Witcher/img/Assets/not_found.jpg");
            monstre.AddFaiblesse("Huile contre les " + monstre.Race);
            monstre.IsDeletable = true;
            MyMainWindow.UCContent.MonstresCrees = (Dictionary<String,List<Monstre>>)SaveLoad.ChargementFichierBinaire("../../../Bestiaire.Services/don/MesMonstre.txt");


            // si la race du monstre existe et que le monstre existe déjà pour cette race, erreur
            if(MyMainWindow.UCContent.MonstresCrees.ContainsKey(monstre.Race) && MyMainWindow.UCContent.MonstresCrees[monstre.Race].Contains(monstre))
            {
                Error.Visibility = Visibility.Visible;
                Nom.Background = Brushes.DarkRed;
            }
            // si il n'existe pas
            else
            {
                // si la race du monstre existe et qu'il n'existe pas, on le crée
                if (MyMainWindow.UCContent.MonstresCrees.ContainsKey(monstre.Race) && !MyMainWindow.UCContent.MonstresCrees[monstre.Race].Contains(monstre))
                {
                    MyMainWindow.UCContent.MonstresCrees[monstre.Race].Add(monstre);
                }
                // sinon on crée une nouvelle paire clef/valeur
                else
                {
                    MyMainWindow.UCContent.MonstresCrees.Add(monstre.Race, new List<Monstre> { monstre });
                }
                SaveLoad.SauvegardeFichierBinaire("../../../Bestiaire.Services/don/MesMonstre.txt", MyMainWindow.UCContent.MonstresCrees);
                MyMainWindow.UCContent.RaceMiens.ItemsSource = MyMainWindow.UCContent.StringRacesMiensList = ServicesMonstres.GetStringRacesMiensList(MyMainWindow.UCContent.MonstresCrees);
                Close();
            }
        }
    }
}
