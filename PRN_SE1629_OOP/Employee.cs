namespace PRN.SE1629;
public class Employee:Person
{
    /*field/data*/
    private int _id;
    private string _name;
    /*properties*/
    public double Salary { get; set; } //.NET 5 +
    public int Id { get => _id; set => _id = value; }

    /*Constructors with no param*/
    public Employee()
    {

    }
    /*Constructors*/
    public Employee(int id, string name, double salary, DateOnly dob, Address address):base(name,dob,address)
    {
        this._id = id;
        this.Salary = salary;

    }

    public override string? ToString()
    {
        //return base.ToString();
        return $"[Id = {this._id}, Name = {this.Name}, Salary = {Salary}], " + this.Address;
    }
}