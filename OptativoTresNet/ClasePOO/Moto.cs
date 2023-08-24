using System;
namespace OptativoTresNet.ClasePOO
{
	public class Moto : Vehiculo
	{

        public Moto(string _chapa, string _modelo, int _año, string _color, string _estado) :
            base(_chapa: _chapa, _modelo: _modelo, _año: _año, _color: _color, _estado: _estado)
        {

		}

        public override void arrancar()
        {
            throw new NotImplementedException();
        }

        public override void frenar()
        {
            Console.WriteLine("Estas presionando la manija de freno de la moto");
            base.frenar();
        }
    }
}

