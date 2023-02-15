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
// RelacionHumedadTemperatura
// 
// Autor : Carlos Davidson Gómez
// 30/01/2023
//

namespace Automatizacion.Core {
	public sealed class RelacionHumedadTemperatura {
		/// <summary>
		///		Inicializa una nueva instancia de la clase <see cref="RelacionHumedadTemperatura"/>.
		/// </summary>
		public RelacionHumedadTemperatura(int humedad, int temperatura) {
			Humedad = humedad;
			Temperatura = temperatura;
		}

		#region Propiedades :

		/// <summary>
		///		Humedad en porciento.
		/// </summary>
		public int Humedad { get; set; }

		/// <summary>
		///		Temperatura en grados Celsius.
		/// </summary>
		public int Temperatura { get; set; }

		#endregion

		#region Funciones :

		/// <summary>
		///		Retorna una cadena que representa el objeto actual.
		/// </summary>
		/// <returns>Una cadena que representa el objeto actual.</returns>
		public override string ToString() {
			return $"{Humedad}|{Temperatura}";
		}

		#endregion
		
	}
}