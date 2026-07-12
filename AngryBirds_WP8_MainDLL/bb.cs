using Microsoft.Xna.Framework;

internal class bb : cm
{
	private new delegate void SceneCallback();

	private float ai;

	private float aj;

	private int al;

	private int am;

	private cd an;

	private cw ao;

	private SceneCallback ap;

	private bool aq;

	public override void e()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		au("episode4");
		SetLayout(new y());
		a3().an();
		a3().i(A_0: false);
		a3().h(A_0: true);
		a3().g(Color.FromNonPremultiplied(61, 163, 204, 255));
		o(0);
		f(0);
		an = new cd
		{
			af = 0f,
			ah = 0f,
			al = true,
			y = a
		};
		an.aa = u.a().f("menu_confirm");
		ao = b0.d().d("big_brother_awakens");
		ae ae2 = u.a().g("STORY_BEGIN_BG");
		al = ae2.c;
		am = ae2.d;
		int num = (480 - am) / 2;
		cd obj = an;
		da da2 = new da();
		da2.i(ae2);
		da2.af = 0f;
		da2.ah = num;
		((ck)da2).al = false;
		obj.be(da2);
		cd obj2 = an;
		da da3 = new da();
		da3.i(u.a().g("STORY_HIDE_BIRDS_1"));
		da3.af = 0f;
		da3.ah = num;
		((ck)da3).al = false;
		obj2.be(da3);
		cd obj3 = an;
		da da4 = new da();
		da4.i(u.a().g("STORY_HIDE_BIRDS_2"));
		da4.af = 0f;
		da4.ah = num;
		((ck)da4).al = false;
		obj3.be(da4);
		cd obj4 = an;
		da da5 = new da();
		da5.i(u.a().g("STORY_HIDE_BIRDS_3"));
		da5.af = 0f;
		da5.ah = num;
		((ck)da5).al = false;
		obj4.be(da5);
		cd obj5 = an;
		da da6 = new da();
		da6.i(u.a().g("STORY_CONSTRUCTION_YARD"));
		da6.af = 0f;
		da6.ah = num;
		((ck)da6).al = false;
		obj5.be(da6);
		cd obj6 = an;
		da da7 = new da();
		da7.i(u.a().g("STORY_BEGIN_BG_EXTENSION"));
		da7.af = 0f;
		da7.ah = num;
		((ck)da7).al = false;
		obj6.be(da7);
		cd obj7 = an;
		da da8 = new da();
		da8.i(u.a().g("STORY_EP4_START_BIG_BROTHER"));
		da8.af = 0f;
		da8.ah = num;
		((ck)da8).al = false;
		obj7.be(da8);
		p(an);
	}

	public override void f()
	{
		base.f();
		aq = false;
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		if (a8().ba() && ap != null)
		{
			if (!aq)
			{
				ap();
			}
			return;
		}
		an.d(A_0);
		if (bc() != 0)
		{
			return;
		}
		float num = (float)A_0.ElapsedGameTime.Milliseconds / 1000f;
		aj -= A_0.ElapsedGameTime.Milliseconds;
		switch (ar)
		{
		case cm.CutScenePhase.b:
			if (aj < 0f)
			{
				ai = (float)(al - 800) / 8.62f;
				ar = cm.CutScenePhase.c;
			}
			break;
		case cm.CutScenePhase.c:
			((ck)an).aj = ((ck)an).aj - num * ai;
			if (((ck)an).aj <= (float)(800 - al))
			{
				((ck)an).aj = 800 - al;
				ar++;
				aj = 2300f;
			}
			break;
		case (cm.CutScenePhase)3:
			if (aj < 0f)
			{
				aj = 0f;
				ar++;
				ai = (float)u.a().g("STORY_BEGIN_BG_EXTENSION").c / 1.73075f;
			}
			break;
		case (cm.CutScenePhase)4:
			((ck)an).aj = ((ck)an).aj - num * ai;
			if (((ck)an).aj <= (float)(800 - (al + u.a().g("STORY_BEGIN_BG_EXTENSION").c)))
			{
				((ck)an).aj = 800 - (al + u.a().g("STORY_BEGIN_BG_EXTENSION").c);
				ar++;
				aj = 0f;
			}
			break;
		case (cm.CutScenePhase)5:
			if (aj < 0f)
			{
				aj = 2200f;
				ar++;
				ao.y(1f);
				ao.ac();
			}
			break;
		case (cm.CutScenePhase)6:
			if (aj < 0f)
			{
				ar = cm.CutScenePhase.d;
				aj = 0f;
			}
			break;
		case cm.CutScenePhase.d:
			au();
			break;
		}
	}

	public override void h(GameTime A_0)
	{
		a8().f(A_0: false);
		b0.d().k(A_0: true);
		cw cw2 = b0.d().d("birds_intro");
		cw2.y(1f);
		cw2.ac();
		an.bw()[0].al = true;
		ar = cm.CutScenePhase.b;
		aj = 4500f;
		((ck)an).aj = 0f;
		((ck)an).ak = 0f;
		@as = d.p().aa()["episode4"];
		((ck)an).al = @as;
		SetMenuState(global::m.MenuState.a);
	}

	public override void b(GameTime A_0)
	{
		b0.d().k(A_0: true);
		SetMenuState(global::m.MenuState.b);
	}

	private void a(ck A_0)
	{
		a8().f(A_0: true);
		aq = true;
		ap = au;
		b0.d().k(A_0: true);
	}

	public void au()
	{
		ap = null;
		d.p().aa()["episode4"] = true;
		SetMenuState(global::m.MenuState.d);
		av()();
	}
}
