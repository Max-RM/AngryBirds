using System.Collections.Generic;
using AngryBirds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class c4 : c
{
	private new int au;

	private new int av;

	private int aw;

	private List<da> ax;

	private List<da> ay;

	private bool az;

	private string a0;

	private da a1;

	private List<string> a2 = new List<string>
	{
		"SOUNDBOARD_1_BLOCK_ICE", "SOUNDBOARD_1_BLOCK_WOOD", "SOUNDBOARD_1_BLOCK_STONE", "SOUNDBOARD_1_TNT", "SOUNDBOARD_1_SLINGSHOT", "SOUNDBOARD_1_PIG_KING", "SOUNDBOARD_1_PIG_OLD", "SOUNDBOARD_1_PIG_HELMET", "SOUNDBOARD_1_PIG_SMALL", "SOUNDBOARD_1_LEVEL_FAIL",
		"SOUNDBOARD_1_LEVEL_START", "SOUNDBOARD_1_BIRD_WHITE", "SOUNDBOARD_1_BIRD_BLACK", "SOUNDBOARD_1_BIRD_YELLOW", "SOUNDBOARD_1_BIRD_RED", "SOUNDBOARD_1_BIRD_BLUE"
	};

	private new List<string> a3 = new List<string>
	{
		"light_destroyed", "wood_destroyed", "rock_destroyed", "tnt_explodes", "slingshot_stretched", "piglette_destroyed", "piglette_destroyed", "piglette_destroyed", "piglette_destroyed", "level_failed_piglets",
		"level_start_military", "bird_05_flying", "bird_04_flying", "bird_03_flying", "bird_01_flying", "bird_02_flying"
	};

	private new List<string> a4 = new List<string>
	{
		"light_collision", "wood_collision", "rock_collision", "tnt_explodes", "slingshot_stretched", "piglette", "piglette", "piglette", "piglette", "level_failed_piglets",
		"level_start_military", "special_egg", "special_explosion", "special_boost", "red_special", "special_group"
	};

	private new List<string> a5 = new List<string>
	{
		"light_collision", "wood_collision", "rock_collision", "tnt_explodes", "slingshot_stretched", "piglette", "piglette", "piglette", "piglette", "level_failed_piglets",
		"level_start_military", "bird_05_collision", "bird_04_collision", "bird_03_collision", "bird_01_collision", "bird_02_collision"
	};

	private new List<string> a6 = new List<string>
	{
		"light_collision", "wood_collision", "rock_collision", "tnt_explodes", "slingshot_stretched", "piglette", "piglette", "piglette", "piglette", "level_failed_piglets",
		"level_start_military", "bird_misc", "bird_misc", "bird_misc", "bird_misc", "bird_misc"
	};

	public c4()
	{
		au = 0;
		av = 0;
		aw = 0;
		a0 = "Level4";
		ax = new List<da>();
		ay = new List<da>();
	}

	public override void e()
	{
		base.e();
		p("goldenEggSoundBoardPage");
		SetMenuState(global::m.MenuState.a);
		au("goldenEggs");
		u u2 = u.a();
		SetLayout(new y());
		a3().an();
		a3().g(u2.g("SOUNDBOARD_1_BG"));
		for (int num = 0; num < a2.Count; num++)
		{
			da da2 = new da();
			da2.ae = num;
			da2.i(u2.g(a2[num]));
			da2.af = -u2.g(a2[num]).e + u2.g(a2[num]).c / 2;
			da2.ah = -u2.g(a2[num]).f + u2.g(a2[num]).d / 2;
			da2.ag(u2.g(a2[num]).c / 2);
			da2.ai(u2.g(a2[num]).d / 2);
			da da3 = da2;
			ax.Add(da3);
			p(da3);
		}
		da da4 = new da();
		da4.i(u2.g("MENU_SFZ"));
		da4.af = (float)((double)u2.g("MENU_SFZ").c * 0.5);
		da4.ah = (float)((double)u2.g("MENU_SFZ").d * 0.5);
		da4.y = a;
		((ck)da4).al = true;
		a("buttonSfxOn", da4);
		da da5 = new da();
		da5.i(u2.g("BUTTON_OFF"));
		da5.af = (float)((double)u2.g("MENU_SFZ").c * 0.5);
		da5.ah = (float)((double)u2.g("MENU_SFZ").d * 0.5);
		((ck)da5).al = false;
		da5.am = b0.d().p();
		a("buttonSfxOff", a1 = da5);
		da da6 = new da();
		da6.i(u2.g("LS_BACK_BUTTON"));
		da6.af = 0f;
		da6.ah = 480f;
		da6.am = true;
		((ck)da6).al = true;
		da6.y = a9().c;
		da6.z = "goldenEggs";
		da6.aa = u2.f("menu_back");
		p(da6);
	}

	public override void h(GameTime A_0)
	{
		az = false;
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
		base.f();
		for (int num = ay.Count - 1; num >= 0; num--)
		{
			ay[num].i(1f);
			ay[num].ai(1f);
			ay.RemoveAt(num);
		}
	}

	public override void g(GameTime A_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		Controls instance = Controls.GetInstance();
		for (int num = 0; num < ax.Count; num++)
		{
			for (int num2 = 0; num2 < instance.Touches.Count; num2++)
			{
				TouchLocation val = instance.Touches[num2];
				if ((int)val.State == 2 && ax[num].Hit(val.Position))
				{
					c(ax[num]);
				}
			}
		}
		base.g(A_0);
		a1.am = b0.d().p();
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

	public void c(ck A_0)
	{
		da da2 = (da)A_0;
		int num = da2.ae;
		switch (num)
		{
		case 0:
		case 1:
		case 2:
			if (au >= 2)
			{
				b0.d().d(a3[num]).ac();
				break;
			}
			au = 0;
			av = 0;
			b0.d().d(a4[num]).ac();
			break;
		case 3:
			b0.d().d(a3[num]).ac();
			break;
		case 4:
			au = 1;
			if (av == 1)
			{
				av = 2;
			}
			else
			{
				av = 0;
			}
			b0.d().d(a3[num]).ac();
			break;
		case 5:
		case 6:
		case 7:
		case 8:
			if (au >= 2)
			{
				if (av == 3)
				{
					au = 0;
					av = 4;
				}
				else
				{
					av = 0;
				}
				b0.d().d(a3[num]).ac();
			}
			else
			{
				au = 0;
				av = 0;
				b0.d().d(a4[num]).ac();
			}
			break;
		case 9:
			au = 0;
			av = 0;
			b0.d().d(a3[num]).ac();
			break;
		case 10:
			au = 0;
			av = 1;
			b0.d().d(a3[num]).ac();
			break;
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
			if (au == 1)
			{
				au = 2;
				if (av == 2)
				{
					av = 3;
				}
				else
				{
					av = 0;
				}
				aw = num;
				b0.d().d(a3[num]).ac();
			}
			else if (au >= 2)
			{
				if (aw == num)
				{
					if (au == 2)
					{
						au = 3;
						b0.d().d(a4[num]).ac();
					}
					else
					{
						b0.d().d(a5[num]).ac();
					}
				}
				else
				{
					au = 0;
					av = 0;
					aw = 0;
					b0.d().d(a6[num]).ac();
				}
			}
			else
			{
				au = 0;
				av = 0;
				aw = 0;
				b0.d().d(a6[num]).ac();
			}
			break;
		}
		da2.i(da2.bj() + 0.1f);
		da2.ai(da2.bh() + 0.1f);
		ay.Add(da2);
		if (av == 4)
		{
			au = 0;
			av = 0;
			aw = 0;
			if (!az)
			{
				az = true;
				a(a0, A_1: false, A_2: false);
			}
		}
	}
}
