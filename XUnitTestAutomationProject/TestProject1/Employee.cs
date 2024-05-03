namespace TestProject1
{
    public class Employee : IEmployee
    {
        public string EmpName { get; set; }

        public Employee(ConfigData configData)
        {
            this.EmpName = configData.EmpName;
        }
    }
}
