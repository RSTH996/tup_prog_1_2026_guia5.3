using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializacion de variables y contadores
            int A, B, Tot=0, V = 0, Option = 0;
            bool Banderita = true;
            //invocacion de clase externo para realizar operaciones y simplificando código
            Funciones funcI = new Funciones();

            Console.WriteLine("Bienvanido a la resolucion de las actividades \n Se usará un metodo swich para evitar consumo exesivo de almacenamiento en actividades simples.\n Se usará métodos externas para practicas de actividades");
            Console.WriteLine("Precione el número 1 para empezar a realizar la actividad N°1");
            Console.WriteLine("Precione el número 2 para empezar a realizar la actividad N°2");
            Console.WriteLine("Precione el número 3 para empezar a realizar la actividad N°3");
            Option = Convert.ToInt16(Console.ReadLine());
            switch (Option) {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Bienvenido a la Actividad N°1, iteracion con PARA o FOR");
                    for (V = 0; V < 20;V++){
                        Console.WriteLine($"Ingrese el número {V} de 20 para realizar un promedio");
                        Tot = Tot + Convert.ToInt16(Console.ReadLine());
                    }
                    Console.WriteLine($"El promedio de los {V} de un total de {funcI.Promedio(Tot, V)}");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Bienvenido a la Actividad N°2, iteracion con MIENTRAS o WHILE y BANDERA");
                    while (Banderita == true){
                        Console.WriteLine("Ingrese la nota de un estudiante \nPara salir, precione un valor por debajo del cero");
                        Option = Convert.ToInt16(Console.ReadLine());
                        if (Option < 0){
                            Banderita = false;
                        }else{
                            Tot = Tot + Option;
                            V = V + 1;
                        }
                    }
                    //verificacion de datos para evitar que se realice divisiones con valor CERO
                    if (V != 0){
                        Console.WriteLine($"La el promedio de {V} estudiantes es igual a: {funcI.Promedio(Tot, V)}");
                    }else{
                        Console.WriteLine("No hay estudiantes para promediar");
                    }
                    break;
                case 3:
                    Console.Clear();
                    int MAX = 0, min = 101;
                    Console.WriteLine("Bienvenido a la Actividad N°3, iteracion con MIENTRAS o WHILE y CENTINELA");
                    Console.WriteLine("Ingrese un número entre 0 y 100 \nPara salir, precione un valor igual a -1");
                    Option = Convert.ToInt16(Console.ReadLine());
                    while (Option !=-1)
                    {
                        //Se verifica la magnitud del número
                        if (Option < min){
                            min = Option;
                        }
                        if (Option > MAX){
                            MAX = Option;
                        }
                        Console.WriteLine("Ingrese un número entre 0 y 100 \nPara salir, precione un valor igual a -1");
                        Option = Convert.ToInt16(Console.ReadLine());
                    }
                    //verificacion de datos finales
                    if (MAX != 0 && min != 101){
                        Console.WriteLine($"El número de maximo valor es {MAX} y el número de menor valor es {min}");
                    }else{
                        Console.WriteLine("No se escribío valores para registrar");
                    }
                    break;
            }
            Console.WriteLine("Precione una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
