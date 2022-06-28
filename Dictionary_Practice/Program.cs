/*Dictionary<int, string> dicti = new Dictionary<int, string>()
{
    {1, "one" },
    {2, "two" },
    {3, "three" }};*/

//creating an array of Employee objects named employee
Employee[] employee =
{
    //creating new employees using constructor
    new Employee("CEO", "Gwyn", 95, 200),
    new Employee("CEO", "Gwyn", 95, 200)
};

Dictionary<string, Employee> Emp = new Dictionary<string, Employee>();



class Employee
{
    //properties of class
    public string Title { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }


    public Employee(string title, string name, int age, int salary) //constructor
    {
        this.Title = title;
        this.Name = name;
        this.Age = age;
        this.Salary = salary;

    }

    public Employee() //default constructor
    {
        this.Title = "Dr";
        this.Age = 0;
        this.Name = "Default";
        this.Salary = 0;
    }

}