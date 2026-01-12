namespace ConsoleApp;

//Task 1

public class Program1
{
    public static void Main(string[] args)
    {
        List<Company> companies1 = new List<Company>
        {
            new Company(
                "White Food Ltd",
                new DateTime(2021, 3, 15),
                BusinessProfiles.Marketing,
                "John",
                "White",
                150,
                "London"
            ),

            new Company(
                "Black Marketing Group",
                new DateTime(2019, 7, 10),
                BusinessProfiles.Marketing,
                "Sarah",
                "Black",
                80,
                "New York"
            ),

            new Company(
                "Tech IT Solutions",
                new DateTime(2020, 1, 25),
                BusinessProfiles.IT,
                "Michael",
                "Brown",
                320,
                "London"
            ),

            new Company(
                "Green Education Center",
                new DateTime(2022, 9, 5),
                BusinessProfiles.Education,
                "Emily",
                "Green",
                45,
                "Berlin"
            ),

            new Company(
                "White Black IT",
                new DateTime(2023, 2, 1),
                BusinessProfiles.IT,
                "Robert",
                "Black",
                210,
                "London"
            ),

            new Company(
                "Food Market White",
                new DateTime(2018, 11, 20),
                BusinessProfiles.Food,
                "Andrew",
                "White",
                95,
                "Paris"
            )
        };
        
        var allCompanies1 = companies1
            .Select(c => c);
        
        Console.WriteLine("=================== All Companies ===================");
        
        foreach (var company in allCompanies1)
        {
            company.CompanyShow();
        }

        var companiesThatHaveFoodInName1 = companies1
            .Where(c => c.Name.Contains("Food"));
        
        Console.WriteLine("====== Companies with name that contains 'food' ======");
        
        foreach (var company in companiesThatHaveFoodInName1)
        {
            company.CompanyShow();
        }

        var companiesThatHaveMarkeringProfile1 = companies1
            .Where(c => c.Profile == BusinessProfiles.Marketing);
        
        Console.WriteLine("========== Companies with marketing profile ==========");
        
        foreach (var company in companiesThatHaveMarkeringProfile1)
        {
            company.CompanyShow();
        }

        var companiesThatHaveMarkeringOrItProfile1 = companies1
            .Where(c => c.Profile == BusinessProfiles.Marketing || c.Profile == BusinessProfiles.IT);
        
        Console.WriteLine("======= Companies with marketing and IT profiles =======");
        
        foreach (var company in companiesThatHaveMarkeringOrItProfile1)
        {
            company.CompanyShow();
        }
        
        var companiesWithMoreThan100Employees1 = companies1
            .Where(c => c.EmployeeCount > 100);
        
        Console.WriteLine("======== Companies with more than 100 employees ========");
        
        foreach (var company in companiesWithMoreThan100Employees1)
        {
            company.CompanyShow();
        }
        
        var companiesWithEmployeeCountBetween100And3001 = companies1
            .Where(c => c.EmployeeCount > 100 && c.EmployeeCount < 300);
        
        Console.WriteLine("=== Companies with employee count between 100 and 300 ===");
        
        foreach (var company in companiesWithEmployeeCountBetween100And3001)
        {
            company.CompanyShow();
        }
        
        var companiesInLondon1 = companies1
            .Where(c => c.Address.Contains("London"));
        
        Console.WriteLine("================== Companies in London ==================");
        
        foreach (var company in companiesInLondon1)
        {
            company.CompanyShow();
        }
        
        var companiesWithOwnersSecondNameWhite1 =  companies1
            .Where(c => c.CompanyOwnerSecondName == "White");
        
        Console.WriteLine("======= Companies with Owner's second name 'White' =======");
        
        foreach (var company in companiesWithOwnersSecondNameWhite1)
        {
            company.CompanyShow();
        }
        
        var companiesOlderThen2Years1 = companies1
            .Where(c => c.Date < DateTime.Now.AddYears(-2));
        
        Console.WriteLine("======= Companies that older then 2 years =======");
        
        foreach (var company in companiesOlderThen2Years1)
        {
            company.CompanyShow();
        }
        
        var companiesOlderThen123Days1 = companies1
            .Where(c => c.Date < DateTime.Now.AddDays(-123));
        
        Console.WriteLine("======= Companies that older then 123 days =======");
        
        foreach (var company in companiesOlderThen123Days1)
        {
            company.CompanyShow();
        }
        
        var companiesWithOwnersSecondNameBlackAndCompanyNameContainsWordWhite1 = companies1
            .Where(c => c.CompanyOwnerSecondName == "Black" && c.Name.Contains("White"));
        
        Console.WriteLine("======= Companies with Owner's second name 'Black' and with company name that contains 'White' =======");
        
        foreach (var company in companiesWithOwnersSecondNameBlackAndCompanyNameContainsWordWhite1)
        {
            company.CompanyShow();
        }
    }
}

//Task 2

