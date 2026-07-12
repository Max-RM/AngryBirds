using System;
using System.Collections.Generic;
using System.Linq;
using AngryBirds.Menus;
using Microsoft.Xna.Framework;

internal class a4 : z
{
	private Dictionary<string, da> ai;

	private Dictionary<string, da> aj;

	private Dictionary<string, da> al;

	private List<de> am;

	private cd an;

	private cd ao;

	private ck ap;

	private int aq;

	public a4()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		a(new List<Color>
		{
			new Color(238, 176, 66),
			new Color(238, 176, 66)
		});
	}

	public override void e()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		au("episodeSelectionPage");
		u u2 = u.a();
		p("goldenEggs");
		SetMenuState(global::m.MenuState.a);
		a3().g(a2()[0]);
		a(2, A_1: true);
		an = (cd)a1().bw()[0];
		ao = (cd)a1().bw()[1];
		ai = new Dictionary<string, da>();
		aj = new Dictionary<string, da>();
		al = new Dictionary<string, da>();
		am = new List<de>();
		List<Vector2> list = global::p.a().a("goldenEggPositions");
		for (int num = 0; num < dc.g.Length; num++)
		{
			string a_ = dc.g[num];
			string text = null;
			string key = "Level" + (num + 1);
			int num2 = (int)(list[num].X * 800f);
			int num3 = (int)(list[num].Y * 480f);
			if (num < dc.f.Length)
			{
				text = dc.f[num];
				cd obj = an;
				da da2 = new da();
				da2.ae = num;
				da2.i(u2.g(text));
				da2.af = num2;
				da2.ah = num3;
				da2.am = true;
				((ck)da2).al = true;
				da2.y = c;
				da2.aa = u2.f("menu_confirm");
				obj.be(da2);
			}
			da da3 = new da();
			da3.i(u2.g("GOLDEN_EGG_STAR_EFFECT"));
			da3.af = num2;
			da3.ah = num3;
			da3.ag(0f);
			da3.am = false;
			da da4 = da3;
			ai.Add(key, da4);
			an.be(da4);
			da da5 = new da();
			da5.ae = num;
			da5.i(u2.g(a_));
			da5.af = num2;
			da5.ah = num3;
			da5.am = false;
			((ck)da5).al = false;
			da5.y = c;
			da5.aa = u2.f("menu_confirm");
			da da6 = da5;
			al.Add(key, da6);
			an.be(da6);
			if (num == 21)
			{
				da da7 = new da();
				da7.i(u2.g("EGG_SUPER_BOWL_STAR"));
				da7.af = num2;
				da7.ah = num3;
				da7.am = false;
				da da8 = da7;
				aj.Add(key, da8);
				an.be(da8);
			}
			else
			{
				da da9 = new da();
				da9.i(u2.g("GOLDEN_EGG_CARVED_STAR"));
				da9.af = num2;
				da9.ah = num3;
				da9.am = false;
				da da10 = da9;
				aj.Add(key, da10);
				an.be(da10);
			}
			de de2 = new de(num);
			de2.SetMenuManager(a9());
			de2.e();
			am.Add(de2);
			e(de2);
		}
		da da11 = new da();
		da11.i(u2.g("GOLDEN_EGG_PUZZLED_BIRD"));
		da11.af = 800f;
		da11.ah = 480f;
		da11.am = true;
		p(da11);
		da da12 = new da();
		da12.i(u2.g("LS_BACK_BUTTON"));
		da12.af = 0f;
		da12.ah = 480f;
		da12.am = true;
		((ck)da12).al = true;
		da12.y = a9().c;
		da12.z = "episodeSelectionPage";
		da12.aa = u2.f("menu_back");
		da12.ab = new r(0, 405, 85, 480);
		p(da12);
	}

	public override void f()
	{
		base.f();
		aq--;
	}

	public override void h(GameTime A_0)
	{
		s.a().a("title_theme");
		bool flag = false;
		for (int num = 0; num < al.Count; num++)
		{
			string text = Enumerable.ElementAt<string>((IEnumerable<string>)al.Keys, num);
			GoldenEggType goldenEggType = d.p().s(text);
			if (num > 14 && goldenEggType != GoldenEggType.Locked)
			{
				flag = true;
			}
			switch (goldenEggType)
			{
			case GoldenEggType.Locked:
				ai[text].am = false;
				al[text].am = false;
				aj[text].am = false;
				((ck)al[text]).al = false;
				break;
			case GoldenEggType.Achieved:
				ai[text].am = true;
				al[text].am = true;
				aj[text].am = false;
				((ck)al[text]).al = true;
				break;
			case GoldenEggType.Visited:
				ai[text].am = false;
				al[text].am = true;
				aj[text].am = false;
				((ck)al[text]).al = true;
				break;
			case GoldenEggType.Completed:
				ai[text].am = false;
				al[text].am = true;
				aj[text].am = true;
				((ck)al[text]).al = true;
				break;
			}
		}
		if (a1().bw().Count == 2)
		{
			a1().bf(an);
			a1().bf(ao);
		}
		else
		{
			a1().bf(an);
		}
		if (flag)
		{
			a(2, A_1: false);
			a1().am(a1().bw()[0], an);
			a1().am(a1().bw()[1], ao);
		}
		else
		{
			a(1, A_1: false);
			a1().am(a1().bw()[0], an);
		}
		int index = d.p().y()["goldenEggs"] - 1;
		a1().ag(a1().bw()[index]);
		string a_ = null;
		bool flag2 = false;
		if (bo.a().c("episode1"))
		{
			a_ = "Level4";
			if (d.p().s(a_) == GoldenEggType.Locked)
			{
				d.p().p(a_, GoldenEggType.Achieved);
				flag2 = true;
			}
		}
		if (bo.a().c("episode2"))
		{
			a_ = "Level7";
			if (d.p().s(a_) == GoldenEggType.Locked)
			{
				d.p().p(a_, GoldenEggType.Achieved);
				flag2 = true;
			}
		}
		if (bo.a().c("episode3"))
		{
			a_ = "Level12";
			if (d.p().s(a_) == GoldenEggType.Locked)
			{
				d.p().p(a_, GoldenEggType.Achieved);
				flag2 = true;
			}
		}
		if (bo.a().c("episode4"))
		{
			a_ = "Level17";
			if (d.p().s(a_) == GoldenEggType.Locked)
			{
				d.p().p(a_, GoldenEggType.Achieved);
				flag2 = true;
			}
		}
		if (bo.a().c("episode5"))
		{
			a_ = "Level21";
			if (d.p().s(a_) == GoldenEggType.Locked)
			{
				d.p().p(a_, GoldenEggType.Achieved);
				flag2 = true;
			}
		}
		if (flag2)
		{
			a(a_, A_1: false, A_2: true);
			SetMenuState(global::m.MenuState.c);
		}
		else
		{
			SetMenuState(global::m.MenuState.a);
		}
	}

	public override void b(GameTime A_0)
	{
		d.p().y()["goldenEggs"] = a1().bh() + 1;
		ap = null;
		aq = 0;
		SetMenuState(global::m.MenuState.b);
	}

	public override void g(GameTime A_0)
	{
		if (aq == 1)
		{
			a8().f(A_0: true);
			return;
		}
		if (aq == 0 && ap != null)
		{
			a(ap);
			return;
		}
		float num = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		foreach (da value in ai.Values)
		{
			value.ag(value.bg() + num * ((float)Math.PI / 2f));
			if (value.bg() > (float)Math.PI * 2f)
			{
				value.ag(value.bg() - (float)Math.PI * 2f);
			}
		}
		base.g(A_0);
	}

	private void c(ck A_0)
	{
		string a_ = Enumerable.ElementAt<string>((IEnumerable<string>)al.Keys, A_0.ae);
		GoldenEggType goldenEggType = d.p().s(a_);
		if (goldenEggType == GoldenEggType.Locked)
		{
			a(A_0);
			return;
		}
		aq = 2;
		ap = A_0;
	}

	private void a(ck A_0)
	{
		int num = A_0.ae;
		string a_ = "Level" + (num + 1);
		if (A_0.aa != null)
		{
			A_0.aa.ac();
		}
		if (d.p().s(a_) == GoldenEggType.Locked)
		{
			c(am[num]);
		}
		else
		{
			a8().f(A_0: true);
			b0.d().k(A_0: true);
			switch (num)
			{
			case 3:
				n.c("goldenEggSoundBoardPage");
				break;
			case 6:
				n.c("goldenEggRadioPage");
				break;
			case 11:
				n.c("goldenEggKeyboardPage");
				break;
			case 16:
				n.c("goldenEggSequencerPage");
				break;
			case 20:
				n.c("goldenEggAccordionPage");
				break;
			default:
			{
				@as as2 = (@as)a9().e()["gameplayPage"];
				as2.a("goldeneggs1", dc.i[num], A_2: false);
				n.c("gameplayPage");
				break;
			}
			}
			if (d.p().s(a_) != GoldenEggType.Completed)
			{
				d.p().p(a_, GoldenEggType.Visited);
			}
		}
		ap = null;
	}
}
