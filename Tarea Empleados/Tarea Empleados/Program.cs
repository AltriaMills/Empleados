using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Empleados
{

    internal class Program { 
    

        static void Main(string[] args)
        {
            double salarioD, salarioN;
            double pagoD, pagoN;
            int horas, day;
            string turno;
            Console.WriteLine("Digite el turno que trabaja (diurno = D o nocturno = N)");
            turno = Console.ReadLine();

            if (turno == "D")
            {
                Console.WriteLine("Digite la cantidad de horas trabajadas dia");
                horas = Convert.ToInt32(Console.ReadLine());
                pagoD = horas * 50;
                Console.WriteLine("Digite el dia que trabaja (" +
                  "Lunes = 1, Martes = 2, Miercoles = 3, Jueves = 4, Viernes = 5, Sabado =6, Domingo=7)");
                day = Convert.ToInt32((Console.ReadLine()));
                if (day == (int)Dias.Domingo)
                {
                    salarioD = pagoD + 20;
                    Console.WriteLine("Su salario total es = " + salarioD);
                }
                else
                {
                    Console.WriteLine("Su salario total es = " + pagoD);
                }
                Console.ReadKey();
            }
            else if (turno == "N")
            {
                Console.WriteLine("Digite la cantidad de horas trabajadas noche");
                horas = Convert.ToInt32(Console.ReadLine());
                pagoN = horas * 80;
                Console.WriteLine("Digite el dia que trabaja (" +
                    "Lunes = 1, Martes = 2, Miercoles = 3, Jueves = 4, Viernes = 5, Sabado =6, Domingo=7)");
                day = Convert.ToInt32((Console.ReadLine()));
                if (day == (int)Dias.Domingo)
                    // if ( 7==7)
                {
                    salarioN = pagoN + 30;
                    Console.WriteLine("Su salario total es = " + salarioN);
                }
                else
                {
                    Console.WriteLine("Su salario total es = " + pagoN);
                }
                Console.ReadKey();
            }

        } 

        enum Dias
        { Domingo= 7, Lunes= 1, Martes= 2, Miercoles= 3, Jueves=4, Viernes=5, Sabado=6 };

    }
           
}
