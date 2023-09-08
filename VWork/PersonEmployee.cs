using System.Security.Cryptography;

namespace VWork;

public abstract class PersonEmployee : Person
{
    
    protected internal string EmployeeSurname { get; set; }
    
    protected byte EmployeeAge;

    protected internal byte Age 
    {
        get { return EmployeeAge; }
        set
        {
            if (value > 18)
            {
                EmployeeAge = value;
            }
        }
    }
    
    protected string EmployeePosition { get; set; }
    
    protected bool EmloyeeOnShift { get; set; }
    
    protected double EmployeeSalary { get; set; }
    
    protected double EmployeeContractSalary { get; set; }

    protected PersonEmployee(string id, string name, string surname, string position, double salary) : base()
    {
        PersonId = id;
        PersonName = name;
        EmployeeSurname = surname;
        EmployeePosition = position;
        EmployeeSalary = salary;
    }
    
    protected PersonEmployee(string id, string name, string surname, byte age, string phone, bool personType, bool isOnShift, string position) :
        base(id, name, age, phone, personType)
    {
        EmployeeAge = age;
        EmployeeSurname = surname;
        EmloyeeOnShift = isOnShift;
        EmployeePosition = position;
    }

    protected virtual void SalaryCalculation()
    {
        byte dayInMonth = 30;
        var oneDaySalary = EmployeeContractSalary / (double)dayInMonth;

        if (EmloyeeOnShift)
        {
            for (int i = 0; i < dayInMonth; i++)
            {
                EmployeeSalary += oneDaySalary;
            }
        }
    }
}