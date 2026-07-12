internal class b7 : cy
{
	private new float b = 5f;

	private new cw c;

	public override object j()
	{
		b7 b10 = (b7)base.j();
		b10.b = b;
		b10.c = c;
		return b10;
	}

	public b7(string A_0, cb A_1, cf A_2)
		: base(A_0, A_1, A_2)
	{
		z = null;
		c = global::u.a().f("special_explosion");
		l(A_0: false);
	}

	public override void k(ct A_0, float A_1, float A_2)
	{
		b = 0f;
		ai(A_0: true);
	}

	public override void l()
	{
	}

	public override void m(float A_0)
	{
		if (!at())
		{
			return;
		}
		b -= A_0;
		if (b <= 0f)
		{
			if (c != null)
			{
				c.ac();
			}
			v.u(this, @as().ak, 6);
			v.u((ct)this);
			v.u(this, "eggShells", 6);
			v.v((ct)this);
			ai(A_0: false);
			j(A_0: false);
		}
	}
}
