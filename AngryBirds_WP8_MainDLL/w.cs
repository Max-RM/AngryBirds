using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Phone.Tasks;
using Microsoft.Xna.Framework;

internal class w : z
{
	private z.LevelButton s;

	private z.LevelButton t;

	private z.LevelButton v;

	public w()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		a(new List<Color>
		{
			new Color(126, 113, 89),
			new Color(99, 142, 160),
			new Color(67, 82, 62),
			new Color(67, 82, 62)
		});
	}

	public override void e()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		u u2 = u.a();
		a("CutSceneTheme12Start");
		p("episode5");
		SetMenuState(global::m.MenuState.a);
		a3().g(a2()[0]);
		da da2 = new da();
		da2.i(u2.g("LS_THEME_1_LEFT"));
		da2.af = 0f;
		da2.ah = 480f;
		p(da2);
		da da3 = new da();
		da3.i(u2.g("LS_THEME_12_RIGHT"));
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
		av a_ = di.d().d("episode5");
		a(a_);
		au();
	}

	private void au()
	{
		try
		{
			u u2 = u.a();
			cd cd2 = (cd)Enumerable.Last<ck>((IEnumerable<ck>)a1().bw());
			a8 a10 = di.d().f("packFacebook1");
			if (a10 == null) return;
			ae ae2 = u2.g(a10.c);
			if (ae2 == null) return;
			s = (z.LevelButton)cd2.bw()[0];
			t = (z.LevelButton)cd2.bw()[1];
			v = (z.LevelButton)cd2.bw()[2];
			da da2 = new da();
			ae fbLike = u2.g("FB_LIKE_BUTTON") ?? u2.g("BUTTON_FACEBOOK_SMALL") ?? ae2;
			da2.i(fbLike);
			da2.af = cd2.af;
			da2.ah = 158.40001f;
			da2.y = OnFacebookClick;
			((ck)da2).al = true;
			da2.aa = u2.f("menu_confirm");
			da da3 = da2;
			cd2.be(s);
			cd2.be(t);
			cd2.be(v);
			cd2.be(da3);
			int d1 = da3.bf() != null ? da3.bf().d : 50;
			int d2 = (s != null && s.m != null && s.m.bf() != null) ? s.m.bf().d : 50;
			float a_ = da3.ah + (float)(d1 / 2) + (float)(d2 / 2);
			if (s != null) s.i(cd2.af - (float)ae2.c - 40f, a_);
			if (t != null) t.i(cd2.af, a_);
			if (v != null) v.i(cd2.af + (float)ae2.c + 40f, a_);
			da da4 = new da();
			ae fbSmall = u2.g("BUTTON_FACEBOOK_SMALL") ?? fbLike;
			if (fbSmall != null)
			{
				da4.i(fbSmall);
				da4.i(0.5f);
				da4.ai(0.5f);
				da4.am = false;
				da a_2 = da4;
				a0().i(a0().be() - 1, a_2);
			}
		}
		catch
		{
		}
	}

	public override void h(GameTime A_0)
	{
		base.h(A_0);
		av();
	}

	public void av()
	{
		if (s != null && t != null && v != null)
		{
			if (d.p().s())
			{
				s.be();
				t.be();
				v.be();
			}
			else
			{
				s.bk();
				t.bk();
				v.bk();
			}
		}
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
	}

	public void OnFacebookClick(ck A_0)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		d.p().q(A_0: true);
		WebBrowserTask val = new WebBrowserTask();
		val.URL = Uri.EscapeDataString("http://www.angrybirds.com/redirect.php?device=wp7&product=angrybirds&variant=full&type=facebooklike");
		val.Show();
	}
}
