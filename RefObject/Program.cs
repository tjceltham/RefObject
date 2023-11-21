namespace RefObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            House h = new House("Collins' House");
            UpdateHouse(ref h);
            h.PrintHouse();

        }

        // A reference to the reference that points to "Collins's house is changed
        // The reference can therefore be changed to reference "Manuell's Housae"
        // You rarely need to pass references to references
        // the use of ref in old AQA skeleton code is a mistake

        static void UpdateHouse(ref House h)
        {
            h = new House("Manuell's House");

        }
    }
}