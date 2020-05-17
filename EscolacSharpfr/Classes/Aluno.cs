using System;
using System.Collections.Generic;
using System.Text;

namespace EscolacSharpfr.Classes
{
    class Aluno
    {
        private string nome;

        private int idade;

		List<Materia> materias = new List<Materia>();

		public List<Materia> getMaterias()
		{
			return materias;
		}

		public void setMaterias(List<Materia> materias)
		{
			this.materias = materias;
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

		

		public double getMediaNota()
		{
			double media = 0;
			int size = 0;
			foreach(Materia materia in materias)
			{

				media += materia.getMediaMateria();
				size++;
			}

			return media / size;
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
			return base.ToString();
		}


	}
}
