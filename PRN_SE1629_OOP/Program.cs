using System.Collections;
using static System.Console;
namespace PRN.SE1629;

public class Program
{
    public static void Main(string[] args)
    {
        /*1. create a new project Employee*/
        /*
        Employee e = new Employee();
        e.Id = 1;
        e.Name = "Dong";
        e.Salary = 150.55d;
        */

        /*
         * Employee emp = new Employee(160d,1,"Nguyen Van A") ;
        emp.Name = "SOS";
        Write(emp);
        */

        /*2. create a list employees and display them*/

        /*ArrayList lstEmp = new ArrayList();
        lstEmp.Add(new Employee(100, 1, "Dong"));
        lstEmp.Add(new Employee(110, 2, "Thanh"));
        lstEmp.Add(new Employee(120, 3, "Minh"));
        lstEmp.Add(new Employee(140, 4, "Case"));
        lstEmp.Add(new Employee(150, 5, "DJessi"));
        lstEmp.Add(new Employee(1320, 6, "Dong"));*/

        Employee a = new Employee(1, "Dong", 152d, new DateOnly(), new Address(493, "CMT8", "P.13", "Quan 10", "HCMC"));
        //Display
        WriteLine(a);

        ReadLine();
    }

    private static void Display(ArrayList lstData)
    {
        /*
        foreach (Employee e in lstData)
        {
            WriteLine(e);
        }
        */
        for (int i = 0; i < lstData.Count; i++)
        {
            WriteLine(lstData[i]);
        }
    }
}