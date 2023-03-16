using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
	internal class Airport
	{
		public const int RECORD_SIZE = 20;
		private string code;
		private string name;

		//class constructor
		public Airport(string code, string name)
		{
			this.code = code;
			this.name = name;
		}

		//getters methods
		public string Code { get { return code; } }
		public string Name { get { return name; } }


	}
}
