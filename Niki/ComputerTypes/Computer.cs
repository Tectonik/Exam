namespace Computers.ComputerTypes
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Computers.Interfaces;

	public abstract class Computer
	{
		protected Computer(
				  Cpu cpu,
				  Rammstein ram,
				  IEnumerable<HardDrive> hardDrives,
				  IVideoCard videoCard)
		{
			Cpu = cpu;
			this.Ram = ram;
			this.HardDrives = hardDrives;
			this.VideoCard = videoCard;
		}

		protected IEnumerable<HardDrive> HardDrives { get; set; }

		protected IVideoCard VideoCard { get; set; }

		protected Cpu Cpu { get; set; }

		protected Rammstein Ram { get; set; }
	}
}
