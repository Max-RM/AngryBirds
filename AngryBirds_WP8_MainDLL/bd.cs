using System;
using AngryBirds;
using AngryBirds.Menus;
using Microsoft.Phone.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class bd : c
{
	private float ai;

	private cd aj;

	private c9 al;

	private da am;

	private da an;

	private da ao;

	private da ap;

	private da aq;

	private da ar;

	private da @as;

	private q at;

	private new string au = "Level5";

	private new cr av;

	private cr aw;

	private cr ax;

	private cr ay;

	private bool az;

	private GameMain a0;

	private DateTime a1;

	public bd(GameMain A_0)
	{
		a0 = A_0;
	}

	public override void e()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		u u2 = u.a();
		au("mainMenu");
		p("aboutPage");
		SetMenuState(global::m.MenuState.b);
		SetLayout(new y());
		a3().an();
		a3().g(dc.j);
		a3().i(A_0: true);
		aj = new cd
		{
			al = false
		};
		c9 c10 = new c9();
		c10.ag(A_0: false);
		c10.ai(A_0: false);
		c10.bg(A_0: true);
		al = c10;
		c9 obj = al;
		da da2 = new da();
		da2.i(u2.g("ABOUT_BIRDS_1"));
		da2.af = 120f * di.d().e();
		da2.ah = 0f;
		obj.be(an = da2);
		c9 obj2 = al;
		cr cr2 = new cr();
		cr2.i(u2.e("TEXT_ABOUT"));
		cr2.af = 120f * di.d().e();
		cr2.ah = 240f;
		cr2.i(200f);
		cr2.i(A_0: true);
		obj2.be(av = cr2);
		c9 obj3 = al;
		da da3 = new da();
		da3.i(u2.g("BUTTON_PRIVACY"));
		da3.af = 120f * di.d().e();
		da3.ah = 0f;
		((ck)da3).al = true;
		da3.y = a;
		obj3.be(ar = da3);
		c9 obj4 = al;
		da da4 = new da();
		da4.i(u2.g("ABOUT_BIRDS_2"));
		da4.af = 120f * di.d().e();
		da4.ah = 480f;
		obj4.be(ao = da4);
		c9 obj5 = al;
		cr cr3 = new cr();
		cr3.i(u2.e("TEXT_CREDITS"));
		cr3.af = 120f * di.d().e();
		cr3.ah = 480f;
		obj5.be(aw = cr3);
		c9 obj6 = al;
		cr cr4 = new cr();
		cr4.i(u2.e("TEXT_CREDITS_INNOGIANT"));
		cr4.af = 120f * di.d().e();
		cr4.ah = 480f;
		obj6.be(ax = cr4);
		c9 obj7 = al;
		da da5 = new da();
		da5.i(u2.g("ABOUT_BIRDS_2"));
		da5.af = 120f * di.d().e();
		da5.ah = 480f;
		obj7.be(aq = da5);
		c9 obj8 = al;
		cr cr5 = new cr();
		cr5.i(u2.e("TEXT_CREDITS_MICROSOFT"));
		cr5.af = 120f * di.d().e();
		cr5.ah = 480f;
		obj8.be(ay = cr5);
		bool flag = d.p().s(au) == GoldenEggType.Locked;
		c9 obj9 = al;
		da da6 = new da();
		da6.i(u2.g("ABOUT_BIRDS_3"));
		da6.af = 120f * di.d().e();
		da6.ah = 480f;
		da6.am = !flag;
		obj9.be(ap = da6);
		c9 obj10 = al;
		da da7 = new da();
		da7.i(u2.g("GOLDEN_EGG_5"));
		da7.af = 120f * di.d().e();
		da7.ah = 1440f;
		((ck)da7).al = flag;
		da7.am = flag;
		da7.y = c;
		obj10.be(@as = da7);
		cd obj11 = aj;
		q q2 = new q();
		q2.af = 0f;
		q2.ah = 0f;
		q2.i(0);
		obj11.be(at = q2);
		aj.be(al);
		cd obj12 = aj;
		da da8 = new da();
		da8.i(u2.g("ARROW_LEFT"));
		da8.af = (float)u2.g("ABOUT_BG").c - 20f * di.d().e();
		da8.ah = 480f - 30f * di.d().e();
		da8.y = base.av;
		((ck)da8).al = true;
		da8.aa = u2.f("menu_back");
		obj12.be(am = da8);
		p(aj);
		int val = 0;
		val = Math.Max(val, aw.bh());
		val = Math.Max(val, ax.bh());
		val = Math.Max(val, ay.bh());
		int num = 50;
		at.i(val + num);
		am.af = at.be();
		al.ai(at.be());
		ai = -at.be();
		((ck)aj).aj = ai;
		av.i((float)(val - num));
		int num2 = val / 2 + num / 2;
		an.af = num2;
		ao.af = num2;
		ap.af = num2;
		aq.af = num2;
		ar.af = num2;
		@as.af = num2;
		av.af = num2;
		aw.af = num2;
		ax.af = num2;
		ay.af = num2;
	}

	public override void f()
	{
		base.f();
	}

	public override void h(GameTime A_0)
	{
		if (!az)
		{
			bool flag = d.p().s(au) == GoldenEggType.Locked;
			an.ah = an.bf().d / 2;
			av.ah = an.ah + (float)(an.bf().d / 2) + 50f;
			ar.ah = av.bi() - ar.bf().d / 2 + 50;
			ao.ah = ar.ah - (float)(ar.bf().d / 2) + 200f;
			aw.ah = ao.ah + (float)(ao.bf().d / 2) + 50f;
			ap.ah = aw.ah + (float)aw.bi() + (float)(ap.bf().d / 2) + 50f;
			@as.ah = ap.ah;
			ax.ah = ap.ah + (float)(ap.bf().d / 2) + 50f;
			aq.ah = ax.ah + (float)ax.bi() + (float)(ap.bf().d / 2) + 50f;
			ay.ah = aq.ah + (float)(aq.bf().d / 2) + 50f;
			ap.am = !flag;
			@as.am = flag;
			az = true;
		}
		s.a().a("title_theme");
		am.am = true;
		float a_ = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		bool flag2 = a(a_, 0f);
		bool flag3 = a3().o();
		if (!flag2 && !flag3)
		{
			((ck)aj).aj = 0f;
			((ck)aj).al = true;
			SetMenuState(global::m.MenuState.a);
			((Game)a0).TargetElapsedTime = TimeSpan.FromTicks(3333L);
		}
	}

	public override void b(GameTime A_0)
	{
		((ck)aj).al = false;
		am.am = false;
		float a_ = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		bool flag = a(a_, ai);
		bool flag2 = a3().m();
		if (!flag && !flag2)
		{
			((ck)aj).aj = ai;
			((ck)al).ak = 0f;
			SetMenuState(global::m.MenuState.b);
			az = false;
			((Game)a0).TargetElapsedTime = TimeSpan.FromTicks(333333L);
		}
	}

	public override void g(GameTime A_0)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		base.g(A_0);
		_ = A_0.ElapsedGameTime.Milliseconds;
		DateTime now = DateTime.Now;
		float num = (float)(now - a1).Ticks / 10000f;
		if (num > 60f)
		{
			num = 33f;
		}
		a1 = now;
		if (bc() != 0 || k != null)
		{
			return;
		}
		if (((ck)aj).al)
		{
			al.bs();
		}
		if (Controls.GetInstance().IsTouchPressed)
		{
			TouchLocation val = Controls.GetInstance().Touches[0];
			if (val.Position.X < al.af + al.bj())
			{
				goto IL_014c;
			}
		}
		((ck)al).ak -= 1.5f * num / 30f;
		if (((ck)al).ak < 0f - (ay.ah + (float)ay.bi()))
		{
			((ck)al).ak = 480f;
		}
		if (((ck)al).ak > 480f)
		{
			((ck)al).ak = 0f - (ay.ah + (float)ay.bi());
		}
		goto IL_014c;
		IL_014c:
		al.d(A_0);
	}

	private bool a(float A_0, float A_1)
	{
		float num = A_1 - ((ck)aj).aj;
		float num2 = num * A_0 * 10f;
		if (Math.Abs(num2) > 1f)
		{
			((ck)aj).aj += num2;
			return true;
		}
		return false;
	}

	private void c(ck A_0)
	{
		@as.am = false;
		((ck)@as).al = false;
		a(au, A_1: false, A_2: true);
	}

	private void a(ck A_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		WebBrowserTask val = new WebBrowserTask();
		val.URL = Uri.EscapeDataString("http://www.rovio.com/index.php?page=privacy-policy");
		val.Show();
	}
}
