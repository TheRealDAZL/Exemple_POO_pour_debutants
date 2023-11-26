using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Espace de noms que j'ai nommé MonProjet
namespace MonProjet
{
    // Classe internal class MaClasseNonStatique
    internal class MaClasseNonStatique
    {
        // Attributs de l'objet, soit 2 private string[] qui contiennent 2 strings chaque
        private string[] MESSAGES_NORMAUX_3 { get; set;} = new string[2];
        private string[] MESSAGES_DERREUR_3 { get; set;} = new string[2];



        // Constructeur public MaClasseNonStatique(), sans argument
        public MaClasseNonStatique()
        {
            // Initialiser tous les éléments des 2 string[] avec les valeurs données
            MESSAGES_NORMAUX_3[0] = "Entrez un nombre entier à afficher. Ce nombre doit être différent de 0 :";
            MESSAGES_NORMAUX_3[1] = "Le nombre qui a été entré puis validé est :";
            MESSAGES_DERREUR_3[0] = "Cette entrée n'est pas valide. Entrez un nombre entier différent de 0 :";
            MESSAGES_DERREUR_3[1] = "Ce nombre est trop large. Entrez un nombre de -2147483648 (Int32.MinValue) à 2147483647 (Int32.MaxValue) :";
        }



        //  Méthode public void AffichageDuMessage3, qui ne retourne pas de valeur (void) et qui ne prend pas d'argument
        public void AffichageDuMessage3()
        {
            // Afficher le message
            Console.WriteLine(MESSAGES_NORMAUX_3[0]);
        }

        // Méthode public int EntreeDeNombre3, qui retourne un nombre entier (int) et qui ne prend pas d'argument
        public int EntreeDeNombre3()
        {
            // Déclarer, puis initialiser la variable nbr3 avec la valeur 0
            int nbr3 = 0;

            // Tant que la valeur de nbr3 est 0, répéter la boucle suivante
            while (nbr3 == 0)
            {
                // Essayer le code suivant, tant qu'on ne rencontre pas d'erreur
                try
                {
                    // Changer la valeur de nbr3 pour la valeur entrée dans la console
                    nbr3 = int.Parse(Console.ReadLine());

                    // Si la valeur de nbr3 est de 0, afficher le message
                    if (nbr3 == 0)
                    {
                        Console.WriteLine(MESSAGES_DERREUR_3[0]);
                    }
                }

                // Si on rencontre une erreur de format, afficher le message
                catch (FormatException)
                {
                    Console.WriteLine(MESSAGES_DERREUR_3[0]);
                }

                // Si on rencontre une erreur d'overflow, afficher le message
                catch (System.OverflowException)
                {
                    Console.WriteLine(MESSAGES_DERREUR_3[1]);
                }
            }

            // Retourner la valeur de nbr3
            return nbr3;
        }

        // Méthode public void AffichageDuTexte3, qui ne retourne pas de valeur (void) et qui prend un argument nbr3 de type int
        public void AffichageDuTexte3(int nbr3)
        {
            // Afficher le message
            Console.WriteLine(MESSAGES_NORMAUX_3[1]);

            // Afficher le nombre
            Console.WriteLine(nbr3);
        }
    }
}
