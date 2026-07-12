using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class y
{
	private enum a
	{
		a,
		b,
		c
	}

	private Color m_a = Color.Transparent;

	private Color b = Color.Transparent;

	private float c;

	private a d = y.a.c;

	private bool e;

	private bool f;

	[CompilerGenerated]
	private ae m_g;

	[CompilerGenerated]
	private bool m_h;

	[SpecialName]
	[CompilerGenerated]
	public ae k()
	{
		return this.m_g;
	}

	[SpecialName]
	[CompilerGenerated]
	public void g(ae A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void h(bool A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	public void g(Color A_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		b = A_0;
	}

	[SpecialName]
	public bool n()
	{
		return f;
	}

	[SpecialName]
	public void i(bool A_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		f = A_0;
		this.m_a = ((d != y.a.b) ? Color.Transparent : this.m_a);
	}

	public y()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		h(A_0: true);
		g((ae)null);
		i(A_0: false);
	}

	public virtual void an()
	{
	}

	public virtual void ao()
	{
	}

	public virtual void ap(GameTime A_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (n())
		{
			if (e)
			{
				float a_ = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
				g(a_);
			}
		}
		else
		{
			this.m_a = b;
		}
	}

	public virtual void aq(float A_0, float A_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		bu bu2 = bu.b();
		if (this.m_a != Color.Transparent)
		{
			bu2.b(this.m_a);
			bu2.b(0f, 0f, 800f, 480f);
			bu2.b(Color.White);
		}
		if (k() != null)
		{
			float a_ = 800f / (float)k().c;
			float a_2 = 480f / (float)k().d;
			bu2.b(k(), A_0, A_1, a_, a_2);
		}
	}

	public bool o()
	{
		if (d != 0)
		{
			c = 0f;
			d = y.a.a;
			e = true;
		}
		return e;
	}

	public void l()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		c = 0f;
		d = y.a.a;
		e = false;
		this.m_a = b;
	}

	public bool m()
	{
		if (d != y.a.b)
		{
			c = 0f;
			d = y.a.b;
			e = true;
		}
		return e;
	}

	private void g(float A_0)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		c += A_0;
		float num = c / 0.3f;
		if (num > 0f && num <= 1f)
		{
			if (d == y.a.a)
			{
				this.m_a = Color.Lerp(Color.Transparent, b, num);
			}
			else
			{
				this.m_a = Color.Lerp(b, Color.Transparent, num);
			}
		}
		else
		{
			e = false;
		}
	}
}
