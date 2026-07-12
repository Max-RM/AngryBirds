using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AngryBirds;
using Microsoft.Xna.Framework;

internal class z : c
{
	public new class LevelButton : cd
	{
		private da m_m;

		private ae[] m_n = new ae[3];

		private int m_o;

		[CompilerGenerated]
		private da m_p;

		[CompilerGenerated]
		private string m_q;

		[CompilerGenerated]
		private string m_r;

		[CompilerGenerated]
		private da m_s;

		[CompilerGenerated]
		private bool t;

		[CompilerGenerated]
		private cr u;

		public da m
		{
			[CompilerGenerated]
			get
			{
				return this.m_p;
			}
			[CompilerGenerated]
			set
			{
				this.m_p = value;
			}
		}

		public string n
		{
			[CompilerGenerated]
			get
			{
				return this.m_q;
			}
			[CompilerGenerated]
			set
			{
				this.m_q = value;
			}
		}

		public string o
		{
			[CompilerGenerated]
			get
			{
				return this.m_r;
			}
			[CompilerGenerated]
			set
			{
				this.m_r = value;
			}
		}

		public da p
		{
			[CompilerGenerated]
			get
			{
				return this.m_s;
			}
			[CompilerGenerated]
			set
			{
				this.m_s = value;
			}
		}

		public bool q
		{
			[CompilerGenerated]
			get
			{
				return t;
			}
			[CompilerGenerated]
			set
			{
				t = value;
			}
		}

		public cr r
		{
			[CompilerGenerated]
			get
			{
				return u;
			}
			[CompilerGenerated]
			set
			{
				u = value;
			}
		}

		public int s
		{
			get
			{
				return this.m_o;
			}
			set
			{
				this.m_o = value;
				if (this.m_o > 0 && this.m_o <= 3)
				{
					this.m_m.i(this.m_n[value - 1]);
					this.m_m.am = true;
				}
				else
				{
					this.m_m.am = false;
				}
			}
		}

		public LevelButton()
		{
			q = false;
		}

		public void i(float A_0, float A_1)
		{
			base.af = A_0;
			((ck)this).ah = A_1;
			m.af = A_0;
			m.ah = A_1;
			r.af = A_0;
			r.ah = A_1;
			p.af = A_0;
			p.ah = A_1;
			this.m_m.af = A_0;
			this.m_m.ah = A_1 + (float)(global::u.a().g("LS_LEVEL_BG_NORMAL_OPEN_1").d / 2);
		}

		public void ag(float A_0, float A_1)
		{
			u u2 = global::u.a();
			this.m_n[0] = u2.g("LS_STARS_1");
			this.m_n[1] = u2.g("LS_STARS_2");
			this.m_n[2] = u2.g("LS_STARS_3");
			base.af = A_0;
			((ck)this).ah = A_1;
			base.ad = new a7(bn.b, dh.b);
			m = new da
			{
				af = A_0,
				ah = A_1
			};
			cr cr2 = new cr();
			cr2.af = A_0;
			cr2.ah = A_1;
			cr2.i(u2.a("FONT_BASIC_WP7.dat"));
			r = cr2;
			da da2 = new da();
			da2.af = A_0;
			da2.ah = A_1;
			da2.i(u2.g("LS_LEVEL_BG_NORMAL_CLOSED"));
			p = da2;
			this.m_m = new da
			{
				af = A_0,
				ah = A_1 + (float)(u2.g("LS_LEVEL_BG_NORMAL_OPEN_1").d / 2)
			};
			be(m);
			be(r);
			be(this.m_m);
			be(p);
			bk();
		}

		public void be()
		{
			if (!dc.IsTrial() || di.d().j(n))
			{
				p.am = false;
				((ck)this).al = true;
			}
		}

		public void bk()
		{
			p.am = true;
			((ck)this).al = false;
		}
	}

	private c9 s;

	private ch t;

	private List<LevelButton> v = new List<LevelButton>();

	private int w;

	private bool x;

	private LevelButton m_levelButton;

	private ck m_targetCk;

	private bool aa;

	private bool ab;

	private ck ac;

	private int ad;

	private List<da> ae = new List<da>();

	private av af;

	[CompilerGenerated]
	private List<Color> ag;

	[CompilerGenerated]
	private string ah;

