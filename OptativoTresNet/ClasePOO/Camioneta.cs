using System;
namespace OptativoTresNet.ClasePOO
{
	public class Camioneta : Vehiculo
	{
		public Camioneta(string _chapa, string _modelo, int _año, string _color, string _estado) :
            base(_chapa: _chapa, _modelo: _modelo, _año: _año, _color: _color, _estado: _estado)
        {

		}

        public override void arrancar()
        {
            throw new NotImplementedException();
        }
    }
}

