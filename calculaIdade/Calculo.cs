
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Calcula_idade



{

    public class Calculo

    {



        public int LeiaValorNumerico(string mensagemParaUsuario)

        {



            bool numeroEhValido = false;



            int numeroInformadoPeloUsuario = 0;



            while (!numeroEhValido)

            {

                Console.WriteLine(mensagemParaUsuario);



                var valorInformadoPeloUsuario = Console.ReadLine();



                numeroEhValido = int.TryParse(valorInformadoPeloUsuario, out numeroInformadoPeloUsuario);



                if (!numeroEhValido)

                {

                    Console.WriteLine("Numero invalido");



                }



            }

            return numeroInformadoPeloUsuario;









        }

    }

}


