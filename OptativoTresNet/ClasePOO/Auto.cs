using System;
namespace OptativoTresNet.ClasePOO
{
	public class Auto : Vehiculo
	{
        private string tamañoValija;
        private string tipoValija;

        public Auto(string _chapa,
					string _modelo,
					int _año,
					string _color,
					string _estado,
					string _tamañoValija,
					string _tipoValija ) : base(_chapa: _chapa,
												_modelo: _modelo,
												_año: _año,
												_color: _color,
												_estado: _estado)
		{
			this.tamañoValija = _tamañoValija;
			this.tipoValija = _tipoValija;
		}

        public override void arrancar()
        {
            
        }

        public override void frenar()
        {
			Console.WriteLine("Estas presionando el pedal de freno del auto");
            base.frenar();
        }
    }
}

