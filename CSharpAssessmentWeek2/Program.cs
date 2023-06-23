namespace CSharpAssessmentWeek2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var carts = new List<Cart>();
            var items = new List<Item>() {
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
            Console.WriteLine("~ Welcome to CoffeeInAja ~");
            order_again:
            Console.Write("\nDaftar Menu\n");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id}. {item.Name}");
            }
            Console.WriteLine($"{items.Count + 1}. Proses Pesanan");
            Console.Write("\nPilih menu: ");
            var choose = int.Parse(Console.ReadLine());
            if (choose >= 1 && choose <= items.Count)
            {
                var checkCart = carts.FirstOrDefault(cart => cart.ItemId == choose);
                if (checkCart != null)
                {
                    checkCart.Quantity += 1;
                }
                else
                {
                    var itemCart = new Cart()
                    {
                        ItemId = choose,
                        Quantity = 1
                    };
                    carts.Add(itemCart);
                }
                goto order_again;
            }
            else if (choose == items.Count + 1)
            {
                Console.Clear();
                Console.WriteLine("~ CoffeeInAja ~");
                Console.WriteLine("Order Items:");
                decimal totalOrder = 0;
                foreach (var cart in carts)
                {
                    var item = cart.Items.FirstOrDefault(item => item.Id == cart.ItemId);
                    Console.WriteLine($"{item.Name} (Quantity: {cart.Quantity}) - Price: Rp{item.Price}");
                    totalOrder += cart.Quantity * item.Price;
                }

                Console.WriteLine($"Total Order Amount: {totalOrder}");
            }
        }
    }
}