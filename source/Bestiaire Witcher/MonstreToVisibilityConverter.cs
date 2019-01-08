using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Bestiaire_Witcher
{
    /// <summary>
    /// Convertisseur de Visibilité en fonction du selectedMonstre, gère la visibilité entre le message ou la zone d'affichage du détail
    /// Il collapse le message et affiche le détail du monstre lorsqu'un monstre est sélectionné, ou affiche le message si aucun monstre n'est sélectionné
    /// </summary>
    public class MonstreToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(parameter.Equals("Affichage"))
            {
                if (value == null) { return Visibility.Collapsed; }
                else { return Visibility.Visible; }
            }
            else if(parameter.Equals("Message"))
            {
                if (value == null) { return Visibility.Visible; }
                else { return Visibility.Collapsed; }
            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
