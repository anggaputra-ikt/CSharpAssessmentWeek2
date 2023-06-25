using CSharpAssessmentWeek2;

public class Order : List<Order>
{
	public string Name { get; set; }
	public bool DineIn { get; set; }
	public int Quantity { get; set; }
	public decimal Amount { get; set; }
	public Item? Item { get; set; }

	public Order(string name, bool dineIn)
	{
		Name = name;
		DineIn = dineIn;
	}

	/// <summary>
	/// Menambahkan item pesanan dan jumlah pesanan
	/// </summary>
	/// <param name="itemId"></param>
	/// <param name="quantity"></param>
	/// <returns></returns>
	public Order AddItem(int itemId, int quantity)
	{
		var items = new Item().GetAllItem();
		var checkItem = items.FirstOrDefault(item => item.Id == itemId);
		// Check if item id it's exist or not
		if (checkItem != null)
		{
			var checkOrder = this.FirstOrDefault(order => order.Item?.Id == itemId);
			if (checkOrder != null)
			{
				// Check if item it's already added with increase of total item in cart
				checkOrder.Quantity += quantity;
				checkOrder.Amount = quantity * checkItem.Price;
			}
			else
			{
				// If not exist add item in to cart with same order id
				var order = new Order(this.Name, this.DineIn)
				{
					Item = checkItem,
					Quantity = quantity,
					Amount = quantity * checkItem.Price
				};
				this.Add(order);
			}
		}
		return this;
	}

	public void Process()
	{
		var discount = new Discount(this);
		var tableService = this.TableService();
		var tableStatus = this.TableStatus();
		var taxService = 0.15;
		var sumAmount = this.Sum(order => order.Amount);
		var tableAmount = (double)sumAmount * tableService;
		var taxAmount = (double)sumAmount * taxService;
		var discountAmount = discount.Amount * (double)sumAmount;
		var totalOrder = sumAmount + (decimal)tableAmount + (decimal)taxAmount - (decimal)discountAmount;

		Console.WriteLine("~ Coffe In Aja ~");
		Console.WriteLine($"Customer: {this.Name}");
		foreach (var item in this)
		{
			Console.WriteLine($"{item?.Item?.Name} (Quantity: {item?.Quantity}) - Rp{item?.Item?.Price}");
		}
		if (discount.Amount > 0)
		{
			Console.WriteLine("Discount applied:");
			Console.WriteLine($"> {discount.Name} ({discount.Amount * 100}%) - Rp{discountAmount}");
		}
		Console.WriteLine("Table Service:");
		Console.WriteLine($"> {tableStatus} - Rp{tableAmount} ({tableService * 100}%)");
		Console.WriteLine($"Tax Services: Rp{taxAmount} ({taxService * 100}%)");
		Console.WriteLine($"Total order: Rp{totalOrder}");

	}

	double TableService()
	{
		if (this.DineIn == true)
		{
			return 0.15;
		}
		return 0.05;
	}

	string TableStatus()
	{
		if (this.DineIn == true)
		{
			return "Dine In";
		}
		return "Take Away";
	}
}
