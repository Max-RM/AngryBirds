using System;
using System.Runtime.CompilerServices;
using AngryBirds.Menus;
using Microsoft.Xna.Framework;

internal class aa : c
{
	public new enum AaPhase
	{
		a,
		b,
		c,
		d
	}

	private da t;

	private da v;

	private da w;

	private da x;

	private da y;

	private c9 z;

	private AaPhase m_aa;

	private float ab;

	private bool ac;

	private int ad;

	[CompilerGenerated]
	private string ae;

	[CompilerGenerated]
	private bool af;

	[CompilerGenerated]
	private bool ag;

	[SpecialName]
	[CompilerGenerated]
	public string aw()
	{
		return ae;
	}

	[SpecialName]
	[CompilerGenerated]
	public void a(string A_0)
	{
		ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool av()
	{
		return af;
	}

	[SpecialName]
	[CompilerGenerated]
	public void a(bool A_0)
	{
		af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool au()
	{
		return ag;
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(bool A_0)
	{
		ag = A_0;
	}

	public aa()
	{
		a("");
	}

	public override void e()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		u u2 = u.a();
		p("goldenEggStarPage");
		SetMenuState(global::m.MenuState.b);
		SetLayout(new y());
		a3().an();
		a3().g(dc.j);
		a3().i(A_0: true);
		ad = u2.g("GOLDEN_EGG_5").d;
		c9 c10 = new c9();
		c10.ag(A_0: false);
		c10.ai(A_0: true);
		c10.bg(A_0: false);
		z = c10;
		da da2 = new da();
		da2.i(u2.g("GOLDEN_EGG_STAR_EFFECT"));
		da2.af = 400f;
		da2.am = false;
		w = da2;
		z.be(w);
		da da3 = new da();
		da3.i(u2.g("GOLDEN_EGG_5"));
		da3.af = 400f;
		da3.am = false;
		t = da3;
		z.be(t);
		da da4 = new da();
		da4.i(u2.g("GOLDEN_EGG_STAR"));
		da4.af = 400f;
		da4.am = false;
		x = da4;
		z.be(x);
		da da5 = new da();
		da5.i(u2.g("GOLDEN_EGG_STAR_COLLECTED"));
		da5.af = 400f;
		da5.am = false;
		y = da5;
		z.be(y);
		da da6 = new da();
		da6.i(u2.g("BIRD_BOOMERANG_STILL"));
		da6.af = 400f;
		da6.am = false;
		v = da6;
		z.be(v);
		p(z);
		((ck)z).ak = 480 + w.bf().d;
	}

	public override void f()
	{
		base.f();
	}

	public override void h(GameTime A_0)
	{
		a8().f(A_0: false);
		if (m_aa != 0)
		{
			return;
		}
		if (av())
		{
			if (!ac)
			{
				b0.d().d("star_collect").ac();
				ac = true;
			}
			v.am = true;
			t.am = false;
			y.am = false;
			w.am = true;
			x.am = false;
		}
		else if (d.p().s(aw()) == GoldenEggType.Completed)
		{
			v.am = false;
			t.am = false;
			y.am = true;
			w.am = false;
			x.am = false;
		}
		else
		{
			if (!ac)
			{
				if (au())
				{
					b0.d().d("goldenegg").ac();
				}
				else
				{
					b0.d().d("star_collect").ac();
				}
				ac = true;
			}
			if (au())
			{
				v.am = false;
				t.am = true;
				y.am = false;
				w.am = true;
				x.am = false;
			}
			else
			{
				v.am = false;
				t.am = false;
				y.am = false;
				w.am = true;
				x.am = true;
			}
		}
		m_aa = global::aa.AaPhase.b;
		ab = 0.8f;
	}

	public override void b(GameTime A_0)
	{
		if (m_aa != 0)
		{
			return;
		}
		((ck)z).ak = 480 + w.bf().d;
		v.am = false;
		t.am = false;
		y.am = true;
		x.am = false;
		w.am = false;
		ac = false;
		if (!av())
		{
			if (au())
			{
				d.p().p(aw(), GoldenEggType.Achieved);
			}
			else
			{
				d.p().p(aw(), GoldenEggType.Completed);
			}
		}
		c(A_0: false);
		SetMenuState(global::m.MenuState.b);
	}

	public override void g(GameTime A_0)
	{
		float num = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		ab -= num;
		da obj = w;
		obj.ag(obj.bg() + num * ((float)Math.PI / 2f));
		if (w.bg() > (float)Math.PI * 2f)
		{
			da obj2 = w;
			obj2.ag(obj2.bg() - (float)Math.PI * 2f);
		}
		if (m_aa == global::aa.AaPhase.b)
		{
			((ck)z).ak = 240f + (float)Math.Pow(ab / 0.8f, 2.0) * (float)(240 + ad);
			bool flag = a3().o();
			if (ab < 0f && !flag)
			{
				ab = 1.5f;
				m_aa = global::aa.AaPhase.c;
				SetMenuState(global::m.MenuState.a);
			}
		}
		if (m_aa == global::aa.AaPhase.c)
		{
			((ck)z).ak = 240f;
			if (ab < 0f)
			{
				ab = 0.8f;
				m_aa = global::aa.AaPhase.d;
				SetMenuState(global::m.MenuState.d);
			}
		}
		if (m_aa == global::aa.AaPhase.d)
		{
			((ck)z).ak = 240f - (float)Math.Pow((0.8f - ab) / 0.8f, 2.0) * (float)(240 + ad);
			bool flag2 = a3().m();
			if (ab < 0f && !flag2)
			{
				ab = 0.8f;
				m_aa = global::aa.AaPhase.a;
			}
		}
		base.g(A_0);
	}

	public override void a()
	{
	}
}
