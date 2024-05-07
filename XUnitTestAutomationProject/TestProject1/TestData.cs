using Microsoft.Extensions.DependencyInjection;

namespace TestProject1
{
    public class TestData<T>
    {
        public static LoggerManager LoggerManager = new LoggerManager();

        public static IEnumerable<object[]> GetLocationObject(IServiceProvider provider)
        {
            var locationObject = (T)Activator.CreateInstance(typeof(T), provider.GetService<IEmployee>());
            if (locationObject == null)
            {
                LoggerManager.Log.Info("Location Object is Null (In TestData.cs file -> LoadLocationObject() method");
            }
            else
            {
                LoggerManager.Log.Info(
                    "Location Object is Created (In TestData.cs file -> LoadLocationObject() method. And the Location Object is: " +
                    locationObject);
            }

            return new List<object[]>
            {
                new object[] { locationObject }
            };
        }
    }
}
