using Microsoft.Xna.Framework;

internal class aj : cm
{
	private float x;

	private float y;

	private float z;

	private int aa;

	private int ab;

	private cd ac;

	private cw ad;

	private cw ae;

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
		ad = b0.d().d("piglette_oink_story");
		ae = b0.d().d("birds_outro");
		ae ae2 = u.a().g("STORY_END_1");
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
		da3.i(u.a().g("STORY_END_KING_EYE_NORMAL"));
		da3.af = 0f;
		da3.ah = num;
		((ck)da3).al = false;
		da3.am = false;
		obj2.be(da3);
		cd obj3 = ac;
		da da4 = new da();
		da4.i(u.a().g("STORY_END_KING_EYE_PEEK"));
		da4.af = 0f;
		da4.ah = num;
		((ck)da4).al = false;
		da4.am = false;
		obj3.be(da4);
		cd obj4 = ac;
		da da5 = new da();
		da5.i(u.a().g("STORY_END_KING_EYE_WINK"));
		da5.af = 0f;
		da5.ah = num;
		((ck)da5).al = false;
		da5.am = false;
		obj4.be(da5);
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
					ac.bw()[1].am = true;
					z = 0f;
					x = (float)(aa - 800) / 516f;
					y = 90f;
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
					z = 1000f;
				}
				break;
			}
			case (cm.CutScenePhase)3:
				if (z < 0f)
				{
					ac.bw()[1].am = true;
					z = 500f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)4:
				if (z < 0f)
				{
					ac.bw()[1].am = false;
					ac.bw()[2].am = true;
					z = 1000f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)5:
				if (z < 0f)
				{
					ac.bw()[1].am = true;
					ac.bw()[2].am = false;
					z = 1300f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)6:
				if (z <= 0f)
				{
					ac.bw()[1].am = false;
					ac.bw()[2].am = false;
					ac.bw()[3].am = true;
					z = 150f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)7:
				if (z <= 0f)
				{
					ac.bw()[3].am = false;
					ac.bw()[1].am = true;
					ad.y(1f);
					ad.ac();
					z = 2000f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)8:
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
		cw cw2 = b0.d().d("birds_outro");
		cw2.y(1f);
		cw2.ac();
		ac.bw()[1].am = false;
		ac.bw()[2].am = false;
		ac.bw()[3].am = false;
		ar = cm.CutScenePhase.b;
		z = 2500f;
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
		n.e()["mainMenu"].c(n.e()["aboutPage"]);
		n.c("mainMenu");
	}
}
