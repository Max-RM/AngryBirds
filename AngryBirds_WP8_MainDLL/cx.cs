using System.Collections.Generic;
using Microsoft.Xna.Framework;

internal class cx : z
{
	public cx()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		a(new List<Color>
		{
			new Color(105, 184, 225),
			new Color(184, 152, 91)
		});
	}

	public override void e()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		u u2 = u.a();
		a("CutSceneTheme4Start");
		p("episode2");
		SetMenuState(global::m.MenuState.a);
		a3().g(a2()[0]);
		da da2 = new da();
		da2.i(u2.g("LS_THEME_4_LEFT"));
		da2.af = 0f;
		da2.ah = 480f;
		p(da2);
		da da3 = new da();
		da3.i(u2.g("LS_THEME_4_RIGHT"));
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
		av a_ = di.d().d("episode2");
		a(a_);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
	}
}
