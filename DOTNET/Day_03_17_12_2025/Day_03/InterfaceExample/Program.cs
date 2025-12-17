namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" FOOD DISPATCHER");

            IFoodDeliveryService vendor = new SwiggyService();

            DeliveryWorkflow workflow = new MaharashtraOrderWorkFlow();

            Console.WriteLine("Executing Maharashtra Transaction ");


            workflow.ProcessOrderFlow(vendor, "Wada Pav");

            Console.WriteLine(vendor.TrackDelivery(201));


            Console.WriteLine("\n-----------------------------------\n");

            vendor = new ZomatoService();

            workflow = new TamilNaduOrderWorkflow();

            Console.WriteLine("Executing TamilNadu Transaction ");


            workflow.ProcessOrderFlow(vendor, "Idli Sambhar");

            Console.WriteLine(vendor.TrackDelivery(301));

        }
    }
}
