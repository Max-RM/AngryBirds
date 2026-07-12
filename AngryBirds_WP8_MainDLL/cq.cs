using System;
using System.IO;
using System.Text;

internal class cq
{
	public static string c(BinaryReader A_0)
	{
		short num = a(A_0);
		if (num < 0)
		{
			return null;
		}
		byte[] bytes = A_0.ReadBytes(num);
		return Encoding.UTF8.GetString(bytes, 0, num);
	}

	public static int b(BinaryReader A_0)
	{
		byte[] array = A_0.ReadBytes(4);
		Array.Reverse(array);
		return BitConverter.ToInt32(array, 0);
	}

	public static short a(BinaryReader A_0)
	{
		byte[] array = A_0.ReadBytes(2);
		Array.Reverse(array);
		return BitConverter.ToInt16(array, 0);
	}

	public static long a(Stream A_0)
	{
		return A_0.Length - A_0.Position;
	}
}
