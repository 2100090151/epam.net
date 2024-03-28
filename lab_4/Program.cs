using System;

class Employee
{
    protected string name;
    protected decimal salary;
    protected decimal bonus;

    public string Name { get { return name; } }
    public decimal Salary { get { return salary; } }

    public Employee(string name, decimal salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public virtual void SetBonus(decimal bonus)
    {
        this.bonus = bonus;
    }

    public virtual decimal ToPay()
    {
        return salary + bonus;
    }
}

class SalesPerson : Employee
{
    private int percent;

    public SalesPerson(string name, decimal salary, int percent) : base(name, salary)
    {
        this.percent = percent;
    }

    public override void SetBonus(decimal bonus)
    {
        if (percent > 200)
            this.bonus = bonus * 3;
        else if (percent > 100)
            this.bonus = bonus * 2;
        else
            this.bonus = bonus;
    }
}

class Manager : Employee
{
    private int quantity;

    public Manager(string name, decimal salary, int quantity) : base(name, salary)
    {
        this.quantity = quantity;
    }

    public override void SetBonus(decimal bonus)
    {
        if (quantity > 150)
            this.bonus = bonus + 1000;
        else if (quantity > 100)
            this.bonus = bonus + 500;
        else
            this.bonus = bonus;
    }
}

class Company
{
    private Employee[] employees;

    public Company(Employee[] employees)
    {
        this.employees = employees;
    }

    public void GiveEverybodyBonus(decimal companyBonus)
    {
        foreach (Employee emp in employees)
        {
            emp.SetBonus(companyBonus);
        }
    }

    public decimal TotalToPay()
    {
        decimal total = 0;
        foreach (Employee emp in employees)
        {
            total += emp.ToPay();
        }
        return total;
    }

    public string NameMaxSalary()
    {
        string maxSalaryName = "";
        decimal maxSalary = decimal.MinValue;
        foreach (Employee emp in employees)
        {
            if (emp.ToPay() > maxSalary)
            {
                maxSalary = emp.ToPay();
                maxSalaryName = emp.Name;
            }
        }
        return maxSalaryName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[]
        {
            new Manager("John", 5000, 120),
            new SalesPerson("Alice", 3000, 150),
            new Manager("Bob", 6000, 180)
        };

        Company company = new Company(employees);

        company.GiveEverybodyBonus(1000);
        Console.WriteLine("Total to Pay: " + company.TotalToPay());
        Console.WriteLine("Employee with Max Salary: " + company.NameMaxSalary());
    }
}
