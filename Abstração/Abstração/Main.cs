using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração
{
    class Program
    {
        static void Main(string[] args) 
        {
            Cachorro cachorro = new Cachorro { Nome = "Rex", Idade = 3 };
            Gato gato = new Gato { Nome = "Yuumi", Idade = 2 };

            cachorro.EmitirSom();
            gato.EmitirSom();

        }
    }
}
