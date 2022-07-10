

namespace variaveis_constantes
{
    class Program
    {
        public const int SAIDA_PROGRAMA = 1;
        static void Main(String[] args)
        {
            while (true) { 
            Console.WriteLine("Digite " + SAIDA_PROGRAMA  + " para sair do programa ");
            int valor = int.Parse(Console.ReadLine());

            if(SAIDA_PROGRAMA == valor)
            {
                break;
            }
          }
       }

    }

    
}