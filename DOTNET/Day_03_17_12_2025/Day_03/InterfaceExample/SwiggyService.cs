namespace InterfaceExample
{
    internal class SwiggyService : IFoodDeliveryService
    {
        public void ConnectToProvider() => Console.WriteLine("[Service] Swiggy Connecting to Provider");

        public bool SubmitOrder(string orderDetails) => true;


        public string TrackDelivery(int orderId) => "Swiggy is 10 mins away";
    }
}