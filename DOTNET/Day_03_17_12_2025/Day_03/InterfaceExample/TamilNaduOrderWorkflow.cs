namespace InterfaceExample
{
    public class TamilNaduOrderWorkflow : DeliveryWorkflow
    {
        protected override void ShowRegionalCompliance()
        => Console.WriteLine("Applying Tamil Nadu Tax Laws");
    }
}