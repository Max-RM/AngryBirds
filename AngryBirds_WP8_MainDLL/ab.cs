using System;
using Box2D.XNA;
using Microsoft.Xna.Framework;

internal class ab
{
	private g[] m_a = new g[8];

	private int b;

	private Body c;

	public void a(Contact[] A_0, int A_1, Body A_2)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		b = A_1;
		c = A_2;
		if (this.m_a.Length < b)
		{
			this.m_a = new g[Math.Max(this.m_a.Length * 2, b)];
		}
		for (int num = 0; num < b; num++)
		{
			Contact contact = A_0[num];
			Fixture fixture = contact.i;
			Fixture fixture2 = contact.j;
			Shape shape = fixture.f;
			Shape shape2 = fixture2.f;
			float radius = shape._radius;
			float radius2 = shape2._radius;
			Body body = fixture.e;
			Body body2 = fixture2.e;
			contact.GetManifold(out var manifold);
			g g2 = this.m_a[num];
			g2.bodyG = body;
			g2.h = body2;
			g2.b = manifold._localNormal;
			g2.c = manifold._localPoint;
			g2.d = manifold._type;
			g2.f = manifold._pointCount;
			g2.e = radius + radius2;
			for (int num2 = 0; num2 < g2.f; num2++)
			{
				g2.a[num2] = manifold._points[num2].LocalPoint;
			}
			this.m_a[num] = g2;
		}
	}

	public bool a(float A_0)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		float num = 0f;
		for (int num2 = 0; num2 < b; num2++)
		{
			g A_ = this.m_a[num2];
			Body body = A_.bodyG;
			Body body2 = A_.h;
			float num3 = body.q;
			float num4 = body2.q;
			if (body == c)
			{
				num4 = 0f;
			}
			else
			{
				num3 = 0f;
			}
			float num5 = num3 * body.r;
			float num6 = num3 * body.t;
			float num7 = num4 * body2.r;
			float num8 = num4 * body2.t;
			for (int num9 = 0; num9 < A_.f; num9++)
			{
				ci ci2 = new ci(ref A_, num9);
				Vector2 val = ci2.a;
				Vector2 val2 = ci2.b;
				float num10 = ci2.c;
				Vector2 val3 = val2 - body.e.c;
				Vector2 val4 = val2 - body2.e.c;
				num = Math.Min(num, num10);
				float num11 = MathUtils.Clamp(A_0 * (num10 + 0.05f), -0.2f, 0f);
				float num12 = MathUtils.Cross(val3, val);
				float num13 = MathUtils.Cross(val4, val);
				float num14 = num5 + num7 + num6 * num12 * num12 + num8 * num13 * num13;
				float num15 = ((num14 > 0f) ? ((0f - num11) / num14) : 0f);
				Vector2 val5 = num15 * val;
				ref Sweep reference = ref body.e;
				reference.c -= num5 * val5;
				body.e.a -= num6 * MathUtils.Cross(val3, val5);
				body.M_a();
				ref Sweep reference2 = ref body2.e;
				reference2.c += num7 * val5;
				body2.e.a += num8 * MathUtils.Cross(val4, val5);
				body2.M_a();
			}
		}
		return num >= -0.075f;
	}
}
