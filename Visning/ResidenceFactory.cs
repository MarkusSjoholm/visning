using System;
using System.Collections.Generic;

namespace Visning
{
	public static class ResidenceFactory
	{
		public static IList<Residence> Residences { get; private set;}

		static ResidenceFactory()
		{
			Residences = new List<Residence> {
				new Residence { Adress = "Ringen 6b", Broker = "Mäklare A"},
				new Residence { Adress = "Örtgatan 123", Broker = "Mäklare B"}
			};
		}

	}
}
