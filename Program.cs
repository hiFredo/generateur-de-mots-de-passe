using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using FormationCs;
using System.Linq.Expressions;

namespace generateurDeMotsDePasse
{
    internal class Program
    {

        static void Main(string[] args)
        {
            const int NBR_MOTS_DE_PASSE = 10;
            Console.WriteLine();
            int longeurMotsDePasse = Outils.DemandeNombrePositifNonNul("Longueur du mots de passe : ");


            Console.WriteLine();
            int choixAlphabet = Outils.DemanderNombreEntre(" Vous voulez un mots de passe avec :  \n " +
                  "1- Uniquement des caractères en minuscule  \n " +
                  "2- Des caractères en minuscule et majuscules \n " +
                  "3- Des caractères  et des chiffres \n " +
                  "4- Caractères ,  chiffres et caractères spéciaux  \n" +
                  " Votre choix : ", 1, 4);



            // 2 - alphabet "abcd1234"
            // 3 - comment choisir un caractère aléatoire

            string miniscule = "abcdefghijklmnopqrdtuvwxyz";
            string majuscucle = miniscule.ToUpper();
            string chiffre = "01233456789";
            string caractereSpeciaux = "#&!?";

            string alphabet;
            string motsDePasse = "";

            Random random = new Random();

            if (choixAlphabet == 1)
                alphabet = miniscule;
            else if (choixAlphabet == 2)
                alphabet = miniscule + majuscucle;
            else if (choixAlphabet == 3)
                alphabet = caractereSpeciaux + chiffre;
            else
                alphabet = miniscule + majuscucle + caractereSpeciaux + chiffre;

            int longueurAlphabet = alphabet.Length;


            for (int e = 0; NBR_MOTS_DE_PASSE > e; e++)

            {


                motsDePasse = "";

                // boucle longuerMotsDePasse

                int i = 0;
                for (i = 0; longeurMotsDePasse > i; i++)
                {

                    int index = random.Next(0, longueurAlphabet);

                    motsDePasse += alphabet[index];
                }

                Console.WriteLine("Mots de passe : " + motsDePasse);


            }

        }


        // 4 - generer le mot de passe
        // 5 - Améliorations : choix alphabet

    }
}

