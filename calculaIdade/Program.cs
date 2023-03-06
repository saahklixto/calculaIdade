using System;

using System.Collections.Generic;

using System.Linq;

using System.Runtime.InteropServices;

using System.Text;

using System.Threading.Tasks;





namespace Calcula_idade

{



    class Program

    {

        static void Main(string[] args)

        {



            Console.WriteLine("Escreva seu nome");

            string nome = Console.ReadLine();





            bool dataDeNascimentoEhValida = false;

            DateTime dataDeNascimento = DateTime.Now;



            while (!dataDeNascimentoEhValida)

            {



                



                string Data = Console.ReadLine();
                string[] strData = Data.Split('/');
                Console.WriteLine(string.Format("dia : {0}", strData[0]));
                Console.WriteLine(string.Format("Mes : {0}", strData[1]));
                Console.WriteLine(String.Format("Ano: {0} ", strData[2]));

                Console.ReadKey();
                Calculo idade = new Calculo();

                //Data = idade.LeiaValorNumerico(nome + " informe o seu dia de nascimento: ");




                //mes = LeiaValorNumerico("Informe o seu mês de nascimento: "); 

                //ano = LeiaValorNumerico("Informe o seu ano de nascimento: "); 

             
               
                //estuda array de string 





                try

                {

                    dataDeNascimento = new DateTime();

                    dataDeNascimentoEhValida = true;

                }



                catch (Exception)

                {

                    Console.WriteLine("Data de nascimento inválida.");

                }





            }

            var idadeDaPessoa = (int)(DateTime.Today.Subtract(dataDeNascimento).TotalDays / 365);

            Console.WriteLine(nome + " tem " + idadeDaPessoa + " anos.");



        }



    }

}







