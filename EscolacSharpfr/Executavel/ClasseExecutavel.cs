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

                for (int i = 1; i <= Convert.ToInt32(qtd); i++)//seta materia
                {
                    Materia materia = new Materia();
                    Console.WriteLine("digite o nome da Materia: " + i);
                    string nomeMateria = Console.ReadLine();
                    materia.setMateria(nomeMateria);

                    double[] notas = new double[2];
                    for (int x = 0; x < 2; x++)  //seta nota
                    {
                        Console.WriteLine("digite a nota : " + (x+1));
                        string nota = Console.ReadLine();
                        notas[x] = Convert.ToDouble(nota);                   

                    
                    materia.setNota(notas);

                    }
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

                
                foreach (Materia m in aluno.getMaterias())
                {
                  

                    Console.WriteLine(" A Materia : "+m.getMateria());

                    for(int a = 0; a < 2; a++)
                    Console.WriteLine(" tem Nota: " + m.getNota()[a]);
                    
                }

                Console.WriteLine(" A media do aluno é : " + aluno.getMediaNota());
                Console.WriteLine(" O Aluno esta : " + (aluno.getAprovado() ? " Aprovado" : " Reprovado"));





            }
        }

    }
}

