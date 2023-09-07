using System;
using Npgsql;
namespace OptativoTresNet.Conexiones
{
	public class ConexionDB
	{
		private string cadenaConexion;
		private NpgsqlConnection conexion;

		public ConexionDB(string cadenaConexion)
		{
			this.cadenaConexion = cadenaConexion;
			conexion = new NpgsqlConnection(cadenaConexion);
		}

		public bool probarConexion()
		{


			conexion.Open();

			return true;
		}
	}
}

