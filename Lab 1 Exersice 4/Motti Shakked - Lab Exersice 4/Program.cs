using System;

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = CreateEmployee();
        Console.WriteLine(emp1);

        Employee emp2 = emp1;
        Console.WriteLine(emp1.Equals(emp2));

        Employee emp3 = CreateEmployee();
        Console.WriteLine(emp1.Equals(emp3));
    }



    static Employee CreateEmployee()
    {
        Employee emp = new Employee();
        emp.ID = 100;
        emp.FirstName = "Motti";
        emp.LastName = "Shaked";
        return emp;
    }



}





class Employee
{
    public int ID
    {
        get;
        set;
    }

    public string FirstName
    {
        get;
        set;
    }

    public string LastName
    {
        get;
        set;
    }

    public override string ToString()
    {
        return "Employee " + this.ID + ": " + this.FirstName + " " + this.LastName;
    }

    public override bool Equals(object obj)
    {
        // this object is not null - if the other is null return false
        if (obj == null)
            return false;

        // make sure the object is of the same type
        // don't use is or as because it can be satisfied if 
        // the compared object derives from Employee
        if (obj.GetType() != this.GetType())
            return false;

        // cast
        Employee otherEmp = (Employee)obj;

        // compare id
        // probably enough in the case of Employee
        // because we don't expect two different employees of the same id
        // in other cases you may want to compare everything
        return otherEmp.ID == this.ID;
    }

    public override int GetHashCode()
    {
        return this.ID;
    }
}