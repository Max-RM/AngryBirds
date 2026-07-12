using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class b
{
	private m a;

	private string m_b;

	[CompilerGenerated]
	private m m_c;

	[CompilerGenerated]
	private Dictionary<string, m> m_d;

	[SpecialName]
	[CompilerGenerated]
	public m f()
	{
		return this.m_c;
	}

	[SpecialName]
	[CompilerGenerated]
	private void c(m A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Dictionary<string, m> e()
	{
		return this.m_d;
	}

	[SpecialName]
	[CompilerGenerated]
	private void c(Dictionary<string, m> A_0)
	{
		this.m_d = A_0;
	}

	public b()
	{
		c(new Dictionary<string, m>());
		c((m)null);
	}

	public void c()
	{
		foreach (KeyValuePair<string, m> item in e())
		{
			item.Value.e();
		}
		a = e()["loading"];
	}

	public void c(string A_0, m A_1)
	{
		A_1.SetMenuManager(this);
		e().Add(A_0, A_1);
	}

	public void d()
	{
		if (f() != null && f().ba())
		{
			f().f();
		}
		if (a != null && a.ba())
		{
			a.f();
		}
	}

	public void c(GameTime A_0)
	{
		if (f() == null)
		{
			return;
		}
		if (f().bc() == m.MenuState.b)
		{
			f().o();
			f().f(A_0: false);
			c((m)null);
			if (m_b != null)
			{
				c(e()[m_b]);
				f().SetMenuState(m.MenuState.c);
				f().f(A_0: true);
				m_b = null;
				f().p();
				f().g(A_0);
			}
		}
		else
		{
			f().g(A_0);
		}
	}

	public bool c(string A_0)
	{
		if (A_0 != null && e().ContainsKey(A_0))
		{
			if (f() != null)
			{
				if (f().be() != null)
				{
					f().bb();
				}
				f().bf();
				global::d.p().r();
				bo.a().b();
				m_b = A_0;
			}
			else
			{
				c(e()[A_0]);
				f().SetMenuState(m.MenuState.c);
				f().f(A_0: true);
				f().p();
			}
			return true;
		}
		return false;
	}

	public void c(ck A_0)
	{
		if (A_0.aa != null)
		{
			A_0.aa.ac();
		}
		c(A_0.z);
	}

	public void g()
	{
		DateTime now = DateTime.Now;
		di.d().h();
		DateTime now2 = DateTime.Now;
		p.a().b("RESO_800");
		DateTime now3 = DateTime.Now;
		bo.a();
		DateTime now4 = DateTime.Now;
		global::d.p();
		DateTime now5 = DateTime.Now;
		new TimeSpan(now2.Ticks - now.Ticks);
		new TimeSpan(now3.Ticks - now2.Ticks);
		new TimeSpan(now4.Ticks - now3.Ticks);
		new TimeSpan(now5.Ticks - now4.Ticks);
	}
}
