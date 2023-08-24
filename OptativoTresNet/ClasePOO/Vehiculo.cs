using System;

namespace OptativoTresNet.ClasePOO
{
	public abstract class Vehiculo
	{
		private string chapa;
		private string modelo;
		private int año;
        private string color;
		private string estado;


		public Vehiculo(string _chapa, string _modelo, int _año, string _color, string _estado)
		{
			this.chapa = _chapa;
			this.modelo = _modelo;
			this.año = _año;
			this.color = _color;
			this.estado = _estado;
		}

		public void setEstado(string _estado)
		{
			this.estado = _estado;
		}

		public string getEstado()
		{
			return this.estado;
		}

		public string getChapa()
		{
			return this.chapa;
		}

		public void setChapa(string chapa)
		{
			if (String.IsNullOrEmpty(chapa))
				return;
			this.chapa = chapa;
		}

		public abstract void arrancar();

		public virtual void frenar()
		{
			Console.WriteLine("Estas frenando, la velocidad va disminuyendo...");
		}
	}
}