using Microsoft.Xna.Framework;

internal class ao : cm
{
	private new delegate void SceneCallback();

	private float ah;

	private float ai;

	private float aj;

	private int ak;

	private int al;

	private cd am;

	private SceneCallback an;

	private bool m_aoFlag;

	public override void e()
	{
		base.e();
		au("episode1");
		o(0);
		f(0);
		am = new cd
		{
			af = 0f,
			ah = 0f,
			al = true,
			y = a
		};
		am.aa = u.a().f("menu_confirm");
		ae ae2 = u.a().g("STORY_BEGIN_BG");
		ak = ae2.c;
		al = ae2.d;
		int num = (480 - al) / 2;
		cd obj = am;
		da da2 = new da();
		da2.i(ae2);
		da2.af = 0f;
		da2.ah = num;
		obj.be(da2);
		cd obj2 = am;
		da da3 = new da();
		da3.i(u.a().g("STORY_BEGIN_PIG_GROUP_1"));
		da3.af = 0f;
		da3.ah = num;
		obj2.be(da3);
		p(am);
	}

	public override void f()
	{
		base.f();
		m_aoFlag = false;
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		if (a8().ba() && an != null)
		{
			if (!m_aoFlag)
			{
				an();
			}
			return;
		}
		am.d(A_0);
		if (bc() != 0)
		{
			return;
		}
		aj -= A_0.ElapsedGameTime.Milliseconds;
		switch (ar)
		{
		case cm.CutScenePhase.b:
			if (aj < 0f)
			{
				ah = (float)(ak - 800) / 516f;
				ai = 60f;
				ar = cm.CutScenePhase.c;
				aj = 0f;
			}
			break;
		case cm.CutScenePhase.c:
		{
			float num = (float)A_0.ElapsedGameTime.Milliseconds / 1000f;
			((ck)am).aj = ((ck)am).aj - num * ai * ah;
			if (((ck)am).aj <= (float)(800 - ak))
			{
				((ck)am).aj = 800 - ak;
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

	public override void h(GameTime A_0)
	{
		a8().f(A_0: false);
		b0.d().k(A_0: true);
		cw cw2 = b0.d().d("birds_intro");
		cw2.y(1f);
		cw2.ac();
		ar = cm.CutScenePhase.b;
		aj = 4500f;
		((ck)am).aj = 0f;
		((ck)am).ak = 0f;
		@as = d.p().z();
		((ck)am).al = @as;
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
		m_aoFlag = true;
		an = au;
		b0.d().k(A_0: true);
	}

	private void au()
	{
		an = null;
		SetMenuState(global::m.MenuState.d);
		d.p().r(A_0: true);
		av()();
	}
}
