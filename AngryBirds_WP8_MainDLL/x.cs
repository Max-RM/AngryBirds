using Innogiant;

internal class x : cy
{
	public override object j()
	{
		return (x)base.j();
	}

	public x(LuaVariable A_0, cf A_1)
		: base(A_0, A_1)
	{
	}

	public override void k(ct A_0, float A_1, float A_2)
	{
		base.k(A_0, A_1, A_2);
		ai(A_0: false);
		j(A_0: false);
	}

	public override void l()
	{
		if (au())
		{
			if (@as().ah != null)
			{
				@as().ah.ac();
			}
			j(A_0: false);
			ai(A_0: true);
		}
	}
}
