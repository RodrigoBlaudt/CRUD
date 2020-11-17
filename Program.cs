using System;
using System.Collections.Generic;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            // C.R.U.D.
            int n = 0;
            var Users = new List<string>() {null};
            int id = 1;
            do
            {
                Console.WriteLine("Selecione uma opção:\n\n1.Cadastro de novo usuário\n2.Consultar Cadastros\n3.Update cadastro\n4.Deletar cadastro\n5.Sair");
                n = Convert.ToInt32(Console.ReadLine());
                
                if (n == 1)
                {
                    Console.WriteLine("Digite o nome de Usuário");
                    Users[0] = Console.ReadLine();
                }

                if (n == 2)
                {
                    if (String.IsNullOrEmpty(Users[0]))
                        {
                            Console.WriteLine("Vazio!");
                        }
                    else
                    {
                        Console.WriteLine("Read: Usuários cadastrados");
                        foreach (string User in Users)
                        {
                            Console.WriteLine($"id: {id} | user: {User}");
                        }
                        Console.WriteLine(Users);
                    }
                }

                if (n == 3)
                {
                    Console.WriteLine("Update");
                }

                if (n == 4)
                {
                    Console.WriteLine("Delete");
                }

                if (n == 5)
                {
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                }
                Console.WriteLine(n);
            }while (n < 5);
        }
    }
}