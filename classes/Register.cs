class Register
{
    
    List<Employee> Listemployees = new List<Employee>();
    public void Cadastre()
    {
        int i= 1;
        
        Console.Write("How Many Employees Do You Want to Register:");
        int Qunt = int.Parse(Console.ReadLine());
        while(i<=Qunt)
        {
        Console.WriteLine($"Employees #{i} ");
        Console.Write("Inform the Id: ");
        int.TryParse(Console.ReadLine(), out int id );
        Console.Write("Inform the Name: ");
        string name = Console.ReadLine();
        Console.Write("Inform the Salary: ");
        double Salary = double.Parse(Console.ReadLine());
        Listemployees.Add(new Employee(name,id,Salary));        
    
        i++;

        }

            Console.WriteLine("Enter the id you want to increase the salary");
            int idIncrease = int.Parse(Console.ReadLine());
            Employee emp = Listemployees.Find(x => x.id == idIncrease);
            if(emp == null)
            {
                Console.WriteLine("The Id not Exist");


            }else
            {
                Console.Write("Enter the percentage:");
                 double.TryParse(Console.ReadLine(),out double porcent);
                 emp.IncreaseSalary(porcent);
            }
           
           foreach(Employee obj in Listemployees)
           {
                Console.WriteLine(obj);
            
           }
            
    }


}