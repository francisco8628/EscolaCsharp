using System;
using System.Collections.Generic;
using System.Text;

namespace EscolacSharpfr.Classes
{
    class Aluno
    {
        private string nome;

        private int idade;

        private string Materia;

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
			return Materia;
		}

		public void setMateria(String materia)
		{
			Materia = materia;
		}



	}
}
