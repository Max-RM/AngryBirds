using System;

namespace Box2D.XNA;

public struct FixedArray8<T>
{
	public T _value0;

	public T _value1;

	public T _value2;

	public T _value3;

	public T _value4;

	public T _value5;

	public T _value6;

	public T _value7;

	public T this[int index]
	{
		get
		{
			return index switch
			{
				0 => _value0, 
				1 => _value1, 
				2 => _value2, 
				3 => _value3, 
				4 => _value4, 
				5 => _value5, 
				6 => _value6, 
				7 => _value7, 
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
			case 3:
				_value3 = value;
				break;
			case 4:
				_value4 = value;
				break;
			case 5:
				_value5 = value;
				break;
			case 6:
				_value6 = value;
				break;
			case 7:
				_value7 = value;
				break;
			default:
				throw new IndexOutOfRangeException();
			}
		}
	}
}
