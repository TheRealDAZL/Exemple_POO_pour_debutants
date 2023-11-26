using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Espace de noms que j'ai nommé MonProjet
namespace MonProjet
{
    // Classe internal static class MaClasseStatique
    internal static class MaClasseStatique
    {
        // Méthode public static void AffichageDuMessage2, qui ne retourne pas de valeur (void)
        public static void AffichageDuMessage2(string msgNormal2)
        {
            // Afficher le message
            Console.WriteLine(msgNormal2);
        }

        // Méthode public static int EntreeDeNombre2, avec un retour de nombre entier (int)
        public static int EntreeDeNombre2(string msgErreur3, string msgErreur4)
        {
            // Déclarer, puis initialiser la variable nbr avec la valeur 0
            int nbr2 = 0;

            // Tant que la valeur de nbr est 0, répéter la boucle suivante
            while (nbr2 == 0)
            {
                // Essayer le code suivant, tant qu'on ne rencontre pas d'erreur
                try
                {
                    // Changer la valeur de nbr pour la valeur entrée dans la console
                    nbr2 = int.Parse(Console.ReadLine());

                    // Si la valeur de nbr est de 0, afficher le message
                    if (nbr2 == 0)
                    {
                        Console.WriteLine(msgErreur3);
                    }
                }

                // Si on rencontre une erreur de format, afficher le message
                catch (FormatException)
                {
                    Console.WriteLine(msgErreur3);
                }

                // Si on rencontre une erreur d'overflow, afficher le message
                catch (System.OverflowException)
                {
                    Console.WriteLine(msgErreur4);
                }
            }

            // Retourner la valeur de nbr
            return nbr2;
        }

        // Méthode public static void AffichageDuTexte2, qui ne retourne pas de valeur (void)
        public static void AffichageDuTexte2(string msgNormal2, int nbr2)
        {
            // Afficher le message
            Console.WriteLine(msgNormal2);

            // Afficher le nombre
            Console.WriteLine(nbr2);
        }
    }
}
