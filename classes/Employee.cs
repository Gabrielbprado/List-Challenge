class Employee
{

    private string name;
    public int id;
    private double _salary; 

    public Employee(string name,int id,double salary)
    {

        this.name = name;
        this.id = id;
        this._salary = salary;

    }

    public double IncreaseSalary(double percentage)
    {
        
        return  _salary+percentage/100;

    }

    public override string ToString()
    {
        return $" Id: {id} Name: {name} Salary {_salary}";
    }


}