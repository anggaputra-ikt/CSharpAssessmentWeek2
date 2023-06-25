namespace CSharpAssessmentWeek2
{
	public class Discount
	{
		public string? Name { get; set; }
		public double Amount { get; set; }


		/// <summary>
		/// Menghitung diskon sesuai item yang dipesan
		/// </summary>
		/// <returns></returns>
		public Discount(Order orders)
		{
			Name = "None";
			Amount = 0.0;
			foreach (var order in orders)
			{
				if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour >= 7
					&& DateTime.Now.Hour <= 9)
				{
					Name = "MarvelousMonday";
					Amount = 0.1;
					break;
				}
				else if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday && orders.Count >= 5)
				{
					Name = "WednesdaySpecial";
					Amount = 0.05;
					break;
				}
				else if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour >= 7
					&& DateTime.Now.Hour <= 9 && order?.Item?.Name == "Cappucino")
				{
					Name = "FabulousFriday";
					Amount = 0.2;
					break;
				}
			}
		}
	}
}