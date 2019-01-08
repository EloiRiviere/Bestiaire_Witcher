using System;
using System.Collections.Generic;

namespace Bestiaire.Monstres
{
    /// <summary>
    /// Classe des monstres
    /// </summary>
    [Serializable]
    public class Monstre
    {
        // Nom du monstre
        public String Nom { get; set; }
        //Race du monstre
        public String Race { get; set; }
        // Description du monstre
        public String Description { get; set; }
        // Chemin de l'image du monstre
        public String Image { get; set; }
        // Liste des faiblesses du monstre
        public List<String> Faiblesse;
        // Enum correspondant au monstre
        public Enum Creaturetype { get; set; }
        // Booléen indiquant si ce monstre prut être supprimé
        public bool IsDeletable { get; set; }

        /// <summary>
        /// Constructeur de monstres
        /// </summary>
        /// <param name="Race"></param>
        /// <param name="Nom"></param>
        public Monstre(String Race, String Nom)
        {
            if (Race == null || Nom == null)
            {
                throw new Exception("Nom et/ou Race non renseignés.");
            }
            Faiblesse = new List<String>();
            this.Nom = Nom;
            this.Race = Race;
            this.IsDeletable = false;
        }

        /// <summary>
        /// Méthode d'ajout de 0 faiblesses
        /// </summary>
        public void AddFaiblesse() { }

        /// <summary>
        /// Méthode d'ajout d'une faiblesse
        /// </summary>
        /// <param name="faiblesse"></param>
        public void AddFaiblesse(String faiblesse) => Faiblesse.Add(faiblesse);

        /// <summary>
        /// Méthode d'ajout de deux faiblesses
        /// </summary>
        /// <param name="faiblesse1"></param>
        /// <param name="faiblesse2"></param>
        public void AddFaiblesse(String faiblesse1, String faiblesse2) { Faiblesse.Add(faiblesse1); Faiblesse.Add(faiblesse2); }

        /// <summary>
        /// Méthode d'ajout de trois faiblesses
        /// </summary>
        /// <param name="faiblesse1"></param>
        /// <param name="faiblesse2"></param>
        /// <param name="faiblesse3"></param>
        public void AddFaiblesse(String faiblesse1, String faiblesse2, String faiblesse3) { Faiblesse.Add(faiblesse1); Faiblesse.Add(faiblesse2); Faiblesse.Add(faiblesse3); }

        /// <summary>
        /// Méthode d'ajout de quatre faiblesses
        /// </summary>
        /// <param name="faiblesse1"></param>
        /// <param name="faiblesse2"></param>
        /// <param name="faiblesse3"></param>
        /// <param name="faiblesse4"></param>
        public void AddFaiblesse(String faiblesse1, String faiblesse2, String faiblesse3, String faiblesse4) { Faiblesse.Add(faiblesse1); Faiblesse.Add(faiblesse2); Faiblesse.Add(faiblesse3); Faiblesse.Add(faiblesse4); }

        /// <summary>
        /// Méthode d'ajout de cinq faiblesses
        /// </summary>
        /// <param name="faiblesse1"></param>
        /// <param name="faiblesse2"></param>
        /// <param name="faiblesse3"></param>
        /// <param name="faiblesse4"></param>
        /// <param name="faiblesse5"></param>
        public void AddFaiblesse(String faiblesse1, String faiblesse2, String faiblesse3, String faiblesse4, String faiblesse5) { Faiblesse.Add(faiblesse1); Faiblesse.Add(faiblesse2); Faiblesse.Add(faiblesse3); Faiblesse.Add(faiblesse4); Faiblesse.Add(faiblesse5) ; }

        /// <summary>
        /// Méthode d'ajout d'une image
        /// </summary>
        /// <param name="image"></param>
        public void AddImage(String image) => this.Image = image;

        /// <summary>
        /// Méthode d'ajout d'une description
        /// </summary>
        /// <param name="description"></param>
        public void AddDescription(String description) => this.Description = description;

        /// <summary>
        /// Redéfinition du toString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // return string.Format("{0} {1}", nom, race);

            // v2: return $"{Nom} => {Race} => {Description}";

            return $"{Nom}";
        }
        
        /// <summary>
        /// Redéfinition du Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if(obj == null) return false;
            if(this == obj) return true;
            if(typeof(Monstre) !=  obj.GetType()) return false;
            Monstre o = obj as Monstre;
            return (this.Nom.Equals(o.Nom) && this.Race.Equals(o.Race));
        }

        /// <summary>
        /// Redéfinition du HashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            var hashCode = -1049045063;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Race);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Image);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(Faiblesse);
            return hashCode;
        }
    }
}