using System;
using System.Collections.Generic;
using System.IO;

public ref struct data
{
    public int id;
    public string user;
    public data(int id, string user){
        this.id = id;
        this.user = user;
    }
}

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            // C.R.U.D.
            int n = 1;
            //var Users = new List<string>() {null};
            //string User = "";
            data d;
            //d.id = 1;
            d.user = "";
        
            Console.WriteLine("\n\n - Menu - \n\n");
            Console.WriteLine("1.Acessar o opções\n0.Sair\n");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                while (n != 0)
                {
                    Console.WriteLine("Selecione uma opção:\n\n1.Cadastro de novo usuário\n2.Consultar Cadastros\n3.Update cadastro\n4.Deletar cadastro\n0.Retornar ao menu");
                    n = Convert.ToInt32(Console.ReadLine());

                    if ((n == 1) || (n == 2) || (n == 3) || (n == 4) || (n == 0))
                    {
                        switch(n)
                        {
                            case 1: // Inserir função CREATE
                                Console.WriteLine("Digite o nome de Usuário");
                                d.user = Console.ReadLine();
                            break;
                
                            case 2: // Inserir função READ (Consulta)
                                {   
                                    if(String.IsNullOrEmpty(d.user))
                                    {
                                        Console.WriteLine("Vazio!\n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine(d.user);
                                    }   
                                        Console.WriteLine("1.Voltar o menu\n0.Sair");
                                        n = Convert.ToInt32(Console.ReadLine());
                            break;
                                }
                            
                            case 3: // Inserir função update
                                {
                                    Console.Write("Opção 3\n\n");
                                    Console.WriteLine("1.Voltar o menu\n0.Sair");
                                    n = Convert.ToInt32(Console.ReadLine());
                                }
                            break;
                            
                            case 4: // Inserir função delete
                                {
                                    Console.Write("Opção 4\n\n");
                                    Console.WriteLine("1.Voltar o menu\n0.Sair");
                                    n = Convert.ToInt32(Console.ReadLine());
                                }
                            break;

                            default:
                                Console.WriteLine("1.Acessar opções\n0.Sair");
                                n = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    }
                }
            }
        }   
    }       
}           
                
                /*switch (caseSwitch)
                {
                    case 1:
                        break;


                    case 2:
                        Console.WriteLine("Digite o nome de Usuário");
                        Usaa = Console.ReadLine();
                        break;

                    case 3:
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
                        break;

                    case 4:
                        Console.WriteLine("Update");
                        if (caseSwitch == 4)
                        {
                            Console.WriteLine("Delete");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exit");
                        Environment.Exit(0);
                        break;
                
                    default:
                        Console.WriteLine("END");
                        break;
                    }
                else
                {
                Console.WriteLine("Erro! Selecione uma opção válida:\n");
                Console.WriteLine("1.Acessar o menu\n0.Sair");
                n = Convert.ToInt32(Console.ReadLine());
                }
        }       
    }
}
        */