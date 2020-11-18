using System;

struct data
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
            int[] id;
            id = new int[5000];
            string[] nomes;
            nomes = new string[5000];
            int cont = 1;

            //data d;           /STRUCT
            //d.user = "R";     /STRUCT
        
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
                                if (cont < 5)
                                {
                                    nomes[cont] = Console.ReadLine();
                                    id[cont] = cont;
                                    cont++;
                                }
                            break;

                            case 2: // Inserir função READ (Consulta)   
                                if(String.IsNullOrEmpty(nomes[1]))
                                {
                                    Console.WriteLine("Vazio!\n\n");
                                }
                                else
                                {
                                    for(int i = 1; i < cont; i++)
                                    {
                                        Console.WriteLine($"ID: {id[i]}, Usuário: {nomes[i]}");
                                    }
                                }
                                    Console.WriteLine("1.Voltar o menu\n0.Sair");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    break;
                            
                            case 3: // Inserir função update
                                if(String.IsNullOrEmpty(nomes[1]))
                                {
                                    Console.WriteLine("Vazio!\n\n");
                                }
                                else
                                {
                                    Console.WriteLine("Qual id deseja atualizar?");
                                    int update = Convert.ToInt32(Console.ReadLine());
                                    for(int i = 1; i <= update; i++)
                                    {
                                        if(id[i] == update)
                                        {
                                            Console.WriteLine("Digite novo nome de usuário: ");
                                            nomes[update] = Console.ReadLine();
                                            Console.WriteLine("\n\nAtualizado com sucesso!\n\n");
                                        }
                                    }
                                }
                                Console.WriteLine("1.Voltar ao menu\n0.Sair");
                                n = Convert.ToInt32(Console.ReadLine());
                                break;
                            
                            case 4: // Inserir função delete
                                Console.WriteLine("Qual ID deseja remover?");
                                int id_remove = Convert.ToInt32(Console.ReadLine());
                                /*if (id > 0)
                                {
                                    for (int i = 0; i < id; i++)
                                    {
                                        if (id == id_remove)
                                        {
                                            for (int j = i; j < id;j++)
                                            {
                                                //id[j] = id[j+1];
                                            }
                                        id--;
                                        }
                                    }
                                }*/
                                Console.WriteLine("1.Voltar o menu\n0.Sair");
                                n = Convert.ToInt32(Console.ReadLine());
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