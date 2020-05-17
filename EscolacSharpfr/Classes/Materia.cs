using System;
using System.Collections.Generic;
using System.Text;

namespace EscolacSharpfr.Classes
{
    class Materia
    {
		private string materia;  //nome da materia

		private double[] nota = new double[2]; //cada materia tera 2 notas

		public string getMateria()
		{
			return materia;
		}

		public void setMateria(string materia)
		{
			this.materia = materia;
		}

		public double[] getNota()
		{
			return nota;
		}

		public void setNota(double[] nota)
		{
			this.nota = nota;
		}

		public double getMediaMateria()
		{
			double mediaBimestre = 0;
			for (int i = 0; i < nota.Length; i++)
			{

				mediaBimestre += nota[i];
			}

			return mediaBimestre / nota.Length;
		}

	}//fim da classe
}
