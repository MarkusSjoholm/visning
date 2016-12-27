using System;
namespace Visning
{
	public class Residence
	{
		public string Adress { get; set;}
		public string Broker { get; set; }

		public Residence() { }

		public Residence(string adress, string broker)
		{
			this.Adress = adress;
			this.Broker = broker;
		}
	}
}
