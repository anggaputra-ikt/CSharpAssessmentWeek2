namespace CSharpAssessmentWeek2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new Product()
            {
                Name = "Americano",
                Category = "Coffee",
                Description = "Coffee Americano",
                Price = 30000
            };
            var order = new Order();
            order.AddOrderItem(product, 5);
        }
    }
}