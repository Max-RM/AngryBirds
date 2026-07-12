using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class PauseGamePage : c
{
	private new string m_g;

	private new int m_h;

	private new cd j;

	private new da k;

	private new da l;

	private new da m;

	private new cr n;

	private bool q;

	private bool r;

	private bool s;

	private bool t;

	public cf u;

	[CompilerGenerated]
	private string v;

	[SpecialName]
	public string au()
	{
		return this.m_g;
	}

	[SpecialName]
	public void c(string A_0)
	{
		this.m_g = A_0;
		a8 a10 = di.d().r(this.m_g);
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
	public void a(string A_0)
	{
		v = A_0;
	}

	public override void e()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		u u2 = global::u.a();
		p("pauseGamePage");
		SetMenuState(global::m.MenuState.b);
		SetLayout(new y());
		a3().an();
		a3().g(dc.j);
		a3().i(A_0: true);
		j = new cd
		{
			al = false
		};
		int num = u2.g("ABOUT_BG").c;
		int num2 = (int)(150f * di.d().e());
		cd obj = j;
		da da2 = new da();
		da2.i(u2.g("ABOUT_BG"));
		da2.af = -num + num2;
		da2.ah = 0f;
		obj.be(da2);
		e(base.n.e()["tutorialPage"]);
		cd obj2 = j;
		cr cr2 = new cr();
		cr2.i("");
		cr2.af = (int)(65f * di.d().e());
		cr2.ah = (int)(40f * di.d().g());
		cr2.i(u2.a("FONT_BIG_NUMBERS_N900.dat"));
		cr2.ad = new a7(bn.b, dh.b);
		obj2.be(n = cr2);
		cd obj3 = j;
		da da3 = new da();
		da3.i(u2.g("BUTTON_SFX"));
		da3.af = (int)(36f * di.d().e());
		da3.ah = (int)(290f * di.d().g());
		((ck)da3).al = true;
		da3.y = ToggleSound;
		obj3.be(k = da3);
		cd obj4 = j;
		da da4 = new da();
		da4.i(u2.g("BUTTON_OFF"));
		da4.af = (int)(36f * di.d().e());
		da4.ah = (int)(290f * di.d().g());
		((ck)da4).al = false;
		da4.am = b0.d().p();
		obj4.be(l = da4);
		cd obj5 = j;
		da da5 = new da();
		da5.i(u2.g("BUTTON_MENU"));
		da5.af = (int)(62f * di.d().e());
		da5.ah = (int)(199f * di.d().g());
		((ck)da5).al = true;
		da5.y = c;
		da5.aa = u2.f("menu_confirm");
		obj5.be(m = da5);
		cd obj6 = j;
		da da6 = new da();
		da6.i(u2.g("BUTTON_RESTART"));
		da6.af = (int)(62f * di.d().e());
		da6.ah = (int)(122f * di.d().g());
		((ck)da6).al = true;
		da6.y = e;
		da6.aa = u2.f("menu_confirm");
		obj6.be(da6);
		cd obj7 = j;
		da da7 = new da();
		da7.i(u2.g("BUTTON_RESUME"));
		da7.af = (int)((float)num2 - 20f * di.d().e());
		da7.ah = 240f;
		((ck)da7).al = true;
		da7.y = base.av;
		da7.aa = u2.f("menu_confirm");
		obj7.be(da7);
		cd obj8 = j;
		da da8 = new da();
		da8.i(u2.g("MENU_TUTORIALZ"));
		da8.af = (int)(92f * di.d().e());
		da8.ah = (int)(290f * di.d().g());
		((ck)da8).al = true;
		da8.y = a;
		da8.aa = u2.f("menu_confirm");
		obj8.be(da8);
		j.be(new ck
		{
			ab = new r(num2, 0, 800, 480),
			al = true,
			y = base.av
		});
		p(j);
		this.m_h = -num;
		((ck)j).aj = this.m_h;
	}

	public override void f()
	{
		base.f();
		s = false;
	}

	public override void h(GameTime A_0)
	{
		float a_ = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		bool flag = a(a_, 0);
		bool flag2 = a3().o();
		if (!q)
		{
			l.am = b0.d().p();
			n.i(di.d().g(au()));
			q = true;
			a8 a10 = di.d().r(au());
			av av2 = di.d().k(a10.a);
			switch (av2.a)
			{
			case "episode1":
				m.z = "episode1";
				break;
			case "episode2":
				m.z = "episode2";
				break;
			case "episode3":
				m.z = "episode3";
				break;
			case "episode4":
				m.z = "episode4";
				break;
			case "episode5":
				m.z = "episode5";
				break;
			case "goldenEggs":
				m.z = "goldenEggs";
				break;
			}
		}
		if (!flag && !flag2)
		{
			((ck)j).aj = 0f;
			((ck)j).al = true;
			SetMenuState(global::m.MenuState.a);
		}
	}

	public override void b(GameTime A_0)
	{
		float a_ = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		bool flag = false;
		bool flag2 = false;
		if (!r)
		{
			flag = a(a_, this.m_h);
			flag2 = a3().m();
		}
		else
		{
			a3().l();
		}
		if (!flag && !flag2)
		{
			((ck)j).aj = this.m_h;
			bf();
			r = false;
			q = false;
			SetMenuState(global::m.MenuState.b);
		}
	}

	public override void g(GameTime A_0)
	{
		l.am = b0.d().p();
		if (a8().ba() && t)
		{
			if (!s)
			{
				t = false;
				u.au();
				r = true;
				bf();
			}
		}
		else
		{
			if (base.k != null)
			{
				b(A_0);
			}
			base.g(A_0);
		}
	}

	public void ToggleSound(ck A_0)
	{
		if (b0.d().p())
		{
			b0.d().g(0.5f);
			l.am = false;
		}
		else
		{
			b0.d().f(0.5f);
			l.am = true;
		}
	}

	private bool a(float A_0, int A_1)
	{
		float num = (float)A_1 - ((ck)j).aj;
		float num2 = num * A_0 * 10f;
		if (Math.Abs(num2) > 1f)
		{
			((ck)j).aj += (int)num2;
			return true;
		}
		return false;
	}

	private void e(ck A_0)
	{
		b0.d().j(A_0: true);
		t = true;
		a8().f(A_0: true);
	}

	private void c(ck A_0)
	{
		b0.d().j(A_0: true);
		a9().c(m.z);
		r = true;
		bf();
	}

	private void a(ck A_0)
	{
		bf();
		bk bk2 = (bk)base.n.e()["tutorialPage"];
		bk2.a(new List<string>(Enumerable.Distinct<string>((IEnumerable<string>)u.a9())));
		u.a9().Clear();
		c(bk2);
	}

	public override void c()
	{
		bf();
	}
}
