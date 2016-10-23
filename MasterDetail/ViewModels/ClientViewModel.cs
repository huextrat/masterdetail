using MvvmSample.Views;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MasterDetail.ViewModels
{
    public enum SortEnum
    {
        Croissant,
    }

    public class ClientViewModel : BindableBase
    {
        string Link = Directory.GetCurrentDirectory() + "/../../Img/";
        string Link2 = Directory.GetCurrentDirectory() + "/../../Voice/";

        public ClientViewModel()
        {
            _champs = new ObservableCollection<Champ>();
            _sortCollection = new ObservableCollection<SortEnum>();
            _decoComand = new DelegateCommand(seDeco);

            InitializeList();

            InitializeSortList();
        }

        private ObservableCollection<Champ> _champs;
        public IEnumerable<Champ> Champs
        {
            get { return _champs; }
        }

        private ObservableCollection<SortEnum> _sortCollection;
        public IEnumerable<SortEnum> SortCollection
        {
            get { return _sortCollection; }
        }

        private SortEnum _selectedSort;
        public SortEnum SelectedSort
        {
            get { return _selectedSort; }
            set
            {
                _selectedSort = value;
                OnPropertyChanged(() => AscendingSortVisibility);;
            }
        }

        public Visibility AscendingSortVisibility
        {
            get { return SelectedSort == SortEnum.Croissant ? Visibility.Visible : Visibility.Hidden; }
        }

        private Champ _selectedChamp;
        public Champ SelectedChamp
        {
            get { return _selectedChamp; }
            set
            {
                _selectedChamp = value;
                OnPropertyChanged();
            }
        }

        #region Initialize Region

        private void InitializeSortList()
        {
            _sortCollection.Add(SortEnum.Croissant);
        }

        private void InitializeList()
        {
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Aatrox (Top)", new Uri(Link + "Aatrox.jpg", UriKind.Absolute), Link + "Aatrox_icon.png", "Top", @"Aatrox est un guerrier légendaire, 
l'un des cinq derniers survivants d'une race antique connue sous le nom de Darkin. Il porte sa large épée avec grâce et prestance, 
et se fraie un chemin dans les rangs ennemis dans un style hypnotisant. À chaque mort d'un adversaire, la lame d'Aatrox, 
frémissante de vie, semble s'abreuver de son sang. Aatrox en tire une puissance 
qui lui permet de poursuivre son élégant mais violent carnage.
Aatrox est présent dans les contes et légendes depuis aussi longtemps qu'il existe une trace de vie humaine. 
On parle par exemple d'une guerre oubliée entre deux grandes factions, le Protectorat et les Seigneurs mages. 
Suite à une vertigineuse série de victoires, les Seigneurs mages étaient sur le point d'annihiler leur ennemi héréditaire à jamais. 
Le jour de l'ultime confrontation, l'armée du Protectorat, inférieure en nombre, épuisée, mal équipée, s'apprêtait à l'inévitable défaite..

Tout espoir semblait perdu quand Aatrox apparut au milieu des rangs clairsemés du Protectorat. 
En quelques mots, il incita les soldats à lutter jusqu'à la dernière goutte de sang et se jeta lui-même dans la bataille. 
Sa présence fut une source d'inspiration pour les guerriers désespérés. Au début, ils se contentèrent de regarder bouche bée ce héros inconnu 
tailler et trancher l'ennemi, son corps et 
sa lame évoluant à l'unisson comme s'ils ne faisaient qu'un. Mais rapidement, les combattants se sentirent saisis par un puissant élan guerrier. 
Ils se jetèrent dans la mêlée à la suite d'Aatrox, chacun luttant comme dix, jusqu'à l'obtention d'un improbable triomphe.

Aatrox disparut après ce combat, mais la nouvelle fureur de l'armée du Protectorat, elle, perdura. Une série de victoires suivit celle-ci et 
les soldats du Protectorat finirent par 
rentrer chez eux triomphants. Ils furent accueillis comme des héros, mais bien qu'ils eussent sauvé leur civilisation de la destruction, les 
ténèbres s'étaient emparées de leur âme. 
Quelque chose, au tréfonds d'eux, avait changé. Peu à peu, leurs souvenirs héroïques des combats firent place à une terrible illumination : loin 
de se conduire en héros, ils avaient perpétré 
de leurs mains de terribles atrocités.

On retrouve des récits similaires dans les mythes de nombreuses cultures. S'il faut les croire, la présence d'Aatrox a changé le cours 
de quelques-uns des plus importants conflits de l'Histoire. 
Si ces récits présentent Aatrox comme le sauveur inattendu dans une période sombre, la vérité est qu'Aatrox a semé partout dans son sillage 
la guerre et les carnages.", new Uri("https://www.youtube.com/embed/0gvBGmwhOLU", UriKind.Absolute), new Uri(Link2 + "Aatrox.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Ahri (Mid)", new Uri(Link + "Ahri.jpg", UriKind.Absolute), Link + "Ahri_icon.png", "Mid", @"La campagne ionienne était en feu. 
Semblables à la lame cruelle d'un couteau de boucher, les soldats de Noxus ravageaient les terres sur leur passage, leur armure brillant 
d'un éclat sanglant dans le crépuscule. La lumière des temples dévorés par les flammes venait s'ajouter aux dernières lueurs du couchant, 
et l'écho de plusieurs cris d'angoisse se répercutait au loin.

Niché dans les contreforts du Mont Tevasa se trouvait un petit village abritant une centaine d'âmes, mais qui ne comptait aucun grand guerrier. 
Plusieurs familles de ce hameau décidèrent de fuir. Certaines se tournèrent vers la prière. D'autres encore étreignirent leurs proches en pleurant.
De leur côté, cinquante valeureux individus se préparèrent au combat.Ils nettoyèrent la saleté de leurs fourches et attachèrent des couteaux 
au bout de plusieurs manches à balai.

Une panique grandissante était lisible dans les yeux de chacun de ces combattants.Ils savaient parfaitement que la situation était sans espoir.
Alors que la poussière soulevée par les troupes de Noxus était déjà visible à l'horizon, il n'y avait plus grand chose à faire, sinon prier 
pour le pardon de leurs dieux.Les fils et filles de Ionia inspirèrent de grandes bouffées de l'air frais de la montagne, tournèrent leur regard 
vers les premières étoiles qui apparaissaient dans le ciel, et attendirent le massacre inéluctable qui allait survenir.", new Uri("https://www.youtube.com/embed/hlalkAUkwqE", UriKind.Absolute), new Uri(Link2 + "Ahri.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Akali (Mid)", new Uri(Link + "Akali.jpg", UriKind.Absolute), Link + "Akali_icon.png", "Mid", @"Il existe un ancien ordre originaire des îles Ioniennes qui est dévoué au maintien de l'équilibre. 
Ordre, chaos, lumière, ténèbres... Tout doit exister en parfaite harmonie, car c'est ainsi que fonctionne l'univers. 
Cet ordre s'appelle Kinkou, et il emploie trois guerriers de l'ombre pour servir sa cause à travers le monde. Akali est l'un de ces guerriers. 
C'est à elle qu'on confia la mission sacrée de la taille de l'arbre, d'éliminer ceux qui menacent l'équilibre de Valoran.

Experte en arts martiaux, Akali débuta son entraînement avec sa mère dès qu'elle fut capable de serrer les poings. 
Sa mère était acharnée et impitoyable, mais elle prônait ce principe fondamental : ""Nous faisons ce qui doit être fait."" 
Lorsque le Kinkou la fit rejoindre l'ordre à quatorze ans, elle était capable de couper une chaîne suspendue avec le tranchant de la main.
Il était dès lors évident qu'elle succèderait à sa mère au rôle de Poing des Ombres. Depuis, les nombreuses tâches qu'elle a accomplies 
peuvent être considérées comme moralement discutables, mais Akali estime qu'elle ne fait que suivre la doctrine inflexible de sa mère.", new Uri("https://www.youtube.com/embed/w8UjQ_hYfh4"), new Uri(Link2 + "Akali.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Alistar (Support)", new Uri(Link + "Alistar.jpg", UriKind.Absolute), Link + "Alistar_icon.png", "Support", @"Alistar est le plus puissant des guerriers nés dans les tribus de Minotaures de la Grande Barrière 
et il a protégé sa tribu contre les nombreux dangers de Valoran, jusqu'à l'arrivée de l'armée Noxienne. Alistar fut attiré loin de son village 
par les machinations de Keiran Darkwill, le benjamin du baron Darkwill, qui commandait la force expéditionnaire Noxienne. Lorsqu'Alistar rentra 
chez lui, il découvrit son village en cendres et sa famille massacrée. Écumant de rage, il chargea un régiment entier de troupes d'élite, 
les massacrant par centaines. Il fallut l'intervention des invocateurs les plus puissants de Noxus pour calmer sa rage. Ramené enchaîné à Noxus, 
Alistar passa les années suivantes dans une arène, à affronter des gladiateurs pour le plaisir des riches aristocrates de Noxus.
Son esprit de plus en plus souillé, Alistar aurait fini par perdre définitivement la raison si une jeune servante, Ayelia, ne s'était pas attachée 
à lui et avait organisé son évasion. Soudain libre, Alistar rejoignit le tout nouvel Institut de la Guerre pour y devenir Champion, 
dans l'espoir d'assouvir un jour sa vengeance contre Noxus et pour retrouver la jeune fille qui lui avait rendu espoir. Refusant au départ de 
reconnaître la célébrité qui accompagnait son statut de champion, Alistar découvrit rapidement qu'il était l'un des porte-parole de ceux que 
le gouvernement Noxien avait écrasés sous sa botte. Il révéla au grand jour des bavures que l'armée Noxienne aurait préféré oublier, ce qui le 
rendit peu populaire auprès de la noblesse de la cité-état. Son travail de transparence lui a valu plusieurs prix de philanthropie, 
des récompenses bien étonnantes quand on le voit déchaîner sa rage dans la League of Legends.", new Uri("https://www.youtube.com/embed/vzHrjOMfHPY"), new Uri(Link2 + "Alistar.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Amumu (Jungle)", new Uri(Link + "Amumu.jpg", UriKind.Absolute), Link + "Amumu_icon.png", "Jungle", @"Le yordle appelé Amumu est sans doute l'un des champions les plus étranges de la League of Legends. 
Sa vie avant qu'il rejoigne la League est un mystère, même pour Amumu. Tout ce dont ils se souvient, c'est de s'être réveillé seul dans une 
pyramide du Désert de Shurima. Il était enroulé dans des bandelettes et il ne sentait plus son cœur battre. Pour une raison inconnue, 
il ressentait une profonde tristesse; ses parents lui manquaient, mais il ne se rappelait pas qui ils étaient. Amumu s'effondra et se mit à 
pleurer dans ses bandelettes. Quoi qu'il fasse, il ne pouvait s'empêcher de pleurer et d'être triste. Il finit par se relever, prêt à explorer 
le monde entier pour découvrir son passé. Amumu arpenta toutes les routes du sud de Valoran, ce qui, en soi, représente déjà un exploit 
considérable.

Certes, Amumu n'avait pas beaucoup appris sur son passé, mais il avait compris qui il était devenu. Il était peut-être un mort-vivant, 
pourtant son apparence n'était pas du tout caractéristique des créatures que l'on désigne normalement sous ce terme. Il semblait également 
capable de tenir à distance les problèmes, car il avait pu traverser tout le sud de Valoran sans que rien ne lui arrive. Il était triste, 
tout simplement, et toutes les personnes, tous les êtres qu'il rencontrait dans son voyage partageaient sa tristesse. En fin de compte, 
il se dirigea vers le nord, franchit la Grande Barrière et atteignit l'Institut de la Guerre. Les invocateurs qu'il y rencontra furent fascinés 
par son histoire, à tel point qu'ils le convièrent à passer le jugement de la League. Grâce à son succès en tant que champion, 
il a finalement pu trouver ce qu'il cherchait depuis si longtemps: un foyer. Maintenant qu'il possède un présent, il souhait simplement 
que ses nouveaux amis l'aident à découvrir son passé.", new Uri("https://www.youtube.com/embed/vzHrjOMfHPY"), new Uri(Link2 + "Amumu.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Anivia (Mid)", new Uri(Link + "Anivia.jpg", UriKind.Absolute), Link + "Anivia_icon.png", "Mid", @"Anivia est un être issu du plus glacial hiver, une incarnation mystique de la magie du givre, un protecteur antique de Freljord. 
Elle commande à toute la puissance et à toute la fureur de la terre elle-même, elle invoque les rafales du blizzard pour défendre son foyer 
contre ceux qui l'attaquent. Créature bénéfique mais mystérieuse, Anivia est pour toujours vouée à veiller sur Freljord, dans la vie, 
la mort et la résurrection.
Anivia fait partie de Freljord, autant que le givre éternel. Bien avant que les mortels n'aient mis le pied sur la toundra glacée, 
elle avait déjà parcouru d'innombrables séries de vies et de morts. Le début et la fin de ces cycles éternels annonçaient toujours 
des changements majeurs, de la fin des tempêtes déchaînées au début d'une nouvelle ère de glaciation. On dit que lorsqu'un Cryophénix meurt, 
un monde meurt, et que quand il ressuscite, un monde nouveau commence.

Bien qu'Anivia ne se souvienne plus de ses vies anciennes, elle n'ignore rien de son but : elle doit protéger Freljord à n'importe quel prix.

La dernière fois qu'elle revint à la vie, Anivia vit l'émergence d'une puissante tribu humaine enfin unifiée. Elle la protégea avec fierté 
tandis qu'elle prospérait, mais une telle unité ne pouvait pas durer toujours. La grande tribu se scinda en trois et Anivia vit le peuple de 
Freljord se déchirer dans la guerre. Alors qu'elle tentait de calmer la violence qui meurtrissait ses terres, Anivia commença à percevoir une 
plus grande menace : un mal ancien en pleine renaissance dans les profondeurs de la terre. Horrifiée, elle sentit la magie pure de la glace 
corrompre et noircir. Comme le sang dans l'eau, les ténèbres se diffusaient dans Freljord. Sa destinée étant intimement liée à la terre, 
Anivia savait que si une puissance impie s'enracinait dans Freljord, elle finirait par gagner son propre cœur. Elle ne pouvait se contenter 
de demeurer un simple gardien. Le Cryophénix devait passer à l'acte.", new Uri("https://www.youtube.com/embed/8Syose1O568"), new Uri(Link2 + "Anivia.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Annie (Mid)", new Uri(Link + "Annie.jpg", UriKind.Absolute), Link + "Annie_icon.png", "Mid", @"Peu de temps avant les débuts de la League, certains dans la sinistre cité-état de Noxus 
restaient perplexes devant les sombres desseins du Haut Commandement Noxien. Ce dernier venait en effet de tenter de renverser l'autoproclamé 
héritier Raschallion, et les mesures les plus fermes étaient prises contre tous ceux qui s'opposaient au nouveau gouvernement. Les dissidents, 
connus sous le nom d'Ordre Gris, estimaient préférable de laisser leurs voisins en paix et de se concentrer sur les études des arcanes noirs. 
Ils décidèrent de s'installer au-delà de la Grande Barrière avec d'autres magiciens et intellectuels de Nox, dans les impitoyables Terres du 
Vaudou. Survivre ne fut pas toujours facile, mais les colons de l'Ordre Gris réussirent à prospérer là où tant d'autres auraient échoué.
Des années après l'exode, Gregori et Amoline eurent un enfant : Annie. Très vite, le couple comprit que leur fille était spéciale. 
Elle n'avait que deux ans quand elle parvint à ensorceler un ours de l'ombre, féroce habitant de la forêt pétrifiée située aux abords de 
la colonie, et à en faire son animal de compagnie. Encore aujourd'hui, elle conserve avec elle son ours Tibbers, le plus souvent ensorcelé 
dans une peluche qu'elle transporte comme un jouet. L'héritage ancestral d'Annie et son lieu de naissance lui ont conféré des pouvoirs 
incommensurables. À présent, elle fait partie des champions les plus appréciés de la League of Legends, et même Nox se l'arrache, 
bien que la cité-état aurait banni ses parents s'ils n'avaient pas fui.", new Uri("https://www.youtube.com/embed/vzHrjOMfHPY"), new Uri(Link2 + "Annie.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Ashe (Adc)", new Uri(Link + "Ashe.jpg", UriKind.Absolute), Link + "Ashe_icon.png", "Adc", @"À chaque nouvelle flèche tirée de son arc antique enchanté par la magie glace, 
Ashe prouve qu'elle est une archère hors pair. Elle choisit sa cible avec soin, attend le moment opportun, puis tire avec force et précision. 
C'est avec la même détermination qu'elle cherche à unir les tribus de tout Freljord pour former une nation suprême.

Enfant, Ashe était d'un tempérament rêveur. Elle s'émerveillait devant les imposantes forteresses abandonnées de ses ancêtres 
et restait des heures près du feu à écouter les légendes des anciens héros de Freljord. Sa préférée était celle d'Avarosa, 
la reine de ce Freljord d'antan, sublime et unifié. Même si sa mère la grondait à chaque fois qu'elle évoquait ce désir absurde, 
Ashe jura qu'un jour, elle unirait elle aussi les tribus dispersées de la toundra. Au fond d'elle-même, elle savait que si son peuple 
venait à se réunir comme autrefois, il atteindrait de nouveau l'excellence.

Alors qu'Ashe n'avait que quinze ans, sa mère fut tuée lorsqu'elle envoya sa tribu dans un raid insensé. Catapultée au rang de chef, 
Ashe prit la décision douloureuse de ne pas chercher vengeance, mais bien de concrétiser ses rêves d'enfant. Elle s'éleva vivement contre 
la soif de rétribution des siens et annonça que l'heure était venue d'oublier les querelles sanglantes pour conclure une paix durable. 
Certains de ses guerriers doutèrent de sa capacité à régner, au point de comploter pour tuer la jeune chef.", new Uri("https://www.youtube.com/embed/mSbMQ5xDnEg"), new Uri(Link2 + "Ashe.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Aurelion Sol (Mid)", new Uri(Link + "AurelionSol.jpg", UriKind.Absolute), Link + "AurelionSol_icon.png", "Mid", @"Réduit en esclavage par les targoniens, l'antique être céleste appelé Aurelion Sol a livré des guerres 
en leurs noms pendant des millénaires détruisant des planètes et de puissantes créatures dans tout l'univers.

Maintenant que leurs emprises se sont relâchées, il se rend à Runeterra pour se libérer et tuer ceux qui ont osé essayer de contrôler 
le forgeur d'étoile (lui).

Dans le jeu Aurelion Sol est un mage a moyenne portée qui inflige des dégâts constant avec ses étoiles en orbite avant de s'envoler 
pour aller ganker.", new Uri("https://www.youtube.com/embed/HM520graePQ"), new Uri(Link2 + "Aurelion_Sol.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Azir (Mid)", new Uri(Link + "Azir.jpg", UriKind.Absolute), Link + "Azir_icon.png", "Mid", @"Azir marcha le long de la rue dorée, le chemin des Empereurs. 
Les immenses statues de Shurima de premières règles, ses ancêtres, regardaient sa progression.

La douce, ombragée lumière de la pré-aurore s’engouffra dans sa cité. Les plus scintillantes des étoiles brillaient encore au dessus de lui, 
pourtant bientôt étouffées par le soleil levant. Le ciel nocturne ne ressemblait pas aux souvenir d’Azir; les étoiles et les constellations 
n’étaient plus alignées. Des millénaires étaient passés.

A chacun de ses pas, l’armure d’Azir résonnait avec une note de solitude, l’écho se propageant dans les rues vides de la capitale.

La dernière fois qu’il avait marché sur ce chemin, une haie d’honneur de 10.000 guerriers d’élite marchait dans son sillage, 
les acclamations de la foule secouant la cité. Cela devait être son moment de gloire, jusqu’à ce qu’on lui vole.

Maintenant, c’était une ville fantôme. Qu’étaient devenu son peuple ?

Avec une gestuelle impériale, Azir demanda au sable sur la route de s’élever, créant des statues vivante. C’était une vision du passé, 
l’écho de la forme donnée de Shurima.", new Uri("https://www.youtube.com/embed/zqH4AA-KEgQ"), new Uri(Link2 + "Azir.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Bard (Support)", new Uri(Link + "Bard.jpg", UriKind.Absolute), Link + "Bard_icon.png", "Support", @"Bard voyage à travers des royaumes inimaginables pour le commun des mortels. Certains des plus grands érudits de Valoran ont 
passé leur vie à tenter de comprendre les mystères qu'il incarne. Tout au long de l'Histoire de Valoran, cet esprit énigmatique fut connu 
sous divers noms, mais les surnoms tels que le Vagabond cosmique et le Grand gardien ne reflètent qu'une infime facette de son véritable but. 
Lorsque l'univers est menacé, Bard intervient pour le sauver de la destruction.", new Uri("https://www.youtube.com/embed/-tNDoXIYptk"), new Uri(Link2 + "Bard.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Blitzcrank (Support)", new Uri(Link + "Blitzcrank.jpg", UriKind.Absolute), Link + "Blitzcrank_icon.png", "Support", @"La ville de Zaun est un lieu où la magie comme la science sont devenues folles. Les expériences incontrôlées ont lourdement meurtri la ville. 
Pourtant, les restrictions plutôt molles de Zaun ont permis aux chercheurs et aux inventeurs de repousser les limites de la science 
plus vite qu'ailleurs, pour le meilleur et pour le pire. Grâce à cela, une équipe de doctorants de l'université de techmaturgie de Zaun 
a fait une avancée remarquable dans le domaine des automates animés par l'énergie de la vapeur. Leur création, le Golem de Vapeur Blitzcrank, 
a été développée pour porter assistance aux procédés de recyclage de Zaun, des procédés souvent trop dangereux pour être gérés directement 
pas des hommes. Bien vite, il fit montre de comportements imprévus.", new Uri("https://www.youtube.com/embed/WtmMC23DdT0"), new Uri(Link2 + "Blitzcrank.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Brand (Mid)", new Uri(Link + "Brand.jpg", UriKind.Absolute), Link + "Brand_icon.png", "Mid", @"En un lieu éloigné, connu sous le nom de Lokfar, vivait un marin au long cours du nom de Kegan Rodhe. Comme tous les membres de son peuple, Kegan et 
ses hommes allaient où le vent les portait, détroussant sans vergogne quiconque avait le malheur d'attirer leur attention. 
Aux yeux de certains, c'était un monstre, tandis que pour d'autres, ce n'était qu'un homme. Une nuit, alors qu'ils traversaient des eaux 
arctiques, d'étranges lumières furent aperçues en train de virevolter sur les étendues glacées. Elles étaient tellement époustouflantes 
que les marins furent attirées vers elles comme des papillons par la lumière d'une flamme. Après avoir traversé un désert de glace, 
ils parvinrent devant une grotte aux murs recouverts de runes antiques. La signification de ces runes était incompréhensible pour des marins 
pratiquement illettrés, mais Kegan ouvrit la voie. Là, dans une prison de glace parfaite, ils virent une colonne de flammes qui dansait. 
Il était incompréhensible, pour ne pas dire impossible, que quoi que ce soit puisse brûler en ces lieux. Mais ses mouvements gracieux étaient 
aussi captivants que le chant d'une sirène. Tandis que ses compagnons restaient abasourdis, Kegan se sentit obligé de tendre la main...", new Uri("https://www.youtube.com/embed/vvuAw6KNn2E"), new Uri(Link2 + "Brand.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Braum (Support)", new Uri(Link + "Braum.jpg", UriKind.Absolute), Link + "Braum_icon.png", "Support", @"''Veux-tu que je te raconte une histoire ?''

''Oh, grand-mère, je ne suis plus un bébé.''

''Il n'y a pas d'âge pour les histoires.''

À contrecœur, la petite fille se glisse sous ses draps en sachant qu'elle ne peut remporter cette bataille. Dehors, un vent glacial hurle et transforme les flocons en de petits diablotins tourbillonnants.

''Quel genre d'histoire veux-tu ? Un conte sur la Sorcière de glace, peut-être ?'' demande la grand-mère.

''Non, pas elle.''", new Uri("https://www.youtube.com/embed/ajUghBnxZQA"), new Uri(Link2 + "Braum.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Caitlyn (Adc)", new Uri(Link + "Caitlyn.jpg", UriKind.Absolute), Link + "Caitlyn_icon.png", "Adc", @"L'une des raisons pour lesquelles on surnomme Piltover la Cité du Progrès, c'est parce que le taux de criminalité y est extraordinairement bas. 
Mais cela n'a pas toujours été le cas; la cité-état était autrefois la cible privilégiée des brigands et voleurs en tout genre qui 
s'y livraient au pillage, principallement du fait des ressources de valeur qu'elle importe pour mener à bien ses recherches en techmaturgie. 
Certains prétendent qu'elle aurait sombré dans le chaos du crime organisé si Caitlyn, le Shérif de Piltover, n'avait pas été là. 
Fille d'un homme d'état fortuné et d'une pionnière dans le domaine de la recherche hextech, Caitlyn se découvrit un don naturel pour les 
enquêtes à l'âge de 14 ans, lorsque son père se fit agresser en rentrant chez lui. Ce soir-là, elle sortit en douce de leur demeure, armée 
du fusil de son père, et elle traqua les agresseurs. Au début, ses parents firent de leur mieux pour la décourager de faire des choses aussi 
dangereuses, mais elle était bien trop entêtée. Néanmoins, voulant absolument protéger sa fille, la mère de Caitlyn lui fabriqua des gadgets 
techmaturgiques pour pourvoir à ses besoins de fin limier.

Caitlyn gagna vite en notoriété, à la fois parce qu'elle triomphait seule du crime qui rongeait Piltover et parce qu'elle devenait une jeune 
femme de plus en plus ravissante. Elle ne reculait jamais devant la moindre affaire et elle était l'un des meilleurs tireurs de la cité-état. 
Un beau jour, Demacia fit appel à ses services et lui demanda de l'aider à retrouver un mystérieux hors-la-loi, qui commettait des cambriolages 
de grande envergure. Ce bandit, qui laissait toujours une carte ornée d'un C sur les lieux du crime, devint alors son ennemi juré. À ce jour, 
Caitlyn est encore à la recherche de ce monte-en-l'air, et sa traque la fait voyager dans tout Valoran. C'est pourquoi elle a décidé de rejoindre 
la League : pour parfaire ses compétences et obtenir l'influence qui lui manque afin de capturer la seule proie qui lui échappe encore et toujours.", new Uri("https://www.youtube.com/embed/KFNFY6-gaDA"), new Uri(Link2 + "Caitlyn.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Cassiopeia (Mid)", new Uri(Link + "Cassiopeia.jpg", UriKind.Absolute), Link + "Cassiopeia_icon.png", "Mid", @"La famille Du Couteau possède une longue histoire au service de Noxus et, de ses deux filles, 
Katarina a toujours été la plus connue et la plus célébrée. Le bonheur que les deux filles du Général Du Couteau lui donnent est tel qu'on dit 
souvent qu'il n'existe pas de soldat plus heureux. La plus jeune, Cassiopeia, n'avait pas l'instinct redoutable de sa sœur, 
mais elle le compensait par une élégance inégalée. Aussi belle que rusée, cette tentatrice ne se trouvait jamais bien loin des dignitaires 
étranges, quel que soir leur pays, pour leur arracher l'un ou l'autre secret du bout des lèvres. La campagne noxienne de pacification des 
barbares étant l'impasse, Cassiopeia porta son dévolu sur le diplomate d'une tribu de Freljord. Pensant trouver là une proie facile, 
la séductrice commença naturellement à le charmer. Il refusa cependant de se laisser tenter et la força de jurer sur son épée, une arme 
étrange à la lame ondoyante, qu'elle ne briserait jamais le secret.

Son rendez-vous galant accompli, Cassiopeia retourna auprès de son père et l'informa sur la résistance barbare. Alors qu'elle révélait ces 
informations, elle fut prise d'un violent spasme. Elle hurla de douleur alors que sa belle peau se changeait en écailles, sa chevelure soyeuse 
en cuir et ses ongle manucurés en griffes acérées. Sous le coup de la folie, elle se jeta sur un groupe de serviteurs terrifiés et arrache leurs 
membres en un éclair. Ce visage maculé de sang n'était désormais plus le joyau de Noxus, mais une créature épouventable à mi-chemin entre femme 
et serpent. Dépossédée de son statut, Cassiopeia se rendit auprès de la League pour continuer à servir Noxus sur les Champs de Justice.", new Uri("https://www.youtube.com/embed/neQNvEyuhPU"), new Uri(Link2 + "Cassiopeia.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Cho'Gath (Top)", new Uri(Link + "Cho'Gath.jpg", UriKind.Absolute), Link + "Cho'Gath_icon.png", "Top", @"Il existe un lieu entre les dimensions, entre les mondes. Certains l'appellent l'Extérieur, d'autres l'Inconnu. Pour les plus érudits, cependant, 
il s'agit du Néant. Malgré son nom, le Néant n'est pas vide ; il s'agit plutôt de la tanière de créatures innommables que l'esprit humain 
ne peut concevoir. Cho'Gath est une créature née du Néant, une chose si horrible que beaucoup préfèrent taire son nom. Ses semblables ont 
longtemps tenté de percer un trou dans les parois interdimensionnelles vers Runeterra, où ils pourraient offrir leur vision horrifique du 
paradis au monde entier. On les appelle les Néantins. Ces créatures anciennes sont si terribles qu'on préféra supprimer toute preuve de leur 
existence dans les livres d'Histoire. On dit que les Néantins commandent d'immenses armées de monstres ignobles et qu'ils furent jadis expulsés 
de Runeterra par une magie puissante mais aujourd'hui oubliée.", new Uri("https://www.youtube.com/embed/GJ8QI_7puvU"), new Uri(Link2 + "ChoGath.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Corki (Adc)", new Uri(Link + "Corki.jpg", UriKind.Absolute), Link + "Corki_icon.png", "Adc", @"Lorsqu'Heimerdinger et ses collègues yordles partirent à Piltover, ils se consacrèrent à la science sans restriction et apportèrent immédiatement 
une grande contribution aux progrès techmaturgiques. Les yordles sont petits, mais ils ont des idées. Corki, l'Artilleur Téméraire, 
obtint son titre en testant l'une de leurs inventions : la Machine Destructrice de Reconnaissance, un appareil d'assaut aérien devenu 
la colonne vertébrale des Forces Expéditionnaires de Bandle (FEB). Corki et son escadrille, les Serpents Volants, écumaient les cieux de Valoran, 
surveillant les environs et effectuant des acrobaties à la grande joie des spectateurs.", new Uri("https://www.youtube.com/embed/ABYix52iBj0"), new Uri(Link2 + "Corki.mp3", UriKind.Absolute)));
            //-----------------------------------------------------------------------------------------------------------------------------
            _champs.Add(new Champ("Darius (Top)", new Uri(Link + "Darius.jpg", UriKind.Absolute), Link + "Darius_icon.png", "Top", @"Il n'est pas de plus grand symbole de la puissance de Noxus que Darius, le guerrier le plus craint et le plus endurci de la nation. 
Orphelin de bonne heure, Darius dut combattre pour rester en vie et protéger son frère cadet. À l'âge de s'enrôler, 
il avait déjà la discipline et la force d'un vétéran. Darius éprouva pour la première fois sa détermination dans un combat crucial contre Demacia,
au cours duquel les forces de Noxus, épuisées, étaient submergées par l'ennemi. Le capitaine de Darius ordonna l'ordre de la retraite, 
mais Darius refusa. Il rompit la formation, marcha jusqu'à son supérieur et le décapita d'une parabole de sa hache gigantesque. 
Terrifiés mais revigorés, les soldats suivirent Darius au cœur du combat et combattirent avec une force et une ferveur renouvelées. Après une 
longue et terrible bataille, Noxus obtint finalement la victoire.", new Uri("https://www.youtube.com/embed/0M15wr-5O18"), new Uri(Link2 + "Darius.mp3", UriKind.Absolute)));

        }

        #endregion

        #region Deco Region
        private readonly DelegateCommand _decoComand;
        public ICommand Deco
        {
            get { return _decoComand; }
        }
        private void seDeco()
        {
            Environment.Exit(0);
        }
        #endregion
    }
}
