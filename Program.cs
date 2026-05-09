using System;


class program
{
    static void Main()
    {
        Console.Clear();
        int Opcion = 0;
        Random random = new Random();
        int LimiteMaximo = 0;

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

                        int NumeroSecreto1 = random.Next(1,11);
                        bool Ganador1 = false;
                        while(Dificultad == 1 && Ganador1 == false)
                        {
                            
                            Console.WriteLine("Ingrese Número a Adivinar");
                            int NumeroUsuario1 = int.Parse(Console.ReadLine());

                            if (NumeroUsuario1 > NumeroSecreto1)
                            {
                                Console.WriteLine("El Numero Secreto Es Menor");
                                
                            }
                            else if(NumeroUsuario1 < NumeroSecreto1)
                            {
                                Console.WriteLine("El Número Secreto Es Mayor");
                                
                            }
                            else
                            {
                                Console.WriteLine(" ¡FELICIDADES, HAS GANADO EL JUEGO!");
                                Ganador1 = true;
                            }
                        
                        }

                      int NumeroSecreto2 = random.Next(1,51);
                      bool Ganador2 = false;
                     while (Dificultad == 2 && Ganador2 == false)
                        {
                            
                            Console.WriteLine("Ingrese Numero a Adivinar");
                            int NumeroUsuario2 = int.Parse(Console.ReadLine());

                            if(NumeroUsuario2 > NumeroSecreto2)
                            {
                                Console.WriteLine("El Número Secreto Es Menor");
                                
                            }
                            else if (NumeroUsuario2 < NumeroSecreto2)
                            {
                                Console.WriteLine("El Numero Secreto Es Mayor");
                                
                            }
                            else
                            {
                                Console.WriteLine("FELICIDADES HAS GANADO EL JUEGO");
                                Ganador2 = true;
                            }

                         
                        }
                        int NumeroSecreto3 = random.Next(1,101);
                        while(Dificultad == 3)
                        {
                           
                            Console.WriteLine("Ingrese Numero a Adivinar");
                            int NumeroUsuario3 = int.Parse(Console.ReadLine());
                             
                             if (NumeroUsuario3 > NumeroSecreto3)
                            {
                                Console.WriteLine("El Número Secreto Es Menor");
                                
                            }
                            else if (NumeroUsuario3 < NumeroSecreto3)
                            {
                                Console.WriteLine("El Número Secreto Es Mayor");
                                
                                
                            }
                            else
                            {
                                Console.WriteLine("FELICIDADES, HAS GANADO EL JUEGO");
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