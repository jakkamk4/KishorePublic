
namespace TestProject1
{
    public class ServiceLocator
    {
        public static LoggerManager LoggerManager = new LoggerManager();
        private static IServiceProvider _provider;

        public static void SetProvider(IServiceProvider provider)
        {
            _provider = provider;

            if (_provider == null)
            {
                LoggerManager.Log.Info("_provider Object is Null (In ServiceLocator.cs file -> SetProvider() Method).");
            }
            else
            {
                LoggerManager.Log.Info("_provider Object is Set (In ServiceLocator.cs file -> SetProvider() Method).  And the Provider Object is: " + _provider);
            }
        }

        public static T GetService<T>()
        {

            if (_provider == null)
            {
                LoggerManager.Log.Info("_provider Object is Null (In ServiceLocator.cs file -> GetProvider() Method).");
            }
            else
            {
                LoggerManager.Log.Info("_provider Object is Set (In ServiceLocator.cs file -> GetProvider() Method). And the Provider Object is:  " + _provider);
            }

            return (T)_provider.GetService(typeof(T));
        }
    }
}
