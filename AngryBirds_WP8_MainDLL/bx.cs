using Microsoft.Xna.Framework;

internal class bx : cm
{
	private new float ar;

	private new float @as;

	private float at;

	private new int m_au;

	private new int av;

	private cd aw;

	private cw ax;

	public override void e()
	{
		base.e();
		o(0);
		f(0);
		aw = new cd
		{
			af = 0f,
			ah = 0f,
			al = true,
			y = a
		};
		aw.aa = u.a().f("menu_confirm");
		ax = b0.d().d("piglette_oink_story");
		ae ae2 = u.a().g("STORY_BOSS_BG");
		this.m_au = ae2.c;
		av = ae2.d;
		int num = (480 - av) / 2;
		cd obj = aw;
		da da2 = new da();
		da2.i(ae2);
		da2.af = 0f;
		da2.ah = num;
		((ck)da2).al = false;
		da2.am = false;
		obj.be(da2);
		cd obj2 = aw;
		da da3 = new da();
		da3.i(u.a().g("STORY_BOSS_THEME_4"));
		da3.af = 0f;
		da3.ah = num;
		((ck)da3).al = false;
		da3.am = false;
		obj2.be(da3);
		cd obj3 = aw;
		da da4 = new da();
		da4.i(u.a().g("STORY_END_2_TONGUE"));
		da4.af = 0f;
		da4.ah = num;
		((ck)da4).al = false;
		da4.am = false;
		obj3.be(da4);
		cd obj4 = aw;
		da da5 = new da();
		da5.i(u.a().g("STORY_END_2_EGGS"));
		da5.af = 0f;
		da5.ah = num;
		((ck)da5).al = false;
		da5.am = false;
		obj4.be(da5);
		cd obj5 = aw;
		da da6 = new da();
		da6.i(u.a().g("STORY_END_2_HIDING_KING"));
		da6.af = 0f;
		da6.ah = num;
		((ck)da6).al = false;
		da6.am = false;
		obj5.be(da6);
		cd obj6 = aw;
		da da7 = new da();
		da7.i(u.a().g("STORY_END_2_EYE_OPEN"));
		da7.af = 0f;
		da7.ah = num;
		((ck)da7).al = false;
		da7.am = false;
		obj6.be(da7);
		cd obj7 = aw;
		da da8 = new da();
		da8.i(u.a().g("STORY_END_2_EYE_PEEK"));
		da8.af = 0f;
		da8.ah = num;
		((ck)da8).al = false;
		da8.am = false;
		obj7.be(da8);
		cd obj8 = aw;
		da da9 = new da();
		da9.i(u.a().g("STORY_END_2_EYE_WINK"));
		da9.af = 0f;
		da9.ah = num;
		((ck)da9).al = false;
		da9.am = false;
		obj8.be(da9);
		cd obj9 = aw;
		da da10 = new da();
		da10.i(u.a().g("STORY_END_2_SMILE"));
		da10.af = 0f;
		da10.ah = num;
		((ck)da10).al = false;
		da10.am = false;
		obj9.be(da10);
		p(aw);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		aw.d(A_0);
		if (bc() == global::m.MenuState.a)
		{
			at -= A_0.ElapsedGameTime.Milliseconds;
			switch (base.ar)
			{
			case cm.CutScenePhase.b:
				if (at < 0f)
				{
					at = 0f;
					ar = (float)(this.m_au - 800) / 164f;
					@as = 90f;
					base.ar = cm.CutScenePhase.c;
				}
				break;
			case cm.CutScenePhase.c:
			{
				float num = (float)A_0.ElapsedGameTime.Milliseconds / 1000f;
				((ck)aw).aj = ((ck)aw).aj - num * @as * ar;
				if (((ck)aw).aj <= (float)(800 - this.m_au))
				{
					((ck)aw).aj = 800 - this.m_au;
					base.ar++;
					at = 1500f;
				}
				break;
			}
			case (cm.CutScenePhase)3:
				if (at < 0f)
				{
					aw.bw()[5].am = false;
					aw.bw()[6].am = true;
					at = 1000f;
					base.ar++;
				}
				break;
			case (cm.CutScenePhase)4:
				if (at < 0f)
				{
					aw.bw()[5].am = true;
					aw.bw()[6].am = false;
					at = 1300f;
					base.ar++;
				}
				break;
			case (cm.CutScenePhase)5:
				if (at < 0f)
				{
					aw.bw()[5].am = false;
					aw.bw()[6].am = false;
					aw.bw()[7].am = true;
					at = 150f;
					base.ar++;
				}
				break;
			case (cm.CutScenePhase)6:
				if (at < 0f)
				{
					aw.bw()[5].am = true;
					aw.bw()[7].am = false;
					at = 1000f;
					base.ar++;
				}
				break;
			case (cm.CutScenePhase)7:
				if (at < 0f)
				{
					ax.y(1f);
					ax.ac();
					aw.bw()[5].am = false;
					aw.bw()[8].am = true;
					at = 2000f;
					base.ar++;
				}
				break;
			case (cm.CutScenePhase)8:
				if (at < 0f)
				{
					base.ar = cm.CutScenePhase.d;
					at = 0f;
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
		at = 2500f;
		aw.bw()[0].am = true;
		aw.bw()[1].am = true;
		aw.bw()[2].am = true;
		aw.bw()[3].am = true;
		aw.bw()[4].am = true;
		aw.bw()[5].am = true;
		aw.bw()[6].am = false;
		aw.bw()[7].am = false;
		aw.bw()[8].am = false;
		((ck)aw).al = base.@as;
		((ck)aw).aj = 0f;
		((ck)aw).ak = 0f;
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
