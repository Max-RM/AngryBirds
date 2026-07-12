using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class BroadPhase
{
	internal DynamicTree _tree = new DynamicTree();

	internal int b;

	internal short[] c;

	internal int d;

	internal int e;

	internal cl[] f;

	internal int g;

	internal int h;

	internal short i;

	private Func<short, bool> j;

	public int ProxyCount => this.b;

	public BroadPhase()
	{
		j = M_a;
		this.b = 0;
		g = 16;
		h = 0;
		f = new cl[g];
		d = 16;
		e = 0;
		this.c = new short[d];
	}

	public short CreateProxy(ref AABB aabb, object userData)
	{
		short num = this._tree.CreateProxy(ref aabb, userData);
		this.b++;
		M_c(num);
		return num;
	}

	public void DestroyProxy(short proxyId)
	{
		M_b(proxyId);
		this.b--;
		this._tree.DestroyProxy(proxyId);
	}

	public void MoveProxy(short proxyId, ref AABB aabb, Vector2 displacement)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (this._tree.MoveProxy(proxyId, ref aabb, displacement))
		{
			M_c(proxyId);
		}
	}

	public void GetFatAABB(int proxyId, out AABB aabb)
	{
		this._tree.GetFatAABB(proxyId, out aabb);
	}

	public object GetUserData(int proxyId)
	{
		return this._tree.GetUserData(proxyId);
	}

	public bool TestOverlap(int proxyIdA, int proxyIdB)
	{
		AABB aABB = this._tree.e[proxyIdA].a;
		AABB aABB2 = this._tree.e[proxyIdB].a;
		if (aABB2.lowerBound.X > aABB.upperBound.X || aABB2.lowerBound.Y > aABB.upperBound.Y || aABB.lowerBound.X > aABB2.upperBound.X || aABB.lowerBound.Y > aABB2.upperBound.Y)
		{
			return false;
		}
		return true;
	}

	public void UpdatePairs<T>(Action<T, T> callback)
	{
		h = 0;
		for (int i = 0; i < e; i++)
		{
			this.i = this.c[i];
			if (this.i != -1)
			{
				this._tree.M_a(this.j, this.i);
			}
		}
		e = 0;
		Array.Sort(f, 0, h);
		int j = 0;
		while (j < h)
		{
			cl cl = f[j];
			object userData = this._tree.GetUserData(cl.a);
			object userData2 = this._tree.GetUserData(cl.b);
			callback.Invoke((T)userData, (T)userData2);
			for (j++; j < h; j++)
			{
				cl cl2 = f[j];
				if (cl2.a != cl.a || cl2.b != cl.b)
				{
					break;
				}
			}
		}
		this._tree.Rebalance(4);
	}

	public void Query(Func<short, bool> callback, ref AABB aabb)
	{
		this._tree.Query(callback, ref aabb);
	}

	internal void M_a(am A_0, ref RayCastInput A_1)
	{
		this._tree.M_a(A_0, ref A_1);
	}

	public int ComputeHeight()
	{
		return this._tree.ComputeHeight();
	}

	internal void M_c(short A_0)
	{
		if (e == d)
		{
			short[] sourceArray = this.c;
			d *= 2;
			this.c = new short[d];
			Array.Copy(sourceArray, this.c, e);
		}
		this.c[e] = A_0;
		e++;
	}

	internal void M_b(short A_0)
	{
		for (int i = 0; i < e; i++)
		{
			if (this.c[i] == A_0)
			{
				this.c[i] = -1;
				break;
			}
		}
	}

	internal bool M_a(short A_0)
	{
		if (A_0 == i)
		{
			return true;
		}
		if (h == g)
		{
			cl[] sourceArray = f;
			g *= 2;
			f = new cl[g];
			Array.Copy(sourceArray, f, h);
		}
		f[h].a = Math.Min(A_0, i);
		f[h].b = Math.Max(A_0, i);
		h++;
		return true;
	}
}
