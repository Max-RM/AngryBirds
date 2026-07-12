using System;

internal struct cl : IComparable<cl>
{
	public short a;

	public short b;

	public short c;

	public int CompareTo(cl other)
	{
		if (a < other.a)
		{
			return -1;
		}
		if (a == other.a)
		{
			if (b < other.b)
			{
				return -1;
			}
			if (b == other.b)
			{
				return 0;
			}
		}
		return 1;
	}
}
