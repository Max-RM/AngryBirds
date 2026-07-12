using System.Collections.Generic;
using System.Linq;
using AngryBirds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class @as : m
{
	public Game ah;

	private cf ai;

	private da aj;

	public bool ak = true;

	private bool al;

	private bool am;

	private bool an;

	private bool ao;

	private bool ap;

	public @as(Game A_0)
	{
		ah = A_0;
	}

	public override void e()
	{
		ai = new cf();
		ai.u(ah);
		da da2 = new da();
		da2.i(u.a().g("MENU_BUTTON"));
		da2.af = 0f;
		da2.ah = 0f;
		((ck)da2).al = true;
		aj = da2;
	}

	public override void f()
	{
		ai.@as();
		aj.i();
		if (k != null)
		{
			k.f();
		}
	}

	public override void h(GameTime A_0)
	{
		ak = true;
		ap = false;
		b0.d().k(A_0: true);
		base.SetMenuState(global::m.MenuState.a);
	}

	public override void a()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		Controls instance = Controls.GetInstance();
		if (instance.IsBackPressed)
		{
			aw();
		}
		else
		{
			if (ai.aa())
			{
				return;
			}
			for (int num = 0; num < instance.Touches.Count; num++)
			{
				TouchLocation val = instance.Touches[num];
				if ((int)val.State == 2)
				{
					da obj = aj;
					TouchLocation val2 = instance.Touches[num];
					if (obj.Hit(val2.Position))
					{
						aw();
						break;
					}
				}
			}
		}
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		if (ak)
		{
			if (ai.aw() == cf.b.b)
			{
				a8().f(A_0: true);
				o();
				p();
				ai.a4();
				ai.u(cf.b.c);
			}
			else if (ai.aw() == cf.b.c)
			{
				ai.u(cf.b.f);
			}
			else if (ai.aw() == cf.b.d)
			{
				a8().f(A_0: true);
				ai.u(cf.b.e);
			}
			else if (ai.aw() == cf.b.e)
			{
				ai.a4();
				ai.u(cf.b.f);
			}
			else if (ai.aw() == cf.b.f)
			{
				ai.ab();
				al = bo.a().d(ai.am());
				am = bo.a().g(ai.bb());
				string a_ = di.d().e(ai.am());
				an = bo.a().f(a_);
				ao = bo.a().c(a_);
				ai.w(A_0: true);
				ai.u(cf.b.g);
			}
			else if (ai.aw() == cf.b.g)
			{
				a8().f(A_0: false);
				bk bk2 = (bk)n.e()["tutorialPage"];
				bk2.a(new List<string>(Enumerable.Distinct<string>((IEnumerable<string>)ai.a9())));
				ai.a9().Clear();
				c(bk2);
				ak = false;
				ai.u(cf.b.j);
			}
			else if (ai.aw() == cf.b.h)
			{
				a(ai.am(), A_1: true, A_2: false);
				ak = false;
				ai.u(cf.b.k);
			}
			else if (ai.aw() == cf.b.i)
			{
				a(ai.a2(), A_1: false, A_2: true);
				ak = false;
				ai.u(cf.b.j);
			}
			else if (!ai.ai())
			{
				ai.u(A_0);
			}
			else if (ai.aw() == cf.b.k)
			{
				int num = di.d().o(ai.bb()) + 1;
				string a_2 = di.d().e(ai.am());
				bool flag = bo.a().a(ai.bb());
				bo.a().g(ai.bb());
				bool flag2 = bo.a().f(a_2);
				bool flag3 = bo.a().c(a_2);
				string text = Enumerable.Last<string>((IEnumerable<string>)di.d().f(ai.bb()).b);
				bool flag4 = text.Equals(ai.am());
				bw.d().f(a);
				if (!ap && ((!an && flag2) || (!ao && flag3)))
				{
					bq bq2 = (bq)n.e()["episodeCompletedPage"];
					bq2.a(flag3);
					bq2.a(ai.bb());
					bq2.aw();
					c(bq2);
					ap = true;
					ak = false;
					ai.w(A_0: false);
					return;
				}
				an an2 = (an)n.e()["levelCompletedPage"];
				an2.c((string)null);
				an2.a(ai.am());
				an2.c(ai.be());
				an2.e(ai.at().d());
				an2.c(ai.a);
				an2.a(au);
				an2.c(av);
				an2.a(!ap);
				if (flag4 && flag)
				{
					switch (num)
					{
					case 1:
						_ = (cm)a9().e()["CutSceneTheme1Complete"];
						an2.e(al);
						an2.c("CutSceneTheme1Complete");
						break;
					case 2:
						_ = (cm)a9().e()["CutSceneTheme2Complete"];
						an2.e(al);
						an2.c("CutSceneTheme2Complete");
						break;
					case 3:
						_ = (cm)a9().e()["CutSceneGameComplete"];
						an2.e(al);
						an2.c("CutSceneGameComplete");
						break;
					case 4:
						_ = (cm)a9().e()["CutSceneTheme4Complete"];
						an2.e(al);
						an2.c("CutSceneTheme4Complete");
						break;
					case 5:
						_ = (cm)a9().e()["CutSceneTheme5Complete"];
						an2.e(al);
						an2.c("CutSceneTheme5Complete");
						break;
					case 6:
						_ = (cm)a9().e()["CutSceneTheme6Complete"];
						an2.e(al);
						an2.c("CutSceneTheme6Complete");
						break;
					case 7:
						_ = (cm)a9().e()["CutSceneTheme7Complete"];
						an2.e(al);
						an2.c("CutSceneTheme7Complete");
						break;
					case 8:
						_ = (cm)a9().e()["CutSceneTheme8Complete"];
						an2.e(al);
						an2.c("CutSceneTheme8Complete");
						break;
					case 9:
						_ = (cm)a9().e()["CutSceneTheme9Complete"];
						an2.e(al);
						an2.c("CutSceneTheme9Complete");
						break;
					case 10:
						_ = (cm)a9().e()["CutSceneTheme10Complete"];
						an2.e(al);
						an2.c("CutSceneTheme10Complete");
						break;
					case 11:
						_ = (cm)a9().e()["CutSceneTheme11Complete"];
						an2.e(al);
						an2.c("CutSceneTheme11Complete");
						break;
					case 12:
						_ = (cm)a9().e()["CutSceneTheme12Complete"];
						an2.e(al);
						an2.c("CutSceneTheme12Complete");
						break;
					case 13:
						_ = (cm)a9().e()["CutSceneTheme13Complete"];
						an2.e(al);
						an2.c("CutSceneTheme13Complete");
						break;
					case 14:
						_ = (cm)a9().e()["CutSceneTheme14Complete"];
						an2.e(al);
						an2.c("CutSceneTheme14Complete");
						break;
					}
				}
				ak = false;
				ai.w(A_0: false);
				ai.ax();
				ai.u(cf.b.m);
				c(an2);
			}
			else
			{
				if (ai.aw() != cf.b.l)
				{
					return;
				}
				int num2 = di.d().o(ai.bb()) + 1;
				bool flag5 = bo.a().a(ai.bb());
				string text2 = Enumerable.Last<string>((IEnumerable<string>)di.d().f(ai.bb()).b);
				bool flag6 = text2.Equals(ai.am());
				bw.d().f(a);
				bp bp2 = (bp)n.e()["levelFailedPage"];
				bp2.c((string)null);
				bp2.a(ai.am());
				bp2.a(ai.be());
				bp2.a(au);
				bp2.c(av);
				if (flag6 && flag5)
				{
					switch (num2)
					{
					case 1:
					{
						cm cm15 = (cm)a9().e()["CutSceneTheme1Complete"];
						cm15.@as = false;
						bp2.c("CutSceneTheme1Complete");
						break;
					}
					case 2:
					{
						cm cm14 = (cm)a9().e()["CutSceneTheme2Complete"];
						cm14.@as = false;
						bp2.c("CutSceneTheme2Complete");
						break;
					}
					case 3:
					{
						cm cm13 = (cm)a9().e()["CutSceneGameComplete"];
						cm13.@as = false;
						bp2.c("CutSceneGameComplete");
						break;
					}
					case 4:
					{
						cm cm12 = (cm)a9().e()["CutSceneTheme4Complete"];
						cm12.@as = false;
						bp2.c("CutSceneTheme4Complete");
						break;
					}
					case 5:
					{
						cm cm11 = (cm)a9().e()["CutSceneTheme5Complete"];
						cm11.@as = false;
						bp2.c("CutSceneTheme5Complete");
						break;
					}
					case 6:
					{
						cm cm10 = (cm)a9().e()["CutSceneTheme6Complete"];
						cm10.@as = false;
						bp2.c("CutSceneTheme6Complete");
						break;
					}
					case 7:
					{
						cm cm9 = (cm)a9().e()["CutSceneTheme7Complete"];
						cm9.@as = false;
						bp2.c("CutSceneTheme7Complete");
						break;
					}
					case 8:
					{
						cm cm8 = (cm)a9().e()["CutSceneTheme8Complete"];
						cm8.@as = false;
						bp2.c("CutSceneTheme8Complete");
						break;
					}
					case 9:
					{
						cm cm7 = (cm)a9().e()["CutSceneTheme9Complete"];
						cm7.@as = false;
						bp2.c("CutSceneTheme9Complete");
						break;
					}
					case 10:
					{
						cm cm6 = (cm)a9().e()["CutSceneTheme10Complete"];
						cm6.@as = false;
						bp2.c("CutSceneTheme10Complete");
						break;
					}
					case 11:
					{
						cm cm5 = (cm)a9().e()["CutSceneTheme11Complete"];
						cm5.@as = false;
						bp2.c("CutSceneTheme11Complete");
						break;
					}
					case 12:
					{
						cm cm4 = (cm)a9().e()["CutSceneTheme12Complete"];
						cm4.@as = false;
						bp2.c("CutSceneTheme12Complete");
						break;
					}
					case 13:
					{
						cm cm3 = (cm)a9().e()["CutSceneTheme13Complete"];
						cm3.@as = false;
						bp2.c("CutSceneTheme13Complete");
						break;
					}
					case 14:
					{
						cm cm2 = (cm)a9().e()["CutSceneTheme14Complete"];
						cm2.@as = false;
						bp2.c("CutSceneTheme14Complete");
						break;
					}
					}
				}
				ak = false;
				ai.w(A_0: false);
				ai.ax();
				ai.u(cf.b.m);
				c(bp2);
			}
		}
		else if (ai.aw() == cf.b.m)
		{
			ak = false;
		}
		else
		{
			ak = a8().ba() || k == null;
		}
	}

	public void a(string A_0, string A_1, bool A_2)
	{
		PauseGamePage f2 = (PauseGamePage)n.e()["pauseGamePage"];
		f2.c(A_1);
		f2.a(A_0);
		a8 a10 = di.d().r(A_1);
		di.d().k(a10.a);
		if (!A_2)
		{
			ai.v(A_0, A_1);
		}
	}

	public void av()
	{
		string text = di.d().l(ai.am());
		if (text == null)
		{
			n.c("mainMenu");
		}
		else
		{
			a8 a10 = di.d().r(text);
			PauseGamePage f2 = (PauseGamePage)n.e()["pauseGamePage"];
			f2.c(text);
			f2.a(a10.a);
			ai.v(a10.a, text);
		}
		bb();
	}

	public void au()
	{
		bb();
		ai.au();
	}

	public void aw()
	{
		ai.ax();
		PauseGamePage f2 = (PauseGamePage)n.e()["pauseGamePage"];
		if (be() == null)
		{
			f2.u = ai;
			c(n.e()["pauseGamePage"]);
		}
		ai.aq();
		ak = false;
	}

	public override void o()
	{
		if (ai.a3() != null)
		{
			ai.a3().f();
			a1.f();
			a1.b();
		}
	}

	public override void p()
	{
		a2 a_ = ai.ae().f();
		a1.g();
		a1.a(ai.ae().f(a_));
	}

	private void a(object A_0)
	{
	}
}
