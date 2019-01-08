using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Data.SqlClient;

namespace Bestiaire.Monstres
{
    /// <summary>
    /// Classe qui gère les chargements et sauvegardes
    /// </summary>
    public class SaveLoad
    {
        /// <summary>
        /// Méthode de sauvegarde d'un objet
        /// </summary>
        /// <param name="Chemin"></param>
        /// <param name="Obj"></param>
        public static void SauvegardeFichierBinaire(String Chemin, Object Obj)
        {
            // Tube.Close(); Tube.Dispose(); effectué par le using, prend en charge les exceptions éventuelles relevées.
            using (Stream Tube = File.Open(Chemin, FileMode.Create))
            { 
                BinaryFormatter ConvertisseurBinaire = new BinaryFormatter();
                ConvertisseurBinaire.Serialize(Tube, Obj);
            }
        }


        /// <summary>
        /// Méthode de chargement d'un objet
        /// </summary>
        /// <param name="Chemin"></param>
        /// <returns></returns>
        public static Object ChargementFichierBinaire(String Chemin)
        {
            using(Stream Tube = File.OpenRead(Chemin))
            {
                BinaryFormatter Convertisseur = new BinaryFormatter();
                Object Obj = Convertisseur.Deserialize(Tube);
                return Obj;
            }
        }


        // Méthodes en cours de codage
        /*
        public static void AjoutStringFichierBinaire(String Chemin, String str)
        {
            String contenu;

            try
            {
                using (Stream Tube = File.OpenRead(Chemin))
                {
                    BinaryFormatter Convertisseur = new BinaryFormatter();
                    contenu = (String)Convertisseur.Deserialize(Tube);
                }

                using (Stream Tube = File.Open(Chemin, FileMode.OpenOrCreate))
                {
                    BinaryFormatter ConvertisseurBinaire = new BinaryFormatter();
                    ConvertisseurBinaire.Serialize(Tube, contenu);
                    ConvertisseurBinaire.Serialize(Tube, str);
                }
            }
            catch(Exception)
            {
                using (Stream Tube = File.Open(Chemin, FileMode.OpenOrCreate))
                {
                    BinaryFormatter ConvertisseurBinaire = new BinaryFormatter();
                    ConvertisseurBinaire.Serialize(Tube, str);
                }
            }
        }

        public void SauvegardeBDD()
        {
            SqlConnection maConnexion = new SqlConnection("Data Source=00.00.00.00; Initial Catalog=BDDName; Integrated Security=False; User Id=IDPropriétaire");
            DbCommand maCommande = new SqlCommand("SELECT * FROM USERS", maConnexion);
            DbDataReader reader = maCommande.ExecuteReader();
            while (reader.Read())
            {

            }
        }
        */
    }
}
