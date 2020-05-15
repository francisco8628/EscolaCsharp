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

                Console.WriteLine("digite a materia 1"); //nota1
                string materia1 = Console.ReadLine();

               
                Console.WriteLine("digite a nota 1");
                string nota1 = Console.ReadLine();

                Console.WriteLine("digite a materia 2");
                string materia2 = Console.ReadLine();

                Console.WriteLine("digite a nota 2");
                string nota2 = Console.ReadLine();

                Console.WriteLine("digite a materia 3");
                string materia3 = Console.ReadLine();

                Console.WriteLine("digite a nota 3");
                string nota3 = Console.ReadLine();

                Console.WriteLine(aluno.getNome());
                Console.WriteLine(aluno.getMediaNota());

                Console.WriteLine(aluno.getAprovado()?"Aluno aprovado":"Aluno reprovado");

                Console.WriteLine(aluno);
            }
        }

    }
}
