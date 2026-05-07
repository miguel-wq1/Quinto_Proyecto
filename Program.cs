using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;

class program
{
    static void Main()
    {
        Console.Clear();
        int Opcion = 0;
        Random random = new Random();

        do
        {
            Console.WriteLine("--- BIENVENIDO A MI JUEGO ---");
            Console.WriteLine("Elija Una Opción");
            Console.WriteLine("1. Jugar");
            Console.WriteLine("2. Salir del Programa");
            Opcion = int.Parse(Console.ReadLine());

            switch (Opcion)
            {
                case 1:
                 int Dificultad = 0;
                 Console.WriteLine("Excelente, que dificultad desea jugar");
                    do
                    {
                        Console.WriteLine("1. Fácil");
                        Console.WriteLine("2. Intermedio");
                        Console.WriteLine("3. Difícil");
                        Console.WriteLine("4. Salir al Menú");
                        Dificultad = int.Parse(Console.ReadLine());

                        while(Dificultad == 1)
                        {
                            int NumeroSecreto1 = random.Next(1,11);
                            Console.WriteLine("Ingrese Número a Adivinar");
                            int NumeroUsuario1 = int.Parse(Console.ReadLine());

                            if (NumeroUsuario1 > NumeroSecreto1)
                            {
                                Console.WriteLine("El Numero Secreto Es Menor");
                                NumeroUsuario1 = int.Parse(Console.ReadLine());
                            }
                            else if(NumeroUsuario1 < NumeroSecreto1)
                            {
                                Console.WriteLine("El Número Secreto Es Mayor");
                                NumeroUsuario1 = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine(" ¡FELICIDADES, HAS GANADO EL JUEGO!");
                            }
                        
                        }
                     while (Dificultad == 2)
                        {
                            int NumeroSecreto2 = random.Next(1,101);
                            Console.WriteLine("Ingrese Numero a Adivinar");
                            int NumeroUsuario2 = int.Parse(Console.ReadLine());

                            if(NumeroUsuario2 > NumeroSecreto2)
                            {
                                Console.WriteLine("El Número Secreto Es Menor");
                                NumeroUsuario2 = int.Parse(Console.ReadLine());
                            }
                            else if (NumeroUsuario2 < NumeroSecreto2)
                            {
                                Console.WriteLine("El Numero Secreto Es Mayor");
                                NumeroUsuario2 = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("FELICIDADES HAS GANADO EL JUEGO");
                            }

                         
                        }
                        while(Dificultad == 3)
                        {
                            int NumeroSecreto3 = random.Next(1,1001);
                            Console.WriteLine("Ingrese Numero a Adivinar");
                            int NumeroUsuario3 = int.Parse(Console.ReadLine());
                             
                             if (NumeroUsuario3 > NumeroSecreto3)
                            {
                                Console.WriteLine("El Número Secreto Es Menor");
                                NumeroUsuario3 = int.Parse(Console.ReadLine());
                            }
                            else if (NumeroUsuario3 < NumeroSecreto3)
                            {
                                Console.WriteLine("El Número Secreto Es Menor");
                                NumeroUsuario3 = int.Parse(Console.ReadLine());
                            }
                        }
                    }while(Dificultad != 4);
                break;

                case 2:
                 Console.WriteLine("SALIENDO DEL PROGRAMA...");
                break;
            }

            
        }while (Opcion != 2);
    }
}