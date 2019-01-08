using Bestiaire.Monstres;
using Bestiaire.Monstres.Enums;
using Bestiaire.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Bestiaire_Witcher
{
    /// <summary>
    /// Logique d'interaction pour UCContent.xaml
    /// </summary>
    public partial class UCContent : UserControl, INotifyPropertyChanged
    {
        public Dictionary<RacesEnum, List<Enum>> CreaturesByRaceCollection { get; set; }
        public ObservableCollection<Enum> EnumCreaturesList { get; set; }
        public List<Monstre> AllMonstres;
        public ObservableCollection<String> StringRacesMiensList { get; set; }
        public Dictionary<String, List<Monstre>> MonstresCrees { get; set; }

        public UCContent()
        {
            InitializeComponent();
            DataContext = this;

            // Création du Dictionnaire<Enum de Races,List<Enum de Créatures>>
            CreaturesByRaceCollection = ServicesMonstres.GetCreaturesByRaceCollection();

            // Initialisation de l'ObservableCollection de Créatures
            EnumCreaturesList = new ObservableCollection<Enum>();

            // Création de la liste de Monstres
            AllMonstres = InitMonstres.InitListeMonstres();

            // Charge le dictionnaire des monstres créés
            MonstresCrees = (Dictionary<String,List<Monstre>>)SaveLoad.ChargementFichierBinaire("../../../Bestiaire.Services/don/MesMonstre.txt");

            // Charge la liste des races des monstres créés
            StringRacesMiensList = ServicesMonstres.GetStringRacesMiensList(MonstresCrees);
        }

        // Instance du MainWindow
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
                MyMainWindow.CompteurRaces = CreaturesByRaceCollection.Keys.Count();
            }
        }

        // Race séléctionnée
        private RacesEnum selectedRace;
        public RacesEnum SelectedRace
        {
            get { return selectedRace; }
            set
            {
                // Récupère la Race sélectionnée
                selectedRace = value;

                // Vide la liste de créature
                EnumCreaturesList.Clear();


                // Pour chaque créature du Dictionnaire dont la clef est la race sélactionnée, on ajoute la creature à la EnumCreaturesList
                EnumCreaturesList = ServicesMonstres.GetEnumCreatureListWithRace(CreaturesByRaceCollection, SelectedRace);

                // Cache la box de message et montre la liste
                Msg1.Visibility = Visibility.Collapsed;
                ListViewCreature.Visibility = Visibility.Visible;

                //Msg2.Visibility = Visibility.Visible;
                //AffichageCreature.Visibility = Visibility.Collapsed;

                ListViewCreatureMiens.Visibility = Visibility.Collapsed;

                // Compte le nombre de créatures
                MyMainWindow.UCFooter.CompteurCreature.Text = EnumCreaturesList.Count().ToString();

                ListViewCreature.ItemsSource = EnumCreaturesList;

            }
        }

        // Race sélectionnée dans les monstres créés
        private String selectedRaceMiens;
        public String SelectedRaceMiens
        {
            get { return selectedRaceMiens; }
            set
            {
                // Récupère la Race sélectionnée
                selectedRaceMiens = value;

                // Cache la box de message et montre la liste
                Msg1.Visibility = Visibility.Collapsed;
                ListViewCreature.Visibility = Visibility.Collapsed;
                ListViewCreatureMiens.Visibility = Visibility.Visible;

                // Compte le nombre de créatures
                MyMainWindow.UCFooter.CompteurCreature.Text = MonstresCrees.Keys.Count().ToString();

                // Tente d'afficher mes monstres créés correspondant à la race sélectionnée
                try
                {
                    ListViewCreatureMiens.ItemsSource = MonstresCrees[selectedRaceMiens];
                    MyMainWindow.UCFooter.CompteurCreature.Text = MonstresCrees[selectedRaceMiens].Count().ToString();
                }
                // Si aucun monstre de cette race existe, NE DOIS PAS ARRIVER car une clef race est supprimée lorsqu'aucun monstre ne lui correspond
                catch(Exception)
                {
                    ListViewCreatureMiens.Visibility = Visibility.Collapsed;
                    Msg1.Visibility = Visibility.Visible;
                }



            }
        }

        // Enum du monstre sélectionné
        private Enum selectedCreature;
        public Enum SelectedCreature
        {
            get
            {
                return selectedCreature;
            }
            set
            {
                selectedCreature = value;
                // Récupère le monstre dans la liste qui correspond à l'enum selectedCreature
                SelectedMonstre = AllMonstres.SingleOrDefault(monstre => monstre.Creaturetype.Equals(selectedCreature));
            }
        }

        // enum du monstre créé sélectionné
        private String selectedCreatureMienne;
        public String SelectedCreatureMienne
        {
            get
            {
                return selectedCreatureMienne;
            }
            set
            {
                selectedCreatureMienne = value;
                // Récupère le monstre dans la liste qui correspond au string selectedCreatureMienne
                SelectedMonstre = MonstresCrees[SelectedRaceMiens].SingleOrDefault(monstre => monstre.Nom.Equals(selectedCreatureMienne));
            }
        }



        // Montre correspondant à l'enum selectedCreature
        private Monstre selectedMonstre;
        public event PropertyChangedEventHandler PropertyChanged;

        public Monstre SelectedMonstre
        {
            get { return selectedMonstre; }
            set
            {
                selectedMonstre = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedMonstre)));
            }
        }

        /// <summary>
        /// Récupère la sélection à partir du listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ListViewRace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedRace = ((RacesEnum)((ListView)sender).SelectedItem);
        }

        /// <summary>
        /// recupere la selection a partir du listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ListViewRaceMiens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedRaceMiens = ((String)((ListView)sender).SelectedItem);
        }

        /// <summary>
        /// Ouvre la fenêtre du login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login log = new Login
            {
                ResizeMode = ResizeMode.NoResize,
                MyMainWindow = MyMainWindow
            };
            log.Show();
        }

        /// <summary>
        /// Lorsque l'on clique sur Monstres, met à jour les listes et les affichages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Monstres_Click(object sender, RoutedEventArgs e)
        {
            EnumCreaturesList.Clear();
            MyMainWindow.UCFooter.CompteurCreature.Clear();

            RaceMiens.Visibility = Visibility.Collapsed;
            Race.Visibility = Visibility.Visible;

            Msg1.Visibility = Visibility.Visible;
            ListViewCreature.Visibility = Visibility.Collapsed;
            ListViewCreatureMiens.Visibility = Visibility.Collapsed;

            Delete.Visibility = Visibility.Collapsed;

            MyMainWindow.CompteurRaces = MonstresCrees.Keys.Count();
        }

        /// <summary>
        /// Ouvre la fenêtre de la Création
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Creation_Click(object sender, RoutedEventArgs e)
        {
            Creation cre = new Creation
            {
                ResizeMode = ResizeMode.NoResize,
                MyMainWindow = MyMainWindow
            };
            cre.Show();
        }

        /// <summary>
        /// Gère la déconnexion d'un utilisateur, met à jour les listes et le visibilité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            MyMainWindow.IsLogged = false;

            RaceMiens.Visibility = Visibility.Collapsed;
            Race.Visibility = Visibility.Visible;

            Race.ItemsSource = CreaturesByRaceCollection.Keys;

            ListViewCreatureMiens.Visibility = Visibility.Collapsed;
            ListViewCreature.Visibility = Visibility.Collapsed;
            Msg1.Visibility = Visibility.Visible;
        }


        /// <summary>
        /// Lorsque l'on clique sur Mes Monstres, met à jour les listes et les visibilités
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MesMonstres_Click(object sender, RoutedEventArgs e)
        {
            Race.Visibility = Visibility.Collapsed;
            RaceMiens.Visibility = Visibility.Visible;

            Msg1.Visibility = Visibility.Visible;
            ListViewCreature.Visibility = Visibility.Collapsed;
            ListViewCreatureMiens.Visibility = Visibility.Collapsed;

            Delete.Visibility = Visibility.Visible;

            RaceMiens.ItemsSource = MonstresCrees.Keys;
            MyMainWindow.CompteurRaces = MonstresCrees.Keys.Count();
            MyMainWindow.UCFooter.CompteurCreature.Text = "";
        }

        /// <summary>
        /// Gère la suppression d'un monstre, et la sauvegarde permanente des changements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MonstresCrees[selectedRaceMiens].Remove(SelectedMonstre);
            
            if(MonstresCrees[selectedRaceMiens].Count == 0)
            {
                MonstresCrees.Remove(selectedRaceMiens);
            }

            ListViewCreatureMiens.Visibility = Visibility.Collapsed;
            Msg1.Visibility = Visibility.Visible;

            Race.Visibility = Visibility.Collapsed;
            MyMainWindow.UCContent.RaceMiens.ItemsSource = MyMainWindow.UCContent.StringRacesMiensList = ServicesMonstres.GetStringRacesMiensList(MyMainWindow.UCContent.MonstresCrees);
            RaceMiens.Visibility = Visibility.Visible;

            SaveLoad.SauvegardeFichierBinaire("../../../Bestiaire.Services/don/MesMonstre.txt", MonstresCrees);
        }
    }
}
