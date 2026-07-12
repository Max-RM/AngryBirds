using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AngryBirds;
using Microsoft.Xna.Framework;

internal class m
{
	public enum MenuState
	{
		a,
		b,
		c,
		d
	}

	protected List<KeyValuePair<string, m>> j = new List<KeyValuePair<string, m>>();

	protected m k;

	protected int l;

	protected int m_depth;

	protected b n;

	[CompilerGenerated]
	private string q;

	[CompilerGenerated]
	private MenuState r;

	[CompilerGenerated]
	private bool s;

	[CompilerGenerated]
	private string t;

	[SpecialName]
	[CompilerGenerated]
	public string bd()
	{
		return q;
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(string A_0)
	{
		q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public MenuState bc()
	{
		return r;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMenuState(MenuState A_0)
	{
		r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool ba()
	{
		return s;
	}

	[SpecialName]
	[CompilerGenerated]
	public void f(bool A_0)
	{
		s = A_0;
	}

	[SpecialName]
	public m be()
	{
		return k;
	}

	[SpecialName]
	public void SetChildMenu(m A_0)
	{
		if (A_0 != null)
		{
			c(A_0);
		}
		else
		{
			bb();
		}
	}

	[SpecialName]
	public b a9()
	{
		return n;
	}

	[SpecialName]
	public void SetMenuManager(b A_0)
	{
		n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string a7()
	{
		return t;
	}

	[SpecialName]
	[CompilerGenerated]
	public void au(string A_0)
	{
		t = A_0;
	}

	[SpecialName]
	public m a8()
	{
		return n.e()["loading"];
	}

	public m()
	{
		au("mainMenu");
		p(null);
		SetMenuState(global::m.MenuState.b);
		f(A_0: true);
	}

	public virtual void e()
	{
	}

	public virtual void f()
	{
	}

	public virtual void g(GameTime A_0)
	{
		if (k != null && k.bc() == global::m.MenuState.b)
		{
			k.f(A_0: false);
			k = null;
		}
		if (k != null)
		{
			k.g(A_0);
			return;
		}
		if (!a8().ba())
		{
			a();
		}
		switch (bc())
		{
		case global::m.MenuState.c:
			h(A_0);
			break;
		case global::m.MenuState.d:
			b(A_0);
			break;
		case global::m.MenuState.a:
		case global::m.MenuState.b:
			break;
		}
	}

	public virtual void a()
	{
		if (Controls.GetInstance().IsBackPressed)
		{
			c();
		}
	}

	public virtual void c()
	{
		if (k != null)
		{
			bb();
		}
		if (a7() != null)
		{
			n.c(a7());
		}
	}

	public virtual void h(GameTime A_0)
	{
		SetMenuState(global::m.MenuState.a);
	}

	public virtual void b(GameTime A_0)
	{
		SetMenuState(global::m.MenuState.b);
	}

	public void e(m A_0)
	{
		if (A_0 != null)
		{
			string text = A_0.bd();
			if (text == null || text == "")
			{
				text = $"Unnamed{m_depth++}";
			}
			j.Add(new KeyValuePair<string, m>(text, A_0));
		}
	}

	public m o(string A_0)
	{
		if (A_0 != null)
		{
			for (int num = 0; num < j.Count; num++)
			{
				if (j[num].Key == A_0)
				{
					return j[num].Value;
				}
			}
		}
		return null;
	}

	public void bf()
	{
		SetMenuState(global::m.MenuState.d);
	}

	public void av(ck A_0)
	{
		SetMenuState(global::m.MenuState.d);
	}

	public void au(ck A_0)
	{
		c(n.e()[A_0.z]);
	}

	public void c(m A_0)
	{
		if (A_0 != null)
		{
			k = A_0;
			k.f(A_0: true);
			k.SetMenuState(global::m.MenuState.c);
		}
	}

	public void bb()
	{
		if (k != null)
		{
			k.SetMenuState(global::m.MenuState.d);
		}
	}

	public void a(string A_0, bool A_1, bool A_2)
	{
		aa aa2 = (aa)a9().e()["goldenEggStarPage"];
		aa2.a(A_0);
		aa2.a(A_1);
		aa2.c(A_2);
		if (o("goldenEggStarPage") == null)
		{
			e(aa2);
		}
		c(aa2);
	}

	public virtual void o()
	{
	}

	public virtual void p()
	{
	}
}
