namespace ObserverPattern
{

    public delegate void BatteryHandler(int level);
    internal class Program
    {
        static void Main(string[] args)
        {

            Battery laptopBattery = new Battery();
            OSFeatures windows = new OSFeatures();


            laptopBattery.OnLevelChanged += windows.ShowLowBatteryWarning;
            laptopBattery.OnLevelChanged += windows.EnablePowerSavingsMode;

            laptopBattery.UpdateLevel(20);

            laptopBattery.OnLevelChanged -= windows.EnablePowerSavingsMode;

            laptopBattery.UpdateLevel(10);

            
        }
    }
}
