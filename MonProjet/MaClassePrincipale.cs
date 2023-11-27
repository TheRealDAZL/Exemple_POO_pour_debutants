/* INTRODUCTION À LA STRUCTURE GÉNÉRALE D'UN PROGRAMME C# */
// Référence : https://learn.microsoft.com/fr-ca/dotnet/csharp/fundamentals/program-structure/
// Les programmes C# se composent d’un ou plusieurs fichiers. Chaque fichier contient zéro ou
// plusieurs espaces de noms. Un espace de noms contient des types tels que des classes, des
// structs, des interfaces, des énumérations et des délégués, ou d’autres espaces de noms.
/* INTRODUCTION À LA STRUCTURE GÉNÉRALE D'UN PROGRAMME C# */



/* INTRODUCTION AUX ESPACES DE NOMS */
// Référence : https://learn.microsoft.com/fr-ca/dotnet/csharp/language-reference/keywords/namespace
// Le mot clé namespace est utilisé pour déclarer une portée qui contient un ensemble d’objets connexes.
// Vous pouvez utiliser un espace de noms pour organiser les éléments de code et créer des types globaux uniques.
/* INTRODUCTION AUX ESPACES DE NOMS */

/* Dans Visual Studio, lorsque l'on crée un nouveau projet, on crée un nouvel espace de noms (namespace) */

/* Espace de noms que j'ai nommé MonProjet */
namespace MonProjet
{
    /* INTRODUCTION AUX CLASSES */
    // Référence : https://learn.microsoft.com/fr-ca/dotnet/csharp/fundamentals/types/classes
    // Un type défini comme class est un type référence. Au moment de l’exécution, quand vous déclarez une
    // variable de type référence, celle-ci contient la valeur null tant que vous n’avez pas explicitement
    // créé une instance de la classe à l’aide de l’opérateur new, ou que vous ne lui avez pas assigné un
    // objet existant d’un type compatible [...].
    // Quand l’objet est créé, une quantité de mémoire suffisante est allouée sur le tas managé de l’objet
    // spécifié, et la variable contient uniquement une référence à l’emplacement de cet objet. La mémoire
    // utilisée par un objet est récupérée par la fonctionnalité de gestion automatique de la mémoire du CLR,
    // appelée garbage collection.
    /* INTRODUCTION AUX CLASSES */

    /* Classe que j'ai nommée MaClassePrincipale */
    class MaClassePrincipale
    {
        /* INTRODUCTION À LA MÉTHODE STATIQUE MAIN() ET AUX ARGUMENTS DE LIGNE DE COMMANDE */
        // Référence : https://learn.microsoft.com/fr-ca/dotnet/csharp/fundamentals/program-structure/main-command-line
        // La méthode Main est le point d’entrée d’une application C#. Lorsque l'application est démarrée, la méthode
        // Main est la première méthode appelée.
        // Note -> Les bibliothèques et les services ne nécessitent pas de méthode Main comme point d'entrée.

        // Il ne peut y avoir qu'un seul point d’entrée dans un programme C#. Si plusieurs classes ont une
        // méthode Main, vous devez compiler votre programme avec l'option de compilateur StartupObject pour
        // spécifier quelle méthode Main utiliser comme point d'entrée.
        /* INTRODUCTION À LA MÉTHODE STATIQUE MAIN() ET AUX ARGUMENTS DE LIGNE DE COMMANDE */

        /* Méthode statique Main(string[] arguments) */
        // Içi, j'ai défini la méthode pour qu'elle ne retourne aucune valeur, et pour qu'elle prenne des string[]
        // comme arguments. J'ai nommée la variable string[] arguments, pour plus de simplicité.
        // Cependant, la méthode Main peut être définie autrement, on peut définir les arguments et les valeurs
        // de retour différemment. Consultez la documentation suivante pour plus d 'information :

        // Microsoft - Valeurs de retour Main()
        // https://learn.microsoft.com/fr-ca/dotnet/csharp/fundamentals/program-structure/main-command-line#main-return-values

