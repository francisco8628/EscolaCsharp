using System;
using System.Collections.Generic;
using System.Text;

namespace EscolacSharpfr.Classes
{
    class Aluno
    {
        private string nome;

        private int idade;

        private string Materia1;
		private string Materia2;
		private string Materia3;

		private double nota1;
		private double nota2;
		private double nota3;

		public String getMateria2()
		{
			return Materia2;
		}

		public void setMateria2(String materia2)
		{
			Materia2 = materia2;
		}

		public String getMateria3()
		{
			return Materia3;
		}

		public void setMateria3(String materia3)
		{
			Materia3 = materia3;
		}

		public double getNota1()
		{
			return nota1;
		}

		public void setNota1(double nota1)
		{
			this.nota1 = nota1;
		}

		public double getNota2()
		{
			return nota2;
		}

		public void setNota2(double nota2)
		{
			this.nota2 = nota2;
		}

		public double getNota3()
		{
			return nota3;
		}

		public void setNota3(double nota3)
		{
			this.nota3 = nota3;
		}

		public String getNome()
		{
			return nome;
		}

		public void setNome(String nome)
		{
			this.nome = nome;
		}

		public int getIdade()
		{
			return idade;
		}

		public void setIdade(int idade)
		{
			this.idade = idade;
		}

		public String getMateria()
		{
			return Materia1;
		}

		public void setMateria(String materia)
		{
			Materia1 = materia;
		}

		public double getMediaNota()
		{

			return (nota1 + nota2 + nota3) / 3;
		}

		public Boolean getAprovado()//se tiver aprovado
		{

			double media = getMediaNota();

			if (media >= 70)
			{

				return true;

			}
			else
			{
				return false;
			}

		}

		public override string ToString()
		{
			return  "Aluno [nome=" + nome + ", idade=" + idade + ", Materia1=" + Materia1 + ", Materia2=" + Materia2
				+ ", Materia3=" + Materia3 + ", nota1=" + nota1 + ", nota2=" + nota2 + ", nota3=" + nota3 + "]";

		}

	}
}
