using Innogiant;
using Microsoft.Xna.Framework;

internal class b1 : cy
{
	private new ae b;

	public override object j()
	{
		b1 b10 = (b1)base.j();
		b10.b = b;
		return b10;
	}

	public b1(LuaVariable A_0, cf A_1)
		: base(A_0, A_1)
	{
		b = global::u.a().g("BIRD_YELLOW_SPECIAL");
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

	public override void m(float A_0)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		base.m(A_0);
		if (at())
		{
			v.u(this, @as().ak, 10);
			w.a(new Vector2(c, d));
			float num = -925f * cf.PhysicsConfig.GetInvTimestep() * o.GetMass();
			Vector2 linearVelocity = o.GetLinearVelocity();
			linearVelocity.Normalize();
			o.ApplyLinearImpulse(-linearVelocity * num, new Vector2(c, d));
			if (b != null)
			{
				((ct)this).m = b;
			}
			if (@as().ah != null)
			{
				@as().ah.ac();
			}
			ai(A_0: false);
		}
	}
}
