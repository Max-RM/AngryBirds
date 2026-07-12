using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.GamerServices;

internal class b3 : c
{
	public new enum B3Mode
	{
		a
	}

	private Color ar;

	private int @as = 10;

	private int at;

	private new int au;

	private new int av;

	private cd aw;

	private cd ax;

	private c9 ay;

	private da az;

	private cd a0;

	private cd a1;

	private cd a2;

	private new da a3;

	private new da a4;

	private new cr a5;

	private new bool a6;

	private new B3Mode a7;

	private new bool a8;

	public b3(B3Mode A_0)
	{
		a7 = A_0;
	}

	public override void e()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		u u2 = u.a();
		p("leaderboardPage");
		base.SetMenuState(global::m.MenuState.b);
		ar = new Color(45, 150, 127);
		at = u2.g("LEADERBOARD_TOP_BAR").d - 15;
		au = 480 - u2.g("LEADERBOARD_BOTTOM_BAR").d;
		aw = new cd
		{
			al = true
		};
		cd obj = aw;
		da da2 = new da();
		da2.i(u2.g("LEADERBOARD_TOP_BAR"));
		da2.af = 0f;
		da2.ah = 0f;
		((ck)da2).al = false;
		da2.i(800 / u2.g("LEADERBOARD_TOP_BAR").c);
		obj.be(da2);
		a2 = new cd();
		a2.af = 0f;
		((ck)a2).ah = u2.g("LEADERBOARD_TOP_BAR").d - u2.g("LEADERBOARD_OWN_SCORE").d - 17;
		aw.be(a2);
		cd obj2 = aw;
		cr cr2 = new cr();
		cr2.i(u2.e("TEXT_LEADERBOARD"));
		cr2.af = 400f;
		cr2.ah = 10f;
		cr2.ad = new a7(bn.b);
		obj2.be(a5 = cr2);
		cd obj3 = aw;
		da da3 = new da();
		da3.i(u2.g("ARROW_LEFT"));
		da3.af = u2.g("ARROW_LEFT").c / 2;
		da3.ah = u2.g("ARROW_LEFT").d / 2;
		da3.y = a9().c;
		da3.z = "mainMenu";
		((ck)da3).al = true;
		da3.aa = u2.f("menu_back");
		obj3.be(az = da3);
		ax = new cd
		{
			al = true
		};
		cd obj4 = ax;
		da da4 = new da();
		da4.i(u2.g("LEADERBOARD_BOTTOM_BAR"));
		da4.af = 0f;
		da4.ah = 480f;
		((ck)da4).al = false;
		da4.i(800 / u2.g("LEADERBOARD_BOTTOM_BAR").c);
		obj4.be(a4 = da4);
		a0 = new cd();
		((ck)a0).am = false;
		((ck)a0).al = false;
		a0.af = 400 - u2.g("BUTTON_YELLOW_BASE").c / 2 - 50;
		((ck)a0).ah = 480 - u2.g("LEADERBOARD_BOTTOM_BAR").d / 2;
		cd obj5 = a0;
		da da5 = new da();
		da5.i(u2.g("BUTTON_YELLOW_BASE"));
		da5.af = a0.af;
		da5.ah = ((ck)a0).ah;
		da5.y = a;
		obj5.be(da5);
		cd obj6 = a0;
		da da6 = new da();
		da6.i(u2.i("TEXT_ACHIEVEMENTS_PREV"));
		da6.af = a0.af;
		da6.ah = ((ck)a0).ah;
		da6.ad = new a7(bn.b, dh.b);
		obj6.be(da6);
		a1 = new cd();
		((ck)a1).am = false;
		((ck)a1).al = false;
		a1.af = 400 + u2.g("BUTTON_YELLOW_BASE").c / 2 + 50;
		((ck)a1).ah = 480 - u2.g("LEADERBOARD_BOTTOM_BAR").d / 2;
		cd obj7 = a1;
		da da7 = new da();
		da7.i(u2.g("BUTTON_YELLOW_BASE"));
		da7.af = a1.af;
		da7.ah = ((ck)a1).ah;
		da7.y = c;
		obj7.be(da7);
		cd obj8 = a1;
		da da8 = new da();
		da8.i(u2.i("TEXT_ACHIEVEMENTS_NEXT"));
		da8.af = a1.af;
		da8.ah = ((ck)a1).ah;
		da8.ad = new a7(bn.b, dh.b);
		da8.y = c;
		obj8.be(da8);
		da da9 = new da();
		da9.i(u2.g("SCROLL_BAR"));
		da9.af = 800 - u2.g("SCROLL_BAR").c;
		da9.ah = at + u2.g("SCROLL_BAR").d / 2;
		da9.am = false;
		p(a3 = da9);
		ax.be(a0);
		ax.be(a1);
		p(aw);
	}

	public override void f()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		bu bu2 = bu.b();
		bu2.b(ar);
		bu2.b(0f, 0f, 800f, 480f);
		bu2.b(Color.White);
		base.f();
	}

	public override void h(GameTime A_0)
	{
		a8 = false;
		if (a6)
		{
			return;
		}
		c9 c10 = new c9();
		c10.i(A_0: true);
		c10.ag(A_0: false);
		c10.ai(A_0: false);
		c10.bg(A_0: true);
		ay = c10;
		((ck)ay).ak = 0f;
		av = 0;
		if (a7 == b3.B3Mode.a)
		{
			if (dc.IsTrial())
			{
				bw.d().d(0, 100, a);
			}
			else
			{
				bw.d().d(0, (long)bo.a().e(), (c2.LiveCallback)c);
			}
		}
		a6 = true;
		a8().f(A_0: true);
	}

	public override void b(GameTime A_0)
	{
		a8().f(A_0: false);
		if (e("listContent") != null)
		{
			f("listContent");
		}
		if (a2 != null)
		{
			a2.bv();
		}
		a3.am = false;
		a3.ah = at + u.a().g("SCROLL_BAR").d / 2;
		a6 = false;
		base.SetMenuState(global::m.MenuState.b);
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		_ = A_0.ElapsedGameTime.Milliseconds;
		if (bc() == global::m.MenuState.a)
		{
			if (((ck)ay).al)
			{
				ay.bs();
				float num = 480 - at;
				float num2 = (0f - ((ck)ay).ak) / ((float)av - num);
				a3.ai(num / (float)a3.bf().d * (480f / (float)av));
				if (a3.bh() > num / (float)a3.bf().d)
				{
					a3.ai(num / (float)a3.bf().d);
				}
				if (a3.bh() < 0.5f)
				{
					a3.ai(0.5f);
				}
				a3.ah = (float)at + (float)a3.bf().d * a3.bh() / 2f + (num - (float)a3.bf().d * a3.bh()) * num2;
			}
			ay.d(A_0);
		}
		if (a8)
		{
			a9().c("mainMenu");
			a8 = false;
		}
	}

	private void c(ck A_0)
	{
		if (bw.d().g())
		{
			if (e("listContent") != null)
			{
				f("listContent");
			}
			bw.d().i(a);
		}
	}

	private void a(ck A_0)
	{
		if (bw.d().h())
		{
			if (e("listContent") != null)
			{
				f("listContent");
			}
			bw.d().d((c2.LiveCallback)a);
		}
	}

	private void c(object A_0)
	{
		if (a7 == b3.B3Mode.a)
		{
			bw.d().d(0, 100, a);
		}
	}

	private void a(object A_0)
	{
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		u u2 = u.a();
		Gamer val = (Gamer)(object)Gamer.SignedInGamers[(PlayerIndex)0];
		LeaderboardReader val2 = (LeaderboardReader)((A_0 is LeaderboardReader) ? A_0 : null);
		if (val2 == null)
		{
			bw.LiveState liveState = bw.d().e();
			if (liveState == bw.LiveState.UpdateRequired)
			{
				a((IAsyncResult)null);
			}
			else
			{
				List<string> list = new List<string>();
				list.Add(u2.e("SK_OK"));
				if (!Guide.IsVisible)
				{
					Guide.BeginShowMessageBox(u.a().e("TEXT_ERROR_TITLE"), u.a().e("TEXT_NO_CONNECTION_LEADERBOARDS"), (IEnumerable<string>)list, 0, (MessageBoxIcon)3, (AsyncCallback)a, (object)null);
				}
			}
			a6 = false;
			base.SetMenuState(global::m.MenuState.a);
			return;
		}
		a8().f(A_0: false);
		((ck)a1).am = val2.CanPageDown;
		((ck)a1).al = val2.CanPageDown;
		((ck)a0).am = val2.CanPageUp;
		((ck)a0).al = val2.CanPageUp;
		a3.am = val2.Entries.Count > @as;
		int num = 0;
		for (int num2 = 0; num2 < val2.Entries.Count; num2++)
		{
			num++;
			int num3 = val2.PageStart + 1 + num2;
			int num4 = u2.g("LEADERBOARD_DARK_BAR").d;
			int num5 = at + num2 * num4;
			int num6 = num5 + num4 / 2;
			av += num4;
			if (val != null && val2.Entries[num2].Gamer.Gamertag == val.Gamertag)
			{
				cd obj = a2;
				da da2 = new da();
				da2.i(u2.g("LEADERBOARD_OWN_SCORE"));
				da2.af = a2.af;
				da2.ah = ((ck)a2).ah;
				((ck)da2).al = false;
				da2.i(800 / u2.g("LEADERBOARD_TOP_BAR").c);
				obj.be(da2);
				cd obj2 = a2;
				cr cr2 = new cr();
				cr2.i(num3 + ".");
				cr2.af = a2.af + 30f;
				cr2.ah = ((ck)a2).ah + (float)(num4 / 2);
				cr2.ad = new a7(bn.b, dh.b);
				obj2.be(cr2);
				cd obj3 = a2;
				cr cr3 = new cr();
				cr3.i(val2.Entries[num2].Gamer.Gamertag);
				cr3.af = a2.af + 90f;
				cr3.ah = ((ck)a2).ah + (float)(num4 / 2);
				cr3.ad = new a7(bn.a, dh.b);
				obj3.be(cr3);
				StringBuilder stringBuilder = new StringBuilder(val2.Entries[num2].Rating.ToString());
				double num7 = Math.Floor((double)stringBuilder.Length / 3.0);
				if (num7 > 0.0)
				{
					int num8 = 0;
					for (int num9 = 1; (double)num9 <= num7; num9++)
					{
						stringBuilder.Insert(stringBuilder.Length - (num9 * 3 + num8), " ");
						num8++;
					}
				}
				cd obj4 = a2;
				cr cr4 = new cr();
				cr4.i(stringBuilder.ToString());
				cr4.af = a2.af + 770f;
				cr4.ah = ((ck)a2).ah + (float)(num4 / 2);
				cr4.ad = new a7(bn.c, dh.b);
				obj4.be(cr4);
				cd obj5 = a2;
				da da3 = new da();
				da3.i(u2.g("LEADERBOARD_VERTICAL_BORDER"));
				da3.af = 60f;
				da3.ah = ((ck)a2).ah;
				da3.ad = new a7(bn.b, dh.b);
				obj5.be(da3);
			}
			ae ae2 = null;
			float num10 = 1f;
			if (val != null && val2.Entries[num2].Gamer.Gamertag == val.Gamertag)
			{
				ae2 = u2.g("LEADERBOARD_HIGHLIGHT_BAR");
				num10 = (800 - u2.g("SCROLL_BAR").c - 14) / u2.g("LEADERBOARD_HIGHLIGHT_BAR").c;
			}
			else
			{
				ae2 = ((num2 % 2 == 0) ? u2.g("LEADERBOARD_DARK_BAR") : u2.g("LEADERBOARD_LIGHT_BAR"));
				num10 = ((num2 % 2 == 0) ? ((800 - u2.g("SCROLL_BAR").c - 14) / u2.g("ACHIEVEMENTS_DARK_BAR").c) : ((800 - u2.g("SCROLL_BAR").c - 14) / u2.g("LEADERBOARD_LIGHT_BAR").c));
			}
			c9 obj6 = ay;
			da da4 = new da();
			da4.i(ae2);
			da4.af = 0f;
			da4.ah = num5;
			da4.i(num10);
			obj6.be(da4);
			c9 obj7 = ay;
			da da5 = new da();
			da5.i(u2.g("LEADERBOARD_VERTICAL_BORDER"));
			da5.af = 60f;
			da5.ah = num5;
			da5.ad = new a7(bn.b, dh.b);
			obj7.be(da5);
			c9 obj8 = ay;
			cr cr5 = new cr();
			cr5.i(num3 + ".");
			cr5.af = 30f;
			cr5.ah = num6;
			cr5.ad = new a7(bn.b, dh.b);
			obj8.be(cr5);
			c9 obj9 = ay;
			cr cr6 = new cr();
			cr6.i(val2.Entries[num2].Gamer.Gamertag);
			cr6.af = 90f;
			cr6.ah = num6;
			cr6.ad = new a7(bn.a, dh.b);
			obj9.be(cr6);
			ay.ag(new Vector2(ay.bk().X, (float)(num5 + num4)));
			StringBuilder stringBuilder2 = new StringBuilder(val2.Entries[num2].Rating.ToString());
			double num11 = Math.Floor((double)stringBuilder2.Length / 3.0);
			if (num11 > 0.0)
			{
				int num12 = 0;
				for (int num13 = 1; (double)num13 <= num11; num13++)
				{
					stringBuilder2.Insert(stringBuilder2.Length - (num13 * 3 + num12), " ");
					num12++;
				}
			}
			c9 obj10 = ay;
			cr cr7 = new cr();
			cr7.i(stringBuilder2.ToString());
			cr7.af = 770f;
			cr7.ah = num6;
			cr7.ad = new a7(bn.c, dh.b);
			obj10.be(cr7);
		}
		da da6 = new da();
		da6.i(u2.g("LEADERBOARD_VERTICAL_BORDER"));
		da6.af = 774f;
		da6.ah = 0f;
		da6.ai(20f);
		da6.ad = new a7(bn.a, dh.b);
		a("blackLine", da6, "__FIRST__");
		a("listContent", ay, "__FIRST__");
		a6 = false;
		base.SetMenuState(global::m.MenuState.a);
	}

	protected void a(IAsyncResult A_0)
	{
		a8 = true;
	}
}
