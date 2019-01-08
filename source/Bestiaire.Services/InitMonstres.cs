using Bestiaire.Monstres.Enums;
using System.Collections.Generic;

namespace Bestiaire.Monstres
{
    /// <summary>
    /// Classe de création automatique des Monstres
    /// </summary>
    public class InitMonstres
    {
        #region Bêtes
        private static Monstre Chien()
        {
            Monstre Chien = new Monstre("Bêtes", "Chien");
            Chien.AddDescription("Le chien est le meilleur ami de l'homme, il parraît... mais par les temps qui courent, vaut mieux se méfier de tout le monde, même de ses amis.\n- Alfred Pankratz, mendiant de Novigrad\n\n\"Tel maître, tel chien\", dit la sagesse populaire.Un animal bien traité est fidèle à son maître, tandis qu'un chien battu et houspillé en permanence finit inévitablement par mordre ma main qui le nourrit. Hélas, en ces temps troublés, où les hommes mauvais pospèrent, bon nombre de chiens errants ont perdu tout respect pour l'homme et développé un goût pour le sang et la charogne.\n\nLes chiens attaquent généralement en meute et choisissent de préférence des victimes isolées ou affaiblies, comme des enfants, des ivrognes, des vieillards ou des infirmes.\nCependant, un chien acculé nhésitera pas à vendre chèrement sa peau.");
            Chien.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Betes/Chien.png");
            Chien.AddFaiblesse("Huile contre les bêtes");
            Chien.Creaturetype = BetesEnum.Chien;
            return Chien;
        }

        private static Monstre Loup()
        {
            Monstre Loup = new Monstre("Bêtes", "Loup");
            Loup.AddDescription("Je me disais qu'avec tous les griffons, les basilics, et les je-sais-pas-quoi-encore qui traînent dans la région, je risquais pas d'être embêté par les loups... Ben ça n'a pas empêché ces sales bêtes de boulotter la moitié de mon troupeau !\n- Yngvar, berger\n\nLes loups régnaient jadis en maîtres sur la forêt. Adultes, et enfants tremblaient de peur en entendant leurs hurlements.\nDepuis la Conjonction cependant, les monstres ont non seulement considérablement réduit le territoire des loups, mais ils ont également pris leur place dans les cauchemards des hommes.Pour autant, l'ancien prédateur n'en reste pas moins dangereux.Le loup n'est pas un animal magique, il ne crache ni feu, ni acide, mais il continue néanmoins de tuer les chasseurs et les voyageurs imprudents. Les wargs, une sous - espèce de loup, sont des adversaires particulièrement corriaces, tout comme le loup blanc des terres sauvages de Skellige.\nLes meutes de loups peuvent compter plus d'une douzaine d'individus, bien que certains mâles particulièrement forts chassent en solitaire.Même si le loup est plus faible que la plupart des monstres issus de la Conjonction, il est aussi beaucoup plus intelligent.Face à une meute de loups, il est particulièrement important de ne pas se laisser encercler.Par ailleurs, la présence de loups peut être révélatrice d'un danger plus grand, les loups-garous et leshen rôdant souvent sur le même territoire que ces prédateurs.");
            Loup.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Betes/Loup.png");
            Loup.AddFaiblesse("Huile contre les bêtes");
            Loup.Creaturetype = BetesEnum.Loup;
            return Loup;
        }

        private static Monstre Ours()
        {
            Monstre Ours = new Monstre("Bêtes", "Ours");
            Ours.AddDescription("Ah, l'ours... Le bon gros ours, le nounours placide qui mange du miel toute la journée... C'est des conneries, tout ça. L'ours est un chasseur, un prédateur. L'ours est un tueur.\n- Jahne Oldak, veneur\n\nL'ours est un omnivore, ce qui signifie qu'il mange aussi bien des baies et du saumon que...des hommes.Dans ce dernier cas, il 's'agit généralement d'un voyageur imprudent ou d'un chasseur trop ambitieux.\nLes différentes espèces d'ours (ours noir, ours polaire, ours des cavernes, etc.) sont de couleur, de taille et de force diverses, mais partagent toutes une même caractéristique: une aptitude naturelle à tuer.");
            Ours.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Betes/Ours.png");
            Ours.AddFaiblesse("Huile contre les bêtes", "Signe de Queen");
            Ours.Creaturetype = BetesEnum.Ours;
            return Ours;
        }
        #endregion

        #region Hybrides
        private static Monstre Erynia()
        {
            Monstre Erynia = new Monstre("Hybrides", "Erynia");
            Erynia.AddDescription("Un marchand m'a un jour traitée d'erynia. Naturellement, je l'ai immédiatement téléporté dans un de leurs nids afin qu'il puisse constater par lui-même l'absurdité de sa comparaison.\n- Lytta Neyd alias Corail, magicienne\n\nAussi surprenant que cela puisse parraître, l'erynia de Skellige est encore plus repoussante et dangereuse que sa cousine la harpie. Bien qu'elle apprécie tout particulièrement la charogne bien faisandée, elle ne dédaigne pas la chair humaine fraîche lorsque l'occasion se présente.\n\nA l'instar des harpies et des chichigas, les erynias misent sur le poids du nombre et sur leur maîtrise des airs pour fondre sur leur proie. Elles tournoient dans le ciel et attaquent de plusieurs directions simultanément en visant en priorité la jugulaire, les yeux et les organes vitaux pour saigner à blanc leur malheureuse victime.\n\nUn petit vol d'erynias peut ainsi venir à bout d'une créature certes plus grande et plus forte, mais mal préparée à affronter une nuée d'adversaires.");
            Erynia.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Hybrides/Erynia.png");
            Erynia.AddFaiblesse("Ruche", "Huile contre les Hybrides", "Signe d'Aard");
            Erynia.Creaturetype = HybridesEnum.Erynia;
            return Erynia;
        }

        private static Monstre Griffon()
        {
            Monstre Griffon = new Monstre("Hybrides", "Griffon");
            Griffon.AddDescription("\"Je vous jure, c'était une bête mi-aigle, mi-chat, comme sur le blason du seigneur. Sauf que celle-ci portait pas un sceptre, mais une de mes vaches.\"\n- Témoin anonyme d'une attaque de griffon\n\nLe griffon était autrefois confiné aux zones montagneuses, où il se nourrissait de marmottes et de chèvres sauvages.Il a cependant trouvé sur les terres habitées par les humains une abondance de proies faciles: vaches, moutons...voire bergers à l'occasion. Cette créature mi-aigle, mi-félin est ainsi devenue en quelques années l'un des pires fléaux des royaumes du Nord.Le griffon royal et l'archigriffon, deux sous-espèces plus redoutables encore, sont la hantise des paysans.");
            Griffon.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Hybrides/Griffon.png");
            Griffon.AddFaiblesse("Ruche", "Huile contre les Hybrides", "Signe d'Aard");
            Griffon.Creaturetype = HybridesEnum.Griffon;
            return Griffon;
        }

        private static Monstre Harpie()
        {
            Monstre Harpie = new Monstre("Hybrides", "Harpie");
            Harpie.AddDescription("En général, les monstres ne s'intéressent pas aux richesses humaines, mais pour une harpie, toue ce qui brille est d'or.\n- Letho, sorceleur de l'Ecole de la Vipère\n\nNon contente d'être d'une laideur repoussante, la harpie(tout comme sa cousine la chichiga) dégage une odeur pestinentielle, savoureux mélange de pourriture et d'excréments. Même les rats, pourtant habitués à vivre parmi la matière fécale et les détritus, évitent soigneusement les nids de harpie.\n\nLes harpies installent le plus souvent leur nid sur les hauteurs, au sommet d'une falaise ou d'un ravin rocailleux par exemple.\nCadavres d'humains ou d'animaux, plumes sur le sol et longues traînées de fiente sont autant de signes révélateurs de la présence de harpies.\n\nHarpies et chichigas vivent en groupe pouvant compter jusqu'à une vingtaine d'individue.Plutôt craintives par nature, elles défendent cependant férocement leur nid en attaquant sans hésiter si elles sont en supériorité numérique.\n\nAu combat, elles plongent sur leur adversaire pour lui porter un coup de griffe ou de bec avant de s'envoler hors de portée.\nSi elles sont redoutables dans les airs, les harpies sont en revanche lentes et maladroites au sol.");
            Harpie.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Hybrides/Harpie.png");
            Harpie.AddFaiblesse("Ruche", "Huile contre les Hybrides", "Signe d'Aard");
            Harpie.Creaturetype = HybridesEnum.Harpie;
            return Harpie;
        }

        private static Monstre Melusine()
        {
            Monstre Melusine = new Monstre("Hybrides", "Mélusine");
            Melusine.AddDescription("J'ai vu... une ombre... Da grandes ailes, comme une nuage qui passe dans le ciel. Ensuite, j'ai entendu crier.\n- Britt de Svorlag\n\nUn vaste réseau de cavernes s'étend sour les montagnes de Skellige, près du village de Svorlag. Depuis des générations, les villageois évitaient ces cavernes comme la peste, sachant qu'elles abritaient une échidna sanguinaire du nom de Mélusine.\n\nCette terrifiante créature avait autrefois fait l'objet d'un culte.\n\nLe sorceleur avisé n'était néanmoins pas dupe. Il avait affaire à un monstre tout de même. Une créature qu'il avait été formé à exterminer.Pour ce faire, il lui faudrait recourrir à des carreaux de la meilleure facture qui soit, à sa fidèle épée en argent, et se fier à sa dextérité inée.");
            Melusine.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Hybrides/Melusine.png");
            Melusine.AddFaiblesse("Ruche", "Huile contre les Hybrides", "Signe d'Igni", "Signe d'Aard");
            Melusine.Creaturetype = HybridesEnum.Mélusine;
            return Melusine;
        }

        private static Monstre Salma()
        {
            Monstre Salma = new Monstre("Hybrides", "Salma");
            Salma.AddDescription("Je n'ai pas l'habitude de mentir, ni de tuer sans raison.\n- Salma, succube\n\nEn enquêtant, le sorceleur découvrit qu'une succube appelée Salma était responsable d'une série de meurtres dont était victime la garde municipale de Novigrad.Ce fut pour lui une véritable surprise, car les succubes n'ont pas pour habitude de tuer de sang-froid ou avec préméditation. Elles n'en restent pas moins des créatures dangereuses qui tuent parfois par accident, sous le coup d'une extase particulièrement puissante, ou simplement pour se défendre. Bien qu'elles ressemblent à de frêles jeunes filles au - dessus de la taille, elles possèdent des membres souples qui cachent une force incroyable.Elles sont de plus invulnérables au feu, et donc au signe d'Igni. Une succube présente pour un sorceleur un dilemme délicat: cette créature à la fois pacifique et mortelle mérite-t-elle la mort ou la pitié ?\n\nTelle est la question à laquelle Geralt de Riv dut répondre.Au final, le sorceleur décida de croire Salma et lui laissa la vie sauve...sans toutefois pouvoir de défaire de l'impression qu'un jour u l'autre, il regretterait sa décision.");
            Salma.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Hybrides/Salma.png");
            Salma.AddFaiblesse("Huile contre les Hybrides", "Signe de Queen");
            Salma.Creaturetype = HybridesEnum.Salma;
            return Salma;
        }

        private static Monstre Sirene()
        {
            Monstre Sirene = new Monstre("Hybrides", "Sirène");
            Sirene.AddDescription("Une fois en mer, si tu entends une douce voix de femme portée par le vent, change de cap immédiatement. Immédiatement, tu comprends ? Même si tu dois faire voile sur une tempête, change de cap.\n- Arike d'Hindarsfjall, conseil donné à son fils avant son premier voyage en mer\n\nTel un chasseur se servant d'un appeau pour attirer sa proie, la sirène et la lamie utilisent leur corps pour piéger leurs malheureuses victimes. Elles peuvent toutes deux se métamorphoser en magnifiques jeunes femmes dotées d'une queue de poisson argentée à la place des jambes.Un marin assez naïf pour les approcher ne tarde cependant pas à découvrir leur vraie nature: leur bouche pulpeuse devient ne mâchoire garnie de crocs pointus, tandis que leur douce étreinte se transforme en un mortel étau.\n\nD'après la légende, sirènes et lamies étaient autrefois bienveillantes envers les hommes et s'accouplaient même parfois avec certains marins.Aujourd'hui cependant, leur animosité ne fait aucun doute et il est plus prudent de les attaquer à vue.\n\nLes sirènes et les lamies(leurs dangereuses cousines) chassent en bancs et sont capables de se déplacer sans efforts dans l'eau comme dans les airs.\n\nElles sont cependant sans défence au sol, c'est pourquoi il est recommandé de viser en priorité leurs ailes membraneuses afin de les contraindre à se poser. Elles sont par ailleurs sensibles au signe d'Igni.Attention cependant, car une sirène menacée peut pousser un cri strident qui étourdit ses adversaires, les laissant à la merci de ses soeurs.");
            Sirene.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Hybrides/Sirene.png");
            Sirene.AddFaiblesse("Ruche", "Huile contre les Hybrides", "Signe d'Igni", "Signe d'Aard");
            Sirene.Creaturetype = HybridesEnum.Sirène;
            return Sirene;
        }

        private static Monstre Succube()
        {
            Monstre Succube = new Monstre("Hybrides", "Succube");
            Succube.AddDescription("Encore ?! Madame, je vous assure, je suis épuisé !\n- Lester de Smallton à une succube, quelques jours avant de faire voeu de chasteté\n\nContrairement aux autres monstres, les succubes et les ménades n'éprouent aucune animosité envers les humains.\n\nElles sont en fait animées par une unique motivation; un insatiable désir sexuel, qui les pousse à chercher l'accouplement avec tout individu humanoïde qu'elles rencontrent. Aussi doux soit le danger représenté par ces créatures, il n'en est pas moins bien réel : leur insatiable appétit sexuel a poussé plus d'une malheureuse \"victime\" vers la mort ou a folie.\n\nLes succubes et les ménades vivent généralement à proximité des installations humaines, villes et villages en particulier.\n\nCréatures nocturnes, elles peuvent néanmoins sortir au grand jour si leur désir se fait trop pressant.Elles prodiguent leur amour à la première personne venue, sans considération pour le sexe, l'âge ou l'apparence physique. Par goût du jeu, certaines succubes ciblent de préférence les hommes d'église.\n\nBien que pacifique, une succube n'en est pas moins capable de se défendre. Ses bras menus dissimulent une force peu commune et elle peut aisément briser des os d'un coup de corne ou de sabot.");
            Succube.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Hybrides/Succube.png");
            Succube.AddFaiblesse("Huile contre les Hybrides", "Signe de Queen");
            Succube.Creaturetype = HybridesEnum.Succube;
            return Succube;
        }


        #endregion

        #region Maudits
        private static Monstre Berserker()
        {
            Monstre Berserker = new Monstre("Maudits", "Berserker");
            Berserker.AddDescription("Finis ta soupe, sinon un berserker viendra te manger cette nuit !\n- Réprimande typique de Skellige.\n\nCréature du folkore de Skellige, le berserker serait un homme qui, à la faveur des combats, se transformerait en ours assoiffé de sang, soif qu'il doit étancher pour reprendre forme humaine. Bien que les habitants de Skellige n'accordent que peu de crédit à la légende, elle perdure encore à ce jour dans les chaumières.Le berserker, s'il n'est pas le fruit d'une imagination collective embrumée par l'hydromel, a sans doute appris au fil des siècles à masquer son existence.\n\nLes ballades des skaldes sont riches en informations, aussi peu fiables soient - elles, sur cette créature.Un berserker métamorphosé serait ainsi presque impossile à distinguer d'un ours véritable. Seuls d'infimes détails anatomiques, comme la forme des dents et de la langue, permettraiet de l'identifier. Sous sa forme d'ours, il est décrit comme insensible à la douleur et capable de soigner instantanément les pires blessures.\nS'il existe vraiment, on peut supposer que le berserker, comme le loup-garou et le lycantrope, est vulnérable aux huiles contre les créatures maudites. Cependant, si l'on se fie aux récits contant les atrocités et les massacres commis par les berserker au fil des siècles, il vaut mieux espérer qu'aucun sorceleur n'ait jamais à vérifier la validité de cette hypothèse.");
            Berserker.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Maudits/Berserker.png");
            Berserker.AddFaiblesse("Vesse de loup du diable", "Huile contre les créatures Maudites", "Signe de Queen", "Signe d'Igni");
            Berserker.Creaturetype = MauditsEnum.Berserker;
            return Berserker;
        }

