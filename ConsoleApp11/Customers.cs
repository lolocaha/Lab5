public class Customers
{
    private int _id;
    private string _name;
    private int _age;
    private string _city;

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set { if (value > 0) _age = value; } }
    public string City { get; set; }
    public Customers(int id, string name, int age, string city)
    {
        Id = id;
        Name = name;
        Age = age;
        City = city;
    }
}

