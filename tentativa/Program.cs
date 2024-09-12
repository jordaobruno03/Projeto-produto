using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemproduto
{
    public class Program

    { 
        static void Main(string[] args)
        {
            InfoProdutos info = new InfoProdutos();
            ReceberString(info);  //Recebe Strings
            ReceberNumeros(info);  //Recebe Numeros 
            Resumo(info); //Imprime todas as informaçoes digitadas 
            Msg(info);  // Mensagem informando q ira aparecer os valores calculados
            Taxa(info);  //Switch que define a origem escolhida
            Taxa2(info); // Calcula o frete
            Descontos(info); // Calcula desconto
            Final(info);   // exibe a mensagem final 
            Console.ReadLine(); //stop
        }

        private static void ReceberString(InfoProdutos info)
        {
            
            
                Console.WriteLine("Digite o nome do produto: ");
                info.nome = Console.ReadLine();
                Console.Clear();    

            do { 
                Console.WriteLine("De 1 a 12 digite o mês de  validade do produto: ");
                info.datavalidade = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (info.datavalidade > 12)
                {
                    Console.WriteLine("Informação Inválida tente novamente:");
                }
            } while (Convert.ToBoolean(info.datavalidade > 12));


            do
            { 
                Console.WriteLine("Digite o numero de acordo com sua região: ");
                Console.WriteLine("1. Sudeste");
                Console.WriteLine("2. Centro-Oeste");
                Console.WriteLine("3. Norte");
                Console.WriteLine("4. Sul");
                Console.WriteLine("5. Nordeste");
                info.origem = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (info.origem > 5)
                {
                    Console.WriteLine("Informação Inválida tente novamente:");
                }
            } while (Convert.ToBoolean(info.origem >5 ));

        }
            

        private static void ReceberNumeros(InfoProdutos info)
        {
            Console.WriteLine("Digite o valor do produto: ");
            info.valor = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            
            Console.WriteLine("Digite a quantidade desejada: ");
            info.quantidade = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            do 
            {
                Console.WriteLine(" De 1 a 12 digite o mes de aquisição do produto: ");
                info.mesaquisicao = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (info.mesaquisicao > 12)
                {
                    Console.WriteLine("Informação Inválida tente novamente:");
                }
            } while (Convert.ToBoolean(info.mesaquisicao > 12));


        }


        static void Descontos(InfoProdutos info)
        {
            info.valorcalculado = info.valor * info.quantidade;

            if (info.mesaquisicao <= 7) {
                Console.WriteLine(string.Format("Seu desconto foi de 30%: R${0}  ",info.finaldes =  info.valorcalculado * 0.30));
            }
            else
            {
                Console.WriteLine(string.Format("Seu desconto foi de 50%: R${0}  ", info.finaldes = info.valorcalculado * 0.50));

            }

        }

        public static double Taxa(InfoProdutos info)
        
           
            {
                switch (info.origem)
                {
                    case 1:

                        return info.taxaorigem = 0.1;

                    case 2:

                        return info.taxaorigem = 0.2;

                    case 3:

                        return info.taxaorigem = 0.3;
                    case 4:

                        return info.taxaorigem = 0.4;
                    case 5:

                        return info.taxaorigem = 0.5;
                    default:
                    return 0;
                     
                
            } 

        }

        public static void Taxa2(InfoProdutos info)

        {
            info.valorcalculado = info.valor * info.quantidade;

            Console.WriteLine("A taxa de frete foi de: R${0}",info.taxaorigem * info.valorcalculado);

        }

        public static void Resumo(InfoProdutos info)
        {
            Console.WriteLine("\n\nO nome do produto é: {0} ", info.nome);
            Console.WriteLine("O produto vence no mes: {0} ", info.datavalidade);
            Console.WriteLine("Sua regiao é: {0} ", info.origem);
            Console.WriteLine("O valor do produto é: {0} ", info.valor);
            Console.WriteLine("A quantidade é: {0} ", info.quantidade);
            Console.WriteLine("A aquisição foi no mes: {0} ", info.mesaquisicao);


        }

        public static void Msg(InfoProdutos info)
        {
            Console.WriteLine("\n\nDe acordo com as informaçoes digitadas, aqui esta o calculo com Desconto, Frete e o valor Final: \n\n");



        }

        public static void Final(InfoProdutos info)
        {
            info.valorcalculado = info.valor * info.quantidade;

            Console.WriteLine("O valor final é de: R${0} ", info.valorcalculado + info.taxaorigem * info.valorcalculado - info.finaldes );

        }

    }





}
