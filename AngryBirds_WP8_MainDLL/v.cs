using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Box2D.XNA;
using Microsoft.Xna.Framework;

internal class v
{
	private cy a;

	private Vector2 b;

	private Vector2 c;

	private float d;

	private float e;

	private ae m_f;

	private ae m_g;

	private ae m_h;

	private bool m_i;

	private Color m_j = new Color(48, 23, 8);

	private cw m_k;

	private cw m_l;

	private List<cy> m;

	[CompilerGenerated]
	private int n;

	[CompilerGenerated]
	private bool o;

	[SpecialName]
	[CompilerGenerated]
	public int i()
	{
		return n;
	}

	[SpecialName]
	[CompilerGenerated]
	private void f(int A_0)
	{
		n = A_0;
	}

	[SpecialName]
	public cy j()
	{
		return a;
	}

	[SpecialName]
	public bool h()
	{
		return this.m_i;
	}

	[SpecialName]
	public Vector2 f()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return b;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool l()
	{
		return o;
	}

	[SpecialName]
	[CompilerGenerated]
	public void f(bool A_0)
	{
		o = A_0;
	}

	public v(Vector2 A_0, List<cy> A_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		this.m_k = b0.d().d("slingshot_stretched");
		this.m_l = b0.d().d("bird_shot");
		b = A_0;
		c = A_0;
		this.m_g = u.a().g("SLING_SHOT_01_FRONT");
		this.m_h = u.a().g("SLING_SHOT_01_BACK");
		this.m_f = u.a().g("SLING_HOLDER");
		m = A_1;
		f(0);
		f(A_0: false);
	}

	public void f(cy A_0)
	{
		a = A_0;
		A_0.@as().ai.ac();
	}

	public bool f(Vector2 A_0, float A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!this.m_i)
		{
			Vector2 val = A_0 - b;
			this.m_i = val.Length() < 5f / A_1;
		}
		return this.m_i;
	}

	public void g()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		c = b;
		d = 0f;
		e = 0f;
		this.m_i = false;
		if (a != null)
		{
			a.o.SetTransform(c, a.e);
		}
	}

	public void k()
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		this.m_i = false;
		if (a != null)
		{
			m.Add(a);
			a.l(A_0: true);
			a.o.SetType(BodyType.Dynamic);
			float val = e / 5.4f;
			val = Math.Min(val, 1f);
			val = Math.Max(val, 0.01f);
			float num = 925f * cf.PhysicsConfig.GetInvTimestep() * a.o.GetMass();
			Vector2 val2 = b - c;
			Vector2 impulse = val2 / val2.Length() * num * val;
			if (float.IsNaN(impulse.X) || float.IsNaN(impulse.Y))
			{
				impulse = new Vector2(0f);
			}
			a.o.ApplyLinearImpulse(impulse, a.o.d.Position);
			a.o.SetBullet(flag: true);
			a.ah(A_0: false);
			((ct)a).m = a.ao();
			c = b;
			d = 0f;
			a = null;
			f(i() + 1);
			this.m_l.ac();
		}
	}

	public void f(Vector2 A_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		if (a == null)
		{
			return;
		}
		Vector2 val = b - c;
		Vector2 val2 = b - A_0;
		c = A_0;
		d = (float)Math.Atan2(val2.Y, val2.X);
		if (val2.Length() < 5.4f)
		{
			e = val2.Length();
			if ((double)Math.Abs(val2.Length() - val.Length()) > 0.1 && (int)this.m_k.w() != 0)
			{
				this.m_k.ac();
			}
		}
		else
		{
			c = Vector2.Normalize(-val2) * 5.4f;
			c += b;
			e = 5.4f;
		}
		float num = 1f;
		if (d >= -1.9f && d < -1.75f)
		{
			num = (0f - (d + 1.75f)) / 0.15f;
		}
		else if (d >= -1.75f && d < -1.5f)
		{
			num = 0.25f;
		}
		else if (d >= -1.5f && d < -1.35f)
		{
			num = (d + 1.5f) / 0.15f;
		}
		if (num < 0.25f)
		{
			num = 0.25f;
		}
		if (e > num * 5.4f)
		{
			c.Y = b.Y - 5.4f * num * val2.Y / val2.Length();
			Vector2 val3 = b - c;
			e = val3.Length();
		}
		a.o.SetTransform(c, a.e);
	}

	public void f(n A_0, bool A_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		Vector2 A_2 = b;
		Vector2 A_3 = c;
		Vector2 val = A_3 - A_2;
		float num = val.Length();
		Vector2 A_4;
		Vector2 A_5;
		if (num > 0f)
		{
			val.Normalize();
			A_4 = A_2 + val * (num + 1f);
			A_5 = A_2 + val * (num + 0f);
		}
		else
		{
			A_4 = A_3;
			A_4.X -= 1f;
			A_5 = A_3;
			A_5.X -= 0f;
		}
		A_0.g(ref A_2);
		A_0.g(ref A_3);
		A_0.g(ref A_4);
		A_0.g(ref A_5);
		float num2 = A_0.m();
		float num3 = 1f * num2 * cf.PhysicsConfig.GetTimestep();
		float num4 = 40f / num;
		if (num4 > 20f)
		{
			num4 = 20f;
		}
		if (num4 < 7f)
		{
			num4 = 7f;
		}
		if (A_1)
		{
			bu.b().b(this.m_h, A_2.X, A_2.Y, num2, num2);
			bu.b().b(this.m_j);
			bu.b().b(new Vector2(A_2.X + num3, A_2.Y), A_4, num4 * num2);
			bu.b().b(Color.White);
			return;
		}
		if (a != null)
		{
			bu.b().b(((ct)a).m, A_5.X, A_5.Y, num2, num2, a.e);
		}
		bu.b().b(this.m_f, A_4.X, A_4.Y, num2, num2, d);
		bu.b().b(this.m_j);
		bu.b().b(new Vector2(A_2.X - num3, A_2.Y), A_4, num4 * num2);
		bu.b().b(Color.White);
		bu.b().b(this.m_g, A_2.X, A_2.Y, num2, num2);
	}
}
