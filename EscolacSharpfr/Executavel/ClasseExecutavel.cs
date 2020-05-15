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
                aluno.setNota1(90);
                aluno.setNota2(70);
                aluno.setNota3(85);

                Console.WriteLine(aluno.getNome());
                Console.WriteLine(aluno.getMediaNota());
            }
        }

    }
}
