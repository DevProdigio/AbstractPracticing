using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração
{
    abstract class Animal()
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public abstract void EmitirSom();
    }

    class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} diz: Au Au!");
        }

    }

    class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} Diz: Miau!");
        }

    }
}
