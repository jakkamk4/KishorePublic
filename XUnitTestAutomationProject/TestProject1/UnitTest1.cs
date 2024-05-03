using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Xunit.Abstractions;

namespace TestProject1
{
    public class UnitTest1
    {
        public LoggerManager LoggerManager = new LoggerManager();
        public UnitTest1()
        {
                
        }

        [Theory]
        [MemberData(nameof(TestData<Location>.GetLocationObject), MemberType = typeof(TestData<Location>))]
        public void GetLocationOfTestEmployee(dynamic LocationObject)
        {
            if (LocationObject == null)
            {
                LoggerManager.Log.Info("Location Object is Null (In GetLocationOfTestEmployee Unit Test case)");
            }
            else
            {
                LoggerManager.Log.Info("Location Object is Set (In GetLocationOfTestEmployee Unit Test case). And the Location Object is: " + LocationObject);
                
                var locationOfTestEmployee = LocationObject.LocationNameOfEmployee;
                LoggerManager.Log.Info("Location Of Test Employee is " + locationOfTestEmployee);
            }
        }
    }
}