namespace InterfaceExample
{
    internal class ZomatoService : IFoodDeliveryService
    {
        public void ConnectToProvider() => Console.WriteLine("[Service] Zomato is Connecting to Provider");
        public bool SubmitOrder(string orderDetails) => true;
        public string TrackDelivery(int orderId) => "Zomato is 10 mins away";
    }
}