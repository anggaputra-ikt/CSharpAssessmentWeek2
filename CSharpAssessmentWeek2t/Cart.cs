namespace CSharpAssessmentWeek2
{
    public class Cart
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public List<Item>? Items { get; set; }
        public Cart()
        {
            Items = new () {
                new ()
                {
                    Id = 1,
                    Name = "Americano",
                    Description = "A classic coffe coiche with a bold flavour.",
                    Category = "Coffee",
                    Price = 30000,
                },
                new ()
                {
                    Id = 2,
                    Name = "Espresso",
                    Description = "A strong and concentrated coffee shot.",
                    Category = "Coffee",
                    Price = 20000,
                },
                new ()
                {
                    Id = 3,
                    Name = "Double Espresso",
                    Description = "two shots of intense esporesso.",
                    Category = "Coffee",
                    Price = 35000,
                },
                new ()
                {
                    Id = 4,
                    Name = "Latte",
                    Description = "Creamy espresso with steamed milk.",
                    Category = "Coffee",
                    Price = 42000,
                },
                new ()
                {
                    Id = 5,
                    Name = "Macchiato",
                    Description = "Espresso with a dollop of foamed milk.",
                    Category = "Coffee",
                    Price = 45000,
                },
                new ()
                {
                    Id = 6,
                    Name = "Mocha",
                    Description = "Rich chocolate and espresso blend.",
                    Category = "Coffee",
                    Price = 45000,
                },
                new ()
                {
                    Id = 7,
                    Name = "Cappuccino",
                    Description = "Espresso topped with equal parts steamed milk and foam.",
                    Category = "Coffee",
                    Price = 30000,
                },
                new ()
                {
                    Id = 8,
                    Name = "French Fries",
                    Description = "Crispy and golden potato fries.",
                    Category = "Snack",
                    Price = 35,
                },
                new ()
                {
                    Id = 9,
                    Name = "Burger",
                    Description = "A juicy and flavourful burger with all the fixings.",
                    Category = "Snack",
                    Price = 40000,
                },
            };
        }
    }
}