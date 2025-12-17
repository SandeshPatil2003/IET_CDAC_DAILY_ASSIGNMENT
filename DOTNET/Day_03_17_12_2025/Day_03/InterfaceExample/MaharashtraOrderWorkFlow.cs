namespace InterfaceExample
{
    public class MaharashtraOrderWorkFlow : DeliveryWorkflow
    {
        protected override void ShowRegionalCompliance() => Console.WriteLine("Applying Maharashtra Tax Laws");
       
    }
}