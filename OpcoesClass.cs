using System.Diagnostics;
using System.Globalization;

namespace DesafioPratico;

public class OpcoesClass
{
    public static void MensagemBoasVindas()
    {
        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine();
        string mensagem = string.Format("Olá, {0}! Seja muito bem-vindo!",nome);
        Console.WriteLine(mensagem);
    }

    public static void ConcatenaNomeSobrenome()
    {
        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o seu sobrenome: ");
        string sobreNome = Console.ReadLine();
        
        string nomeSobrenome = string.Format("{0} {1}", nome, sobreNome);
        Console.WriteLine(nomeSobrenome);
    }

    public static void OperacoesMatematicas()
    {
        Console.WriteLine("Digite o primeiro número: ");
        string stringNum1 = Console.ReadLine();
        Console.WriteLine("Digite o segundo número: ");
        string stringNum2 = Console.ReadLine();
        
        double num1= double.Parse(stringNum1);
        double num2= double.Parse(stringNum2);
        
        double multiplicacao = num1 * num2;
        double divisao = num1 / num2;
        double soma = num1 + num2;
        double subtracao = num1 - num2;
        
        double media = (num1 + num2) / 2;
        
        Console.WriteLine(string.Format("Soma: {0}\n" + "Subtracao: {1}\n" + "Multiplicação: {2}\n" + "Divisão: {3}\n" + "Média: {4}", soma, subtracao, multiplicacao, divisao, media));
    }

    public static void QuantidadeCaracteresString()
    {
        Console.WriteLine("Digite uma string: ");
        string inputString = Console.ReadLine();
        
        Console.WriteLine(inputString.Length);
    }

    public static void ValidacaoPlacaBrasileira()
    {
        Console.WriteLine("Digite a placa: ");
        string placa = Console.ReadLine();

        if (placa.Length != 7)
        {
            Console.WriteLine("A placa digitada é inválida. Falta caracteres.");
            
        }

        string primeirosCaracteres = placa.Substring(0, 3);
        bool primeirosCaracteresSaoString = !int.TryParse(primeirosCaracteres, out int resultado);
        
        string ultimosCaracteres = placa.Substring(placa.Length - 4, 4);
        bool ultimosCaracteresSaoInteiros = int.TryParse(ultimosCaracteres, out int resultadoInteiro);

        string retorno = "";
        
        if (primeirosCaracteresSaoString && ultimosCaracteresSaoInteiros)
        {
            retorno += (string.Format("Placa é válida. Primeiros Caracteres: {0} Ultimos caracteres: {1}", primeirosCaracteresSaoString, ultimosCaracteresSaoInteiros));
        } 
        
        if (!primeirosCaracteresSaoString)
        {
            retorno += (string.Format("Os tres primeiros caracteres precisam ser do tipo string! Primeiros Caracteres: {0} Ultimos caracteres: {1}\n", primeirosCaracteresSaoString, ultimosCaracteresSaoInteiros));
        }  
        
        if (!ultimosCaracteresSaoInteiros)
        {
            retorno += (string.Format("Os ultimos quatro ultimos caracters precisam ser numericos! Primeiros Caracteres: {0} Ultimos caracteres: {1}\n", primeirosCaracteresSaoString, ultimosCaracteresSaoInteiros ));
        }
        
        Console.WriteLine(retorno);

    }

    public static void ImprimeDatas()
    {
        DateTime dataHora = DateTime.Now;
        Console.Write("Formatos: \n" + 
                      "1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)\n" + 
                      "2 - Apenas a data no formato 01/03/2024\n" + 
                      "3 - Apenas a hora no formato de 24 horas\n" + 
                      "4 - A data com o mês por extenso");
        string opcaoSeleccionada = Console.ReadLine();

        switch (opcaoSeleccionada)
        {
            case "1":
					Console.WriteLine(dataHora.ToString("dddd, dd/MM/yyyy hh:mm:ss", CultureInfo.CurrentCulture));
                break;
            case "2":
                Console.WriteLine(dataHora.ToString("d", CultureInfo.CurrentCulture));
                break;
            case "3":
                Console.WriteLine(dataHora.ToString("T", CultureInfo.CurrentCulture));
                break;
            case "4":
                Console.WriteLine(dataHora.ToString("f", CultureInfo.CurrentCulture));
                break;
        }

    }
}