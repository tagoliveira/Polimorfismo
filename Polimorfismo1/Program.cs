using System;

namespace Polimorfismo1
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica obj_pf = new PessoaFisica();
            obj_pf.gravar("Thiago", "Rua", "adsf", "2342342", 34);
            Console.WriteLine(obj_pf.getNome());
            Console.WriteLine(obj_pf.getEndereco());
            Console.WriteLine(obj_pf.getApelido());
            Console.WriteLine(obj_pf.getCpf());
            Console.WriteLine(obj_pf.getIdade());
        }
    }
}
