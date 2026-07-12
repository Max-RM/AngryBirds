#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using AngryBirds;
using Innogiant;
using Microsoft.Xna.Framework;

internal class di
{
	private static di a;

	private Dictionary<string, cb> b;

	private Dictionary<string, cv> c;

	private Dictionary<string, a9> m_d;

	private Dictionary<string, a2> m_e;

	private Dictionary<string, a8> m_f;

	private Dictionary<string, av> m_g;

	private Dictionary<string, be> m_h;

	private bool m_i;

	[CompilerGenerated]
	private float m_j;

	[CompilerGenerated]
	private float m_k;

	[CompilerGenerated]
	private a2 m_l;

	[SpecialName]
	[CompilerGenerated]
	public float e()
	{
		return this.m_j;
	}

	[SpecialName]
	[CompilerGenerated]
	private void e(float A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float g()
	{
		return this.m_k;
	}

	[SpecialName]
	[CompilerGenerated]
	private void d(float A_0)
	{
		this.m_k = A_0;
	}

	public static di d()
	{
		if (a == null)
		{
			a = new di();
		}
		return a;
	}

	private di()
	{
		b = new Dictionary<string, cb>();
		c = new Dictionary<string, cv>();
		this.m_d = new Dictionary<string, a9>();
		this.m_e = new Dictionary<string, a2>();
		this.m_h = new Dictionary<string, be>();
		this.m_f = new Dictionary<string, a8>();
		this.m_g = new Dictionary<string, av>();
		this.m_i = false;
	}

	public void h()
	{
		if (this.m_i)
		{
			return;
		}
		string text = "";
		string text2 = "";
		LuaParser luaParser = new LuaParser();
		LuaVariable luaVariable = null;
		e(1.6666666f);
		d(1.5f);
		d(this.m_h);
		d(this.m_e);
		d(this.m_d);
		d(c);
		d(b);
		text = u.a("episodes.lua", global::h.g);
		text2 = al.a(text, "?:a/+6'N", ":4>)9a/{");
		luaParser.Parse(text2);
		luaVariable = luaParser.Value["episodes"];
		foreach (KeyValuePair<string, LuaVariable> item in luaVariable.GetArray())
		{
			av av2 = new av();
			av2.a = item.Key;
			av2.b = new List<string>();
			av av3 = av2;
			foreach (KeyValuePair<string, LuaVariable> item2 in item.Value.GetArray())
			{
				av3.b.Add(item2.Value);
			}
			this.m_g.Add(item.Key, av3);
		}
		text = u.a("levelPacks.lua", global::h.e);
		text2 = al.a(text, "?:a/+6'N", ":4>)9a/{");
		luaParser.Parse(text2);
		luaVariable = luaParser.Value["levelOrder"];
		int num = 0;
		foreach (KeyValuePair<string, LuaVariable> item3 in luaVariable.GetArray())
		{
			a8 a10 = new a8();
			a10.a = item3.Key;
			a10.e = true;
			a10.b = new List<string>();
			foreach (KeyValuePair<string, LuaVariable> item4 in item3.Value.GetArray())
			{
				a10.b.Add(item4.Value);
			}
			a10.d = num++;
			this.m_f.Add(item3.Key, a10);
		}
		luaVariable = luaParser.Value["packLevelButtonImages"];
		foreach (KeyValuePair<string, LuaVariable> item5 in luaVariable.GetArray())
		{
			if (this.m_f.ContainsKey(item5.Key))
			{
				this.m_f[item5.Key].c = item5.Value;
			}
		}
		luaVariable = luaParser.Value["comingSoonPacks"];
		foreach (KeyValuePair<string, LuaVariable> item6 in luaVariable.GetArray())
		{
			if (this.m_f.ContainsKey(item6.Value))
			{
				this.m_f[item6.Value].e = false;
			}
		}
		this.m_i = true;
	}

	public cb q(string A_0)
	{
		if (A_0 == null || !b.ContainsKey(A_0))
		{
			return null;
		}
		return b[A_0];
	}

	public cv p(string A_0)
	{
		if (A_0 == null || !c.ContainsKey(A_0))
		{
			return null;
		}
		return c[A_0];
	}

	public a9 n(string A_0)
	{
		if (A_0 == null || !this.m_d.ContainsKey(A_0))
		{
			return null;
		}
		return this.m_d[A_0];
	}

	public a2 i(string A_0)
	{
		if (A_0 == null || !this.m_e.ContainsKey(A_0))
		{
			return null;
		}
		return this.m_e[A_0];
	}

	[SpecialName]
	[CompilerGenerated]
	public a2 f()
	{
		return this.m_l;
	}

	[SpecialName]
	[CompilerGenerated]
	private void d(a2 A_0)
	{
		this.m_l = A_0;
	}

	public void e(a2 A_0)
	{
		if (f() != null && A_0.a != f().a)
		{
			a1.a(f());
			d(A_0);
			a1.b(A_0);
			f().g();
			global::d.p().v("theme" + A_0.a);
		}
	}

	public void m(string A_0)
	{
		a2 a10 = i(A_0);
		if (a10 != f())
		{
			a1.a(f());
			d(a10);
			a1.b(a10);
			f().g();
			global::d.p().v(A_0);
		}
	}

	public be h(string A_0)
	{
		if (A_0 == null || !this.m_h.ContainsKey(A_0))
		{
			return null;
		}
		return this.m_h[A_0];
	}

	public string l(string A_0)
	{
		a8 a10 = r(A_0);
		int num = a10.b.IndexOf(A_0);
		Debug.Assert(num != -1, "GameHelper: Could not find level {0} in pack {1}.", A_0, a10.a);
		num++;
		if (num < a10.b.Count)
		{
			return a10.b[num];
		}
		int num2 = o(a10.a);
		num2++;
		if (num2 < this.m_f["packs"].b.Count)
		{
			string a_ = this.m_f["packs"].b[num2];
			return f(a_)?.b[0];
		}
		return null;
	}

	public int o(string A_0)
	{
		return this.m_f["packs"].b.IndexOf(A_0);
	}

	public a8 f(string A_0)
	{
		if (!this.m_f.ContainsKey(A_0))
		{
			return null;
		}
		return this.m_f[A_0];
	}

	public av d(string A_0)
	{
		if (A_0 == null || !this.m_g.ContainsKey(A_0))
		{
			return null;
		}
		return this.m_g[A_0];
	}

	public List<string> i()
	{
		return Enumerable.ToList<string>((IEnumerable<string>)this.m_g.Keys);
	}

	public string g(string A_0)
	{
		a8 a10 = r(A_0);
		if (a10 != null)
		{
			int num = a10.b.IndexOf(A_0) + 1;
			StringBuilder stringBuilder = new StringBuilder(5);
			if (a10.d == 16)
			{
				if (num == 22)
				{
					stringBuilder.Append("*");
				}
				else
				{
					stringBuilder.Append("^");
					stringBuilder.Append("-");
					stringBuilder.Append(num);
				}
			}
			else if (a10.d == 15)
			{
				stringBuilder.Append("|");
				stringBuilder.Append("-");
				stringBuilder.Append(num);
			}
			else
			{
				stringBuilder.Append(a10.d);
				stringBuilder.Append("-");
				stringBuilder.Append(num);
			}
			return stringBuilder.ToString();
		}
		return "0-0";
	}

	public a8 r(string A_0)
	{
		foreach (KeyValuePair<string, a8> item in this.m_f)
		{
			for (int num = 0; num < item.Value.b.Count; num++)
			{
				if (item.Value.b[num] == A_0)
				{
					return item.Value;
				}
			}
		}
		return null;
	}

	public string e(string A_0)
	{
		switch (o(r(A_0).a))
		{
		case 0:
		case 1:
		case 2:
			return "episode1";
		case 3:
		case 4:
			return "episode2";
		case 5:
		case 6:
		case 7:
			return "episode3";
		case 8:
		case 9:
		case 10:
			return "episode4";
		case 11:
		case 12:
		case 13:
		case 14:
			return "episode5";
		default:
			return null;
		}
	}

	public av k(string A_0)
	{
		foreach (KeyValuePair<string, av> item in this.m_g)
		{
			for (int num = 0; num < item.Value.b.Count; num++)
			{
				if (item.Value.b[num] == A_0)
				{
					return item.Value;
				}
			}
		}
		return null;
	}

	public bool j(string A_0)
	{
		a8 a10 = d().r(A_0);
		return a10.a == "pack1";
	}

	private void d(Dictionary<string, cb> A_0)
	{
		//IL_1342: Unknown result type (might be due to invalid IL or missing references)
		//IL_1347: Unknown result type (might be due to invalid IL or missing references)
		//IL_135e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1363: Unknown result type (might be due to invalid IL or missing references)
		//IL_137a: Unknown result type (might be due to invalid IL or missing references)
		//IL_137f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1474: Unknown result type (might be due to invalid IL or missing references)
		//IL_1479: Unknown result type (might be due to invalid IL or missing references)
		//IL_1490: Unknown result type (might be due to invalid IL or missing references)
		//IL_1495: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_289e: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_28bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_28db: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6840: Unknown result type (might be due to invalid IL or missing references)
		//IL_6845: Unknown result type (might be due to invalid IL or missing references)
		//IL_685c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6861: Unknown result type (might be due to invalid IL or missing references)
		//IL_6878: Unknown result type (might be due to invalid IL or missing references)
		//IL_687d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6894: Unknown result type (might be due to invalid IL or missing references)
		//IL_6899: Unknown result type (might be due to invalid IL or missing references)
		//IL_68b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_68b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_68cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_68d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_694b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6950: Unknown result type (might be due to invalid IL or missing references)
		//IL_6967: Unknown result type (might be due to invalid IL or missing references)
		//IL_696c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6983: Unknown result type (might be due to invalid IL or missing references)
		//IL_6988: Unknown result type (might be due to invalid IL or missing references)
		//IL_699f: Unknown result type (might be due to invalid IL or missing references)
		//IL_69a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_69bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_69c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_69d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_69dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_6aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_6aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_6acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_6daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_6db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_6dcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_6dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_6de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_6dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e03: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_6eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ebf: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_6edb: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ef7: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f92: Unknown result type (might be due to invalid IL or missing references)
		//IL_6fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_6fae: Unknown result type (might be due to invalid IL or missing references)
		//IL_6fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_6fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_6fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_6fe6: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_7002: Unknown result type (might be due to invalid IL or missing references)
		//IL_7019: Unknown result type (might be due to invalid IL or missing references)
		//IL_701e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7098: Unknown result type (might be due to invalid IL or missing references)
		//IL_709d: Unknown result type (might be due to invalid IL or missing references)
		//IL_70b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_70b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_70d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_70d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_70ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_70f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_7108: Unknown result type (might be due to invalid IL or missing references)
		//IL_710d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7124: Unknown result type (might be due to invalid IL or missing references)
		//IL_7129: Unknown result type (might be due to invalid IL or missing references)
		//IL_71a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_71a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_71bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_71c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_71db: Unknown result type (might be due to invalid IL or missing references)
		//IL_71e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_71f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_71fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_7213: Unknown result type (might be due to invalid IL or missing references)
		//IL_7218: Unknown result type (might be due to invalid IL or missing references)
		//IL_722f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7234: Unknown result type (might be due to invalid IL or missing references)
		A_0.Add("SmallBlueBird", new cn(BlockBasicType.CIRCLE, null, "BIRD_BLUE", null, "light", BlockGroup.BIRDS, 0.6f, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, "bird_02_collision", 4.5f, 0.3f, 0.25f, 60f, 2f, A_23: true, "blueBuff", "blueBirdTrail", "CLUSTER_BOMB", "TUTORIAL_2", "BlueBirdDamageFactors", A_29: true, A_30: true, "bird_02_flying", "special_group", "bird_02_select", "bird_02_unselect", "BIRD_BLUE", "BIRD_BLUE", "BIRD_BLUE_COLLISION", "HUD_ICON_SPLIT", "10K_BLUE", "BIRD_BLUE_YELL", "BIRD_BLUE_BLINK"));
		A_0.Add("RedBird", new cn(BlockBasicType.CIRCLE, null, "BIRD_RED", null, "red", BlockGroup.BIRDS, 0.85f, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, "bird_01_collision", 6f, 0.3f, 0.43f, 60f, float.NaN, A_23: true, "redBuff", "redBirdTrail", "SOUND", "TUTORIAL_1", "DefaultDamageFactors", A_29: true, A_30: true, "bird_01_flying", "red_special", "bird_01_select", "bird_01_unselect", "BIRD_RED", "BIRD_RED_FLYING", "BIRD_RED_COLLISION", "HUD_ICON_NOTE", "10K_RED", "BIRD_RED_YELL", "BIRD_RED_BLINK"));
		A_0.Add("YellowBird", new cn(BlockBasicType.CIRCLE, null, "BIRD_YELLOW", null, "wood", BlockGroup.BIRDS, 0.8f, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, "bird_03_collision", 6f, 0.3f, 0.23f, 60f, 2.5f, A_23: true, "yellowBuff", "yellowBirdTrail", "BOOST", "TUTORIAL_3", "YellowBirdDamageFactors", A_29: true, A_30: true, "bird_03_flying", "special_boost", "bird_03_select", "bird_03_unselect", "BIRD_YELLOW", "BIRD_YELLOW_FLYING", "BIRD_YELLOW_COLLISION", "HUD_ICON_BOOST", "10K_YELLOW", "BIRD_YELLOW_YELL", "BIRD_YELLOW_BLINK"));
		A_0.Add("BlackBird", new cn(BlockBasicType.CIRCLE, null, "BIRD_GREY", null, "rock", BlockGroup.BIRDS, 1f, 5, A_8: true, 0, null, 15f, 40000f, 5f, 300f, A_15: false, 0, "bird_04_collision", 6f, 0.3f, 0.03f, 60f, 15f, A_23: true, "blackBuff", "bombBirdTrail", "BOMB", "TUTORIAL_4", "BlackBirdDamageFactors", A_29: false, A_30: true, "bird_04_flying", "special_explosion", "bird_04_select", "bird_04_unselect", "BIRD_GREY", "BIRD_GREY_FLYING", "BIRD_GREY_FLYING", "HUD_ICON_EXPLOSION", "10K_BLACK", "BIRD_GREY_YELL", "BIRD_GREY_BLINK"));
		A_0.Add("BasicBird2", new cn(BlockBasicType.CIRCLE, null, "BIRD_GREEN", null, "red", BlockGroup.BIRDS, 1.3f, 4, A_8: true, 0, null, 10f, 20000f, 5f, 200f, A_15: false, 0, "bird_05_collision", 4.5f, 0.3f, 0.23f, 60f, float.NaN, A_23: true, "greenBuff", "bomberBirdTrail", "GRENADE", "TUTORIAL_5", "DefaultDamageFactors", A_29: false, A_30: true, "bird_05_flying", "special_egg", "bird_05_select", "bird_05_unselect", "BIRD_GREEN", "BIRD_GREEN_FLYING", "BIRD_GREEN_COLLISION", "HUD_ICON_EGG", "10K_WHITE", "BIRD_GREEN_YELL", "BIRD_GREEN_BLINK"));
		A_0.Add("EggGranade", new cn(BlockBasicType.CIRCLE, null, "DROPPABLE_EGG", null, "red", BlockGroup.BIRDS, float.NaN, int.MinValue, A_8: true, 0, null, 10f, 10000f, 8f, 400f, A_15: false, 0, null, 3f, 0.3f, 0.23f, 60f, float.NaN, A_23: true, "explosionBuff", null, "BOMB", null, "DefaultDamageFactors", A_29: false, A_30: true, null, null, null, null, "DROPPABLE_EGG", null, null, null, null, null, null));
		A_0.Add("RedBigBird", new cn(BlockBasicType.CIRCLE, null, "BIRD_BIG_BROTHER", null, "red", BlockGroup.BIRDS, 1.8f, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, "big_brother_collision", 10f, 0.3f, 0.45f, 60f, float.NaN, A_23: true, "redBuff", "redBirdTrail", "SOUND", "TUTORIAL_7", "RedBigBirdDamageFactors", A_29: true, A_30: false, "big_brother_flying", "big_brother_special", "big_brother_select", "bird_01_unselect", "BIRD_BIG_BROTHER", "BIRD_BIG_BROTHER", "BIRD_BIG_BROTHER", "HUD_ICON_NOTE", "10K_RED", "BIRD_BIG_BROTHER_YELL", "BIRD_BIG_BROTHER_BLINK"));
		A_0.Add("BoomerangBird", new cn(BlockBasicType.CIRCLE, null, "BIRD_BOOMERANG", null, "wood", BlockGroup.BIRDS, 1.5f, 7, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, "bird_03_collision", 3f, 0.3f, 0.23f, 60f, 2.5f, A_23: true, "yellowBuff", "yellowBirdTrail", "BOOMERANG", "TUTORIAL_6", "BoomerangBirdDamageFactors", A_29: true, A_30: false, "bird_06_flying", "boomerang_activate", "boomerang_select", "bird_03_unselect", "BIRD_BOOMERANG", "BIRD_BOOMERANG", "BIRD_BOOMERANG_COLLISION", "HUD_ICON_BOOST", "10K_BOOMERANG", "BIRD_BOOMERANG_YELL", "BIRD_BOOMERANG_BLINK"));
		A_0.Add("MightyEagleBird", new cn(BlockBasicType.CIRCLE, null, "BIRD_MIGHTY_EAGLE_MOTION", null, "red", BlockGroup.BIRDS, 5f, 8, A_8: true, 999, null, 100f, 20000f, 100f, 1f, A_15: false, 0, "big_brother_collision", 100f, 0.1f, 0.05f, 60000f, float.NaN, A_23: true, "smokeBuff", "redBirdTrail", "MIGHTY_EAGLE", "TUTORIAL_8", "MightyEagleBirdDamageFactors", A_29: true, A_30: false, null, null, null, null, "BIRD_MIGHTY_EAGLE_MOTION", "BIRD_MIGHTY_EAGLE_RADIAL", "BIRD_MIGHTY_EAGLE_MOTION", "BIRD_MIGHTY_EAGLE_RADIAL", "BIRD_MIGHTY_EAGLE_RADIAL", "BIRD_MIGHTY_EAGLE_RADIAL", "BIRD_MIGHTY_EAGLE_RADIAL"));
		A_0.Add("BaitSardine", new cn(BlockBasicType.BOX, null, "BAIT_SARDINE", null, "common", BlockGroup.BIRDS, float.NaN, 9, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, "sardine_can_physics_a2", 1f, 0.25f, 0.05f, 1f, 1f, A_23: true, null, "redBirdTrail", "SUMMON_MIGHTY_EAGLE", "TUTORIAL_8", "DefaultDamageFactors", A_29: true, A_30: false, "sardine_can_shot", "mighty_eagle_yell", null, null, "BAIT_SARDINE", "BAIT_SARDINE", "BAIT_SARDINE", "BAIT_SARDINE", "BAIT_SARDINE", "BAIT_SARDINE", "BAIT_SARDINE"));
		A_0.Add("SmallPiglette", new at(BlockBasicType.CIRCLE, null, "PIGLETTE_SMALL_01", null, "piglette", BlockGroup.PIGLETTES, 1.075f, 1, A_8: true, 0, new bl[3]
		{
			new bl("PIGLETTE_SMALL_01", "PIGLETTE_SMALL_01_BLINK", "PIGLETTE_SMALL_01_SMILE", 100, 90),
			new bl("PIGLETTE_SMALL_02", "PIGLETTE_SMALL_02_BLINK", "PIGLETTE_SMALL_02_SMILE", 90, 50),
			new bl("PIGLETTE_SMALL_03", "PIGLETTE_SMALL_03_BLINK", "PIGLETTE_SMALL_03_SMILE", 50, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 2f, 0.7f, 0.05f, 4f, 1f, A_23: false, A_24: true));
		A_0.Add("MediumPiglette", new at(BlockBasicType.CIRCLE, null, "PIGLETTE_MEDIUM_01", null, "piglette", BlockGroup.PIGLETTES, 1.85f, 2, A_8: true, 0, new bl[3]
		{
			new bl("PIGLETTE_MEDIUM_01", "PIGLETTE_MEDIUM_01_BLINK", "PIGLETTE_MEDIUM_01_SMILE", 100, 90),
			new bl("PIGLETTE_MEDIUM_02", "PIGLETTE_MEDIUM_02_BLINK", "PIGLETTE_MEDIUM_02_SMILE", 90, 50),
			new bl("PIGLETTE_MEDIUM_03", "PIGLETTE_MEDIUM_03_BLINK", "PIGLETTE_MEDIUM_03_SMILE", 50, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 2f, 0.3f, 0.05f, 10f, 1f, A_23: false, A_24: true));
		A_0.Add("HelmetPiglette", new at(BlockBasicType.CIRCLE, null, "PIGLETTE_HELMET_01", null, "piglette", BlockGroup.PIGLETTES, 1.95f, 3, A_8: true, 0, new bl[3]
		{
			new bl("PIGLETTE_HELMET_01", "PIGLETTE_HELMET_01_BLINK", "PIGLETTE_HELMET_01_SMILE", 100, 90),
			new bl("PIGLETTE_HELMET_02", "PIGLETTE_HELMET_02_BLINK", "PIGLETTE_HELMET_02_SMILE", 90, 50),
			new bl("PIGLETTE_HELMET_03", "PIGLETTE_HELMET_03_BLINK", "PIGLETTE_HELMET_03_SMILE", 50, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 2f, 0.3f, 0.05f, 15f, 8f, A_23: false, A_24: true));
		A_0.Add("LargePiglette", new at(BlockBasicType.CIRCLE, null, "PIGLETTE_BIG_01", null, "piglette", BlockGroup.PIGLETTES, 2.325f, 4, A_8: true, 0, new bl[3]
		{
			new bl("PIGLETTE_BIG_01", "PIGLETTE_BIG_01_BLINK", "PIGLETTE_BIG_01_SMILE", 100, 90),
			new bl("PIGLETTE_BIG_02", "PIGLETTE_BIG_02_BLINK", "PIGLETTE_BIG_02_SMILE", 90, 50),
			new bl("PIGLETTE_BIG_03", "PIGLETTE_BIG_03_BLINK", "PIGLETTE_BIG_03_SMILE", 50, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1f, 0.3f, 0.05f, 20f, 1f, A_23: false, A_24: true));
		A_0.Add("GrandpaPiglette", new at(BlockBasicType.CIRCLE, null, "PIGLETTE_GRANDPA_01", null, "piglette", BlockGroup.PIGLETTES, 2.2f, 5, A_8: true, 0, new bl[3]
		{
			new bl("PIGLETTE_GRANDPA_01", "PIGLETTE_GRANDPA_01_BLINK", "PIGLETTE_GRANDPA_04_SMILE", 100, 90),
			new bl("PIGLETTE_GRANDPA_02", "PIGLETTE_GRANDPA_02_BLINK", "PIGLETTE_GRANDPA_05_SMILE", 90, 50),
			new bl("PIGLETTE_GRANDPA_03", "PIGLETTE_GRANDPA_03_BLINK", "PIGLETTE_GRANDPA_06_SMILE", 50, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1f, 0.3f, 0.05f, 30f, 1f, A_23: false, A_24: true));
		A_0.Add("KingPiglette", new at(BlockBasicType.CIRCLE, null, "PIGLETTE_KING_01", null, "piglette", BlockGroup.PIGLETTES, 2.825f, 6, A_8: true, 0, new bl[3]
		{
			new bl("PIGLETTE_KING_01", "PIGLETTE_KING_01_BLINK", "PIGLETTE_KING_07_SMILE", 100, 90),
			new bl("PIGLETTE_KING_02", "PIGLETTE_KING_02_BLINK", "PIGLETTE_KING_08_SMILE", 90, 50),
			new bl("PIGLETTE_KING_03", "PIGLETTE_KING_03_BLINK", "PIGLETTE_KING_09_SMILE", 50, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1f, 0.3f, 0.05f, 100f, 0f, A_23: false, A_24: true));
		A_0.Add("WoodBlock1", new cb(BlockBasicType.BOX, null, "BLOCK_WOOD_1_1", null, "wood", BlockGroup.WOOD_BLOCK, float.NaN, 1, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_WOOD_1_1", "", "", 100, 75),
			new bl("BLOCK_WOOD_2_1", "", "", 75, 50),
			new bl("BLOCK_WOOD_3_1", "", "", 50, 25),
			new bl("BLOCK_WOOD_4_1", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1.5f, 4f, 0.2f, 20f, 2.5f, A_23: false));
		A_0.Add("WoodBlock2", new cb(BlockBasicType.BOX, null, "BLOCK_WOOD_1_2", null, "wood", BlockGroup.WOOD_BLOCK, float.NaN, 2, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_WOOD_1_2", "", "", 100, 75),
			new bl("BLOCK_WOOD_2_2", "", "", 75, 50),
			new bl("BLOCK_WOOD_3_2", "", "", 50, 25),
			new bl("BLOCK_WOOD_4_2", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1.5f, 4f, 0.2f, 40f, 2.5f, A_23: false));
		A_0.Add("WoodBlock3", new cb(BlockBasicType.BOX, null, "BLOCK_WOOD_1_3", null, "wood", BlockGroup.WOOD_BLOCK, float.NaN, 3, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_WOOD_1_3", "", "", 100, 75),
			new bl("BLOCK_WOOD_2_3", "", "", 75, 50),
			new bl("BLOCK_WOOD_3_3", "", "", 50, 25),
			new bl("BLOCK_WOOD_4_3", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1.5f, 4f, 0.2f, 60f, 2.5f, A_23: false));
		A_0.Add("WoodBlock4", new cb(BlockBasicType.BOX, null, "BLOCK_WOOD_1_4", null, "wood", BlockGroup.WOOD_BLOCK, float.NaN, 4, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_WOOD_1_4", "", "", 100, 75),
			new bl("BLOCK_WOOD_2_4", "", "", 75, 50),
			new bl("BLOCK_WOOD_3_4", "", "", 50, 25),
			new bl("BLOCK_WOOD_4_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1.5f, 4f, 0.2f, 50f, 2.5f, A_23: false));
		A_0.Add("WoodBlock5", new cb(BlockBasicType.BOX, null, "BLOCK_WOOD_1_5", null, "wood", BlockGroup.WOOD_BLOCK, float.NaN, 5, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_WOOD_1_5", "", "", 100, 75),
			new bl("BLOCK_WOOD_2_5", "", "", 75, 50),
			new bl("BLOCK_WOOD_3_5", "", "", 50, 25),
			new bl("BLOCK_WOOD_4_5", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1.5f, 4f, 0.2f, 80f, 2.5f, A_23: false));
		A_0.Add("WoodBlock6", new cb(BlockBasicType.BOX, null, "BLOCK_WOOD_1_6", null, "wood", BlockGroup.WOOD_BLOCK, float.NaN, 6, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_WOOD_1_6", "", "", 100, 75),
			new bl("BLOCK_WOOD_2_6", "", "", 75, 50),
			new bl("BLOCK_WOOD_3_6", "", "", 50, 25),
			new bl("BLOCK_WOOD_4_6", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1.5f, 4f, 0.2f, 70f, 2.5f, A_23: false));
		A_0.Add("WoodBlock7", new cb(BlockBasicType.CIRCLE, null, "BLOCK_WOOD_1_7", null, "wood", BlockGroup.WOOD_BLOCK, float.NaN, 7, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_WOOD_1_7", "", "", 100, 75),
			new bl("BLOCK_WOOD_2_7", "", "", 75, 50),
			new bl("BLOCK_WOOD_3_7", "", "", 50, 25),
			new bl("BLOCK_WOOD_4_7", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1.5f, 4f, 0.2f, 200f, 2.5f, A_23: false));
		A_0.Add("WoodBlock8", new cb(BlockBasicType.CIRCLE, null, "BLOCK_WOOD_1_8", null, "wood", BlockGroup.WOOD_BLOCK, float.NaN, 8, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_WOOD_1_8", "", "", 100, 75),
			new bl("BLOCK_WOOD_2_8", "", "", 75, 50),
			new bl("BLOCK_WOOD_3_8", "", "", 50, 25),
			new bl("BLOCK_WOOD_4_8", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1.5f, 4f, 0.2f, 150f, 2.5f, A_23: false));
		A_0.Add("WoodBlock9", new cb(BlockBasicType.BOX, null, "BLOCK_WOOD_4X4_1", null, "wood", BlockGroup.WOOD_BLOCK, float.NaN, 9, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_WOOD_4X4_1", "", "", 100, 75),
			new bl("BLOCK_WOOD_4X4_2", "", "", 75, 50),
			new bl("BLOCK_WOOD_4X4_3", "", "", 50, 25),
			new bl("BLOCK_WOOD_4X4_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1.5f, 4f, 0.2f, 120f, 2.5f, A_23: false));
		A_0.Add("WoodBlock10", new cb(BlockBasicType.BOX, null, "BLOCK_WOOD_10X1_1", null, "wood", BlockGroup.WOOD_BLOCK, float.NaN, 10, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_WOOD_10X1_1", "", "", 100, 75),
			new bl("BLOCK_WOOD_10X1_2", "", "", 75, 50),
			new bl("BLOCK_WOOD_10X1_3", "", "", 50, 25),
			new bl("BLOCK_WOOD_10X1_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1.5f, 4f, 0.2f, 100f, 2.5f, A_23: false));
		A_0.Add("WoodBlock11", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[3]
		{
			new Vector2(0f, 0f),
			new Vector2(1f, 1f),
			new Vector2(0f, 1f)
		}, "BLOCK_WOOD_TRIANGLE_L_1", null, "wood", BlockGroup.WOOD_BLOCK, float.NaN, 11, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_WOOD_TRIANGLE_L_1", "", "", 100, 75),
			new bl("BLOCK_WOOD_TRIANGLE_L_2", "", "", 75, 50),
			new bl("BLOCK_WOOD_TRIANGLE_L_3", "", "", 50, 25),
			new bl("BLOCK_WOOD_TRIANGLE_L_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1.5f, 4f, 0.2f, 80f, 2.5f, A_23: false));
		A_0.Add("WoodBlock12", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[3]
		{
			new Vector2(0.5f, 0f),
			new Vector2(1f, 1f),
			new Vector2(0f, 1f)
		}, "BLOCK_WOOD_TRIANGLE_M_1", null, "wood", BlockGroup.WOOD_BLOCK, float.NaN, 12, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_WOOD_TRIANGLE_M_1", "", "", 100, 75),
			new bl("BLOCK_WOOD_TRIANGLE_M_2", "", "", 75, 50),
			new bl("BLOCK_WOOD_TRIANGLE_M_3", "", "", 50, 25),
			new bl("BLOCK_WOOD_TRIANGLE_M_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 1.5f, 4f, 0.2f, 70f, 2.5f, A_23: false));
		A_0.Add("StoneBlock1", new cb(BlockBasicType.BOX, null, "BLOCK_ROCK_1_1", null, "rock", BlockGroup.UNDEFINED, float.NaN, 1, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_ROCK_1_1", "", "", 100, 75),
			new bl("BLOCK_ROCK_2_1", "", "", 75, 50),
			new bl("BLOCK_ROCK_3_1", "", "", 50, 25),
			new bl("BLOCK_ROCK_4_1", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 30f, 15f, A_23: false));
		A_0.Add("StoneBlock2", new cb(BlockBasicType.BOX, null, "BLOCK_ROCK_1_2", null, "rock", BlockGroup.UNDEFINED, float.NaN, 2, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_ROCK_1_2", "", "", 100, 75),
			new bl("BLOCK_ROCK_2_2", "", "", 75, 50),
			new bl("BLOCK_ROCK_3_2", "", "", 50, 25),
			new bl("BLOCK_ROCK_4_2", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 60f, 15f, A_23: false));
		A_0.Add("StoneBlock3", new cb(BlockBasicType.BOX, null, "BLOCK_ROCK_1_3", null, "rock", BlockGroup.UNDEFINED, float.NaN, 3, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_ROCK_1_3", "", "", 100, 75),
			new bl("BLOCK_ROCK_2_3", "", "", 75, 50),
			new bl("BLOCK_ROCK_3_3", "", "", 50, 25),
			new bl("BLOCK_ROCK_4_3", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 100f, 15f, A_23: false));
		A_0.Add("StoneBlock4", new cb(BlockBasicType.BOX, null, "BLOCK_ROCK_1_4", null, "rock", BlockGroup.UNDEFINED, float.NaN, 4, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_ROCK_1_4", "", "", 100, 75),
			new bl("BLOCK_ROCK_2_4", "", "", 75, 50),
			new bl("BLOCK_ROCK_3_4", "", "", 50, 25),
			new bl("BLOCK_ROCK_4_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 80f, 15f, A_23: false));
		A_0.Add("StoneBlock5", new cb(BlockBasicType.BOX, null, "BLOCK_ROCK_1_5", null, "rock", BlockGroup.UNDEFINED, float.NaN, 5, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_ROCK_1_5", "", "", 100, 75),
			new bl("BLOCK_ROCK_2_5", "", "", 75, 50),
			new bl("BLOCK_ROCK_3_5", "", "", 50, 25),
			new bl("BLOCK_ROCK_4_5", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 140f, 15f, A_23: false));
		A_0.Add("StoneBlock6", new cb(BlockBasicType.BOX, null, "BLOCK_ROCK_1_6", null, "rock", BlockGroup.UNDEFINED, float.NaN, 6, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_ROCK_1_6", "", "", 100, 75),
			new bl("BLOCK_ROCK_2_6", "", "", 75, 50),
			new bl("BLOCK_ROCK_3_6", "", "", 50, 25),
			new bl("BLOCK_ROCK_4_6", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 120f, 15f, A_23: false));
		A_0.Add("StoneBlock7", new cb(BlockBasicType.CIRCLE, null, "BLOCK_ROCK_1_7", null, "rock", BlockGroup.UNDEFINED, float.NaN, 7, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_ROCK_1_7", "", "", 100, 75),
			new bl("BLOCK_ROCK_2_7", "", "", 75, 50),
			new bl("BLOCK_ROCK_3_7", "", "", 50, 25),
			new bl("BLOCK_ROCK_4_7", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 600f, 15f, A_23: false));
		A_0.Add("StoneBlock8", new cb(BlockBasicType.CIRCLE, null, "BLOCK_ROCK_1_8", null, "rock", BlockGroup.UNDEFINED, float.NaN, 8, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_ROCK_1_8", "", "", 100, 75),
			new bl("BLOCK_ROCK_2_8", "", "", 75, 50),
			new bl("BLOCK_ROCK_3_8", "", "", 50, 25),
			new bl("BLOCK_ROCK_4_8", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 300f, 15f, A_23: false));
		A_0.Add("StoneBlock9", new cb(BlockBasicType.BOX, null, "BLOCK_ROCK_4X4_1", null, "rock", BlockGroup.UNDEFINED, float.NaN, 9, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_ROCK_4X4_1", "", "", 100, 75),
			new bl("BLOCK_ROCK_4X4_2", "", "", 75, 50),
			new bl("BLOCK_ROCK_4X4_3", "", "", 50, 25),
			new bl("BLOCK_ROCK_4X4_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 160f, 15f, A_23: false));
		A_0.Add("StoneBlock10", new cb(BlockBasicType.BOX, null, "BLOCK_ROCK_10X1_1", null, "rock", BlockGroup.UNDEFINED, float.NaN, 10, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_ROCK_10X1_1", "", "", 100, 75),
			new bl("BLOCK_ROCK_10X1_2", "", "", 75, 50),
			new bl("BLOCK_ROCK_10X1_3", "", "", 50, 25),
			new bl("BLOCK_ROCK_10X1_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 140f, 15f, A_23: false));
		A_0.Add("StoneBlock11", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[3]
		{
			new Vector2(0f, 0f),
			new Vector2(1f, 1f),
			new Vector2(0f, 1f)
		}, "BLOCK_ROCK_TRIANGLE_L_1", null, "rock", BlockGroup.UNDEFINED, float.NaN, 11, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_ROCK_TRIANGLE_L_1", "", "", 100, 75),
			new bl("BLOCK_ROCK_TRIANGLE_L_2", "", "", 75, 50),
			new bl("BLOCK_ROCK_TRIANGLE_L_3", "", "", 50, 25),
			new bl("BLOCK_ROCK_TRIANGLE_L_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 140f, 15f, A_23: false));
		A_0.Add("StoneBlock12", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[3]
		{
			new Vector2(0.5f, 0f),
			new Vector2(1f, 1f),
			new Vector2(0f, 1f)
		}, "BLOCK_ROCK_TRIANGLE_M_1", null, "rock", BlockGroup.UNDEFINED, float.NaN, 12, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_ROCK_TRIANGLE_M_1", "", "", 100, 75),
			new bl("BLOCK_ROCK_TRIANGLE_M_2", "", "", 75, 50),
			new bl("BLOCK_ROCK_TRIANGLE_M_3", "", "", 50, 25),
			new bl("BLOCK_ROCK_TRIANGLE_M_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 140f, 15f, A_23: false));
		A_0.Add("LightBlock1", new cb(BlockBasicType.BOX, null, "BLOCK_LIGHT_1_1", null, "light", BlockGroup.LIGHT_BLOCK, float.NaN, 1, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_LIGHT_1_1", "", "", 100, 75),
			new bl("BLOCK_LIGHT_2_1", "", "", 75, 50),
			new bl("BLOCK_LIGHT_3_1", "", "", 50, 25),
			new bl("BLOCK_LIGHT_4_1", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.2f, 13f, 2f, A_23: false));
		A_0.Add("LightBlock2", new cb(BlockBasicType.BOX, null, "BLOCK_LIGHT_1_2", null, "light", BlockGroup.LIGHT_BLOCK, float.NaN, 2, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_LIGHT_1_2", "", "", 100, 75),
			new bl("BLOCK_LIGHT_2_2", "", "", 75, 50),
			new bl("BLOCK_LIGHT_3_2", "", "", 50, 25),
			new bl("BLOCK_LIGHT_4_2", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.2f, 26f, 2f, A_23: false));
		A_0.Add("LightBlock3", new cb(BlockBasicType.BOX, null, "BLOCK_LIGHT_1_3", null, "light", BlockGroup.LIGHT_BLOCK, float.NaN, 3, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_LIGHT_1_3", "", "", 100, 75),
			new bl("BLOCK_LIGHT_2_3", "", "", 75, 50),
			new bl("BLOCK_LIGHT_3_3", "", "", 50, 25),
			new bl("BLOCK_LIGHT_4_3", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.2f, 40f, 2f, A_23: false));
		A_0.Add("LightBlock4", new cb(BlockBasicType.BOX, null, "BLOCK_LIGHT_1_4", null, "light", BlockGroup.LIGHT_BLOCK, float.NaN, 4, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_LIGHT_1_4", "", "", 100, 75),
			new bl("BLOCK_LIGHT_2_4", "", "", 75, 50),
			new bl("BLOCK_LIGHT_3_4", "", "", 50, 25),
			new bl("BLOCK_LIGHT_4_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.2f, 33f, 2f, A_23: false));
		A_0.Add("LightBlock5", new cb(BlockBasicType.BOX, null, "BLOCK_LIGHT_1_5", null, "light", BlockGroup.LIGHT_BLOCK, float.NaN, 5, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_LIGHT_1_5", "", "", 100, 75),
			new bl("BLOCK_LIGHT_2_5", "", "", 75, 50),
			new bl("BLOCK_LIGHT_3_5", "", "", 50, 25),
			new bl("BLOCK_LIGHT_4_5", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.2f, 53f, 2f, A_23: false));
		A_0.Add("LightBlock6", new cb(BlockBasicType.BOX, null, "BLOCK_LIGHT_1_6", null, "light", BlockGroup.LIGHT_BLOCK, float.NaN, 6, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_LIGHT_1_6", "", "", 100, 75),
			new bl("BLOCK_LIGHT_2_6", "", "", 75, 50),
			new bl("BLOCK_LIGHT_3_6", "", "", 50, 25),
			new bl("BLOCK_LIGHT_4_6", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.2f, 47f, 2f, A_23: false));
		A_0.Add("LightBlock7", new cb(BlockBasicType.CIRCLE, null, "BLOCK_LIGHT_1_7", null, "light", BlockGroup.LIGHT_BLOCK, float.NaN, 7, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_LIGHT_1_7", "", "", 100, 75),
			new bl("BLOCK_LIGHT_2_7", "", "", 75, 50),
			new bl("BLOCK_LIGHT_3_7", "", "", 50, 25),
			new bl("BLOCK_LIGHT_4_7", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.2f, 125f, 2f, A_23: false));
		A_0.Add("LightBlock8", new cb(BlockBasicType.CIRCLE, null, "BLOCK_LIGHT_1_8", null, "light", BlockGroup.LIGHT_BLOCK, float.NaN, 8, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_LIGHT_1_8", "", "", 100, 75),
			new bl("BLOCK_LIGHT_2_8", "", "", 75, 50),
			new bl("BLOCK_LIGHT_3_8", "", "", 50, 25),
			new bl("BLOCK_LIGHT_4_8", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.2f, 100f, 2f, A_23: false));
		A_0.Add("LightBlock9", new cb(BlockBasicType.BOX, null, "BLOCK_LIGHT_4X4_1", null, "light", BlockGroup.LIGHT_BLOCK, float.NaN, 9, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_LIGHT_4X4_1", "", "", 100, 75),
			new bl("BLOCK_LIGHT_4X4_2", "", "", 75, 50),
			new bl("BLOCK_LIGHT_4X4_3", "", "", 50, 25),
			new bl("BLOCK_LIGHT_4X4_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.2f, 70f, 2f, A_23: false));
		A_0.Add("LightBlock10", new cb(BlockBasicType.BOX, null, "BLOCK_LIGHT_10X1_1", null, "light", BlockGroup.LIGHT_BLOCK, float.NaN, 10, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_LIGHT_10X1_1", "", "", 100, 75),
			new bl("BLOCK_LIGHT_10X1_2", "", "", 75, 50),
			new bl("BLOCK_LIGHT_10X1_3", "", "", 50, 25),
			new bl("BLOCK_LIGHT_10X1_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.2f, 65f, 2f, A_23: false));
		A_0.Add("LightBlock11", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[3]
		{
			new Vector2(0f, 0f),
			new Vector2(1f, 1f),
			new Vector2(0f, 1f)
		}, "BLOCK_LIGHT_TRIANGLE_L_1", null, "light", BlockGroup.LIGHT_BLOCK, float.NaN, 11, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_LIGHT_TRIANGLE_L_1", "", "", 100, 75),
			new bl("BLOCK_LIGHT_TRIANGLE_L_2", "", "", 75, 50),
			new bl("BLOCK_LIGHT_TRIANGLE_L_3", "", "", 50, 25),
			new bl("BLOCK_LIGHT_TRIANGLE_L_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.2f, 53f, 2f, A_23: false));
		A_0.Add("LightBlock12", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[3]
		{
			new Vector2(0.5f, 0f),
			new Vector2(1f, 1f),
			new Vector2(0f, 1f)
		}, "BLOCK_LIGHT_TRIANGLE_M_1", null, "light", BlockGroup.LIGHT_BLOCK, float.NaN, 12, A_8: true, 0, new bl[4]
		{
			new bl("BLOCK_LIGHT_TRIANGLE_M_1", "", "", 100, 75),
			new bl("BLOCK_LIGHT_TRIANGLE_M_2", "", "", 75, 50),
			new bl("BLOCK_LIGHT_TRIANGLE_M_3", "", "", 50, 25),
			new bl("BLOCK_LIGHT_TRIANGLE_M_4", "", "", 25, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.2f, 48f, 2f, A_23: false));
		A_0.Add("DecorationSpotsTheme01_01", new cb(BlockBasicType.BOX, null, "DECORATION_SPOTS_THEME1_01", null, "decoration", BlockGroup.DECORATION, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationSpotsTheme01_02", new cb(BlockBasicType.BOX, null, "DECORATION_SPOTS_THEME1_02", null, "decoration", BlockGroup.DECORATION, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationSpotsTheme01_03", new cb(BlockBasicType.BOX, null, "DECORATION_SPOTS_THEME1_03", null, "decoration", BlockGroup.DECORATION, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationSpotsTheme02_01", new cb(BlockBasicType.BOX, null, "DECORATION_SPOTS_THEME2_01", null, "decoration", BlockGroup.DECORATION, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationSpotsTheme02_02", new cb(BlockBasicType.BOX, null, "DECORATION_SPOTS_THEME2_02", null, "decoration", BlockGroup.DECORATION, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationSpotsTheme02_03", new cb(BlockBasicType.BOX, null, "DECORATION_SPOTS_THEME2_03", null, "decoration", BlockGroup.DECORATION, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationSpotsTheme03_01", new cb(BlockBasicType.BOX, null, "DECORATION_SPOTS_THEME3_01", null, "decoration", BlockGroup.DECORATION, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationSpotsTheme03_02", new cb(BlockBasicType.BOX, null, "DECORATION_SPOTS_THEME3_02", null, "decoration", BlockGroup.DECORATION, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationSpotsTheme03_03", new cb(BlockBasicType.BOX, null, "DECORATION_SPOTS_THEME3_03", null, "decoration", BlockGroup.DECORATION, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationSkull01", new cb(BlockBasicType.BOX, null, "DECORATION_SKULL01", null, "decoration", BlockGroup.DECORATION, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationSkull02", new cb(BlockBasicType.BOX, null, "DECORATION_SKULL02", null, "decoration", BlockGroup.DECORATION, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationBone01", new cb(BlockBasicType.BOX, null, "DECORATION_BONE01", null, "decoration", BlockGroup.DECORATION, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationBone02", new cb(BlockBasicType.BOX, null, "DECORATION_BONE02", null, "decoration", BlockGroup.DECORATION, float.NaN, 7, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationBone03", new cb(BlockBasicType.BOX, null, "DECORATION_BONE03", null, "decoration", BlockGroup.DECORATION, float.NaN, 8, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationBone04", new cb(BlockBasicType.BOX, null, "DECORATION_BONE04", null, "decoration", BlockGroup.DECORATION, float.NaN, 9, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationBoneSet01", new cb(BlockBasicType.BOX, null, "DECORATION_BONESET01", null, "decoration", BlockGroup.DECORATION, float.NaN, 10, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationBoneSet02", new cb(BlockBasicType.BOX, null, "DECORATION_BONESET02", null, "decoration", BlockGroup.DECORATION, float.NaN, 11, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationEstrade01", new cb(BlockBasicType.BOX, null, "ESTRADE_FLAG", null, "decoration", BlockGroup.DECORATION, float.NaN, 12, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("DecorationEstrade02", new cb(BlockBasicType.BOX, null, "ESTRADE_THEATER", null, "decoration", BlockGroup.DECORATION, float.NaN, 13, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme01_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme01_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme01_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme01_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme01_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme01_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme02_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_2", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme02_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_2", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme02_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_2", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme02_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_2", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme02_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_2", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme02_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_2", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme03_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme03_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme03_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme03_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme03_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme03_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme04_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_4", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme04_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_4", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme04_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_4", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme04_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_4", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme04_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_4", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme04_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_4", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme05_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_5", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme05_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_5", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme05_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_5", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme05_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_5", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme05_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_5", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme05_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_5", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme06_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_6", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme06_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_6", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme06_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_6", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme06_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_6", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme06_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_6", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme06_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_6", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme07_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_7", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme07_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_7", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme07_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_7", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme07_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_7", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme07_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_7", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme07_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_7", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme08_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_8", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme08_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_8", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme08_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_8", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme08_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_8", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme08_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_8", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme08_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_8", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme09_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme09_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme09_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme09_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme09_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme09_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme10_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_2", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme10_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_2", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme10_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_2", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme10_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_2", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme10_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_2", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme10_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_2", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme11_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme11_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme11_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme11_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme11_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme11_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme12_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme12_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme12_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme12_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme12_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme12_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_3", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme13_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_4", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme13_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_4", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme13_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_4", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme13_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_4", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme13_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_4", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme13_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_4", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme14_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_6", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme14_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_6", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme14_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_6", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme14_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_6", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme14_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_6", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme14_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_6", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme15_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_7", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme15_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_7", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme15_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_7", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme15_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_7", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme15_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_7", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme15_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_7", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme16_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_9", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme16_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_9", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme16_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_9", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme16_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_9", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme16_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_9", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme16_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_9", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme17_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme17_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme17_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme17_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme17_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockTheme17_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "THEME_GROUND_TEXTURE_1", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockThemeCave_01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", "INGAME_THEME_GROUND_CAVE", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockThemeCave_02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", "INGAME_THEME_GROUND_CAVE", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockThemeCave_03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", "INGAME_THEME_GROUND_CAVE", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockThemeCave_04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", "INGAME_THEME_GROUND_CAVE", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockThemeCave_05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", "INGAME_THEME_GROUND_CAVE", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticBlockThemeCave_06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", "INGAME_THEME_GROUND_CAVE", "immovable", BlockGroup.STATIC_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("ShootingPlatform01", new cb(BlockBasicType.BOX, null, "SHOOTING_PLATFORM", null, "immovable", BlockGroup.PLATFORM, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("Estrade01", new cb(BlockBasicType.BOX, null, "ESTRADE_01", null, "immovable", BlockGroup.PLATFORM, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("Estrade02", new cb(BlockBasicType.BOX, null, "ESTRADE_02", null, "immovable", BlockGroup.PLATFORM, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("Estrade03", new cb(BlockBasicType.BOX, null, "ESTRADE_03", null, "immovable", BlockGroup.PLATFORM, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("Estrade04", new cb(BlockBasicType.BOX, null, "ESTRADE_04", null, "immovable", BlockGroup.PLATFORM, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("ExtraBlockToilet", new cb(BlockBasicType.BOX, null, "BLOCK_EXTRA_TOILET", null, "extras", BlockGroup.EXTRA, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 40f, 5f, A_23: false));
		A_0.Add("ExtraBlockFlag01", new cb(BlockBasicType.BOX, null, "BLOCK_EXTRA_FLAG_01", null, "extras", BlockGroup.EXTRA, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 40f, 5f, A_23: false));
		A_0.Add("ExtraBlockFlag02", new cb(BlockBasicType.BOX, null, "BLOCK_EXTRA_FLAG_02", null, "extras", BlockGroup.EXTRA, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 40f, 5f, A_23: false));
		A_0.Add("ExtraBlockTNT", new cb(BlockBasicType.BOX, null, "BLOCK_EXTRA_TNT", null, "extras", BlockGroup.EXTRA, float.NaN, 4, A_8: true, 0, null, 10f, 30000f, 5f, 150f, A_15: true, 0, null, 0.75f, 0.7f, 0.4f, 10f, 1f, A_23: false));
		A_0.Add("ExtraBlockDice", new cb(BlockBasicType.BOX, null, "BLOCK_EXTRA_DICE_6", null, "extras", BlockGroup.EXTRA, float.NaN, 5, A_8: true, 0, new bl[6]
		{
			new bl("BLOCK_EXTRA_DICE_6", "", "", 100, 84),
			new bl("BLOCK_EXTRA_DICE_5", "", "", 84, 68),
			new bl("BLOCK_EXTRA_DICE_4", "", "", 68, 52),
			new bl("BLOCK_EXTRA_DICE_3", "", "", 52, 36),
			new bl("BLOCK_EXTRA_DICE_2", "", "", 36, 20),
			new bl("BLOCK_EXTRA_DICE_1", "", "", 20, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 30f, 1f, A_23: false));
		A_0.Add("ExtraBlockStairs", new cb(BlockBasicType.BOX, null, "ESTRADE_STAIRS", null, "extras", BlockGroup.EXTRA, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 40f, 5f, A_23: false));
		A_0.Add("SpecialBlockSwing", new cb(BlockBasicType.BOX, null, "SWING_HOLDER_01", null, "immovable", BlockGroup.EXTRA, float.NaN, 7, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("SpecialBlockStart", new cb(BlockBasicType.BOX, null, "SWING_BASKET_01", null, "extras", BlockGroup.EXTRA, float.NaN, 8, A_8: false, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 10f, 1000000f, A_23: false));
		A_0.Add("ExtraPoleYellow", new cb(BlockBasicType.BOX, null, "POLE_YELLOW", null, "immovable", BlockGroup.EXTRA, float.NaN, 9, A_8: false, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 10f, 1000000f, A_23: false));
		A_0.Add("ExtraPoleRed", new cb(BlockBasicType.BOX, null, "POLE_RED", null, "immovable", BlockGroup.EXTRA, float.NaN, 10, A_8: false, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 10f, 1000000f, A_23: false));
		A_0.Add("ExtraTire01", new cb(BlockBasicType.CIRCLE, null, "BLOCK_TIRE_01", null, "extras", BlockGroup.EXTRA, float.NaN, 11, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 200f, 5f, A_23: false));
		A_0.Add("ExtraTire02", new cb(BlockBasicType.CIRCLE, null, "BLOCK_TIRE_02", null, "extras", BlockGroup.EXTRA, float.NaN, 12, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 200f, 5f, A_23: false));
		A_0.Add("ExtraTire03", new cb(BlockBasicType.CIRCLE, null, "BLOCK_TIRE_03", null, "extras", BlockGroup.EXTRA, float.NaN, 13, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 200f, 5f, A_23: false));
		A_0.Add("ExtraDonut01", new cb(BlockBasicType.CIRCLE, null, "BLOCK_DONUT", null, "extras", BlockGroup.EXTRA, float.NaN, 14, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 50f, 5f, A_23: false));
		A_0.Add("ExtraMelon", new cb(BlockBasicType.CIRCLE, null, "BLOCK_WATERMELON", null, "extras", BlockGroup.EXTRA, float.NaN, 15, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 40f, 5f, A_23: false));
		A_0.Add("ExtraHam", new cb(BlockBasicType.CIRCLE, null, "BLOCK_HAM", null, "extras", BlockGroup.EXTRA, float.NaN, 16, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 60f, 5f, A_23: false));
		A_0.Add("ExtraApple", new cb(BlockBasicType.CIRCLE, null, "BLOCK_APPLE", null, "extras", BlockGroup.EXTRA, float.NaN, 17, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 30f, 5f, A_23: false));
		A_0.Add("ExtraStrawberry", new cb(BlockBasicType.CIRCLE, null, "BLOCK_STRAWBERRY", null, "extras", BlockGroup.EXTRA, float.NaN, 18, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 30f, 5f, A_23: false));
		A_0.Add("ExtraBanana", new cb(BlockBasicType.BOX, null, "BLOCK_BANANA", null, "extras", BlockGroup.EXTRA, float.NaN, 19, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 30f, 5f, A_23: false));
		A_0.Add("ExtraTreasureChest", new cb(BlockBasicType.BOX, null, "BLOCK_TREASURE_CHEST", null, "extras", BlockGroup.EXTRA, float.NaN, 20, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 20f, 5f, A_23: false));
		A_0.Add("ExtraPillar", new cb(BlockBasicType.BOX, null, "BLOCK_PILLAR", null, "extras", BlockGroup.EXTRA, float.NaN, 21, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 10f, 0.7f, 0.4f, 120f, 40f, A_23: false));
		A_0.Add("ExtraBeachBall", new cb(BlockBasicType.CIRCLE, null, "BLOCK_BEACHBALL", null, "extras", BlockGroup.EXTRA, float.NaN, 22, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 15f, 5f, A_23: false));
		A_0.Add("ExtraBlockSmiley", new cb(BlockBasicType.CIRCLE, null, "BLOCK_SMILEY_1", null, "extras", BlockGroup.EXTRA, float.NaN, 23, A_8: true, 0, new bl[2]
		{
			new bl("BLOCK_SMILEY_1", "", "", 100, 50),
			new bl("BLOCK_SMILEY_3", "", "", 50, -1000)
		}, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 25f, 5f, A_23: false));
		A_0.Add("ExtraHolyGrail", new cb(BlockBasicType.BOX, null, "BLOCK_HOLYGRAIL", null, "extras", BlockGroup.EXTRA, float.NaN, 24, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 25f, 5f, A_23: false));
		A_0.Add("ExtraDiamond", new cb(BlockBasicType.CIRCLE, null, "BLOCK_DIAMOND", null, "extras", BlockGroup.EXTRA, float.NaN, 25, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 25f, 5f, A_23: false));
		A_0.Add("ExtraRubberDuck", new cb(BlockBasicType.CIRCLE, null, "BLOCK_RUBBERDUCK", null, "extras", BlockGroup.EXTRA, float.NaN, 26, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 25f, 5f, A_23: false));
		A_0.Add("ExtraStolenEgg", new cb(BlockBasicType.CIRCLE, null, "BLOCK_STOLEN_EGG", null, "extras", BlockGroup.EXTRA, float.NaN, 27, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 2000f, 20000f, A_23: false));
		A_0.Add("ExtraStrongBall", new cb(BlockBasicType.CIRCLE, null, "BLOCK_STEEL_BALL", null, "rock", BlockGroup.EXTRA, float.NaN, 28, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 4f, 4f, 0.1f, 5000f, 2000f, A_23: false));
		A_0.Add("ExtraRubberBall", new cb(BlockBasicType.CIRCLE, null, "BLOCK_BEACHBALL", null, "rubber", BlockGroup.EXTRA, float.NaN, 29, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 1.1f, 1000f, 50f, A_23: false));
		A_0.Add("ExtraTrampoline", new cb(BlockBasicType.CIRCLE, null, "BLOCK_SUPER_BALL", null, "rubber", BlockGroup.EXTRA, float.NaN, 30, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 5.5f, 1000f, 1000f, A_23: false));
		A_0.Add("ExtraBlueBird", new cb(BlockBasicType.CIRCLE, null, "BIRD_BLUE", null, "extras", BlockGroup.EXTRA, 0.6f, 31, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 8f, 0.3f, 0.25f, 3000f, 2000f, A_23: false));
		A_0.Add("ExtraTrampoline2", new cb(BlockBasicType.BOX, null, "BLOCK_TRAMPOLINE_01", null, "immovableRubber", BlockGroup.EXTRA, float.NaN, 32, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 1.1f, 1000f, 1000f, A_23: false));
		A_0.Add("ExtraGoldenEgg", new cb(BlockBasicType.CIRCLE, null, "BLOCK_GOLDEN_EGG", null, "extras", BlockGroup.EXTRA, float.NaN, 33, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 5f, 1f, A_23: false));
		A_0.Add("ExtraRopeThick01", new cb(BlockBasicType.BOX, null, "BLOCK_ROPE_THICK_1", null, "extras", BlockGroup.EXTRA, float.NaN, 34, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0.75f, 0.7f, 0.4f, 5f, 1f, A_23: false));
		A_0.Add("ExtraRopeThin01", new cb(BlockBasicType.BOX, null, "BLOCK_ROPE_THIN_1", null, "extras", BlockGroup.EXTRA, float.NaN, 35, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0.75f, 0.7f, 0.4f, 5f, 1f, A_23: false));
		A_0.Add("ExtraRopeThin02", new cb(BlockBasicType.BOX, null, "BLOCK_ROPE_THIN_2", null, "extras", BlockGroup.EXTRA, float.NaN, 36, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0.75f, 0.7f, 0.4f, 5f, 1f, A_23: false));
		A_0.Add("ExtraBoomerangBird", new cb(BlockBasicType.CIRCLE, null, "BIRD_BOOMERANG_STILL", null, "extras", BlockGroup.EXTRA, 1.1f, 37, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 8f, 0.3f, 0.25f, 3000f, 2000f, A_23: false));
		A_0.Add("BlockCarpet", new cb(BlockBasicType.BOX, null, "BLOCK_CARPET", null, "extras", BlockGroup.EXTRA, float.NaN, 38, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0.75f, 0.7f, 0.4f, 40f, 5f, A_23: false));
		A_0.Add("ExtraHelmetSmall", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[6]
		{
			new Vector2(0.2f, 0.3f),
			new Vector2(0.4f, 0.2f),
			new Vector2(0.6f, 0.2f),
			new Vector2(0.8f, 0.3f),
			new Vector2(0.8f, 0.5f),
			new Vector2(0.2f, 0.5f)
		}, "HELMET_SMALL", null, "extras", BlockGroup.EXTRA, float.NaN, 39, A_8: true, 5, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 50, null, 0.3f, 1f, 0.1f, 10f, 300f, A_23: false));
		A_0.Add("ExtraHelmetSmall2", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[6]
		{
			new Vector2(0.2f, 0.2f),
			new Vector2(0.4f, 0.1f),
			new Vector2(0.8f, 0.1f),
			new Vector2(1f, 0.2f),
			new Vector2(1f, 0.4f),
			new Vector2(0.2f, 0.4f)
		}, "BLOCK_RUBBERDUCK", null, "extras", BlockGroup.EXTRA, float.NaN, 40, A_8: true, 5, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 50, null, 0.5f, 1f, 0f, 10f, 300f, A_23: false));
		A_0.Add("ExtraHelmetBig", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[6]
		{
			new Vector2(0.2f, 0.3f),
			new Vector2(0.4f, 0.2f),
			new Vector2(0.6f, 0.2f),
			new Vector2(0.8f, 0.3f),
			new Vector2(0.8f, 0.5f),
			new Vector2(0.2f, 0.5f)
		}, "HELMET_BIG", null, "extras", BlockGroup.EXTRA, float.NaN, 41, A_8: true, 5, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 50, null, 0.5f, 1f, 0f, 10f, 300f, A_23: false));
		A_0.Add("ExtraHelmetBig2", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[6]
		{
			new Vector2(0.2f, 0.2f),
			new Vector2(0.4f, 0.1f),
			new Vector2(0.8f, 0.1f),
			new Vector2(1f, 0.2f),
			new Vector2(1f, 0.4f),
			new Vector2(0.2f, 0.4f)
		}, "BIRD_BOOMERANG_STILL", null, "extras", BlockGroup.EXTRA, float.NaN, 42, A_8: true, 5, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 50, null, 0.5f, 1f, 0f, 10f, 300f, A_23: false));
		A_0.Add("ExtraHelmetBoss", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[6]
		{
			new Vector2(0.2f, 0.3f),
			new Vector2(0.4f, 0.2f),
			new Vector2(0.6f, 0.2f),
			new Vector2(0.8f, 0.3f),
			new Vector2(0.8f, 0.5f),
			new Vector2(0.2f, 0.5f)
		}, "HELMET_BOSS", null, "extras", BlockGroup.EXTRA, float.NaN, 43, A_8: true, 5, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 50, null, 0.5f, 1f, 0f, 10f, 300f, A_23: false));
		A_0.Add("ExtraCowboyHelmet_1", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[6]
		{
			new Vector2(0.3f, 0.3f),
			new Vector2(0.4f, 0.2f),
			new Vector2(0.6f, 0.2f),
			new Vector2(0.65f, 0.3f),
			new Vector2(0.65f, 0.5f),
			new Vector2(0.3f, 0.5f)
		}, "COWBOY_HAT_BIG_1", null, "extras", BlockGroup.EXTRA, float.NaN, 44, A_8: true, 5, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0.5f, 1f, 0f, 10f, 20f, A_23: false));
		A_0.Add("ExtraCowboyHelmetSmall_1", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[6]
		{
			new Vector2(0.3f, 0.3f),
			new Vector2(0.4f, 0.2f),
			new Vector2(0.6f, 0.2f),
			new Vector2(0.65f, 0.3f),
			new Vector2(0.65f, 0.5f),
			new Vector2(0.3f, 0.5f)
		}, "COWBOY_HAT_SMALL_1", null, "extras", BlockGroup.EXTRA, float.NaN, 45, A_8: true, 5, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0.3f, 1f, 0.1f, 10f, 10f, A_23: false));
		A_0.Add("ExtraSheriffHat_1", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[6]
		{
			new Vector2(0.35f, 0.3f),
			new Vector2(0.4f, 0.2f),
			new Vector2(0.6f, 0.2f),
			new Vector2(0.7f, 0.3f),
			new Vector2(0.7f, 0.6f),
			new Vector2(0.35f, 0.6f)
		}, "SHERIFF_HAT_1", null, "extras", BlockGroup.EXTRA, float.NaN, 46, A_8: true, 5, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0.5f, 1f, 0f, 10f, 20f, A_23: false));
		A_0.Add("ExtraSheriffHat_2", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[6]
		{
			new Vector2(0.35f, 0.3f),
			new Vector2(0.4f, 0.2f),
			new Vector2(0.6f, 0.2f),
			new Vector2(0.7f, 0.3f),
			new Vector2(0.7f, 0.6f),
			new Vector2(0.35f, 0.6f)
		}, "SHERIFF_HAT_2", null, "extras", BlockGroup.EXTRA, float.NaN, 47, A_8: true, 5, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0.5f, 1f, 0f, 10f, 20f, A_23: false));
		A_0.Add("ExtraBanditoHat_1", new cb(BlockBasicType.POLYGON, (Vector2[])(object)new Vector2[6]
		{
			new Vector2(0.4f, 0.3f),
			new Vector2(0.45f, 0.2f),
			new Vector2(0.55f, 0.2f),
			new Vector2(0.6f, 0.3f),
			new Vector2(0.6f, 0.7f),
			new Vector2(0.4f, 0.7f)
		}, "BANDITO_HAT_1", null, "extras", BlockGroup.EXTRA, float.NaN, 48, A_8: true, 5, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0.5f, 1f, 0f, 10f, 30f, A_23: false));
		A_0.Add("ExtraSuperBowl", new cb(BlockBasicType.CIRCLE, null, "B_EGG_SUPER_BOWL", null, "extras", BlockGroup.EXTRA, float.NaN, 49, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.7f, 0.4f, 5f, 1f, A_23: false));
		A_0.Add("StaticFragileBlock01", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_01", null, "immovableFragile", BlockGroup.STATIC_FRAGILE_BLOCK, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 50, null, 0f, 0.8f, 0f, 2f, 1f, A_23: false));
		A_0.Add("StaticFragileBlock02", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_02", null, "immovableFragile", BlockGroup.STATIC_FRAGILE_BLOCK, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 50, null, 0f, 0.8f, 0f, 2f, 1f, A_23: false));
		A_0.Add("StaticFragileBlock03", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_03", null, "immovableFragile", BlockGroup.STATIC_FRAGILE_BLOCK, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 50, null, 0f, 0.8f, 0f, 2f, 1f, A_23: false));
		A_0.Add("StaticFragileBlock04", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_04", null, "immovableFragile", BlockGroup.STATIC_FRAGILE_BLOCK, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 50, null, 0f, 0.8f, 0f, 2f, 1f, A_23: false));
		A_0.Add("StaticFragileBlock05", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_05", null, "immovableFragile", BlockGroup.STATIC_FRAGILE_BLOCK, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 50, null, 0f, 0.8f, 0f, 2f, 1f, A_23: false));
		A_0.Add("StaticFragileBlock06", new cb(BlockBasicType.BOX, null, "GROUND_BLOCK_06", null, "immovableFragile", BlockGroup.STATIC_FRAGILE_BLOCK, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 50, null, 0f, 0.8f, 0f, 2f, 1f, A_23: false));
		A_0.Add("StaticBalloon01", new cb(BlockBasicType.BOX, null, "BLOCK_PIG_BALLOON_1", null, "clouds", BlockGroup.CLOUD, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0f, 0.8f, 0f, 0.1f, 1f, A_23: false));
		A_0.Add("StaticBalloon02", new cb(BlockBasicType.BOX, null, "BLOCK_PIG_BALLOON_2", null, "clouds", BlockGroup.CLOUD, float.NaN, 2, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0f, 0.8f, 0f, 0.1f, 1f, A_23: false));
		A_0.Add("StaticBalloon03", new cb(BlockBasicType.BOX, null, "BLOCK_BALLOON_1", null, "clouds", BlockGroup.CLOUD, float.NaN, 3, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0f, 0.8f, 0f, 0.1f, 1f, A_23: false));
		A_0.Add("StaticBalloon04", new cb(BlockBasicType.BOX, null, "BLOCK_BALLOON_2", null, "clouds", BlockGroup.CLOUD, float.NaN, 4, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0f, 0.8f, 0f, 0.1f, 1f, A_23: false));
		A_0.Add("StaticBalloon05", new cb(BlockBasicType.BOX, null, "BLOCK_BALLOON_3", null, "clouds", BlockGroup.CLOUD, float.NaN, 5, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 100, null, 0f, 0.8f, 0f, 0.1f, 1f, A_23: false));
		A_0.Add("StaticCloud01", new cb(BlockBasicType.BOX, null, "BLOCK_BANANA", null, "immovable", BlockGroup.CLOUD, float.NaN, 6, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticCloud02", new cb(BlockBasicType.BOX, null, "BLOCK_BANANA", null, "immovable", BlockGroup.CLOUD, float.NaN, 7, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticCloud03", new cb(BlockBasicType.BOX, null, "BLOCK_BANANA", null, "immovable", BlockGroup.CLOUD, float.NaN, 8, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("StaticCloud04", new cb(BlockBasicType.BOX, null, "BLOCK_BANANA", null, "immovable", BlockGroup.CLOUD, float.NaN, 9, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
		A_0.Add("Ground", new cb(BlockBasicType.BOX, null, null, null, "staticGround", BlockGroup.GROUND, float.NaN, 1, A_8: true, 0, null, float.NaN, float.NaN, float.NaN, float.NaN, A_15: false, 0, null, 0f, 0.8f, 0f, 30f, 100000f, A_23: false));
	}

	private void d(Dictionary<string, be> A_0)
	{
		A_0.Add("bird_01_collision", new be(new string[4] { "bird 01 collision a1", "bird 01 collision a2", "bird 01 collision a3", "bird 01 collision a4" }));
		A_0.Add("bird_02_collision", new be(new string[5] { "bird 02 collision a1", "bird 02 collision a2", "bird 02 collision a3", "bird 02 collision a4", "bird 02 collision a5" }));
		A_0.Add("bird_03_collision", new be(new string[5] { "bird 03 collision a1", "bird 03 collision a2", "bird 03 collision a3", "bird 03 collision a4", "bird 03 collision a5" }));
		A_0.Add("bird_04_collision", new be(new string[4] { "bird 04 collision a1", "bird 04 collision a2", "bird 04 collision a3", "bird 04 collision a4" }));
		A_0.Add("bird_05_collision", new be(new string[5] { "bird 05 collision a1", "bird 05 collision a2", "bird 05 collision a3", "bird 05 collision a4", "bird 05 collision a5" }));
		A_0.Add("big_brother_collision", new be(new string[4] { "bird 01 collision a1_low", "bird 01 collision a2_low", "bird 01 collision a3_low", "bird 01 collision a4_low" }));
		A_0.Add("bird_next", new be(new string[3] { "bird next a1", "bird next a2", "bird next a3" }));
		A_0.Add("bird_next_military", new be(new string[3] { "bird next military a1", "bird next military a2", "bird next military a3" }));
		A_0.Add("bird_shot", new be(new string[3] { "bird shot a1", "bird shot a2", "bird shot a3" }));
		A_0.Add("level_clear_military", new be(new string[2] { "level clear military a1", "level clear military a2" }));
		A_0.Add("level_failed_piglets", new be(new string[2] { "level failed piglets a1", "level failed piglets a2" }));
		A_0.Add("level_start_military", new be(new string[2] { "level start military a1", "level start military a2" }));
		A_0.Add("light_collision", new be(new string[8] { "light collision a1", "light collision a2", "light collision a3", "light collision a4", "light collision a5", "light collision a6", "light collision a7", "light collision a8" }));
		A_0.Add("light_damage", new be(new string[3] { "light damage a1", "light damage a2", "light damage a3" }));
		A_0.Add("light_destroyed", new be(new string[3] { "light destroyed a1", "light destroyed a2", "light destroyed a3" }));
		A_0.Add("piglette_collision", new be(new string[8] { "piglette collision a1", "piglette collision a2", "piglette collision a3", "piglette collision a4", "piglette collision a5", "piglette collision a6", "piglette collision a7", "piglette collision a8" }));
		A_0.Add("piglette_damage", new be(new string[8] { "piglette damage a1", "piglette damage a2", "piglette damage a3", "piglette damage a4", "piglette damage a5", "piglette damage a6", "piglette damage a7", "piglette damage a8" }));
		A_0.Add("rock_collision", new be(new string[5] { "rock collision a1", "rock collision a2", "rock collision a3", "rock collision a4", "rock collision a5" }));
		A_0.Add("rock_damage", new be(new string[3] { "rock damage a1", "rock damage a2", "rock damage a3" }));
		A_0.Add("rock_destroyed", new be(new string[3] { "rock destroyed a1", "rock destroyed a2", "rock destroyed a3" }));
		A_0.Add("wood_collision", new be(new string[6] { "wood collision a1", "wood collision a2", "wood collision a3", "wood collision a4", "wood collision a5", "wood collision a6" }));
		A_0.Add("wood_damage", new be(new string[3] { "wood damage a1", "wood damage a2", "wood damage a3" }));
		A_0.Add("wood_destroyed", new be(new string[3] { "wood destroyed a1", "wood destroyed a2", "wood destroyed a3" }));
		A_0.Add("bird_misc", new be(new string[12]
		{
			"bird_misc_a1", "bird_misc_a2", "bird_misc_a3", "bird_misc_a4", "bird_misc_a5", "bird_misc_a6", "bird_misc_a7", "bird_misc_a8", "bird_misc_a9", "bird_misc_a10",
			"bird_misc_a11", "bird_misc_a12"
		}));
		A_0.Add("piglette", new be(new string[10] { "piglette_a1", "piglette_a2", "piglette_a3", "piglette_a4", "piglette_a5", "piglette_a8", "piglette_a9", "piglette_a10", "piglette_a11", "piglette_a12" }));
		A_0.Add("red_special", new be(new string[3] { "red_special_1", "red_special_2", "red_special_3" }));
		A_0.Add("big_brother_special", new be(new string[1] { "big_brother_special_1" }));
		A_0.Add("pig_accordion", new be(new string[8] { "pig_singing_1", "pig_singing_2", "pig_singing_3", "pig_singing_4", "pig_singing_5", "pig_singing_6", "pig_singing_7", "pig_singing_8" }));
	}

	private void d(Dictionary<string, cv> A_0)
	{
		A_0.Add("wood", new cv(MaterialType.WOOD, 60f, 2.5f, 4f, 0.2f, 1.5f, A_6: false, "woodenBuff", "wood_collision", "wood_damage", "wood_destroyed", "wood_rolling"));
		A_0.Add("rock", new cv(MaterialType.ROCK, 120f, 15f, 4f, 0.1f, 4f, A_6: false, "rockBuff", "rock_collision", "rock_damage", "rock_destroyed", "rock_rolling"));
		A_0.Add("light", new cv(MaterialType.LIGHT, 40f, 2f, 0.7f, 0.2f, 0.75f, A_6: false, "lightBuff", "light_collision", "light_damage", "light_destroyed", "light_rolling"));
		A_0.Add("piglette", new cv(MaterialType.PIGLETTE, 10f, 1f, 0.7f, 0.05f, 2f, A_6: false, "smokeBuff", "piglette_collision", "piglette_damage", "piglette_destroyed", null));
		A_0.Add("staticGround", new cv(MaterialType.STATIC_GROUND, 30f, 100000f, 0.8f, 0f, 0f, A_6: false, "smokeBuff", "ground_collision", null, null, null));
		A_0.Add("immovable", new cv(MaterialType.IMMOVABLE, 30f, 100000f, 0.8f, 0f, 0f, A_6: false, "smokeBuff", "ground_collision", null, null, null));
		A_0.Add("immovableFragile", new cv(MaterialType.IMMOVABLE_FRAGILE, 2f, 1f, 0.8f, 0f, 0f, A_6: false, null, "ground_collision", null, null, null));
		A_0.Add("clouds", new cv(MaterialType.CLOUDS, 0.1f, 1f, 0.8f, 0f, 0f, A_6: false, "smokeBuff", "ground_collision", null, "balloon_pop", null));
		A_0.Add("immovableRubber", new cv(MaterialType.IMMOVABLE_RUBBER, 30f, 100000f, 0.8f, 0f, 0f, A_6: false, "smokeBuff", "trampoline", null, null, null));
		A_0.Add("extras", new cv(MaterialType.EXTRAS, 40f, 5f, 0.7f, 0.4f, 0.75f, A_6: false, "smokeBuff", "ground_collision", null, null, null));
		A_0.Add("halloween", new cv(MaterialType.UNDEFINED, 40f, 5f, 0.7f, 0.4f, 1f, A_6: false, "pumpkinBuff", "ground_collision", null, "halloween_destroyed", null));
		A_0.Add("pumpkin", new cv(MaterialType.UNDEFINED, 40f, 5f, 0.7f, 0.4f, 1f, A_6: false, "pumpkinBuff", "ground_collision", null, "pumpkin_destroyed", null));
		A_0.Add("lantern", new cv(MaterialType.UNDEFINED, 20f, 5f, 0.7f, 0.4f, 0.75f, A_6: false, "flameBuff", "light_collision", null, "lantern_break_a1", null));
		A_0.Add("rubber", new cv(MaterialType.RUBBER, 40f, 5f, 0.7f, 0.4f, 0.75f, A_6: false, "smokeBuff", "ball_bounce", null, null, null));
		A_0.Add("decoration", new cv(MaterialType.DECORATION, 30f, 100000f, 0.8f, 0f, 0f, A_6: false, null, null, null, null, null));
		A_0.Add("common", new cv(MaterialType.UNDEFINED, 1f, 1f, 0.7f, 0.2f, 0.75f, A_6: false, "lightBuff", null, null, null, null));
	}

	private void d(Dictionary<string, a9> A_0)
	{
		A_0.Add("DefaultDamageFactors", new a9(new b5(1f, 1f, 1f, 0f, 0f), new b5(1f, 1f, 1f, 1f, float.NaN)));
		A_0.Add("BlueBirdDamageFactors", new a9(new b5(1f, 1f, 2.9f, 0f, 0f), new b5(1f, 1f, 1.9f, 1f, float.NaN)));
		A_0.Add("YellowBirdDamageFactors", new a9(new b5(2.4f, 1f, 1f, 0f, 0f), new b5(1f, 1f, 1f, 1f, float.NaN)));
		A_0.Add("BlackBirdDamageFactors", new a9(new b5(1f, 4f, 1f, 0f, 0f), new b5(1f, 1f, 1f, 1f, float.NaN)));
		A_0.Add("RedBigBirdDamageFactors", new a9(new b5(0.3f, 0.3f, 0.3f, 0f, 0f), new b5(1.8f, 1.8f, 1.8f, 1f, float.NaN)));
		A_0.Add("BoomerangBirdDamageFactors", new a9(new b5(1.6f, 0.8f, 1.4f, 0f, 0f), new b5(1.3f, 1f, 1.3f, 1f, float.NaN)));
		A_0.Add("MightyEagleBirdDamageFactors", new a9(new b5(1000000f, 1000000f, 1000000f, 1000000f, 0f), new b5(555f, 555f, 555f, 555f, float.NaN)));
	}

	private void d(Dictionary<string, a2> A_0)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1185: Unknown result type (might be due to invalid IL or missing references)
		//IL_1195: Unknown result type (might be due to invalid IL or missing references)
		//IL_1249: Unknown result type (might be due to invalid IL or missing references)
		//IL_1259: Unknown result type (might be due to invalid IL or missing references)
		//IL_1316: Unknown result type (might be due to invalid IL or missing references)
		//IL_1326: Unknown result type (might be due to invalid IL or missing references)
		A_0.Add("theme1", new a2(1, "ambient_theme1", new c5[3]
		{
			new c5("INGAME_SKIES_1", "BACKGROUND_1_LAYER_1", 0.125f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_1", "BACKGROUND_1_LAYER_2", 0.5f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_1", "BACKGROUND_1_LAYER_3", 1f, 1.5f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_1_LAYER_1"),
			new c5("INGAME_PARALLAX_1", "FOREGROUND_1_LAYER_2")
		}, new Color(148, 206, 222, 255), new Color(10, 19, 57, 255)));
		A_0.Add("theme2", new a2(2, "ambient_theme2", new c5[3]
		{
			new c5("INGAME_SKIES_1", "BACKGROUND_2_LAYER_1", 0.125f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_2", "BACKGROUND_2_LAYER_2", 0.5f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_2", "BACKGROUND_2_LAYER_3", 1f, 1.5f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_2_LAYER_1"),
			new c5("INGAME_PARALLAX_2", "FOREGROUND_2_LAYER_2")
		}, new Color(193, 231, 239, 255), new Color(10, 19, 15, 255)));
		A_0.Add("theme3", new a2(3, "ambient_theme3", new c5[3]
		{
			new c5("INGAME_SKIES_1", "BACKGROUND_3_LAYER_1", 0.125f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_3", "BACKGROUND_3_LAYER_2", 0.5f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_3", "BACKGROUND_3_LAYER_3", 1f, 1.6f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_3_LAYER_1"),
			new c5("INGAME_PARALLAX_3", "FOREGROUND_3_LAYER_2")
		}, new Color(239, 214, 115, 255), new Color(47, 23, 14, 255)));
		A_0.Add("theme4", new a2(4, "ambient_theme1", new c5[3]
		{
			new c5("INGAME_SKIES_1", "BACKGROUND_4_LAYER_1", 0.125f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_4", "BACKGROUND_4_LAYER_2", 0.5f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_4", "BACKGROUND_4_LAYER_3", 1f, 1.85f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_4_LAYER_1"),
			new c5("INGAME_PARALLAX_4", "FOREGROUND_4_LAYER_2")
		}, new Color(144, 205, 237, 255), new Color(28, 18, 12, 255)));
		A_0.Add("theme5", new a2(5, "ambient_theme3", new c5[3]
		{
			new c5("INGAME_SKIES_1", "BACKGROUND_5_LAYER_1", 0.125f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_5", "BACKGROUND_5_LAYER_2", 0.5f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_5", "BACKGROUND_5_LAYER_3", 1f, 1.8f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_5_LAYER_1"),
			new c5("INGAME_PARALLAX_5", "FOREGROUND_5_LAYER_2")
		}, new Color(241, 226, 140, 255), new Color(68, 39, 2, 255)));
		A_0.Add("theme6", new a2(6, "ambient_theme3", new c5[3]
		{
			new c5("INGAME_SKIES_2", "BACKGROUND_6_LAYER_1", 0.3f, 4.5f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_6", "BACKGROUND_6_LAYER_2", 0.55f, 3.3f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_6", "BACKGROUND_6_LAYER_3", 1f, 2f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_6_LAYER_1"),
			new c5("INGAME_PARALLAX_6", "FOREGROUND_6_LAYER_2")
		}, new Color(74, 90, 44, 255), new Color(24, 28, 15, 255)));
		A_0.Add("theme7", new a2(7, "ambient_theme7", new c5[3]
		{
			new c5("INGAME_SKIES_2", "BACKGROUND_7_LAYER_1", 0.125f, 3.5f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_7", "BACKGROUND_7_LAYER_2", 0.5f, 3f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_7", "BACKGROUND_7_LAYER_3", 1f, 2.8f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_7_LAYER_1"),
			new c5("INGAME_PARALLAX_7", "FOREGROUND_7_LAYER_2")
		}, new Color(0, 0, 0, 255), new Color(17, 34, 69, 255)));
		A_0.Add("theme8", new a2(8, "ambient_theme2", new c5[3]
		{
			new c5("INGAME_SKIES_2", "BACKGROUND_8_LAYER_1", 0.125f, 2.5f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_8", "BACKGROUND_8_LAYER_2", 0.5f, 2.5f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_8", "BACKGROUND_8_LAYER_3", 1f, 1.8f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_PARALLAX_8", "FOREGROUND_8_LAYER_1"),
			new c5("INGAME_PARALLAX_8", "FOREGROUND_8_LAYER_2")
		}, new Color(249, 248, 235, 255), new Color(238, 255, 255, 255)));
		A_0.Add("theme9", new a2(9, "construction_theme1", new c5[7]
		{
			new c5("INGAME_SKIES_1", "BACKGROUND_1_LAYER_1", 0.125f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_1", "BACKGROUND_1_LAYER_2", 0.5f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_1", 0.8f, 1f, A_4: false, 565f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_2", 0.85f, 1.3f, A_4: false, 645f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_3", 0.9f, 1.6f, A_4: false, 755f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_4", 0.95f, 2f, A_4: false, 822f),
			new c5("INGAME_PARALLAX_1", "BACKGROUND_1_LAYER_3", 1f, 1.5f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_1_LAYER_1"),
			new c5("INGAME_PARALLAX_1", "FOREGROUND_1_LAYER_2")
		}, new Color(148, 206, 222, 255), new Color(10, 19, 57, 255)));
		A_0.Add("theme10", new a2(10, "construction_theme1", new c5[7]
		{
			new c5("INGAME_SKIES_1", "BACKGROUND_2_LAYER_1", 0.125f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_2", "BACKGROUND_2_LAYER_2", 0.5f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_1", 0.8f, 1f, A_4: false, 565f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_2", 0.85f, 1.3f, A_4: false, 645f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_3", 0.9f, 1.6f, A_4: false, 755f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_4", 0.95f, 2f, A_4: false, 822f),
			new c5("INGAME_PARALLAX_2", "BACKGROUND_2_LAYER_3", 1f, 1.5f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_2_LAYER_1"),
			new c5("INGAME_PARALLAX_2", "FOREGROUND_2_LAYER_2")
		}, new Color(193, 231, 239, 255), new Color(10, 19, 15, 255)));
		A_0.Add("theme11", new a2(11, "construction_theme1", new c5[7]
		{
			new c5("INGAME_SKIES_1", "BACKGROUND_3_LAYER_1", 0.125f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_3", "BACKGROUND_3_LAYER_2", 0.5f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_1", 0.8f, 1f, A_4: false, 565f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_2", 0.85f, 1.3f, A_4: false, 645f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_3", 0.9f, 1.6f, A_4: false, 755f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_4", 0.95f, 2f, A_4: false, 822f),
			new c5("INGAME_PARALLAX_3", "BACKGROUND_3_LAYER_3", 1f, 1.6f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_3_LAYER_1"),
			new c5("INGAME_PARALLAX_3", "FOREGROUND_3_LAYER_2")
		}, new Color(239, 214, 115, 255), new Color(47, 23, 14, 255)));
		A_0.Add("theme12", new a2(12, "construction_theme1", new c5[7]
		{
			new c5("INGAME_SKIES_1", "BACKGROUND_4_LAYER_1", 0.125f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_4", "BACKGROUND_4_LAYER_2", 0.5f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_1", 0.8f, 1f, A_4: false, 565f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_2", 0.85f, 1.3f, A_4: false, 645f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_3", 0.9f, 1.6f, A_4: false, 755f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_4", 0.95f, 2f, A_4: false, 822f),
			new c5("INGAME_PARALLAX_4", "BACKGROUND_4_LAYER_3", 1f, 1.85f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_4_LAYER_1"),
			new c5("INGAME_PARALLAX_4", "FOREGROUND_4_LAYER_2")
		}, new Color(144, 205, 237, 255), new Color(28, 18, 12, 255)));
		A_0.Add("theme13", new a2(13, "construction_theme1", new c5[7]
		{
			new c5("INGAME_SKIES_1", "BACKGROUND_5_LAYER_1", 0.125f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_5", "BACKGROUND_5_LAYER_2", 0.5f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_1", 0.8f, 1f, A_4: false, 565f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_2", 0.85f, 1.3f, A_4: false, 645f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_3", 0.9f, 1.6f, A_4: false, 755f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_4", 0.95f, 2f, A_4: false, 822f),
			new c5("INGAME_PARALLAX_5", "BACKGROUND_5_LAYER_3", 1f, 1.8f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_5_LAYER_1"),
			new c5("INGAME_PARALLAX_5", "FOREGROUND_5_LAYER_2")
		}, new Color(241, 226, 140, 255), new Color(68, 39, 2, 255)));
		A_0.Add("theme14", new a2(14, "construction_theme1", new c5[7]
		{
			new c5("INGAME_SKIES_2", "BACKGROUND_6_LAYER_1", 0.3f, 4.5f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_6", "BACKGROUND_6_LAYER_2", 0.55f, 3.3f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_1", 0.8f, 1f, A_4: false, 565f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_2", 0.85f, 1.3f, A_4: false, 645f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_3", 0.9f, 1.6f, A_4: false, 755f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_4", 0.95f, 2f, A_4: false, 822f),
			new c5("INGAME_PARALLAX_6", "BACKGROUND_6_LAYER_3", 1f, 2f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_6_LAYER_1"),
			new c5("INGAME_PARALLAX_6", "FOREGROUND_6_LAYER_2")
		}, new Color(74, 90, 44, 255), new Color(24, 28, 15, 255)));
		A_0.Add("theme15", new a2(15, "construction_theme1", new c5[7]
		{
			new c5("INGAME_SKIES_2", "BACKGROUND_7_LAYER_1", 0.125f, 3.5f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_7", "BACKGROUND_7_LAYER_2", 0.5f, 3f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_1", 0.8f, 1f, A_4: false, 565f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_2", 0.85f, 1.3f, A_4: false, 645f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_3", 0.9f, 1.6f, A_4: false, 755f),
			new c5("INGAME_PARALLAX_CRANES", "PARALLAX_CRANE_4", 0.95f, 2f, A_4: false, 822f),
			new c5("INGAME_PARALLAX_7", "BACKGROUND_7_LAYER_3", 1f, 2.8f, A_4: true, float.NaN)
		}, new c5[2]
		{
			new c5("INGAME_GROUNDS_1", "FOREGROUND_7_LAYER_1"),
			new c5("INGAME_PARALLAX_7", "FOREGROUND_7_LAYER_2")
		}, new Color(0, 0, 0, 255), new Color(17, 34, 69, 255)));
		A_0.Add("theme16", new a2(16, "ambient_theme3", new c5[3]
		{
			new c5("INGAME_SKIES_2", "BACKGROUND_10_LAYER_1", 0.125f, 2.35f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_9", "BACKGROUND_10_LAYER_1", 0.2f, 2.5f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_9", "BACKGROUND_10_LAYER_2", 0.45f, 1.75f, A_4: true, float.NaN)
		}, new c5[1]
		{
			new c5("INGAME_PARALLAX_9", "FOREGROUND_10_LAYER_1")
		}, new Color(8, 82, 104, 255), new Color(51, 34, 34, 255)));
		A_0.Add("theme17", new a2(17, "construction_theme1", new c5[3]
		{
			new c5("INGAME_SKIES_1", "BACKGROUND_2_LAYER_1", 0.125f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_3", "BACKGROUND_5_LAYER_2", 0.5f, 2f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_6", "BACKGROUND_6_LAYER_3", 0.7f, 2f, A_4: true, float.NaN)
		}, new c5[1]
		{
			new c5("INGAME_PARALLAX_7", "FOREGROUND_7_LAYER_2")
		}, new Color(0, 0, 0, 255), new Color(17, 17, 19, 255)));
		A_0.Add("theme18", new a2(18, "ambient_theme3", new c5[3]
		{
			new c5("INGAME_SKIES_3", "THEME_BG_1", 0.125f, 1.5f, A_4: true, float.NaN),
			new c5("INGAME_SKIES_3", "THEME_CAVE_PARALLAX_2", 0.45f, 1.5f, A_4: true, float.NaN),
			new c5("INGAME_PARALLAX_CAVE", "THEME_CAVE_PARALLAX_1", 0.45f, 1.5f, A_4: true, float.NaN)
		}, new c5[1]
		{
			new c5("INGAME_PARALLAX_CAVE", "THEME_CAVE_FG_1")
		}, new Color(156, 140, 123, 255), new Color(68, 34, 17, 255)));
	}

	public static Vector2 e(float A_0, float A_1, float A_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		Vector2 result = default(Vector2);
		result.X = A_0 * (1f / A_2);
		result.Y = A_1 * (1f / A_2);
		return result;
	}

	public static Vector2 d(float A_0, float A_1, float A_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		Vector2 result = default(Vector2);
		result.X = A_0 * A_2;
		result.Y = A_1 * A_2;
		return result;
	}

	public static float d(float A_0, float A_1, float A_2, float A_3)
	{
		float num = A_2 - A_0;
		float num2 = A_3 - A_1;
		return (float)Math.Sqrt(num * num + num2 * num2);
	}

	public static uint d(char A_0, char A_1, char A_2, char A_3)
	{
		return ((uint)A_0 << 24) | ((uint)A_1 << 16) | ((uint)A_2 << 8) | A_3;
	}
}
