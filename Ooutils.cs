using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCs
{
    static class Outils
    {


        public static int DemandeNombrePositifNonNul(string question)

        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR : Le nombre doit  etre positif et non null");

        }
        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonalise = null)
        {

            {

                int nombre = DemanderNombre(question);

                if (nombre >= min && nombre <= max)
                {
                    return nombre;

                }

                if (messageErreurPersonalise == null)

                {

                    Console.WriteLine("ERREUR : Veuille rentre un nombre entre " + min + " et " + max);
                }
                else
                {
                    Console.WriteLine(messageErreurPersonalise);
                }

                Console.WriteLine();

                return DemanderNombreEntre(question, min, max);
            }
        }

        public static int DemanderNombre(string question)
        {

            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("ERREUR : Veuille rentre un nombre .  ");

                }

            }

        }

    }
}