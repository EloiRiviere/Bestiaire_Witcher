using System.ComponentModel;

namespace Bestiaire.Monstres
{
    public enum RacesEnum
    {
        Bêtes,
        Hybrides,
        Maudits,
        Elémentaires,
        Draconides,
        Insectoïdes,
        Nécrophages,
        Orgoïdes,
        Spectres,
        Vampires,
        Vestiges
    }

    public enum BetesEnum
    {
        [Description("Chien")]
        Chien,
        [Description("Loup")]
        Loup,
        [Description("Ours")]
        Ours
    }

    public enum HybridesEnum
    {
        [Description("Erynia")]
        Erynia,
        [Description("Griffon")]
        Griffon,
        [Description("Harpie")]
        Harpie,
        [Description("Mélusine")]
        Mélusine,
        [Description("Salma")]
        Salma,
        [Description("Sirène")]
        Sirène,
        [Description("Succube")]
        Succube
    }

    public enum MauditsEnum
    {
        [Description("Berserker")]
        Berserker,
        [Description("Couvin")]
        Couvin,
        [Description("Loup-Garou")]
        Loup_Garou,
        [Description("Ulfhedinn")]
        Ulfhedinn
    }

    public enum ElementairesEnum
    {
        [Description("Djinn")]
        Djinn,
        [Description("Gargouille")]
        Gargouille,
        [Description("Golem")]
        Golem,
        [Description("Fantôme des rayons")]
        FantomeDesRayons,
        [Description("Molosse de la Chasse Sauvage")]
        MolosseDeLaChasseSauvage,
        [Description("Therazane")]
        Therazane,
        [Description("Elémentaire de feu")]
        ElementaireFeu,
        [Description("Elémentaire de glace")]
        ElementaireGlace,
        [Description("Elémentaire de terre")]
        ElemenyaireTerre
    }

    public enum DraconidesEnum
    {
        [Description("Basilic")]
        Basilic,
        [Description("Cocatrix")]
        Cocatrix,
        [Description("Foënard")]
        Foënard,
        [Description("Hurleur")]
        Hurleur,
        [Description("Dragon de Fyresdal")]
        Dragon_Fyresdal,
        [Description("Wyvern")]
        Wyvern,
        [Description("Wyvern Royale")]
        WyvernRoyale
    }

    public enum InsectoïdesEnum
    {
        [Description("Arachas")]
        Arachas,
        [Description("Arachas Cuirassé")]
        ArachasCuirasse,
        [Description("Arachas Venimeux")]
        ArachasVenimeux,
        [Description("Bourdon Endriague")]
        BourdonEndriague,
        [Description("Endriague Guerrière")]
        EndriagueGuerriere,
        [Description("Endriague Ouvrière")]
        EndriagueOuvriere,
        [Description("Harrisi")]
        Harrisi
    }

    public enum NecrophagesEnum
    {
        [Description("Abaya")]
        Abaya,
        [Description("Algoule")]
        Algoule,
        [Description("Brumelin")]
        Brumelin,
        [Description("Fourbe-veuve")]
        FourbeVeuve,
        [Description("Goule")]
        Goule,
        [Description("Gueunaude Aquatique")]
        GueunaudeAquatique,
        [Description("Gueunaude Sépulcrale")]
        GuenaudeSepulcrale,
        [Description("Ignis Fatuus")]
        IgnisFatuus,
        [Description("Noyeur")]
        Noyeur,
        [Description("Putréfacteur")]
        Putrefacteur
    }

    public enum OrgoïdesEnum
    {
        [Description("Cyclope")]
        Cyclope,
        [Description("Géant de Glace")]
        GéantDeGlace,
        [Description("Hagubman")]
        Hagubman,
        [Description("Nekker")]
        Nekker,
        [Description("Tape-tapeur")]
        TapeTapeur,
        [Description("Troll de Glace")]
        TrollDeGlace,
        [Description("Troll de Pierre")]
        TrollDePierre
    }

    public enum SpectresEnum
    {
        [Description("Blême")]
        Bleme,
        [Description("Démon près du puits")]
        DémonPresDuPuits,
        [Description("La Dame Blanche")]
        LaDameBlanche,
        [Description("La dame des bois")]
        LaDameDesBois,
        [Description("Pénitent")]
        Penitent,
        [Description("Spectre")]
        Spectre,
        [Description("Spectre de midi")]
        SpectreDeMidi,
        [Description("Spectre de minuit")]
        SpectreDeMinuit,
        [Description("Vierge de la peste")]
        Pesta
    }

    public enum VampiresEnum
    {
        [Description("Ekimme")]
        Ekimme,
        [Description("Gaël")]
        Gael,
        [Description("Katakan")]
        Katakan,
        [Description("Sarasti")]
        Sarasti,
        [Description("Vampire Suppérieur")]
        VampireSupperieur
    }

    public enum VestigesEnum
    {
        [Description("Célicole")]
        Célicole,
        [Description("Doppler")]
        Doppler,
        [Description("Esprit de la forêt")]
        EspritDeLaForet,
        [Description("Fiellon")]
        Fiellon,
        [Description("Hurleur")]
        Hurleur,
        [Description("Kernun")]
        Kernun,
        [Description("Leshen")]
        Leshen,
        [Description("Lutin")]
        Lutin,
        [Description("Moire")]
        Moire,
        [Description("Morvudd")]
        Morvudd,
        [Description("Sylvain")]
        Sylvain,
        [Description("Tschart")]
        Tschart
    }

}