public class Program2
{
    public static void Main(string[] args)
    {
        List<Company> companies2 = new List<Company>
        {
            new Company(
                "White Finance Group",
                new DateTime(2016, 3, 10),
                BusinessProfiles.Finance,
                "Daniel",
                "White",
                260,
                "London"
            ),

            new Company(
                "Black IT Solutions",
                new DateTime(2021, 7, 22),
                BusinessProfiles.IT,
                "Emma",
                "Black",
                180,
                "Berlin"
            ),

            new Company(
                "White Marketing House",
                new DateTime(2019, 11, 5),
                BusinessProfiles.Marketing,
                "Oliver",
                "White",
                95,
                "Amsterdam"
            ),

            new Company(
                "Black Education Center",
                new DateTime(2018, 1, 14),
                BusinessProfiles.Education,
                "Sophia",
                "Black",
                60,
                "Paris"
            ),

            new Company(
                "White Food Factory",
                new DateTime(2022, 5, 30),
                BusinessProfiles.Food,
                "Liam",
                "White",
                140,
                "Rome"
            ),

            new Company(
                "Black Marketing & IT",
                new DateTime(2017, 9, 18),
                BusinessProfiles.IT,
                "Noah",
                "Black",
                310,
                "London"
            )
        };

        
        var allCompanies2 = 
            from c in companies2 
            select c;
        
        Console.WriteLine("=================== All Companies ===================");
        
        foreach (var company in allCompanies2)
        {
            company.CompanyShow();
        }

        var companiesThatHaveFoodInName2 = 
            from c in  companies2 
            where c.Name.Contains("Food") 
            select c;
        
        Console.WriteLine("====== Companies with name that contains 'food' ======");
        
        foreach (var company in companiesThatHaveFoodInName2)
        {
            company.CompanyShow();
        }

        var companiesThatHaveMarkeringProfile2 = 
                from c in companies2 
                where c.Profile == BusinessProfiles.Marketing 
                select c;
        
        Console.WriteLine("========== Companies with marketing profile ==========");
        
        foreach (var company in companiesThatHaveMarkeringProfile2)
        {
            company.CompanyShow();
        }

        var companiesThatHaveMarkeringOrItProfile2 = 
                from c in companies2 
                where c.Profile == BusinessProfiles.Marketing || c.Profile == BusinessProfiles.IT 
                select c;
        
        Console.WriteLine("======= Companies with marketing and IT profiles =======");
        
        foreach (var company in companiesThatHaveMarkeringOrItProfile2)
        {
            company.CompanyShow();
        }
        
        var companiesWithMoreThan100Employees2 = 
            from c in companies2 
            where c.EmployeeCount > 100 
            select c;
        
        Console.WriteLine("======== Companies with more than 100 employees ========");
        
        foreach (var company in companiesWithMoreThan100Employees2)
        {
            company.CompanyShow();
        }
        
        var companiesWithEmployeeCountBetween100And3002 = 
            from c in companies2 
            where c.EmployeeCount > 100 && c.EmployeeCount < 300 
            select c;
        
        Console.WriteLine("=== Companies with employee count between 100 and 300 ===");
        
        foreach (var company in companiesWithEmployeeCountBetween100And3002)
        {
            company.CompanyShow();
        }
        
        var companiesInLondon2 = 
            from c in companies2 
            where c.Address.Contains("London") 
            select c;
        
        Console.WriteLine("================== Companies in London ==================");
        
        foreach (var company in companiesInLondon2)
        {
            company.CompanyShow();
        }
        
        var companiesWithOwnersSecondNameWhite2 = 
            from c in companies2 
            where c.CompanyOwnerSecondName == "White" 
            select c;
        
        Console.WriteLine("======= Companies with Owner's second name 'White' =======");
        
        foreach (var company in companiesWithOwnersSecondNameWhite2)
        {
            company.CompanyShow();
        }
        
        var companiesOlderThen2Years2 = 
            from c in companies2
            where c.Date < DateTime.Now.AddYears(-2) 
            select c;
        
        Console.WriteLine("======= Companies that older then 2 years =======");
        
        foreach (var company in companiesOlderThen2Years2)
        {
            company.CompanyShow();
        }
        
        var companiesOlderThen123Days2 = 
            from c in companies2
            where c.Date < DateTime.Now.AddDays(-123) 
            select c;
        
        Console.WriteLine("======= Companies that older then 123 days =======");
        
        foreach (var company in companiesOlderThen123Days2)
        {
            company.CompanyShow();
        }
        
        var companiesWithOwnersSecondNameBlackAndCompanyNameContainsWordWhite2 = 
            from c in companies2
            where c.CompanyOwnerSecondName == "Black" && c.Name.Contains("White") 
            select c;
        
        Console.WriteLine("======= Companies with Owner's second name 'Black' and with company name that contains 'White' =======");
        
        foreach (var company in companiesWithOwnersSecondNameBlackAndCompanyNameContainsWordWhite2)
        {
            company.CompanyShow();
        }
    }
}

//Task 3