        private static Monstre Couvin()
        {
            Monstre Couvin = new Monstre("Maudits", "Couvin");
            Couvin.AddDescription("Dire qu'un couvin est moche, c'est comme dire que la merde n'a pas très bon gout: ce n'est pas totalement faux, mais ça reste assez loin de la vérité.\n- Lambert, sorceleur de l'Ecole du Loup.\n\nLe couvin est sans doute la créature la plus repoussante qu'un sorceleur puisse croiser au cours de ses voyages. Formé à partir du cadavre d'un bébé enterré sans cérémonie, il ressemble à un foetus en décomposition aux traits déformés par la haine, la peur et la malice.Ce monstre hideux se nourrit du sang des femmes enceintes, malheureuses victimes de sa faim dévorante.\n\nLe couvin sort de son antre à la tombée de la nuit pour rôder autour du chevet d'une future mère, dont il draîne la force vitale ainsi que celle de son enfant. La pauvre femme, assaillie de cauchemards, est rapidement plongée dans un délire fiévreux. Au bout de quelques nuits de ce traitement, elle est trop faible pour se défendre, laissant au couvin le champ libre pour planter ses crocs acérés dans sa chair et la vider de son sang jusqu'à ce que mort s'ensuive.\n\nHaut d'environ 50 centimètres, le couvin peut cependant changer de forme une fois gorgé de sang. Face au danger, il se transforme alors en une créature humanoïde difforme et bossue s'appuyant sur de longs bras décharnés.Sa force est alors décuplée et ses griffes peuvent infloger de douloureuses blessures.\n\nIl est possible de lever la malédiction qui pèse sur un couvin.Il devient alors un sommeillard, esprit protecteur veillant sur la famille qu'il n'a jamais connue et le foyer où il aurait dû naître.");
            Couvin.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Maudits/Couvin.png");
            Couvin.AddFaiblesse("Huile contre les créatures Maudites", "Signe de Queen");
            Couvin.Creaturetype = MauditsEnum.Couvin;
            return Couvin;
        }

        private static Monstre LoupGarou()
        {
            Monstre LoupGarou = new Monstre("Maudits", "Loup-Garou");
            LoupGarou.AddDescription("Au fond, les loups ne sont pas de mauvaises bêtes. Les loups-garous, en revanche, c'est une autre histoire...\n- Elsa Vilge, archère\n\nLe loup-garou est à la croisée des chemins entre l'homme et le loup. Sous sa forme bestiale, il emprunte à chaque race ses pires caractéristiques: l'appétit de chair fraîche et l'instinct de prédateur du loup d'une part, la cruauté et l'intelligence calculatrice de l'homme d'autre part. Créature maudite, le loup-garou n'exerce aucun contrôle sur ses tranformations.\nLorsqu'il reprend forme humaine, il ne conserve aucun souvenir de ses actes, sans quoi il perdrait certainement la raison ou mettrait fin à ses jours.\n\nNocturne par nature, le loup - garou est particulièrement actif par les nuits de pleine lune.Bien qu'il préfère chasser seul, il n'hésite pas à faire appel à ses congénères en cas de danger.Il éprouve rarement le besoin de fuir un combat, sachant que peu d'adversaires sont capables de résister à sa fureur. Ses griffes et ses crocs sont tranchants comme des rasoirs et il peut récupérer des pires blessures en l'espace d'un instant. Pour vaincre un loup-garou, il est impératif d'utiliser une lame enduite d'huile contre les créatures maudites ou de disposer d'un stock conséquent de vesses-de-loup du diable.\n\nIl n'existe pas de méthode sûre pour lever la malédiction d'un loup garou.Chaque cas est unique.Pour accomplir une telle tâche, une bonne dose de patience et une solide armure seront les meilleures alliées du sorceleur.");
            LoupGarou.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Maudits/Loup_Garou.png");
            LoupGarou.AddFaiblesse("Poussière de lune", "Vesse-de-loup du diable", "Huile contre les créatures Maudites", "Signe d'Igni");
            LoupGarou.Creaturetype = MauditsEnum.Loup_Garou;
            return LoupGarou;
        }

        private static Monstre Ulfhedinn()
        {
            Monstre Ulfhedinn = new Monstre("Maudts", "Ulfhedinn");
            Ulfhedinn.AddDescription("Un ulfhedinn ? Jamais entendu parler... C'est une sorte de poisson ?\n- Professeur Artibus Joannes Rack, géographe porté disparu au cours d'une expédition sur Skellige\n\nL'ulfhedinn est une espèce de loup-garou originaire de Skellige. Sans doute en raison des rudes conditions de vie sur les îles, il est plus fort que ses congénères du continent et chasse principalement des hommes. Les ulfhedinns les plus anciens, les vorefs, sont des monstres terriblement dangereux. Dans toute l'histoire de Skellige, seuls quelques rares guerriers ont réussi à vaincre un ulfhedinn et leurs exploits sont aujourd'hui chantés par les skaldes.\n\nTout comme le loup-garou, l'ulfhedinn (ainsi que le voref) est actif la nuit, surtout en période de pleine lune. Rapide, puissant et extraordinairement robuste, c'est un tueur - né contre qui la plupart des armes sont ineffcaces.Seules les lames d'argent et les vesses-de-loup du diable peuvent lui infliger des blessures sérieuses. Pire encore, un ulfhedinn proche de la mort attaque avec une ardeur redoublée et peut même appeler une meute de loups à son secours.");
            Ulfhedinn.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Maudits/Ulfhedinn.png");
            Ulfhedinn.AddFaiblesse("Poussière de lune", "Vesse-de-loup du diable", "Huile contre les créatures Mausites", "Signe d'Igni");
            Ulfhedinn.Creaturetype = MauditsEnum.Ulfhedinn;
            return Ulfhedinn;
        }
        #endregion

        #region Elémentaires
        private static Monstre Djinn()
        {
            Monstre Djinn = new Monstre("Elémentaire", "Djinn");
            Djinn.AddDescription("Un nuage de fumée rouge s'échappa de la jarre, puis vint former une sphère irrégulière devant le visage du poète...\n- L'histoire extraordinaire du premier désir\n\nUn djinn est un esprit de l'air particulièrement puissant, un concentré d'énergie magique doué d'une conscience et d'une personnalité...souvent pernicieuse.D'après la légende, un djinn est capable d'exaucer des souhaits les plus fous, bien qu'il le fasse généralement de mauvaise grâce.\n\nSeul un mage d'exception peut capturer et dompter cette terrifiante créature. Il peut alors canaliser son énergie pour lancer des sorts sans recourir aux sources traditionnelles.\n\nNéanmoins, il s'agit là d'un exploit rarissime, car un djinn fera tout pour échapper à un tel sort.Pour emprisonner un djinn et le soumettre à sa volonté, il faut tout d'abord l'affaiblir, tâche délicate s'il en est.\n\nPeu de monstres sont aussi dangereux qu'un djinn: capable de lancer des sorts d'une puissance extraordinaire, il peut également manipuler les éléments pour invoquer orages, ouragans et autres tempêtes.Il est de plus, comme toutes les autres créatures d'origine magique, invulnérable aux armes en acier... mais fort heureusement sensible aux lames d'argent.");
            Djinn.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Elementaires/Djinn.png");
            Djinn.AddFaiblesse("Bombe au diméritium", "Huile contre les créatures Elémentaires");
            Djinn.Creaturetype = ElementairesEnum.Djinn;
            return Djinn;
        }

        private static Monstre Gargouille()
        {
            Monstre Gargouille = new Monstre("Elémentaires", "Gargouille");
            Gargouille.AddDescription("Je rêve où cette gargouille nous reluque ?\n- Lara Estevann, cambrioleuse de Loc Muine\n\nUne gargouille est une statue de pierre animée par magie, généralement conçue pour protéger le repaire ou le laboratoire d'un mage et dont la simple vue suffit à emplir d'effroi le coeur de la plupart des intrus.Ceux qui parviennent à surmonter leur terreur regrettent bien vite leur bravoire inconsidérée...quelques secondes avat de trouver la mort.");
            Gargouille.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Elementaires/Gargouille.png");
            Gargouille.AddFaiblesse("Bombe au diméritium", "Huile contre les créatures Elémentaires", "Signe de Queen");
            Gargouille.Creaturetype = ElementairesEnum.Gargouille;
            return Gargouille;
        }

        private static Monstre Golem()
        {
            Monstre Golem = new Monstre("Elémentaires", "Golem");
            Golem.AddDescription("Pour ouvrir une brèche dans cette muraille, il nous faudrait une vingtaine de sapeurs, une dizaines de mules et un quintal de salpêtre. Ou un golem.\n- Vilmir Brass, contremaître au Mont Terrim\n\nLe golem est un être créé magiquement à partir de matière inerte.Son obéissance aveugle, sa force inouïe et son insensibilité à la douleur font de lui un serviteur ou un garde idéal.Absolument infatigable, il se battra jusqu'à avoir écrasé tous ses adversaires ou jusqu'à tomber lui - même en poussière.\n\nIl est presque impossible de vaincre un golem: il ne saigne pas, il ne craint ni le feu, ni le poison et ne connaît pas plus la peur que la pitié.Pis encore, son corps est dur comme la roche, au point que même une lame d'argent n'a guère d'effet sur lui. L'acide est son unique faiblesse: seule une lame ointe d'une huile caustique peut lui infliger des blessures.\n\nUn golem n'utilise pas d'arme, et pour cause: ses poings sont de pesantes massues capables de réduire en poudre un bloc de granit pur.Nul bouclier ne peut arrêter le poing d'un golem, nulle épée ne peut le dévier. La seule parade, le seul espoir de survie, consiste à esquiver ses coups, une tâche plus complexe qu'il n'y parraît, un golem étant capable de se déplacer à une vitesse surprenante. Heureusement, sa masse est telle qu'une fois lancé, il ne peut s'arrêter rapidement. Un sorceleur expérimenté saura tirer profit de ce manque de dextérité.");
            Golem.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Elementaires/Golem.png");
            Golem.AddFaiblesse("Bombe au diméritium", "Huile contre les créatures Elémentaires");
            Golem.Creaturetype = ElementairesEnum.Golem;
            return Golem;
        }

        private static Monstre FantomeRayons()
        {
            Monstre FantomeRayons = new Monstre("Elémentaires", "Le Fantôme des Rayons");
            FantomeRayons.AddDescription("Quelque chose a détruit nos ruches. Selon nous, c'est l'oeuvre du... fantôme des rayons.\n- Holofernus Meiersdorf\n\nLe soi-disant \"fantôme des rayons\" qui ravageait le rucher de la famille Meiersdorf était en réalité un molosse égaré de la Chasse Sauvage.Lors d'une rencontre avec une bête de cet acabit, il convient de se souvenir de trois choses.\nPremièrement, seuls les coups les plus puissants parviendront à pénétrer l'épaisse armure de glace qui la recouvre.\nDeuxièmement, à l'instar des autres créatures issues du froid, elle est vulnérable au feu, y compris au signe d'Igni.Et troisièmement, ce monstre ne connaît aucune pitié.\n\nLe molosse se défendit farouchement, mais finit quand même par tomber sous les coups de lame du sorceleur.En tuant ce monstre dangereux, Geralt sauva les humains, les halfelins et, il ne faut pas l'oublier, les abeilles menacées de la région.");
            FantomeRayons.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Elementaires/Fantome_des_rayons.png");
            FantomeRayons.AddFaiblesse("Bombe au diméritium", "Huile contre les créatures Elémentaires", "Signe d'Igni", "Signe d'Aard");
            FantomeRayons.Creaturetype = ElementairesEnum.FantomeDesRayons;
            return FantomeRayons;
        }

        private static Monstre Molosse()
        {
            Monstre Molosse = new Monstre("Elémentaires", "Molosse de la Chasse Sauvage");
            Molosse.AddDescription("Dans le sillage de la Chasse Sauvage hurlent les molosses, bêtes cruelles et sauvages. D'anciennes légendes murmurent avec effroi qu'il descendent parfois du ciel nocturne pour s'abattre sur la terre comme une funeste comète, ne laissant derrière eux que ruine et désolation.\n- Essi \"Petit-Oeil\" Daven, barde\nNé de l'avis des experts, d'un cristal de glace magique, le molosse de la Chasse Sauvage est le fidèle serviteur de ses maîtres spectraux.Créature féroce et carnassière, le molosse attaque sans réfléchir tout ce qui se dresse sur son chemin.");
            Molosse.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Elementaires/Molosse.png");
            Molosse.AddFaiblesse("Bombe au diméritium", "Huile contre les créatures Elémentaires", "Signe d'Igni", "Signe d'Aard");
            Molosse.Creaturetype = ElementairesEnum.MolosseDeLaChasseSauvage;
            return Molosse;
        }

        private static Monstre Therazane()
        {
            Monstre Therazane = new Monstre("Elémentaire", "Therazane");
            Therazane.AddDescription("Autant vous le dire, je ne crois pas aux fantômes... mais mes hommes disent que la maison tremble la nuit, que les murs s'effritent et que le plancher se soulève.\n- Kurt Dysart, compte d'Anchor\n\nEn immobilier, l'investissement sûr n'existe pas.Infiltration, moisissure, vice caché...Tel sont les risques du métier.Il est en revanche plus rare de découvrir sous les fondations de sa maison des ruines elfes abritant un gigantesque élémentaire de terre prêt à saisir la moindre chance de brises ses chaînes.\n\nAffronter pareille créature n'est pas une mince affaire. Son épaisse carapace dévie les coups les plus faibles. D'un coup d'un seul, elle est capable de broyer les os d'un homme, c'est pourquoi il est primordial que le sorceleur garde ses distances lorsqu'il lance le signe de Queen.Il est également recommandé de se tenir prêt à utiliser le signe d'Yrden. Les signes d'Igni, Aard et Axii en revanche, resteront sans effet contre l'élémentaire.\n\nFinalement, le sorceleur triompha du puissant élémentaire de terre et gagna ainsi la gratitude du compte Dysart, ainsi qu'une récompense.");
            Therazane.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Elementaires/Therazane.png");
            Therazane.AddFaiblesse("Bombe au diméritium", "Huile contre les créatures Elémentaires");
            Therazane.Creaturetype = ElementairesEnum.Therazane;
            return Therazane;
        }

        private static Monstre ElementaireFeu()
        {
            Monstre ElementaireFeu = new Monstre("Elémentaire", "Elémentaire de Feu");
            ElementaireFeu.AddDescription("Le premier élémentaire de feu fut créé par Ransant Alvaro. Hélas, l'illustre érudit périt le jour même dans l'incendie qui détruisit son laboratoire... et tous les bâtiments attenants.\n- Tarvix Sandoval, \"Des origines de l'énergie magique\"\n\nElément de la destruction par excellence, le feu engendre tout naturellement des créatures à son image.Un élémentaire de feu est forgé dans les flammes à l'aide de rituels magiques complexes dans un seul et unique but: l'anéantissement.Un but qu'il poursuit, dès sa création, avec une implacable détermination.");
            ElementaireFeu.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Elementaires/Elementaire_feu.png");
            ElementaireFeu.AddFaiblesse("Bonbe au diméritium", "Vent du Nord", "Huile contre les créatures Elémentaires", "Signe d'Aard");
            ElementaireFeu.Creaturetype = ElementairesEnum.ElementaireFeu;
            return ElementaireFeu;
        }

