namespace CSharpAssessmentWeek2
{
    public class Discount
    {
        public string? Name { get; set; }
        public double Amount { get; set; }
        public List<Cart> Carts { get; set; }
        public Discount(List<Cart> carts)
        {
            Carts = carts;
        }
        public double Calculate()
        {
            Name = "None";
            Amount = 0.0;
            foreach (var cart in Carts)
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour >= 7
                    || DateTime.Now.Hour <= 9)
                {
                    Name = "MarvelousMonday";
                    Amount = 0.1;
                    break;
                }
                else if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday && Carts.Count >= 5)
                {
                    Name = "WednesdaySpecial";
                    Amount = 0.5;
                    break;
                }
                else if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour >= 7
                    || DateTime.Now.Hour <= 9 && cart.Items.ToList().FirstOrDefault(item => item.Name == "Cappucino").Name == "Cappucino")
                {
                    Name = "FabulousFriday";
                    Amount = 2.0;
                    break;
                }
            }
            return Amount;
        }
    }
}