public class Program3
{
    public static void Main(string[] args)
    {
        List<Company> companies3 = new List<Company>
        {
            new Company(
                "Tech IT Solutions",
                new DateTime(2020, 1, 25),
                BusinessProfiles.IT,
                "Michael",
                "Brown",
                320,
                "London"
            )
            {
                Employees = new List<Employee>
                {
                    new Employee("Michael", "Brown", Positions.Senior, "231234567890", "michael.brown@techit.com", 5000),
                    new Employee("Lionel", "White", Positions.Junior, "441234567891", "sarah.white@techit.com", 2500),
                    new Employee("Robert", "Black", Positions.TeamLead, "441234567892", "robert.black@techit.com", 6000)
                }
            },

            new Company(
                "NextGen Marketing",
                new DateTime(2019, 2, 18),
                BusinessProfiles.Marketing,
                "Lucas",
                "Miller",
                95,
                "Amsterdam"
            )
            {
                Employees = new List<Employee>
                {
                    new Employee("Lucas", "Miller", Positions.Middle, "23201234567", "dicas.miller@nextgen.com", 3500),
                    new Employee("Lionel", "Green", Positions.Manager, "31201234568", "olivia.green@nextgen.com", 7000)
                }
            },

            new Company(
                "Global Education Hub",
                new DateTime(2016, 11, 3),
                BusinessProfiles.Education,
                "Sophia",
                "Williams",
                60,
                "Toronto"
            )
            {
                Employees = new List<Employee>
                {
                    new Employee("Sophia", "Rain", Positions.TeamLead, "14161234567", "diphia.williams@edu.com", 4000),
                    new Employee("Ethan", "Cooper", Positions.Junior, "23161234568", "ethan.cooper@edu.com", 2200)
                }
            },

            new Company(
                "Urban Food Factory",
                new DateTime(2022, 6, 14),
                BusinessProfiles.Food,
                "Mia",
                "Johnson",
                140,
                "Barcelona"
            )
            {
                Employees = new List<Employee>
                {
                    new Employee("Lionel", "Messi", Positions.Intern, "34931234567", "goat.messi@urbanfood.com", 1200),
                    new Employee("Noah", "Anderson", Positions.Senior, "23931234568", "dihh.anderson@urbanfood.com", 4800)
                }
            }
        };
        
        var oneCompanyEmployees = companies3
            .Where(c => c.Name == "Tech IT Solutions")
            .SelectMany(c => c.Employees);
        
        Console.WriteLine("======================== Company 'Tech IT Solutions' employees ========================");

        foreach (var employee in oneCompanyEmployees)
        {
            employee.EmployeeShow();
        }
        
        var oneCompanyEmployeesWithSalaryMoreThan3000 = companies3
            .Where(c => c.Name == "Tech IT Solutions")
            .SelectMany(c => c.Employees)
            .Where(e => e.Salary > 3000);
        
        Console.WriteLine("========== Company 'Tech IT Solutions' employees with salary more than $3000 ==========");

        foreach (var employee in oneCompanyEmployeesWithSalaryMoreThan3000)
        {
            employee.EmployeeShow();
        }
        
        var allEmployeesWithManagerPosition = companies3
            .SelectMany(c => c.Employees)
            .Where(e => e.Position == Positions.Manager);
        
        Console.WriteLine("========================= All employees with manager position =========================");

        foreach (var employee in allEmployeesWithManagerPosition)
        {
            employee.EmployeeShow();
        }
        
        var allEmployeesWithPhoneNumberThatStartsWith23 = companies3
            .SelectMany(c => c.Employees)
            .Where(e => e.PhoneNumber.StartsWith("23"));
        
        Console.WriteLine("================= All employees with phone number that starts with 23 =================");

        foreach (var employee in allEmployeesWithPhoneNumberThatStartsWith23)
        {
            employee.EmployeeShow();
        }
        
        var allEmployeesWithPhoneEmailThatStartsWithDi = companies3
            .SelectMany(c => c.Employees)
            .Where(e => e.Email.StartsWith("di"));
        
        Console.WriteLine("==================== All employees with email that starts with di ====================");

        foreach (var employee in allEmployeesWithPhoneEmailThatStartsWithDi)
        {
            employee.EmployeeShow();
        }
        
        var allEmployeesWithNameLionel = companies3
            .SelectMany(c => c.Employees)
            .Where(e => e.FirstName == "Lionel");
        
        Console.WriteLine("=========================== All employees with name Lionel ===========================");

        foreach (var employee in allEmployeesWithNameLionel)
        {
            employee.EmployeeShow();
        }
    }
}

//Task 4

public class Program4
{
    public static void Main(string[] args)
    {
        List<int> unsortedNumbers = new List<int> { 10, 18, 121, 82, 90, 78, 102 };
        
        var sortedNumbersByAscending = unsortedNumbers
            .OrderBy(n => SumOfDigits(n));

        Console.WriteLine("Sorted numbers by ascending order: ");
        
        foreach (var number in sortedNumbersByAscending)
        {
            Console.Write(number + ", ");
        }

        var sortedNumbersByDescending = unsortedNumbers
            .OrderByDescending(n => SumOfDigits(n));
        
        Console.WriteLine("\n\nSorted numbers by descending order: ");

        foreach (var number in sortedNumbersByDescending)
        {
            Console.Write(number + ", ");
        }
    }

    static int SumOfDigits(int number)
    {
        return number
            .ToString()
            .Sum(c => c - '0');
    }
}