        private static Monstre ElementaireGlace()
        {
            Monstre ElementaireGlace = new Monstre("Elémentaire", "Elémentaire de Glace");
            ElementaireGlace.AddDescription("Je me demandais ce qu'un gros tas de glace venait faire au milieu de la pièce... quand le tas de glace s'est levé et m'a brisé les deux jambes.\n- Yannick Lovt, cambrioleur\n\nUn élémentaire de glace est une masse d'eau glacée animée par magie. Sans conscience ni volonté propres, l'élémentaire obéit aveuglément à son créateur, qui lui assigne généralement une tâche élémentaire: tuer.");
            ElementaireGlace.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Elementaires/Elementaire_glace.png");
            ElementaireGlace.AddFaiblesse("");
            ElementaireGlace.Creaturetype = ElementairesEnum.ElementaireGlace;
            return ElementaireGlace;
        }

        private static Monstre ElementaireTerre()
        {
            Monstre ElementaireTerre = new Monstre("Elémentaire", "Elémentaire de Terre");
            ElementaireTerre.AddDescription("Survivre à une rencontre avec un élémentaire de terre ? C'est très simple. Il suffit de courrir. Vite, de préférence.\n- Nino Murk, chasseur de primes\n\nUn élémentaire de terre est un agglomérat de boue, d'argile, de sable et de roche animé par magie. En apparence lent et maladroit, il est cependant terriblement dangereux et doit être évité à tout prix.");
            ElementaireTerre.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Elementaires/Elementaire_terre.png");
            ElementaireTerre.AddFaiblesse("Bombe au diméritium", "Huile contre les Elémentaires");
            ElementaireTerre.Creaturetype = ElementairesEnum.ElemenyaireTerre;
            return ElementaireTerre;
        }
        #endregion

        #region Draconides
        private static Monstre Basilic()
        {
            Monstre Basilic = new Monstre("Draconides", "Basilic");
            Basilic.AddDescription("En mémoire du noble chevalier Roderick, tué au combat par un basilic. Puisse un de ses os être resté en travers de la gorge du monstre.\n- Epitaphe, cimetière de Wyzima\n\nContrairement à la croyance populaire, le regard d'un basilic ne transforme pas sa victime en statue de pierre. Il n'en reste pas moins une créature terriblement dangereuse, capable de tuer de bien des manières: crocs, griffes, acide ou encore venin font partie de son arsenal.\n\nLe basilic aime les endroits sombres et humides comme les égouts, les cavernes, ou les celliers.Chasseur diurne, il peut attendre une proie pendant des heures avant de surgir pour lancer une attaque fatale.\n\nAfin d'affronter une telle créature, il est recommandé de boire une potion de Loriot doré et de s'armer de bombes(Etoile dansante ou à fragmentation, de préférence).\n\nLe cuir de basilic est un matériau très recherché, utilisé dans la confection de chaussures ou de sacs à main.Pour cette raison, de nombreux hommes aveuglés par des rêves de fortune se lancent, souvent à leurs dépens, dans la chasse au basilic, si bien que bien des imprudents trouvent là une mort prématurée.Les plus chanceux atteignent leur objectif, avec pour conséquence un déclin progressif du nombre de basilics au cours de ces dernières années.Certains druides et mages estiment que le basilic devrait être placé sur une liste des espèces protégées...mais personne ne les écoute.");
            Basilic.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Draconides/Basilic.png");
            Basilic.AddFaiblesse("Loriot doré","Ruche","Huile contre les Draconides","Signe d'Aard");
            Basilic.Creaturetype = DraconidesEnum.Basilic;
            return Basilic;
        }

        private static Monstre Cocatrix()
        {
            Monstre Cocatrix = new Monstre("Draconides", "Cocatrix");
            Cocatrix.AddDescription("J'avais huit belles génisses, donc cinq laitières. Mais depuis que le cocatrix est passé par là, il ne me reste plus que mes yeux pour pleurer.\n- Jethro, paysan de Pindan\n\nLa croyance populaire prête au cocatrix, tout comme au basilic, le pouvoir de changer ses proies en pierre d'un seul regard.\n\nCette croyance n'a cependant aucun fondement et le regard du cocatrix n'est pas plus dangereux que celui d'une oie en colère.\n\nSon bec acéré et sa longue queue sont en revanche des armes autrement plus redoutables...et bien réelles.\n\nLe cocatrix apprécie les grottes sombres, les ruines abandonnées, les souterrains poussiéreux et les vieilles caves.\n\nPlus petit qu'un griffon ou qu'une mantiore, il n'en est pas moins capable de tuer quiconque s'aventure dans son antre.\n\nLorsque que la confrontation est inévitable, le cocatrix frappe son adversaire de ses ailes et de sa queue pour l'épuiser, puis cherche à porter un coup fatal avec son puissant bec, arme redoutable ouvrant de larges plaies. L'huile contre les draconides et la bombe Ruche(dont les éclats transpercent les ailes fragiles du cocatrix) sont particulièrement efficaces contre cette créature.");
            Cocatrix.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Draconides/Cocatrix.png");
            Cocatrix.AddFaiblesse("Ruche", "Huile contre les draconides", "Signe d'Aard");
            Cocatrix.Creaturetype = DraconidesEnum.Cocatrix;
            return Cocatrix;
        }

        private static Monstre Foenard()
        {
            Monstre Foenard = new Monstre("Draconides", "Foënard");
            Foenard.AddDescription("Me parlez pas des foënards... Des saloperies, des aberrations de la nature !\n- Yavinn Buck, vétéran du régiment de volontaires de Mahakam\n\nTout comme le renard, dont son nom est rérivé, le foënard est immédiatement reconnaissable à sa queue.Celle - ci n'est cependant pas rousse est touffue, mais garnie d'excroissances osseuses et parfaitement capable de détruire d'un seul coup un bouclier en chêne et la main de son porteur.");
            Foenard.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Draconides/Foenard.png");
            Foenard.AddFaiblesse("Loriot doré", "Ruche", "Huile contre les draconides", "Signe d'Aard");
            Foenard.Creaturetype = DraconidesEnum.Foënard;
            return Foenard;
        }

        private static Monstre Hurleur()
        {
            Monstre Hurleur = new Monstre("Draconides", "Hurleur");
            Hurleur.AddDescription("Il paraît que vous avec un problème avec un monstre. Un hurleur c'est ça ?\nOuais, il rôde dans le coin, il boulotte les vaches et les chèvres, et il attaque même les hommes.\n- Conversation entretenue à Perchefreux\n\nLe monstre qui tourmentait les habitants de Perchefreux s'avéra être un cocatrix particulièrement retors. Geralt ne fut guère surpris que les hommes du baron n'en soient pas venus à bout.Ils étaient impuissants face à la précision chirurgicale de ses attaques, capables de trancher les artères et de déverser un flot de sang que seule une potion d'Hirondelle pourrait tarir. Ces soldats ignoraient comment contraindre la bête à atterrir grâce à un carreau d'arbalète, une bombe, ou un signe lancé au moment opportun, et comment esquiver sa charge d'une roulade habile afin de se placer sous ses ailes déployées de la créature.\n\nAlors que les villageois semblaient devoir se résigner à vivre avec la menace constante d'une bête assoiffée de sang, et à scruter le ciel avec crainte, le sorceleur fit son apparition et les débarrassa définitivement du hurleur.");
            Hurleur.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Draconides/Hurleur.png");
            Hurleur.AddFaiblesse("Ruche", "Huile contre les draconides", "Signe d'Aard");
            Hurleur.Creaturetype = DraconidesEnum.Hurleur;
            return Hurleur;
        }

        private static Monstre Dragon_Fyresdal()
        {
            Monstre Dragon_Fyresdal = new Monstre("Draconides", "Dragon de Fyresdal");
            Dragon_Fyresdal.AddDescription("Ecailles, ailes, griffes... un dragon, quoi ! Finassez pas et tuez-moi ça avant qu'il fasse d'autres victimes !\n- Yagn, ancien du village de Fyresdal\n\n Rares sont ceux qui peuvent se vanter d'avoir survécu à une rencontre avec un dragon, en conséquence de quoi le commun des mortels est bien incapable de dire précisément à quoi ressemble cette créature. Il n'est donc pas étonnant que, confrontés à un monstre inhabituel, les gens du peuple crient bien souvent au dragon.\n\nC'est ce qui advint à Fyresdal, où le dragon n'était en fait qu'un simple foënard. Ceci dit, la créature pourvue de griffes hautement venimeuses était particulièrement coriace. Dans ces conditions, il aurait été scuicidaire d'engager le combat sans avoir préalablement consommé une potion régénératrice ou un antidote afin de se prémunir contre le poison.\n\nEn affrontant le foënard, Geralt fit preuve non seulement de son habileté avec une lame, mais aussi de compétences inédites de berger.Avec l'aide d'un brave mouton prêté par l'ancien du village, Geralt attira le monstre dans un piège, puis mit un terme à son existence.");
            Dragon_Fyresdal.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Draconides/Dragon_Fyresdal.png");
            Dragon_Fyresdal.AddFaiblesse("Loriot doré", "Ruche", "Huile contre les draconides", "Signe d'Aard");
            Dragon_Fyresdal.Creaturetype = DraconidesEnum.Dragon_Fyresdal;
            return Dragon_Fyresdal;
        }

        private static Monstre Wyvern()
        {
            Monstre Wyvern = new Monstre("Draconides", "Wyvern");
            Wyvern.AddDescription("Parmi les différentes espèces de wyvern, la plus dangereuse est sans le moindre doute la wyvern royale... ou comme elle est parfois surnommée dans certains cercles, la saloperie royale.\n- Albina Tottelkampf, professeur de sciences naturelles à Aretuza\n\nLa wyvern est souvent confonde avec un dragon.Bien qu'elle sois plus petite que son cousin et qu'elle soit incapable de cracher du feu, elle n'en reste pas moins un monstre des plus dangereux. La wyvern royale, en particulier, est une créature féroce et mortelle.");
            Wyvern.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Draconides/Wyvern.png");
            Wyvern.AddFaiblesse("Loriot doré", "Ruche", "Huile contre les draconides", "Signe d'Aard");
            Wyvern.Creaturetype = DraconidesEnum.Wyvern;
            return Wyvern;
        }

        private static Monstre Wyvern_Royale()
        {
            Monstre Wyvern_Royale = new Monstre("Draconides", "Wyvern_Royale");
            Wyvern_Royale.AddDescription("L'était énorme. Et ces crocs ! On a eu chaud.\nMe demande si la bête a tué les marchands...L'auraient pas volé, ces salauds-là !\n- Conversation entretenue à Velen\n\nConnaître sa proie, suivre les chemins forestiers, localiser les points d'eau, écouter son instinct: telles sont les principales qualités d'un bon chasseur.Des qualités que certains monstres possèdent au plus haut degrès...\n\nAinsi, une wyvern royale de Velen avait appris à chasser ses proies sans s'exposer aux regards humains et aux flèches, mais en rôdant aux abords de la route pour attaquer directement les convois millitaires, source de bière et de porc salé. La bête avait grandi tant et si bien qu'elle ressemblait presque à un dragon et terrorrisait la région.\n\nLe sorceleur sut d'emblée que ce spécimen serait plus résistant et puissant que ses congénères. Un coup un seul, et ce serait fini de lui, c'est pourquoi il allait devoir éviter ses charges à tout prix.L'utilisation avisée d'une bombe ou de son arbalète empêcherait quand à elle la bête de prendre son essor afin de fondre sur lui dans un piqué mortel.\n\nFinalement, le sorceleur vint à bout de l'horrible créature, mais non sans mal. Grâce à cet exploit, les soldats purent à nouveau envoyer des chargements de nourriture et d'équippement pour livrer bataille.Etait - ce une bonne ou une mauvaise chose ? Ca, c'est une toute autre question.");
            Wyvern_Royale.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Draconides/Wyvern_Royale.png");
            Wyvern_Royale.AddFaiblesse("Loriot doré", "Ruche", "Huile contre les draconides", "Signe d'Aard");
            Wyvern_Royale.Creaturetype = DraconidesEnum.WyvernRoyale;
            return Wyvern_Royale;
        }


        #endregion

        #region Insectoïdes

        private static Monstre Arachas()
        {
            Monstre Arachas = new Monstre("Insectoïdes", "Arachas");
            Arachas.AddDescription("N'arache aen woed endicen [Ne réveillez pas l'arachas quand il dort].\n- Proverbe Elfe\n\nPinces puissantes, crocs acérés et glandes de venin mortel: tel est le terrible arsenal de l'arachas. Grand prédateur d'humains et d'animaux de ferme, l'arachas est une source de revenus réguliers pour la plupart des sorceleurs.\n\nOriginaire du lointain sud, cette espèce envahissante a migré vers le nord au fil du temps, s'adaptant progressivement au climat plus humide et aux températures moins clémentes. Aujourd'hui parfaitement à son aise au milieu des bois et des marais, l'arachas se terre sous une épaisse couche de boue et de mousse pour hiberner durant l'hiver.Pour protéger son abdomen, sac fragile et vulnérable, il utilise souvent un tronc d'arbre mort.\n\nImmobile, il se fond alors parfaitement dans la végétation pour mieux surprendre ses proies.Lorsqu'il chasse, il commence généralement par cracher son venin pour affaiblir sa victime avant de l'immobiliser à l'aide d'appendices préhensibles pour finalement l'écraser sous ses pinces.");
            Arachas.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Insectoides/Arachas.png");
            Arachas.AddFaiblesse("Loriot doré","Huile contre les Insectoïdes");
            Arachas.Creaturetype = InsectoidesEnum.Arachas;
            return Arachas;
        }

        private static Monstre ArachasCuirasse()
        {
            Monstre ArachasCuirasse = new Monstre("Insectoïdes", "Arachas Cuirassé");
            ArachasCuirasse.AddDescription("\"Les clients comme lui, on les appelle les \"arachas cuirassés\".De vrais durs à l'extérieur, mais dès qu'ils se retrouvent à poil, ils deviennent doux comme des agneaux.\"\n- Lisa la Chaude, prostituée de Maribor\n\nLa seule véritable faiblesse d'un arachas est son abdomen souple et fragile. Si les arachas communs protègent cette zone sensible avec une souche creuse, l'arachas cuirassé bénéficie pour sa part d'une protection naturelle.\n\nL'arachas cuirassé est un mastodonte qui charge ses victimes tête baissée pour les renverser avant de dévorer leur cadavre broyé. Comme tous les arachas, il crache un venin mortel, il est donc fortemement recommandé d'ingérer une potion de Loriot doré avant de l'affronter.\n\nPar ailleurs, un sorceleur avisé préparera une réserve conséquente de potions de soin et de carreaux d'arbalète en prévision d'un combat long et épuisant.");
            ArachasCuirasse.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Insectoides/Arachas_cuirasse.png");
            ArachasCuirasse.AddFaiblesse("Loriot doré", "Huile contre les Insectoïdes");
            ArachasCuirasse.Creaturetype = InsectoidesEnum.ArachasCuirasse;
            return ArachasCuirasse;
        }

        private static Monstre ArachasVenimeux()
        {
            Monstre ArachasVenimeux = new Monstre("Insectoïdes", "Arachas Venimeux");
            ArachasVenimeux.AddDescription("Ca va aller, c'est juste une égratignure.\n- Dernières paroles d'un chasseur anonyme\n\nBien que tous les arachas soient venimeux, cette expèce sécrète une toxine particulièrement puissante.Quelques gouttes de son venin suffisent à terrasser un homme adulte.Un sorceleur peut, grâce à son métabolisme particulier, survivre à une faible dose, mais une forte quantité de venin lui sera également fatale.\n\nL'arachas venimeux dispose d'une importante réserve de venin qu'il utilise de diverses manières pour éliminer ses adversaires. Avant un combat, il enduit ses crocs et ses pinces d'une épaisse couche du liquide mortel.Il peut également cracher son venin pour affaiblir sa proie et, une fois au contact de celle - ci, libérer un nuage toxique irrespirable.Enfin, comme tous ses congénères, l'arachas venimeux dispose d'appendices préhensibles pour immobiliser sa proie.Pour se défaire d'une de ces créatures, il est recommandé de boire une potion de Loriot doré et de l'affaiblir par des attaques à distance(bombes ou tirs d'arbalète) avant de l'achever à l'aide d'une épée d'argent enduite d'huile contre les insectoïdes.");
            ArachasVenimeux.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Insectoides/Arachas_venimeux.png");
            ArachasVenimeux.AddFaiblesse("Loriot doré", "Huile contre les Insectoïdes");
            ArachasVenimeux.Creaturetype = InsectoidesEnum.ArachasVenimeux;
            return ArachasVenimeux;
        }

