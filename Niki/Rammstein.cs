namespace Computers1
{
	class Rammstein
	{
		int value;

		internal Rammstein(int a)
		{
			this.Amount = a;
		}

		int Amount { get; set; }

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