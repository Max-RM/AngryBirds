using Microsoft.Xna.Framework;

internal class bz : cm
{
	private new float ar;

	private new float @as;

	private int at;

	private new int m_au;

	private new cd av;

	private da aw;

	private da ax;

	private da ay;

	private cw az;

	public override void e()
	{
		base.e();
		o(0);
		f(0);
		av = new cd
		{
			af = 0f,
			ah = 0f,
			al = true,
			y = a
		};
		av.aa = u.a().f("menu_confirm");
		az = b0.d().d("piglette_oink_story");
		ae ae2 = u.a().g("STORY_BOSS_BG");
		at = ae2.c;
		this.m_au = ae2.d;
		int num = (480 - this.m_au) / 2;
		cd obj = av;
		da da2 = new da();
		da2.i(ae2);
		da2.af = 0f;
		da2.ah = num;
		((ck)da2).al = false;
		obj.be(da2);
		cd obj2 = av;
		da da3 = new da();
		da3.i(u.a().g("STORY_WEST_KING_DEAD_1"));
		da3.af = 491f;
		da3.ah = 148f;
		((ck)da3).al = false;
		obj2.be(da3);
		cd obj3 = av;
		da da4 = new da();
		da4.i(u.a().g("STORY_WEST_KING_DEAD_2"));
		da4.af = 383f;
		da4.ah = 321f;
		((ck)da4).al = false;
		obj3.be(da4);
		cd obj4 = av;
		da da5 = new da();
		da5.i(u.a().g("STORY_WEST_EGGS_BACK"));
		da5.af = 8f;
		da5.ah = 162f;
		((ck)da5).al = false;
		obj4.be(da5);
		cd obj5 = av;
		da da6 = new da();
		da6.i(u.a().g("STORY_WEST_KING_EYE_OPEN"));
		da6.af = 0f;
		da6.ah = 0f;
		((ck)da6).al = false;
		obj5.be(aw = da6);
		cd obj6 = av;
		da da7 = new da();
		da7.i(u.a().g("STORY_WEST_KING_EYE_PEAK"));
		da7.af = 0f;
		da7.ah = 0f;
		((ck)da7).al = false;
		obj6.be(ax = da7);
		cd obj7 = av;
		da da8 = new da();
		da8.i(u.a().g("STORY_WEST_KING_EYE_WINK"));
		da8.af = 0f;
		da8.ah = 0f;
		((ck)da8).al = false;
		obj7.be(ay = da8);
		p(av);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		av.d(A_0);
		if (bc() == global::m.MenuState.a)
		{
			@as -= A_0.ElapsedGameTime.Milliseconds;
			switch (base.ar)
			{
			case cm.CutScenePhase.b:
				if (@as < 0f)
				{
					@as = 0f;
					ar = (float)(at - 800) / 1.002f;
					base.ar = cm.CutScenePhase.c;
				}
				break;
			case cm.CutScenePhase.c:
			{
				float num = (float)A_0.ElapsedGameTime.Milliseconds / 1000f;
				((ck)av).aj = ((ck)av).aj - num * ar;
				if (((ck)av).aj <= (float)(800 - at))
				{
					((ck)av).aj = 800 - at;
					base.ar++;
					@as = 3000f;
				}
				break;
			}
			case (cm.CutScenePhase)3:
				if (@as < 0f)
				{
					ay.am = false;
					aw.am = true;
					@as = 1000f;
					base.ar++;
				}
				break;
			case (cm.CutScenePhase)4:
				if (@as < 0f)
				{
					aw.am = false;
					ax.am = true;
					@as = 1000f;
					base.ar++;
				}
				break;
			case (cm.CutScenePhase)5:
				if (@as < 0f)
				{
					ax.am = false;
					aw.am = true;
					@as = 1000f;
					base.ar++;
				}
				break;
			case (cm.CutScenePhase)6:
				if (@as < 0f)
				{
					az.y(1f);
					az.ac();
					ay.am = true;
					@as = 200f;
					base.ar++;
				}
				break;
			case (cm.CutScenePhase)7:
				if (@as < 0f)
				{
					ay.am = false;
					aw.am = true;
					@as = 1500f;
					base.ar++;
				}
				break;
			case (cm.CutScenePhase)8:
				if (@as < 0f)
				{
					base.ar = cm.CutScenePhase.d;
					@as = 0f;
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
		cw cw2 = b0.d().d("birds_outro");
		cw2.y(1f);
		cw2.ac();
		base.ar = cm.CutScenePhase.b;
		@as = 3500f;
		((ck)av).aj = 0f;
		((ck)av).ak = 0f;
		((ck)av).al = base.@as;
		aw.am = false;
		ax.am = false;
		ay.am = false;
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
		n.e()["mainMenu"].c(n.e()["aboutPage"]);
		n.c("mainMenu");
	}
}
