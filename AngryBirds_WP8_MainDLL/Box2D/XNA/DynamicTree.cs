using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class DynamicTree
{
	internal static short a = -1;

	private short[] m_b = new short[256];

	private int m_c;

	private short m_d;

	internal c1[] e;

	private short f;

	private short g;

	private short h;

	private int i;

	private int j;

	public DynamicTree()
	{
		this.m_d = DynamicTree.a;
		g = 16;
		f = 0;
		e = new c1[g];
		for (int i = 0; i < g - 1; i++)
		{
			e[i].c = (short)(i + 1);
		}
		e[g - 1].c = DynamicTree.a;
		h = 0;
		this.i = 0;
	}

	public short CreateProxy(ref AABB aabb, object userData)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		short num = M_a();
		Vector2 val = default(Vector2);
		val = new Vector2(0.1f, 0.1f);
		e[num].a.lowerBound = aabb.lowerBound - val;
		e[num].a.upperBound = aabb.upperBound + val;
		e[num].b = userData;
		e[num].f = 1;
		M_c(num);
		if (f >= 64)
		{
			int iterations = f >> 4;
			int num2 = 0;
			int num3 = ComputeHeight();
			while (num3 > 64 && num2 < 10)
			{
				Rebalance(iterations);
				num3 = ComputeHeight();
				num2++;
			}
		}
		return num;
	}

	public void DestroyProxy(short proxyId)
	{
		M_b(proxyId);
		M_d(proxyId);
	}

	public bool MoveProxy(short proxyId, ref AABB aabb, Vector2 displacement)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (e[proxyId].a.Contains(ref aabb))
		{
			return false;
		}
		M_b(proxyId);
		AABB aABB = aabb;
		Vector2 val = default(Vector2);
		val = new Vector2(0.1f, 0.1f);
		aABB.lowerBound -= val;
		aABB.upperBound += val;
		Vector2 val2 = 2f * displacement;
		if (val2.X < 0f)
		{
			ref Vector2 lowerBound = ref aABB.lowerBound;
			lowerBound.X += val2.X;
		}
		else
		{
			ref Vector2 upperBound = ref aABB.upperBound;
			upperBound.X += val2.X;
		}
		if (val2.Y < 0f)
		{
			ref Vector2 lowerBound2 = ref aABB.lowerBound;
			lowerBound2.Y += val2.Y;
		}
		else
		{
			ref Vector2 upperBound2 = ref aABB.upperBound;
			upperBound2.Y += val2.Y;
		}
		e[proxyId].a = aABB;
		M_c(proxyId);
		return true;
	}

	public void Rebalance(int iterations)
	{
		if (this.m_d == DynamicTree.a)
		{
			return;
		}
		for (int i = 0; i < iterations; i++)
		{
			short num = this.m_d;
			int num2 = 0;
			while (!e[num].IsLeaf())
			{
				num = ((((this.i >> num2) & 1) == 0) ? e[num].d : e[num].e);
				num2 = (num2 + 1) & 0x1F;
			}
			this.i++;
			M_b(num);
			M_c(num);
		}
	}

	public object GetUserData(int proxyId)
	{
		return e[proxyId].b;
	}

	public void GetFatAABB(int proxyId, out AABB fatAABB)
	{
		fatAABB = e[proxyId].a;
	}

	public int ComputeHeight()
	{
		if (this.m_c == 0)
		{
			this.m_c = M_a(this.m_d) - 1;
		}
		return this.m_c + 1;
	}

	public void Query(Func<short, bool> callback, ref AABB aabb)
	{
		if (this.m_d != DynamicTree.a)
		{
			M_a(callback, ref aabb, this.m_d);
		}
	}

	private void M_a(Func<short, bool> A_0, ref AABB A_1, short A_2)
	{
		int num = 1;
		this.m_b[0] = A_2;
		while (num > 0)
		{
			short num2 = this.m_b[--num];
			c1 c = e[num2];
			if (!AABB.TestOverlap(ref c.a, ref A_1))
			{
				continue;
			}
			if (c.IsLeaf())
			{
				if (!A_0.Invoke(num2))
				{
					break;
				}
				continue;
			}
			if (c.d != DynamicTree.a)
			{
				this.m_b[num++] = c.d;
			}
			if (c.e != DynamicTree.a)
			{
				this.m_b[num++] = c.e;
			}
		}
	}

	internal void M_a(am A_0, ref RayCastInput A_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		if (this.m_d == DynamicTree.a)
		{
			return;
		}
		Vector2 p = A_1.p1;
		Vector2 p2 = A_1.p2;
		Vector2 val = p2 - p;
		val.Normalize();
		Vector2 val2 = MathUtils.Cross(1f, val);
		Vector2 val3 = MathUtils.Abs(val2);
		float num = A_1.maxFraction;
		AABB aABB = default(AABB);
		Vector2 val4 = p + num * (p2 - p);
		aABB.lowerBound = Vector2.Min(p, val4);
		aABB.upperBound = Vector2.Max(p, val4);
		int num2 = 1;
		this.m_b[0] = this.m_d;
		RayCastInput A_2 = default(RayCastInput);
		while (num2 > 0)
		{
			int num3 = this.m_b[--num2];
			c1 c = e[num3];
			if (!AABB.TestOverlap(ref c.a, ref aABB))
			{
				continue;
			}
			Vector2 center = c.a.GetCenter();
			Vector2 extents = c.a.GetExtents();
			float num4 = Math.Abs(Vector2.Dot(val2, p - center)) - Vector2.Dot(val3, extents);
			if (num4 > 0f)
			{
				continue;
			}
			if (c.IsLeaf())
			{
				A_2.p1 = A_1.p1;
				A_2.p2 = A_1.p2;
				A_2.maxFraction = num;
				float num5 = A_0(ref A_2, num3);
				if (num5 == 0f)
				{
					break;
				}
				if (num5 > 0f)
				{
					num = num5;
					Vector2 val5 = p + num * (p2 - p);
					aABB.lowerBound = Vector2.Min(p, val5);
					aABB.upperBound = Vector2.Max(p, val5);
				}
			}
			else
			{
				if (c.d != DynamicTree.a)
				{
					this.m_b[num2++] = c.d;
				}
				if (c.e != DynamicTree.a)
				{
					this.m_b[num2++] = c.e;
				}
			}
		}
	}

	private short M_a()
	{
		if (h == DynamicTree.a)
		{
			c1[] sourceArray = e;
			g *= 2;
			e = new c1[g];
			Array.Copy(sourceArray, e, f);
			for (int i = f; i < g - 1; i++)
			{
				e[i].c = (short)(i + 1);
			}
			e[g - 1].c = DynamicTree.a;
			h = f;
		}
		short num = h;
		h = e[num].c;
		e[num].c = DynamicTree.a;
		e[num].d = DynamicTree.a;
		e[num].e = DynamicTree.a;
		e[num].f = 0;
		f++;
		return num;
	}

	private void M_d(short A_0)
	{
		e[A_0].c = h;
		h = A_0;
		f--;
	}

	private void M_c(short A_0)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		j++;
		if (this.m_d == DynamicTree.a)
		{
			this.m_d = A_0;
			e[this.m_d].c = DynamicTree.a;
			return;
		}
		int num = 1;
		AABB aabb = e[A_0].a;
		aabb.GetCenter();
		short num2 = this.m_d;
		AABB aABB = default(AABB);
		while (!e[num2].IsLeaf())
		{
			e[num2].a.Combine(ref aabb);
			e[num2].f++;
			short num3 = e[num2].d;
			short num4 = e[num2].e;
			aABB.Combine(ref aabb, ref e[num3].a);
			float num5 = aABB.upperBound.X - aABB.lowerBound.X + (aABB.upperBound.Y - aABB.lowerBound.Y);
			float num6 = (float)e[num3].f * num5;
			aABB.Combine(ref aabb, ref e[num4].a);
			float num7 = aABB.upperBound.X - aABB.lowerBound.X + (aABB.upperBound.Y - aABB.lowerBound.Y);
			float num8 = (float)e[num4].f * num7;
			num2 = ((num6 < num8) ? num3 : num4);
			num++;
		}
		if (num > this.m_c)
		{
			this.m_c = num;
		}
		short num9 = e[num2].c;
		short num10 = M_a();
		e[num10].c = num9;
		e[num10].b = null;
		e[num10].a.Combine(ref aabb, ref e[num2].a);
		e[num10].f = (short)(e[num2].f + 1);
		if (num9 != DynamicTree.a)
		{
			if (e[num9].d == num2)
			{
				e[num9].d = num10;
			}
			else
			{
				e[num9].e = num10;
			}
			e[num10].d = num2;
			e[num10].e = A_0;
			e[num2].c = num10;
			e[A_0].c = num10;
		}
		else
		{
			e[num10].d = num2;
			e[num10].e = A_0;
			e[num2].c = num10;
			e[A_0].c = num10;
			this.m_d = num10;
		}
	}

	private void M_b(short A_0)
	{
		if (A_0 == this.m_d)
		{
			this.m_d = DynamicTree.a;
			return;
		}
		short num = e[A_0].c;
		short num2 = e[num].c;
		short num3 = ((e[num].d != A_0) ? e[num].d : e[num].e);
		if (num2 != DynamicTree.a)
		{
			if (e[num2].d == num)
			{
				e[num2].d = num3;
			}
			else
			{
				e[num2].e = num3;
			}
			e[num3].c = num2;
			M_d(num);
			for (num = num2; num != DynamicTree.a; num = e[num].c)
			{
				_ = e[num].a;
				e[num].a.Combine(ref e[e[num].d].a, ref e[e[num].e].a);
				e[num].f--;
			}
		}
		else
		{
			this.m_d = num3;
			e[num3].c = DynamicTree.a;
			M_d(num);
		}
		this.m_c = 0;
	}

	private int M_a(short A_0)
	{
		c1 c = e[A_0];
		int num = ((c.d != DynamicTree.a) ? M_a(c.d) : 0);
		int num2 = ((c.e != DynamicTree.a) ? M_a(c.e) : 0);
		return 1 + ((num > num2) ? num : num2);
	}

	internal void M_a(Func<short, bool> A_0, short A_1)
	{
		M_a(A_0, ref e[A_1].a, this.m_d);
	}
}
