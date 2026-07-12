using Microsoft.Xna.Framework;

internal class af : cm
{
	private new delegate void SceneCallback();

	private float x;

	private float y;

	private int z;

	private int aa;

	private cd ab;

	private SceneCallback ac;

	private bool ad;

	public override void e()
	{
		base.e();
		au("episode5");
		o(0);
		f(0);
		ab = new cd
		{
			af = 0f,
			ah = 0f,
			al = true,
			y = a
		};
		ab.aa = u.a().f("menu_confirm");
		ae ae2 = u.a().g("STORY_BEGIN_BG");
		z = ae2.c;
		aa = ae2.d;
		_ = (480 - aa) / 2;
		cd obj = ab;
		da da2 = new da();
		da2.i(ae2);
		da2.af = 0f;
		da2.ah = 0f;
		((ck)da2).al = false;
		obj.be(da2);
		cd obj2 = ab;
		da da3 = new da();
		da3.i(u.a().g("STORY_WEST_PIGS_1"));
		da3.af = 1183f;
		da3.ah = 201f;
		((ck)da3).al = false;
		obj2.be(da3);
		cd obj3 = ab;
		da da4 = new da();
		da4.i(u.a().g("STORY_WEST_ROPE_1"));
		da4.af = 1047f;
		da4.ah = 312f;
		((ck)da4).al = false;
		obj3.be(da4);
		cd obj4 = ab;
		da da5 = new da();
		da5.i(u.a().g("STORY_WEST_EGGS_1"));
		da5.af = 778f;
		da5.ah = 265f;
		((ck)da5).al = false;
		obj4.be(da5);
		cd obj5 = ab;
		da da6 = new da();
		da6.i(u.a().g("STORY_WEST_HIDE_1"));
		da6.af = 554f;
		da6.ah = 264f;
		((ck)da6).al = false;
		obj5.be(da6);
		cd obj6 = ab;
		da da7 = new da();
		da7.i(u.a().g("STORY_WEST_HIDE_2"));
		da7.af = 381f;
		da7.ah = 405f;
		((ck)da7).al = false;
		obj6.be(da7);
		p(ab);
	}

	public override void f()
	{
		base.f();
		ad = false;
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		if (a8().ba() && ac != null)
		{
			if (!ad)
			{
				ac();
			}
			return;
		}
		ab.d(A_0);
		if (bc() != 0)
		{
			return;
		}
		float num = (float)A_0.ElapsedGameTime.Milliseconds / 1000f;
		y -= A_0.ElapsedGameTime.Milliseconds;
		switch (ar)
		{
		case cm.CutScenePhase.b:
			if (y < 0f)
			{
				y = 0f;
				x = (float)(z - 800) / 8.62f;
				ar = cm.CutScenePhase.c;
			}
			break;
		case cm.CutScenePhase.c:
			((ck)ab).aj = ((ck)ab).aj - num * x;
			if (((ck)ab).aj <= (float)(800 - z))
			{
				((ck)ab).aj = 800 - z;
				ar++;
				y = 3000f;
			}
			break;
		case (cm.CutScenePhase)3:
			if (y < 0f)
			{
				y = 0f;
				ar = cm.CutScenePhase.d;
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
		y = 4500f;
		((ck)ab).aj = 0f;
		((ck)ab).ak = 0f;
		@as = d.p().aa()["episode5"];
		((ck)ab).al = @as;
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
		ad = true;
		ac = au;
		b0.d().k(A_0: true);
	}

	public void au()
	{
		ac = null;
		d.p().aa()["episode5"] = true;
		SetMenuState(global::m.MenuState.d);
		av()();
	}
}
