using System;
using System.Runtime.Serialization;


class program
{
    static void Main()
    {
        Console.Clear();
        int Opcion = 0;
        Random random = new Random();
        int LimiteMaximo = 0;
        int NumeroSecreto = 0;
        int NumeroUsuario = 0;
        bool Ganador = false;

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
                        
                        if (Dificultad != 4)
                        {
                            
                        
                         if (Dificultad == 1)
                         {
                            LimiteMaximo = 11;
                         }
                        
                         if (Dificultad == 2)
                         {
                            LimiteMaximo = 51;
                         }

                         if (Dificultad == 3)
                         {
                            LimiteMaximo = 101;
                         }

                        

                         NumeroSecreto = random.Next(1, LimiteMaximo);
                         Ganador = false;
                        


                        
                          while(!Ganador)
                         {
                            
                            Console.WriteLine("Ingrese Número a Adivinar");
                            NumeroUsuario = int.Parse(Console.ReadLine());
                            

                            if (NumeroUsuario> NumeroSecreto)
                            {
                                Console.WriteLine("El Numero Secreto Es Menor");
                                
                            }
                            else if(NumeroUsuario< NumeroSecreto)
                            {
                                Console.WriteLine("El Número Secreto Es Mayor");
                                
                            }
                            else
                            {
                                Console.WriteLine(" ¡FELICIDADES, HAS GANADO EL JUEGO!");
                                Ganador = true;
                            }
                        
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