        private static Monstre BourdonEndriague()
        {
            Monstre BourdonEndriague = new Monstre("Insectoïdes", "Bourdon Endriague");
            BourdonEndriague.AddDescription("Le mâle endriague passe sa vie à se battre dans le seul but de féconder la femelle. Quelle que soit l'espèce, les hommes sont touhjours les mêmes...\n- Evelyn Harker, herboriste\n\nLe mâle endriague, aussi appelé \"bourdon\", est une créature vorace qui semble passer le plus clair de son temps à manger, se battre et se reproduire.Pourtant, lorsqu'il s'aventure hors du nid, c'est un chasseur très agressif et particulièrement dangereux.\n\nLe bourdon endriague a une espérance de vie très courte.Il meurt à l'automne en fécondant la reine et consacre le reste de sa vie à défendre le territoire de la colonie. Seils les bourdons les plus forts survivent à ces combats, une sélection naturelle qui assure la transmission des meilleurs gènes d'une génération à l'autre. Après la fécondation, les bourdons sont tués et servent à nourrir la colonie pendant les longs mois d'hivers.\n\nUn bourdon endriague est facilement identifiable à son abdomen conique.Contrairement aux autres endriagues, le bourdon est capable d'attaquer à distance en projetant des pointes empoisonnées. Il est par ailleurs insensible au saignement et vulnérable aux armes enduites d'huile contre les insectoïdes.");
            BourdonEndriague.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Insectoides/Bourdon_endriague.png");
            BourdonEndriague.AddFaiblesse("Loriot doré", "Huile contre les Insectoïdes");
            BourdonEndriague.Creaturetype = InsectoidesEnum.BourdonEndriague;
            return BourdonEndriague;
        }

        private static Monstre EndriagueGuerriere()
        {
            Monstre EndriagueGuerriere = new Monstre("Insectoïdes", "Endriague Guerrière");
            EndriagueGuerriere.AddDescription("Vous avez peur de ces endriagues ? Attendez un peu d'avoir vu leurs guerrières.\n- Klaus Altman, forestier\n\nLes hordes d'endriagues ouvrières sont capables de venir à bout de la plupart des menaces, mais lorsqu'un adversaire trop coriace se présente, la colonie envoie ses guerrières, plus grandes et plus puissantes.Cette caste ne vit que pour se battre, qu'il s'agisse de défendre les frontières de la colonie ou de conquérir de nouveaux territoires.\n\nL'arme principale d'une endriague guerrière est sa longue queue - massue dotée de pointes venimeuses, grâce à laquelle elle peut assommer ou même tuer un adversaire d'un seul coup.\n\nL'endriague guerrière utilise également son poids et sa puissance comme une arme pour changer et renverser l'ennemi.Comme la plupart des invertébrés à carapace, l'endriague guerrière saigne très peu. En revanche, la douleur infligée par une lame enduite d'une huile contre les insectoïdes lui est presque insupportable.");
            EndriagueGuerriere.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Insectoides/Endriague_guerriere.png");
            EndriagueGuerriere.AddFaiblesse("Loriot doré", "Huile contre les Insectoïdes");
            EndriagueGuerriere.Creaturetype = InsectoidesEnum.EndriagueGuerriere;
            return EndriagueGuerriere;
        }

        private static Monstre EndriagueOuvriere()
        {
            Monstre EndriagueOuvriere = new Monstre("Insectoïdes", "Endriague Ouvrière");
            EndriagueOuvriere.AddDescription("Moi qui croyais que les ouvrières étaient inoffensives... Ca m'apprendra.\n- Jeanne au pied bot, chasseuse\n\nLes ouvrières sont de loin la caste la plus représentée au sein d'une colonie endriague. Elles constituent les nids et les cocons, approvisionnent la colonie en nourriture et prennent soin des oeufs et des larves. Face au danger, elles appellent généralement les guerrières à la rescousse, mais sont néanmoins capables de se défendre.\n\nLes endriagues ouvrières se déplacent le plus souvent en petits groupes d'une demi-douzaine de membres. En dépit de leur lenteur apparente, elles sont capables d'attaques fulgurantes lorsqu'elles sont menacées. Comme toutes les endriagues, les ouvrières sont venimeuses. Leur morsure est toxique, de même que les excroissances osseuses aux extrémités de leurs membres. Elles peuvent par ailleurs cracher de l'acide sur plusieurs mètres.Leur tactiqué habituelle consiste à encercler leur ennemi pour l'attaquer simultanément de tous côtés. De part leur nature, elles ne sont pas affectées par le saignement et sont très vulnérables aux armes enduites d'huile contre les insectoïdes.");
            EndriagueOuvriere.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Insectoides/Endriague_ouvriere.png");
            EndriagueOuvriere.AddFaiblesse("Loriot doré", "Huile contre les Insectoïdes");
            EndriagueOuvriere.Creaturetype = InsectoidesEnum.EndriagueOuvriere;
            return EndriagueOuvriere;
        }

        private static Monstre Harrisi()
        {
            Monstre Harrisi = new Monstre("Insectoïdes", "Harrisi");
            Harrisi.AddDescription("La chose nous a attaqués... Dieux j'ignore ce que c'était mais quelle bếte immense !\n- Paysanne de Velen\n\nChacun sait que les bois et les marais de Velen regorgent de monstres de tout poil.Voilà pourquoi, lorsque la guerre éclata, un groupe de réfugiés pensa échapper aux dangers des basses terres en s'abritant dans une mine désaffectée. Hélas pour eux, ils allaient au devant d'une bien mauvaise surprise: la galerie qu'ils avaient choisie pour sanctuaire servait également d'antre à un arachas venimeux, créature impitoyable et sanguinaire.\n\nLe sorceleur sut immédiatement que la lutte serait âpre.L'arachas, tapi dans une mine depuis des années, avait gagné tant en force qu'en taille.A l'image de ses congénères, il serait aussi dangereux au corps à corps qu'à distance.Sans oublier qu'il était certainement venimeux. Le sorceleur allait devoir ingérer une potion d'Hirondelle ou de Loriot doré(voire les deux) avant le combat s'il espérait triompher. En revanche, le sorceleur savait la créature vulnérable aux signes, en particulier Igni, Aard et Yrden, ainsi qu'à la bombe Vent du Nord.\n\nLe sorceleur arriva à la grotte trop tard pour sauver les réfugiés, mais il pouvait toujours les venger.Il élimina le puissant arachas et détruisit les oeufs contenant ses immondes rejetons.");
            Harrisi.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Insectoides/Harrisi.png");
            Harrisi.AddFaiblesse("Loriot doré", "Huile contre les Insectoïdes");
            Harrisi.Creaturetype = InsectoidesEnum.Harrisi;
            return Harrisi;
        }

        #endregion

        #region Nécrophages

        private static Monstre Abaya()
        {
            Monstre Abaya = new Monstre("Nécrophages", "Abaya");
            Abaya.AddDescription("J'ai vu mon lot de saletés dans ma chienne de vie: murènes, lamproies, lottes... Mais rien d'aussi afreux !\n- Bjorg, charpentier de marine de Kaer Trolde\n\nLa baie de Kaer Trolde jouissait d'une bien mauvaise réputation. Les pêcheurs qui jetaient leurs filets dans ses eaux disparaissaient parfois sans laisser de trace. Des rameurs se faisaient happer sur leurs drakkars, quand cesz derniers n'étaient pas tout simplement renversés.Les villageois y voyaient l'oeuvre de noyeurs, mais la réalité était toute autre... et bien plus sombre encore.\n\nDans les cavernes des Hauts de Kjerag vivait en effet une guenaude aquatique particulièrement retorse, dont les redoutables griffes rendaient vain tout espoir de parade.Après avoir aveuglé ses adversaires à distance, la créature passait à l'attaque avec une vivacité fulgurante. Afin d'en venir à bout, l'utilisation des signes serait de rigueur: Yrden pour la ralentir, et Queen pour se protéger de ses coups. Mais l'atout essentiel de ce combat serait sans conteste une belle dose de chance.\n\nCependant, le sorceleur n'avait jamais été du genre à compter sur la chance. Il avait plus d'un tour dans son sac et, en masquant son odeur, il parvint à surprendr ela cruelle créature et la tua sans coup férir.");
            Abaya.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Necrophages/Abaya.png");
            Abaya.AddFaiblesse("Vent du Nord","Huile contre les Nécrophages","Signe de Queen","Signe d'Igni");
            Abaya.Creaturetype = NecrophagesEnum.Abaya;
            return Abaya;
        }

        private static Monstre Algoule()
        {
            Monstre Algoule = new Monstre("Nécrophages", "Algoule");
            Algoule.AddDescription("Une algoule, c'est comme une goule... mais en pire.\n- Yarpen Zigrin, guerrier nain\n\nL'algoule est plus grande, plus forte et plus intelligente que sa cousine commune. Alors que la goule et le graveir sont des créatures primitives, l'algoule et ses semblables(comme le décharneur, par exemple) sont capables d'élaborer des plans complexes, ce qui les rend d'autant plus dangereuses.\n\nAussi primitives soient - elles, les goules sont toutefois assez lucides pour reconnaître un esprit suppérieur et se laissent volontiers diriger par une algoule ou un décharneur.Ces bandes s'en prennent aux voyageurs solitaires mais aussi aux caravanes, voire aux hameaux isolés. Au sein d'un tel groupe, la menace principale est l'algoule, qui doit être éliminée en priorité. La prudence est de mise lorsque l'on affronte une algoule au crépuscule ou de nuit, car leur force est alors doublée.\n\nAu combat, l'algoule et le décharneur cherchent parfois au mépris du danger, à renverser leur adversaire afin que celui-ci soit facilement déchiqueté par les autre goules. Tout comme une goule ordinaire, une algoule blessée peut devenir frénétique et attaquer avec une fureur aveugle. Si bien des jeunes sorceleurs ont connu une fin prématurée face à une algoule déchaînée, un sorceleur expérimenté profitera de cette aubaine en la frappant dans le dos.");
            Algoule.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Necrophages/Algoule.png");
            Algoule.AddFaiblesse("Huile contre les Nécrophages","Signe d'Axii");
            Algoule.Creaturetype = NecrophagesEnum.Algoule;
            return Algoule;
        }

        private static Monstre Brumelin()
        {
            Monstre Brumelin = new Monstre("Nécrophages", "Brumelin");
            Brumelin.AddDescription("Si la nuit vous surprend au milieu des marais, ne bougez plus avant le lever du soleil. Plus un geste, même si vous avez de l'eau jusqu'à la taille et des sangsues plein le froc... Et surtout, surtout, si vous voyez une lueur dans le brouillard, n'allez jamais vers elle. Jamais, vous comprenez ?\n- Johannes Strudd, guide\n\nLe brouillard est l'ennemi du voyageur. En forêt, il peut lui faire perdre son chemin. En mer, il peut l'envoyer s'échouer sur les récifs. Pourtant, ces dangers sont insinifiants en comparaison du brumelin, monstre sournois qui rôde dans les bancs de brouillard. Si cette créature est dotéer de bras puissants et de griffes aussi tranchantes qu'un kinjal de Zerrikania, c'est son sens de l'illusion et de la duperie qui la rend terriblement mortelle.Bien souvent, le brumelin n'attaque pas sa proie mais se contente de la faire sombrer dans la folie ou de l'attirer dans une zone marécageuse avant d'attendre patiemment qu'elle se noie.");
            Brumelin.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Necrophages/Brumelin.png");
            Brumelin.AddFaiblesse("Poussière de Lune","Huile contre les Nécrophages","Signe de Queen");
            Brumelin.Creaturetype = NecrophagesEnum.Brumelin;
            return Brumelin;
        }

        private static Monstre FourbeVeuve()
        {
            Monstre FourbeVeuve = new Monstre("Nécrophages", "Fourbe-veuve");
            FourbeVeuve.AddDescription("Quelqu'un a cuisiné... C'est... un fémur humain... un fémur d'enfant.\n- Geralt de Riv\n\nLes guenaudes sépulcrales attaquent rarement les humains et préfèrent se nourrir de cadavres déterrés dans les cimetières.Néanmoins, certaines guenaudes s'enhardissent avec l'âge et vont parfois jusqu'à se faufiler dans les maisons pour s'en prendre aux enfants ou aux vieillards.Une telle créature tourmentait les habitants de Valtilleul.\n\nLe sorceleur se doutait que la gueunaude sépulcrale lui donnerait du fil à retordre.Il allait devoir éviter ou parer les coups de ses puissantes griffes capables de tailler la roche, ainsi que sa langue, longue et venimeuse.Il réalisa également que ses attaques seraient trop fulgurantes pour ses réflexes surhumains, et avisa qu'il serait donc judicieux d'avoir recours au signe d'Yrden pour sortir vainqueur de cet affrontement.\n\nL'issue du combat était assez prévisible. La guenaude sépulcrale périt dans le cimetière même où elle se nourrissait, puis son cadavre fut jeté dans une tombe qu'elle avait creusée de ses propres griffes.");
            FourbeVeuve.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Necrophages/Fourbe-veuve.png");
            FourbeVeuve.AddFaiblesse("Sang Noir","Huile contre les Nécrophages","Signe d'Irden","Signe de Queen");
            FourbeVeuve.Creaturetype = NecrophagesEnum.FourbeVeuve;
            return FourbeVeuve;
        }

        private static Monstre Goule()
        {
            Monstre Goule = new Monstre("Nécrophages", "Goule");
            Goule.AddDescription("Les goules rampent la nuit, rampent rampent sous les lits, elles mangent les petits enfants, les gentils et les méchants.\n- Comptine\n\nIl est difficile de décrire correctement une goule ou un graveir.En dépit de leur apparence quasi humaine, ces deux créatures représentent la négation même de toute l'humanité. Bien qu'elles aient des bras et des jambes, elles se déplacent à quatre pattes.Leur visage affreusement humain ne montre jamais la moindre émotion, ni le moindre signe de conscience.Leur unique source de motivation est leur insatiable appétit de chair humaine.\n\nEn combat singulier, une goule ne représente pas une menace sérieuse pour un sorceleur aguerri, mais il faut cependant rappeler qu'une goule blessée plonge parfois dans une frénésie sanguinaire qui la pousse à attaquer au mépris du danger. Sans oublier que les goules et autres graveirs sont particulièrement dangereux au crépuscule et de nuit.");
            Goule.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Necrophages/Goule.png");
            Goule.AddFaiblesse("Huile contre les Nécrophages");
            Goule.Creaturetype = NecrophagesEnum.Goule;
            return Goule;
        }

        private static Monstre GuenaudeAquatique()
        {
            Monstre GuenaudeAquatique = new Monstre("Nécrophages", "Guenaude Aquatique");
            GuenaudeAquatique.AddDescription("Paraîtrait que les guenaudes aquatiques sont les femmes des noyeurs. Je sais pas si c'est vrai, mais ça expliquerait pourquoi c'est des mal-baisées.\n- Shemhel de Dregsdon\n\nDe nombreuses légendes relatent l'histoire tragique de malheureux voyageurs piégés par une guenaude aquatique ou une ribaude des marais dissimulée sous les traits d'une vieille femme inoffensive.En vérité, seul un fou entrerait de son plein gré dans l'antre infâme d'une guenaude et même un aveugle ne se laisserait pas duper par l'odeur immonde de poisson pourri émanant de ces créaturers couvertes de verrues, ridées des pieds à la tête et hautes de près de deux mètres. Des excroissances osseuses de près de cinquante centimètres pousssent dans leur dos, leurs cheveux ressemblent à un amas d'algues humides et leurs griffes n'ont rien à envier à celles d'un loup - garou.");
            GuenaudeAquatique.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Necrophages/Gueunaude_aquatique.png");
            GuenaudeAquatique.AddFaiblesse("Vent du Nord","Huile contre les Nécrophages","Signe de Queen","Signe d'Igni");
            GuenaudeAquatique.Creaturetype = NecrophagesEnum.GueunaudeAquatique;
            return GuenaudeAquatique;
        }

