using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace backend118_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object Nicatdata = new { name = "nicat", Age = 19, surname = "heyderzade" };
            //object Selimdata = new { name = "selim", Age = 16, surname = "imranli" };

            //dynamic[] studentdata = { Nicatdata, Selimdata };
            ////////////////////////////////////////////////////
            dynamic[] studentlist = new dynamic[0];
            int count = 0;
            while (true) {

                Console.WriteLine("1.student add");
                Console.WriteLine("2.student list");
                Console.WriteLine("3.programclose");
                Console.Write("4cu search");
                int chose=Convert.ToInt32(Console.ReadLine());
                if(chose == 3)
                {
                    break;
                 }

                switch (chose)
                {


                    case 1:
                        Console.WriteLine("telebenin adini daxil et");
                        string namest = Console.ReadLine();
                        Console.WriteLine("telebenin soyadini daxil et");
                        string surnamest = Console.ReadLine();
                        Console.WriteLine("telebenin yasini qeyd et");
                        byte agest = Convert.ToByte(Console.ReadLine());
                        var telebe = new { name = namest, age = agest, surname = surnamest };
                        Console.WriteLine(telebe.name + " " + telebe.surname + " " + telebe.age);
                        count++;
                        Array.Resize(ref studentlist, count);
                        studentlist[count - 1] = telebe;
                        Console.WriteLine("telebe daxil edildi  " + studentlist[count - 1].name + " " + studentlist[count - 1].surname + " " + studentlist[count - 1].age);
                        break;
                    case 2:
                        foreach (var item in studentlist)
                        {
                            Console.WriteLine(item.name + " "+item.surname);

                        }
                        break;
                        case 4:
                        if(studentlist.Length > 0)
                        {
                            Console.WriteLine("axtardiginiz telebenin adini daxil et");
                            string searchst = Console.ReadLine();
                            foreach (var item in studentlist)
                            {
                                if (item.name = searchst)
                                    Console.WriteLine(item.name + " " + item.surname + " " + item.age);

                            }

                        }
                        else
                        {
                            Console.WriteLine("siyahida telebe yoxdur");
                        }
                      
                        break;





                }
                }
        }
    }
}