using System;

namespace Box2D.XNA;

public struct FixedArray3<T>
{
	public T _value0;

	public T _value1;

	public T _value2;

	public T this[int index]
	{
		get
		{
			return index switch
			{
				0 => _value0, 
				1 => _value1, 
				2 => _value2, 
				_ => throw new IndexOutOfRangeException(), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				_value0 = value;
				break;
			case 1:
				_value1 = value;
				break;
			case 2:
				_value2 = value;
				break;
			default:
				throw new IndexOutOfRangeException();
			}
		}
	}
}