        private static Monstre GuenaudeSepulcrale()
        {
            Monstre GuenaudeSepulcrale = new Monstre("Nécrophages", "Guenaude Sépulcrale");
            GuenaudeSepulcrale.AddDescription("\"En parlant de crémation, les humains seraient bien inspirés d'imiter ces gnomes. Enterrer des corps, quelle idée saugrenue ! Autant lancer une invitation à tous les monstres de la région. Et encore, si on attire que les goules, on a de la chance. Elles se rempliront la panse et iront chercher leur prochain repas un peu plus loin. En revanche, si une guenaude sépulcrale décide de faire de votre cimetière sa nouvelle cantine, c'est une autre histoire.\"\n- Jacquess de Villepin, académie d'Oxenfurt\n\nLa guenaude sépulcrale, la bien nommée, ressemble à une vieillarde difforme rôdant près des cimetières et des champs de bataille.Friante de cadavres humains, elle apprécie particulièrement la moelle des os, qu'elle aspire à l'aide de ses langues préhensibles.A défaut de cadavres frais, la guenaude n'hésite pas à s'en prendre aux humains pour les enterrer et attendre que leur corps commence à se décomposer.");
            GuenaudeSepulcrale.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Necrophages/Guenaude_sepulcrale.png");
            GuenaudeSepulcrale.AddFaiblesse("Sang Noir","Huile contre les Nécrophages","Signe d'Irden","Signe de Queen");
            GuenaudeSepulcrale.Creaturetype = NecrophagesEnum.GuenaudeSepulcrale;
            return GuenaudeSepulcrale;
        }

        private static Monstre IgnisFatuus()
        {
            Monstre IgnisFatuus = new Monstre("Nécrophages", "Ignis Fatuus");
            IgnisFatuus.AddDescription("\"En parlant de crémation, les humains seraient bien inspirés d'imiter ces gnomes. Enterrer des corps, quelle idée saugrenue ! Autant lancer une invitation à tous les monstres de la région. Et encore, si on attire que les goules, on a de la chance. Elles se rempliront la panse et iront chercher leur prochain repas un peu plus loin. En revanche, si une guenaude sépulcrale décide de faire de votre cimetière sa nouvelle cantine, c'est une autre histoire.\"\n- Jacquess de Villepin, académie d'Oxenfurt\n\nLa guenaude sépulcrale, la bien nommée, ressemble à une vieillarde difforme rôdant près des cimetières et des champs de bataille.Friante de cadavres humains, elle apprécie particulièrement la moelle des os, qu'elle aspire à l'aide de ses langues préhensibles.A défaut de cadavres frais, la guenaude n'hésite pas à s'en prendre aux humains pour les enterrer et attendre que leur corps commence à se décomposer.");
            IgnisFatuus.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Necrophages/Ignis_fatuus.png");
            IgnisFatuus.AddFaiblesse("Poussière de Lune","Huile contre les Nécrophages","Signe de Queen");
            IgnisFatuus.Creaturetype = NecrophagesEnum.IgnisFatuus;
            return IgnisFatuus;
        }

        private static Monstre Noyeur()
        {
            Monstre Noyeur = new Monstre("Nécrophages", "Noyeur");
            Noyeur.AddDescription("A la pêche, la première règle est de ne pas faire de bruit. D'abord pour ne pas effrayer les poissons... mais surtout, pour ne pas attirer les noyeurs.\n- Yanneck de Blaviken, pêcheur\n\nUn noyeur ressemble à un cadavre humain ayant longtemps séjourné au fond de l'eau. Boue et vase sortent par tous les pores de sa peau bleuâtre ou verdâtre et il émane de lui une odeur âcre de chair pourrie. Pour cette raison, la croyance populaire veut que le noyeur (ainsi que ses sinistre cousins, vodnik, fangeux et noyadé) naisse des cadavres noyés en eau peu profonde: voyageur perdu tombant dans une tourbière, enfant emporté par le courant ou, dans le cas du voldnik, paysan éméché égaré dans les marais.\n\nComme la plupart de ces croyances, celle - ci est fausse: en dépit de son apparence humanoïde, le noyeur possède une anatomie différente de la nôtre, comme le peuvent en attester tous les sorceleurs ayant eu le privilège peu enviable d'en examiner un de près. Sa peau écailleuse, ses branchies et ses nageoires indiquent que le noyeur appartient à une espèce bien distincte.\n\nCes caractéristiques physiques font du noyeur un excellent nageur, parfaitement adapté aux mares et aux marécages dans lesquels il évolue.il installe souvent son antre à proximité des habitations humaines, qui lui procurent une source de nourriture régulière.\n\nDe nature craintive, il se contente généralement de restes et de carcasses d'animaux, mais ne dédaigne pas le voyageur isolé ou le pêcheur imprudent occasionnel. Il attaque alors avec une vitesse stupéfiante pour entraîner sa victime dans l'eau et la noyer.Le plus souvent, il laisse macérer sa malheureuse victime pendant plusieurs jours pour attendrir sa chair.Le noyeur est surtout actif au crépuscule et la nuit(sourtout s'il pleut), heures durant lesquelles il peut s'éloigner de son terrier aquatique pour s'aventurer dans les terres.\n\nNoyeurs, fangeux, voldniks, noyadés vivent tous dans un environnement putride et ont développé une résistance naturelle aux toxines et au poison.En dépit de leur forme humanoïde, aucune de ces créatures n'est plus intelligente qu'une carpe ou qu'un brochet. Les sorts affectant l'esprit, signe d'Axii inclus, sont donc inefficaces contre elles. En revanche, elles sont particulièrement vulnérables aéu signe d'Igni et à la magie du feu en général.");
            Noyeur.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Necrophages/Noyeur.png");
            Noyeur.AddFaiblesse("Huile contre les Nécrophages","Signe d'Igni");
            Noyeur.Creaturetype = NecrophagesEnum.Noyeur;
            return Noyeur;
        }

        private static Monstre Putrefacteur()
        {
            Monstre Putrefacteur = new Monstre("Nécrophages", "Putréfacteur");
            Putrefacteur.AddDescription("Evidemment qu'ils empestent ! Tu crois qu'on les appelle putréfacteurs parce qu'ils sentent la rose ?\n- Vesimir, Ecole du Loup\n\nLe putréfacteur ressemble à un cadavre écorché en décomposition et doit son nom à l'atroce puanteur qu'il dégage.Parmi les différents types de putréfacteurs le dévoreur est sans doute le plus dangereux et apprécie tout particulièrement la chair humaine.\n\nAutrefois rares, putréfacteurs et dévoreurs prolifèrent aujourd'hui autour des nombreux champs de bataille et des zones frappées par la maladie. Nécrophages par nature, ils peuvent néanmoins s'en prendre aux êtres vivants.Ils se déplacent en groupe et les voyageurs isolés sont pour eux des proies faciles, d'autant plus qu'ils sont parfaitement capables de rattrapper un cheval au galop.\n\nLe corps en décomposition d'un putréfacteur est rempli de gazs² toxiques (même pour un sorceleur) et inflammables. Une simple étincelle ou un signe d'Igni lancé à la hâte peuvent provoquer une explosion, surtout au moment de la mort du putréfacteur, dont le corps est alors pris de soubresauts incontrôlables.\n\nPutréfacteurs et dévoreurs chassent du crépuscule à l'aube, c'est pourquoi ils sont bien plus dangereux à ces heures qu'en plein jour.");
            Putrefacteur.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Necrophages/Putrefacteur.png");
            Putrefacteur.AddFaiblesse("Huile contre les Nécrophages");
            Putrefacteur.Creaturetype = NecrophagesEnum.Putrefacteur;
            return Putrefacteur;
        }

        #endregion

        #region Orgoïdes

        private static Monstre Cyclope()
        {
            Monstre Cyclope = new Monstre("Orgoïdes", "Cyclope");
            Cyclope.AddDescription("Bon, voilà le plan... On prend un grand pieu, on affûte sa pointe, on la plante dans l'oeil du cyclope... et ensuite on sort de la caverne déguisés en moutons. Comment ça, pas une bonne idée ?\n- Odess Thaka, voyageur mort tragiquement sur Spikeroog\n\nLe cyclope est immédiatement reconnaissable à son oeil unique situé au centre du front.Si, pour une raison ou pour une autre, ce trait distinctif n'est pas visible, sa taille monstrueuse, son incroyable force et sa haine des humains sont autant de signes révélateurs.");
            Cyclope.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Orgoides/Cyclope.png");
            Cyclope.AddFaiblesse("Huile contre les Orgoïdes", "Signe d'Axii", "Signe de Queen");
            Cyclope.Creaturetype = OrgoidesEnum.Cyclope;
            return Cyclope;
        }
        private static Monstre GeantGlace()
        {
            Monstre GeantGlace = new Monstre("Orgoïdes", "Géant de Glace");
            GeantGlace.AddDescription("De toute ma vie, je n'ai fui qu'une seule fois, devant le géant de glace. Et vous savez quoi ? Je n'en ai pas honte du tout.\nRasmund Kvaalkje, rameur du clan Torrdarroch\n\nLe géant de glace, monstre puissant et primitif, est sans doute le dernier représentant de son espèce.Il ressemble à un homme, mais un homme plus grand qu'un arbre à la peau bleue comme le givre. Bien qu'il semble doué de raison, toutes les tentatives de communication se sont soldées par la mort violente de l'interlocuteur.");
            GeantGlace.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Orgoides/Geant_glace.png");
            GeantGlace.AddFaiblesse("Huile contre les Orgoïdes", "Signe de Queen");
            GeantGlace.Creaturetype = OrgoidesEnum.GéantDeGlace;
            return GeantGlace;
        }

        private static Monstre Hagubman()
        {
            Monstre Hagubman = new Monstre("Orgoïdes", "Hagubman");
            Hagubman.AddDescription("Déjà entendu causer d'une sale bête qui laisse un chariot sur la route pis qu'attend en embuscade ? Sont trop crétins pour ça, bon sang !\n- Egil, guerrier d'Hindarsfjall\n\nLe nekker moyen est une créature veule et faible qui n'attaque qu'en cas de suppériorité numérique évidente.Pourtant, certains nekkers sont parfois plus fort, résistants et malins que leurs congénères.En dépit de leur surnom de \"guerrier\", ces individus agissent plutôt comme des assassins: tapis dans les ombres, ils attaquent par surprise dans le dos de leurs adversaires, ou attendent que l'ennemi ouvre sa garde pour attaquer. Par chance, à l'instar des autres nekkers, les guerriers sont vulnérables à tous les signes, et leurs coups peuvent aisément être parés ou contrés.\n\nUn tel monstre sévissait près du village de Larvik sur Hindarsfjall.Les plus braves combattants du village ne pouvaient pas en venir à bout, mais un sorceleur en revanche...Un sorceleur est un adversaire de haute volée.");
            Hagubman.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Orgoides/Hagubman.png");
            Hagubman.AddFaiblesse("Vent du Nord", "Huile contre les Orgoïdes");
            Hagubman.Creaturetype = OrgoidesEnum.Hagubman;
            return Hagubman;
        }

        private static Monstre Nekker()
        {
            Monstre Nekker = new Monstre("Orgoïdes", "Nekker");
            Nekker.AddDescription("Prenez garde, messieurs, il y a des nekkers sous ce pont. Si vous traversez tous ensemble sans ralentir, vous n'avez rien à craindre, mais si par malheur l'essieu de votre chariot casse et que vous restez bloqués... Eh bien, fermez les yeux et adressez une dernière prière à Melitele.\n- Kurt Hammerbach, garde de Vengerberg\n\nUn nekker solitaire est inoffensif.Cinq nekkers représentent une menace sérieuse.Dix nekkers peuvent venir à bout d'un tueur de monstre expérimenté. Les guerriers nekker, ainsi que les redoutables foucasses (plus rares), sont particulièrement dangereux.\n\nNekkers et foucasses vivent au coeur des bois sombres poussant dans les vallées humides et brumeuses, au sein de colonies pouvant compter jusqu'à plusieurs dixaines d'individus.Ils creusent de profonds terriers reliés entre eux par un vaste réseau d'étroits tunnels grâce auxquels ils peuvent se déplacer rapidement dans et autour de leur colonie.\n\nLes nekkers attaquent toujours en groupe et par surprise.Ils essayent d'encercler leur proie aussi vite que possible afin de l'empêcher de fuir, puis se jettent sur elle de manière désorganisée.Les nekkers sont craintifs et un sorceleur expérimenté saura exploiter leurs nombreuses hésitations pour tuer les individus les plus dangereux avant d'achever les survivants.");
            Nekker.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Orgoides/Nekker.png");
            Nekker.AddFaiblesse("Vent du Nord", "Huile contre les Orgoïdes");
            Nekker.Creaturetype = OrgoidesEnum.Nekker;
            return Nekker;
        }

        private static Monstre TapeTapeur()
        {
            Monstre TapeTapeur = new Monstre("Orgoïdes", "Tape-tapeur");
            TapeTapeur.AddDescription("Eux rentrer maison troll. Troll dire \"Hommes partir !\" mais eux tape-taper cailloux troll. Alors troll tape-taper aussi !\n- Troll de pierre appelé Tape-tapeur\n\nLourds et lents, les trolls de pierre semblent le plus souvent stupides aux yeux des humains.Il est cependant dangereux de les sous - estimer et plus encore de les enrager.Si par malheur on en énerve un, le mieux à faire est de prendre ses jambes à son cou, car un troll de pierre en colère est aussi mortel qu'un éboulement. Cette vérité se confirma avec l'énorme troll de pierre Tape - tapeur.Il assenait de véritables coups de boutoir, aussi fallait - il soit les éviter soit se protéger avec le signe de Queen.Sa peau épaisse le rendait presque invulnérable aux coups d'épée, en particulier ceux portés par derrière, sa peau de pierre étant plus épaisse dans son dos. La seule chance pour le vaincre était de profiter de sa lenteur naturelle de troll, encore plus facile à exploiter avec le signe d'Yrden.\n\nUn groupe de mineurs de Skellige apprit à ses dépens à quel point les trolls de pierre sont dangereux.Ignorant les avertissements, ils entreprirent d'exploiter un filon d'argent dans la caverne ou un troll surnommé le Tape - tapeur avait élu domicile...et moururent peu de temps après sous les coups du troll irascible.Sa colère était justifiée mais malheureusement pour lui, les sorceleurs n'émettent pas de jugement moral: ils se contentent de tuer les monstres.");
            TapeTapeur.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Orgoides/Tape-tapeur.png");
            TapeTapeur.AddFaiblesse("Huile contre les Orgoïdes", "Signe de Queen");
            TapeTapeur.Creaturetype = OrgoidesEnum.TapeTapeur;
            return TapeTapeur;
        }

        private static Monstre TrollGlace()
        {
            Monstre TrollGlace = new Monstre("Orgoïdes", "Troll de Glace");
            TrollGlace.AddDescription("Quand vient l'hiver glacial, les engelures rongent les pieds, la neige recouvre la terre et les trolls de glace sortent de leur tannière.\n- Chanson folklorique du nord de Kaedwen\n\nComme chacun sait, l'ascention d'un sommet enneigé est une activité présentant mille dangers: chute au fond d'un ravin, avalanche ou encore... rencontre avec un troll de glace. Contrairement au troll de pierre, le troll de glace considère chaque humain rencontré comme une pièce de choix pour son prochain repas.\n\nPar chance, le troll de glace vit à l'écart des humains, au sommet des plus hautes montagnes, ce qui explique sans doute pourquoi il ne s'exprime que par grognements.Certains érudits avancent que l'environnement inhospitalier dans lequel évolue le troll ne laisse guère de place à la communication ou à la pitié.\n\nPlus cruel et plus fort que son cousin de pierre, le troll de glace utilise cependant la même tactique de combat: projection d'énormes blocs de roche et grands coups de poings solides comme des massues. Son dos est protégé par une épaisse arme naturelle, il est donc inutile de l'attaquer par derrière.De plus, il est trop lourd pour être affecté par le signe d'Aard. Enfin, ne songez pas à engager le combat durant un blizzard, dont il profitera pour puiser ses forces.");
            TrollGlace.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Orgoides/Troll_glace.png");
            TrollGlace.AddFaiblesse("Huile contre les Orgoïdes", "Signe de Queen");
            TrollGlace.Creaturetype = OrgoidesEnum.TrollDeGlace;
            return TrollGlace;
        }

