using System;

int user_code; int password;
int user_code_target = 1234;
int password_target = 9999;
int op = 2;

do 
{
    Console.WriteLine("Qual o código do usuário?");
    user_code = Convert.ToInt32(Console.ReadLine());
    if(user_code == user_code_target)
    {
        Console.WriteLine("Digite a senha: ");
        password = Convert.ToInt32(Console.ReadLine());
        
        if(password == password_target)
        {
            Console.WriteLine("Acesso permitido!\nEncerrando sistema...");
            break;
        }
        else
        {
            Console.WriteLine("Senha inválida!\n\n1 - Tentar novamente.\n0 - Encerrar sistema.");
            op = Convert.ToInt32(Console.ReadLine());
        }
    }
    else
    {
        Console.WriteLine("Usuário inválido!");
    }
}while(op != 0); 