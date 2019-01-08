using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Bestiaire.Monstres;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bestiaire.Tests
{
    /// <summary>
    /// Classe de tests
    /// </summary>
    [TestClass]
    public class TestChargementSauvegarde
    {
        // Test sauvegarde et chargement dans un fichier binaire
        [TestMethod]
        public void TestSauvegardeChargementBinaire()
        {
            List<Monstre> Liste = InitMonstres.InitListeMonstres();
            foreach (Monstre monstre in Liste)
            {
                Debug.WriteLine(monstre);
            }
            Debug.WriteLine("\nNombre de Monstres: " + Liste.Count());
            SaveLoad.SauvegardeFichierBinaire("../../../Bestiaire.Services/don/test.txt", Liste);
            Debug.WriteLine("\n____________________________________________\n");
            List<Monstre> Liste2 = (List<Monstre>)SaveLoad.ChargementFichierBinaire("../../../Bestiaire.Services/don/test.txt");
            foreach (Monstre monstre in Liste2)
            {
                Debug.WriteLine(monstre);
            }
            Debug.WriteLine("\nNombre de Monstres: " + Liste2.Count());
        }

        // Test qui initialise les utilisateurs auxquels on pourra se connecter
        [TestMethod]
        public void TestLogin()
        {
            Dictionary<string, string> dico = new Dictionary<string, string>
            {
                { "Admin", "admin" },
                { "Login", "motDePasse" }
            };

            Debug.WriteLine("\nDico: " + dico.Count() + " clefs");
            SaveLoad.SauvegardeFichierBinaire("../../../Bestiaire.Services/don/passwd.txt", dico);
        }

        // Test portant sur une méthode non codée
        [TestMethod]
        public void TestChargementSauvegardeBDD()
        {

        }

        // Méthode en cours de codage
        [TestMethod]
        public void FichierBinaireToString()
        {
            String Chemin = "../../../Bestiaire.Services/don/IdSpy.txt";
            using (Stream Tube = File.OpenRead(Chemin))
            {
                try
                {
                    BinaryFormatter Convertisseur = new BinaryFormatter();
                    while (true)
                    {
                        Debug.WriteLine(Convertisseur.Deserialize(Tube));
                    }
                }
                catch(Exception)
                {
                 
                }
            }
        }

        // Méthode d'initialisation du fichier de monstres créés
        [TestMethod]
        public void InitMonstresCrees()
        {
            Dictionary<String, List<Monstre>> dico = new Dictionary<String, List<Monstre>>
            {
                {"Plante", new List<Monstre> { new Monstre("Plante", "Bulbizare"), new Monstre("Plante", "Mystherbe") } },
                {"Feu", new List<Monstre> { new Monstre("Feu", "Salamèche") } }
            };
            SaveLoad.SauvegardeFichierBinaire("../../../Bestiaire.Services/don/MesMonstre.txt", dico);
            foreach(String key in dico.Keys)
            {
                Debug.WriteLine(key);
                foreach(Monstre monstre in dico[key])
                {
                    Debug.WriteLine("\t" + monstre);
                }
            }
            Debug.WriteLine(dico);

        }

        // Méthode espion permettant de visualiser les connexions
        [TestMethod]
        public void SeeIDSpy()
        {
            Dictionary<String,List<DateTime>> dico = new Dictionary<String, List<DateTime>>();
            try
            {
                dico = (Dictionary<String, List<DateTime>>)SaveLoad.ChargementFichierBinaire("../../../Bestiaire.Services/don/IdSpy.txt");
                foreach (String log in dico.Keys)
                {
                    Debug.WriteLine(log);
                    foreach (DateTime date in dico[log])
                    {
                        Debug.WriteLine("\t" + date);
                    }
                }

            }
            catch (Exception)
            {
                Debug.WriteLine("Dictionnaire vide.");
            }
        }

    }
}
