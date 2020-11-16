using System;

namespace Estruturas_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18){
                Console.WriteLine("Você gostaria de participar do time de CS GO");
                string resposta = (Console.ReadLine());

                if(resposta == "Sim"){
                    Console.WriteLine ("Compareça a secretaria - falar com Sara");                    
                }else{
                    Console.WriteLine ("Passar bem");
                }
                }else{
                Console.WriteLine ("Você gostaria de particpar do time de LOL? - Sim ou Não ");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Compareça a secretaria - falar com Jucelino");

                }else{
                    Console.WriteLine ("Muito Obrigado");
                }
            }
            
            }
        }
    }

