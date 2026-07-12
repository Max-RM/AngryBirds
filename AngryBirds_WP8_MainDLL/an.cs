using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class an : c
{
	public new delegate void SceneCallback();

	private da x;

	private ae y;

	private ae z;

	private ae aa;

	private cr ab;

	private cr ac;

	private cr ad;

	private cr ae;

	private da af;

	private da ag;

	private da ah;

	private da ai;

	private da aj;

	private da ak;

	private da al;

	private string am;

	private string m_an;

	private ae[] ao = new ae[3];

	private ae[] ap = new ae[3];

	private bool aq;

	private bool ar;

	private SceneCallback @as;

	private bool at;

	[CompilerGenerated]
	private new bool m_au;

	[CompilerGenerated]
	private new bool m_av;

	[CompilerGenerated]
	private bool m_aw;

	[CompilerGenerated]
	private int m_ax;

	[CompilerGenerated]
	private int m_ay;

	[CompilerGenerated]
	private int m_az;

	[CompilerGenerated]
	private SceneCallback m_a0;

	[CompilerGenerated]
	private SceneCallback m_a1;

	[SpecialName]
	public string az()
	{
		return m_an;
	}

	[SpecialName]
	public void a(string A_0)
	{
		m_an = A_0;
		a8 a10 = di.d().r(m_an);
		av av2 = di.d().k(a10.a);
		switch (av2.a)
		{
		case "episode1":
			au("episode1");
			break;
		case "episode2":
			au("episode2");
			break;
		case "episode3":
			au("episode3");
			break;
		case "episode4":
			au("episode4");
			break;
		case "episode5":
			au("episode5");
			break;
		case "goldenEggs":
			au("goldenEggs");
			break;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool a2()
	{
		return this.m_au;
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(bool A_0)
	{
		this.m_au = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool au()
	{
		return this.m_av;
	}

	[SpecialName]
	[CompilerGenerated]
	public void e(bool A_0)
	{
		this.m_av = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool a0()
	{
		return this.m_aw;
	}

	[SpecialName]
	[CompilerGenerated]
	public void a(bool A_0)
	{
		this.m_aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int av()
	{
		return this.m_ax;
	}

	[SpecialName]
	[CompilerGenerated]
	public void e(int A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int aw()
	{
		return this.m_ay;
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(int A_0)
	{
		this.m_ay = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int ay()
	{
		return this.m_az;
	}

	[SpecialName]
	[CompilerGenerated]
	private void a(int A_0)
	{
		this.m_az = A_0;
	}

	[SpecialName]
	public void c(string A_0)
	{
		am = A_0;
		ak.am = a2() || au();
		al.am = a2() || au();
		aj.am = am == null;
		ai.am = am != null;
	}

	[SpecialName]
	[CompilerGenerated]
	public SceneCallback a1()
	{
		return this.m_a0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void a(SceneCallback A_0)
	{
		this.m_a0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public SceneCallback ax()
	{
		return this.m_a1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(SceneCallback A_0)
	{
		this.m_a1 = A_0;
	}

	public an()
	{
		e(99999);
		a(3);
	}

	public override void e()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		u u2 = u.a();
		p("levelCompletedPage");
		SetMenuState(global::m.MenuState.b);
		f(A_0: false);
		SetLayout(new y());
		a3().an();
		a3().g(dc.j);
		a3().i(A_0: true);
		da da2 = new da();
		da2.i(u2.g("LEVEL_FINISH_TOP_BG"));
		da2.af = 400f;
		da2.ah = (480 - u2.g("LEVEL_FINISH_BG").d) / 2;
		p(da2);
		da da3 = new da();
		da3.i(u2.g("LEVEL_FINISH_BG"));
		da3.af = 400f;
		da3.ah = 240f;
		p(da3);
		da da4 = new da();
		da4.i(u2.g("BUTTON_MENU"));
		da4.af = (int)(400f - 100f * di.d().e());
		da4.ah = (int)(240f + 106f * di.d().g());
		da4.y = c;
		((ck)da4).al = true;
		p(ak = da4);
		da da5 = new da();
		da5.i(u2.g("BUTTON_RESTART"));
		da5.af = 400f;
		da5.ah = (int)(240f + 106f * di.d().g());
		da5.y = f;
		((ck)da5).al = true;
		p(al = da5);
		da da6 = new da();
		da6.i(u2.g("BUTTON_NEXTLEVEL"));
		da6.af = (int)(400f + 100f * di.d().e());
		da6.ah = (int)(240f + 106f * di.d().g());
		da6.y = e;
		((ck)da6).al = true;
		p(aj = da6);
		p(x = new da
		{
			af = (int)(400f + 86f * di.d().e()),
			ah = (int)(240f + 27f * di.d().g()),
			am = true
		});
		da da7 = new da();
		da7.af = (int)(400f + 86f * di.d().e());
		da7.ah = (int)(240f + 27f * di.d().g());
		da7.am = true;
		da7.i(u2.i("TEXT_NEW_HIGHSCORE"));
		da7.ag(0.5f);
		p(af = da7);
		y = u2.g("NEW_HIGHSCORE_BG");
		z = u2.g("GOLDEN_EGG_STAR");
		aa = u2.g("GOLDEN_EGG_STAR_COLLECTED");
		ap[0] = u2.g("STARS_BIG_1");
		ap[1] = u2.g("STARS_BIG_2");
		ap[2] = u2.g("STARS_BIG_3");
		p(ah = new da
		{
			af = 0f,
			ah = (int)(240f + 53f * di.d().g())
		});
		ao[0] = u2.g("RESULT_STARS_1");
		ao[1] = u2.g("RESULT_STARS_2");
		ao[2] = u2.g("RESULT_STARS_3");
		p(ag = new da
		{
			af = 0f,
			ah = (int)(240f - 88f * di.d().g())
		});
		cr cr2 = new cr();
		cr2.i(u2.e("MT_LEVEL_COMPLETE"));
		cr2.af = (int)(400f - 120f * di.d().e());
		cr2.ah = (int)(240f - 10f * di.d().g());
		cr2.i(u2.a("FONT_BASIC_WP7.dat"));
		cr2.ad = new a7(bn.a, dh.b);
		p(cr2);
		cr cr3 = new cr();
		cr3.i("");
		cr3.af = (int)(400f - 80f * di.d().e());
		cr3.ah = (int)(240f - 98f * di.d().g());
		cr3.i(u2.a("FONT_BIG_NUMBERS_N900.dat"));
		cr3.ad = new a7(bn.b, dh.b);
		p(ae = cr3);
		cr cr4 = new cr();
		cr4.i(u2.e("MI_SCORE"));
		cr4.af = (int)(400f - 120f * di.d().e());
		cr4.ah = (int)(240f + 30f * di.d().g());
		cr4.i(u2.a("FONT_BASIC_WP7.dat"));
		cr4.ad = new a7(bn.a, dh.b);
		p(cr4);
		cr cr5 = new cr();
		cr5.i("0");
		cr5.af = (int)(400f - 120f * di.d().e());
		cr5.ah = (int)(240f + 53f * di.d().g());
		cr5.i(u2.a("FONT_BASIC_WP7.dat"));
		cr5.ad = new a7(bn.a, dh.b);
		p(ad = cr5);
		cr cr6 = new cr();
		cr6.i(u2.e("MI_HIGH_SCORE"));
		cr6.af = (int)(400f + 65f * di.d().e());
		cr6.ah = (int)(240f - 110f * di.d().g());
		cr6.i(u2.a("FONT_BASIC_WP7.dat"));
		cr6.ad = new a7(bn.b, dh.b);
		p(ab = cr6);
		cr cr7 = new cr();
		cr7.i("0");
		cr7.af = (int)(400f + 65f * di.d().e());
		cr7.ah = (int)(240f - 88f * di.d().g());
		cr7.i(u2.a("FONT_BASIC_WP7.dat"));
		cr7.ad = new a7(bn.c, dh.b);
		p(ac = cr7);
		da da8 = new da();
		da8.i(u2.g("MENU_CUTSCENE"));
		da8.af = (int)(400f + 100f * di.d().e());
		da8.ah = (int)(240f + 106f * di.d().g());
		da8.y = a;
		da8.am = false;
		((ck)da8).al = true;
		p(ai = da8);
	}

	public override void h(GameTime A_0)
	{
		if (!aq)
		{
			if (a0())
			{
				s.a().a("level_complete", A_1: false);
			}
			ae.i(di.d().g(az()));
			l l2 = bo.a().e(az());
			ac.i(l2.a.ToString());
			if (!a2() && l2.b > 0 && l2.b < 4)
			{
				ag.i(ao[l2.b - 1]);
				ag.af = ac.af;
			}
			else
			{
				ag.i(null);
			}
			ad.i(av().ToString());
			a(bo.a().a(az(), av()));
			if (!a2() && ay() > 0 && ay() < 4)
			{
				ah.i(ap[ay() - 1]);
				ah.af = ad.af + (float)ad.bh() + 5f;
			}
			else
			{
				ah.i(null);
			}
			ab.am = true;
			ac.am = true;
			ag.am = true;
			ah.am = true;
			al.am = am == null || au();
			((ck)al).al = am == null || au();
			ak.am = am == null || au();
			((ck)ak).al = am == null || au();
			((ck)aj).al = am == null;
			aj.am = am == null;
			ai.am = am != null;
			((ck)ai).al = am != null;
			if (a2())
			{
				ab.am = false;
				ac.am = false;
				ag.am = false;
				ah.am = false;
				((ck)aj).al = false;
				aj.am = false;
				ai.am = false;
			}
			if (a2())
			{
				if (aw() == 0)
				{
					x.i(z);
				}
				else
				{
					x.i(aa);
				}
				af.am = false;
			}
			else if (aw() < av())
			{
				x.i(y);
				af.am = true;
			}
			else
			{
				x.i(null);
				af.am = false;
			}
			a8 a10 = di.d().r(az());
			if (a10.a == "packFacebook1")
			{
				aj.am = false;
				((ck)aj).al = false;
				ai.am = false;
				((ck)ai).al = false;
			}
			aq = true;
			f(A_0: true);
		}
		if (!a3().o())
		{
			SetMenuState(global::m.MenuState.a);
		}
	}

	public override void b(GameTime A_0)
	{
		e(A_0: false);
		aq = false;
		if (!a3().m() || at)
		{
			SetMenuState(global::m.MenuState.b);
			f(A_0: false);
			at = false;
		}
	}

	public override void f()
	{
		if (aq)
		{
			base.f();
		}
		ar = false;
	}

	public override void g(GameTime A_0)
	{
		if (a8().ba() && @as != null)
		{
			if (!ar)
			{
				@as();
				@as = null;
			}
		}
		else
		{
			base.g(A_0);
		}
	}

	private void f(ck A_0)
	{
		a8().f(A_0: true);
		ar = true;
		@as = a1();
	}

	private void e(ck A_0)
	{
		((ck)aj).al = false;
		a8().f(A_0: true);
		a8 a10 = di.d().r(az());
		av av2 = di.d().k(a10.a);
		switch (av2.a)
		{
		case "episode1":
		{
			dj dj2 = (dj)n.e()["episode1"];
			dj2.ax();
			break;
		}
		case "episode2":
		{
			cx cx2 = (cx)n.e()["episode2"];
			cx2.ax();
			break;
		}
		case "episode3":
		{
			o o2 = (o)n.e()["episode3"];
			o2.ax();
			break;
		}
		case "episode4":
		{
			dg dg2 = (dg)n.e()["episode4"];
			dg2.ax();
			break;
		}
		case "episode5":
		{
			w w2 = (w)n.e()["episode5"];
			w2.ax();
			break;
		}
		}
		ar = true;
		@as = ax();
	}

	private void c(ck A_0)
	{
		at = true;
		a8 a10 = di.d().r(az());
		av av2 = di.d().k(a10.a);
		switch (av2.a)
		{
		case "episode1":
			n.c("episode1");
			break;
		case "episode2":
			n.c("episode2");
			break;
		case "episode3":
			n.c("episode3");
			break;
		case "episode4":
			n.c("episode4");
			break;
		case "episode5":
			n.c("episode5");
			break;
		case "goldenEggs":
			n.c("goldenEggs");
			break;
		}
	}

	private void a(ck A_0)
	{
		if (am != null)
		{
			a8().f(A_0: true);
			at = true;
			n.c(am);
		}
	}
}
