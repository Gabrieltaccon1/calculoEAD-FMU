using System;

namespace teste_udemy
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome, retorno;
            double ra, atividaden1, atividaden2, resultado = 0;

            do
            {


                Console.WriteLine("DIGITE SEU NOME");
                nome = Console.ReadLine();

                Console.WriteLine("INFORME SEU RA");
                ra = double.Parse(Console.ReadLine());

                Console.WriteLine("DIGITE A NOTA DA SUA ATIVIDADE N1");
                atividaden1 = double.Parse(Console.ReadLine());

                Console.WriteLine("DIGITE A NOTA DA SUA ATIVIDADE N2");
                atividaden2 = double.Parse(Console.ReadLine());

                resultado = (atividaden1 * 0.4) + (atividaden2 * 0.7);




                if (resultado >= 6.75)
                {
                    Console.WriteLine(" Olá " + nome + " ! " + "Seu RA é: " + ra + ", Sua nota final é: " + resultado + " Você foi Aprovado! ");

                }
                else
                {

                    if (resultado <= 6.75 && resultado >= 3.75)
                    {

                        Console.WriteLine(" Olá " + nome + " ! " + "Seu RA é: " + ra + ", A SUA MÉDIA FINAL FOI: " + resultado + " NÃO ESQUEÇA DE ESTUDAR E MARCAR SEU EXAME"); ;

                    }
                    else
                    {
                        if (resultado <= 3.75)

                            Console.WriteLine(" Olá " + nome + " ! " + "Seu RA é: " + ra + ",  Sua nota final é: " + resultado + " INFELIZEMENTE VOCÊ NÃO ATINGIU A MEDIA FINAL PARA IR PARA EXAME");
                        Console.ReadLine();
                    }
                }
                Console.WriteLine("DESEJA INICIAR UMA NOVA CONSULTA? sim / não");
                retorno = Console.ReadLine();

            } while (retorno == "sim" || retorno == "SIM");

            Console.Clear();


        }   

    }
}
