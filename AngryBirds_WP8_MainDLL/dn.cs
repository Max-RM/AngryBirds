using Innogiant;

internal class dn : cy
{
	private new float ah = 1.5f;

	private new ae ai;

	private ae aj;

	private ae ak;

	public override object j()
	{
		dn dn2 = (dn)base.j();
		dn2.ah = ah;
		dn2.ai = ai;
		dn2.aj = aj;
		dn2.ak = ak;
		return dn2;
	}

	public dn(LuaVariable A_0, cf A_1)
		: base(A_0, A_1)
	{
		z = null;
		ai = global::u.a().g("BIRD_GREY_1");
		aj = global::u.a().g("BIRD_GREY_2");
		ak = global::u.a().g("BIRD_GREY_3");
	}

	public override void k(ct A_0, float A_1, float A_2)
	{
		base.k(A_0, A_1, A_2);
		if (au())
		{
			ai(A_0: true);
		}
		((ct)this).m = ai;
	}

	public override void l()
	{
		if (au())
		{
			ai(A_0: true);
			j(A_0: false);
			ah = 0f;
		}
	}

	public override void m(float A_0)
	{
		base.m(A_0);
		if (at())
		{
			ah -= A_0;
			if (ah <= 0f)
			{
				v.u((ct)this);
				@as().ah.ac();
				ai(A_0: false);
				j(A_0: false);
				aw();
				v.v((ct)this);
			}
			else if (ah < 1f)
			{
				((ct)this).m = ak;
			}
			else if (ah < 2f)
			{
				((ct)this).m = aj;
			}
		}
	}
}
