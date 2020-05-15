using System;
using System.Collections.Generic;
using System.Text;

namespace EscolacSharpfr.Classes
{
    class Materia
    {
		private string Materia1;
		private String Materia2;
		private String Materia3;

		private double nota1;
		private double nota2;
		private double nota3;

		public String getMateria1()
		{
			return Materia1;
		}
		public void setMateria1(string materia1)
		{
			this.Materia1 = materia1;
		}
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


		}
}
