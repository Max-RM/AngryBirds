using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal class cu
{
	private List<cc> a;

	[CompilerGenerated]
	private n m_b;

	[SpecialName]
	[CompilerGenerated]
	public n d()
	{
		return this.m_b;
	}

	[SpecialName]
	[CompilerGenerated]
	public void b(n A_0)
	{
		this.m_b = A_0;
	}

	public cu()
	{
		a = new List<cc>();
	}

	public void b()
	{
		for (int num = 0; num < a.Count; num++)
		{
			a[num].a(d());
		}
	}

	public cc c()
	{
		cc cc2 = new cc();
		a.Add(cc2);
		return cc2;
	}

	public void b(cc A_0)
	{
		a.Remove(A_0);
	}

	public void e()
	{
		if (a != null)
		{
			a.Clear();
		}
	}
}
