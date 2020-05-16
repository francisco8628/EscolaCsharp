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

                Console.WriteLine("digite a quantidade de materias do aluno");
                string qtd = Console.ReadLine();

                for (int i = 1; i <= Convert.ToInt32(qtd); i++)
                {
                    Materia materia = new Materia();
                    Console.WriteLine("digite o nome da Materia: " + i);
                    string nome = Console.ReadLine();

                    Console.WriteLine("digite a nota : " + i);
                    string nota = Console.ReadLine();

                    materia.setMateria(nome);
                    materia.setNota(Double.Parse(nota));

                    aluno.getMaterias().Add(materia);
                }


                Console.WriteLine("deseja remover alguma materia? digite 0 para sim ou  1 para não");
                string remover = Console.ReadLine();

                if (Convert.ToInt32(remover) == 0)
                {
                    Console.WriteLine("Digite de 1 a" + qtd);
                    string escolha = Console.ReadLine();

                    if (Convert.ToInt32(escolha) - 1 < Convert.ToInt32(qtd))
                    {

                        aluno.getMaterias().RemoveAt(Convert.ToInt32(escolha) - 1);
                    }
                    else
                    {

                        Console.WriteLine("valor não encontrado");
                    }
                }//fim if remove

                for (int i = 0; i < Convert.ToInt32(qtd); i++)
                {
                    List<Materia> materias = aluno.getMaterias();

                    Console.WriteLine(" A Materia : "+materias[i].getMateria());
                    Console.WriteLine(" tem Nota: " + materias[i].getNota());
                    
                }

                Console.WriteLine(" A media do aluno é : " + aluno.getMediaNota());
                Console.WriteLine(" O Aluno esta : " + (aluno.getAprovado() ? " Aprovado" : " Reprovado"));





            }
        }

    }
}

