using System;

namespace Bestiaire.Monstres
{
    /// <summary>
    /// Classe des Items
    /// </summary>
    public class Item
    {
        // label de l'item
        public String Label { get; set; }

        // emplacement de l'image correspondant à l'item
        public String Chemin { get; set; }

        /// <summary>
        /// Constructeur d'item
        /// </summary>
        /// <param name="Label"></param>
        /// <param name="Chemin"></param>
        public Item(String Label, String Chemin)
        {
            this.Label = Label;
            this.Chemin = Chemin;
        }

    }
}
