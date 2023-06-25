namespace CSharpAssessmentWeek2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order("Angga", false);
            order.AddItem(1, 5);
            order.AddItem(2, 3);
			order.Process();
        }
    }
}