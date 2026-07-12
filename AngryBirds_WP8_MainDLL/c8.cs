using System;
using AngryBirds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class c8 : c
{
	private new da m_au;

	private new da av;

	private da aw;

	private da ax;

	private da[] ay;

	private da[] az;

	private da a0;

	private da a1;

	private da a2;

	private new da a3;

	private new cw a4;

	private new cw a5;

	private new int a6;

	private new int a7;

	private new int a8;

	private new int a9;

	private new int ba;

	private new int bb;

	private new int bc;

	private new int bd;

	private new bool be;

	private new bool bf;

	private bool bg;

	private bool bh;

	private bool bi;

	private bool bj;

	private float bk;

	private float bl;

	private float bm;

	private float bn;

	private float bo;

	private float bp;

	private string bq;

	private da br;

	public c8()
	{
		bq = "Level21";
		a6 = 5;
	}

	public override void e()
	{
		base.e();
		p("goldenEggAccordionPage");
		SetMenuState(global::m.MenuState.a);
		au("goldenEggs");
		u u2 = u.a();
		ay = new da[a6];
		az = new da[a6];
		SetLayout(new y());
		a3().an();
		a3().g(u2.g("CONCEPT_ART_BG"));
		da da2 = new da();
		da2.i(u2.g("MENU_SFZ"));
		da2.af = (float)((double)u2.g("MENU_SFZ").c * 0.5);
		da2.ah = (float)((double)u2.g("MENU_SFZ").d * 0.5);
		da2.y = a;
		((ck)da2).al = true;
		a("buttonSfxOn", da2);
		da da3 = new da();
		da3.i(u2.g("BUTTON_OFF"));
		da3.af = (float)((double)u2.g("MENU_SFZ").c * 0.5);
		da3.ah = (float)((double)u2.g("MENU_SFZ").d * 0.5);
		((ck)da3).al = false;
		da3.am = b0.d().p();
		a("buttonSfxOff", br = da3);
		a7 = u2.g("ACCO_MID").c;
		a8 = u2.g("ACCO_MID").e;
		a9 = u2.g("ACCO_RIGHT").c;
		da da4 = new da();
		da4.i(u2.g("ACCO_MID_BROKEN"));
		da4.af = 400f - (float)a7 / 2.5f;
		da4.ah = 240f;
		da4.am = false;
		p(this.m_au = da4);
		da da5 = new da();
		da5.i(u2.g("ACCO_MID"));
		da5.af = 400f - (float)a7 / 2.5f;
		da5.ah = 240f;
		p(av = da5);
		da da6 = new da();
		da6.i(u2.g("ACCO_LEFT"));
		da6.af = 400f - (float)a7 / 2.5f;
		da6.ah = 240f;
		p(aw = da6);
		da da7 = new da();
		da7.i(u2.g("ACCO_RIGHT"));
		da7.af = 400f + (float)a7 / 4f;
		da7.ah = 240f;
		p(ax = da7);
		for (int num = 0; num < a6; num++)
		{
			string text = "";
			da da8 = null;
			text = "ACCO_BTN_DOWN_" + (num + 1);
			da da9 = new da();
			da9.ae = num;
			da9.i(u2.g(text));
			da9.af = 400f - (float)a7 / 2.5f;
			da9.ah = 240f;
			da9.am = false;
			da8 = da9;
			ay[num] = da8;
			p(da8);
			text = "ACCO_BTN_UP_" + (num + 1);
			da da10 = new da();
			da10.ae = num;
			da10.i(u2.g(text));
			da10.af = 400f - (float)a7 / 2.5f;
			da10.ah = 240f;
			da8 = da10;
			az[num] = da8;
			p(da8);
		}
		ba = u2.g("PIGLETTE_GRANDPA_01").c;
		bb = u2.g("PIGLETTE_GRANDPA_01").d;
		float num2 = 1.25f;
		if (num2 > 1.5f)
		{
			num2 = 1.5f;
		}
		da da11 = new da();
		da11.i(u2.g("SOUNDBOARD_4_SHADOW"));
		da11.af = 800f - (float)ba * num2 / 1.75f;
		da11.ah = 480f - (float)bb * num2 / 7f - 15f;
		p(a0 = da11);
		da da12 = new da();
		da12.i(u2.g("PIGLETTE_GRANDPA_01"));
		da12.af = 800f - (float)ba * num2 / 1.75f;
		da12.ah = 480f - (float)bb * num2 / 1.75f;
		da12.y = c;
		((ck)da12).al = true;
		p(a1 = da12);
		da da13 = new da();
		da13.i(u2.g("PIGLETTE_GRANDPA_04_SMILE"));
		da13.af = 800f - (float)ba * num2 / 1.75f;
		da13.ah = 480f - (float)bb * num2 / 1.75f;
		da13.am = false;
		p(a2 = da13);
		da da14 = new da();
		da14.i(u2.g("PIGLETTE_GRANDPA_01_BLINK"));
		da14.af = 800f - (float)ba * num2 / 1.75f;
		da14.ah = 480f - (float)bb * num2 / 1.75f;
		da14.am = false;
		p(a3 = da14);
		da da15 = new da();
		da15.i(u2.g("LS_BACK_BUTTON"));
		da15.af = 0f;
		da15.ah = 480f;
		da15.am = true;
		((ck)da15).al = true;
		da15.y = a9().c;
		da15.z = "goldenEggs";
		da15.aa = u2.f("menu_back");
		da15.ab = new r(0, 400, 90, 480);
		p(da15);
		a4 = b0.d().d("empty_accordion_right");
		a5 = b0.d().d("empty_accordion_left");
		a4.r(A_0: true);
		a5.r(A_0: true);
	}

	public override void h(GameTime A_0)
	{
		be = false;
		bf = false;
		bg = true;
		bh = false;
		bl = 0f;
		bm = 0f;
		bn = 0f;
		bd = -1;
		bk = 0f;
		for (int num = 0; num < a6; num++)
		{
			ay[num].am = false;
			az[num].am = true;
		}
		this.m_au.am = false;
		av.i(1f);
		av.af = 400f - (float)a7 / 2.5f;
		ax.af = 400f + (float)a7 / 4f;
		a1.am = true;
		a2.am = false;
		a3.am = false;
		a8().f(A_0: false);
		e("buttonSfxOff").am = b0.d().p();
		b0.d().k(A_0: true);
		SetMenuState(global::m.MenuState.a);
	}

	public override void b(GameTime A_0)
	{
		SetMenuState(global::m.MenuState.b);
		b0.d().k(A_0: true);
	}

	public override void f()
	{
		if (bc() == global::m.MenuState.a)
		{
			base.f();
		}
	}

	public override void g(GameTime A_0)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		base.g(A_0);
		br.am = b0.d().p();
		float num = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		Controls instance = Controls.GetInstance();
		bf = false;
		for (int num2 = 0; num2 < instance.Touches.Count; num2++)
		{
			TouchLocation val = instance.Touches[num2];
			if (ax.Hit(val.Position))
			{
				bf = true;
			}
			else
			{
				bf = false;
			}
		}
		if (be)
		{
			e(num);
			return;
		}
		int num3 = 0;
		int a_ = -1;
		for (int num4 = 0; num4 < 5; num4++)
		{
			for (int num5 = 0; num5 < instance.Touches.Count; num5++)
			{
				TouchLocation val2 = instance.Touches[num5];
				if (az[num4].Hit(val2.Position))
				{
					num3++;
					a_ = num4;
				}
			}
		}
		if (num3 == 1)
		{
			a(a_);
		}
		bj = bi;
		for (int num6 = 0; num6 < instance.Touches.Count; num6++)
		{
			TouchLocation val3 = instance.Touches[num6];
			if (ax.af >= 400f + (float)a7 / 2.1f && val3.Position.X >= ax.af + (float)(ax.bf().c / 2))
			{
				bf = true;
				a(0f - num, num);
			}
			else if (ax.Hit(val3.Position))
			{
				if (val3.Position.X > bp)
				{
					bj = true;
				}
				else if (val3.Position.X < bp)
				{
					bj = false;
				}
				a(val3.Position.X);
				bp = val3.Position.X;
				if (bi != bj)
				{
					if (bj)
					{
						bc = 6;
						bm = bl;
						bl = 0f;
						a(1f, 6);
						a(0f, 7);
					}
					else
					{
						bc = 7;
						bl = bm;
						bm = 0f;
						a(1f, 7);
						a(0f, 6);
					}
					if (bg)
					{
						a2.am = a1.am;
						a1.am = !a1.am;
						b0.d().d("pig_accordion").ac();
					}
					bi = bj;
				}
				a(bo, num);
			}
			else
			{
				a(0f - num, num);
			}
		}
		if (ax.af >= 400f + (float)a7 / 2.1f)
		{
			bk += num;
		}
		else
		{
			bk = 0f;
		}
		if (bk > 3f)
		{
			b0.d().k(A_0: true);
			be = true;
			this.m_au.am = true;
			av.i(1f);
			av.af = 400f + (float)a7 / 2f;
			au();
		}
		if (!bf)
		{
			c(num);
		}
	}

	public void e(float A_0)
	{
		if (ax.af <= 1600f)
		{
			ax.af += ax.af * 2f * A_0;
			av.af += ax.af * 2f * A_0;
		}
	}

	public void au()
	{
		b0.d().d("accordion_break").ac();
		a(bq, A_1: false, A_2: false);
	}

	public void a(float A_0)
	{
		bo = Math.Abs(A_0 - bp) / (float)(a7 / 20);
		if (bo > 1f)
		{
			bo = 1f;
		}
		else if (bo < 0f)
		{
			bo = 0f;
		}
		else if (bo == float.NaN)
		{
			bo = 0f;
		}
		ax.af = A_0 - (float)(a9 / 2);
		if (ax.af <= aw.af + (float)a8)
		{
			ax.af = aw.af + (float)a8;
		}
		else if (ax.af >= 400f + (float)a7 / 2f)
		{
			ax.af = 400f + (float)a7 / 2f;
		}
		av.i((ax.af - aw.af) / (float)(a7 - a8));
	}

	public void c(float A_0)
	{
		if (ax.af < 400f + (float)a7 / 4f)
		{
			if (bh && !bi)
			{
				bc = 6;
				bm = bl;
				bl = 0f;
				bi = true;
				a(bm, 6);
				a(0f, 7);
			}
			ax.af += ax.af * A_0;
			if (ax.af > 400f + (float)a7 / 4f)
			{
				ax.af = 400f + (float)a7 / 4f;
			}
		}
		else if (ax.af > 400f + (float)a7 / 4f)
		{
			if (bh && bi)
			{
				bc = 7;
				bl = bm;
				bm = 0f;
				bi = false;
				a(bm, 7);
				a(0f, 6);
			}
			ax.af -= ax.af * A_0;
			if (ax.af < 400f + (float)a7 / 4f)
			{
				ax.af = 400f + (float)a7 / 4f;
			}
		}
		else if (bg)
		{
			a1.am = true;
			a2.am = false;
		}
		a(0f - A_0, A_0);
		av.i((ax.af - aw.af) / (float)(a7 - a8));
	}

	public void a(float A_0, float A_1)
	{
		bn += A_1;
		if (bn >= 0.03f)
		{
			bn = 0f;
			if (bc == 6)
			{
				if (A_0 < 0f)
				{
					if (bm >= 0f)
					{
						bm += A_0;
					}
				}
				else if (A_0 - bm > 0.1f)
				{
					bm += 0.1f;
				}
				else if (A_0 - bm < -0.1f)
				{
					bm -= 0.1f;
				}
				else
				{
					bm = A_0;
				}
				a(bm, bc);
			}
			else
			{
				if (A_0 < 0f)
				{
					if (bl >= 0f)
					{
						bl += A_0;
					}
				}
				else if (A_0 - bl > 0.1f)
				{
					bl += 0.1f;
				}
				else if (A_0 - bl < -0.1f)
				{
					bl -= 0.1f;
				}
				else
				{
					bl = A_0;
				}
				a(bl, bc);
			}
		}
		if (!bh)
		{
			switch (bd)
			{
			case 0:
				a4 = b0.d().d("cminor_right");
				a5 = b0.d().d("cminor_left");
				break;
			case 1:
				a4 = b0.d().d("dismajor_right");
				a5 = b0.d().d("dismajor_left");
				break;
			case 2:
				a4 = b0.d().d("fmajor_right");
				a5 = b0.d().d("fmajor_left");
				break;
			case 3:
				a4 = b0.d().d("gminor_right");
				a5 = b0.d().d("gminor_left");
				break;
			case 4:
				a4 = b0.d().d("bmajor_right");
				a5 = b0.d().d("bmajor_left");
				break;
			default:
				a4 = b0.d().d("empty_accordion_right");
				a5 = b0.d().d("empty_accordion_left");
				break;
			}
			a4.r(A_0: true);
			a5.r(A_0: true);
			a4.ac();
			a5.ac();
			a4.y(0f);
			a5.y(0f);
			bh = true;
		}
	}

	public void a(ck A_0)
	{
		if (b0.d().p())
		{
			b0.d().g(0.5f);
			br.am = false;
		}
		else
		{
			b0.d().f(0.5f);
			br.am = true;
		}
	}

	public void a(float A_0, int A_1)
	{
		switch (A_1)
		{
		case 6:
			a4.y(A_0);
			break;
		case 7:
			a5.y(A_0);
			break;
		}
	}

	public void a(int A_0)
	{
		if (!be && !ay[A_0].am)
		{
			b0.d().k(A_0: true);
			bh = false;
			bd = A_0;
			for (int num = 0; num < a6; num++)
			{
				ay[num].am = num == A_0;
				az[num].am = num != A_0;
			}
		}
	}

	public void c(ck A_0)
	{
		if (!be)
		{
			bg = !bg;
			a1.am = bg;
			a3.am = !bg;
		}
	}
}