        // Microsoft - Arguments de ligne de commande
        // https://learn.microsoft.com/fr-ca/dotnet/csharp/fundamentals/program-structure/main-command-line#command-line-arguments
        static void Main(string[] arguments)
        {
            // Voici les lignes de code qui seront traitées en exécutant la méthode Main, soit dès le début de l'exécution de
            // MonProjet. Les lignes de code suivantes seront traitées selon l'ordre dans lequel elles apparaissent

            /* DÉBUT DE LA MÉTHODE MAIN */

            // Afficher ce message
            Console.WriteLine("*** DÉBUT DE LA MÉTHODE MAIN ***");



            /* TECHNIQUE 1 : À L'AIDE DE LA MÉTHODE MAIN UNIQUEMENT */

            // Afficher ce message
            Console.WriteLine("\n\n*** TECHNIQUE 1 : À L'AIDE DE LA MÉTHODE MAIN UNIQUEMENT ***");

            // Déclarer et initialiser les string[] de messages prédéfinis
            string[] MESSAGES_NORMAUX = ["Entrez un nombre entier à afficher. Ce nombre doit être différent de 0 :",
                                         "Le nombre qui a été entré puis validé est :"];
            string[] MESSAGES_DERREUR = ["Cette entrée n'est pas valide. Entrez un nombre entier différent de 0 :",
                                         "Ce nombre est trop large. Entrez un nombre de -2147483648 (Int32.MinValue) " +
                                         "à 2147483647 (Int32.MaxValue) :"];

            // Afficher le 1er message prédéfini
            AffichageDuMessage(MESSAGES_NORMAUX[0]);

            // Déclarer, puis initialiser une variable int à partir de la valeur de retour de la méthode EntreeDeNombre
            int nombre = EntreeDeNombre(MESSAGES_DERREUR[0], MESSAGES_DERREUR[1]);

            // Afficher le 2ième message prédéfini et le nombre saisi précédement
            AffichageDuTexte(MESSAGES_NORMAUX[1], nombre);

            // Début de la déclaration des méthodes de la technique 1

            /* Méthode AffichageDuMessage, qui prend un string msgNormal comme argument et qui ne retourne pas de valeur (void) */
            void AffichageDuMessage(string msgNormal)
            {
                // Afficher le message
                Console.WriteLine(msgNormal);
            }

            /* Méthode EntreeDeNombre, qui prend un string msgErreur1 et un string msgErreur2 comme argument, et qui retourne un nombre entier (int) */
            int EntreeDeNombre(string msgErreur1, string msgErreur2)
            {
                // Déclarer, puis initialiser la variable nbr avec la valeur 0
                int nbr = 0;

                // Tant que la valeur de nbr est 0, répéter la boucle suivante
                while (nbr == 0)
                {
                    // Essayer le code suivant, tant qu'on ne rencontre pas d'erreur
                    try
                    {
                        // Changer la valeur de nbr pour la valeur entrée dans la console
                        nbr = int.Parse(Console.ReadLine());

                        // Si la valeur de nbr est de 0, afficher le message
                        if (nbr == 0)
                        {
                            Console.WriteLine(msgErreur1);
                        }
                    }

                    // Si on rencontre une erreur de format, afficher le message
                    catch (FormatException)
                    {
                        Console.WriteLine(msgErreur1);
                    }

                    // Si on rencontre une erreur d'overflow, afficher le message
                    catch (System.OverflowException)
                    {
                        Console.WriteLine(msgErreur2);
                    }
                }

                // Retourner la valeur de nbr
                return nbr;
            }

            /* Méthode AffichageDuTexte, qui prend un string msgNormal et un int nbr comme argument, et qui ne retourne pas de valeur (void) */
            void AffichageDuTexte(string msgNormal, int nbr)
            {
                // Afficher le message
                Console.WriteLine(msgNormal);

                // Afficher le nombre
                Console.WriteLine(nbr);
            }

            // Fin de la déclaration des méthodes de la technique 1

            /* TECHNIQUE 1 : À L'AIDE DE LA MÉTHODE MAIN UNIQUEMENT */



            /* TECHNIQUE 2 : À L'AIDE DE LA MÉTHODE MAIN ET D'UNE CLASSE STATIQUE */

            // Afficher ce message
            Console.WriteLine("\n\n*** TECHNIQUE 2 : À L'AIDE DE LA MÉTHODE MAIN ET D'UNE CLASSE STATIQUE ***");

            // Déclarer et initialiser les string[] de messages prédéfinis
            string[] MESSAGES_NORMAUX_2 = ["Entrez un nombre entier à afficher. Ce nombre doit être différent de 0 :",
                                           "Le nombre qui a été entré puis validé est :"];
            string[] MESSAGES_DERREUR_2 = ["Cette entrée n'est pas valide. Entrez un nombre entier différent de 0 :",
                                           "Ce nombre est trop large. Entrez un nombre de -2147483648 (Int32.MinValue) " +
                                           "à 2147483647 (Int32.MaxValue) :"];

            // Afficher le 1er message prédéfini
            MaClasseStatique.AffichageDuMessage2(MESSAGES_NORMAUX_2[0]);

            // Déclarer, puis initialiser une variable int à partir de la valeur de retour de la méthode EntreeDeNombre2
            int nombre2 = MaClasseStatique.EntreeDeNombre2(MESSAGES_DERREUR_2[0], MESSAGES_DERREUR_2[1]);

            // Afficher le 2ième message prédéfini, de même que le nombre saisi précédement
            MaClasseStatique.AffichageDuTexte2(MESSAGES_NORMAUX_2[1], nombre2);

            /* TECHNIQUE 2 : À L'AIDE DE LA MÉTHODE MAIN ET D'UNE CLASSE STATIQUE */



            /* TECHNIQUE 3 : À L'AIDE DE LA MÉTHODE MAIN ET D'UNE CLASSE NON-STATIQUE */

            // Afficher ce message
            Console.WriteLine("\n\n*** TECHNIQUE 3 : À L'AIDE DE LA MÉTHODE MAIN ET D'UNE CLASSE NON-STATIQUE ***");

            // Déclarer, puis instancier un objet de la classe MaClasseNonStatique
            MaClasseNonStatique objet = new MaClasseNonStatique();

            // Afficher le 1er message prédéfini
            objet.AffichageDuMessage3();

            // Déclarer, puis initialiser une variable int à partir de la valeur de retour de la méthode EntreeDeNombre3.
            // Prenez note que la méthode EntreeDeNombre3 ne prend pas d'argument
            int nombre3 = objet.EntreeDeNombre3();

            // Afficher le 2ième message prédéfini, de même que le nombre saisi précédement
            objet.AffichageDuTexte3(nombre3);

            /* TECHNIQUE 3 : À L'AIDE DE LA MÉTHODE MAIN ET D'UNE CLASSE NON-STATIQUE */



            // Afficher ce message
            Console.WriteLine("\n\n*** FIN DE LA MÉTHODE MAIN ***");

            /* FIN DE LA MÉTHODE MAIN */

        }
    }
}