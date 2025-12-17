
namespace LoggingDemo
{
    public abstract class Database
    {
        protected abstract string DbName { get; }
        public void ExecuteDelete()
        {
            PerformDelete();    
            AppLogger.Instance.Log($"Record removed from {DbName}");
        }

        public void ExecuteInsert()
        {
            PerformInsert();
            AppLogger.Instance.Log($"Record added to {DbName}");
        }

        protected abstract void PerformInsert();
        protected abstract void PerformDelete();

    }
}