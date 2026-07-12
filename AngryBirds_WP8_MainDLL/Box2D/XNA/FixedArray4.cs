using System;

namespace Box2D.XNA;

public struct FixedArray4<T>
{
	private T a;

	private T b;

	private T c;

	private T d;

	public T this[int index]
	{
		get
		{
			return index switch
			{
				0 => a, 
				1 => b, 
				2 => c, 
				3 => d, 
				_ => throw new IndexOutOfRangeException(), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				a = value;
				break;
			case 1:
				b = value;
				break;
			case 2:
				c = value;
				break;
			case 3:
				d = value;
				break;
			default:
				throw new IndexOutOfRangeException();
			}
		}
	}
}
