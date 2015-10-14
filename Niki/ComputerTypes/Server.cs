namespace Computers.ComputerTypes
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Server : Computer
	{
		public Server(
			Cpu cpu,
			Rammstein ram,
			IEnumerable<HardDrive> hardDrives,
			HardDrive videoCard)
			: base(cpu, ram, hardDrives, videoCard)
		{
		}
		internal void Process(int data)
		{
			this.Ram.SaveValue(data);

			// TODO: Fix it
			Cpu.SquareNumber();
		}
	}
}