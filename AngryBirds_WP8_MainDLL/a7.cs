using System.Runtime.CompilerServices;

internal struct a7
{
	private dh a;

	private bn b;

	[SpecialName]
	public dh c()
	{
		return a;
	}

	[SpecialName]
	public void c(dh A_0)
	{
		a = A_0;
	}

	[SpecialName]
	public bn d()
	{
		return b;
	}

	[SpecialName]
	public void c(bn A_0)
	{
		b = A_0;
	}

	public a7(dh A_0)
	{
		a = A_0;
		b = bn.a;
	}

	public a7(bn A_0)
	{
		a = dh.a;
		b = A_0;
	}

	public a7(bn A_0, dh A_1)
	{
		a = A_1;
		b = A_0;
	}

	public void c(int A_0, int A_1, int A_2, int A_3, int A_4)
	{
	}

	public r c(r A_0, int A_1, int A_2)
	{
		switch (a)
		{
		case dh.b:
			A_0.h(A_0.g() - A_0.i() / 2);
			A_0.f(A_0.e() - A_0.i() / 2);
			break;
		case dh.c:
			A_0.h(A_0.g() - A_0.i());
			A_0.f(A_0.e() - A_0.i());
			break;
		case dh.d:
		case dh.e:
			A_0.h(A_0.g() - A_2);
			A_0.f(A_0.e() - A_2);
			break;
		}
		switch (b)
		{
		case bn.b:
			A_0.e(A_0.f() - A_0.j() / 2);
			A_0.g(A_0.h() - A_0.j() / 2);
			break;
		case bn.c:
			A_0.e(A_0.f() - A_0.j());
			A_0.g(A_0.h() - A_0.j());
			break;
		case bn.d:
			A_0.e(A_0.f() - A_1);
			A_0.g(A_0.h() - A_1);
			break;
		}
		return A_0;
	}
}