        private static Monstre TrollPierre()
        {
            Monstre TrollPierre = new Monstre("Orgoïdes", "Troll de Pierre");
            TrollPierre.AddDescription("Homme pas parler, sinon troll tape-taper !\n- Troll de pierre vivant dans une caverne près d'Undvik\n\nSi d'aventure vous apercevez un rocher vivant au cours d'une marche en montagne, vous ne rêvez pas: vous venez de rencontrer un troll de pierre.Ce monstre à l'intelligence limitée n'est pas particulièrement belliqueux, mais il est préférable de se préparer à un éventuel combat, sous peine de périr dans sa panse rebondie.\n\nLe troll est capable d'utiliser le feu et des outils simples, et certains trolls maîtrisent même les rudiments de la langue commune. Bien que la conversation d'un troll soit des plus limitées, il apprécie les énigmes, les rimes et les jeux de mots, une particularité dont un sorceleur habile saura tirer profit.\n\nSi le combat est inévitable, il faut savoir que le troll de pierre aime lancer des blocs de roche sur ses adversaires avant de les démolir avec ses énormes poings capables d'enfoncer la plus solide armure. De plus, son dos est couvert d'une épaisse couche de roche, le rendant de facto invulnérable sous cet angle.il est donc obligatoire de l'affronter de face, si possible armé d'une lame enduite d'huile contre les orgoïdes.");
            TrollPierre.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Orgoides/Troll_pierre.png");
            TrollPierre.AddFaiblesse("Huile contre les Orgoïdes", "Signe de Queen");
            TrollPierre.Creaturetype = OrgoidesEnum.TrollDePierre;
            return TrollPierre;
        }

        #endregion

        #region Spectres

        private static Monstre Bleme()
        {
            Monstre Bleme = new Monstre("Spectres", "Blême");
            Bleme.AddDescription("Certains hommes ont de bonnes raisons d'avoir peur de leur ombre.\n- Svargmitt, druide d'An Skellig\n\nLes monstres s'en prennent le plus souvent à ce que l'on appelle communément d'innocentes victimes: marchands tardifs, enfants imprudents, voyageurs isolés ou un peu trop curieux... Pourtant, le blême ne représente aucune menace pour ces individus. En effet, il s'attaque uniquement aux êtes les plus abjects et les plus méprisables, coupables d'un crime inavouable. Le blême apparaît à sa victime sous la forme d'une silhouette humanoïde de haute taille, drapée dans l'ombre et dotée de longues griffes acérées. Aux yeux du reste du monde, il est totalement invisible.\n\nEn dépit de ses griffes, le blême ne s'en prend jamais directement à sa victime. Il préfère saper sa volonté de manière indirecte, s'emparer de ses peurs les plus sombres pour créer de terrifiantes visions et lui murmurer à l'oreille pour la pousser lentement mais sûrement vers la folie, la violence et l'autodestruction.\n\nLa proie d'un blême est hantée chaque nuit par d'affreux cauchemards terriblement réalistes lui interdisant toute forme de repos.Sous l'effet de la fatigue et de la peur, elle peut alors supplier ou menacer d'invisibles fantômes, voire confesser publiquement ses crimes dans l'espour de mettre un terme à ses souffrances. En vain, car le blême n'a de cesse de plonger sa victime dans la folie pure ou de la pousser au scuicide.");
            Bleme.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Spectres/Bleme.png");
            Bleme.AddFaiblesse("Poussière de Lune","Huile contre les Spectres","Signe d'Igni");
            Bleme.Creaturetype = SpectresEnum.Bleme;
            return Bleme;
        }

        private static Monstre DemonPresDuPuits()
        {
            Monstre DemonPresDuPuits = new Monstre("Spectres", "Démon près du puits");
            DemonPresDuPuits.AddDescription("Il porte une robe sale, de vrais haillons, et sa peau pend sur ses os. Et il hurle... comme s'il souffrait.\n- Odolan de Blanchefleur\n\nLes habitants de Blanchefleur avaient connu plus que leur lot de malheurs.Les armées de passage les avaient empêchés de faire les semailles du printemps, un griffon enlevait leur bétail, puis, pour couronner le tout, voilà qu'un spectre de midi s'était mis à hanter le puits le plus proche.Pas étonnant que les habitants se soient mis à qualifier ce dernier de démon.le sorceleur sentit que quelque chose liait le spectre à cet endroit, et que pour le renvoyer dans le monde des esprits, il devrait d'abord découvrir son secret.\n\nLorsque ce fut chose faite, il dut se préparer au combat, et un spectre de midi est un adversaire que l'on ne doit pas prendre à la légère. Il peut désorienter sa victime en l'aveuglant et en créant des doubles de son image.Ces doubles absorbent lentement l'énergie vitale de sa victime pendant que leur maître reste intouchable. Afin de vaincre le spectre, le sorceleur ne pourrait pas compter que sur son épée en argent. Il devrait aussi empàloyer le signe d'Yrden pour le piéger et l'obliger à se matérialiser.\n\nEn général, les sorceleurs ne ressentent pas grand - chose pour les monstres qu'ils tuent. Ils haïssent les plus cruels et sont repoussés par les plus répugnants, mais il arrive en de rares occasions qu'ils éprouvent de la sympathie pour un monstre.Et c'est exactement ce que Geralt ressentit pour le spectre de midi de Blanchefleur. Pendant longtemps, les pensées du sorceleur furent hantées par la jeune femme transformée en monstre terrible à cause de sa mort affreuse et de ses puissantes émotions.");
            DemonPresDuPuits.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Spectres/Demon_pres_du_puits.png");
            DemonPresDuPuits.AddFaiblesse("Poussière de Lune", "Huile contre les Spectres", "Signe d'Yrden");
            DemonPresDuPuits.Creaturetype = SpectresEnum.DémonPresDuPuits;
            return DemonPresDuPuits;
        }

        private static Monstre DameBlanche()
        {
            Monstre DameBlanche = new Monstre("Spectres", "La Dame Blanche");
            DameBlanche.AddDescription("Quatre gars, soiffards et bons à rien. Après quelques pintes, ils ont décidé d'aller se taper la Dame blanche, pour voir si ça allait la faire déguerpir.\n- Conversation entretenue dans un champ près de Novigrad\n\nL'apparition qui hantait les champs à l'extérieur de Novigrad était en réalité un spectre de midi, retenue en ce lieu par une émotion puissante: amour, haine, colère, voire un mélange des trois.A l'instar de nombreux spectres de ce type, celui-ci était capable de créer des illusions de lui-même afin d'induire ses adversaire en erreur tout en regagnant de la vitalité.Par chance, ces mirages peuvent aisément être dissipés à la pointe d'une lame d'argent.A l'image de ses congénères, ce spectre adopterait sûrement une forme éthérée durant le combat afin de se prémunir contre les attaques physiques, à moins d'être préalablement piégé dans le signe d'Yrden ou affecté par une bombe spéciale. Une fois la créature sous une forme matérielle, les attaques puissantes et le signe d'Igni seront les meilleurs amis du sorceleur: \"Plus tu combats longtemps un spectre de midi, plus tes chances de survivre s'amenuisent\" et \"Spectre de midi au zénith, mort assurée avant la nuit\".L'esprit vengeur appelé Dame blanche terrorrisait depuis longtemps les paysans et empêchait toute récolte, faisant planer sur la région le \"spectre\" de la famine. Mettant leurs maigres ressources en commun, les paysans décidèrent de recourir aux services d'un sorceleur afin que leur vie puisse reprendre son cours normal.Leur argent fut bien dépensé.");
            DameBlanche.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Spectres/Dame_blanche.png");
            DameBlanche.AddFaiblesse("Poussière de Lune", "Huile contre les Spectres", "Signe d'Yrden");
            DameBlanche.Creaturetype = SpectresEnum.LaDameBlanche;
            return DameBlanche;
        }

        private static Monstre DameDesBois()
        {
            Monstre DameDesBois = new Monstre("Spectres", "La Dame des Bois");
            DameDesBois.AddDescription("Alors... Ca veut dire que... Le spectre, c'est notre Zula ?\n- Bolko, échevin d'Haubreuil\n\nOn dit que le véritable amour ne meurt jamais.Cette triste vérité est à l'origine du retour de Zula de Hautbreuil, qui, morte prématurément et incapable de trouver la paix éternelle, revint hanter son village sous la forme d'un spectre de minuit.\n\nCe type d'apparitions est particulièrement difficile à vaincre. Un spectre de minuit crée des illusions de lui-même afin de semer la confusion dans l'esprit de son adversaire.Il est de plus capable d'adopter une forme immatérielle le rendant invulnérable aux dégats physiques. Le meilleur moyen de l'obliger à quitter cet état consiste à le piéger à l'aide du signe d'Yrden, immédiatement suivi du signe d'Igni une fois le spectre emprisonné. Et le plus important: n'engagez jamais le combat en pleine nuit, lorsque la nuit est à son zénith.\n\nSans l'arrivée de Geralt de Riv, sorceleur de passage et à la bourse vide, ce monstre vengeur aurait sans doute fini par tuer les habitants jusqu'au dernier.");
            DameDesBois.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Spectres/Dame_des_bois.png");
            DameDesBois.AddFaiblesse("Poussière de Lune", "Huile contre les Spectres", "Signe d'Yrden");
            DameDesBois.Creaturetype = SpectresEnum.LaDameDesBois;
            return DameDesBois;
        }
        private static Monstre Penitent()
        {
            Monstre Penitent = new Monstre("Spectres", "Pénitent");
            Penitent.AddDescription("Je suis rentré tout de suite, je me suis barricadé... et là j'ai entendu une voix qui m'appelait. Mikkjaaal, Mikkjaaal !\n- Mikkjal, gardien du phare d'Eldberg\n\nIl s'avéra que le monstre hantant l'île d'Eldberg et son phare était un spectre rare connu sous le nom de pénitent. Les lieux qu'il hante sont immédiatement nimbés d'un épais brouillard et de profondes ténèbres où se perdent à jamais les voyageurs imprudents. Pour vaincre un pénitent, il convient de rester constament en mouvement afin d'éviter les coups de l'agile créature, capable de se matérialiser dans le dos de l'ennemi en un clin d'oeil. Mais le plus important, c'est de découvrir ce qui relie le monstre à l'endroit qu'il hante et de briser ce lien dans les meilleurs délais.\n\nAvec l'aide du gardien du phare, Geralt chassa la brume de l'île, puis expédia le pénitent dans un autre monde pour de bon.Les navires pouvaient à nouveau gagner le port d'Arinbjorn, et la bourse du sorceleur s'alourdit un peu.");
            Penitent.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Spectres/Penitent.png");
            Penitent.AddFaiblesse("Poussière de Lune", "Huile contre les Spectres", "Signe d'Yrden", "Signe de Queen");
            Penitent.Creaturetype = SpectresEnum.Penitent;
            return Penitent;
        }

        private static Monstre Spectre()
        {
            Monstre Spectre = new Monstre("Spectres", "Spectre");
            Spectre.AddDescription("Avant de mourir, mettez vos affaires en ordre, dites adieu à vos proches, rédigez votre testament et excusez-vous auprès de ceux à qui vous avez causé du tort. Sinon vous ne quitterez jamais vraiment ce bas-monde.\nPaule Vikar, guérisseuse, offrant ses conseils à un mourant\n\nPrêtres et érudits débattent depuis toujours pour savoir si les âmes des défunts voyagent vers un autre monde après la mort, un monde où les attendrait joie ou souffrance éternelle.Les deux groupes s'accordent cependant en un point: un esprit qui ne peut, pour une raison ou pour une autre, quitter notre monde après sa mort, se transforme inévitablement en spectre. Un sort peu enviable, à entendre leurs cris lugubres.\n\nLe spectre erre généralement la nuit dans les cimetières, les catacombes et autre lieux funéraires, ou près des endroits importants pour lui de son vivant: maison abandonnée, château en ruines ou pont oublié.\n\nConsumé par sa haine et sa jalousie des vivants, un spectre souffre en permanence.Immatériel par nature, il est insensible au feu, au poison et aux armes conçues pour infliger des hémorragies.\n\nSous sa forme immatérielle, un spectre est très difficile à blesser.Pour le forcer à s'incarner physiquement, il faut l'immobiliser à l'aide du signe d'Yrden ou le toucher avec une bombe Poussière de lune.Il devient alors vulnérable pendant un bref instant à une lame d'argent enduite d'huile contre les spectres.A noter que les spectres sont particulièrement dangereux lors des nuits sans lune.");
            Spectre.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Spectres/Spectre.png");
            Spectre.AddFaiblesse("Poussière de Lune", "Huile contre les Spectres", "Signe d'Yrden", "Signe de Queen");
            Spectre.Creaturetype = SpectresEnum.Spectre;
            return Spectre;
        }

        private static Monstre SpectreDeMidi()
        {
            Monstre SpectreDeMidi = new Monstre("Spectres", "Spectre de midi");
            SpectreDeMidi.AddDescription("Si les paysans interrompent leur labeur à midi, ce n'est pas pour se reposer à l'heure la plus chaude de la journée... C'est pour éviter les spectres de midi.\n- Vlad Reymond, Coutumes paysannes\n\nLors des chaudes journées estivales, quand le soleil est proche de son zénith, on voit parfois apparaître une femme roussie par le soleil et vêtue d'une longue robe blache. Il s'agit d'un spectre de midi, l'esprit d'une jeune femme décédée de mort violente à la veille de son mariage. Folle de douleur et de colère, elle erre dans les champs à la recherche de son amant infidèle ou d'une rivale déloyale et tue quiconque se dresse sur son chemin.Elle est souvent retenue en ce monde par un objet chargé d'émotions fortes, c'est pourquoi il ne faut jamais ramasser un anneau ou un voile déchiré trouvé dans un champ, mais au contraire s'en éloigner le plus vite possible. Le spectre de midi hante uniquement les zones rurales et reste généralement à proximité du lieu de sa mort. Il s'attaque aux paysans ou à leurs enfants.\n_nIl ne saigne pas et la plupart des signes de sorceleurs sont sans effet sur lui.Il peut créer des doubles à son image pour encercler sa victime dans une sinistre parodie de danse et saper son énergie vitale pour l'ajouter à la sienne. Il peut enfin dans une certaine mesure, manipuler le monde physique, en soulevant par exemple des nuages de poussière pour aveugler ou désorienter ses adversaires.\n\nSous sa forme immatérielle, un spectre de midi est très difficile à blesser.Pour le forcer à s'incarner physiquement, il faut l'immobiliser à l'aide du signe d'Yrden ou le toucher avec une bombe Poussière de lune.Il devient alors vulnérable pendant un bref instant à une lame d'argent enduite d'huile contre les spectres.");
            SpectreDeMidi.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Spectres/Spectre_de_midi.png");
            SpectreDeMidi.AddFaiblesse("Poussière de Lune", "Huile contre les Spectres", "Signe d'Yrden");
            SpectreDeMidi.Creaturetype = SpectresEnum.SpectreDeMidi;
            return SpectreDeMidi;
        }

