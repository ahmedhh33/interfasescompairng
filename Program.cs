namespace interfacees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(2);
            Square square2 = new Square(3);

        
            Console.WriteLine(square1.CompareTo(square2));// comparing the lenght of Two square so if lenght of square1>square two will return 1 and if it less will return-1 and if it = will return 0
        
        
        }

    }
}