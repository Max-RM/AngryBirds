using System;

internal class b9
{
	private static Random m_a;

	public b9()
	{
		b9.m_a = new Random();
	}

	public static float a()
	{
		return (float)b9.m_a.NextDouble();
	}

	public static int a(int A_0)
	{
		return b9.m_a.Next(A_0 + 1);
	}

	public static int a(int A_0, int A_1)
	{
		return b9.m_a.Next(A_0, A_1 + 1);
	}
}
