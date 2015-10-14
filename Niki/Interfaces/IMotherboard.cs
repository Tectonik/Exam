using System;
using System.Collections.Generic;
namespace Computers.Interfaces
{
	using System.Linq;

	interface IMotherboard
	{
		int LoadRamValue();

		void SaveRamValue(int value);

		void DrawOnVideoCard(string data);
	}
}
