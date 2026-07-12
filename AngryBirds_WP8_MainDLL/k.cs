using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class k : cd
{
	private new enum SliderState
	{
		a,
		b,
		c,
		d
	}

	private new List<ck> m_a;

	private da b;

	private da c;

	private SliderState m_d;

	private ae e;

	[CompilerGenerated]
	private int f;

	[CompilerGenerated]
	private float g;

	[SpecialName]
	[CompilerGenerated]
	public int be()
	{
		return f;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(int A_0)
	{
		f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float bf()
	{
		return g;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ai(float A_0)
	{
		g = A_0;
	}

	public k()
	{
		ai(0.1f);
		this.m_a = new List<ck>();
		this.m_d = k.SliderState.a;
		e = u.a().g("MENU_SLIDER_BG");
	}

	public void i(da A_0, da A_1)
	{
		if (b != null)
		{
			bf(b);
		}
		if (c != null)
		{
			bf(c);
		}
		c = A_1;
		c.af = base.af;
		c.ah = ((ck)this).ah;
		c.y = i;
		((ck)c).al = true;
		be(c);
		b = A_0;
		b.af = base.af;
		b.ah = ((ck)this).ah;
		b.y = i;
		((ck)b).al = true;
		be(b);
	}

	public void ag(ck A_0)
	{
		be(A_0);
		this.m_a.Add(A_0);
		A_0.ah = ((ck)this).ah;
		A_0.af = base.af;
		A_0.al = false;
		bf(c);
		be(c);
		bf(b);
		be(b);
	}

	public override void d(GameTime A_0)
	{
		base.d(A_0);
		float a_ = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		switch (this.m_d)
		{
		case k.SliderState.b:
			ag(a_);
			break;
		case k.SliderState.c:
			i(a_);
			break;
		}
	}

	public override void i()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if (this.m_a.Count > 0)
		{
			float num = Enumerable.First<ck>((IEnumerable<ck>)this.m_a).ak;
			if (num < 0f)
			{
				float num2 = ((ck)this).ah + num - (float)(be() / 2);
				float num3 = 0f - num - 15f + 15f + (float)(be() / 2);
				Rectangle a_ = default(Rectangle);
				a_ = new Rectangle(0, 0, 88, 15);
				bu.b().b(e, base.af, num2 - 15f, a_, 1f, 1f, 0f);
				a_ = new Rectangle(0, 30, 88, (int)num3);
				bu.b().b(e, base.af, num2 + 15f - 15f, a_, 1f, 1f, 0f);
			}
		}
		base.i();
	}

	private void ag(float A_0)
	{
		float num = -this.m_a.Count * be() - 15;
		float num2 = num / (bf() * (float)this.m_a.Count) * A_0;
		for (int num3 = 0; num3 < this.m_a.Count; num3++)
		{
			if (num3 == 0)
			{
				this.m_a[num3].ak += num2;
			}
			else if ((float)(num3 * -be()) > Enumerable.First<ck>((IEnumerable<ck>)this.m_a).ak)
			{
				this.m_a[num3].ak = Enumerable.First<ck>((IEnumerable<ck>)this.m_a).ak + (float)(num3 * be());
			}
			if (Enumerable.First<ck>((IEnumerable<ck>)this.m_a).ak <= num)
			{
				Enumerable.First<ck>((IEnumerable<ck>)this.m_a).ak = num;
				for (int num4 = 0; num4 < this.m_a.Count; num4++)
				{
					this.m_a[num4].ak = Enumerable.First<ck>((IEnumerable<ck>)this.m_a).ak + (float)(num4 * be());
					this.m_a[num4].al = true;
				}
				this.m_d = k.SliderState.d;
			}
			float num5 = (0f - Enumerable.First<ck>((IEnumerable<ck>)this.m_a).ak) / (float)(this.m_a.Count * be());
			num5 = (float)Math.Min(num5, 1.0);
			b.ag((float)Math.PI * num5);
		}
	}

	private void i(float A_0)
	{
		float num = 0f;
		float num2 = -this.m_a.Count * be() - 15;
		float num3 = num2 / (bf() * (float)this.m_a.Count) * A_0;
		for (int num4 = 0; num4 < this.m_a.Count; num4++)
		{
			this.m_a[num4].al = false;
			if (num4 == 0)
			{
				this.m_a[num4].ak -= num3;
			}
			else
			{
				this.m_a[num4].ak = Enumerable.First<ck>((IEnumerable<ck>)this.m_a).ak + (float)(num4 * be());
			}
			if (this.m_a[num4].ak >= num)
			{
				this.m_a[num4].ak = num;
			}
			if (Enumerable.First<ck>((IEnumerable<ck>)this.m_a).ak >= num)
			{
				this.m_d = k.SliderState.a;
			}
			float num5 = (0f - Enumerable.First<ck>((IEnumerable<ck>)this.m_a).ak) / (float)(this.m_a.Count * be());
			num5 = (float)Math.Min(num5, 1.0);
			b.ag((float)Math.PI * num5);
		}
	}

	private void i(ck A_0)
	{
		switch (this.m_d)
		{
		case k.SliderState.d:
			this.m_d = k.SliderState.c;
			break;
		case k.SliderState.a:
			this.m_d = k.SliderState.b;
			break;
		}
	}
}
