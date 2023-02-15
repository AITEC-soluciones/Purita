//
// Copyright (C) 2022 DaviSOFT
// All rights reserved.
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER
// EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF
// MERCHANTIBILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// 

//
// Solución : Purita
// Proyecto : Automatizacion.Core
// PerfilDeshidratacion
// 
// Autor : Carlos Davidson Gómez
// 30/01/2023
//

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Automatizacion.Core {
	public class PerfilDeshidratacion {
		private readonly string _rutaArchivo = $@"{Environment.CurrentDirectory}\perfiles";

		/// <summary>
		///		Inicializa una nueva instancia de la clase <see cref="PerfilDeshidratacion"/>.
		/// </summary>
		/// <param name="nombre">El nombre que identifica al perfil.</param>
		public PerfilDeshidratacion(string nombre) {
			Nombre = nombre;

			/* Inicializar relaciones */
			Relaciones = new RelacionHumedadTemperatura[10];

			for (var i = 0; i < 10; i++) 
				Relaciones[i] = new RelacionHumedadTemperatura(0, 0);
		}

		#region Propiedades :

		/// <summary>
		///		El nombre que identifica al perfil.
		/// </summary>
		public string Nombre { get; private set; }

		/// <summary>
		///		Relaciones Humedad-Temperaturas
		/// </summary>
		public RelacionHumedadTemperatura[] Relaciones { get; private set; }

		#endregion

		#region Funciones :

		/// <summary>
		///		Modifica el valor de humedad y temperatura en la posición dada.
		/// </summary>
		/// <param name="valorHumedad">Valor de humedad de la relación</param>
		/// <param name="valorTemperatura">Valor de temperatura de la relación</param>
		/// <param name="posicion">Posición de la relación en el arreglo</param>
		public void ModificarRelacion(int valorHumedad, int valorTemperatura, int posicion) {
			if (posicion < 0 || posicion >= 10)
				throw new ArgumentOutOfRangeException(nameof(posicion), posicion, 
					@"La posición especificada está fuera de los límites del arreglo");

			/* Actualizar valores */
			Relaciones[posicion].Humedad = valorHumedad;
			Relaciones[posicion].Temperatura = valorTemperatura;
		}

		/// <summary>
		///		Retorna el valor de humedad y temperatura en la posición dada.
		/// </summary>
		/// <param name="posicion">Posición de la relación en el arreglo</param>
		/// <returns>El valor de humedad y temperatura en la posición dada</returns>
		public RelacionHumedadTemperatura ObtenerRelacion(int posicion) {
			if (posicion < 0 || posicion >= 10)
				throw new ArgumentOutOfRangeException(nameof(posicion), posicion,
					@"La posición especificada está fuera de los límites del arreglo");

			return Relaciones[posicion];
		}

		/// <summary>
		///		Salva el perfil actual en archivo.
		/// </summary>
		public void Salvar() {
			if (!Directory.Exists(_rutaArchivo))
				Directory.CreateDirectory(_rutaArchivo);

			/* Escribir el archivo */
			using (var fs = new FileStream($@"{_rutaArchivo}\{Nombre}.pd", FileMode.OpenOrCreate)) {
				using (var sw = new StreamWriter(fs, Encoding.ASCII)) 
					sw.Write(ToString());
			}
		}

        /// <summary>
		///		Elimina el perfil actual en archivo.
		/// </summary>
		public void Eliminar() {
            if (!Directory.Exists(_rutaArchivo) || !File.Exists($@"{_rutaArchivo}\{Nombre}.pd"))
                return;

            /* Eliminar el archivo */
            File.Delete($@"{_rutaArchivo}\{Nombre}.pd");
        }

        /// <summary>
        ///		Retorna una cadena que representa el objeto actual.
        /// </summary>
        /// <returns>Una cadena que representa el objeto actual.</returns>
        public override string ToString() {
			return Relaciones.Aggregate(Nombre, (current, relacion) => current + $"\n{relacion}");
		}

		#endregion

	}
}