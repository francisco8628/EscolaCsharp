using EscolacSharpfr.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscolacSharpfr.Executavel
{
    class ClasseExecutavel
    {
        class Program
        {
            static void Main(string[] args)
            {
                Aluno aluno = new Aluno();

                aluno.setNome("francisco");

                Console.WriteLine(aluno.getNome());
            }
        }

    }
}
