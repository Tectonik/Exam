namespace Computers
{
	class Rammstein
	{
		int value;
		int Amount { get; set; }


		internal Rammstein(int a)
		{
			this.Amount = a;
		}


		public void SaveValue(int newValue)
		{
			value = newValue;
		}

		public int LoadValue()
		{
			return value;
		}
	}
}