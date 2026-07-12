using System.Runtime.CompilerServices;

internal class aw : a3
{
	public delegate void SceneCallback();

	[CompilerGenerated]
	private SceneCallback m_a;

	[CompilerGenerated]
	private float b;

	[CompilerGenerated]
	private float c;

	[CompilerGenerated]
	private bool d;

	[CompilerGenerated]
	private bool e;

	[CompilerGenerated]
	private bool f;

	[SpecialName]
	[CompilerGenerated]
	public SceneCallback m()
	{
		return this.m_a;
	}

	[SpecialName]
	[CompilerGenerated]
	public void g(SceneCallback A_0)
	{
		this.m_a = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float k()
	{
		return b;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(float A_0)
	{
		b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float n()
	{
		return c;
	}

	[SpecialName]
	[CompilerGenerated]
	private void g(float A_0)
	{
		c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool i()
	{
		return d;
	}

	[SpecialName]
	[CompilerGenerated]
	public void g(bool A_0)
	{
		d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool h()
	{
		return e;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(bool A_0)
	{
		e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool l()
	{
		return f;
	}

	[SpecialName]
	[CompilerGenerated]
	public void h(bool A_0)
	{
		f = A_0;
	}

	public virtual object j()
	{
		aw aw2 = (aw)MemberwiseClone();
		aw2.g(m());
		aw2.i(k());
		aw2.g(n());
		aw2.g(i());
		aw2.i(h());
		aw2.h(l());
		return aw2;
	}

	public aw()
	{
		g(null);
		g(A_0: false);
		i(A_0: true);
		h(A_0: false);
		i(0f);
		g(k());
	}

	public void g()
	{
		if (!l())
		{
			g(A_0: false);
		}
		g(h() ? k() : 0f);
	}

	public void h(float A_0)
	{
		if (!i())
		{
			return;
		}
		g(n() + (h() ? (0f - A_0) : A_0));
		if ((h() && n() < 0f) || (!h() && n() > k()))
		{
			g();
			if (m() != null)
			{
				m()();
			}
		}
	}
}
