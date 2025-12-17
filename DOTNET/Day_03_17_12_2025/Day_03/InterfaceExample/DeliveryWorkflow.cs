
namespace InterfaceExample
{
    public abstract class DeliveryWorkflow
    {


        private void LogActivity(string activity)
        {
            Console.WriteLine($" SYSTEM LOG -{DateTime.Now:t}:{activity}");
        }

        protected abstract void ShowRegionalCompliance();

        internal void ProcessOrderFlow(IFoodDeliveryService vendor, string order)
        {
            LogActivity("Intiating Process");

            vendor.ConnectToProvider();


            if(vendor.SubmitOrder(order))
            {
                LogActivity($"Order {order} sent successfully!");

                ShowRegionalCompliance();   
            }

            Console.WriteLine("Workflow Execution Complete");
        }
    }
}