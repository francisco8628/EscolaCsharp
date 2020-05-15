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
                
                Console.WriteLine("digite a materia 1"); //nota1
                string materia1 = Console.ReadLine();
                aluno.getMateria().setMateria1(materia1);
                /************************************************/

                Console.WriteLine("digite a nota 1");
                string nota1 = Console.ReadLine();
                aluno.getMateria().setNota1(Double.Parse(nota1));

                /************************************************/

                Console.WriteLine("digite a materia 2");
                string materia2 = Console.ReadLine();
                aluno.getMateria().setMateria2(materia2);

                /************************************************/

                Console.WriteLine("digite a nota 2");
                string nota2 = Console.ReadLine();
                aluno.getMateria().setNota2(Double.Parse(nota2));

                /************************************************/

                Console.WriteLine("digite a materia 3");
                string materia3 = Console.ReadLine();
                aluno.getMateria().setMateria3(materia3);
                /************************************************/

                Console.WriteLine("digite a nota 3");
                string nota3 = Console.ReadLine();
                aluno.getMateria().setNota3(Double.Parse(nota3));
                /************************************************/
                aluno.setNome("francisco");
                Console.WriteLine(aluno.getNome());
                

                Console.WriteLine("A materia : " +aluno.getMateria().getMateria1()+ ", tem nota : "+aluno.getMateria().getNota1());
                Console.WriteLine("A materia : " + aluno.getMateria().getMateria2() + ", tem nota : " + aluno.getMateria().getNota2());
                Console.WriteLine("A materia : " + aluno.getMateria().getMateria3() + ", tem nota : " + aluno.getMateria().getNota3());

                Console.WriteLine(" A media das notas é: " + aluno.getMediaNota());

                Console.WriteLine(aluno.getAprovado() ? "Aluno aprovado" : "Aluno reprovado");
            }
        }

    }
}
