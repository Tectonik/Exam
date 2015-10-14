namespace Computers.Interfaces
{
	using System;
	using System.Linq;

	public interface IMotherboard
	{
		int LoadRamValue();

		void SaveRamValue(int value);

		void DrawOnVideoCard(string data);
	}
}
