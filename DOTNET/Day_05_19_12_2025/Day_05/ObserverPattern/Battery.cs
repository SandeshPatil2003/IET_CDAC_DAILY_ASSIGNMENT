
namespace ObserverPattern
{
    public class Battery
    {
        public event BatteryHandler OnLevelChanged;
        public void UpdateLevel(int newLevel)
        {
            Console.WriteLine($"\n Hardware: Battery is Now {newLevel}% ");

            OnLevelChanged(newLevel);
        }
    }
}