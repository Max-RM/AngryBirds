using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AngryBirds.Menus;
using Microsoft.Xna.Framework;

internal class bk : c
{
	private int ai;

	private string aj;

	private string al = "Level1";

	private da am;

	private bool an = true;

	[CompilerGenerated]
	private List<string> ao;

	[SpecialName]
	[CompilerGenerated]
	public List<string> au()
	{
		return ao;
	}

	[SpecialName]
	[CompilerGenerated]
	public void a(List<string> A_0)
	{
		ao = A_0;
	}

	public override void e()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		ai = 0;
		aj = null;
		a(new List<string>());
		p("tutorialPage");
		base.SetMenuState(global::m.MenuState.b);
		f(A_0: false);
		u u2 = u.a();
		base.SetLayout(new y());
		a3().an();
		a3().g(dc.j);
		for (int num = 0; num < dc.e.Length; num++)
		{
			string a_ = dc.e[num];
			da da2 = new da();
			da2.i(u2.g("TUTORIAL_" + (num + 1)));
			da2.af = 400f;
			da2.ah = 240f;
			da2.am = false;
			a(a_, da2);
		}
		da da3 = new da();
		da3.i(u2.g("TUTORIAL_OK"));
		da3.af = (int)(400.0 + (double)(130f * di.d().e()));
		da3.ah = (int)(240.0 + (double)(87f * di.d().g()));
		((ck)da3).al = true;
		da3.am = true;
		da3.y = c;
		p(da3);
		List<Vector2> list = global::p.a().a("tutorialGoldenEggPosition");
		da da4 = new da();
		da4.i(u2.g("GOLDEN_EGG_1"));
		da4.af = list[0].X * 0.65f;
		da4.ah = list[0].Y * 0.65f;
		da4.i(0.65f);
		da4.ai(0.65f);
		da4.ab = new r((int)list[1].X, (int)list[1].Y, (int)list[2].X, (int)list[2].Y);
		((ck)da4).al = false;
		da4.am = false;
		da4.y = a;
		p(am = da4);
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		PauseGamePage f2 = (PauseGamePage)n.e()["pauseGamePage"];
		f2.bf();
	}

	public override void f()
	{
		if (bc() == global::m.MenuState.a)
		{
			base.f();
		}
	}

	public override void h(GameTime A_0)
	{
		a(new List<string>(Enumerable.Distinct<string>((IEnumerable<string>)au())));
		ai = 0;
		aj = null;
		an = true;
		if (au().Count > 0)
		{
			for (int num = au().Count - 1; num >= 0; num--)
			{
				if (d.p().p(au()[num]))
				{
					au().Remove(au()[num]);
				}
			}
			an = au().Count == 0;
		}
		else
		{
			for (int num2 = 0; num2 < dc.e.Length; num2++)
			{
				if (d.p().p(dc.e[num2]))
				{
					au().Add(dc.e[num2]);
				}
			}
		}
		if (au().Count > 0)
		{
			aj = au()[ai];
			da da2 = (da)e(aj);
			da2.am = true;
			if (an && aj == "BIRD_GREEN" && d.p().s(al) == GoldenEggType.Locked)
			{
				am.am = true;
				((ck)am).al = true;
			}
			else
			{
				am.am = false;
				((ck)am).al = false;
			}
			base.SetMenuState(global::m.MenuState.a);
		}
		else
		{
			bf();
		}
	}

	public override void b(GameTime A_0)
	{
		da da2 = (da)e(aj);
		if (da2 != null)
		{
			da2.am = false;
		}
		ai = 0;
		aj = null;
		am.am = false;
		((ck)am).al = false;
		for (int num = au().Count - 1; num >= 0; num--)
		{
			d.p().u(au()[num]);
		}
		bw.d().f(a);
		au().Clear();
		base.SetMenuState(global::m.MenuState.b);
	}

	private void c(ck A_0)
	{
		da da2 = (da)e(aj);
		if (da2 != null)
		{
			da2.am = false;
		}
		ai++;
		if (au().Count > ai)
		{
			aj = au()[ai];
		}
		else
		{
			aj = null;
		}
		da2 = (da)e(aj);
		if (da2 != null && au().Contains(aj))
		{
			if (an && aj == "BIRD_GREEN" && d.p().s(al) == GoldenEggType.Locked)
			{
				am.am = true;
				((ck)am).al = true;
			}
			else
			{
				am.am = false;
				((ck)am).al = false;
			}
			da2.am = true;
		}
		else
		{
			bf();
		}
	}

	private void a(ck A_0)
	{
		am.am = false;
		((ck)am).al = false;
		a(al, A_1: false, A_2: true);
	}

	public override void c()
	{
		bf();
	}

	private void a(object A_0)
	{
	}
}