	[SpecialName]
	[CompilerGenerated]
	public List<Color> a2()
	{
		return ag;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void a(List<Color> A_0)
	{
		ag = A_0;
	}

	[SpecialName]
	protected c9 a1()
	{
		return s;
	}

	[SpecialName]
	protected ch a0()
	{
		return t;
	}

	[SpecialName]
	[CompilerGenerated]
	protected string aw()
	{
		return ah;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void a(string A_0)
	{
		ah = A_0;
	}

	public override void e()
	{
		base.e();
		u u2 = u.a();
		SetLayout(new y());
		a3().an();
		a3().g(u2.g("LS_BACKGROUND"));
		c9 c10 = new c9();
		c10.ag(A_0: true);
		c10.ai(A_0: true);
		c10.bg(A_0: false);
		s = c10;
	}

	public override void f()
	{
		base.f();
		aa = false;
	}

	public override void h(GameTime A_0)
	{
		global::s.a().a("title_theme");
		au();
		bool a_ = dc.IsTrial() && af.a == "episode1" && bo.a().a("pack1");
		for (int num = 0; num < ae.Count; num++)
		{
			((ck)ae[num]).al = a_;
			ae[num].am = a_;
		}
		if (!x)
		{
			w = d.p().y()[bd()] - 1;
			s.ag(s.bw()[w]);
		}
		x = false;
		au("episodeSelectionPage");
		SetMenuState(global::m.MenuState.a);
	}

	public override void b(GameTime A_0)
	{
		d.p().y()[bd()] = s.bh() + 1;
		a8().f(A_0: false);
		SetMenuState(global::m.MenuState.b);
	}

	public override void g(GameTime A_0)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		base.g(A_0);
		if (a8().ba() && m_targetCk != null)
		{
			if (!aa)
			{
				f(m_targetCk);
			}
			return;
		}
		if (ab)
		{
			((ck)s).al = false;
			ad -= A_0.ElapsedGameTime.Milliseconds;
			if (ad < 0)
			{
				s.bf(A_0: true);
				s.ai(ac);
				ab = false;
				ac = null;
				ad = 0;
				((ck)s).al = true;
			}
		}
		s.d(A_0);
		int num = s.bh();
		float num2 = (0f - ((ck)s).aj) / 800f;
		if (num2 <= 0f)
		{
			a3().g(a2()[0]);
		}
		else if (num2 >= (float)(s.bw().Count - 1))
		{
			a3().g(a2()[s.bw().Count - 1]);
		}
		else
		{
			int num3 = (int)Math.Floor(num2);
			float num4 = num2 - (float)num3;
			a3().g(Color.Lerp(a2()[num3], a2()[num3 + 1], num4));
		}
		if (num != t.bf())
		{
			t.i(num);
		}
	}

	public override void a()
	{
		base.a();
		s.bs();
	}

	protected void a(int A_0, bool A_1)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (A_0 > 0)
		{
			if (A_1)
			{
				p(s);
			}
			List<string> list = new List<string>(A_0);
			for (int num = 0; num < A_0; num++)
			{
				s.be(new cd
				{
					al = true,
					af = 800f * ((float)num + 0.5f),
					ah = 240f
				});
				list.Add((num + 1).ToString());
			}
			s.bo();
			s.bt();
			if (t == null)
			{
				p(t = new ch());
			}
			t.i(new Vector2(400f, 473f), list);
			af = null;
		}
	}

