using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AngryBirds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class db : y
{
	private class DbAtlasPair
	{
		[CompilerGenerated]
		private ae a;

		[CompilerGenerated]
		private ae entryB;

		[CompilerGenerated]
		private int c;

		[CompilerGenerated]
		private int d;

		[SpecialName]
		[CompilerGenerated]
		public ae h()
		{
			return a;
		}

		[SpecialName]
		[CompilerGenerated]
		public void f(ae A_0)
		{
			a = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public ae g()
		{
			return entryB;
		}

		[SpecialName]
		[CompilerGenerated]
		public void e(ae A_0)
		{
			entryB = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int e()
		{
			return c;
		}

		[SpecialName]
		[CompilerGenerated]
		public void f(int A_0)
		{
			c = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int f()
		{
			return d;
		}

		[SpecialName]
		[CompilerGenerated]
		public void e(int A_0)
		{
			d = A_0;
		}
	}

	private class DbSpriteInfo
	{
		[CompilerGenerated]
		private ae a;

		[CompilerGenerated]
		private ae m_imgB;

		[CompilerGenerated]
		private float c;

		[CompilerGenerated]
		private float d;

		[CompilerGenerated]
		private float e;

		[CompilerGenerated]
		private float f;

		[CompilerGenerated]
		private float g;

		[CompilerGenerated]
		private float h;

		[CompilerGenerated]
		private float i;

		[CompilerGenerated]
		private int j;

		[CompilerGenerated]
		private int k;

		[CompilerGenerated]
		private bool l;

		[CompilerGenerated]
		private int m;

		[SpecialName]
		[CompilerGenerated]
		public ae u()
		{
			return a;
		}

		[SpecialName]
		[CompilerGenerated]
		public void o(ae A_0)
		{
			a = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public ae s()
		{
			return m_imgB;
		}

		[SpecialName]
		[CompilerGenerated]
		public void n(ae A_0)
		{
			m_imgB = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float v()
		{
			return c;
		}

		[SpecialName]
		[CompilerGenerated]
		public void p(float A_0)
		{
			c = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float o()
		{
			return d;
		}

		[SpecialName]
		[CompilerGenerated]
		public void q(float A_0)
		{
			d = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float t()
		{
			return e;
		}

		[SpecialName]
		[CompilerGenerated]
		public void t(float A_0)
		{
			e = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float x()
		{
			return f;
		}

		[SpecialName]
		[CompilerGenerated]
		public void s(float A_0)
		{
			f = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float n()
		{
			return g;
		}

		[SpecialName]
		[CompilerGenerated]
		public void n(float A_0)
		{
			g = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float r()
		{
			return h;
		}

		[SpecialName]
		[CompilerGenerated]
		public void o(float A_0)
		{
			h = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float y()
		{
			return i;
		}

		[SpecialName]
		[CompilerGenerated]
		public void r(float A_0)
		{
			i = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int p()
		{
			return j;
		}

		[SpecialName]
		[CompilerGenerated]
		public void p(int A_0)
		{
			j = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int w()
		{
			return k;
		}

		[SpecialName]
		[CompilerGenerated]
		public void o(int A_0)
		{
			k = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public bool z()
		{
			return l;
		}

		[SpecialName]
		[CompilerGenerated]
		public void n(bool A_0)
		{
			l = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int q()
		{
			return m;
		}

		[SpecialName]
		[CompilerGenerated]
		public void n(int A_0)
		{
			m = A_0;
		}

		public bool n(Vector2 A_0)
		{
			if (t() - (float)u().c * y() / 2f <= A_0.X && A_0.X <= t() + (float)u().c * y() / 2f && x() - (float)u().d * y() / 2f <= A_0.Y && A_0.Y <= x() + (float)u().d * y() / 2f)
			{
				return true;
			}
			return false;
		}
	}

	private u e = u.a();

	private List<DbAtlasPair> f = new List<DbAtlasPair>();

	private new List<DbSpriteInfo> m_g = new List<DbSpriteInfo>();

	private new Stack<DbSpriteInfo> m_h = new Stack<DbSpriteInfo>();

	private new string[] m_i = new string[7] { "bird_01_flying", "bird_02_flying", "bird_03_flying", "bird_04_flying", "bird_05_flying", "bird_06_flying", "big_brother_flying" };

	private float m_j = 1f;

	private new float k = 1.83f;

	private new float l;

	private new DateTime m;

	[CompilerGenerated]
	private new bool n;

	[CompilerGenerated]
	private new r o;

	[SpecialName]
	[CompilerGenerated]
	public bool i()
	{
		return n;
	}

	[SpecialName]
	[CompilerGenerated]
	public void g(bool A_0)
	{
		n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public r j()
	{
		return o;
	}

	[SpecialName]
	[CompilerGenerated]
	public void g(r A_0)
	{
		o = A_0;
	}

	public override void an()
	{
		base.an();
		this.m_j = 0.6f / (k * 0.66f);
		if (d.p().ac() != null)
		{
			di.d().m(d.p().ac());
		}
		ao();
	}

	public override void ao()
	{
		f.Clear();
		if (di.d().f() == null)
		{
			di.d().m("theme1");
		}
		for (int num = 0; num < dc.e.Length; num++)
		{
			if (d.p().p(dc.e[num]))
			{
				List<DbAtlasPair> list = f;
				DbAtlasPair a10 = new DbAtlasPair();
				a10.f(e.g(dc.e[num]));
				a10.e(e.g(dc.e[num] + "_YELL"));
				a10.f(0);
				a10.e(num);
				list.Add(a10);
			}
		}
		if (f.Count == 0)
		{
			List<DbAtlasPair> list2 = f;
			DbAtlasPair a11 = new DbAtlasPair();
			a11.f(e.g("BIRD_RED"));
			a11.e(e.g("BIRD_RED_YELL"));
			a11.f(0);
			a11.e(0);
			list2.Add(a11);
		}
		bo bo2 = bo.a();
		if (bo2.f("episode1") && !dc.IsTrial())
		{
			if (bo2.c("episode1"))
			{
				List<DbAtlasPair> list3 = f;
				DbAtlasPair a12 = new DbAtlasPair();
				a12.f(e.g("REWARD_1_STAR"));
				a12.f(1);
				list3.Add(a12);
				List<DbAtlasPair> list4 = f;
				DbAtlasPair a13 = new DbAtlasPair();
				a13.f(e.g("REWARD_1_STAR"));
				a13.f(1);
				list4.Add(a13);
			}
			else
			{
				List<DbAtlasPair> list5 = f;
				DbAtlasPair a14 = new DbAtlasPair();
				a14.f(e.g("REWARD_1"));
				a14.f(1);
				list5.Add(a14);
				List<DbAtlasPair> list6 = f;
				DbAtlasPair a15 = new DbAtlasPair();
				a15.f(e.g("REWARD_1"));
				a15.f(1);
				list6.Add(a15);
			}
		}
		if (bo2.f("episode2"))
		{
			if (bo2.c("episode2"))
			{
				List<DbAtlasPair> list7 = f;
				DbAtlasPair a16 = new DbAtlasPair();
				a16.f(e.g("REWARD_2_STAR"));
				a16.f(1);
				list7.Add(a16);
				List<DbAtlasPair> list8 = f;
				DbAtlasPair a17 = new DbAtlasPair();
				a17.f(e.g("REWARD_2_STAR"));
				a17.f(1);
				list8.Add(a17);
			}
			else
			{
				List<DbAtlasPair> list9 = f;
				DbAtlasPair a18 = new DbAtlasPair();
				a18.f(e.g("REWARD_2"));
				a18.f(1);
				list9.Add(a18);
				List<DbAtlasPair> list10 = f;
				DbAtlasPair a19 = new DbAtlasPair();
				a19.f(e.g("REWARD_2"));
				a19.f(1);
				list10.Add(a19);
			}
		}
		if (bo2.f("episode3"))
		{
			if (bo2.c("episode3"))
			{
				List<DbAtlasPair> list11 = f;
				DbAtlasPair a20 = new DbAtlasPair();
				a20.f(e.g("REWARD_3_STAR"));
				a20.f(2);
				list11.Add(a20);
			}
			else
			{
				List<DbAtlasPair> list12 = f;
				DbAtlasPair a21 = new DbAtlasPair();
				a21.f(e.g("REWARD_3"));
				a21.f(2);
				list12.Add(a21);
			}
		}
		if (bo2.f("episode4"))
		{
			if (bo2.c("episode4"))
			{
				List<DbAtlasPair> list13 = f;
				DbAtlasPair a22 = new DbAtlasPair();
				a22.f(e.g("REWARD_4_STAR"));
				a22.f(1);
				list13.Add(a22);
				List<DbAtlasPair> list14 = f;
				DbAtlasPair a23 = new DbAtlasPair();
				a23.f(e.g("REWARD_4_STAR"));
				a23.f(1);
				list14.Add(a23);
			}
			else
			{
				List<DbAtlasPair> list15 = f;
				DbAtlasPair a24 = new DbAtlasPair();
				a24.f(e.g("REWARD_4"));
				a24.f(1);
				list15.Add(a24);
				List<DbAtlasPair> list16 = f;
				DbAtlasPair a25 = new DbAtlasPair();
				a25.f(e.g("REWARD_4"));
				a25.f(1);
				list16.Add(a25);
			}
		}
		if (bo2.f("episode5"))
		{
			if (bo2.c("episode5"))
			{
				List<DbAtlasPair> list17 = f;
				DbAtlasPair a26 = new DbAtlasPair();
				a26.f(e.g("REWARD_5_STAR"));
				a26.f(1);
				list17.Add(a26);
				List<DbAtlasPair> list18 = f;
				DbAtlasPair a27 = new DbAtlasPair();
				a27.f(e.g("REWARD_5_STAR"));
				a27.f(1);
				list18.Add(a27);
			}
			else
			{
				List<DbAtlasPair> list19 = f;
				DbAtlasPair a28 = new DbAtlasPair();
				a28.f(e.g("REWARD_5"));
				a28.f(1);
				list19.Add(a28);
				List<DbAtlasPair> list20 = f;
				DbAtlasPair a29 = new DbAtlasPair();
				a29.f(e.g("REWARD_5"));
				a29.f(1);
				list20.Add(a29);
			}
		}
	}

	public override void ap(GameTime A_0)
	{
		base.ap(A_0);
		float a_ = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		DateTime now = DateTime.Now;
		float num = (float)(now - m).Ticks / 10000f;
		if (num > 60f)
		{
			num = 33f;
		}
		m = now;
		l += 1.5f * num / 30f;
		g(a_);
	}

	public override void aq(float A_0, float A_1)
	{
		bu bu2 = bu.b();
		h();
		for (int num = 0; num < this.m_g.Count; num++)
		{
			DbSpriteInfo b10 = this.m_g[num];
			if (b10.p() == 3)
			{
				float num2 = ((b10.w() > 0) ? (b10.y() * 0.45f) : 0.7f);
				bu2.b(b10.u(), b10.t(), b10.x(), num2, num2, b10.v());
			}
		}
		for (int num3 = 0; num3 < this.m_g.Count; num3++)
		{
			DbSpriteInfo b11 = this.m_g[num3];
			if (b11.p() == 4)
			{
				float num4 = ((b11.w() > 0) ? (b11.y() * 0.6f) : 0.85f);
				bu2.b(b11.u(), b11.t(), b11.x(), num4, num4, b11.v());
			}
		}
		for (int num5 = 0; num5 < this.m_g.Count; num5++)
		{
			DbSpriteInfo b12 = this.m_g[num5];
			if (b12.p() == 5)
			{
				float num6 = ((b12.w() > 0) ? (b12.y() * 0.75f) : 1f);
				bu2.b(b12.u(), b12.t() / num6, b12.x() / num6, num6, num6, b12.v());
			}
		}
		g();
	}

	private void h()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		bu bu2 = bu.b();
		float a_ = 408f;
		float num = 1f;
		float a_2 = 0f;
		a2 a10 = di.d().f();
		bu2.b(a10.e);
		bu.a.Clear(bu2.f());
		bu2.b(Color.White);
		float num2 = this.m_j;
		for (int num3 = 0; num3 < a10.c.Count; num3++)
		{
			c5 c10 = a10.c[num3];
			if (c10.a == null)
			{
				continue;
			}
			num = num2 * c10.e;
			float num4 = (0f - l) * num2 * c10.d;
			float num5 = (float)c10.a.c * num - 1f;
			float num6 = 800f / num2;
			if (c10.f)
			{
				int num7 = (int)(num6 / num5) + 2;
				float num8 = num4 % num5 - (float)c10.a.e * num;
				if (num4 > 0f)
				{
					num8 -= num5;
				}
				while (num7 >= 0)
				{
					bu2.b(c10.a, num8, a_, num, num, a_2);
					num8 += num5;
					num7--;
				}
			}
			else
			{
				int num9 = (int)(num6 / (num5 + c10.g * num)) + 2;
				float num10 = num4 % (num5 + c10.g * num) - (float)c10.a.e * num;
				if (num4 > 0f)
				{
					num10 -= c10.g * num;
				}
				while (num9 >= 0)
				{
					bu2.b(c10.a, num10, a_, num, num, a_2);
					num10 += c10.g * num + num5;
					num9--;
				}
			}
		}
	}

	private void g()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		float num = this.m_j;
		float num2 = 1.5f;
		float num3 = 408f;
		float num4 = 1f;
		float a_ = 0f;
		a2 a10 = di.d().f();
		c5 c10 = a10.d[0];
		bu.b().b(a10.f);
		bu.b().b(0f, num3, 800f, 481f);
		bu.b().b(Color.White);
		num4 = num * num2;
		for (int num5 = 0; num5 < a10.d.Count; num5++)
		{
			c10 = a10.d[num5];
			float num6 = (0f - l) * num;
			float num7 = (float)c10.a.c * num4 - 1f;
			float num8 = 800f / num;
			int num9 = (int)(num8 / num7) + 2;
			float num10 = num6 % num7 - (float)c10.a.e * num4;
			if (num6 > 0f)
			{
				num10 -= num7;
			}
			while (num9 >= 0)
			{
				bu.b().b(c10.a, num10, num3, num4, num4, a_);
				num10 += num7;
				num9--;
			}
		}
	}

	private void g(float A_0)
	{
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		float num = (float)f.Count * 3f;
		if ((float)this.m_g.Count < num && b9.a(1, 5) == 1)
		{
			int num2 = b9.a(3, 5);
			float a_ = b9.a(-600, 600);
			float a_2 = 480f + 30f * di.d().g();
			float num3 = (float)num2 * 0.2f;
			float num4 = (float)b9.a(100, 350) * num3 * (di.d().e() + 1f) * 0.5f;
			float num5 = (float)b9.a(-400, -150) * num3 * (di.d().g() + 1f) * 0.5f;
			if (num2 == 1)
			{
				num5 *= 1.75f;
				num4 *= 1.75f;
			}
			DbAtlasPair a10 = f[b9.a(f.Count - 1)];
			ae a_3 = a10.h();
			int num6 = a10.e();
			float a_4 = 0f;
			switch (num6)
			{
			case 1:
				a_4 = b9.a() * (float)Math.PI * 1.5f;
				break;
			case 2:
				a_ = b9.a(80, 719);
				num5 = (float)b9.a(-250, -150) * num3 * (di.d().g() + 1f) * 0.175f;
				num4 = 0f;
				break;
			}
			DbSpriteInfo b10 = null;
			b10 = ((this.m_h.Count <= 0) ? new DbSpriteInfo() : this.m_h.Pop());
			b10.o(a_3);
			b10.n(a10.g());
			b10.p(0f);
			b10.q(a_4);
			b10.t(a_);
			b10.s(a_2);
			b10.n(num4);
			b10.o(num5);
			b10.r(num3);
			b10.p(num2);
			b10.o(num6);
			b10.n(a10.f());
			b10.n(A_0: false);
			this.m_g.Add(b10);
		}
		for (int num7 = this.m_g.Count - 1; num7 >= 0; num7--)
		{
			DbSpriteInfo b11 = this.m_g[num7];
			if (b11.w() == 2)
			{
				b11.p((float)Math.Sin(b11.o()) * 0.15f);
				b11.q((b11.o() + A_0 * 2f) % ((float)Math.PI * 2f));
				b11.t(b11.t() - b11.v() * (float)b11.p() * 0.5f);
			}
			else
			{
				b11.o(b11.r() + 150f * A_0);
				b11.p(b11.v() + b11.o() * A_0);
			}
			b11.t(b11.t() + b11.n() * A_0);
			b11.s(b11.x() + b11.r() * A_0);
			if (b11.x() > 480f + 50f * di.d().g() || b11.t() > 800f + 50f * di.d().e() || (b11.w() == 2 && b11.x() < (float)(-b11.u().d)))
			{
				this.m_h.Push(this.m_g[num7]);
				this.m_g.RemoveAt(num7);
			}
		}
		if (!i())
		{
			return;
		}
		Controls instance = Controls.GetInstance();
		for (int num8 = 0; num8 < this.m_g.Count; num8++)
		{
			if (this.m_g[num8].p() != 5)
			{
				continue;
			}
			for (int num9 = 0; num9 < instance.Touches.Count; num9++)
			{
				TouchLocation val = instance.Touches[num9];
				if (this.m_g[num8].w() == 0 && !this.m_g[num8].z() && this.m_g[num8].n(val.Position) && !j().e((int)val.Position.X, (int)val.Position.Y))
				{
					this.m_g[num8].n(A_0: true);
					this.m_g[num8].o(this.m_g[num8].s());
					int num10 = this.m_g[num8].q();
					b0.d().d(this.m_i[num10]).ac();
				}
			}
		}
	}
}
