using System;
using System.Collections.Generic;
using System.Text;

namespace EscolacSharpfr.Classes
{
    class Materia
    {
		private string materia;
		private double nota;

		public string getMateria()
		{
			return materia;
		}

		public void setMateria(string materia)
		{
			this.materia = materia;
		}

		public double getNota()
		{
			return nota;
		}

		public void setNota(double nota)
		{
			this.nota = nota;
		}

	}//fim da classe
}