	protected void a(av A_0)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		if (A_0 != null || A_0.b != null)
		{
			p(s);
			u.a();
			List<string> list = new List<string>(A_0.b.Count);
			for (int num = 0; num < A_0.b.Count; num++)
			{
				a8 a10 = di.d().f(A_0.b[num]);
				s.be(a(A_0.b[num], new Vector2(800f * ((float)num + 0.5f), 240f), u.a().g(a10.c)));
				list.Add(a10.d.ToString());
			}
			s.bo();
			s.bt();
			p(t = new ch());
			t.i(new Vector2(400f, 473f), list);
			((ck)t).am = list.Count > 1;
			af = A_0;
		}
	}

	private cd a(string A_0, Vector2 A_1, ae A_2)
	{
		u u2 = u.a();
		a8 a10 = di.d().f(A_0);
		int num = A_2.c;
		int num2 = A_2.d;
		int num3 = 40;
		int num4 = 40;
		int num5 = 15;
		int num6 = 140;
		int num7 = 3;
		int num8 = 800 - num3 - num4;
		int num9 = 480 - num5 - num6;
		float num10 = A_1.X - 400f;
		float num11 = A_1.Y - 240f;
		int num12 = a10.b.Count / num7;
		int num13 = 10;
		int num14 = 10;
		if (num12 > 1)
		{
			num13 = (num8 - num12 * num) / (num12 - 1);
			num14 = (num9 - num7 * num2) / (num7 - 1);
		}
		cd cd2 = new cd();
		((ck)cd2).al = true;
		cd2.af = A_1.X;
		((ck)cd2).ah = A_1.Y;
		cd cd3 = cd2;
		for (int num15 = 0; num15 < num7; num15++)
		{
			for (int num16 = 0; num16 < num12; num16++)
			{
				string a_ = a10.b[num16 + num15 * num12];
				l l2 = bo.a().e(a_);
				LevelButton a11 = new LevelButton();
				a11.ag(num10 + (float)(num / 2) + (float)num3 + (float)(num16 * num) + (float)(num16 * num13), num11 + (float)(num2 / 2) + (float)num5 + (float)(num15 * num2) + (float)(num15 * num14));
				a11.m.i(A_2);
				a11.s = l2.b;
				a11.n = a_;
				a11.o = A_0;
				a11.r.i((num16 + num15 * num12 + 1).ToString());
				a11.y = o;
				cd3.be(a11);
				if (a10.e)
				{
					v.Add(a11);
				}
			}
		}
		if (dc.IsTrial() && (A_0 == "pack2" || A_0 == "pack3"))
		{
			da da2 = new da();
			da2.i(u.a().g("BTN_FULL_WP7_BG"));
			da2.af = A_1.X;
			da2.ah = A_1.Y - 62f;
			((ck)da2).al = true;
			da2.y = e;
			da da3 = da2;
			ae.Add(da3);
			cd3.be(da3);
			da da4 = new da();
			da4.i(u.a().i("TEXT_FULL_WP7"));
			da4.af = A_1.X;
			da4.ah = A_1.Y - 62f;
			da da5 = da4;
			ae.Add(da5);
			cd3.be(da5);
		}
		else if (!a10.e)
		{
			da da6 = new da();
			da6.i(u2.g("COMING_SOON_BG"));
			da6.af = A_1.X;
			da6.ah = A_1.Y;
			cd3.be(da6);
			da da7 = new da();
			da7.i(u2.i("TEXT_COMING_SOON"));
			da7.af = A_1.X;
			da7.ah = A_1.Y - 20f;
			cd3.be(da7);
		}
		return cd3;
	}

	public void az()
	{
		for (int num = 0; num < ae.Count; num++)
		{
			ae[num].am = false;
		}
		au();
	}

	private void au()
	{
		int num = -1;
		for (int num2 = 0; num2 < v.Count; num2++)
		{
			l l2 = bo.a().e(v[num2].n);
			v[num2].s = l2.b;
			if (bo.a().d(v[num2].n))
			{
				v[num2].be();
				num = num2;
			}
			if (num2 == num + 1)
			{
				v[num2].be();
			}
		}
	}

	protected virtual void f(ck A_0)
	{m_levelButton = (LevelButton)A_0;
		av av2 = di.d().k(m_levelButton.o);
		string text = m_levelButton.n;
		string value = Enumerable.First<string>((IEnumerable<string>)di.d().f(m_levelButton.o).b);
		bool flag = text.Equals(value) && Enumerable.First<string>((IEnumerable<string>)av2.b).Equals(m_levelButton.o);
		if (aw() != null && !x && flag)
		{
			x = true;
			cm cm2 = (cm)n.e()[aw()];
			cm2.a(ay);
			n.c(aw());
		}
		else if (m_levelButton.n != null)
		{
			x = false;
			w = v.IndexOf(m_levelButton);
			@as as2 = (@as)a9().e()["gameplayPage"];
			as2.a(m_levelButton.o, m_levelButton.n, A_2: false);
			a9().c("gameplayPage");
		}
	}

	public void ay()
	{
		f(m_levelButton);
	}

	protected virtual void o(ck A_0)
	{
		m_levelButton = (LevelButton)A_0;
		av av2 = di.d().k(m_levelButton.o);
		string text = m_levelButton.n;
		string value = Enumerable.First<string>((IEnumerable<string>)di.d().f(m_levelButton.o).b);
		bool flag = text.Equals(value) && Enumerable.First<string>((IEnumerable<string>)av2.b).Equals(m_levelButton.o);
		if (aw() != null && flag)
		{
			f(A_0);
			return;
		}
		m_targetCk = A_0;
		aa = true;
		b0.d().k(A_0: true);
		a8().f(A_0: true);
	}

	public void ax()
	{
		if (af == null)
		{
			return;
		}
		w++;
		bool flag = false;
		if (w >= v.Count)
		{
			w = 0;
			flag = true;
		}
		int num = 0;
		for (int num2 = 0; num2 < Enumerable.Count<ck>((IEnumerable<ck>)s.bw()); num2++)
		{
			if (((cd)s.bw()[num2]).bw().Contains(v[w]))
			{
				num = num2;
				break;
			}
		}
		if (flag && num < Enumerable.Count<string>((IEnumerable<string>)af.b) - 1)
		{
			a8 a10 = di.d().f(af.b[num + 1]);
			if (!a10.e)
			{
				num++;
			}
		}
		if (num >= Enumerable.Count<ck>((IEnumerable<ck>)s.bw()))
		{
			num = 0;
		}
		ck ck2 = s.bw()[num];
		x = true;
		ab = true;
		ac = ck2;
		ad = 250;
	}

	protected void e(ck A_0)
	{
		if (dc.IsTrial())
		{
			GameMain.Instance.ShowMarket();
		}
	}
}
