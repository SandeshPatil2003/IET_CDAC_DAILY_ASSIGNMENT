namespace InterfaceFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstInterface i = new FirstInterfaceImpl();


           Console.WriteLine( i.getMessage());
        }
    }
}
