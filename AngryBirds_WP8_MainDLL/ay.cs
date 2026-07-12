using Microsoft.Xna.Framework;

internal class ay : cm
{
	private new delegate void SceneCallback();

	private float ai;

	private float aj;

	private float al;

	private int am;

	private int an;

	private cd ao;

	private SceneCallback ap;

	private bool aq;

	public override void e()
	{
		base.e();
		au("episode2");
		o(0);
		f(0);
		ao = new cd
		{
			af = 0f,
			ah = 0f,
			al = true,
			y = a
		};
		ao.aa = u.a().f("menu_confirm");
		ae ae2 = u.a().g("STORY_BEGIN_BG");
		am = ae2.c;
		an = ae2.d;
		int num = (480 - an) / 2;
		cd obj = ao;
		da da2 = new da();
		da2.i(ae2);
		da2.af = 0f;
		da2.ah = num;
		obj.be(da2);
		cd obj2 = ao;
		da da3 = new da();
		da3.i(u.a().g("STORY_BEGIN_FAKE_EGGS"));
		da3.af = 0f;
		da3.ah = num;
		((ck)da3).al = false;
		obj2.be(da3);
		cd obj3 = ao;
		da da4 = new da();
		da4.i(u.a().g("STORY_BEGIN_PIG_GROUP_2"));
		da4.af = 0f;
		da4.ah = num;
		((ck)da4).al = false;
		obj3.be(da4);
		p(ao);
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
		ao.d(A_0);
		if (bc() != 0)
		{
			return;
		}
		al -= A_0.ElapsedGameTime.Milliseconds;
		switch (ar)
		{
		case cm.CutScenePhase.b:
			if (al < 0f)
			{
				al = 0f;
				ai = (float)(am - 800) / 516f;
				aj = 60f;
				ar = cm.CutScenePhase.c;
			}
			break;
		case cm.CutScenePhase.c:
		{
			float num = (float)A_0.ElapsedGameTime.Milliseconds / 1000f;
			((ck)ao).aj = ((ck)ao).aj - num * aj * ai;
			if (((ck)ao).aj <= (float)(800 - am))
			{
				((ck)ao).aj = 800 - am;
				ar++;
				al = 2500f;
			}
			break;
		}
		case (cm.CutScenePhase)3:
			if (al < 0f)
			{
				ar = cm.CutScenePhase.d;
				al = 0f;
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
		ar = cm.CutScenePhase.b;
		al = 4500f;
		((ck)ao).aj = 0f;
		((ck)ao).ak = 0f;
		@as = d.p().aa()["episode2"];
		((ck)ao).al = @as;
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
		d.p().aa()["episode2"] = true;
		SetMenuState(global::m.MenuState.d);
		av()();
	}
}