        private static Monstre SpectreDeMinuit()
        {
            Monstre SpectreDeMinuit = new Monstre("Spectres", "Spectre de minuit");
            SpectreDeMinuit.AddDescription("Les spectres de minuit semblent si tristes... Je les crains, bien sûr, mais j'ai parfois pitié de ces âmes en peine.\n- Aelline, Altsparr, barde elfe\n\nComparé aux autres créatures de la nuit comme les katakans, les nosferatus ou les loups - garous, le spectre de minuit(et son cousin le spectre du couchant) semble presque inoffensif.Après tout, quel danger pourrait bien représenter cette femme pâle et flétrie vêtue d'une robe en ambeaux ? Le dicton \"L'habit ne fais pas le moine\" prend ici tout son sens, car le spectre de minuit est si dangereux qu'il vaut mieux éviter à tout prix de couper à travers champs en pleine nuit.\n\nComme le spectre de midi, le spectre de minuit est une créature rurale.Ses victimes sont le plus souvent des voyageurs imprudents, mais la légende veut qu'il se glisse parfois dans les fermes pour tuer les paysans dans leur sommeil.\n\nLe spectre de minuit est immatériel, mais devient tangible pendant un très cours instant lorsqu'il frappe son adversaire. S'il est affaibli, il projette plusieurs images de lui - même pour entourer son ennemi et saper son énergie vitale.\n\nSous sa forme immatérielle, un spectre de minuit est très difficile à blesser.Pour le forcer à s'incarner physiquement, il faut l'immobiliser à l'aide du signe d'Yrden ou le toucher avec une bombe Poussière de lune.");
            SpectreDeMinuit.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Spectres/Spectre_de_minuit.png");
            SpectreDeMinuit.AddFaiblesse("Poussière de Lune", "Huile contre les Spectres", "Signe d'Yrden");
            SpectreDeMinuit.Creaturetype = SpectresEnum.SpectreDeMinuit;
            return SpectreDeMinuit;
        }

        private static Monstre Pesta()
        {
            Monstre Pesta = new Monstre("Spectres", "Vierge de la peste");
            Pesta.AddDescription("Les patients semblent pris d'hallucination collective. Ils parlent d'une femme couverte de croûtes et de furoncles et entourée de rats. Les visions persistent même après une forte dose de jusquiame noire et de pavot.\n- Notes de Joachim von Gratz, hôpital de Vilmerius de Novigrad\n\nDans les régions ravagées par la peste, un esprit apparaît sous la forme d'une femme aux chairs décomposées suivie d'une myriade de rats.Nul ne peut dire si ce spectre est à l'origine de la peste ou s'il est simplement attiré par la maladie comme un papillon par une flamme.Une chose est certaine, cependant: il aime infliger d'insupportables souffrances et se repaît des cris de douleurs de ses victimes.\n\nNombre de gens doutent de l'existence des vierges de la peste, aussi appelées pestas. On n'a recensé que deux témoignages concernant de telles créatures, chaque fois au cours d'une épidémie.\n\nComme son nom l'indique, la vierge de la peste apparaît toujours sous les traits d'une femme, sans que l'on sache vraiment pourquoi. A l'instar des autres spectres, elle semble liée aux puissantes émotions suscitées par une maladie longue et douloureuse.\n\nNul ne sait vraiment comment combattre une vierge de la peste, bien que l'on puisse penser qu'elle partage les faiblesses des autres spectres.Quoi qu'il en soit, elle représente un danger qu'il est impossible d'ignorer, même pour un sorceleur immunisé contre les miasmes néfastes qu'elle transporte.");
            Pesta.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Spectres/Pesta.png");
            Pesta.AddFaiblesse("Huile contre les Spectres", "Signe d'Yrden");
            Pesta.Creaturetype = SpectresEnum.Pesta;
            return Pesta;
        }

        #endregion

        #region Vampires

        private static Monstre Ekimme()
        {
            Monstre Ekimme = new Monstre("Vampires", "Ekimme");
            Ekimme.AddDescription("Pourquoi d'aurais peur des ekimmes ? C'est juste des grosses chauves-souris, non ?\n- Dernières paroles d'un garde anonyme\n\nComme tous les vampires et contrairement à la croyance populaire, l'ekimme n'est pas un mort - vivant.C'est une créature issus de la Conjonction qui ne craint ni l'ail, ni l'eau bénite, ni les symboles religieux.\n\nL'ekimme n'a pas ailleurs aucune similitude avec l'aristocrate livide des légendes mais, à l'instar du katakan et du nosferatu, ressemble plutôt à une énorme chauve - souris.Enfin, il ne suce pas le sang des jeunes vierges d'une tendre morsure, mais leur arrache la gorge de ses longues griffes avant de lécher leur sang à même le sol.\n\nLa cruauté de l'ekimme n'a d'égale que sa stupéfiante vitesse. Ses coups répétés peuvent détruire en quelques instants une armure en acier de Mahakam. Il est vulnérable aux lames en argent, mais sa faculté de régénération fait de lui un adversaire infatigable. Mieux vaut chercher une victoire rapide et décisive et, si possible, brûler le corps avant d'éparpiller les cendres aux quatre vents.");
            Ekimme.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vampires/Ekimme.png");
            Ekimme.AddFaiblesse("Vesse-de-loup du diable","Huile contre les Vampires","Signe d'Igni");
            Ekimme.Creaturetype = VampiresEnum.Ekimme;
            return Ekimme;
        }

        private static Monstre Gael()
        {
            Monstre Gael = new Monstre("Vampires", "Gaël");
            Gael.AddDescription("Morsure de vampire et forte odeur d'alcool.\n- Geralt de Riv\n\nContrairement à la croyance populaire, les monstres ne sont pas tous semblables.Ils possèdent tous un caractère, des préférences et des faiblesses propres.Ainsi, un certain katakan sévissant à Oxenfurt avait développé un goût inhabituel pour le sang chargé d'alcool des étudiants enivrés de la ville.\n\nLe vampire avait grandement profité de ce régime riche: il avait ainsi largement gagné en puissance et développé ses capacités de régénération.De plus, il disposait de griffes redoutables infligeant des hémorragies importantes, et comme si cela ne suffisait pas, pouvait se volatiliser et réapparaître dans le dos de sa proie.Fort heureusement, le signe de Queen offrait au sorceleur une défense de choix contre ce tour pendable, et le signe d'Yrden quant à lui, lui permettrait de piéger l'infâme créature.\n\nPour attirer le vampire, Geralt prit note de ses préférences alimentaires et chargea son sang d'une bonne dose de vinasse. Certes, il eut beaucoup plus de mal à ajuster ses coups, mais parvint néanmoins à vaincre la bête. La bataille du lendemain contre sa terrible gueule de bois fut en revanche plus difficile.");
            Gael.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vampires/Gael.png");
            Gael.AddFaiblesse("Poussière de lune","Vesse-de-loup du diable","Huile contre les Vampires","Signe d'Yrden","Signe d'Igni");
            Gael.Creaturetype = VampiresEnum.Gael;
            return Gael;
        }

        private static Monstre Katakan()
        {
            Monstre Katakan = new Monstre("Vampires", "Katakan");
            Katakan.AddDescription("Melitele, Mère toute-puissante, protège-nous du mal et de ses diaboliques serviteurs. Préserve-nous par-dessus tout des katakans et des nosferatus...\n\n- Extrait de prière\n\nLe katakan(ainsi que son redoutable cousin, le nosferatu), incarne l'essence même des peurs humaines. Il vit dans l'ombre.Il se nourrit de sang.Il ressemble à une gigantesque chauve - souris aux serres crochues.Pour couronner le tout, il peut devenir invisible, attendant patiemment que sa proie succombe à la terreur de son inéluctable attaque.");
            Katakan.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vampires/Katakan.png");
            Katakan.AddFaiblesse("Poussière de lune", "Vesse-de-loup du diable", "Huile contre les Vampires", "Signe d'Yrden", "Signe d'Igni");
            Katakan.Creaturetype = VampiresEnum.Katakan;
            return Katakan;
        }

        private static Monstre Sarasti()
        {
            Monstre Sarasti = new Monstre("Vampires", "Sarasti");
            Sarasti.AddDescription("En creusant, on est tombés sur une grande salle. Il y avait une bête endormie à l'intérieur... On a provoqué un éboulement, mais le monstre à réussi à s'en sortir...\n- Bytomir de Velen parlant de sa rencontre avec un ekimme\n\nPiller une tombe elfe est un excellent moyen de faire fortune...ou de trouver la mort.Les temples et les palais des Aen Seidhe regorgent en effet de trésors inestimables, mais abritent parfois en leur sein une abomination endormie.Tel était le cas de Méandres, où d'infortunés paysans réveillèrent par mégarde un ekimme particulièrement dangereux.\n\nAu premier coup d'oeil, le sorceleur comprit que le monstre n'abandonnerait pas facilement.Capable d'infliger de sévères hémorragies et de se volatiliser, le vampire était également doté de facultés de régénération. Toutefois le sorceleur savait comment coutourner ces désavantages: user des signes de Queen et d'Yrden tout en administrant des attaques puissantes.Et en évitant de se faire tuer, bien sûr.\n\nLe vampire avait déjà tué plusieurs paysans, ainsi qu'une patrouille de Nilfgaardiens lourdement armés, et il aurait sans doute fait de nombreuses autres victimes sans l'arrivée opportune de Geralt de Riv, le célèbre Loup Blanc.");
            Sarasti.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vampires/Sarasti.png");
            Sarasti.AddFaiblesse("Vesse-de-loup du diable","Huile contre les Vampires","Signe d'Igni");
            Sarasti.Creaturetype = VampiresEnum.Sarasti;
            return Sarasti;
        }

        private static Monstre VampireSupperieur()
        {
            Monstre VampireSupperieur = new Monstre("Vampires", "Vampire Suppérieur");
            VampireSupperieur.AddDescription("Les hommes, les plus polis en tout cas, disent de moi que je suis un monstre. Une bête assoiffée de sang.\n- Emiel Regis, vampire suppérieur\n\nLa soif de sang est probablement l'unique point commun entre le vampire suppérieur et ses cousins primitifs (ekimme, alpyre, katakan, etc.). En fait, le vampire suppérieur est plus proche de l'humain que de ces créatures sanguinaires, non seulement en termes d'apparence, mais également d'intelligence et de comportement.Il apprécie les villes, où il mène une vie normale sous bien des aspects.Même un sorceleur ne peut le reconnaître, car son médaillon ne réagit pas en présence d'un vampire suppérieur. En dépit de ces similitudes, une différence essentielle persiste: le vampire suppérieur est un être immortel. Ceux qui ont survécu à leur rencontre avec l'une de ces néfastes créatures se comptent sur les doigts d'une main.\n\nFort heureusement, les vampires suppérieurs sont rares et ne sont pas tous dangereux pour les humains.Ils aiment le sang, mais n'ont pas besoin d'en boire pour survivre.Certais d'entre eux ont même renoncé à boire du sang humain. Un sorceleur assez brave ou assez fou pour affronter un vampire suppérieur doit garder à l'esprit qu'il a devant lui un monstre doté d'une force surhumaine, et capable de manipuler les hommes et animaux, de devenir invisible et de se transformer en chauve - souris géante, un monstre presque impossible à tuer de surcroît.En d'autres termes, même un sorceleur expérimenté devrait y réfléchir à deux fois avant d'accepter un contrat sur l'une de ces créatures, quelle que soit la récompense.");
            VampireSupperieur.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vampires/Vampire_supperieur.png");
            VampireSupperieur.AddFaiblesse("Huile contre les Vampires", "Signe d'Igni");
            VampireSupperieur.Creaturetype = VampiresEnum.VampireSupperieur;
            return VampireSupperieur;
        }

        #endregion

        #region Vestiges

        private static Monstre Celicole()
        {
            Monstre Celicole = new Monstre("Vestiges", "Célicole");
            Celicole.AddDescription("Il y a quelques années encore, les terres sauvages foisonnaient d'esprits de la nature, mais aujourd'hui farfadets, buccas et lutins ont pour ainsi dire disparu. Ne parlons pas des célicoles, qui sont toujours les premières victimes de l'inexorable avancée de la civilisation.\n- Préface de l'ouvrage \"Le monde perdu\", par le professeur Dorregaray\n\nLe célicole(à ne pas confondre avec le lutin) est une créature des bois vivant dans les souches et les tarriers près des habitations humaines.Il ressemble en tout point à un enfant et, tel un enfant, est doté d'un esprit farceur. Un célicole veille de manière invisible sur les humains et les animaux vivant à proximité de sa tanière. Attiré par la joie et l'innocence, il apprécie tout naturellement la compagnie des enfants, seuls humains à qui il ose révéler sa présence.\n\nEn échange de ses services, il ne demande rien d'autre que le respect et une petite récompense sous forme de nourriture ou d'outils usés.En revanche, il déteste la grossièreté et l'ingratitude. Un célicole aime le calme et la sérénité. C'est pourquoi lorsqu'un village prend trop d'ampleur ou que ses habitants oublient les anciennes traditions, il abandonne son terrier et part vers d'autre horizons.");
            Celicole.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vestiges/Celicole.png");
            Celicole.AddFaiblesse();
            Celicole.Creaturetype = VestigesEnum.Célicole;
            return Celicole;
        }

        private static Monstre Doppler()
        {
            Monstre Doppler = new Monstre("Vestiges", "Doppler");
            Doppler.AddDescription("Votre colis ? Votre frère est déjà passé le prendre. C'est drôle, vous lui ressemblez comme deux gouttes d'eau... Hé, vous allez où comme ça ?!\n- Hanne Kluger, maître de relai\n\nUn doppler, aussi connu sous le nom de changelin, est une créature capable de prendre la forme de tout animal ou de toute créature humanoïde.Cette tranformation n'est pas une simple illusion, mais une authentique métamorphose. En conséquence, aucune amulette ou aucun médaillon de sorceleur ne peut révéler la présence d'un doppler, qui émet une aura en tout point identique à la créature imitée.Le doppler étant par ailleurs doté d'une remarquable intelligence, il pourrait sans difficulté se spécialiser dans le meurtre ou le vol s'il n'était par nature un être timide, généreux et pacifique.");
            Doppler.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vestiges/Doppler.png");
            Doppler.AddFaiblesse("Huile contre les Vestiges");
            Doppler.Creaturetype = VestigesEnum.Doppler;
            return Doppler;
        }

        private static Monstre EspritDeLaForet()
        {
            Monstre EspritDeLaForet = new Monstre("Vestiges", "Esprit de la forêt");
            EspritDeLaForet.AddDescription("Nous avons offensé l'esprit de la forêt, Sven, et il crie vengence. Il nous rappelle que nous avons tourné le dos à nos traditions.\n- Harald de Fayrlund\n\nCertains monstres sont si puissants que les populations locales se mettent à les vénérer comme des dieux.Il en allait ainsi avec le leshen dans les bois près du village de Fayrlund, sur l'archipel de Skellige. Les anciens étaient convaincus que le monstre veillait sur eux en les protégeant de leurs ennemis et en entraînant leurs chasseurs.\n\nLe sorceleur avait quelques doutes, cependant.Les leshens sont des créatures fourbes, n'agissant que par intérêt, et l'ancien leshen vivant dans les bois près de Fayrlund ne faisait sûrement pas exception.\n\nGeralt savait qu'il ne serait pas aisé de libérer les villageois de l'emprise de leur soi - disant protecteur, s'il tentait seulement de le faire. L'esprit de la forêt, comme le surnommaient les habitants, était si puissant qu'il avait maîtrisé l'art du marquage, grâce auquel il avait inséré son essence dans un des habitants de Fayrlund.Tant que ce malheureux resterait en vie et à proximité du village, le leshen renaîtrait toujours près de son antre.\n\nCependant, même en se débarassant de la personne marquée, tuer le leshen ne serait pas une mince affaire.Les créatures des bois étaient aux ordres du monstre, qui pouvait donc faire appel aux loups, aux corbeaux et même aux arbres pour l'aider. Heureusement, ce monstre avait aussi un point faible: une vulnérabilité au feu, notamment celui provoqué par le signe d'Igni.\n\nCependant, il n'y eut jamais d'affrontement entre Geralt et l'esprit de la forêt. Geralt savait que le leshen était sûrement moins bienveillant que ne le pensaient les anciens, mais il savait également qu'il ferait plus de mal que de bien en tuant la créature.");
            EspritDeLaForet.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vestiges/Esprit_de_la_foret.png");
            EspritDeLaForet.AddFaiblesse("Bombe au diméritium","Huile contre les Vestiges","Signe d'Igni");
            EspritDeLaForet.Creaturetype = VestigesEnum.EspritDeLaForet;
            return EspritDeLaForet;
        }

