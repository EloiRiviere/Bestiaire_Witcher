using Bestiaire.Monstres;
using System;
using System.Collections.Generic;

namespace Bestiaire.Services
{
    /// <summary>
    /// Classe qui gère les connexions et les espionnages
    /// </summary>
    public class ServicesConnexion
    {
        /// <summary>
        /// Méthode qui charge la liste d'identifiants
        /// </summary>
        /// <returns></returns>
        private static Dictionary<string, string> ListeId()
        {
            return ((Dictionary<string, string>)SaveLoad.ChargementFichierBinaire("../../../Bestiaire.Services/don/passwd.txt"));
            
        }

        /// <summary>
        /// Méthode qui gère la connexion d'un utilisateur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passwd"></param>
        /// <returns></returns>
        public static bool Connexion(String id, String passwd)
        {
            Dictionary<string, string> dico = ListeId();
            foreach(string Identifiant in dico.Keys)
            {
                if(Identifiant.Equals(id))
                {
                    if(dico[id].Equals(passwd))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Méthode Espion
        /// </summary>
        /// <param name="id"></param>
        public static void IdSpy(String id)
        {
            Dictionary<String, List<DateTime>> dico = new Dictionary<String, List<DateTime>>();
            try
            {
                dico = (Dictionary<String, List<DateTime>>)SaveLoad.ChargementFichierBinaire("../../../Bestiaire.Services/don/IdSpy.txt");
                if(dico.ContainsKey(id))
                {
                    dico[id].Add(DateTime.Now);
                }
                else
                {
                    dico.Add(id, new List<DateTime> { DateTime.Now });                }
                }
            catch(Exception)
            {
                dico.Add(id, new List<DateTime> { DateTime.Now });
            }
            finally
            {
                SaveLoad.SauvegardeFichierBinaire("../../../Bestiaire.Services/don/IdSpy.txt", dico);
            }
        }
    }
}
