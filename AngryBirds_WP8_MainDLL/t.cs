using Innogiant;
using Microsoft.Xna.Framework;

internal class t : ct
{
	private cf a;

	private new cw b;

	private new aw c;

	private new aw d;

	private new bool e;

	public override object j()
	{
		t t2 = (t)base.j();
		t2.a = a;
		t2.b = b;
		t2.c = c;
		t2.d = d;
		t2.e = e;
		t2.c.g(t2.ai);
		t2.d.g(t2.ah);
		return t2;
	}

	public t(LuaVariable A_0, cf A_1)
		: base(A_0)
	{
		a = A_1;
		b = global::u.a().f("piglette");
		aw aw2 = new aw();
		aw2.g(ai);
		aw2.i((float)b9.a(1, 4) / 10f);
		aw2.g(A_0: true);
		aw2.h(A_0: true);
		c = aw2;
		aw aw3 = new aw();
		aw3.g(ah);
		aw3.i((float)b9.a(10, 60) / 10f);
		aw3.g(A_0: true);
		aw3.h(A_0: true);
		d = aw3;
	}

	public void j(float A_0)
	{
		if (a.a5())
		{
			m = t;
		}
		else
		{
			c.h(A_0);
		}
		d.h(A_0);
	}

	private void ai()
	{
		if (e)
		{
			c.i((float)b9.a(1, 30) / 10f);
			m = s;
			e = false;
		}
		else
		{
			c.i((float)b9.a(1, 4) / 10f);
			m = r;
			e = true;
		}
	}

	private void ah()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		d.i((float)b9.a(10, 60) / 10f);
		Vector2 val = di.d(base.c, base.d, cf.PhysicsConfig.GetTimestep());
		Vector2 val2 = default(Vector2);
		val2 = new Vector2(a.an().g() - val.X, a.an().f() - val.Y);
		float num = 1f - val2.Length() / 1000f;
		if (num > 0f)
		{
			b.y(num);
			b.ac();
		}
	}
}
