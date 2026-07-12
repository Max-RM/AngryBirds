using System.Collections.Generic;

internal class b6
{
	private static b6 m_a;

	private List<aw> m_b;

	public static b6 a()
	{
		if (b6.m_a == null)
		{
			b6.m_a = new b6();
		}
		return b6.m_a;
	}

	private b6()
	{
		this.m_b = new List<aw>();
	}

	public void a(aw A_0)
	{
		this.m_b.Add(A_0);
	}

	public void b()
	{
		for (int num = 0; num < this.m_b.Count; num++)
		{
			this.m_b[num].g();
		}
	}

	public void a(float A_0)
	{
		for (int num = 0; num < this.m_b.Count; num++)
		{
			this.m_b[num].h(A_0);
		}
	}
}
