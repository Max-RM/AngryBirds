using Microsoft.Xna.Framework;

internal class c7 : cm
{
	private new float m_au;

	private new float av;

	private int aw;

	private int ax;

	private cd ay;

	private da az;

	private da a0;

	private cw a1;

	public override void e()
	{
		base.e();
		o(0);
		f(0);
		ay = new cd
		{
			af = 0f,
			ah = 0f,
			al = true,
			y = a
		};
		ay.aa = u.a().f("menu_confirm");
		a1 = b0.d().d("piglette_oink_story");
		ae ae2 = u.a().g("STORY_BOSS_BG");
		aw = ae2.c;
		ax = ae2.d;
		int num = (480 - ax) / 2;
		cd obj = ay;
		da da2 = new da();
		da2.i(ae2);
		da2.af = 0f;
		da2.ah = num;
		((ck)da2).al = false;
		obj.be(da2);
		cd obj2 = ay;
		da da3 = new da();
		da3.i(u.a().g("STORY_HIDE_HOOF_2"));
		da3.af = 0f;
		da3.ah = num;
		((ck)da3).al = false;
		obj2.be(da3);
		cd obj3 = ay;
		da da4 = new da();
		da4.i(u.a().g("STORY_HIDE_BIRDS_4"));
		da4.af = 0f;
		da4.ah = num;
		((ck)da4).al = false;
		obj3.be(da4);
		cd obj4 = ay;
		da da5 = new da();
		da5.i(u.a().g("STORY_EP4_END"));
		da5.af = 0f;
		da5.ah = num;
		((ck)da5).al = false;
		obj4.be(da5);
		cd obj5 = ay;
		da da6 = new da();
		da6.i(u.a().g("STORY_BIG_BROTHER_2"));
		da6.af = 0f;
		da6.ah = num;
		((ck)da6).al = false;
		obj5.be(da6);
		cd obj6 = ay;
		da da7 = new da();
		da7.i(u.a().g("STORY_BIG_BROTHER_HELMET"));
		da7.af = 0f;
		da7.ah = num;
		((ck)da7).al = false;
		obj6.be(da7);
		cd obj7 = ay;
		da da8 = new da();
		da8.i(u.a().g("STORY_EP4_KING_PEAK"));
		da8.af = 0f;
		da8.ah = num;
		((ck)da8).al = false;
		obj7.be(az = da8);
		cd obj8 = ay;
		da da9 = new da();
		da9.i(u.a().g("STORY_EP4_KING_WINK"));
		da9.af = 0f;
		da9.ah = num;
		((ck)da9).al = false;
		obj8.be(a0 = da9);
		p(ay);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		ay.d(A_0);
		if (bc() == global::m.MenuState.a)
		{
			av -= A_0.ElapsedGameTime.Milliseconds;
			switch (ar)
			{
			case cm.CutScenePhase.b:
				if (av < 0f)
				{
					av = 0f;
					this.m_au = (float)(aw - 800) / 1.002f;
					ar = cm.CutScenePhase.c;
				}
				break;
			case cm.CutScenePhase.c:
			{
				float num = (float)A_0.ElapsedGameTime.Milliseconds / 1000f;
				((ck)ay).aj = ((ck)ay).aj - num * this.m_au;
				if (((ck)ay).aj <= (float)(800 - aw))
				{
					((ck)ay).aj = 800 - aw;
					ar++;
					av = 3000f;
				}
				break;
			}
			case (cm.CutScenePhase)3:
				if (av < 0f)
				{
					a0.am = false;
					av = 1000f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)4:
				if (av < 0f)
				{
					az.am = true;
					av = 1000f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)5:
				if (av < 0f)
				{
					az.am = false;
					av = 1000f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)6:
				if (av < 0f)
				{
					a1.y(1f);
					a1.ac();
					a0.am = true;
					av = 200f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)7:
				if (av < 0f)
				{
					a0.am = false;
					av = 1500f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)8:
				if (av < 0f)
				{
					ar = cm.CutScenePhase.d;
					av = 0f;
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
		ar = cm.CutScenePhase.b;
		av = 3500f;
		((ck)ay).aj = 0f;
		((ck)ay).ak = 0f;
		((ck)ay).al = @as;
		az.am = false;
		a0.am = true;
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
