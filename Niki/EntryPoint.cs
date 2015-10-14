namespace Computers
{
	using System;
	using System.Collections.Generic;
	using Computers.ComputerTypes;

	public class EntryPoint
	{
		private static PersonalComputer pc = null;
		private static Server server = null;
		private static Laptop laptop = null;

		// Delete me

		// private static Computer pc, laptop, server;

		public static void Main()
		{
			var manufacturer = Console.ReadLine();

			if (manufacturer == "HP")
			{
				Hp();
			}
			else if (manufacturer == "Dell")
			{
				Dell();
			}
			else
			{
				throw new InvalidArgumentException("Invalid manufacturer!");
			}

			while (true)
			{
				var c = Console.ReadLine();

				if (c == null)
				{
					break;
				}

				if (c.StartsWith("Exit"))
				{
					break;
				}

				var cp = c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				if (cp.Length != 2)
				{
					throw new ArgumentException("Invalid command!");
				}

				var cn = cp[0];
				var ca = int.Parse(cp[1]);

				if (cn == "Charge")
				{
					laptop.ChargeBattery(ca);
				}
				else if (cn == "Process")
				{
					server.Process(ca);
				}
				else if (cn == "Play")
				{
					pc.Play(ca);
				}
				else
				{
					Console.WriteLine("Invalid command!");
				}
			}
		}

		private static void Hp()
		{
			var ram = new Rammstein(8 / 4);
			var videoCard = new HardDrive() { IsMonochrome = false };
			pc = new PersonalComputer
			(
				new Cpu(8 / 4, 32, ram, videoCard), ram, new[] { new HardDrive(500, false, 0) }, videoCard
			);

			var serverRam = new Rammstein(8 * 4);
			var serverVideo = new HardDrive();
			server = new Server(
			new Cpu(8 / 2, 32, serverRam, serverVideo),
			serverRam,
			new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(1000, false, 0), new HardDrive(1000, false, 0) }) },
			serverVideo);

			var card = new HardDrive()
			{
				IsMonochrome
				= false
			};

			var ram1 = new Rammstein(8 / 2);

			laptop = new Laptop
			(
				new Cpu(8 / 4, 64, ram1, card),
				ram1,
				new[] { new HardDrive(500, false, 0) },
				card,
				new LaptopBattery()
			);
		}

		private static void Dell()
		{
			var ram = new Rammstein(8);
			var videoCard = new HardDrive() { IsMonochrome = false };

			pc = new PersonalComputer
			(
			new Cpu(8 / 2, 64, ram, videoCard), ram, new[] { new HardDrive(1000, false, 0) }, videoCard
			);

			var ram1 = new Rammstein(8 * 8);
			var card = new HardDrive();

			server = new Server
			(
				new Cpu(8, 64, ram1, card),
				ram1,
				new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(2000, false, 0), new HardDrive(2000, false, 0) }) },
				card
			);

			var ram2 = new Rammstein(8);
			var videoCard1 = new HardDrive() { IsMonochrome = false };

			laptop = new Laptop
			(
				new Cpu(8 / 2, 32, ram2, videoCard1),
				ram2,
				new[] { new HardDrive(1000, false, 0) },
				videoCard1,
				new LaptopBattery()
			);
		}
	}
}
