namespace VWork;

public class PersonEmployeeOfficeManager : PersonEmployee
{
    protected new double EmployeeContractSalary;

    protected PersonEmployeeOfficeManager(string id, string name, string surname, byte age, string phone,
        bool personType,
        bool isOnShift, string position) :
        base(id, name, surname, age, phone, personType, isOnShift, position)
    {
    }

    public override void Greeting() => Console.WriteLine($"Hello, {EmployeeSurname} {PersonName}");

    protected override void SalaryCalculator()
    {
        
    }
}