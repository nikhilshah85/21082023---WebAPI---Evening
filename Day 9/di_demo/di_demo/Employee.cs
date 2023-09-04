namespace di_demo
{
    public class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }

        static List<Employee> eList = new List<Employee>()
        {
            new Employee(){empNo=101, empName="Karan", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            new Employee(){empNo=102, empName="Rahil", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            new Employee(){empNo=103, empName="Mohan", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            new Employee(){empNo=104, empName="Suman", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            new Employee(){empNo=105, empName="Suchit", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            new Employee(){empNo=106, empName="Mahendran", empDesignation="Sales", empIsPermenant=true, empSalary=5000}
        };

        public List<Employee> GetAllEmployees()
        {
            return eList;
        }

    }
}
