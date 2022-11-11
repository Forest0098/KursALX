using AlxCourseHomework.MaterialsAssignments.Classes;
using AlxCourseHomework.MaterialsAssignments.Enums;

namespace AlxCourseHomework.MaterialsAssignments.Classes
{
    public class Zadanie3ProduktWKoszyku
    {
        public Zadanie3ProduktywSkelpie ProductName;
        public double AmountOfProductInCart;
        public double ProductCostPerUnit;
        public double SummaryOfCostofThisProduct;

        public Zadanie3ProduktWKoszyku() { }

        public Zadanie3ProduktWKoszyku(Zadanie3ProduktywSkelpie productName, double amountOfProductInCart, double productCostPerUnit)
        {
            ProductName = productName;
            AmountOfProductInCart = amountOfProductInCart;
            ProductCostPerUnit = productCostPerUnit;
            SummaryOfCostofThisProduct = amountOfProductInCart * productCostPerUnit;
        }
    }
}
