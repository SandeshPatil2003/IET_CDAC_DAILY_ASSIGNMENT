namespace ObserverPattern
{
    public class OSFeatures
    {
        public void ShowLowBatteryWarning(int level)
        {
            Console.WriteLine($"[OS] Warning! Battery is at Level: {level}");
        }

        public void EnablePowerSavingsMode(int level)
        {
            Console.WriteLine($" [OS] Power saving Mode turned on!");
        }
    }
}