        private static Monstre Fiellon()
        {
            Monstre Fiellon = new Monstre("Vestiges", "Fiellon");
            Fiellon.AddDescription("Votre Grâce, j'ai le regret de vous informer que votre fils est tombé au combat lors d'une chasse au fiellon. Il est mort sur le coup, ainsi que son écuyer, son guide, ses rabatteurs, son entourage et ses chiens.\n\n- Kavin Jell, responsable du domaine de Villepin près de Wyzima\n\nUn fiellon est une montagne de muscles au sommet de laquelle trône une tête cornue à la gueule bardée de crocs.Tout comme son cousin le bukavac(plus rare), il vit dans les forêts humides et les marais.Il évite les humains si possible, mais en cas de confrontation, il les tue sans états d'âme... et sans la moindre difficulté.\n\nFiellon et bukavac sont si grands qu'ils peuvent tuer un cavalier en armure et sa monture d'un simple coup de patte.Ils sont par ailleurs insensibles au signe d'Aard, même les sorceleurs faisant des signes leur spécialité ne parviennent pas à les soulever d'un pouce.Enfin, ils régénèrent à vue d'oeil même les blessures les plus graves.\n\nPour couronner le tout, la force et l'endurance ne sont pas les seuls atouts du fiellon. Il possède un troisième oeil, situé au centre du front, grâce auquel il peut hypnotiser sa proie. Pour la malheureuse victime, cet oeil cerclé de flammes est bien souvent sa dernière vision.\n\nLa seule faiblesse du fiellon est sa peur des bruits puissants: les bombes Samum et Vesse - de - loup du diable sont ainsi salutaires face à ce monstre.Par ailleurs, une lame couverte d'huile contre les vestiges ouvre au sorceleur une perspective, sinon de victoire, au moins de survie.");
            Fiellon.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vestiges/Fiellon.png");
            Fiellon.AddFaiblesse("Samum","Vesse-de-loup du diable","Huile contre les Vestiges");
            Fiellon.Creaturetype = VestigesEnum.Fiellon;
            return Fiellon;
        }

        private static Monstre Hurleur2()
        {
            Monstre Hurleur = new Monstre("Vestiges", "Hurleur");
            Hurleur.AddDescription("Je viens pour le contrat. Vous savez à quel genre de monstre vous avez affaire ?\nNon, mais c'est sûr que c'est une sacrée bestiole.Il a tué toute une meute de loups...\n- Conversation entretenue à Valtilleul\n\nVelen est sans doute la région du monde où l'on retrouve la plus forte concentration de monstres. Corollaire inattendu de cette triste situation, les monstres sont souvent amenés à s'entretuer au cours de luttes territoriales.Ainsi, un tschart particulièrement agressif surnommé \"Hurleur\" massacra, au cours d'une rage meurtrière, une meute de loups et un fiellon pourtant bien plus imposant que lui.\n\nLe hurleur était un redoutable adversaire.Chacun de ses coups aurait suffi à tuer un homme.Seule une lourde armure ou l'utilisation d'un signe de Queen pourrait protéger efficacement son adversaire.Dans la mesure du possible, il allait falloir éviter ses charges et attaquer les flancs de la bête.\n\nGeralt tua le Hurleur sans trop de mal, mais l'élimination de ce monstre puissant aurait pu s'avérer impossible s'il n'avait été déjà considérablement affaibli par un combat contre d'autres créatures. La morale de cette histoire est que, lorsque deux monstres s'affrontent, le sorceleur est le vainqueur.");
            Hurleur.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vestiges/Hurleur.png");
            Hurleur.AddFaiblesse("Vesse-de-loup du diable","Huile contre les Vestiges");
            Hurleur.Creaturetype = VestigesEnum.Hurleur;
            return Hurleur;
        }

        private static Monstre Kernun()
        {
            Monstre Kernun = new Monstre("Vestiges", "Kernun");
            Kernun.AddDescription("On lui avait dit, à ce crétin, qu'une drôle de bestiole rôdait dans les bois, mais il a rien voulu entendre...\n- Louis Closster, bûcheron\n\nNovigrad, plus grande ville du monde, pinacle de la civilisation, preuve irréfutable de la domination de l'homme sur la nature... et pourtant, les étendues sauvages qui entourent la ville rappellent à quiconque s'y aventure que la nature est toujours prête à reprendre ses droits.\n\nParmi ces créatures rôdant dans cette verte contrée, un leshen, ancien et puissant, massacrait dans distinction les audacieux et les imprudents qui osaient pénétrer sur son territoire, avec une cruauté caractéristique: lacérations, empalements sur la végétation environnante, cadavres livrés en pâture aux loups...Sans sa vulnérabilité au feu, signe d'Igni compris, et la protection du signe de Queen, il y a fort à parier que même le sorceleur le plus aguerri n'en viendrait pas à bout.\n\nGeralt de Riv n'acheva de ce leshen qu'après un long combat épuisant.Après la mort du monstre, les bûcherons ne perdirent pas de temps pour se mettre à l'ouvrage et les bois reculent chaque jour un peu plus sous les coups de hache, signe qu'un jour peut - être, la civilisation humaine aura définitivement conquis la nature.");
            Kernun.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vestiges/Kernun.png");
            Kernun.AddFaiblesse("Bombe au diméritium","Huile contre les Vestiges","Signe d'Igni");
            Kernun.Creaturetype = VestigesEnum.Kernun;
            return Kernun;
        }

        private static Monstre Leshen()
        {
            Monstre Leshen = new Monstre("Vestiges", "Leshen");
            Leshen.AddDescription("On ne chasse jamais dans ces bois. Même si tout le village crève de faim.\n- Mulliver, échevin de Hoshberg, Bas - Aedirn\n\nLe leshen est une créature territoriale vivant au plus profond des forêts anciennes.Furtif et rusé, c'est un monstre solitaire qui contrôle par magie les plantes et les animaux de son territoire. Pour affronter un leshen, encore faut-il pouvoir l'approcher sans se faire repérer...Les plus vieux leshens, aussi appelés \"anciens\", sont de formidables adversaires même pour un sorceleur aguerri.");
            Leshen.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vestiges/Leshen.png");
            Leshen.AddFaiblesse("Bombe au diméritium", "Huile contre les Vestiges", "Signe d'Igni");
            Leshen.Creaturetype = VestigesEnum.Leshen;
            return Leshen;
        }

        private static Monstre Lutin()
        {
            Monstre Lutin = new Monstre("Vestiges", "Lutin");
            Lutin.AddDescription("Tu veux vraiment voir un sorceleur en colère ?\nEt toi ?\n-Conversation entretenue dans les rues de Novigrad\n\nLe lutin qui s'en prenait aux marchands de Novigrad était en fait un doppler. Ces créatures évitent généralement l'affrontement direct...et c'est plutôt une bonne chose, car un doppler acculé est un adversaire extrêmement dangereux. Combattre un doppler, c'est se combattre soi - même...ou, pour être plus précis, combattre un reflet doté des mêmes forces et des mêmes pouvoirs.Inutile de dire que la chance décide le plus souvent de l'issue du combat.\n\nGéralt, béni des dieux, parvint à vaincre son double et décida de lui laisser la vie sauve, jugeant ses actes nobles et justifiés.");
            Lutin.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vestiges/Lutin.png");
            Lutin.AddFaiblesse("Huile contre les Vestiges");
            Lutin.Creaturetype = VestigesEnum.Lutin;
            return Lutin;
        }

        private static Monstre Moire()
        {
            Monstre Moire = new Monstre("Vestiges", "Moire");
            Moire.AddDescription("\"Les soeurs Moires, la main dans la main, fléaux de terre et de mer, ainsi vont en rond, en rond.Trois tours pour toi, et trois pour moi, et trois de plus, pour faire neuf.\"\n- Macveth, Acte I, Scène 3\n\nIl existe de par le monde des créatures plus anciennes que les mages et leurs académies, plus anciennes que les humains, plus anciennes même que les elfes et les nains.Les Moires du marais de Torséchine font partie de ces créatures dont l'existence remonte à la nuit des temps. Nul ne connaît leur véritable nom, ni leur véritable nature.\n\nLes petites gens désignent les trois soeurs par les noms de Fuselle, Ambroise et Soupir, ou collectivement les \"Dames de la forêt\".Les Moires règnent sur Velen, dont elles protègent les habitants en échange d'une indéfectible loyauté. Leur puissante magie, qui trouve sa source dans l'eau et la terre, les lie irrémédiablement à leur territoire.Les Moires peuvent entendre tout ce qui se trame dans les bois, prédire l'avenir et modifier la destinée des humains comme bon leur semble.\n\nSelon toute vraisemblance, les Moires sembles immortelles.Des élixirs magiques leur permettent de conserver l'apparence de jeunes femmes et leur accordent une force et une vigueur surnaturelles.");
            Moire.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vestiges/Moire.png");
            Moire.AddFaiblesse("Huile contre les Vestiges", "Signe de Queen");
            Moire.Creaturetype = VestigesEnum.Moire;
            return Moire;
        }

        private static Monstre Morvudd()
        {
            Monstre Morvudd = new Monstre("Vestiges", "Morvudd");
            Morvudd.AddDescription("Il n'a mangé que des entrailles. Un gourmet.\n- Geralt de Riv\n\nUn dicton populaire affirme que sur Skellige, le moindre voyage est une aventure.Une aventure parfois mortelle, comme en atteste l'histoire d'un groupe d'insulaires en quête de gloire, parti à la recherche d'un trésor dans des ruines oubliées...qui s'avèrent être le terrain de chasse d'un puissant fiellon nommé Morvudd.\n\nLe sorceleur savait qu'il n'aurait pas droit à l'erreur durant son bras de fer avec la bête. Une seule seconde d'inattention permettrait à son adversaire de l'hypnotiser avec son troisième oeil, avant de le tailler en pièces. Morvudd était un spécimen imposant, aussi était-il permis de penser que les attaques rapides seraient innefficaces contre lui... et que ses coups terrasseraient l'aventurier imprudent qui aurait négligé d'utiliser une armure lourde ou le signe de Queen.\n\nMorvudd avait certes tué les guerriers de Skellige sans effort, mais il n'était pas de taille face au sorceleur. Il tenta même de sauver sa peau en s'enfuyant, mais cela ne fit que retarder l'inévitable et le sorceleur le pourfendit de sa lame en argent.");
            Morvudd.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vestiges/Morvudd.png");
            Morvudd.AddFaiblesse("Samum", "Vesse-de-loup du diable", "Huile contre les Vestiges");
            Morvudd.Creaturetype = VestigesEnum.Morvudd;
            return Morvudd;
        }

        private static Monstre Sylvain()
        {
            Monstre Sylvain = new Monstre("Vestiges", "Sylvain");
            Sylvain.AddDescription("Le sylvain est une créature cruelle et perfide. A tout prendre, je préfère cependant sa compagnie à celle d'un dh'oine.\n- Yaevinn, commandant Scoia'tael\n\nLe sylvain et le yaksha sont des créatures forestières extrêmement rares, mi - home mi - chèvre.Ni l'un, ni l'autre ne représente un réel danger, leurs rares contacts avec des humains se limitant à d'innocentes plaisanteries.");
            Sylvain.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vestiges/Sylvain.png");
            Sylvain.AddFaiblesse("Samum","Vesse-de-loup du diable","Huile contre les Vestiges","Signe d'Igni");
            Sylvain.Creaturetype = VestigesEnum.Sylvain;
            return Sylvain;
        }

        private static Monstre Tschart()
        {
            Monstre Tschart = new Monstre("Vestiges", "Tschart");
            Tschart.AddDescription("Le tschart est plus petit qu'un fiellon, c'est vrai... mais il est bien assez grand pour tuer quiconqui lui barre la route.\n- Agnès Chardon, herboriste de la forêt noire.\n\nLe tschart est apparenté au fiellon et au bukavac.Si son gabarit est moins imposant, il n'en demeure pas moins un adversaire dangereux, même pour un sorceleur expérimenté. Ce monstre des sombres forêts est sans conteste l'une des créatures les plus redoutables du monde connu.\n\nLe tschart est souvent confondu avec le sylvain et son nom évoque donc une créature humanoïde douée de parole, friande de choux et n'aimant rien plus que jouer des tours aux villageois. L'arrivée d'un véritable tschart dans une région met bien vite un terme à cette légende. Un tschart ne parle pas, il grogne. De plus, il se déplace à quatre pattes et, pour toute facétie, se contente de raser des villages entiers en dévorant tout ce qui s'y trouve, sans faire de distinction entre les choux, les poules, les cochons, les chiens et les humains.\n\nLe tschart n'est pas une créature subtile: au combat, il charge son adversaire pour le renverser, puis l'achève à coups de griffes et de crocs.En raison de sa taille et de sa posture quadrupède, il ne ressent quère les effets du signe d'Aard. Pour ne rien arranger, il est de plus doté d'une faculté de régénération assez stupéfiante.");
            Tschart.AddImage("pack://application:,,,/Bestiaire Witcher;component/img/Monstres/Vestiges/Tschart.png");
            Tschart.AddFaiblesse("Vesse-de-loup du diable","Huile contre les Vestiges");
            Tschart.Creaturetype = VestigesEnum.Tschart;
            return Tschart;
        }

        #endregion

        public static List<Monstre> InitListeMonstres()
        {
            List<Monstre> listeMonstres = new List<Monstre>
            {

                // Bêtes
                Chien(),
                Loup(),
                Ours(),

                // Hybrides
                Erynia(),
                Griffon(),
                Harpie(),
                Melusine(),
                Salma(),
                Sirene(),
                Succube(),

                // Maudits
                Berserker(),
                Couvin(),
                LoupGarou(),
                Ulfhedinn(),

                // Elémentaires
                Djinn(),
                Gargouille(),
                Golem(),
                FantomeRayons(),
                Molosse(),
                Therazane(),
                ElementaireFeu(),
                ElementaireGlace(),
                ElementaireTerre(),

                // Draconides
                Basilic(),
                Cocatrix(),
                Dragon_Fyresdal(),
                Foenard(),
                Hurleur(),
                Wyvern(),
                Wyvern_Royale(),

                // Insectoïdes
                Arachas(),
                ArachasCuirasse(),
                ArachasVenimeux(),
                BourdonEndriague(),
                EndriagueGuerriere(),
                EndriagueOuvriere(),
                Harrisi(),

                // Nécrophages
                Abaya(),
                Algoule(),
                Brumelin(),
                FourbeVeuve(),
                Goule(),
                GuenaudeAquatique(),
                GuenaudeSepulcrale(),
                IgnisFatuus(),
                Noyeur(),
                Putrefacteur(),

                // Orgoïdes
                Cyclope(),
                GeantGlace(),
                Hagubman(),
                Nekker(),
                TapeTapeur(),
                TrollGlace(),
                TrollPierre(),

                // Spectres

                Bleme(),
                DameBlanche(),
                DameDesBois(),
                DemonPresDuPuits(),
                Penitent(),
                Spectre(),
                SpectreDeMidi(),
                SpectreDeMinuit(),
                Pesta(),

                // Vampires
                Ekimme(),
                Gael(),
                Katakan(),
                Sarasti(),
                VampireSupperieur(),

                // Vestiges
                Celicole(),
                Doppler(),
                EspritDeLaForet(),
                Fiellon(),
                Hurleur2(),
                Kernun(),
                Leshen(),
                Lutin(),
                Moire(),
                Morvudd(),
                Sylvain(),
                Tschart()
            };

            return listeMonstres;
        }
    }
}