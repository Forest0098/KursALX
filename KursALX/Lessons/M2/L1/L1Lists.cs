namespace KursALX.Lessons.M2.L1
{
    public class L1Lists
    {
        public static void Run()
        {
            List<string> shoppingList = new List<string>();
            shoppingList.Add("milk");
            ShowList(shoppingList);
            shoppingList.Add("butter");
            ShowList(shoppingList);
            shoppingList.Add("papaya");
            ShowList(shoppingList);
            shoppingList.Add("bread");
            ShowList(shoppingList);
            shoppingList.Add("tomato sauce");
            ShowList(shoppingList);
            shoppingList.Add("apple juice");
            ShowList(shoppingList);


            shoppingList.Remove("apple juice");
            ShowList(shoppingList);
            shoppingList.Remove("milk");
            ShowList(shoppingList);            
            shoppingList.Remove("juice");
            ShowList(shoppingList);
            shoppingList.Remove("bread");
            ShowList(shoppingList);            
            shoppingList.Remove("papaya");
            ShowList(shoppingList);
            shoppingList.Remove("tomato sauce");
            ShowList(shoppingList);
        }

        public static void ShowList(List<string> list)
        {
            Console.WriteLine($"Number of elements: {list.Count}");
            foreach (string item in list)
            { 
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
