using System;

public abstract class Employee
{
    public virtual string GetWorkDetails(int id)
    {
        return "Working";
    }

    public virtual string GetEmployeeDetails(int id)
    {
        return "Employee";
    }
}

public class Baker : Employee
{
    public override string GetWorkDetails(int id)
    {
        return "Bake cakes";
    }

    public override string GetEmployeeDetails(int id)
    {
        return "Bakery worker";
    }
}

public class Butcher : Employee
{
    public override string GetWorkDetails(int id)
    {
        throw new NotImplementedException();
    }

    public override string GetEmployeeDetails(int id)
    {
        return "Butcher shop worker";
    }
}
