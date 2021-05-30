using System;

namespace tp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            punto1();
            punto2();
            punto3();
        }

        public static void punto1()
        {
            int n, inverso = 0;
            string cadena;

            Console.WriteLine("ingrese un numero: ");
            cadena = Console.ReadLine();

            n = Convert.ToInt32(cadena);

            if (n <= 0)
            {
                Console.WriteLine("no se puede invertir numero: " + n);
            }
            else
            {
                while (n % 10 != 0)
                {
                    inverso = inverso * 10 + n % 10;
                    n = n / 10;
                }
                Console.WriteLine("numero invertido es: " + inverso);

            }

        }

        public static void punto2()
        {
            int a, b;
            float resultado;
            string c, operador;

            Console.WriteLine("ingrese la operacion siguiendo el siguiente orden: numero, enter operador, enter numero");
            c = Console.ReadLine();
            a = Convert.ToInt32(c);
            operador = Console.ReadLine();
            c = Console.ReadLine();
            b = Convert.ToInt32(c);

            switch (operador)
            {
                case "+":
                    resultado = a + b;
                    Console.WriteLine(resultado);
                    break;
                case "-":
                    resultado = a - b;
                    Console.WriteLine(resultado);
                    break;
                case "*":
                    resultado = a * b;
                    Console.WriteLine(resultado);
                    break;
                case "/":
                    resultado = a / b;
                    Console.WriteLine(resultado);
                    break;
            }

        }

        public static void punto3()
        {
            double resultado, a, c, d;
            string aux;

            Console.WriteLine("ingrese un nomero");
            aux = Console.ReadLine();
            a = Convert.ToDouble(aux);

            Console.WriteLine("ingrese la opcion que busca: \n1)valorabsoluto \n2)cuadrado \n3)raiz cuadrada " +
                "\n4)seno \n5)coseno \n6)entero de un flotante");

            aux = Console.ReadLine();

            switch (aux)
            {
                case "1":
                    resultado = Math.Abs(a);
                    Console.WriteLine(resultado);
                    break;
                case "2":
                    resultado = Math.Pow(a, 2);
                    Console.WriteLine(resultado);
                    break;
                case "3":

                    resultado = Math.Sqrt(a);
                    Console.WriteLine(resultado);
                    break;
                case "4":
                    resultado = Math.Sin(a);
                    Console.WriteLine(resultado);
                    break;
                case "5":
                    resultado = Math.Cos(a);
                    Console.WriteLine(resultado);
                    break;
                case "6":
                    resultado = Math.Round(a);
                    Console.WriteLine(resultado);
                    break;
            }

            Console.WriteLine("ingrese un dos numeros");
            aux = Console.ReadLine();
            c = Convert.ToDouble(aux);
            aux = Console.ReadLine();
            d = Convert.ToDouble(aux);

            Console.WriteLine("el maximo entre los numeros:" + Math.Max(c, d));
            Console.WriteLine("el minimo entre los numeros:" + Math.Min(c, d));

        }

    }
}
