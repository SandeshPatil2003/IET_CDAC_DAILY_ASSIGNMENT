using System.Globalization;

namespace InterfaceExample
{
    public interface IFoodDeliveryService
    {

        void ConnectToProvider();
        bool SubmitOrder(string orderDetails);
        string TrackDelivery(int orderId);
    }
}