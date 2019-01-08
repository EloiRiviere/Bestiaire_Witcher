using Bestiaire.Monstres;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Bestiaire.Tests
{
    // Classe de tests d'utilisation de linq
    [TestClass]
    public class TesLinq
    {
        // LINK SKIP TAKE ToUpper
        [TestMethod]
        public void TestLinq()
        {
            List<Monstre> ListeMonstres = InitMonstres.InitListeMonstres();

            // Récupérer les 5 premiers monstres de ma liste
            IEnumerable<Monstre> IEMonstres = ListeMonstres.Take(5);
            // Récupérer 5 monstres à partir du 20°
            IEnumerable<Monstre> IEMonstres2 = ListeMonstres.Skip(20).Take(5);
            var monstre = IEMonstres2.First();
            monstre.Nom.ToLower();
            Debug.WriteLine(monstre);
        }

        // LINK WHERE
        // Retourne le nombre de Monstres qui ont 2 faiblesses

        [TestMethod]
        public void TestLinq2()
        {
            List<Monstre> ListeMonstres = InitMonstres.InitListeMonstres();
            IEnumerable<Monstre> IEMonstres = ListeMonstres.Where(x => TestFaiblesse(x));
            Debug.WriteLine(IEMonstres.Count());
        }

        private static bool TestFaiblesse(Monstre monstre)
        {
            return monstre.Faiblesse.Count() > 1 && monstre.Faiblesse.Count() < 3;
        }

        [TestMethod]
        public void TestLinq3()
        {
            List<Monstre> ListeMonstres = InitMonstres.InitListeMonstres();
            IEnumerable<int> moyenneFaiblesses = ListeMonstres.Select(monstre => monstre.Faiblesse.Count());
            foreach (int moyenne in moyenneFaiblesses)
            {
                Debug.WriteLine(moyenne);
            }
        }

        [TestMethod]
        public void TestLinq4()
        {
            List<Monstre> ListeMonstres = InitMonstres.InitListeMonstres();
            var IEMonstres = ListeMonstres
                .Where(monstre => monstre.Faiblesse.Count() > 1 && monstre.Faiblesse.Count() < 3)
                .Where(monstre => monstre.Nom.StartsWith("n", StringComparison.InvariantCultureIgnoreCase))
                .Select(monstre => monstre.Faiblesse.Count())
                .Sum();

            Debug.WriteLine(ListeMonstres);

        }

        // LINK RECHERCHE
        [TestMethod]
        public void TestLinq5()
        {
            String input = "j";
            List<Monstre> ListeMonstres = InitMonstres.InitListeMonstres();
            var Liste = ListeMonstres
            .Where(monstre => monstre.Nom.Contains(input) || monstre.Race.Contains(input));

            foreach (Monstre monstre in Liste)
            {
                Debug.WriteLine(monstre);
            }
        }
    }
}
