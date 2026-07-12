using System;
using AngryBirds;
using Microsoft.Phone.Tasks;
using Microsoft.Xna.Framework;

internal class ac : c
{
	private bd x;

	private bool y;

	private da z;

	private da aa;

	private k ab;

	private k m_ac;

	private da ad;

	public ac()
	{
		y = false;
	}

	public override void e()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		au((string)null);
		p("mainMenu");
		base.SetMenuState(global::m.MenuState.a);
		base.SetLayout((y)new db());
		a3().an();
		a3().g(new Color(11, 101, 76));
		ae ae2 = u.a().g("PLAY_BUTTON_BG");
		ae ae3 = u.a().i("MENU_PLAY");
		((db)a3()).g(new r((int)((double)(800 - ae3.c) * 0.5) - 20, (int)(240.0 + (double)(17f * di.d().g())) - ae2.d / 2, (int)((double)(800 + ae3.c) * 0.5) + 20, (int)(240.0 + (double)(17f * di.d().g())) + ae2.d / 2));
		u u2 = u.a();
		p(new c6());
		da da2 = new da();
		da2.i(u2.g("BUTTON_YELLOW_BASE"));
		da2.af = 400 - u2.g("BUTTON_YELLOW_BASE").c / 2 - 5;
		da2.ah = (int)(480f - 27f * di.d().g());
		da2.y = a9().c;
		da2.z = "leaderboardPage";
		((ck)da2).al = true;
		p(da2);
		da da3 = new da();
		da3.i(u2.i("TEXT_LEADERBOARD"));
		da3.af = 400 - u2.g("BUTTON_YELLOW_BASE").c / 2 - 5;
		da3.ah = (int)(480f - 29f * di.d().g());
		p(da3);
		da da4 = new da();
		da4.i(u2.g("BUTTON_YELLOW_BASE"));
		da4.af = 400 + u2.g("BUTTON_YELLOW_BASE").c / 2 + 5;
		da4.ah = (int)(480f - 27f * di.d().g());
		da4.y = a9().c;
		da4.z = "achievementsPage";
		((ck)da4).al = true;
		p(da4);
		da da5 = new da();
		da5.i(u2.i("TEXT_ACHIEVEMENTS"));
		da5.af = 400 + u2.g("BUTTON_YELLOW_BASE").c / 2 + 5;
		da5.ah = (int)(480f - 29f * di.d().g());
		p(da5);
		da da6 = new da();
		da6.i(u2.g("MENU_LOGO"));
		da6.af = 400f;
		da6.ah = 7f;
		((ck)da6).al = false;
		p(da6);
		if (dc.IsTrial())
		{
			da da7 = new da();
			da7.i(u2.g("BUTTON_PURCHASE_BASE"));
			da7.af = 400f;
			da7.ah = 360f;
			da7.y = a;
			((ck)da7).al = true;
			da7.am = true;
			da7.ac = false;
			p(z = da7);
			da da8 = new da();
			da8.i(u2.i("TEXT_PURCHASE"));
			da8.af = 400f;
			da8.ah = 360f;
			da8.am = true;
			p(aa = da8);
		}
		k k2 = new k();
		k2.af = 60f;
		((ck)k2).ah = 430f;
		((ck)k2).am = true;
		((ck)k2).al = true;
		k2.i(65);
		p(ab = k2);
		k k3 = new k();
		k3.af = 740f;
		((ck)k3).ah = 430f;
		((ck)k3).am = true;
		((ck)k3).al = true;
		k3.i(65);
		p(m_ac = k3);
		k obj = ab;
		da da9 = new da();
		da9.i(u2.g("BUTTON_OPTIONS"));
		da da10 = new da();
		da10.i(u2.g("BUTTON_EMPTY"));
		obj.i(da9, da10);
		k obj2 = m_ac;
		da da11 = new da();
		da11.i(u2.g("BUTTON_SLIDER"));
		da da12 = new da();
		da12.i(u2.g("BUTTON_EMPTY"));
		obj2.i(da11, da12);
		da da13 = new da();
		da13.i(u2.i("MENU_PLAY"));
		da13.af = 400f;
		da13.ah = (int)(240.0 + (double)(20f * di.d().g()));
		((ck)da13).al = true;
		da13.y = a9().c;
		da13.z = "episodeSelectionPage";
		da13.aa = u2.f("menu_confirm");
		p(da13);
		k obj3 = ab;
		da da14 = new da();
		da14.i(u2.g("BUTTON_ABOUT_SMALL"));
		da14.y = base.au;
		da14.z = "aboutPage";
		((ck)da14).al = true;
		da14.aa = u2.f("menu_confirm");
		obj3.ag(da14);
		cd cd2 = new cd();
		cd2.af = ab.af;
		((ck)cd2).ah = ((ck)ab).ah;
		((ck)cd2).al = true;
		cd cd3 = cd2;
		da da15 = new da();
		da15.i(u2.g("BUTTON_SOUNDS_SMALL"));
		da15.af = ab.af;
		da15.ah = ((ck)ab).ah;
		da15.y = c;
		((ck)da15).al = true;
		cd3.be(da15);
		da da16 = new da();
		da16.i(u2.g("BUTTON_SOUNDS_OFF_SMALL"));
		da16.af = ab.af;
		da16.ah = ((ck)ab).ah;
		((ck)da16).al = false;
		da16.am = b0.d().p();
		cd3.be(ad = da16);
		ab.ag(cd3);
		k obj4 = m_ac;
		da da17 = new da();
		da17.i(u2.g("BUTTON_TRAILER_SMALL"));
		da17.y = f;
		((ck)da17).al = true;
		obj4.ag(da17);
		k obj5 = m_ac;
		da da18 = new da();
		da18.i(u2.g("BUTTON_FACEBOOK_SMALL"));
		da18.y = e;
		((ck)da18).al = true;
		obj5.ag(da18);
		k obj6 = m_ac;
		da da19 = new da();
		da19.i(u2.g("BUTTON_TWITTER_SMALL"));
		da19.y = o;
		((ck)da19).al = true;
		obj6.ag(da19);
		x = (bd)n.e()["aboutPage"];
		x.f(A_0: false);
		e(x);
	}

	public override void f()
	{
		base.f();
	}

	public override void h(GameTime A_0)
	{
		if (!y)
		{
			a1.k();
			a1.c();
			n.g();
			n.c();
			bw.d().f(a);
			y = true;
		}
		if (z != null)
		{
			((ck)z).al = dc.IsTrial();
			z.am = dc.IsTrial();
			aa.am = dc.IsTrial();
		}
		ad.am = b0.d().p();
		s.a().a("title_theme");
		base.SetMenuState(global::m.MenuState.a);
		a3().ao();
	}

	public override void g(GameTime A_0)
	{
		if (x != null && x.ba())
		{
			if (a3() != null)
			{
				((db)a3()).g(A_0: false);
			}
		}
		else if (a3() != null)
		{
			((db)a3()).g(A_0: true);
		}
		if (ab != null)
		{
			ab.d(A_0);
		}
		if (m_ac != null)
		{
			m_ac.d(A_0);
		}
		base.g(A_0);
		ad.am = b0.d().p();
	}

	public void c(ck A_0)
	{
		if (b0.d().p())
		{
			b0.d().g(0.5f);
			ad.am = false;
		}
		else
		{
			b0.d().f(0.5f);
			ad.am = true;
		}
	}

	public void f(ck A_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		WebBrowserTask val = new WebBrowserTask();
		val.URL = Uri.EscapeDataString("http://www.angrybirds.com/redirect.php?device=wp7&product=angrybirds&variant=full&type=trailer");
		val.Show();
	}

	public void o(ck A_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		WebBrowserTask val = new WebBrowserTask();
		val.URL = Uri.EscapeDataString("http://www.angrybirds.com/redirect.php?device=wp7&product=angrybirds&variant=full&type=twitterfollow");
		val.Show();
	}

	public void e(ck A_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		WebBrowserTask val = new WebBrowserTask();
		val.URL = Uri.EscapeDataString("http://www.angrybirds.com/redirect.php?device=wp7&product=angrybirds&variant=full&type=facebook");
		val.Show();
	}

	public void a(ck A_0)
	{
		GameMain.Instance.ShowMarket();
	}

	private void a(object A_0)
	{
	}

	public void au()
	{
		if (z != null)
		{
			z.am = false;
			((ck)z).al = false;
		}
		if (aa != null)
		{
			aa.am = false;
			((ck)aa).al = false;
		}
	}
}
