using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Variables
            double calif1, calif2, calif3, calif4, calif5, calif6, calif7, promedio;
            Console.Write("Dame la primer calificación del alumno: ");
            calif1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dame la segunda calificación del alumno: ");
            calif2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dame la Tercera calificación del alumno: ");
            calif3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dame la cuarta calificación del alumno: ");
            calif4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dame la quinta calificación del alumno: ");
            calif5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dame la sexta calificación del alumno: ");
            calif6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dame la septima calificación del alumno: ");
            calif7 = Convert.ToDouble(Console.ReadLine());

            //Calculamos el promedio
            promedio = (calif1 + calif2 + calif3+ calif4 + calif5 + calif6 + calif7) / 7;
            Console.Write("El promedio es: {0} ", promedio); */

            //* Declaración e inicialización de una variable de control
            //* Una instruccion de asignación

            //----------------Ciclo For------------------------------------
            //Contador
            /* int i, contador = 0;
             for (i = 0; i <= 10; i+=2)
             {
                 //contador +=1;
                 contador++;
                 Console.WriteLine("{0},Vuelta del ciclo: {1}", i,contador);
             }

             Console.WriteLine("Numero de vueltas que dio el ciclo: {0}", contador);

             */
            /*
            //Acumulador
            int i, acumulador = 0, precio;
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Ingresa el precio del producto: ");
                precio = Convert.ToInt32(Console.ReadLine());

                acumulador += precio;
            }

            Console.WriteLine("El total es: {0} ", acumulador);
            */
            /*
            Variables
            double calificacion,sumaCali = 0, promedio;
            byte i, numAlumnos;

            Console.Write("Ingresa el numero de materias: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            for (i = 1; i <= numAlumnos; i++)
            {
                Console.Write("Ingresa la calificación: ");
                calificacion = Convert.ToDouble(Console.ReadLine());

                sumaCali += calificacion;

            }
            //Calculamos el promedio
            promedio = sumaCali / numAlumnos;
            Console.WriteLine("El promedio es: {0} ", promedio);

            */
            /*
            //----------------------------------Factoriales------------------------
            ulong i, numero, factorial = 1;

            Console.Write("Ingresa el número para calcular su factorial: ");
            numero = Convert.ToUInt64(Console.ReadLine());

            for ( i = numero; i >= 1; i--)
            {
                factorial = factorial * i; //Factorial *= i;
            }
            Console.WriteLine("El factorial de {0}, es: {1}", numero, factorial);
            */

            //-----------------------------while---------------------------------
            /*
            byte numero = 1;

            while (numero <= 10)
            {
                Console.WriteLine(numero);
                numero++;
            }*/
            /*
            String contraseña1, contraseña2 = "";

            Console.WriteLine("Ingresa tu contraseña: ");
            contraseña1 = Console.ReadLine();

            while(contraseña1 != contraseña2)
            {
                Console.Write("Confirma tu contraseña: ");
                contraseña2 = Console.ReadLine();
            }
            Console.WriteLine("¡Contraseña guardada !" );
            */

            //-------------------------Do while---------------------------------
            /*
            int i = 12;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);

            */
            //________---------------___________-----------------____________________-------------
            /*decimal num1, num2, resultado = 0M;
            byte opcion;

            do
            {
                Console.Clear(); // Limpia la consola (opcional)
                Console.WriteLine("===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. Division");
                Console.Write("Selecciona una opción (1-4): ");
                opcion = Convert.ToByte(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));
            Console.Write("Dame el primer número: ");
            num1= Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el Segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Divisor no valido");
                    }
                    break;
            }
            Console.WriteLine("El resultado de la operacion es:  {0}", resultado);
            */

            //-------------______________----------------____________----------------________________
            //MULTIPLICACION
            int i, j, resultado;
            for( i=1; i <=10; i++)
            {
                Console.WriteLine("Tabla de muntiplicar del {0}", i);
                for( j=1; j<=10; j++)
                {
                    resultado = i * j;
                    Console.WriteLine("{0} * {1} = {2}", i,j,resultado);
                }
            }

            Console.ReadKey();
        }
    }
}
