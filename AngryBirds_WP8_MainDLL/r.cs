using System.Runtime.CompilerServices;

internal class r
{
	private int a;

	private int b;

	private int c;

	private int d;

	[SpecialName]
	public int f()
	{
		return a;
	}

	[SpecialName]
	public void e(int A_0)
	{
		a = A_0;
	}

	[SpecialName]
	public int h()
	{
		return c;
	}

	[SpecialName]
	public void g(int A_0)
	{
		c = A_0;
	}

	[SpecialName]
	public int g()
	{
		return b;
	}

	[SpecialName]
	public void h(int A_0)
	{
		b = A_0;
	}

	[SpecialName]
	public int e()
	{
		return d;
	}

	[SpecialName]
	public void f(int A_0)
	{
		d = A_0;
	}

	public r(int A_0, int A_1, int A_2, int A_3)
	{
		a = A_0;
		b = A_1;
		c = A_2;
		d = A_3;
	}

	public int j()
	{
		return c - a;
	}

	public int i()
	{
		return d - b;
	}

	public bool e(int A_0, int A_1)
	{
		if (A_0 >= f() && A_0 <= h() && A_1 >= g())
		{
			return A_1 <= e();
		}
		return false;
	}
}
