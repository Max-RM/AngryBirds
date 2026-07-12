using Microsoft.Xna.Framework;

internal class j : cm
{
	private new float m_jValue;

	private new float k;

	private new float l;

	private new int m;

	private new int n;

	private cd q;

	private cw r;

	public override void e()
	{
		base.e();
		o(0);
		f(0);
		q = new cd
		{
			af = 0f,
			ah = 0f,
			al = true,
			y = a
		};
		q.aa = u.a().f("menu_confirm");
		r = b0.d().d("piglette_oink_story");
		ae ae2 = u.a().g("STORY_BOSS_BG");
		m = ae2.c;
		n = ae2.d;
		int num = (480 - n) / 2;
		cd obj = q;
		da da2 = new da();
		da2.i(ae2);
		da2.af = 0f;
		da2.ah = num;
		((ck)da2).al = false;
		obj.be(da2);
		cd obj2 = q;
		da da3 = new da();
		da3.i(u.a().g("STORY_HIDE_HOOF_2"));
		da3.af = 0f;
		da3.ah = num;
		((ck)da3).al = false;
		obj2.be(da3);
		cd obj3 = q;
		da da4 = new da();
		da4.i(u.a().g("STORY_BOSS_KING_ESCAPING_4"));
		da4.af = 0f;
		da4.ah = num;
		((ck)da4).al = false;
		obj3.be(da4);
		cd obj4 = q;
		da da5 = new da();
		da5.i(u.a().g("STORY_BOSS_CARPET"));
		da5.af = 0f;
		da5.ah = num;
		((ck)da5).al = false;
		obj4.be(da5);
		cd obj5 = q;
		da da6 = new da();
		da6.i(u.a().g("STORY_BOSS_KING_ESCAPING_4_EYE_2"));
		da6.af = 0f;
		da6.ah = num;
		((ck)da6).al = false;
		da6.am = false;
		obj5.be(da6);
		cd obj6 = q;
		da da7 = new da();
		da7.i(u.a().g("STORY_BOSS_KING_ESCAPING_4_EYE_WINK"));
		da7.af = 0f;
		da7.ah = num;
		((ck)da7).al = false;
		da7.am = false;
		obj6.be(da7);
		p(q);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		q.d(A_0);
		if (bc() == global::m.MenuState.a)
		{
			l -= A_0.ElapsedGameTime.Milliseconds;
			switch (ar)
			{
			case cm.CutScenePhase.b:
				if (l < 0f)
				{
					l = 0f;
					m_jValue = (float)(m - 800) / 100f;
					k = 100f;
					ar = cm.CutScenePhase.c;
				}
				break;
			case cm.CutScenePhase.c:
			{
				float num = (float)A_0.ElapsedGameTime.Milliseconds / 1000f;
				((ck)q).aj = ((ck)q).aj - num * k * m_jValue;
				if (((ck)q).aj <= (float)(800 - m))
				{
					((ck)q).aj = 800 - m;
					ar++;
					l = 1500f;
				}
				break;
			}
			case (cm.CutScenePhase)3:
				if (l < 0f)
				{
					q.bw()[4].am = true;
					l = 1000f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)4:
				if (l < 0f)
				{
					q.bw()[4].am = false;
					l = 1300f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)5:
				if (l < 0f)
				{
					q.bw()[5].am = true;
					l = 150f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)6:
				if (l < 0f)
				{
					r.y(1f);
					r.ac();
					q.bw()[5].am = false;
					l = 2000f;
					ar++;
				}
				break;
			case (cm.CutScenePhase)7:
				if (l < 0f)
				{
					ar = cm.CutScenePhase.d;
					l = 0f;
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
		l = 3500f;
		((ck)q).aj = 0f;
		((ck)q).ak = 0f;
		q.bw()[0].am = true;
		q.bw()[1].am = true;
		q.bw()[2].am = true;
		q.bw()[3].am = true;
		q.bw()[4].am = false;
		q.bw()[5].am = false;
		((ck)q).al = @as;
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
		base.n.e()["mainMenu"].c(base.n.e()["aboutPage"]);
		base.n.c("mainMenu");
	}
}
