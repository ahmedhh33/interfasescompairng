namespace interfacees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(2);
            Square square2 = new Square(3);

        
            Console.WriteLine(square1.CompareTo(square2));// comparing the lenght of Two square so if lenght of square1>square two will return 1 and if it less will return-1 and if it = will return 0

            Console.WriteLine("priting using foreach");
            person[] Persons = new person[3];
            Persons[0] = new person("adf", "r34r", 423);
            Persons[1] = new person("wew", "3422r", 34);
            Persons[2] = new person("dew", "3453d", 31);

            foreach(person person in Persons)
            {
                Console.WriteLine(person.ToString());
                //Console.WriteLine();
                Console.WriteLine(person);//autherway without calling tostring
            }
        }

    }
}