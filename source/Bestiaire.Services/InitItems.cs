using System.Collections.Generic;

namespace Bestiaire.Monstres
{
    /// <summary>
    /// Classe de création automatique des items principaux 
    /// </summary>
    public class InitItemcs
    {
        #region Bombes
        /// <summary>
        /// Méthodes de création des Bombes
        /// </summary>

        private static Item Ruche(){return new Item("Ruche", "pack://application:,,,/Bestiaire Witcher;component/img/Bombes/Ruche.png"); }
        private static Item Dimeritium(){return new Item("Bombe au Diméritium", "pack://application:,,,/Bestiaire Witcher;component/img/Bombes/Dimeritium.png"); }
        private static Item Lune() { return new Item("Poudre de Lune", "pack://application:,,,/Bestiaire Witcher;component/img/Bombes/poudre_de_lune.png"); }
        private static Item Vent() { return new Item("Vent du Nord", "pack://application:,,,/Bestiaire Witcher;component/img/Bombes/Vent_du_Nord.png"); }
        private static Item Vesse() { return new Item("Vesse-de-loup du diable", "pack://application:,,,/Bestiaire Witcher;component/img/Bombes/Vesse_de_loup_du_diable.png"); }
        #endregion

        #region Huiles
        /// <summary>
        /// Méthodes de création des Huiles
        /// </summary>
        private static Item Betes() { return new Item("Huile contre les Bêtes", "pack://application:,,,/Bestiaire Witcher;component/img/Huiles/Huiles_Betes.png"); }
        private static Item Draconides() { return new Item("Huile contre les Draconides", "pack://application:,,,/Bestiaire Witcher;component/img/Huiles/Huiles_Draconides.png"); }
        private static Item Elementaires() { return new Item("Huile contre les créatures Elémentaires", "pack://application:,,,/Bestiaire Witcher;component/img/Huiles/Huiles_Elementaires.png"); }
        private static Item Hybrides() { return new Item("Huile contre les créatures Hybrides", "pack://application:,,,/Bestiaire Witcher;component/img/Huiles/Huiles_Hybrides.png"); }
        private static Item Maudits() { return new Item("Huile contre les créarures Maudites", "pack://application:,,,/Bestiaire Witcher;component/img/Huiles/Huiles_Maudits.png"); }
        #endregion

        #region Potions
        /// <summary>
        /// Méthodes de création des Potions
        /// </summary>
        private static Item Loriot() { return new Item("Loriot Doré", "pack://application:,,,/Bestiaire Witcher;component/img/Huiles/Loriot_dore.png"); }
        #endregion

        #region Signes
        /// <summary>
        /// Méthodes de création des Signes
        /// </summary>
        private static Item Aard() { return new Item("Signe d'Aard", "pack://application:,,,/Bestiaire Witcher;component/img/Huiles/Signe_Aard.png"); }
        #endregion

        /// <summary>
        /// Création de la liste des items
        /// </summary>
        /// <returns></returns>
        public static List<Item> InitItems()
        {
            return new List<Item>
            {
                Ruche(),
                Dimeritium(),
                Lune(),
                Vent(),
                Vesse(),

                Betes(),
                Draconides(),
                Elementaires(),
                Hybrides(),
                Maudits(),

                Loriot(),

                Aard()
            };
        }
    }
}
