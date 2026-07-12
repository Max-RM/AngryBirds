using Microsoft.Xna.Framework;

internal class cz : cm
{
	private new float m_au;

	private new float av;

	private int aw;

	private int ax;

	private cd ay;

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
		da3.i(u.a().g("STORY_WEST_MOUSTACHE_PIG_1"));
		da3.af = 411f;
		da3.ah = 183f;
		((ck)da3).al = false;
		obj2.be(da3);
		cd obj3 = ay;
		da da4 = new da();
		da4.i(u.a().g("STORY_WEST_PIGS_ESCAPE_2"));
		da4.af = 748f;
		da4.ah = 183f;
		((ck)da4).al = false;
		obj3.be(da4);
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
		cw cw2 = b0.d().d("birds_boss");
		cw2.y(1f);
		cw2.ac();
		ar = cm.CutScenePhase.b;
		av = 3500f;
		((ck)ay).aj = 0f;
		((ck)ay).ak = 0f;
		((ck)ay).al = @as;
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
		z z2 = (z)n.e()["episode5"];
		n.c("episode5");
		z2.ax();
	}
}
