using Bestiaire.Monstres;
using Bestiaire.Monstres.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bestiaire.Services
{
    /// <summary>
    /// Classe de gestion des monstres
    /// </summary>
    public class ServicesMonstres
    {
        /// <summary>
        /// Méthode d'initialisation du dictionnaire des enums de monstres
        /// </summary>
        /// <returns></returns>
        public static Dictionary<RacesEnum, List<Enum>> GetCreaturesByRaceCollection()
        {
            return new Dictionary<RacesEnum, List<Enum>>
            {
                { RacesEnum.Bêtes, new List<Enum> { BetesEnum.Chien, BetesEnum.Loup, BetesEnum.Ours } },
                { RacesEnum.Draconides, new List<Enum> { DraconidesEnum.Basilic, DraconidesEnum.Cocatrix, DraconidesEnum.Foënard, DraconidesEnum.Hurleur, DraconidesEnum.Wyvern, DraconidesEnum.WyvernRoyale } },
                { RacesEnum.Elémentaires, new List<Enum> {ElementairesEnum.ElementaireFeu, ElementairesEnum.ElementaireGlace, ElementairesEnum.ElemenyaireTerre, ElementairesEnum.FantomeDesRayons, ElementairesEnum.Gargouille, ElementairesEnum.Golem, ElementairesEnum.MolosseDeLaChasseSauvage, ElementairesEnum.Therazane} },
                { RacesEnum.Hybrides, new List<Enum> {HybridesEnum.Erynia, HybridesEnum.Griffon, HybridesEnum.Harpie, HybridesEnum.Mélusine, HybridesEnum.Salma, HybridesEnum.Sirène, HybridesEnum.Succube} },
                { RacesEnum.Insectoïdes, new List<Enum> { InsectoidesEnum.Arachas, InsectoidesEnum.ArachasCuirasse, InsectoidesEnum.BourdonEndriague, InsectoidesEnum.EndriagueGuerriere, InsectoidesEnum.EndriagueOuvriere} },
                { RacesEnum.Maudits, new List<Enum> {MauditsEnum.Berserker, MauditsEnum.Couvin, MauditsEnum.Loup_Garou, MauditsEnum.Ulfhedinn} },
                { RacesEnum.Nécrophages, new List<Enum> {NecrophagesEnum.Abaya, NecrophagesEnum.Algoule, NecrophagesEnum.Brumelin, NecrophagesEnum.FourbeVeuve, NecrophagesEnum.Goule, NecrophagesEnum.GuenaudeSepulcrale, NecrophagesEnum.GueunaudeAquatique, NecrophagesEnum.IgnisFatuus, NecrophagesEnum.Noyeur, NecrophagesEnum.Putrefacteur} },
                { RacesEnum.Orgoïdes, new List<Enum> {OrgoidesEnum.Cyclope, OrgoidesEnum.GéantDeGlace, OrgoidesEnum.Hagubman, OrgoidesEnum.Nekker, OrgoidesEnum.TrollDeGlace, OrgoidesEnum.TrollDePierre} },
                { RacesEnum.Spectres, new List<Enum> {SpectresEnum.DémonPresDuPuits, SpectresEnum.LaDameBlanche, SpectresEnum.LaDameDesBois, SpectresEnum.Penitent, SpectresEnum.Pesta, SpectresEnum.Spectre, SpectresEnum.SpectreDeMidi, SpectresEnum.SpectreDeMinuit} },
                { RacesEnum.Vampires, new List<Enum> {VampiresEnum.Ekimme, VampiresEnum.Gael, VampiresEnum.Katakan, VampiresEnum.Sarasti, VampiresEnum.VampireSupperieur} },
                { RacesEnum.Vestiges, new List<Enum> {VestigesEnum.Célicole, VestigesEnum.Doppler, VestigesEnum.EspritDeLaForet, VestigesEnum.Fiellon, VestigesEnum.Hurleur, VestigesEnum.Kernun, VestigesEnum.Leshen, VestigesEnum.Lutin, VestigesEnum.Moire, VestigesEnum.Sylvain, VestigesEnum.Tschart} }
            };
        }

        /// <summary>
        /// Méthode qui retourne une ObservableCollection d'Enums de monstres correspondants à l'Enum de Race donné
        /// </summary>
        /// <param name="CreaturesByRaceCollection"></param>
        /// <param name="SelectedRace"></param>
        /// <returns></returns>
        public static ObservableCollection<Enum> GetEnumCreatureListWithRace(Dictionary<RacesEnum, List<Enum>> CreaturesByRaceCollection, RacesEnum SelectedRace)
        {
            ObservableCollection<Enum> EnumCreaturesList = new ObservableCollection<Enum>();
            foreach (Enum creature in CreaturesByRaceCollection[SelectedRace])
            {
                EnumCreaturesList.Add(creature);
            }
            return EnumCreaturesList;
        }

        /// <summary>
        /// Méthode qui retourne une ObservableCollection de String de monstres créés correspondants au String de Race donné
        /// </summary>
        /// <param name="MonstresCrees"></param>
        /// <returns></returns>
        public static ObservableCollection<String> GetStringRacesMiensList(Dictionary<String, List<Monstre>> MonstresCrees)
        {
            ObservableCollection<String> StringRacesMiensList = new ObservableCollection<String>();
            foreach (String Race in MonstresCrees.Keys)
            {
                StringRacesMiensList.Add(Race);
            }
            return StringRacesMiensList;
        }
    }
}
