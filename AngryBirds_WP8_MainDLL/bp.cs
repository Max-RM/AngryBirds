using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class bp : c
{
	public new delegate void SceneCallback();

	private cr aj;

	private cr al;

	private cr am;

	private da an;

	private da ao;

	private da ap;

	private string aq;

	private string ar;

	private ae[] @as = new ae[4];

	private bool at;

	private new bool m_au;

	private new SceneCallback m_av;

	private bool m_aw;

	[CompilerGenerated]
	private bool m_ax;

	[CompilerGenerated]
	private SceneCallback ay;

	[CompilerGenerated]
	private SceneCallback az;

	[SpecialName]
	public string av()
	{
		return ar;
	}

	[SpecialName]
	public void a(string A_0)
	{
		ar = A_0;
		a8 a10 = di.d().r(ar);
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
	public bool ax()
	{
		return this.m_ax;
	}

	[SpecialName]
	[CompilerGenerated]
	public void a(bool A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public SceneCallback aw()
	{
		return ay;
	}

	[SpecialName]
	[CompilerGenerated]
	public void a(SceneCallback A_0)
	{
		ay = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public SceneCallback au()
	{
		return az;
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(SceneCallback A_0)
	{
		az = A_0;
	}

	[SpecialName]
	public void c(string A_0)
	{
		aq = A_0;
		ap.am = aq == null;
		ao.am = aq != null;
	}

	public override void e()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		u u2 = u.a();
		p("levelFailedPage");
		SetMenuState(global::m.MenuState.b);
		f(A_0: false);
		SetLayout(new y());
		a3().an();
		a3().g(dc.j);
		a3().i(A_0: true);
		da da2 = new da();
		da2.i(u2.g("LEVEL_FINISH_TOP_BG"));
		da2.af = 400f;
		da2.ah = (480 - u2.g("LEVEL_FAILED_BG").d) / 2;
		p(da2);
		da da3 = new da();
		da3.i(u2.g("LEVEL_FAILED_BG"));
		da3.af = 400f;
		da3.ah = 240f;
		p(da3);
		da da4 = new da();
		da4.i(u2.g("BUTTON_MENU"));
		da4.af = (int)(400f - 100f * di.d().e());
		da4.ah = (int)(240f + 81f * di.d().g());
		da4.y = c;
		((ck)da4).al = true;
		p(da4);
		da da5 = new da();
		da5.i(u2.g("BUTTON_RESTART"));
		da5.af = 400f;
		da5.ah = (int)(240f + 81f * di.d().g());
		da5.y = f;
		((ck)da5).al = true;
		p(da5);
		da da6 = new da();
		da6.i(u2.g("BUTTON_NEXTLEVEL"));
		da6.af = (int)(400f + 100f * di.d().e());
		da6.ah = (int)(240f + 81f * di.d().g());
		da6.y = e;
		da6.am = false;
		((ck)da6).al = false;
		p(ap = da6);
		@as[0] = u2.g("RESULT_STARS_0");
		@as[1] = u2.g("RESULT_STARS_1");
		@as[2] = u2.g("RESULT_STARS_2");
		@as[3] = u2.g("RESULT_STARS_3");
		p(an = new da
		{
			af = 0f,
			ah = (int)(240f - 65f * di.d().g())
		});
		cr cr2 = new cr();
		cr2.i(u2.e("MT_LEVEL_FAILED"));
		cr2.af = 400f;
		cr2.ah = (int)(240f + 14f * di.d().g());
		cr2.i(u2.a("FONT_BASIC_WP7.dat"));
		cr2.ad = new a7(bn.b, dh.b);
		p(cr2);
		cr cr3 = new cr();
		cr3.i("");
		cr3.af = (int)(400f - 80f * di.d().e());
		cr3.ah = (int)(240f - 75f * di.d().g());
		cr3.i(u2.a("FONT_BIG_NUMBERS_N900.dat"));
		cr3.ad = new a7(bn.b, dh.b);
		p(am = cr3);
		cr cr4 = new cr();
		cr4.i(u2.e("MI_HIGH_SCORE"));
		cr4.af = (int)(400f + 65f * di.d().e());
		cr4.ah = (int)(240f - 88f * di.d().g());
		cr4.i(u2.a("FONT_BASIC_WP7.dat"));
		cr4.ad = new a7(bn.b, dh.b);
		p(aj = cr4);
		cr cr5 = new cr();
		cr5.i("0");
		cr5.af = (int)(400f + 65f * di.d().e());
		cr5.ah = (int)(240f - 65f * di.d().g());
		cr5.i(u2.a("FONT_BASIC_WP7.dat"));
		cr5.ad = new a7(bn.c, dh.b);
		p(al = cr5);
		da da7 = new da();
		da7.i(u2.g("MENU_CUTSCENE"));
		da7.af = (int)(400f + 100f * di.d().e());
		da7.ah = (int)(240f + 81f * di.d().g());
		da7.y = null;
		da7.am = false;
		((ck)da7).al = true;
		p(ao = da7);
	}

	public override void h(GameTime A_0)
	{
		if (!at)
		{
			s.a().a("level_failed_piglets", A_1: false);
			am.i(di.d().g(av()));
			l l2 = bo.a().e(av());
			al.i(l2.a.ToString());
			an.i(@as[l2.b]);
			an.af = al.af;
			bool flag = bo.a().d(av());
			aj.am = true;
			al.am = true;
			an.am = true;
			((ck)ap).al = flag && aq == null;
			ap.am = flag && aq == null;
			ao.am = flag && aq != null;
			a8 a10 = di.d().r(av());
			if (a10.a == "packFacebook1")
			{
				ap.am = false;
				((ck)ap).al = false;
				ao.am = false;
				((ck)ao).al = false;
			}
			if (ax())
			{
				aj.am = false;
				al.am = false;
				an.am = false;
				((ck)ap).al = false;
				ap.am = false;
				ao.am = false;
			}
			at = true;
			f(A_0: true);
		}
		if (!a3().o())
		{
			SetMenuState(global::m.MenuState.a);
		}
	}

	public override void b(GameTime A_0)
	{
		at = false;
		if (!a3().m() || this.m_aw)
		{
			ao.am = false;
			ap.am = false;
			SetMenuState(global::m.MenuState.b);
			f(A_0: false);
			this.m_aw = false;
		}
	}

	public override void f()
	{
		if (at)
		{
			base.f();
		}
		this.m_au = false;
	}

	public override void g(GameTime A_0)
	{
		if (a8().ba() && this.m_av != null)
		{
			if (!this.m_au)
			{
				this.m_av();
				this.m_av = null;
			}
		}
		else
		{
			base.g(A_0);
		}
	}

	private void f(ck A_0)
	{
		this.m_av = aw();
		a8().f(A_0: true);
	}

	private void e(ck A_0)
	{
		((ck)ap).al = false;
		a8().f(A_0: true);
		this.m_av = au();
	}

	private void c(ck A_0)
	{
		this.m_aw = true;
		a8 a10 = di.d().r(av());
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
		if (aq != null)
		{
			this.m_aw = true;
			n.c(aq);
		}
	}
}
