using System;

namespace projeto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = DateTime.Now.Year;
            //escrita para o ano da pessoa
            Console.WriteLine("_____________________________");
            Console.WriteLine("Escreva o ano em que nasceu: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_____________________________");
            //nota da prova
            Console.WriteLine("Qual foi a sua nota da prova: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            //idade do aluno e nota da prova
            if (idade >=1931 && idade <=2003){
                Console.WriteLine("Voce poderia tirar a sua habilitação há: "+((anoAtual-idade)-18)+" anos");
                Console.WriteLine("Voce tem idade para tirar a sua habilitação.");
                    if(a1 >= 70.0)
                    {
                     System.Console.WriteLine("E tambem tirou uma boa nota na prova!");
                    }else
                    {                    
                     System.Console.WriteLine("Mas, a sua nota não foi suficiente: "+ a1);
                    }
            }else
            {
                System.Console.WriteLine("\nNão pode tirar habilitação");       //aluno nao pode tirar a carteira
                Console.WriteLine("Voce ainda precisa de alcançar 18 anos.");   
                Console.WriteLine("Faltam: "+ (idade-2003)+" ano(s)");          //calculo para ver a idade que falta para tirar a habilitação
            }
            }

        }
}
