namespace VWork;

public class PersonEmployeeOfficeManager : PersonEmployee
{
    protected new double EmployeeContractSalary { get; set; }
    
    protected new double EmployeeSalary { get; set; }
    

    protected PersonEmployeeOfficeManager(string id, string name, string surname, string position, double salary) :
        base(id, name, surname, position, salary)
    {
        EmployeeSalary = salary;
    }

    public override void Greeting() => Console.WriteLine($"Hello, {EmployeeSurname} {PersonName}");

    private double CheckEmployeePosition()
    {
        string employeePosition = EmployeePosition;
        
        if (employeePosition == "")
        {
            
        }

        if (employeePosition == "")
        {
            
        }

        return EmployeeContractSalary;
    }
    
    private int GetCurrentMonth() 
    {
        int currentYear = DateTime.Now.Year;
        int currentMonth = DateTime.Now.Year;
        int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);

        return daysInMonth;
    }
    
    private byte OnShiftCalcualation() 
    {
        bool onShift = EmloyeeOnShift;
        int daysInMonth = GetCurrentMonth();
        byte daysNumber = 0;

        if (onShift)
        {
            for (int i = 0; i < daysInMonth; i++)
            {
                daysNumber++;
            }
        }

        return daysNumber;
    }
    
    protected sealed override void SalaryCalculation() 
    {
        var daysNumber = Convert.ToDouble(OnShiftCalcualation());
        EmployeeSalary = EmployeeContractSalary / daysNumber;
    }
}