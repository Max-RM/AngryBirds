using AngryBirds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;

internal class ax : c
{
	private Color ai;

	private int aj = 5;

	private int al;

	private int am;

	private cd an;

	private c9 ao;

	private da ap;

	private da aq;

	private cr ar;

	private cr @as;

	private bool at;

	public override void e()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		u u2 = u.a();
		p("achievementsPage");
		base.SetMenuState(global::m.MenuState.b);
		ai = new Color(45, 150, 127);
		al = u2.g("ACHIEVEMENTS_TOP_BAR").d - 10;
		an = new cd
		{
			al = true
		};
		cd obj = an;
		da da2 = new da();
		da2.i(u2.g("ACHIEVEMENTS_TOP_BAR"));
		da2.af = 0f;
		da2.ah = 0f;
		((ck)da2).al = false;
		da2.i(800 / u2.g("ACHIEVEMENTS_TOP_BAR").c);
		obj.be(da2);
		cd obj2 = an;
		cr cr2 = new cr();
		cr2.i(u2.e("TEXT_ACHIEVEMENTS"));
		cr2.af = 400f;
		cr2.ah = 5f;
		cr2.ad = new a7(bn.b);
		obj2.be(cr2);
		cd obj3 = an;
		da da3 = new da();
		da3.i(u2.g("GAMESCORE_ICON"));
		da3.af = 775f;
		da3.ah = u2.g("ACHIEVEMENTS_TOP_BAR").d / 2;
		((ck)da3).al = false;
		obj3.be(da3);
		cd obj4 = an;
		da da4 = new da();
		da4.i(u2.g("ARROW_LEFT"));
		da4.af = u2.g("ARROW_LEFT").c / 2;
		da4.ah = u2.g("ARROW_LEFT").d / 2;
		da4.y = a9().c;
		da4.z = "mainMenu";
		((ck)da4).al = true;
		da4.aa = u2.f("menu_back");
		obj4.be(ap = da4);
		da da5 = new da();
		da5.i(u2.g("SCROLL_BAR"));
		da5.af = 800 - u2.g("SCROLL_BAR").c;
		da5.ah = al + u2.g("SCROLL_BAR").d / 2;
		da5.am = false;
		p(aq = da5);
		p(an);
	}

	public override void f()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		bu bu2 = bu.b();
		bu2.b(ai);
		bu2.b(0f, 0f, 800f, 480f);
		bu2.b(Color.White);
		base.f();
	}

	public override void h(GameTime A_0)
	{
		if (!at)
		{
			u.a();
			bw.d().e(a);
			at = true;
			c9 c10 = new c9();
			c10.i(A_0: true);
			c10.ag(A_0: false);
			c10.ai(A_0: false);
			c10.bg(A_0: true);
			ao = c10;
			am = 0;
			a8().f(A_0: true);
		}
	}

	public override void b(GameTime A_0)
	{
		if (e("listContent") != null)
		{
			f("listContent");
		}
		aq.am = false;
		aq.ah = al + u.a().g("SCROLL_BAR").d / 2;
		at = false;
		base.SetMenuState(global::m.MenuState.b);
		a8().f(A_0: false);
	}

	public override void g(GameTime A_0)
	{
		if (Controls.GetInstance().IsBackPressed)
		{
			a8().f(A_0: false);
			at = false;
			a9().c("mainMenu");
			return;
		}
		base.g(A_0);
		_ = A_0.ElapsedGameTime.Milliseconds;
		if (bc() != 0)
		{
			return;
		}
		if (((ck)ao).al)
		{
			ao.bs();
			float num = 480 - al;
			float num2 = (0f - ((ck)ao).ak) / ((float)am - num);
			aq.ai(num / (float)aq.bf().d * (480f / (float)am));
			if (aq.bh() > num / (float)aq.bf().d)
			{
				aq.ai(num / (float)aq.bf().d);
			}
			if (aq.bh() < 0.5f)
			{
				aq.ai(0.5f);
			}
			aq.ah = (float)al + (float)aq.bf().d * aq.bh() / 2f + (num - (float)aq.bf().d * aq.bh()) * num2;
		}
		ao.d(A_0);
	}

	private void a(object A_0)
	{
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		a8().f(A_0: false);
		AchievementCollection val = (AchievementCollection)((A_0 is AchievementCollection) ? A_0 : null);
		if (val == null)
		{
			at = false;
			base.SetMenuState(global::m.MenuState.a);
			return;
		}
		a8().f(A_0: false);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		u u2 = u.a();
		int num5 = u2.g("ACHIEVEMENTS_DARK_BAR").d;
		int num6 = 0;
		aq.am = val.Count > aj;
		foreach (Achievement item in val)
		{
			num6 = al + num * num5;
			int num7 = num6 + num5 / 2;
			int num8 = num6 + num5 / 3;
			int num9 = num6 + num5 / 3 * 2;
			am += num5;
			int gamerScore = item.GamerScore;
			num2 += gamerScore;
			cd cd2 = new cd();
			cd2.af = 400f;
			((ck)cd2).ah = num7;
			cd cd3 = cd2;
			da da2 = new da();
			da2.i((num % 2 == 0) ? u2.g("ACHIEVEMENTS_DARK_BAR") : u2.g("ACHIEVEMENTS_LIGHT_BAR"));
			da2.af = 0f;
			da2.ah = num6;
			da2.i((num % 2 == 0) ? ((800 - u2.g("SCROLL_BAR").c - 14) / u2.g("ACHIEVEMENTS_DARK_BAR").c) : ((800 - u2.g("SCROLL_BAR").c - 14) / u2.g("ACHIEVEMENTS_LIGHT_BAR").c));
			cd3.be(da2);
			if (!item.IsEarned)
			{
				da da3 = new da();
				da3.i(u2.g("ACHIEVEMENT_NOT_ACQUIRED"));
				da3.af = 50f;
				da3.ah = num7;
				cd3.be(da3);
				cr cr2 = new cr();
				cr2.i(u2.e("TEXT_ACHIEVEMENT_LOCKED"));
				cr2.af = 715f;
				cr2.ah = num6 + 60;
				cr2.ad = new a7(bn.b, dh.b);
				cr2.i(u.a().a("FONT_WP7_LIVE.dat"));
				cr2.i(Color.Red);
				cd3.be(cr2);
				cr cr3 = new cr();
				cr3.i(item.Name);
				cr3.af = 130f;
				cr3.ah = num8;
				cr3.ad = new a7(bn.a, dh.b);
				cr3.i(Color.LightGray);
				cd3.be(cr3);
			}
			else
			{
				Texture2D val2 = Texture2D.FromStream(bu.a, item.GetPictureStream());
				ca ca2 = new ca(val2);
				ae a_ = ca2.b("ACHIEVEMENT", 0, 0, val2.Width, val2.Height, val2.Width / 2, val2.Height / 2);
				da da4 = new da();
				da4.i(a_);
				da4.af = 50f;
				da4.ah = num7;
				cd3.be(da4);
				num3++;
				num4 += gamerScore;
				cr cr4 = new cr();
				cr4.i(u2.e("TEXT_ACHIEVEMENT_ACQUIRED"));
				cr4.af = 715f;
				cr4.ah = num6 + 60;
				cr4.ad = new a7(bn.b, dh.b);
				cr4.i(u.a().a("FONT_WP7_LIVE.dat"));
				cd3.be(cr4);
				cr cr5 = new cr();
				cr5.i(item.Name);
				cr5.af = 130f;
				cr5.ah = num8;
				cr5.ad = new a7(bn.a, dh.b);
				cd3.be(cr5);
			}
			cr cr6 = new cr();
			cr6.i(item.IsEarned ? item.Description : item.HowToEarn);
			cr6.af = 130f;
			cr6.ah = num9;
			cr6.ad = new a7(bn.a, dh.b);
			cr6.i(u.a().a("FONT_WP7_LIVE.dat"));
			cr6.i(new Color(78, 196, 133, 255));
			cd3.be(cr6);
			if (!item.IsEarned)
			{
				cr cr7 = new cr();
				cr7.i(gamerScore.ToString());
				cr7.af = 715f;
				cr7.ah = num6 + 30;
				cr7.ad = new a7(bn.c, dh.b);
				cr7.i(Color.LightGray);
				cd3.be(cr7);
			}
			else
			{
				cr cr8 = new cr();
				cr8.i(gamerScore.ToString());
				cr8.af = 715f;
				cr8.ah = num6 + 30;
				cr8.ad = new a7(bn.c, dh.b);
				cd3.be(cr8);
			}
			da da5 = new da();
			da5.i(u2.g("GAMESCORE_ICON"));
			da5.af = 730f;
			da5.ah = num6 + 30;
			((ck)da5).al = false;
			cd3.be(da5);
			ao.be(cd3);
			num++;
		}
		ao.ag(new Vector2(ao.bk().X, (float)(num6 + num5)));
		if (ar != null)
		{
			an.bf(@as);
		}
		cd obj = an;
		cr cr9 = new cr();
		cr9.i("Y/20 ACHIEVED");
		cr9.af = 400f;
		cr9.ah = 45f;
		cr9.ad = new a7(bn.b);
		obj.be(@as = cr9);
		if (ar != null)
		{
			an.bf(ar);
		}
		cd obj2 = an;
		cr cr10 = new cr();
		cr10.i("X/200");
		cr10.af = 755f;
		cr10.ah = u2.g("ACHIEVEMENTS_TOP_BAR").d / 2;
		cr10.ad = new a7(bn.c, dh.b);
		obj2.be(ar = cr10);
		ar.i(num4 + "/" + num2);
		@as.i(num3 + "/20 " + u2.e("TEXT_ACHIEVEMENT_ACHIEVED"));
		if (e("blackLine") != null)
		{
			f("blackLine");
		}
		da da6 = new da();
		da6.i(u2.g("LEADERBOARD_VERTICAL_BORDER"));
		da6.af = 774f;
		da6.ah = 0f;
		da6.ai(20f);
		da6.ad = new a7(bn.a, dh.b);
		a("blackLine", da6, "__FIRST__");
		a("listContent", ao, "__FIRST__");
		at = false;
		base.SetMenuState(global::m.MenuState.a);
	}
}
