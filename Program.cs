using System.Diagnostics;
using System.Security.Principal;

namespace DesafioPratico;

class DesafioPratico
{
    static void Main()
    {
        Console.Write("Menu:\n" +
                          "1 -> Mensagem de Boas Vindas;\n" +
                          "2 -> Concatenação de Nome e Sobrenome \n" +
                          "3 -> Operações matemáticas \n" +
                          "4 -> Impressão de quantidade de caracteres de uma string \n" +  
                          "5 -> Validação de placa brasileira até 2018\n" +
                          "6 -> Exibição da data atual \n" +
                          "Escolha a opção desejada: "
                          );
            
        var escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                OpcoesClass.MensagemBoasVindas();
                break;
            
            case "2":
                OpcoesClass.ConcatenaNomeSobrenome();
                break;
            
            case "3":
                OpcoesClass.OperacoesMatematicas();
                break;
            
            case "4":
                OpcoesClass.QuantidadeCaracteresString();
                break;
            
            case "5":
                OpcoesClass.ValidacaoPlacaBrasileira();
                break;
            
            case "6":
                OpcoesClass.ImprimeDatas();
                break;
        }
    }
}