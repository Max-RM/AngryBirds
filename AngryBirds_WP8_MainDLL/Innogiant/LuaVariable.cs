using System;
using System.Collections;
using System.Collections.Generic;

namespace Innogiant;

public class LuaVariable : IEnumerable
{
	private object a;

	public object Content
	{
		get
		{
			return a;
		}
		set
		{
			a = value;
		}
	}

	public LuaVariable this[int aIndex]
	{
		get
		{
			Dictionary<string, LuaVariable> dictionary = a as Dictionary<string, LuaVariable>;
			if (!dictionary.ContainsKey(aIndex.ToString()))
			{
				return null;
			}
			return dictionary[aIndex.ToString()];
		}
		set
		{
			Dictionary<string, LuaVariable> dictionary = a as Dictionary<string, LuaVariable>;
			dictionary[aIndex.ToString()] = value;
		}
	}

	public LuaVariable this[string aIndex]
	{
		get
		{
			Dictionary<string, LuaVariable> dictionary = a as Dictionary<string, LuaVariable>;
			if (!dictionary.ContainsKey(aIndex))
			{
				return null;
			}
			return dictionary[aIndex];
		}
		set
		{
			Dictionary<string, LuaVariable> dictionary = a as Dictionary<string, LuaVariable>;
			dictionary[aIndex] = value;
		}
	}

	public int Count
	{
		get
		{
			Dictionary<string, LuaVariable> dictionary = a as Dictionary<string, LuaVariable>;
			return dictionary.Count;
		}
	}

	public LuaVariable(object aValue)
	{
		a = aValue;
	}

	public IEnumerator GetEnumerator()
	{
		Dictionary<string, LuaVariable> dictionary = a as Dictionary<string, LuaVariable>;
		return dictionary.GetEnumerator();
	}

	public bool ContainsKey(int aIndex)
	{
		Dictionary<string, LuaVariable> dictionary = a as Dictionary<string, LuaVariable>;
		return dictionary.ContainsKey(aIndex.ToString());
	}

	public bool ContainsKey(string aIndex)
	{
		Dictionary<string, LuaVariable> dictionary = a as Dictionary<string, LuaVariable>;
		return dictionary.ContainsKey(aIndex);
	}

	public string GetString()
	{
		return Convert.ToString(a);
	}

	public int GetInteger()
	{
		return Convert.ToInt32(a);
	}

	public double GetDouble()
	{
		return Convert.ToDouble(a);
	}

	public bool GetBool()
	{
		return Convert.ToBoolean(a);
	}

	public Dictionary<string, LuaVariable> GetArray()
	{
		return (Dictionary<string, LuaVariable>)a;
	}

	public static implicit operator string(LuaVariable aValue)
	{
		if (aValue != null)
		{
			return aValue.a as string;
		}
		return null;
	}

	public static implicit operator bool(LuaVariable aValue)
	{
		if (aValue == null)
		{
			return false;
		}
		return (aValue.a as bool?) ?? false;
	}

	public static implicit operator int(LuaVariable aValue)
	{
		if (aValue == null)
		{
			return int.MinValue;
		}
		int result = int.MinValue;
		if (aValue.a is int)
		{
			int num = (int)aValue.a;
			result = num;
		}
		else if (aValue.a is double)
		{
			double num2 = (double)aValue.a;
			result = (int)num2;
		}
		else if (aValue.a is float)
		{
			float num3 = (float)aValue.a;
			result = (int)num3;
		}
		else if (aValue.a is bool)
		{
			result = (((bool)aValue.a) ? 1 : 0);
		}
		return result;
	}

	public static implicit operator double(LuaVariable aValue)
	{
		if (aValue == null)
		{
			return double.NaN;
		}
		double num = 0.0;
		if (aValue.a is int)
		{
			int num2 = (int)aValue.a;
			return num2;
		}
		if (aValue.a is double)
		{
			double num3 = (double)aValue.a;
			return num3;
		}
		if (aValue.a is float)
		{
			float num4 = (float)aValue.a;
			return num4;
		}
		if (aValue.a is bool)
		{
			return ((bool)aValue.a) ? 1.0 : 0.0;
		}
		return double.NaN;
	}

	public static implicit operator float(LuaVariable aValue)
	{
		if (aValue == null)
		{
			return float.NaN;
		}
		float num = 0f;
		if (aValue.a is int)
		{
			int num2 = (int)aValue.a;
			return num2;
		}
		if (aValue.a is double)
		{
			double num3 = (double)aValue.a;
			return (float)num3;
		}
		if (aValue.a is float)
		{
			float num4 = (float)aValue.a;
			return num4;
		}
		if (aValue.a is bool)
		{
			return ((bool)aValue.a) ? 1f : 0f;
		}
		return float.NaN;
	}

	public static implicit operator LuaVariable(string aValue)
	{
		return new LuaVariable(aValue);
	}

	public static implicit operator LuaVariable(int aValue)
	{
		return new LuaVariable(aValue);
	}

	public static implicit operator LuaVariable(double aValue)
	{
		return new LuaVariable(aValue);
	}

	public static implicit operator LuaVariable(bool aValue)
	{
		return new LuaVariable(aValue);
	}

	public static implicit operator LuaVariable(Dictionary<string, LuaVariable> aValue)
	{
		return new LuaVariable(aValue);
	}
}
