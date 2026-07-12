using Microsoft.Xna.Framework;

internal class ag : cm
{
	private float x;

	private float y;

	private float z;

	private int aa;

	private int ab;

	private cd ac;

	public override void e()
	{
		base.e();
		o(0);
		f(0);
		ac = new cd
		{
			af = 0f,
			ah = 0f,
			al = true,
			y = a
		};
		ac.aa = u.a().f("menu_confirm");
		ae ae2 = u.a().g("STORY_BOSS_BG");
		aa = ae2.c;
		ab = ae2.d;
		int num = (480 - ab) / 2;
		cd obj = ac;
		da da2 = new da();
		da2.i(ae2);
		da2.af = 0f;
		da2.ah = num;
		((ck)da2).al = false;
		obj.be(da2);
		cd obj2 = ac;
		da da3 = new da();
		da3.i(u.a().g("STORY_BOSS_THEME_1"));
		da3.af = 0f;
		da3.ah = num;
		((ck)da3).al = false;
		obj2.be(da3);
		cd obj3 = ac;
		da da4 = new da();
		da4.i(u.a().g("STORY_BOSS_KING_ESCAPING"));
		da4.af = 0f;
		da4.ah = num;
		((ck)da4).al = false;
		obj3.be(da4);
		cd obj4 = ac;
		da da5 = new da();
		da5.i(u.a().g("STORY_HIDE_BIRDS_4"));
		da5.af = 0f;
		da5.ah = num;
		((ck)da5).al = false;
		obj4.be(da5);
		cd obj5 = ac;
		da da6 = new da();
		da6.i(u.a().g("STORY_BIG_BROTHER_2"));
		da6.af = 0f;
		da6.ah = num;
		((ck)da6).al = false;
		obj5.be(da6);
		cd obj6 = ac;
		da da7 = new da();
		da7.i(u.a().g("STORY_BOSS_1_HELMET"));
		da7.af = 0f;
		da7.ah = num;
		((ck)da7).al = false;
		obj6.be(da7);
		p(ac);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		ac.d(A_0);
		if (bc() == global::m.MenuState.a)
		{
			z -= A_0.ElapsedGameTime.Milliseconds;
			switch (ar)
			{
			case cm.CutScenePhase.b:
				if (z < 0f)
				{
					z = 0f;
					x = (float)(aa - 800) / 100f;
					y = 100f;
					ar = cm.CutScenePhase.c;
				}
				break;
			case cm.CutScenePhase.c:
			{
				float num = (float)A_0.ElapsedGameTime.Milliseconds / 1000f;
				((ck)ac).aj = ((ck)ac).aj - num * y * x;
				if (((ck)ac).aj <= (float)(800 - aa))
				{
					((ck)ac).aj = 800 - aa;
					ar++;
					z = 2500f;
				}
				break;
			}
			case (cm.CutScenePhase)3:
				if (z < 0f)
				{
					ar = cm.CutScenePhase.d;
					z = 0f;
				}
				break;
			case cm.CutScenePhase.d:
				au();
				break;
			}
		}
		else
		{
			base.g(A_0);
		}
	}

	public override void h(GameTime A_0)
	{
		a8().f(A_0: false);
		b0.d().k(A_0: true);
		cw cw2 = b0.d().d("birds_boss");
		cw2.y(1f);
		cw2.ac();
		ar = cm.CutScenePhase.b;
		z = 3500f;
		((ck)ac).aj = 0f;
		((ck)ac).ak = 0f;
		((ck)ac).al = @as;
		SetMenuState(global::m.MenuState.a);
	}

	public override void b(GameTime A_0)
	{
		b0.d().k(A_0: true);
		SetMenuState(global::m.MenuState.b);
	}

	public void a(ck A_0)
	{
		au();
	}

	public void au()
	{
		SetMenuState(global::m.MenuState.d);
		dg dg2 = (dg)n.e()["episode4"];
		n.c("episode4");
		dg2.ax();
	}
}
