using AlxCourseHomework.MaterialsAssignments.Classes;
using AlxCourseHomework.MaterialsAssignments.Enums;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class Zadanie3ListaZakupow
    {
        public static void SprawdzmyListeZakupow()
        {
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("+++++LISTA ZAKUPOW+++++");
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("Sprawdzmy czy wzielismy wszystko z listy zakupow.");

            Console.WriteLine("Ile wziales sztuk chleba? ");
            var amountOfProductBread = Double.Parse(Console.ReadLine());
            Console.WriteLine("A ile kosztowal ten chleb? ");
            var costPerUnitBread = Double.Parse(Console.ReadLine());
            var chlebwKoszyku = new Zadanie3ProduktWKoszyku(Enums.Zadanie3ProduktywSkelpie.CHLEB, amountOfProductBread, costPerUnitBread);
            double costForProductMultipliedByUnitBread = chlebwKoszyku.SummaryOfCostofThisProduct;

            Console.WriteLine("Ile wziales litrow mleka? ");
            var amountOfProductMilk = Double.Parse(Console.ReadLine());
            Console.WriteLine("A ile kosztowal jeden karton? ");
            var costPerUnitMilk = Double.Parse(Console.ReadLine());
            var mlekowKoszyku = new Zadanie3ProduktWKoszyku(Enums.Zadanie3ProduktywSkelpie.MLEKO, amountOfProductMilk, costPerUnitMilk);
            double costForProductMultipliedByUnitMilk = chlebwKoszyku.SummaryOfCostofThisProduct;

            Console.WriteLine("Ile wziales kostek masla? ");
            var amountOfProductButter = Double.Parse(Console.ReadLine());
            Console.WriteLine("A ile kosztowala kostka? ");
            var costPerUnitButter = Double.Parse(Console.ReadLine());
            var maslowKoszyku = new Zadanie3ProduktWKoszyku(Enums.Zadanie3ProduktywSkelpie.MASLO, amountOfProductButter, costPerUnitButter);
            double costForProductMultipliedByUnitButter = maslowKoszyku.SummaryOfCostofThisProduct;

            Console.WriteLine("Ile wziales sera? ");
            var amountOfProductCheese = Double.Parse(Console.ReadLine());
            Console.WriteLine("A ile kosztowala kostka? ");
            var costPerUnitCheese = Double.Parse(Console.ReadLine());
            var serKoszyku = new Zadanie3ProduktWKoszyku(Enums.Zadanie3ProduktywSkelpie.SER, amountOfProductCheese, costPerUnitCheese);
            double costForProductMultipliedByUnitCheese = serKoszyku.SummaryOfCostofThisProduct;

            Console.WriteLine("Ile paczek szynki? ");
            var amountOfProductHam = Double.Parse(Console.ReadLine());
            Console.WriteLine("A ile kosztowala jedna paczka? ");
            var costPerUnitHam = Double.Parse(Console.ReadLine());
            var szynkaKoszyku = new Zadanie3ProduktWKoszyku(Enums.Zadanie3ProduktywSkelpie.SZYNKA, amountOfProductHam, costPerUnitHam);
            double costForProductMultipliedByUnitHam = szynkaKoszyku.SummaryOfCostofThisProduct;

            Console.WriteLine("No to sprawdzmy czy lapiesz sie na rabat!");
            double sumaCalkowitaProduktowwKoszyku = costForProductMultipliedByUnitBread + costForProductMultipliedByUnitButter +
                costForProductMultipliedByUnitCheese + costForProductMultipliedByUnitHam + costForProductMultipliedByUnitMilk;
            Console.WriteLine($"Wszystko bedzie cie kosztowac: {sumaCalkowitaProduktowwKoszyku}");

            if (sumaCalkowitaProduktowwKoszyku < 60)
            {
                Console.WriteLine("*** RABATU NIE PRZYDZIELONO ***");
            }
            else if (sumaCalkowitaProduktowwKoszyku < 100)
            {
                double sumaPoRabacie = sumaCalkowitaProduktowwKoszyku * 0.95;
                Console.WriteLine("*** Przydzielono rabat 5% ***");
                Console.WriteLine($"Kwota do zaplaty: {sumaPoRabacie}");
            }
            else if (sumaCalkowitaProduktowwKoszyku > 100)
            {
                double sumaPoRabacie = sumaCalkowitaProduktowwKoszyku * 0.85;
                Console.WriteLine("*** Przydzielono rabat 15% ***");
                Console.WriteLine($"Kwota do zaplaty: {sumaPoRabacie}");
            }
        }
    }
}
