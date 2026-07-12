using System.Collections.Generic;
using AngryBirds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class b2 : c
{
	private List<da> ar;

	private List<da> @as;

	private List<ae> at;

	private new List<ae> m_au;

	private new u av;

	private int aw;

	private int ax;

	private bool ay;

	private bool az;

	private string a0;

	private da a1;

	private bool[] a2;

	private new bool[] a3;

	private new aw a4;

	private new List<string> a5 = new List<string> { "C", "Cis", "D", "dis", "E", "F", "Fis", "G" };

	private new List<int> a6 = new List<int> { 0, 2, 3, 0, 7 };

	private new List<int> a7 = new List<int>
	{
		0, 2, 3, 0, 7, 7, 7, 5, 3, 3,
		2, 0
	};

	private new List<aw> a8;

	private new List<string> a9;

	private new List<string> ba;

	public b2()
	{
		List<aw> list = new List<aw>();
		aw aw2 = new aw();
		aw2.i(0.1875f);
		list.Add(aw2);
		aw aw3 = new aw();
		aw3.i(0.1875f);
		list.Add(aw3);
		aw aw4 = new aw();
		aw4.i(0.375f);
		list.Add(aw4);
		aw aw5 = new aw();
		aw5.i(0.375f);
		list.Add(aw5);
		aw aw6 = new aw();
		aw6.i(0.6f);
		list.Add(aw6);
		aw aw7 = new aw();
		aw7.i(0.375f);
		list.Add(aw7);
		aw aw8 = new aw();
		aw8.i(0.15f);
		list.Add(aw8);
		aw aw9 = new aw();
		aw9.i(0.225f);
		list.Add(aw9);
		aw aw10 = new aw();
		aw10.i(0.375f);
		list.Add(aw10);
		aw aw11 = new aw();
		aw11.i(0.15f);
		list.Add(aw11);
		aw aw12 = new aw();
		aw12.i(0.225f);
		list.Add(aw12);
		aw aw13 = new aw();
		aw13.i(0.5f);
		list.Add(aw13);
		a8 = list;
		a9 = new List<string> { "BIRD_BLUE", "BIRD_GREY", "BIRD_RED", "BIRD_GREY_BLINK", "BIRD_YELLOW", "BIRD_GREEN", "BIRD_GREY_FLYING", "BIRD_BOOMERANG" };
		ba = new List<string> { "BIRD_BLUE_YELL", "BIRD_GREY_YELL", "BIRD_RED_YELL", "BIRD_GREY_YELL", "BIRD_YELLOW_YELL", "BIRD_GREEN_YELL", "BIRD_GREY_YELL", "BIRD_BOOMERANG_YELL" };
		
		aw = 0;
		ax = 0;
		ay = false;
		az = false;
		a0 = "Level12";
	}

	public override void e()
	{
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		p("goldenEggKeyboardPage");
		SetMenuState(global::m.MenuState.a);
		au("goldenEggs");
		ar = new List<da>();
		@as = new List<da>();
		a2 = new bool[8];
		a3 = new bool[8];
		av = u.a();
		SetLayout(new y());
		a3().an();
		a3().g(av.g("CONCEPT_ART_BG"));
		List<Vector2> list = global::p.a().a("keyboardShadowPositions");
		List<Vector2> list2 = global::p.a().a("keyboardShadowSizes");
		List<Vector2> list3 = global::p.a().a("keyboardBirdPositions");
		List<Vector2> list4 = global::p.a().a("keyboardBirdSizes");
		at = new List<ae>();
		this.m_au = new List<ae>();
		aw aw2 = new aw();
		aw2.i(0.8f);
		aw2.g(au);
		a4 = aw2;
		for (int num = 0; num < a9.Count; num++)
		{
			da da2 = new da();
			da2.i(av.g("SOUNDBOARD_3_SHADOW"));
			da2.af = list[num].X;
			da2.ah = list[num].Y;
			da2.i(list2[num].X);
			da2.ai(list2[num].Y);
			da a_ = da2;
			p(a_);
		}
		for (int num2 = 0; num2 < a9.Count; num2++)
		{
			at.Add(av.g(a9[num2]));
			this.m_au.Add(av.g(ba[num2]));
			int num3 = (int)list3[num2].X;
			int num4 = (int)list3[num2].Y;
			da da3 = new da();
			da3.i(av.g(a9[num2]));
			da3.af = list3[num2].X;
			da3.ah = list3[num2].Y;
			da3.i(list4[num2].X);
			da3.ai(list4[num2].Y);
			da3.ab = new r(num3 - 40, num4 - 40, num3 + 40, num4 + 40);
			da3.ae = num2;
			da da4 = da3;
			p(da4);
			ar.Add(da4);
		}
		da da5 = new da();
		da5.i(av.g("MENU_SFZ"));
		da5.af = (float)((double)av.g("MENU_SFZ").c * 0.5);
		da5.ah = (float)((double)av.g("MENU_SFZ").d * 0.5);
		da5.y = a;
		((ck)da5).al = true;
		a("buttonSfxOn", da5);
		da da6 = new da();
		da6.i(av.g("BUTTON_OFF"));
		da6.af = (float)((double)av.g("MENU_SFZ").c * 0.5);
		da6.ah = (float)((double)av.g("MENU_SFZ").d * 0.5);
		((ck)da6).al = false;
		da6.am = b0.d().p();
		a("buttonSfxOff", a1 = da6);
		da da7 = new da();
		da7.i(av.g("LS_BACK_BUTTON"));
		da7.af = 0f;
		da7.ah = 480f;
		da7.am = true;
		((ck)da7).al = true;
		da7.y = a9().c;
		da7.z = "goldenEggs";
		da7.aa = av.f("menu_back");
		da7.ab = new r(0, 400, 90, 480);
		p(da7);
	}

	public override void h(GameTime A_0)
	{
		e("buttonSfxOff").am = b0.d().p();
		a8().f(A_0: false);
		b0.d().k(A_0: true);
		SetMenuState(global::m.MenuState.a);
	}

	public override void b(GameTime A_0)
	{
		SetMenuState(global::m.MenuState.b);
		aw = 0;
		ax = 0;
		ay = false;
		az = false;
		b0.d().k(A_0: true);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		a1.am = b0.d().p();
		if (b0.d().p())
		{
			b0.d().k(A_0: true);
		}
		float a_ = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		for (int num = 0; num < ar.Count; num++)
		{
			a3[num] = false;
			Controls instance = Controls.GetInstance();
			for (int num2 = 0; num2 < instance.Touches.Count; num2++)
			{
				TouchLocation val = instance.Touches[num2];
				if (ar[num].Hit(val.Position))
				{
					a3[num] = true;
				}
			}
			if (a2[num] && !a3[num])
			{
				c(num);
			}
			else if (!a2[num] && a3[num])
			{
				a(num);
			}
		}
		a4.h(a_);
		for (int num3 = 0; num3 < a8.Count; num3++)
		{
			a8[num3].h(a_);
		}
		base.g(A_0);
	}

	public void a(ck A_0)
	{
		if (b0.d().p())
		{
			b0.d().g(0.5f);
			a1.am = false;
		}
		else
		{
			b0.d().f(0.5f);
			a1.am = true;
		}
	}

	public void c(int A_0)
	{
		if (a2[A_0])
		{
			ar[A_0].i(at[A_0]);
			da obj = ar[A_0];
			obj.ai(obj.bh() / 0.85f);
			a2[A_0] = false;
		}
	}

	public void a(int A_0)
	{
		a2[A_0] = true;
		ar[A_0].i(this.m_au[A_0]);
		da obj = ar[A_0];
		obj.ai(obj.bh() * 0.85f);
		@as.Add(ar[A_0]);
		av.f("note" + a5[A_0]).ac();
		if (!az && !ay)
		{
			if (A_0 == a6[aw])
			{
				aw++;
			}
			else
			{
				aw = 0;
			}
			if (aw == a6.Count)
			{
				az = true;
				a4.g();
				a4.g(A_0: true);
			}
		}
	}

	public void au()
	{
		if (ax < a7.Count)
		{
			a8[ax].g();
			a8[ax].g(au);
			a8[ax].g(A_0: true);
			if (ax > 0)
			{
				c(a7[ax - 1]);
			}
			a(a7[ax]);
			ax++;
		}
		if (ax == a7.Count)
		{
			az = false;
			ay = true;
			a(a0, A_1: false, A_2: false);
		}
	}
}
