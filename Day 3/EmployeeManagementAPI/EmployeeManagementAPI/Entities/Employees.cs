using System.Threading.Channels;

namespace EmployeeManagementAPI.Entities
{
    public class Employees
    {
        #region #1 Properies
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }

        public bool empIsPermenant { get; set; }
        public int empDeptNo { get; set; }

        #endregion

        #region #2 Data

        static List<Employees> empList = new List<Employees>()
        {
            new Employees(){ empNo=101, empName="Nikhil", empDesignation="Consultant", empDeptNo=10, empIsPermenant = true, empSalary=200},
            new Employees(){ empNo=102, empName="Amit", empDesignation="Sales", empDeptNo=20, empIsPermenant = true, empSalary=300},
            new Employees(){ empNo=103, empName="Pari", empDesignation="Consultant", empDeptNo=10, empIsPermenant = false, empSalary=100},
            new Employees(){ empNo=104, empName="Nikita", empDesignation="Consultant", empDeptNo=10, empIsPermenant = true, empSalary=400},
            new Employees(){ empNo=105, empName="Anjali", empDesignation="Consultant", empDeptNo=30, empIsPermenant = true, empSalary=600},
            new Employees(){ empNo=106, empName="Surbhi", empDesignation="Sales", empDeptNo=30, empIsPermenant = true, empSalary=800},
            new Employees(){ empNo=107, empName="Maahi", empDesignation="Consultant", empDeptNo=10, empIsPermenant = false, empSalary=1200},
            new Employees(){ empNo=108, empName="Akshay", empDesignation="Consultant", empDeptNo=10, empIsPermenant = true, empSalary=2200},
            new Employees(){ empNo=109, empName="Puneet", empDesignation="HR", empDeptNo=20, empIsPermenant = true, empSalary=100},
            new Employees(){ empNo=1010, empName="Raj", empDesignation="Consultant", empDeptNo=10, empIsPermenant = true, empSalary=220},
            new Employees(){ empNo=1011, empName="Roshni", empDesignation="HR", empDeptNo=20, empIsPermenant = false, empSalary=250}
        };


        #endregion

        #region #3 Methods

        #region Get Methods
        public List<Employees> GetAllEmployees()
        {
            return empList;
        }

        public Employees GetEmployeeById(int id)
        {
            var emp = empList.Find(e => e.empNo == id);
            if (emp != null)
            {
                return emp;
            }
            throw new Exception("Employee Not Found");
        }

        public List<Employees> GetEmployeeByDesignation(string desg)
        {
            var emp = empList.FindAll(e => e.empDesignation == desg);
            if (emp.Count > 1)
            {
                return emp;
            }
            throw new Exception("Sorry no one working as " + desg);
        }

        public List<Employees> GetEmployeesByDept(int deptno)
        {
            var emp = empList.FindAll(e => e.empDeptNo == deptno);
            if (emp.Count > 1)
            {
                return emp;
            }
            throw new Exception("Sorry no one working in depertment no  " + deptno);
        }

        public int GetTotalEmployees()
        {
            return empList.Count;
        }

        public double GetTotalSalaryPaid()
        {
            var totalSal = empList.Sum(e => e.empSalary);
            return totalSal;
        }

        public List<Employees> getEmployeeByState(string ispermenant)
        {
            if (ispermenant == "yes")
            {
                var permenantemp = empList.FindAll(e => e.empIsPermenant == true);
                return permenantemp;
            }
            var emp = empList.FindAll(e => e.empIsPermenant == false);
            return emp;
        }
        #endregion

        #region Add, update and delete employees
        public string AddNewEmployee(Employees newEmp)
        {
            empList.Add(newEmp);
            return "Employee Added Successfully";
        }

        public string UpdateEmployee(Employees changes)
        {
            var emp = empList.Find(e => e.empNo == changes.empNo);
            if (emp != null)
            {
                emp.empName = changes.empName;
                emp.empDeptNo = changes.empDeptNo;
                emp.empDesignation = changes.empDesignation;
                emp.empSalary = changes.empSalary;
                emp.empIsPermenant = changes.empIsPermenant;
                return "Employee Details Updated";
            }
            throw new Exception("Employee Not Found");

        }

        public string DeleteEmployee(int empno)
        {
            var emp = empList.Find(e => e.empNo == empno);
            if (emp != null)
            {
                empList.Remove(emp);
                return "Employee Deleted Successfully";
            }
            throw new Exception("Employee Not Found");
        }

        #endregion

        #endregion


    }
}








