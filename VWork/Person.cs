
using System.Text;

namespace VWork
{
    
    public abstract class Person
    {
        protected internal string PersonId { get; set; }
        
        public string PersonName { get; set; }

        protected internal byte PersonAge
        {
            get { return PersonAge; }
            set
            {
                if (value > 0)
                {
                    PersonAge = value;
                }
            }
        }

        protected internal string PersonPhone { get; set; }
        
        protected internal string PersonEmail { get; set; }
        
        public string PersonCity { get; set; }

        protected static bool boolPersonType { get; set; }

        private static HashSet<string> generatedIdNumbers = new HashSet<string>();

        protected Person()
        {
            
        }

        protected Person(string id, string name, byte age, string phone, bool personType)
        {
            PersonId = id;
            PersonName = name;
            PersonAge = age;
            PersonPhone = phone;
            boolPersonType = personType;
        }

        protected static string GenerateSymbolsArray() 
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

        protected static string GetPersonId(in bool boolPersonType) 
        {
            var isPersonType = boolPersonType;
            var tempById = GenerateSymbolsArray();
            string personId;

            if (isPersonType) /// true, means EMPLOYEE
            {
                personId = "EMP-";
                personId = personId + tempById;
            }
            else /// false, means CUSTOMER
            {
                personId = "CUS-";
                personId = personId + tempById;
            }

            return personId;
        }

        protected static string ProcessListFromIdNumbers() 
        {
            var personId = GetPersonId(boolPersonType);

            if (generatedIdNumbers.Contains(personId))
            {
                generatedIdNumbers.Add(personId);
            }
            else
            {
                Console.WriteLine($"{personId} - its not uniq");
                GenerateSymbolsArray();
                ProcessListFromIdNumbers();
            }

            return personId;
        }

        public abstract void Greeting();
    }

}