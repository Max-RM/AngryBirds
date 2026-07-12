using Microsoft.Xna.Framework;

internal class ap : cm
{
	private float ah;

	private float ai;

	private int aj;

	private int ak;

	private cd al;

	public override void e()
	{
		base.e();
		o(0);
		f(0);
		al = new cd
		{
			af = 0f,
			ah = 0f,
			al = true,
			y = a
		};
		al.aa = u.a().f("menu_confirm");
		ae ae2 = u.a().g("STORY_BOSS_BG");
		aj = ae2.c;
		ak = ae2.d;
		int num = (480 - ak) / 2;
		cd obj = al;
		da da2 = new da();
		da2.i(ae2);
		da2.af = 0f;
		da2.ah = num;
		((ck)da2).al = false;
		obj.be(da2);
		cd obj2 = al;
		da da3 = new da();
		da3.i(u.a().g("STORY_WEST_HELMET_PIG_1"));
		da3.af = 403f;
		da3.ah = 234f;
		((ck)da3).al = false;
		obj2.be(da3);
		cd obj3 = al;
		da da4 = new da();
		da4.i(u.a().g("STORY_WEST_PIGS_ESCAPE_1"));
		da4.af = 738f;
		da4.ah = 236f;
		((ck)da4).al = false;
		obj3.be(da4);
		p(al);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		al.d(A_0);
		if (bc() == global::m.MenuState.a)
		{
			ai -= A_0.ElapsedGameTime.Milliseconds;
			switch (ar)
			{
			case cm.CutScenePhase.b:
				if (ai < 0f)
				{
					ai = 0f;
					ah = (float)(aj - 800) / 1.002f;
					ar = cm.CutScenePhase.c;
				}
				break;
			case cm.CutScenePhase.c:
			{
				float num = (float)A_0.ElapsedGameTime.Milliseconds / 1000f;
				((ck)al).aj = ((ck)al).aj - num * ah;
				if (((ck)al).aj <= (float)(800 - aj))
				{
					((ck)al).aj = 800 - aj;
					ar++;
					ai = 3000f;
				}
				break;
			}
			case (cm.CutScenePhase)3:
				if (ai < 0f)
				{
					ar = cm.CutScenePhase.d;
					ai = 0f;
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
		ai = 3500f;
		((ck)al).aj = 0f;
		((ck)al).ak = 0f;
		((ck)al).al = @as;
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
