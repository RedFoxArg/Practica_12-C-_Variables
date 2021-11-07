using System;

namespace PrimerProyectoConsolaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] arrayInt = new int[] {1, 2, 3, 4, 5};
            Console.WriteLine(arrayInt.Length); */
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Cadenas de caracteres - 1ra parte
            string nombre, apellido, nombreCompleto;
            Console.Write("\x1B[38;5;11m¡Hola! Ingresa tu nombre (y presiona Enter): \x1B[0m");
            nombre = Console.ReadLine();
            Console.Write("\x1B[38;5;11mIngresa tu apellido (y presiona Enter): \x1B[0m");
            apellido = Console.ReadLine();
            nombreCompleto = nombre + " " + apellido;
            string rtaUsuario;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\r\nBienvenido/a \x1B[38;5;15m{nombreCompleto}.\x1B[0m");
            
            Opciones();
            rtaUsuario = Console.ReadLine();
            
            if(rtaUsuario != "1" && rtaUsuario != "0"){
                do{
                    SolicitarOpcionValida(nombre);
                    rtaUsuario = Console.ReadLine();
                }while(rtaUsuario != "1" && rtaUsuario != "0");
            }
            // fin 1ra parte cadenas de caracteres
            
            if(rtaUsuario == "1"){
                // Variables numéricas.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\n\x1B[4mVariables Numéricas\x1B[0m\r\n");
                const int ancho = 20;
                float numero = 1452.546789F;
                int numeroEntero = 5;

                float total1 = SumarCinco(numero);
                float total2 = numero + 5;
                float total3;
                float total4;

                Console.WriteLine($"{numeroEntero, 10}");
                Console.WriteLine($"{numeroEntero, 10:f3}");
                Console.WriteLine($"{numero:C2}");
                Console.WriteLine($"{numeroEntero:C3}\r\n\r\n");

                // Suma 5
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\x1B[4mSuma 5:\x1B[0m\r\n");

                Console.WriteLine($"{numero, ancho:C3} + {numeroEntero, ancho:C3} = {total1, ancho:c3}");
                Console.WriteLine($"{numero, ancho:C3} + {numeroEntero, ancho:C3} = {total2, ancho:c3}");
                Console.WriteLine($"{numero, ancho:C3} + {numeroEntero, ancho:C3} = {SumarCinco(numero), ancho:c3}");
                Console.WriteLine($"{numero, ancho:C3} + {numeroEntero, ancho:C3} = {numero + numeroEntero, ancho:c3}");
                Console.WriteLine($"{numero, ancho:C3} + {numeroEntero, ancho:C3} = {numero + 5, ancho:c3}\r\n\r\n");
                
                // Resta 3
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\x1B[4mResta 3:\x1B[0m\r\n");
                total3 = numero - (numeroEntero = 3);

                Console.WriteLine($"{numero, ancho:C3} - {numeroEntero, ancho:C3} = {total3, ancho:c3}");
                Console.WriteLine($"{numero, ancho:C3} - {numeroEntero, ancho:C3} = {numero - numeroEntero, ancho:c3}");
                Console.WriteLine($"{numero, ancho:C3} - {numeroEntero, ancho:C3} = {numero - 3, ancho:c3}\r\n\r\n");
                
                // Multiplica 2
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\x1B[4mMultiplica por 2:\x1B[0m\r\n");
                numeroEntero-=1;
                total4 = numero * numeroEntero;
                
                Console.WriteLine($"{numero, (ancho-15):C3} x {numeroEntero, (ancho-15):C3} = {total4, (ancho-15):c3}");
                Console.WriteLine($"{numero, ancho:C3} x {numeroEntero, ancho:C3} = {numero * numeroEntero, ancho:c3}");
                Console.WriteLine($"{numero, ancho:C3} x {numeroEntero, ancho:C3} = {numero * 2, ancho:c3}\r\n\r\n");
                // fin variables numéricas.
            
                // Cadenas de caracteres - 3ra parte
                SaludoDespedida(nombre, apellido);
                // fin cadenas de caracteres

            }else{
                // Cadenas de caracteres - 2da parte
                SaludoDespedida(nombre, apellido);
                // fin cadenas de caracteres    
            }
        }

        private static float SumarCinco(float num)
        {
            for (int i = 0; i < 5; i++)
            {
                num++;
            }
            return num;
        }
        private static void SaludoDespedida(string nom, string ape)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\r\nLa aplicación a finalizado, hasta luego {0} {1}.\r\n\r\n", nom, ape);
            Console.ResetColor();
        }

        private static void SolicitarOpcionValida(string nomb)
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\r\n\x1B[1;3;4m{nomb}\x1B[0m\x1B[38;5;11m, debes ingrasar una opción válida.\x1B[0m\r\n");
            Opciones();
        }
        private static void Opciones()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\r\nIngresa ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1 (uno) ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("para \x1B[4miniciar\x1B[0m");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" la aplicación o ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("0 (cero) ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("para \x1B[4mfinalizar\x1B[0m: ");
        }
    }
}
