namespace TestProject1
{
    public class TestData<T>
    {
        public static LoggerManager LoggerManager = new LoggerManager();
        public static T LocationObject;

        static TestData()
        {
            LocationObject = LoadLocationObject<T>();
        }

        public static IEnumerable<object[]> GetLocationObject =>
            new List<object[]>
            {
                new object[] { LocationObject }
            };

        public static T LoadLocationObject<T>()
        {
            var locationObject = (T)Activator.CreateInstance(typeof(T), ServiceLocator.GetService<IEmployee>());
            if (locationObject == null)
            {
                LoggerManager.Log.Info("Location Object is Null (In TestData.cs file -> LoadLocationObject() method");
            }
            else
            {
                LoggerManager.Log.Info("Location Object is Created (In TestData.cs file -> LoadLocationObject() method. And the Location Object is: " + locationObject);
            }
            return locationObject;
        }
    }
}
