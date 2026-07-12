using System;
using System.Collections.Generic;
using AngryBirds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class b4 : c
{
	private List<Vector2> ar;

	private da @as;

	private da at;

	private new da m_au;

	private new da[] m_av;

	private da[] aw;

	private bool[] ax;

	private int ay;

	private float az = float.NaN;

	private float a0;

	private float a1;

	private float a2;

	private new bool a3;

	private new bool a4;

	private new bool a5;

	private new bool a6;

	private new string a7;

	private new da a8;

	public b4()
	{
		ay = 4;
		a7 = "Level7";
		au();
	}

	public override void e()
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		p("goldenEggRadioPage");
		SetMenuState(global::m.MenuState.a);
		au("goldenEggs");
		u u2 = u.a();
		ar = global::p.a().a("radioPagePositions");
		this.m_av = new da[ay];
		aw = new da[ay];
		ax = new bool[ay];
		SetLayout(new y());
		a3().an();
		a3().g(u2.g("SOUNDBOARD_2_BG"));
		da da2 = new da();
		da2.i(u2.g("SOUNDBOARD_2_BIRD"));
		da2.af = (int)ar[0].X;
		da2.ah = (int)ar[0].Y;
		at = da2;
		p(at);
		da da3 = new da();
		da3.i(u2.g("SOUNDBOARD_2_WHEEL"));
		da3.af = (int)ar[1].X;
		da3.ah = (int)ar[1].Y;
		((ck)da3).al = true;
		da3.y = c;
		@as = da3;
		p(@as);
		da da4 = new da();
		da4.i(u2.g("SOUNDBOARD_2_LCD"));
		p(da4);
		da da5 = new da();
		da5.i(u2.g("SOUNDBOARD_2_INDICATOR"));
		da5.af = (int)ar[2].X;
		da5.ah = (int)ar[2].Y;
		this.m_au = da5;
		p(this.m_au);
		for (int num = 0; num < ay; num++)
		{
			string text = "";
			da da6 = null;
			text = "SOUNDBOARD_2_BUTTON_UP_" + (num + 1);
			da da7 = new da();
			da7.ae = num;
			da7.i(u2.g(text));
			da6 = da7;
			this.m_av[num] = da6;
			p(da6);
			text = "SOUNDBOARD_2_BUTTON_DOWN_" + (num + 1);
			da da8 = new da();
			da8.ae = num;
			da8.i(u2.g(text));
			da8.am = false;
			da6 = da8;
			aw[num] = da6;
			p(da6);
		}
		da da9 = new da();
		da9.i(u2.g("MENU_SFZ"));
		da9.af = (float)((double)u2.g("MENU_SFZ").c * 0.5);
		da9.ah = (float)((double)u2.g("MENU_SFZ").d * 0.5);
		da9.y = a;
		((ck)da9).al = true;
		a("buttonSfxOn", da9);
		da da10 = new da();
		da10.i(u2.g("BUTTON_OFF"));
		da10.af = (float)((double)u2.g("MENU_SFZ").c * 0.5);
		da10.ah = (float)((double)u2.g("MENU_SFZ").d * 0.5);
		((ck)da10).al = false;
		da10.am = b0.d().p();
		a("buttonSfxOff", a8 = da10);
		da da11 = new da();
		da11.i(u2.g("LS_BACK_BUTTON"));
		da11.af = 0f;
		da11.ah = 480f;
		da11.am = true;
		((ck)da11).al = true;
		da11.y = a9().c;
		da11.z = "goldenEggs";
		da11.aa = u2.f("menu_back");
		p(da11);
	}

	private void au()
	{
		a0 = 0f;
		a1 = 0f;
		a2 = 0f;
		a3 = false;
		a4 = false;
		a5 = false;
		a6 = false;
	}

	public override void h(GameTime A_0)
	{
		a8().f(A_0: false);
		e("buttonSfxOff").am = b0.d().p();
		b0.d().k(A_0: true);
		SetMenuState(global::m.MenuState.a);
	}

	public override void b(GameTime A_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		SetMenuState(global::m.MenuState.b);
		b0.d().k(A_0: true);
		au();
		at.ah = (int)ar[0].Y;
		@as.ag(0f);
		this.m_au.af = (int)ar[2].X;
		for (int num = 0; num < ay; num++)
		{
			this.m_av[num].am = true;
			aw[num].am = false;
			ax[num] = false;
		}
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Invalid comparison between Unknown and I4
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		a8.am = b0.d().p();
		float num = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		if (a6)
		{
			a2 = (a2 + num * 5f) % (float)Math.PI;
			at.ag((float)Math.Sin(a2) / 4f);
			at.ah = ar[0].Y - (float)Math.Sin(a2) * (float)at.bf().d / 3f;
		}
		else if (a2 > 0f)
		{
			a2 += num * 5f;
			if (a2 > (float)Math.PI)
			{
				a2 = 0f;
			}
			at.ag((float)Math.Sin(a2) / 4f);
			at.ah = ar[0].Y - (float)Math.Sin(a2) * (float)at.bf().d / 3f;
		}
		Controls instance = Controls.GetInstance();
		if (instance.IsDragged)
		{
			for (int num2 = 0; num2 < instance.DragGestures.Count; num2++)
			{
				GestureSample val = instance.DragGestures[num2];
				Vector2 position = val.Position;
				float num3 = di.d(@as.af, @as.ah, position.X, position.Y);
				int num4 = @as.bf().c;
				if ((int)num3 < num4 * 2)
				{
					b0.d().k(A_0: true);
					a5 = true;
					double num5 = Math.Atan2((double)@as.ah - (double)position.Y, (double)@as.af - (double)position.X);
					if (!float.IsNaN(az))
					{
						double num6 = num5 - (double)az;
						if (num6 >= 4.71238898038469)
						{
							num6 -= Math.PI * 2.0;
						}
						else if (num6 <= -4.71238898038469)
						{
							num6 += Math.PI * 2.0;
						}
						if (Math.Abs(num6) < Math.PI / 2.0)
						{
							this.m_au.af += (float)num6 * 12f;
							if (this.m_au.af < ar[3].X)
							{
								num6 = 0.0;
								this.m_au.af = ar[3].X;
							}
							else if (this.m_au.af > ar[6].X)
							{
								num6 = 0.0;
								this.m_au.af = ar[6].X;
							}
							da obj = @as;
							obj.ag(obj.bg() + (float)num6);
						}
					}
					az = (float)num5;
				}
				else if (num3 < (float)(num4 / 2))
				{
					az = float.NaN;
				}
			}
		}
		else if (instance.IsPinched)
		{
			int num7 = 0;
			for (int num8 = 0; num8 < instance.PinchGestures.Count; num8++)
			{
				GestureSample val2 = instance.PinchGestures[num8];
				Vector2 position2 = val2.Position;
				GestureSample val3 = instance.PinchGestures[num8];
				Vector2 position3 = val3.Position2;
				for (int num9 = 0; num9 < ay; num9++)
				{
					if (this.m_av[num9].Hit((int)position2.X, (int)position2.Y) || this.m_av[num9].Hit((int)position3.X, (int)position3.Y))
					{
						num7++;
						ax[num9] = true;
					}
				}
			}
			if (num7 == 2)
			{
				av();
			}
		}
		else
		{
			int num10 = 0;
			for (int num11 = 0; num11 < ay; num11++)
			{
				for (int num12 = 0; num12 < instance.Touches.Count; num12++)
				{
					TouchLocation val4 = instance.Touches[num12];
					if ((int)val4.State == 2 && this.m_av[num11].Hit(val4.Position) && (!a6 || !aw[num11].am))
					{
						num10++;
						ax[num11] = true;
					}
				}
			}
			if (num10 == 1)
			{
				av();
			}
		}
		if (instance.IsDragCompleted)
		{
			double num13 = 800.0;
			int num14 = 0;
			for (int num15 = 0; num15 < ay; num15++)
			{
				_ = aw[num15].am;
			}
			for (int num16 = 3; num16 <= 7; num16++)
			{
				double num17 = Math.Abs(this.m_au.af - ar[num16].X);
				if (num17 < num13)
				{
					num13 = num17;
					num14 = num16 - 3;
					if (num17 > 0.0)
					{
						a4 = true;
					}
				}
			}
			a1 = (this.m_au.af - ar[3].X) / (ar[6].X - ar[3].X);
			if (num14 == 4)
			{
				ax[0] = true;
				ax[2] = true;
			}
			else
			{
				ax[num14] = true;
			}
			if (a5)
			{
				av();
			}
		}
		if (a4)
		{
			float num18 = 0.03f;
			float num19 = ar[3].X;
			float num20 = (float)Math.PI * 2f;
			float num21 = ar[6].X - num19;
			bool flag = true;
			if (a0 < a1)
			{
				num18 *= -1f;
				flag = false;
			}
			a1 += num18;
			@as.ag(a1 * num20);
			this.m_au.af = num19 + a1 * num21;
			if (flag && a1 >= a0)
			{
				@as.ag(a0 * num20);
				this.m_au.af = num19 + a0 * num21;
				a4 = false;
			}
			else if (!flag && a1 <= a0)
			{
				@as.ag(a0 * num20);
				this.m_au.af = num19 + a0 * num21;
				a4 = false;
			}
		}
		for (int num22 = 0; num22 < ay; num22++)
		{
			ax[num22] = false;
		}
		base.g(A_0);
	}

	public void a(ck A_0)
	{
		if (b0.d().p())
		{
			b0.d().g(0.5f);
			a8.am = false;
		}
		else
		{
			b0.d().f(0.5f);
			a8.am = true;
		}
	}

	public void av()
	{
		bool flag = a5;
		a5 = false;
		int num = 0;
		int num2 = 0;
		for (int num3 = 0; num3 < ay; num3++)
		{
			if (ax[num3] && !aw[num3].am)
			{
				flag = true;
			}
			if (ax[num3])
			{
				num++;
				num2 = num3;
			}
			this.m_av[num3].am = !ax[num3];
			aw[num3].am = ax[num3];
		}
		if (!flag)
		{
			return;
		}
		b0.d().d("button_radio").ac();
		a4 = true;
		if (num == 2)
		{
			a0 = 5f / 6f;
			a6 = true;
			s.a().a("funky_theme");
			if (!a3)
			{
				a3 = true;
				a(a7, A_1: false, A_2: false);
			}
		}
		else
		{
			a0 = (float)num2 / 3f;
			a6 = false;
			if (num2 == 0)
			{
				s.a().a("title_theme");
			}
			else
			{
				s.a().a("ambient_theme" + num2);
			}
		}
	}

	public void c(ck A_0)
	{
		for (int num = 0; num < ay; num++)
		{
			if (aw[num].am)
			{
				return;
			}
		}
		ax[0] = true;
		av();
	}
}
