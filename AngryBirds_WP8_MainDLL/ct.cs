using Box2D.XNA;
using Innogiant;
using Microsoft.Xna.Framework;

internal class ct : a3
{
	public float b;

	public float c;

	public float d;

	public float e;

	public float f;

	public bool g;

	public bool h;

	public Vector2 i;

	public bool k;

	public ae m;

	public Body o;

	public cb p;

	public string q;

	public ae r;

	public ae s;

	public ae t;

	public ae u;

	public virtual object j()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		ct ct2 = (ct)MemberwiseClone();
		ct2.b = b;
		ct2.c = c;
		ct2.d = d;
		ct2.e = e;
		ct2.f = f;
		ct2.g = g;
		ct2.h = h;
		ct2.i = i;
		ct2.k = k;
		ct2.m = m;
		ct2.o = o;
		ct2.p = p;
		ct2.q = q;
		ct2.r = r;
		ct2.s = s;
		ct2.t = t;
		ct2.u = u;
		return ct2;
	}

	public ct(string A_0, cb A_1)
	{
		q = A_0;
		p = A_1;
		f = p.w;
		g = p.y;
		m = global::u.a().g(p.d);
		u = ((p.e != null) ? global::u.a().g(p.e) : null);
	}

	public ct(LuaVariable A_0)
	{
		c = A_0["x"];
		d = A_0["y"];
		q = A_0["name"];
		e = A_0["angle"];
		p = di.d().q(A_0["definition"]);
		f = p.w;
		g = p.y;
		m = global::u.a().g(p.d);
		b = p.i;
		u = ((p.e != null) ? global::u.a().g(p.e) : null);
		if (p.f == null)
		{
			return;
		}
		int num = 0;
		for (int num2 = 0; num2 < p.f.Length; num2++)
		{
			if (num < p.f[num2].d)
			{
				num = p.f[num2].d;
				r = global::u.a().g(p.f[num2].a);
				s = global::u.a().g(p.f[num2].b);
				t = global::u.a().g(p.f[num2].c);
			}
		}
	}

	public void az()
	{
		if (p.f == null)
		{
			return;
		}
		float num = f / p.w * 100f;
		for (int num2 = 0; num2 < p.f.Length; num2++)
		{
			if ((float)p.f[num2].d >= num && (float)p.f[num2].e < num)
			{
				m = global::u.a().g(p.f[num2].a);
				r = global::u.a().g(p.f[num2].a);
				s = global::u.a().g(p.f[num2].b);
				t = global::u.a().g(p.f[num2].c);
				s = ((s != null) ? s : m);
				t = ((t != null) ? t : m);
				break;
			}
		}
	}
}
