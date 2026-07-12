using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using AngryBirds;
using AngryBirds.Menus;
using Box2D.XNA;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class cf
{
	public enum b
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i,
		j,
		k,
		l,
		m
	}

	public class ScorePair
	{
		public int a;

		public int b;

		[SpecialName]
		public int d()
		{
			return b + a;
		}
	}

	public static class PhysicsConfig
	{
		public static float a = 1f / 30f;

		public static int b = 10;

		public static int c = 10;

		public static bool d = false;

		private static float e;

		private static float f;

		[SpecialName]
		public static float GetInvTimestep()
		{
			return e;
		}

		[SpecialName]
		public static float GetTimestep()
		{
			return f;
		}

		[SpecialName]
		public static void SetTimestep(float A_0)
		{
			f = A_0;
			e = 1f / A_0;
		}
	}

	public class d
	{
		public string a;

		public bool b;

		public ct c;
	}

	public int a;

	private cw m_b;

	private cw m_c;

	private cw m_d;

	private cw e;

	private cw f;

	private cw g;

	private cw h;

	private cw i;

	private cw j;

	private World k;

	private bc l;

	private bc m;

	private e n;

	private cu o;

	private cs p;

	private aq q;

	private List<ct> r;

	private List<cy> s;

	private List<cy> t;

	private v m_u;

	private ct m_v;

	private ct m_w;

	private string m_x;

	private string m_y;

	private Vector2 m_z;

	private bool m_aa;

	private bool m_ab;

	private bool m_ac;

	private bool m_ad;

	private bool m_ae;

	private int m_af;

	private cy m_ag;

	private bool m_ah = true;

	private co m_ai;

	private a7 m_aj;

	private a7 m_ak;

	private string m_al;

	private StringBuilder m_am;

	private string m_an;

	private int m_ao;

	private int m_ap;

	private int m_aq;

	private ae m_ar;

	private ae m_as;

	private float m_at = 1f;

	private aw m_au;

	private aw m_av;

	private aw m_aw;

	private aw m_ax;

	private aw m_ay;

	private aw m_az;

	private aw m_a0;

	public aw a1;

	private List<ae> m_a2;

	private List<List<ct>> m_a3;

	private int m_a4;

	private Vector2 m_a5 = new Vector2(0f);

	[CompilerGenerated]
	private Game m_a6;

	[CompilerGenerated]
	private n m_a7;

	[CompilerGenerated]
	private b m_a8;

	[CompilerGenerated]
	private ScorePair m_a9;

	[CompilerGenerated]
	private cy m_ba;

	[CompilerGenerated]
	private string m_bb;

	[CompilerGenerated]
	private bool m_bc;

	[CompilerGenerated]
	private bool m_bd;

	[CompilerGenerated]
	private bool m_be;

	[CompilerGenerated]
	private List<string> bf;

	[SpecialName]
	[CompilerGenerated]
	public Game ak()
	{
		return this.m_a6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void u(Game A_0)
	{
		this.m_a6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public n an()
	{
		return this.m_a7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void u(n A_0)
	{
		this.m_a7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public b aw()
	{
		return this.m_a8;
	}

	[SpecialName]
	[CompilerGenerated]
	public void u(b A_0)
	{
		this.m_a8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public ScorePair at()
	{
		return this.m_a9;
	}

	[SpecialName]
	[CompilerGenerated]
	private void u(ScorePair A_0)
	{
		this.m_a9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public cy ah()
	{
		return this.m_ba;
	}

	[SpecialName]
	[CompilerGenerated]
	public void u(cy A_0)
	{
		this.m_ba = A_0;
	}

	[SpecialName]
	public bc a3()
	{
		return l;
	}

	[SpecialName]
	public bc ae()
	{
		return m;
	}

	[SpecialName]
	public string am()
	{
		return this.m_x;
	}

	[SpecialName]
	public string bb()
	{
		return this.m_y;
	}

	[SpecialName]
	[CompilerGenerated]
	public string a2()
	{
		return this.m_bb;
	}

	[SpecialName]
	[CompilerGenerated]
	private void v(string A_0)
	{
		this.m_bb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool be()
	{
		return this.m_bc;
	}

	[SpecialName]
	[CompilerGenerated]
	private void v(bool A_0)
	{
		this.m_bc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool ai()
	{
		return this.m_bd;
	}

	[SpecialName]
	[CompilerGenerated]
	private void u(bool A_0)
	{
		this.m_bd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool az()
	{
		return this.m_be;
	}

	[SpecialName]
	[CompilerGenerated]
	public void w(bool A_0)
	{
		this.m_be = A_0;
	}

	[SpecialName]
	public bool aa()
	{
		if (this.m_u == null)
		{
			return false;
		}
		return this.m_u.h();
	}

	[SpecialName]
	[CompilerGenerated]
	public List<string> a9()
	{
		return bf;
	}

	[SpecialName]
	[CompilerGenerated]
	private void u(List<string> A_0)
	{
		bf = A_0;
	}

	[SpecialName]
	public aq bc()
	{
		return q;
	}

	[SpecialName]
	public cu ag()
	{
		return o;
	}

	[SpecialName]
	public List<cy> aj()
	{
		return t;
	}

	[SpecialName]
	public void w(cy A_0)
	{
		this.m_ag = A_0;
	}

	public cf()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		w(A_0: false);
		this.m_b = global::u.a().f("wood_rolling");
		this.m_c = global::u.a().f("rock_rolling");
		this.m_d = global::u.a().f("light_rolling");
		this.m_c.r(A_0: true);
		this.m_d.r(A_0: true);
		this.m_b.r(A_0: true);
		e = global::u.a().f("level_clear_military");
		f = global::u.a().f("level_failed_piglets");
		g = global::u.a().f("bird_misc");
		h = global::u.a().f("piglette_damage");
		i = global::u.a().f("tnt_explodes");
		j = global::u.a().f("level_start_military");
		u(new ScorePair());
		at().b = 0;
		at().a = 0;
		this.m_ai = global::u.a().a("FONT_BASIC_WP7.dat");
		this.m_aj = new a7(bn.c, dh.a);
		this.m_ak = new a7(bn.c, dh.a);
		this.m_al = global::u.a().e("MI_SCORE") + " ";
		this.m_am = new StringBuilder("0", 16);
		this.m_an = global::u.a().e("MI_HIGH_SCORE") + " ";
		this.a = 0;
		this.m_ar = global::u.a().g("5K_GREEN");
		this.m_as = global::u.a().g("HUD_ARROW_UP");
		n = new e(this);
		o = new cu();
		p = new cs(global::u.a("particles.lua", global::h.g));
		q = new aq();
		this.m_z = default(Vector2);
		b6.a();
		aw aw2 = new aw();
		aw2.g(af);
		aw2.i(1f);
		this.m_au = aw2;
		b6.a().a(this.m_au);
		aw aw3 = new aw();
		aw3.g(ar);
		aw3.i(1.5f);
		this.m_av = aw3;
		aw aw4 = new aw();
		aw4.g(ac);
		aw4.i(1f);
		this.m_aw = aw4;
		b6.a().a(this.m_aw);
		aw aw5 = new aw();
		aw5.g(ao);
		aw5.i(1f);
		this.m_ax = aw5;
		b6.a().a(this.m_ax);
		aw aw6 = new aw();
		aw6.g(a6);
		aw6.i(2.5f);
		this.m_ay = aw6;
		b6.a().a(this.m_ay);
		aw aw7 = new aw();
		aw7.g(x);
		aw7.i(0.15f);
		this.m_az = aw7;
		b6.a().a(this.m_az);
		aw aw8 = new aw();
		aw8.g(null);
		aw8.i(0.6f);
		this.m_a0 = aw8;
		b6.a().a(this.m_a0);
		aw aw9 = new aw();
		aw9.g(a0);
		aw9.i(1f);
		aw9.i(A_0: false);
		a1 = aw9;
		b6.a().a(a1);
	}

	public bool v(cy A_0)
	{
		for (int num = 0; num < s.Count; num++)
		{
			if (s[num] == A_0)
			{
				return true;
			}
		}
		if (this.m_u.j() == A_0)
		{
			return true;
		}
		return false;
	}

	public void v(string A_0, string A_1)
	{
		this.m_y = A_0;
		this.m_x = A_1;
		m = new bc(this);
		m.f(this.m_y, this.m_x);
		this.m_at = 1f;
		u(cf.b.b);
	}

	public void au()
	{
		m = l;
		this.m_at = (float)an().ar;
		u(cf.b.d);
	}

	public void a4()
	{
		u(this.m_y, this.m_x);
	}

	private void u(string A_0, string A_1)
	{
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1204: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_115f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_15be: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc7: Unknown result type (might be due to invalid IL or missing references)
		this.m_ah = true;
		if (this.m_a2 != null)
		{
			this.m_a2.Clear();
		}
		if (this.m_a3 != null)
		{
			for (int num = 0; num < this.m_a3.Count; num++)
			{
				if (this.m_a3[num] != null)
				{
					this.m_a3[num].Clear();
				}
			}
			this.m_a3.Clear();
		}
		u((cy)null);
		this.m_af = -1;
		this.m_ag = null;
		this.a = bo.a().e(A_1).a;
		o.e();
		p.d();
		q.e();
		this.m_y = A_0;
		this.m_x = A_1;
		v(this.m_y == "goldeneggs1");
		di.d().e(m.f());
		l = m;
		l.i();
		m = null;
		cf.PhysicsConfig.SetTimestep(l.c);
		u(new n(l));
		an().f((double)this.m_at);
		an().a7 = false;
		an().f(1);
		an().f(1);
		this.m_ac = true;
		o.b(an());
		p.b(an());
		q.a(an());
		k = new World(dc.k, doSleep: true);
		k.ContactListener = n;
		k.ContactFilter = n;
		n.b(A_0: false);
		k.WarmStarting = false;
		k.ContinuousPhysics = true;
		r = new List<ct>();
		s = new List<cy>();
		u(new List<string>());
		ba();
		for (int num2 = r.Count - 1; num2 > 0; num2--)
		{
			if (r[num2].p.h == BlockGroup.PIGLETTES)
			{
				ct item = r[num2];
				r.RemoveAt(num2);
				r.Add(item);
			}
		}
		for (int num3 = r.Count - 1; num3 > 0; num3--)
		{
			ct ct2 = r[num3];
			if (ct2.q.StartsWith("Extra") && (ct2.q.Contains("Hat") || ct2.q.Contains("Helmet")))
			{
				r.RemoveAt(num3);
				r.Add(ct2);
			}
		}
		for (int num4 = 0; num4 < r.Count; num4++)
		{
			if (r[num4].q == "ExtraBoomerangBird_1" && ay())
			{
				ct item2 = r[num4];
				r.RemoveAt(num4);
				r.Insert(0, item2);
			}
		}
		k.ForceWakeUp = true;
		if (this.m_x == "LevelGE_1")
		{
			this.m_av.i(3f);
			this.m_av.g();
			float num5 = 0f;
			for (int num6 = 0; num6 < r.Count; num6++)
			{
				if (r[num6].q == "StoneBlock8_1")
				{
					num5 = 42.82f;
					r[num6].c = num5;
					r[num6].o.d.Position.X = num5;
				}
				else if (r[num6].q == "ExtraStrongBall_1")
				{
					num5 = 33.05f;
					r[num6].c = num5;
					r[num6].o.d.Position.X = num5;
				}
				else if (r[num6].q == "StoneBlock8_14")
				{
					num5 = 52.22f;
					r[num6].c = num5;
					r[num6].o.d.Position.X = num5;
				}
			}
		}
		if (this.m_x == "LevelGE_4")
		{
			k.ForceWakeUp = false;
		}
		if (this.m_x == "LevelGE_11")
		{
			k.ForceWakeUp = false;
		}
		if (this.m_x == "LevelGE_19")
		{
			k.ForceWakeUp = false;
		}
		if (this.m_x == "LevelP3_313")
		{
			k.ForceWakeUp = false;
		}
		if (this.m_x == "LevelP5_631")
		{
			k.ForceWakeUp = false;
		}
		if (this.m_x == "LevelP5_663")
		{
			k.ForceWakeUp = false;
		}
		if (this.m_x == "LevelP5_668")
		{
			k.ForceWakeUp = false;
		}
		if (this.m_x == "LevelP5_672")
		{
			k.ForceWakeUp = false;
		}
		if (this.m_x == "Level34")
		{
			k.ForceWakeUp = false;
			for (int num7 = 0; num7 < r.Count; num7++)
			{
				if (r[num7].q == "WoodBlock6_1")
				{
					ct ct3 = r[num7];
					float num8 = 3.14159f;
					ct3.e = num8;
					ct3.o.SetTransform(new Vector2(ct3.c, ct3.d), ct3.e);
					ct3.o.SetAwake(flag: false);
				}
			}
		}
		if (this.m_x == "Level77")
		{
			for (int num9 = 0; num9 < r.Count; num9++)
			{
				if (r[num9].q == "WoodBlock5_1")
				{
					ct ct4 = r[num9];
					ct4.e = 1.570795f;
					ct4.o.SetTransform(new Vector2(ct4.c, ct4.d), ct4.e);
					ct4.o.SetAwake(flag: false);
				}
				else if (r[num9].q == "WoodBlock5_2")
				{
					ct ct5 = r[num9];
					ct5.e = 1.570795f;
					ct5.o.SetTransform(new Vector2(ct5.c, ct5.d), ct5.e);
					ct5.o.SetAwake(flag: false);
				}
				else if (r[num9].q == "WoodBlock5_3")
				{
					ct ct6 = r[num9];
					ct6.e = 1.570795f;
					ct6.o.SetTransform(new Vector2(ct6.c, ct6.d), ct6.e);
					ct6.o.SetAwake(flag: false);
				}
			}
		}
		if (this.m_x == "Level57")
		{
			for (int num10 = 0; num10 < r.Count; num10++)
			{
				if (r[num10].q == "WoodBlock4_5")
				{
					ct ct7 = r[num10];
					ct7.e = 3.14159f;
					ct7.o.SetTransform(new Vector2(ct7.c, ct7.d), ct7.e);
					ct7.o.SetAwake(flag: false);
				}
			}
		}
		if (this.m_x == "LevelP4_421")
		{
			for (int num11 = 0; num11 < r.Count; num11++)
			{
				if (r[num11].q == "ExtraHelmetSmall_1")
				{
					ct ct8 = r[num11];
					ct8.c += 0.04f;
					ct8.o.SetTransform(new Vector2(ct8.c, ct8.d), ct8.e);
					ct8.o.SetAwake(flag: false);
				}
			}
		}
		if (this.m_x == "LevelP4_425")
		{
			for (int num12 = 0; num12 < r.Count; num12++)
			{
				if (r[num12].q == "WoodBlock6_17")
				{
					ct ct9 = r[num12];
					ct9.e = 3.14159f;
					ct9.o.SetTransform(new Vector2(ct9.c, ct9.d), ct9.e);
					ct9.o.SetAwake(flag: false);
				}
				else if (r[num12].q == "LargePiglette_1")
				{
					ct ct10 = r[num12];
					ct10.e = 0f;
					ct10.c = 58.4783f;
					ct10.d += 0.06f;
					ct10.o.SetTransform(new Vector2(ct10.c, ct10.d), ct10.e);
					ct10.o.SetAwake(flag: false);
				}
				else if (r[num12].q == "ExtraHelmetBig_1")
				{
					ct ct11 = r[num12];
					ct11.e = 0f;
					ct11.c = 58.4783f;
					ct11.d += 0.06f;
					ct11.o.SetTransform(new Vector2(ct11.c, ct11.d), ct11.e);
					ct11.o.SetAwake(flag: false);
				}
				else if (r[num12].q == "WoodBlock4_1")
				{
					ct ct12 = r[num12];
					ct12.e = 1.570795f;
					ct12.d = -2.08f;
					ct12.o.SetTransform(new Vector2(ct12.c, ct12.d), ct12.e);
					ct12.o.SetAwake(flag: false);
				}
				else if (r[num12].q == "WoodBlock4_2")
				{
					ct ct13 = r[num12];
					ct13.e = 1.570795f;
					ct13.d = -2.08f;
					ct13.o.SetTransform(new Vector2(ct13.c, ct13.d), ct13.e);
					ct13.o.SetAwake(flag: false);
				}
			}
		}
		if (this.m_x == "LevelP4_444")
		{
			for (int num13 = 0; num13 < r.Count; num13++)
			{
				if (r[num13].q == "LightBlock9_20")
				{
					ct ct14 = r[num13];
					ct14.e = 2.3561926f;
					ct14.o.SetTransform(new Vector2(ct14.c, ct14.d), ct14.e);
					ct14.o.SetAwake(flag: false);
				}
				else if (r[num13].q == "LightBlock9_16")
				{
					ct ct15 = r[num13];
					ct15.e = 2.3561926f;
					ct15.o.SetTransform(new Vector2(ct15.c, ct15.d), ct15.e);
					ct15.o.SetAwake(flag: false);
				}
			}
		}
		if (this.m_x == "LevelP4_451")
		{
			for (int num14 = 0; num14 < r.Count; num14++)
			{
				if (r[num14].q == "HelmetPiglette_2")
				{
					ct ct16 = r[num14];
					ct16.e = 0f;
					ct16.o.SetTransform(new Vector2(ct16.c, ct16.d), ct16.e);
					ct16.o.SetAwake(flag: false);
				}
				else if (r[num14].q == "ExtraHelmetBig_2")
				{
					ct ct17 = r[num14];
					ct17.e = 0.02f;
					ct17.o.SetTransform(new Vector2(ct17.c, ct17.d), ct17.e);
					ct17.o.SetAwake(flag: false);
				}
				else if (r[num14].q == "WoodBlock5_1")
				{
					ct ct18 = r[num14];
					ct18.e = 1.570795f;
					ct18.d = -2.06f;
					ct18.o.SetTransform(new Vector2(ct18.c, ct18.d), ct18.e);
					ct18.o.SetAwake(flag: false);
				}
				else if (r[num14].q == "WoodBlock5_2")
				{
					ct ct19 = r[num14];
					ct19.e = 1.570795f;
					ct19.d = -2.06f;
					ct19.o.SetTransform(new Vector2(ct19.c, ct19.d), ct19.e);
					ct19.o.SetAwake(flag: false);
				}
				else if (r[num14].q == "LightBlock4_1")
				{
					ct ct20 = r[num14];
					ct20.e = 1.570795f;
					ct20.d = -2.06f;
					ct20.o.SetTransform(new Vector2(ct20.c, ct20.d), ct20.e);
					ct20.o.SetAwake(flag: false);
				}
				else if (r[num14].q == "WoodBlock6_12")
				{
					ct ct21 = r[num14];
					ct21.e = (float)Math.PI;
					ct21.d -= 0.02f;
					ct21.o.SetTransform(new Vector2(ct21.c, ct21.d), ct21.e);
					ct21.o.SetAwake(flag: false);
				}
			}
		}
		if (this.m_x == "LevelP4_455")
		{
			for (int num15 = 0; num15 < r.Count; num15++)
			{
				if (r[num15].q == "ExtraHelmetSmall_4")
				{
					ct ct22 = r[num15];
					ct22.e = -0.03f;
					ct22.c = 90.86f;
					ct22.o.SetTransform(new Vector2(ct22.c, ct22.d), ct22.e);
					ct22.o.SetAwake(flag: false);
				}
				else if (r[num15].q == "HelmetPiglette_1")
				{
					ct ct23 = r[num15];
					ct23.e = 0f;
					ct23.c = 90.882f;
					ct23.o.SetTransform(new Vector2(ct23.c, ct23.d), ct23.e);
					ct23.o.SetAwake(flag: false);
				}
				else if (r[num15].q == "StoneBlock3_7")
				{
					ct ct24 = r[num15];
					ct24.e = 0f;
					ct24.o.SetTransform(new Vector2(ct24.c, ct24.d), ct24.e);
					ct24.o.SetAwake(flag: false);
				}
			}
		}
		if (this.m_x == "LevelP4_470")
		{
			for (int num16 = 0; num16 < r.Count; num16++)
			{
				if (r[num16].q == "HelmetPiglette_1")
				{
					ct ct25 = r[num16];
					ct25.c += 0.03f;
					ct25.o.SetTransform(new Vector2(ct25.c, ct25.d), ct25.e);
					ct25.o.SetAwake(flag: false);
				}
			}
		}
		if (this.m_x == "LevelP5_364")
		{
			for (int num17 = 0; num17 < r.Count; num17++)
			{
				if (r[num17].q == "ExtraGoldenEgg_1")
				{
					ct ct26 = r[num17];
					float num18 = (ct26.c = 114f);
					ct26.o.SetTransform(new Vector2(num18, ct26.d), ct26.e);
					ct26.o.SetAwake(flag: false);
				}
			}
		}
		if (this.m_x == "LevelP5_628")
		{
			for (int num19 = 0; num19 < r.Count; num19++)
			{
				if (r[num19].q == "WoodBlock6_31")
				{
					ct ct27 = r[num19];
					float num20 = (ct27.c += 0.03f);
					ct27.o.SetTransform(new Vector2(num20, ct27.d), ct27.e);
					ct27.o.SetAwake(flag: false);
				}
			}
		}
		int num21 = 0;
		for (int num22 = 0; num22 < s.Count; num22++)
		{
			if (s[num22] is x)
			{
				num21++;
			}
			if (s[num22] is b1)
			{
				num21++;
			}
			if (s[num22] is ah)
			{
				num21 += 3;
			}
			if (s[num22] is dn)
			{
				num21++;
			}
			if (s[num22] is bt)
			{
				num21++;
			}
			if (s[num22] is bh)
			{
				num21++;
			}
			if (s[num22] is ar)
			{
				num21++;
			}
		}
		for (int num23 = 0; num23 < s.Count; num23++)
		{
			if (s[num23] is x)
			{
				a9().Add("BIRD_RED");
			}
			if (s[num23] is b1)
			{
				a9().Add("BIRD_YELLOW");
			}
			if (s[num23] is ah)
			{
				a9().Add("BIRD_BLUE");
			}
			if (s[num23] is dn)
			{
				a9().Add("BIRD_GREY");
			}
			if (s[num23] is bt)
			{
				a9().Add("BIRD_GREEN");
			}
			if (s[num23] is bh)
			{
				a9().Add("BIRD_BOOMERANG");
			}
			if (s[num23] is ar)
			{
				a9().Add("BIRD_BIG_BROTHER");
			}
		}
		this.m_v = v();
		this.m_w = u();
		t = new List<cy>(num21);
		ae ae2 = global::u.a().g("SLING_SHOT_01_BACK");
		cy cy2 = s[0];
		Vector2 position = cy2.o.d.Position;
		position.Y -= (float)(ae2.d - ae2.f) * cf.PhysicsConfig.GetInvTimestep() - cy2.@as().i - 0.2f;
		this.m_u = new v(position, t);
		at().a = 0;
		at().b = 0;
		GC.Collect();
		b6.a().b();
		this.m_au.g(A_0: true);
		ao();
		u(A_0: false);
		this.m_ae = false;
		u(cf.b.f);
		this.m_ao = this.m_ai.a("0");
		this.m_ap = this.m_ai.a(this.a.ToString());
		this.m_am.Length = 0;
		this.m_am.Append(at().d());
		ak().ResetElapsedTime();
	}

	public void u(GameTime A_0)
	{
		float a_ = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		u(a_, A_0.IsRunningSlowly);
	}

	public void u(float A_0, bool A_1)
	{
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Invalid comparison between Unknown and I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Invalid comparison between Unknown and I4
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Invalid comparison between Unknown and I4
		ad();
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		if (!cf.PhysicsConfig.d)
		{
			k.Step(cf.PhysicsConfig.a, cf.PhysicsConfig.b, cf.PhysicsConfig.c);
			k.ClearForces();
			p.b(A_0);
			q.a(A_0);
			u(A_0);
			this.m_aa = false;
			this.m_ab = false;
			al();
			for (int num4 = 0; num4 < r.Count; num4++)
			{
				ct ct2 = r[num4];
				if (ct2.h)
				{
					ct2.o.SetLinearVelocity(ct2.i);
					ct2.h = false;
				}
				if (ct2.o.IsAwake())
				{
					ct2.c = ct2.o.d.Position.X;
					ct2.d = ct2.o.d.Position.Y;
					ct2.e = ct2.o.e.a;
					if (ct2.p.h == BlockGroup.BIRDS && ct2.o.GetMass() != 0f)
					{
						ct2.o.SetBullet(flag: true);
					}
				}
				if (ct2.k || ct2.o.IsAwake())
				{
					Vector2 linearVelocity = ct2.o.GetLinearVelocity();
					float num5 = linearVelocity.LengthSquared();
					this.m_ab = this.m_ab || (num5 > 1.1920929E-07f && !ct2.g);
					this.m_aa = this.m_aa || num5 > 9f || ct2.o.GetAngularVelocity() > 0.1f;
					if (ct2.p.h != BlockGroup.BIRDS && ct2.p.b == BlockBasicType.CIRCLE)
					{
						float num6 = Math.Abs(ct2.o.GetAngularVelocity()) * ct2.b / 400f * ct2.o.GetMass();
						if (num6 > 1f)
						{
							num6 = 1f;
						}
						if (ct2.p.g.a == MaterialType.WOOD && num < num6)
						{
							num = num6;
						}
						if (ct2.p.g.a == MaterialType.ROCK && num2 < num6)
						{
							num2 = num6;
						}
						if (ct2.p.g.a == MaterialType.LIGHT && num3 < num6)
						{
							num3 = num6;
						}
					}
				}
				ct2.k = ct2.o.IsAwake();
				if (ct2.p.h == BlockGroup.BIRDS)
				{
					((cy)ct2).m(A_0);
				}
			}
		}
		if (this.m_ad)
		{
			if (s[0].al)
			{
				a1.g(A_0: false);
			}
			else
			{
				this.m_ad = false;
				a1.g(A_0: true);
				this.m_z.X = s[0].c;
				this.m_z.Y = s[0].d;
			}
		}
		if (a1.i())
		{
			cy cy2 = s[0];
			float num7 = a1.n();
			cy2.c = this.m_z.X * (1f - num7) + this.m_u.f().X * num7;
			cy2.d = this.m_z.Y + (this.m_u.f().Y - this.m_z.Y) * (float)Math.Sin(Math.PI * 3.0 / 4.0 * (double)num7) * 1.33f;
			cy2.e += (float)Math.PI * 2f * A_0;
			cy2.o.SetTransform(new Vector2(cy2.c, cy2.d), cy2.e);
		}
		if (!this.m_aa && !this.m_ab && (ah() == null || !ah().at()) && this.m_ac && aw() == cf.b.j && this.m_u.j() != null)
		{
			an().h(2);
			this.m_ac = false;
		}
		an().f((int)(A_0 * 1000f));
		if (num > 0f)
		{
			if ((int)this.m_b.w() == 2)
			{
				this.m_b.y(num);
				this.m_b.ac();
			}
			else
			{
				this.m_b.y(num);
			}
		}
		else if ((int)this.m_b.w() == 0)
		{
			this.m_b.ae();
		}
		if (num2 > 0f)
		{
			if ((int)this.m_c.w() == 2)
			{
				this.m_c.y(num2);
				this.m_c.ac();
			}
			else
			{
				this.m_c.y(num2);
			}
		}
		else if ((int)this.m_c.w() == 0)
		{
			this.m_c.ae();
		}
		if (num3 > 0f)
		{
			if ((int)this.m_d.w() == 2)
			{
				this.m_d.y(num3);
				this.m_d.ac();
			}
			else
			{
				this.m_d.y(num3);
			}
		}
		else if ((int)this.m_d.w() == 0)
		{
			this.m_d.ae();
		}
		b6.a().a(A_0);
		if (aw() == cf.b.j)
		{
			if (bd())
			{
				this.m_ah = false;
				this.m_u.g();
				this.m_u.f(A_0: false);
				if (!this.m_ae)
				{
					e.ac();
					this.m_ae = true;
				}
				this.m_aw.i(1f);
				this.m_aw.g(A_0: true);
				an().h(2);
				for (int num8 = 0; num8 < s.Count; num8++)
				{
					s[num8].j(0f);
				}
				if (this.m_u.j() != null)
				{
					this.m_u.j().j(0f);
				}
			}
			if (a5())
			{
				this.m_av.g(A_0: true);
				this.m_av.h(A_0);
			}
		}
		else
		{
			this.m_u.g();
		}
		this.m_am.Length = 0;
		this.m_am.Append(at().d());
	}

	public void @as()
	{
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		z();
		o.b();
		bu bu2 = bu.b();
		float num = an().m();
		bu2.e();
		for (int num2 = 0; num2 < this.m_a2.Count; num2++)
		{
			float a_ = an().i();
			float a_2 = an().j();
			bu2.b(this.m_a2[num2], num, a_, a_2);
			for (int num3 = 0; num3 < this.m_a3[num2].Count; num3++)
			{
				ct ct2 = this.m_a3[num2][num3];
				if (ct2.u != null)
				{
					float A_ = ct2.c;
					float A_2 = ct2.d;
					an().f(ref A_, ref A_2);
					if (ct2.m != null)
					{
						bu2.c(ct2.m, A_, A_2, ct2.e);
					}
				}
			}
			bu2.c();
		}
		bu2.d();
		for (int num4 = 0; num4 < r.Count; num4++)
		{
			ct ct2 = r[num4];
			if (ct2.u == null)
			{
				float A_ = ct2.c;
				float A_2 = ct2.d;
				an().f(ref A_, ref A_2);
				if (ct2.m != null)
				{
					bu2.b(ct2.m, A_, A_2, num, num, ct2.e);
				}
			}
		}
		this.m_u.f(an(), A_1: true);
		for (int num5 = 0; num5 < s.Count; num5++)
		{
			ct ct2 = s[num5];
			float A_ = ct2.c;
			float A_2 = ct2.d;
			an().f(ref A_, ref A_2);
			if (ct2.m != null)
			{
				bu2.b(ct2.m, A_, A_2, num, num, ct2.e);
			}
		}
		this.m_u.f(an(), A_1: false);
		y();
		p.b();
		q.c();
		if (az())
		{
			int num6 = this.m_ai.a(this.m_am.ToString());
			if (num6 > this.m_ao)
			{
				this.m_ao = num6;
			}
			int num7 = 0;
			if (this.a > 0)
			{
				if (this.m_ao < this.m_ap)
				{
					this.m_ao = this.m_ap;
				}
				this.m_ai.a(this.m_an, new Vector2((float)(797 - this.m_ao), 2f), this.m_aj);
				this.m_ai.a(this.a.ToString(), new Vector2(797f, 2f), this.m_aj);
				num7 = this.m_ai.a();
			}
			this.m_ai.a(this.m_al, new Vector2((float)(797 - this.m_ao), (float)(2 + num7)), this.m_aj);
			this.m_ai.a(this.m_am.ToString(), new Vector2(797f, (float)(2 + num7)), this.m_ak);
		}
		if (ah() != null)
		{
			float A_ = ah().c;
			float A_2 = ah().d;
			an().f(ref A_, ref A_2);
			if (A_2 < 0f)
			{
				bu2.b(this.m_as, A_, 0f);
			}
		}
	}

	private void z()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		bu bu2 = bu.b();
		float A_ = 0f;
		float A_2 = 0f;
		float num = 1f;
		float a_ = 0f;
		an().f(ref A_, ref A_2);
		a2 a10 = di.d().f();
		bu2.b(a10.e);
		bu.a.Clear(bu2.f());
		bu2.b(Color.White);
		float num2 = an().m();
		for (int num3 = 0; num3 < a10.c.Count; num3++)
		{
			c5 c10 = a10.c[num3];
			if (c10.a == null)
			{
				continue;
			}
			num = num2 * c10.e;
			float num4 = (0f - an().i()) * num2 * c10.d;
			float num5 = (float)c10.a.c * num - 1f;
			float num6 = 800f / num2;
			int num7 = (int)(num6 / num5) + 2;
			if (c10.f)
			{
				float num8 = num4 % num5 - (float)c10.a.e * num;
				if (num4 > 0f)
				{
					num8 -= num5;
				}
				while (num7 >= 0)
				{
					bu2.b(c10.a, num8, A_2, num, num, a_);
					num8 += num5;
					num7--;
				}
			}
			else
			{
				float a_2 = num4 + c10.g * num;
				bu2.b(c10.a, a_2, A_2, num, num, a_);
			}
		}
	}

	private void y()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		float num = an().m();
		float num2 = 1.5f;
		float A_ = 0f;
		float A_2 = 0f;
		float num3 = 1f;
		float a_ = 0f;
		an().f(ref A_, ref A_2);
		a2 a10 = di.d().f();
		c5 c10 = a10.d[0];
		bu.b().b(a10.f);
		bu.b().b(0f, A_2, 800f, 481f);
		bu.b().b(Color.White);
		num3 = num * num2;
		for (int num4 = 0; num4 < a10.d.Count; num4++)
		{
			c10 = a10.d[num4];
			float num5 = (0f - an().i()) * num;
			float num6 = (float)c10.a.c * num3 - 1f;
			float num7 = 800f / num;
			int num8 = (int)(num7 / num6) + 2;
			float num9 = num5 % num6 - (float)c10.a.e * num3;
			if (num5 > 0f)
			{
				num9 -= num6;
			}
			while (num8 >= 0)
			{
				bu.b().b(c10.a, num9, A_2, num3, num3, a_);
				num9 += num6;
				num8--;
			}
		}
	}

	private void x()
	{
		an().h(2);
	}

	public void a7()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I4, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		Controls instance = Controls.GetInstance();
		for (int num = 0; num < instance.Touches.Count; num++)
		{
			TouchLocation val = instance.Touches[num];
			Vector2 A_ = val.Position;
			an().f(ref A_);
			TouchLocationState state = val.State;
			switch (state)
			{
			case TouchLocationState.Pressed:
				if (this.m_u.l() && !this.m_u.h() && !instance.IsPinched && !this.m_a0.i() && this.m_u.f(A_, an().m()))
				{
					this.m_a4 = val.Id;
				}
				break;
			case TouchLocationState.Moved:
				if (this.m_u.h() && this.m_a4 == val.Id)
				{
					this.m_u.f(A_);
				}
				break;
			case TouchLocationState.Released:
				if (this.m_u.h() && this.m_a4 == val.Id)
				{
					w();
				}
				break;
			}
		}
	}

	public void ad()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		if (aw() != cf.b.j || !this.m_ah)
		{
			return;
		}
		Controls instance = Controls.GetInstance();
		if (instance.IsTapped)
		{
			if (!this.m_a0.i())
			{
				this.m_az.g();
				this.m_az.g(A_0: true);
			}
		}
		else if (instance.IsDoubleTapped)
		{
			if (!this.m_a0.i())
			{
				this.m_az.g();
				if (this.m_w != null)
				{
					for (int num = 0; num < instance.DoubleTapGestures.Count; num++)
					{
						GestureSample val = instance.DoubleTapGestures[num];
						Vector2 A_ = val.Position;
						an().f(ref A_);
						Vector2 val2 = A_ - this.m_w.o.Position;
						if (val2.Length() < 2.5f)
						{
							u(cf.b.i);
							this.m_w = null;
						}
					}
				}
				else
				{
					an().f(1.0);
					an().a7 = true;
				}
			}
		}
		else if (instance.IsDragCompleted)
		{
			if (!this.m_u.h())
			{
				for (int num2 = 0; num2 < instance.DragCompletedGestures.Count; num2++)
				{
					float a_ = this.m_a5.X * cf.PhysicsConfig.GetTimestep();
					float a_2 = this.m_a5.Y * cf.PhysicsConfig.GetTimestep();
					an().f(a_, a_2);
				}
			}
		}
		else if (instance.IsDragged)
		{
			if (!this.m_a0.i())
			{
				for (int num3 = 0; num3 < instance.DragGestures.Count; num3++)
				{
					if (!this.m_u.h())
					{
						this.m_ac = false;
						GestureSample val3 = instance.DragGestures[num3];
						this.m_a5 = val3.Position;
						GestureSample val4 = instance.DragGestures[num3];
						float a_3 = val4.Position.X * cf.PhysicsConfig.GetTimestep();
						GestureSample val5 = instance.DragGestures[num3];
						float a_4 = val5.Position.Y * cf.PhysicsConfig.GetTimestep();
						if (an().o != 3)
						{
							an().h(3);
							an().g(a_3, a_4);
						}
						else
						{
							an().h(a_3, a_4);
						}
					}
				}
			}
		}
		else if (instance.IsTouchPressed && !this.m_u.h() && ah() != null && ah().au() && ah().o.GetType() != 0)
		{
			ah().l();
			this.m_a0.g();
			this.m_a0.g(A_0: true);
		}
		if (instance.IsPinched && (ah() == null || ah().aq()))
		{
			float num4 = 0f;
			for (int num5 = 0; num5 < instance.PinchGestures.Count; num5++)
			{
				GestureSample val6 = instance.PinchGestures[num5];
				Vector2 position = val6.Position2;
				GestureSample val7 = instance.PinchGestures[num5];
				Vector2 val8 = position - val7.Position;
				GestureSample val9 = instance.PinchGestures[num5];
				Vector2 position2 = val9.Position2;
				GestureSample val10 = instance.PinchGestures[num5];
				Vector2 val11 = position2 + val10.Delta2;
				GestureSample val12 = instance.PinchGestures[num5];
				Vector2 position3 = val12.Position;
				GestureSample val13 = instance.PinchGestures[num5];
				Vector2 val14 = val11 - (position3 + val13.Delta);
				float num6 = val8.Length() - val14.Length();
				num4 += num6;
			}
			an().f(num4 * -0.005f);
		}
		a7();
	}

	private bool w()
	{
		if (this.m_u.l() && this.m_u.h() && this.m_u.j() != null)
		{
			u(this.m_u.j());
			r.Add(ah());
			this.m_u.k();
			if (ah().@as().ag != null)
			{
				ah().@as().ag.ac();
			}
			an().a8 = ah();
			an().h(4);
			this.m_ac = true;
			this.m_u.f(A_0: false);
			this.m_ax.g(A_0: true);
			return true;
		}
		return false;
	}

	public void aq()
	{
		if (this.m_u.h())
		{
			this.m_u.g();
		}
	}

	public void al()
	{
		ct ct2 = null;
		global::d d2 = global::d.p();
		for (int num = 0; num < r.Count; num++)
		{
			ct2 = r[num];
			if (ct2.f <= 0f)
			{
				int num2 = 500;
				if (ct2.p.r != 0)
				{
					num2 = ct2.p.r;
				}
				if (ct2.p.h == BlockGroup.PIGLETTES)
				{
					num2 = 5000;
					d2.e++;
					if (((at)ct2.p).ar())
					{
						this.m_aq--;
					}
					h.ac();
					q.a(ct2.c, ct2.d, this.m_ar, 0f, 0.9f, 1f, 0f);
				}
				else
				{
					if (ct2.p.g.a == MaterialType.WOOD)
					{
						d2.b++;
					}
					else if (ct2.p.g.a == MaterialType.LIGHT)
					{
						d2.c++;
					}
					else if (ct2.p.g.a == MaterialType.ROCK)
					{
						d2.d_value++;
					}
					q.a(ct2.c, ct2.d, 500.ToString(), 0f, 0.6f, 0.25f + (float)num2 / 3000f, 0f);
				}
				if (ct2.p.q)
				{
					i.ac();
					u(ct2);
				}
				if (ct2.p.g.k != null && ct2.p.h != BlockGroup.BIRDS)
				{
					ct2.p.g.k.y(0.7f);
					ct2.p.g.k.ac();
				}
				if (ct2.p.h != BlockGroup.BIRDS)
				{
					x(ct2);
				}
				at().b += num2;
			}
			if (!(ct2.f <= 0f) && (!(ct2.o.GetMass() > 0f) || (!(ct2.d > 20f) && !(ct2.c < l.l) && !(ct2.c > l.m))))
			{
				continue;
			}
			if (ct2.p.h == BlockGroup.BIRDS)
			{
				cy cy2 = (cy)ct2;
				if (this.m_ag != cy2)
				{
					cy2.n(A_0: true);
				}
			}
			v(ct2);
		}
	}

	public void ab()
	{
		global::s.a().a(a3().n(), A_1: true);
		j.ac();
	}

	public void a8()
	{
		global::s.a().c();
	}

	private Body u(float A_0, float A_1, float A_2, float A_3, float A_4, float A_5, float A_6, float A_7, bool A_8)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		BodyDef bodyDef = new BodyDef();
		bodyDef.position = new Vector2(A_0, A_1);
		bodyDef.angularDamping = 1f;
		bodyDef.type = ((A_5 != 0f) ? BodyType.Dynamic : BodyType.Static);
		bodyDef.angle = A_4;
		Body body = k.CreateBody(bodyDef);
		PolygonShape polygonShape = new PolygonShape();
		polygonShape.SetAsBox(A_2 * 0.5f, A_3 * 0.5f);
		FixtureDef fixtureDef = new FixtureDef();
		fixtureDef.density = A_5;
		fixtureDef.friction = A_6;
		fixtureDef.restitution = A_7;
		fixtureDef.shape = polygonShape;
		body.CreateFixture(fixtureDef);
		return body;
	}

	private Body u(float A_0, float A_1, float A_2, float A_3, float A_4, float A_5, float A_6)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		BodyDef bodyDef = new BodyDef();
		bodyDef.position = new Vector2(A_0, A_1);
		bodyDef.angularDamping = 1f;
		bodyDef.type = ((A_4 != 0f) ? BodyType.Dynamic : BodyType.Static);
		bodyDef.angle = A_3;
		Body body = k.CreateBody(bodyDef);
		CircleShape circleShape = new CircleShape();
		circleShape._radius = A_2;
		FixtureDef fixtureDef = new FixtureDef();
		fixtureDef.density = A_4;
		fixtureDef.friction = A_5;
		fixtureDef.restitution = A_6;
		fixtureDef.shape = circleShape;
		body.CreateFixture(fixtureDef);
		return body;
	}

	private Body u(Vector2[] A_0, float A_1, float A_2, float A_3, float A_4, float A_5, float A_6, float A_7, float A_8)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		BodyDef bodyDef = new BodyDef();
		bodyDef.position = new Vector2(A_1, A_2);
		bodyDef.angularDamping = 1f;
		bodyDef.type = ((A_6 != 0f) ? BodyType.Dynamic : BodyType.Static);
		bodyDef.angle = A_5;
		Body body = k.CreateBody(bodyDef);
		PolygonShape polygonShape = new PolygonShape();
		polygonShape.Set(A_0, A_0.Length);
		FixtureDef fixtureDef = new FixtureDef();
		fixtureDef.density = A_6;
		fixtureDef.friction = A_7;
		fixtureDef.restitution = A_8;
		fixtureDef.shape = polygonShape;
		body.CreateFixture(fixtureDef);
		return body;
	}

	private Joint u(a6 A_0)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		JointDef jointDef = null;
		if (A_0.b == 1)
		{
			DistanceJointDef distanceJointDef = new DistanceJointDef();
			jointDef = distanceJointDef;
			distanceJointDef.frequencyHz = 4f;
			distanceJointDef.dampingRatio = 0.5f;
			distanceJointDef.bodyA = u(A_0.d);
			distanceJointDef.bodyB = u(A_0.e);
			distanceJointDef.localAnchorA = new Vector2(0f, 0f);
			distanceJointDef.localAnchorB = new Vector2(0f, 0f);
			if (A_0.c == 0)
			{
				Vector2 worldPoint = distanceJointDef.bodyA.GetWorldPoint(distanceJointDef.localAnchorA);
				Vector2 worldPoint2 = distanceJointDef.bodyB.GetWorldPoint(distanceJointDef.localAnchorB);
				Vector2 val = worldPoint2 - worldPoint;
				distanceJointDef.length = val.Length();
			}
			else if (A_0.c == 1)
			{
				Vector2 worldPoint3 = distanceJointDef.bodyA.GetWorldPoint(distanceJointDef.localAnchorA);
				Vector2 worldPoint4 = distanceJointDef.bodyB.GetWorldPoint(distanceJointDef.localAnchorB);
				Vector2 val2 = default(Vector2);
				val2 = new Vector2(A_0.f, A_0.h);
				Vector2 val3 = default(Vector2);
				val3 = new Vector2(A_0.g, A_0.i);
				distanceJointDef.localAnchorA = val2 - worldPoint3;
				distanceJointDef.localAnchorB = val3 - worldPoint4;
				Vector2 val4 = val3 - val2;
				distanceJointDef.length = val4.Length();
			}
			else if (A_0.c == 2)
			{
				distanceJointDef.localAnchorA = new Vector2(A_0.f, A_0.h);
				distanceJointDef.localAnchorB = new Vector2(A_0.g, A_0.i);
				Vector2 val5 = distanceJointDef.bodyB.GetWorldPoint(distanceJointDef.localAnchorB) - distanceJointDef.bodyA.GetWorldPoint(distanceJointDef.localAnchorA);
				distanceJointDef.length = val5.Length();
			}
			return k.CreateJoint(jointDef);
		}
		return null;
	}

	private Body u(string A_0)
	{
		for (int num = 0; num < r.Count; num++)
		{
			if (r[num].q == A_0)
			{
				return r[num].o;
			}
		}
		return null;
	}

	public ct ap()
	{
		ct ct2 = new ct("ground", new global::a());
		ct2.o = u((l.l + l.m) / 2f, 5f, 2000f, 10f, 0f, ct2.p.t, ct2.p.u, ct2.p.v, ct2.p.k);
		ct2.f = ct2.p.w;
		d d2 = new d();
		d2.a = ct2.q;
		d2.b = ct2.p.k;
		d2.c = ct2;
		ct2.o.SetUserData(d2);
		return ct2;
	}

	public void u(ct A_0, string A_1, int A_2)
	{
		float num = 1f;
		float num2 = 1f;
		if (float.IsNaN(A_0.p.i) || A_0.p.i == 0f)
		{
			num = A_0.m.c;
			num2 = A_0.m.d;
		}
		else
		{
			num = A_0.p.i * 2f;
			num2 = A_0.p.i * 2f;
		}
		p.b(A_1, A_2, A_0.c, A_0.d, num, num2, A_0.e);
	}

	public void w(ct A_0)
	{
		r.Add(A_0);
	}

	public void v(ct A_0)
	{
		if (an().a8 == A_0)
		{
			an().a8 = null;
		}
		if (ah() == A_0)
		{
			u((cy)null);
		}
		A_0.o.SetUserData(null);
		k.DestroyBody(A_0.o);
		r.Remove(A_0);
		if (A_0.p.h == BlockGroup.BIRDS)
		{
			t.Remove((cy)A_0);
		}
		if (this.m_v != null && A_0 == this.m_v)
		{
			u(cf.b.i);
		}
	}

	private ct v()
	{
		ct ct2 = null;
		bool flag = false;
		for (int num = 0; num < r.Count; num++)
		{
			if (this.m_x == "Level34" && r[num].q == "ExtraBeachBall_1")
			{
				v("Level3");
				ct2 = r[num];
				break;
			}
			if (this.m_x == "LevelP3_220" && r[num].q == "StaticBalloon03_2")
			{
				v("Level10");
				ct2 = r[num];
				break;
			}
			if (this.m_x == "LevelP2_64" && r[num].q == "ExtraGoldenEgg_1")
			{
				v("Level9");
				ct2 = r[num];
				flag = true;
				break;
			}
			if (this.m_x == "LevelP2_67" && r[num].q == "ExtraGoldenEgg_1")
			{
				v("Level2");
				ct2 = r[num];
				flag = true;
				break;
			}
			if (this.m_x == "LevelP3_313" && r[num].q == "ExtraGoldenEgg_1")
			{
				v("Level13");
				ct2 = r[num];
				flag = true;
				break;
			}
			if (this.m_x == "LevelP4_440" && r[num].q == "ExtraGoldenEgg_1")
			{
				v("Level14");
				ct2 = r[num];
				flag = true;
				break;
			}
			if (this.m_x == "LevelP4_444" && r[num].q == "ExtraRubberDuck_1")
			{
				v("Level15");
				ct2 = r[num];
				flag = true;
				break;
			}
			if (this.m_x == "LevelP4_478" && r[num].q == "ExtraGoldenEgg_1")
			{
				v("Level16");
				ct2 = r[num];
				flag = true;
				break;
			}
			if (this.m_x == "LevelP5_357" && r[num].q == "ExtraHolyGrail_4")
			{
				v("Level18");
				ct2 = r[num];
				flag = true;
				break;
			}
			if (this.m_x == "LevelP5_650" && r[num].q == "ExtraGoldenEgg_1")
			{
				v("Level19");
				ct2 = r[num];
				flag = true;
				break;
			}
			if (this.m_x == "LevelP5_364" && r[num].q == "ExtraGoldenEgg_1")
			{
				v("Level20");
				ct2 = r[num];
				flag = true;
				break;
			}
			if (this.m_x == "LevelP5_354" && r[num].q == "ExtraSuperBowl_2")
			{
				v("Level22");
				ct2 = r[num];
				ct2.u = ct2.m;
				flag = true;
				break;
			}
		}
		if (ct2 != null && global::d.p().s(a2()) != GoldenEggType.Locked)
		{
			if (flag)
			{
				v(ct2);
			}
			ct2 = null;
		}
		return ct2;
	}

	private ct u()
	{
		ct ct2 = null;
		for (int num = 0; num < r.Count; num++)
		{
			if (this.m_x == "Level5" && r[num].q == "ExtraTreasureChest_1")
			{
				v("Level6");
				ct2 = r[num];
				break;
			}
		}
		if (ct2 != null && global::d.p().s(a2()) != GoldenEggType.Locked)
		{
			ct2 = null;
		}
		return ct2;
	}

	public void ba()
	{
		List<cy> list = new List<cy>();
		r.Add(ap());
		this.m_aq = 0;
		for (int num = 0; num < l.a.Count; num++)
		{
			ct ct2 = l.a[num];
			float num2 = 1f;
			float num3 = 1f;
			float num4 = 0.92f;
			if (ct2.q == "ground" || (ct2.q == "ExtraBoomerangBird_1" && ay() && bo.a().d(this.m_x)))
			{
				continue;
			}
			ct2.e %= (float)Math.PI * 2f;
			if (ct2.e < 0f)
			{
				ct2.e += (float)Math.PI * 2f;
			}
			if (this.m_a2 == null)
			{
				this.m_a2 = new List<ae>();
			}
			if (this.m_a3 == null)
			{
				this.m_a3 = new List<List<ct>>();
			}
			if (ct2.u != null)
			{
				if (!this.m_a2.Contains(ct2.u))
				{
					this.m_a2.Add(ct2.u);
					List<ct> list2 = new List<ct>();
					list2.Add(ct2);
					this.m_a3.Add(list2);
				}
				else
				{
					int index = this.m_a2.IndexOf(ct2.u);
					this.m_a3[index].Add(ct2);
				}
			}
			switch (ct2.p.b)
			{
			case BlockBasicType.BOX:
			{
				if (ct2.m != null)
				{
					num2 = ct2.m.c;
					num3 = ct2.m.d;
					if (ct2.p.t == 0f)
					{
						num4 = 1f;
					}
					num2 = num2 * cf.PhysicsConfig.GetInvTimestep() * num4;
					num3 = num3 * cf.PhysicsConfig.GetInvTimestep() * num4;
				}
				ct2.o = u(ct2.c, ct2.d, num2, num3, ct2.e, ct2.p.t, ct2.p.u, ct2.p.v, ct2.p.k);
				d d4 = new d();
				d4.a = ct2.q;
				d4.b = ct2.p.k;
				d4.c = ct2;
				ct2.o.SetUserData(d4);
				break;
			}
			case BlockBasicType.CIRCLE:
			{
				if (ct2.p.i > 0f)
				{
					num2 = ct2.p.i;
				}
				else if (ct2.m != null)
				{
					num2 = (float)ct2.m.c / 2f * cf.PhysicsConfig.GetInvTimestep() * num4;
				}
				ct2.b = num2;
				ct2.o = u(ct2.c, ct2.d, num2, ct2.e, ct2.p.t, ct2.p.u, ct2.p.v);
				if (ct2.p.h == BlockGroup.BIRDS)
				{
					ct2.o.SetAngularDamping(2f);
				}
				d d3 = new d();
				d3.a = ct2.q;
				d3.b = ct2.p.k;
				d3.c = ct2;
				ct2.o.SetUserData(d3);
				break;
			}
			case BlockBasicType.POLYGON:
			{
				if (ct2.m != null)
				{
					num2 = ct2.m.c;
					num3 = ct2.m.d;
					if (ct2.p.t == 0f)
					{
						num4 = 1f;
					}
					num2 = num2 * cf.PhysicsConfig.GetInvTimestep() * num4;
					num3 = num3 * cf.PhysicsConfig.GetInvTimestep() * num4;
				}
				Vector2[] array = (Vector2[])(object)new Vector2[ct2.p.c.Length];
				for (int num5 = 0; num5 < array.Length; num5++)
				{
					array[num5].X = ct2.p.c[num5].X * num2 - num2 * 0.5f;
					array[num5].Y = ct2.p.c[num5].Y * num3 - num3 * 0.5f;
				}
				ct2.o = u(array, ct2.c, ct2.d, num2, num3, ct2.e, ct2.p.t, ct2.p.u, ct2.p.v);
				d d2 = new d();
				d2.a = ct2.q;
				d2.b = ct2.p.k;
				d2.c = ct2;
				ct2.o.SetUserData(d2);
				break;
			}
			}
			if (ct2.p.h != BlockGroup.BIRDS)
			{
				r.Add(ct2);
			}
			else
			{
				ct2.o.SetType(BodyType.Static);
				list.Add((cy)ct2);
			}
			if (ct2.p.h == BlockGroup.PIGLETTES && ((at)ct2.p).ar())
			{
				this.m_aq++;
			}
		}
		int num6 = 1;
		int num7 = 0;
		while (num7 < list.Count)
		{
			cy cy2 = list[num7];
			if (cy2.av() == num6)
			{
				s.Add(cy2);
				num6++;
				num7 = 0;
			}
			else
			{
				num7++;
			}
		}
		for (int num8 = 0; num8 < l.b.Count; num8++)
		{
			u(l.b[num8]);
		}
	}

	public void ao()
	{
		if (s.Count > 0)
		{
			if (s[0].al)
			{
				this.m_ad = true;
				return;
			}
			this.m_ad = false;
			a1.g(A_0: true);
			this.m_z.X = s[0].c;
			this.m_z.Y = s[0].d;
		}
	}

	public void a0()
	{
		if (s.Count > 0)
		{
			s[0].e = 0f;
			this.m_u.f(s[0]);
			s.RemoveAt(0);
			this.m_u.f(A_0: true);
		}
	}

	public void av()
	{
		if (this.m_ag != null)
		{
			this.m_ag.n();
		}
	}

	public void u(ct A_0)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		if (!(A_0.p.n > 0f))
		{
			return;
		}
		u(A_0, "explosion", 1);
		u(A_0, "explosionBuff", 1);
		Vector2 position = A_0.o.d.Position;
		for (int num = 0; num < r.Count; num++)
		{
			ct ct2 = r[num];
			if (ct2 != A_0 && ct2.p.h != BlockGroup.BIRDS)
			{
				Vector2 position2 = ct2.o.d.Position;
				float num2 = di.d(position2.X, position2.Y, position.X, position.Y);
				if (num2 < A_0.p.m)
				{
					Vector2 val = position2 - position;
					val.Normalize();
					float num3 = cf.PhysicsConfig.GetInvTimestep() * A_0.p.n / num2;
					ct2.o.ApplyLinearImpulse(val * num3, position2);
				}
				if (num2 < A_0.p.o && ct2.p.x < A_0.p.p / num2)
				{
					ct2.f -= A_0.p.p / num2;
					ct2.az();
				}
			}
		}
	}

	public void x(ct A_0)
	{
		int a_ = 12;
		if (A_0.p.g.h != null && A_0.p.g.h.Equals("smokeBuff"))
		{
			a_ = 1;
		}
		u(A_0, A_0.p.g.h, a_);
	}

	public void af()
	{
		n.b(A_0: true);
		if (this.m_ac)
		{
			an().h(2);
		}
	}

	public void ar()
	{
		an().h(1);
		this.m_ah = false;
		this.m_aw.i(0.5f);
		this.m_aw.g(A_0: true);
	}

	public void ac()
	{
		this.m_ay.i(2.5f);
		this.m_ay.g(A_0: true);
	}

	public void a6()
	{
		if (this.m_aq == 0)
		{
			u(cf.b.k);
		}
		else
		{
			u(cf.b.l);
		}
		cy cy2 = null;
		if (this.m_af == -1)
		{
			cy2 = this.m_u.j();
			this.m_af++;
		}
		else if (this.m_af < s.Count)
		{
			cy2 = s[this.m_af];
			this.m_af++;
		}
		if (cy2 != null)
		{
			g.y(1f);
			g.ac();
			at().a += 10000;
			q.a(cy2.c, cy2.d, cy2.ar(), 0f, 0.9f, 1f, 0f);
			this.m_ay.i(0.5f);
			if (this.m_af == s.Count)
			{
				this.m_ay.i(1f);
			}
			this.m_ay.g();
			this.m_ay.g(A_0: true);
			return;
		}
		this.m_af = -1;
		u(A_0: true);
		a8();
		if (aw() != cf.b.k)
		{
			return;
		}
		if (ay() && !bo.a().d(this.m_x))
		{
			u(cf.b.h);
		}
		bo.a().a(am(), at().d(), this.m_u.i());
		if (be())
		{
			for (int num = 0; num < dc.i.Length; num++)
			{
				if (this.m_x == dc.i[num])
				{
					global::d.p().p("Level" + (num + 1), GoldenEggType.Completed);
				}
			}
		}
		global::d.p().r();
		bo.a().b();
		bw.d().f(u);
	}

	public bool ay()
	{
		if (!(this.m_x == "LevelP3_271"))
		{
			return this.m_x == "LevelP4_426";
		}
		return true;
	}

	public void ax()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if ((int)this.m_b.w() == 0)
		{
			this.m_b.ae();
		}
		if ((int)this.m_c.w() == 0)
		{
			this.m_c.ae();
		}
		if ((int)this.m_d.w() == 0)
		{
			this.m_d.ae();
		}
	}

	public bool bd()
	{
		if (this.m_aa && !l.d)
		{
			return false;
		}
		if (this.m_aq > 0)
		{
			return false;
		}
		return true;
	}

	public bool a5()
	{
		if (this.m_aq == 0)
		{
			return false;
		}
		if (t.Count > 0)
		{
			return false;
		}
		if (this.m_aa && !l.d)
		{
			return false;
		}
		if (s.Count > 0 || this.m_u.j() != null || (ah() != null && ah().g))
		{
			return false;
		}
		return true;
	}

	public void u(float A_0)
	{
		for (int num = 0; num < r.Count; num++)
		{
			if (r[num].p.h == BlockGroup.PIGLETTES && ((at)r[num].p).ar())
			{
				((t)r[num]).j(A_0);
			}
		}
		for (int num2 = 0; num2 < s.Count; num2++)
		{
			if (num2 == 0 && a1.i())
			{
				s[num2].j(A_0, A_1: false);
			}
			else
			{
				s[num2].j(A_0, A_1: true);
			}
		}
		if (this.m_u.j() != null)
		{
			this.m_u.j().j(A_0, A_1: false);
		}
	}

	private void u(object A_0)
	{
	}
}
