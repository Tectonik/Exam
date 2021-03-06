﻿namespace Computers.ComputerTypes
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Computers.Interfaces;

	public class PersonalComputer : Computer
	{
		public PersonalComputer(
			Cpu cpu,
			Rammstein ram,
			IEnumerable<HardDrive> hardDrives,
			ColourVideoCard videoCard)
			: base(cpu, ram, hardDrives, videoCard)
		{
		}

		public void Play(int guessNumber)
		{
			Cpu.Rand(1, 10);
			var number = this.Ram.LoadValue();
			if (number + 1 != guessNumber + 1)
			{
				this.VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
			}
			else
			{
				this.VideoCard.Draw("You win!");
			}
		}
	}
}
