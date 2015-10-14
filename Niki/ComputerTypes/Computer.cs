namespace Computers.ComputerTypes
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public abstract class Computer
	{
		protected Computer(
				  Cpu cpu,
				  Rammstein ram,
				  IEnumerable<HardDrive> hardDrives,
				  HardDrive videoCard)
		{
			Cpu = cpu;
			this.Ram = ram;
			this.HardDrives = hardDrives;
			this.VideoCard = videoCard;
		}

		protected IEnumerable<HardDrive> HardDrives { get; set; }

		protected HardDrive VideoCard { get; set; }

		protected Cpu Cpu { get; set; }

		protected Rammstein Ram { get; set; }
	}
}
