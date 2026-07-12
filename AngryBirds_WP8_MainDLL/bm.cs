using System;
using System.Collections.Generic;
using AngryBirds;
using AngryBirds.Menus;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class bm : c
{
	private List<Vector2> aj;

	private da al;

	private da am;

	private da an;

	private da ao;

	private da ap;

	private bool aq;

	private bool ar;

	private string @as;

	private GestureSample at;

	private new bool m_au;

	private new bool av;

	private bool aw;

	public bm()
	{
		aq = false;
		ar = true;
		@as = "Level5";
		this.m_au = false;
	}

	public override void e()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		p("goldenEggEaglePage");
		SetMenuState(global::m.MenuState.a);
		au("goldenEggs");
		u u2 = u.a();
		aj = global::p.a().a("eaglePagePositions");
		SetLayout(new y());
		a3().an();
		a3().g(u2.g("CONCEPT_ART_BG"));
		da da2 = new da();
		da2.i(u2.g("CONCEPT_EAGLE_BIRDS_2"));
		p(da2);
		da da3 = new da();
		da3.i(u2.g("CONCEPT_EAGLE_BIRDS_1"));
		p(da3);
		da da4 = new da();
		da4.i(u2.g("CONCEPT_EAGLE_TONGUE"));
		p(da4);
		da da5 = new da();
		da5.i(u2.g("GOLDEN_EGG_STAR_EFFECT"));
		da5.af = (int)aj[10].X;
		da5.ah = (int)aj[10].Y;
		da5.am = false;
		an = da5;
		p(an);
		da da6 = new da();
		da6.i(u2.g("GOLDEN_EGG_STAR"));
		da6.af = (int)aj[11].X;
		da6.ah = (int)aj[11].Y;
		da6.am = false;
		ao = da6;
		p(ao);
		da da7 = new da();
		da7.i(u2.g("GOLDEN_EGG_STAR_COLLECTED"));
		da7.af = (int)aj[12].X;
		da7.ah = (int)aj[12].Y;
		da7.am = false;
		ap = da7;
		p(ap);
		da da8 = new da();
		da8.i(u2.g("CONCEPT_EAGLE_BEAK_LOWER"));
		da8.af = (int)aj[3].X;
		da8.ah = (int)aj[3].Y;
		((ck)da8).al = true;
		da8.ab = new r((int)aj[5].X, (int)aj[5].Y, 800, (int)aj[4].Y);
		da8.y = a;
		am = da8;
		p(am);
		da da9 = new da();
		da9.i(u2.g("CONCEPT_EAGLE_BEAK_UPPER"));
		da9.af = (int)aj[0].X;
		da9.ah = (int)aj[0].Y;
		((ck)da9).al = true;
		da9.ab = new r((int)aj[2].X, (int)aj[2].Y, 800, (int)aj[1].Y);
		da9.y = a;
		al = da9;
		p(al);
		da da10 = new da();
		da10.i(u2.g("LS_BACK_BUTTON"));
		da10.af = 0f;
		da10.ah = 480f;
		da10.am = true;
		((ck)da10).al = true;
		da10.y = a9().c;
		da10.z = "goldenEggs";
		da10.aa = u2.f("menu_back");
		p(da10);
	}

	public override void h(GameTime A_0)
	{
		a8().f(A_0: false);
		b0.d().k(A_0: true);
		SetMenuState(global::m.MenuState.a);
		aq = true;
		if (d.p().s(@as) == GoldenEggType.Completed)
		{
			ap.am = true;
			ao.am = false;
		}
		else
		{
			ap.am = false;
			ao.am = true;
		}
	}

	public override void b(GameTime A_0)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		ap.am = false;
		an.am = false;
		ao.am = false;
		((ck)ao).al = false;
		al.ah = (int)aj[0].Y;
		am.ah = (int)aj[3].Y;
		((ck)am).al = true;
		aq = false;
		SetMenuState(global::m.MenuState.b);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		float num = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		da obj = an;
		obj.ag(obj.bg() + num * ((float)Math.PI / 2f));
		if (an.bg() > (float)Math.PI * 2f)
		{
			da obj2 = an;
			obj2.ag(obj2.bg() - (float)Math.PI * 2f);
		}
		if (aq)
		{
			int num2 = (int)aj[0].Y;
			int num3 = (int)aj[1].Y;
			int num4 = (int)aj[8].Y;
			int num5 = (int)aj[9].Y;
			int num6 = 5;
			if (!this.m_au)
			{
				if (ar && al.ah >= (float)(num2 - 6))
				{
					al.ah -= 3f;
				}
				else
				{
					ar = false;
					if (al.ah <= (float)num2)
					{
						al.ah += (num2 - num4) / num6;
					}
					if (al.ah >= (float)num2)
					{
						al.ah = num2;
					}
					if (am.ah >= (float)num3)
					{
						am.ah -= (num5 - num3) / num6;
					}
					if (am.ah <= (float)num3)
					{
						am.ah = num3;
					}
				}
			}
			if (Controls.GetInstance().IsPinched)
			{
				if (!this.m_au && aq)
				{
					this.m_au = true;
					GestureSample val = Controls.GetInstance().PinchGestures[0];
					Vector2 position = val.Position;
					GestureSample val2 = Controls.GetInstance().PinchGestures[0];
					Vector2 position2 = val2.Position2;
					if (al.Hit((int)position.X, (int)position.Y))
					{
						av = true;
					}
					else if (al.Hit((int)position2.X, (int)position2.Y))
					{
						av = false;
					}
					else
					{
						this.m_au = false;
					}
					if (am.Hit((int)position.X, (int)position.Y))
					{
						aw = true;
					}
					else if (am.Hit((int)position2.X, (int)position2.Y))
					{
						aw = false;
					}
					else
					{
						this.m_au = false;
					}
					at = Controls.GetInstance().PinchGestures[0];
				}
				if (this.m_au && aq)
				{
					for (int num7 = 0; num7 < Controls.GetInstance().PinchGestures.Count; num7++)
					{
						GestureSample val3 = Controls.GetInstance().PinchGestures[num7];
						Vector2 position3 = val3.Position;
						GestureSample val4 = Controls.GetInstance().PinchGestures[num7];
						Vector2 position4 = val4.Position2;
						if (position3 == Vector2.Zero || position4 == Vector2.Zero)
						{
							break;
						}
						if (av)
						{
							al.ah -= at.Position.Y - position3.Y;
						}
						else
						{
							al.ah -= at.Position2.Y - position4.Y;
						}
						if (aw)
						{
							am.ah -= at.Position.Y - position3.Y;
						}
						else
						{
							am.ah -= at.Position2.Y - position4.Y;
						}
						if (al.ah < (float)num4)
						{
							al.ah = num4;
						}
						else if (al.ah > (float)num2)
						{
							al.ah = num2;
						}
						if (am.ah > (float)num5)
						{
							am.ah = num5;
						}
						else if (am.ah < (float)num3)
						{
							am.ah = num3;
						}
						if (al.ah <= (float)num4 && am.ah >= (float)num5)
						{
							al.ah = num4;
							am.ah = num5;
							au();
							break;
						}
						at = Controls.GetInstance().PinchGestures[num7];
					}
				}
			}
		}
		if (Controls.GetInstance().IsPinchCompleted)
		{
			this.m_au = false;
			ar = false;
		}
		base.g(A_0);
	}

	public void a(ck A_0)
	{
		ar = true;
	}

	public void au()
	{
		aq = false;
		if (d.p().s(@as) == GoldenEggType.Completed)
		{
			ap.am = true;
			an.am = false;
			ao.am = false;
			((ck)ao).al = false;
		}
		else
		{
			b0.d().d("star_collect").ac();
			ap.am = false;
			an.am = true;
			ao.am = true;
			((ck)ao).al = true;
		}
		d.p().p(@as, GoldenEggType.Completed);
	}
}
