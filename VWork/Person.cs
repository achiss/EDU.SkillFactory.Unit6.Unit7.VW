
using System.Text;

namespace VWork;


public abstract class Person
{
    public string PersonName { set; get; }

    protected internal byte PersonAge
    {
        get
        {
            return PersonAge;
        }
        set
        {
            if (value > 0)
            {
                PersonAge = value;
            }
        }
    }
    
    protected internal string PersonPhone { get; set; }

    public Person(string name, byte age, string phone)
    {
        PersonName = name;
        PersonAge = age;
        PersonPhone = phone;
    }

    public static string GenerateSymbolsArray()
    {
        Random random = new Random();
        const string chars = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЫЭЮЯ0123456789";
        StringBuilder str = new StringBuilder();

        for (int i = 0; i < 14; i++)
        {
            str.Append(chars[random.Next(chars.Length)]);
        }

        string generatedString = str.ToString();
        return generatedString;
    }
    
    public static string GetPersonId(in bool boolPersonType)
    {
        bool isPersonType = boolPersonType;
        string personId;

        if (isPersonType)
        {
            
        }
        else
        {
            
        }
    }

    public static void ProcessListFromIdNumbers()
    {
        
    }
}