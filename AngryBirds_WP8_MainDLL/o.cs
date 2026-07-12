using System.Collections.Generic;
using AngryBirds.Menus;
using Microsoft.Xna.Framework;

internal class o : z
{
	private string s = "Level11";

	private da t;

	public o()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		a(new List<Color>
		{
			new Color(82, 103, 43),
			new Color(21, 31, 63),
			new Color(190, 219, 229)
		});
	}

	public override void e()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		u u2 = u.a();
		a("CutSceneTheme6Start");
		p("episode3");
		SetMenuState(global::m.MenuState.a);
		a3().g(a2()[0]);
		da da2 = new da();
		da2.i(u2.g("LS_THEME_6_LEFT"));
		da2.af = 0f;
		da2.ah = 480f;
		p(da2);
		da da3 = new da();
		da3.i(u2.g("LS_THEME_6_RIGHT"));
		da3.af = 800f;
		da3.ah = 480f;
		p(da3);
		da da4 = new da();
		da4.i(u2.g("LS_BACK_BUTTON"));
		da4.af = 0f;
		da4.ah = 480f;
		da4.y = a9().c;
		da4.z = "episodeSelectionPage";
		((ck)da4).al = true;
		da4.aa = u2.f("menu_back");
		p(da4);
		av a_ = di.d().d("episode3");
		a(a_);
		da da5 = new da();
		da5.i(u2.g("GOLDEN_EGG_1"));
		da5.af = 2680f;
		da5.ah = 240f;
		((ck)da5).al = false;
		da5.am = false;
		p(t = da5);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		if (t.am)
		{
			t.aj = ((ck)a1()).aj;
			if (t.aj < -1879.9999f - (float)t.bf().c)
			{
				t.am = false;
				a(s, A_1: false, A_2: true);
				a1().bt();
				a1().be(A_0: true);
			}
		}
	}

	public override void h(GameTime A_0)
	{
		base.h(A_0);
		if (d.p().s(s) == GoldenEggType.Locked)
		{
			t.am = true;
		}
	}
}
