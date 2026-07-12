using Microsoft.Xna.Framework;

internal class az : cm
{
	private float ai;

	private float aj;

	private int al;

	private int am;

	private cd an;

	public override void e()
	{
		base.e();
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
		ae ae2 = u.a().g("STORY_BOSS_BG");
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
		da3.i(u.a().g("STORY_BOSS_THEME_2"));
		da3.af = 0f;
		da3.ah = num;
		((ck)da3).al = false;
		obj2.be(da3);
		cd obj3 = an;
		da da4 = new da();
		da4.i(u.a().g("STORY_BOSS_KING_ESCAPING"));
		da4.af = 0f;
		da4.ah = num;
		((ck)da4).al = false;
		obj3.be(da4);
		cd obj4 = an;
		da da5 = new da();
		da5.i(u.a().g("STORY_HIDE_BIRDS_4"));
		da5.af = 0f;
		da5.ah = num;
		((ck)da5).al = false;
		obj4.be(da5);
		cd obj5 = an;
		da da6 = new da();
		da6.i(u.a().g("STORY_BIG_BROTHER_2"));
		da6.af = 0f;
		da6.ah = num;
		((ck)da6).al = false;
		obj5.be(da6);
		cd obj6 = an;
		da da7 = new da();
		da7.i(u.a().g("STORY_BOSS_2_HELMET"));
		da7.af = 0f;
		da7.ah = num;
		((ck)da7).al = false;
		obj6.be(da7);
		p(an);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		an.d(A_0);
		if (bc() == global::m.MenuState.a)
		{
			aj -= A_0.ElapsedGameTime.Milliseconds;
			switch (ar)
			{
			case cm.CutScenePhase.b:
				if (aj < 0f)
				{
					aj = 0f;
					ai = (float)(al - 800) / 1.002f;
					ar = cm.CutScenePhase.c;
				}
				break;
			case cm.CutScenePhase.c:
			{
				float num = (float)A_0.ElapsedGameTime.Milliseconds / 1000f;
				((ck)an).aj = ((ck)an).aj - num * ai;
				if (((ck)an).aj <= (float)(800 - al))
				{
					((ck)an).aj = 800 - al;
					ar++;
					aj = 2500f;
				}
				break;
			}
			case (cm.CutScenePhase)3:
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
		aj = 3500f;
		((ck)an).aj = 0f;
		((ck)an).ak = 0f;
		((ck)an).al = @as;
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
