using System;
using System.Collections.Generic;
using AngryBirds;
using AngryBirds.Menus;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class bj : c
{
	private List<Vector2> ai;

	private da aj;

	private da al;

	private da am;

	private da an;

	private da ao;

	private r ap;

	private r aq;

	private bool ar;

	private bool @as;

	private string at;

	private new float au;

	private new float av;

	public bj()
	{
		ar = true;
		@as = false;
		at = "Level6";
		au = 0f;
	}

	public override void e()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		p("goldenEggPiggyPage");
		SetMenuState(global::m.MenuState.a);
		au("goldenEggs");
		u u2 = u.a();
		ai = global::p.a().a("piggyPagePositions");
		SetLayout(new y());
		a3().an();
		a3().g(u2.g("CONCEPT_ART_BG"));
		da da2 = new da();
		da2.i(u2.g("CONCEPT_PIG_BODY"));
		p(da2);
		da da3 = new da();
		da3.i(u2.g("CONCEPT_PIG_BIRD"));
		p(da3);
		ap = new r((int)ai[0].X - (int)ai[3].X, (int)ai[0].Y - (int)ai[3].X, (int)ai[0].X + (int)ai[3].X, (int)ai[0].Y + (int)ai[3].X);
		aq = new r((int)ai[1].X - (int)ai[3].X, (int)ai[1].Y - (int)ai[3].X, (int)ai[1].X + (int)ai[3].X, (int)ai[1].Y + (int)ai[3].X);
		da da4 = new da();
		da4.i(u2.g("GOLDEN_EGG_STAR_EFFECT"));
		da4.af = (int)ai[4].X;
		da4.ah = (int)ai[4].Y;
		da4.am = false;
		am = da4;
		p(am);
		da da5 = new da();
		da5.i(u2.g("GOLDEN_EGG_STAR"));
		da5.af = (int)ai[4].X;
		da5.ah = (int)ai[4].Y;
		da5.am = false;
		an = da5;
		p(an);
		da da6 = new da();
		da6.i(u2.g("GOLDEN_EGG_STAR_COLLECTED"));
		da6.af = (int)ai[4].X;
		da6.ah = (int)ai[4].Y;
		da6.am = false;
		ao = da6;
		p(ao);
		da da7 = new da();
		da7.i(u2.g("CONCEPT_PIG_EYES_OPEN"));
		da7.am = false;
		al = da7;
		p(al);
		da da8 = new da();
		da8.i(u2.g("CONCEPT_PIG_NOSE"));
		((ck)da8).al = true;
		da8.ab = new r((int)ai[2].X - (int)ai[3].X, (int)ai[2].Y - (int)ai[3].X, (int)ai[2].X + (int)ai[3].X, (int)ai[2].Y + (int)ai[3].X);
		da8.y = a;
		aj = da8;
		p(aj);
		da da9 = new da();
		da9.i(u2.g("LS_BACK_BUTTON"));
		da9.af = 0f;
		da9.ah = 480f;
		da9.am = true;
		((ck)da9).al = true;
		da9.y = a9().c;
		da9.z = "goldenEggs";
		da9.aa = u2.f("menu_back");
		p(da9);
	}

	public override void h(GameTime A_0)
	{
		a8().f(A_0: false);
		ao.am = false;
		am.am = false;
		an.am = false;
		((ck)an).al = false;
		@as = false;
		ar = true;
		av = 0f;
		al.am = false;
		aj.ah = 0f;
		au = 0f;
		b0.d().k(A_0: true);
		SetMenuState(global::m.MenuState.a);
	}

	public override void b(GameTime A_0)
	{
		SetMenuState(global::m.MenuState.b);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		float num = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		da obj = am;
		obj.ag(obj.bg() + num * ((float)Math.PI / 2f));
		if (am.bg() > (float)Math.PI * 2f)
		{
			da obj2 = am;
			obj2.ag(obj2.bg() - (float)Math.PI * 2f);
		}
		if (Controls.GetInstance().IsPinched)
		{
			bool flag = false;
			bool flag2 = false;
			for (int num2 = 0; num2 < Controls.GetInstance().PinchGestures.Count; num2++)
			{
				GestureSample val = Controls.GetInstance().PinchGestures[num2];
				Vector2 position = val.Position;
				GestureSample val2 = Controls.GetInstance().PinchGestures[num2];
				Vector2 position2 = val2.Position2;
				if (ap.e((int)position.X, (int)position.Y) || ap.e((int)position2.X, (int)position2.Y))
				{
					flag = true;
				}
				if (aq.e((int)position.X, (int)position.Y) || aq.e((int)position2.X, (int)position2.Y))
				{
					flag2 = true;
				}
			}
			if (flag && flag2)
			{
				c(null);
			}
		}
		if (ar && @as)
		{
			au += num;
			int num3 = 0;
			if ((double)au < 0.08)
			{
				aj.ah -= (float)Math.Ceiling(60f * num);
			}
			else if ((double)au < 0.16)
			{
				aj.ah += (float)Math.Ceiling(30f * num);
			}
			else
			{
				au = 0f;
				aj.ah = num3;
				@as = false;
			}
		}
		if (!ar)
		{
			au += num;
			if ((double)au < 0.25 || ((double)au > 0.4 && (double)au < 0.8) || (double)au > 0.9)
			{
				al.am = true;
			}
			else
			{
				al.am = false;
			}
			if ((double)au > 1.5)
			{
				if (d.p().s(at) == GoldenEggType.Completed)
				{
					ao.am = true;
				}
				else
				{
					if (!am.am)
					{
						b0.d().d("star_collect").ac();
						d.p().p(at, GoldenEggType.Completed);
					}
					ao.am = false;
					am.am = true;
					an.am = true;
				}
				av += 800f * num;
				aj.ah += av * num;
			}
		}
		base.g(A_0);
	}

	public void a(ck A_0)
	{
		@as = true;
	}

	public void c(ck A_0)
	{
		ar = false;
	}
}
