using System;
using Innogiant;
using Microsoft.Xna.Framework;

internal class bh : cy
{
	private new Vector2 b = new Vector2(0f);

	private new float c;

	private new float d;

	private new Vector2 e = new Vector2(0f);

	private new float f;

	private new ae g;

	private new cw h;

	private new bool i;

	public override object j()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		bh bh2 = (bh)base.j();
		bh2.b = b;
		bh2.c = c;
		bh2.d = d;
		bh2.e = e;
		bh2.f = f;
		bh2.g = g;
		bh2.h = h;
		bh2.i = i;
		return bh2;
	}

	public bh(LuaVariable A_0, cf A_1)
		: base(A_0, A_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		e = new Vector2(0f, -60f);
		b.X = -50f;
		b.Y = -350f;
		c = 50f;
		d = 0f - c;
		g = global::u.a().g("BIRD_BOOMERANG_SPECIAL");
		h = global::u.a().f("boomerang_swish");
	}

	public override void k(ct A_0, float A_1, float A_2)
	{
		base.k(A_0, A_1, A_2);
		ai(A_0: false);
		j(A_0: false);
		i = false;
	}

	public override void l()
	{
		if (au())
		{
			ai(A_0: true);
		}
	}

	public override void m(float A_0)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		base.m(A_0);
		if (at())
		{
			w.a(new Vector2(base.c, base.d));
			float num = 0f;
			Vector2 linearVelocity = o.GetLinearVelocity();
			if (linearVelocity.X != 0f)
			{
				num = 2f - Math.Min(Math.Abs(linearVelocity.Y / linearVelocity.X), 2f);
			}
			b.X = linearVelocity.X * o.GetMass() * b.X * cf.PhysicsConfig.GetInvTimestep();
			b.Y = num * o.GetMass() * b.Y * cf.PhysicsConfig.GetInvTimestep();
			if (g != null)
			{
				((ct)this).m = g;
			}
			if (@as().ah != null)
			{
				@as().ah.ac();
			}
			ai(A_0: false);
			j(A_0: false);
			i = true;
		}
		if (i)
		{
			float a_ = 1f;
			if (base.c <= v.a3().l || base.c >= v.a3().m)
			{
				a_ = 0f;
			}
			else if (base.c > v.a3().l && base.c < v.a3().l + 40f)
			{
				a_ = Math.Abs(v.a3().l - base.c) / 40f;
			}
			else if (base.c < v.a3().m && base.c > v.a3().m - 40f)
			{
				a_ = Math.Abs(v.a3().m - base.c) / 40f;
			}
			h.y(a_);
			if (base.e >= f + 1f)
			{
				h.ac();
				f = base.e;
			}
			Vector2 linearVelocity2 = o.GetLinearVelocity();
			Vector2 force = default(Vector2);
			force = new Vector2(0f);
			if (linearVelocity2.X >= d && linearVelocity2.X <= c)
			{
				force.X = b.X;
			}
			if (linearVelocity2.Y > 5f)
			{
				force.Y = b.Y;
			}
			o.ApplyForce(force, o.d.Position);
			float val = o.GetAngularVelocity() + 20f * A_0 * 10f;
			val = Math.Min(20f, val);
			o.SetAngularVelocity(val);
		}
		else if (au())
		{
			o.ApplyForce(e, o.d.Position);
			float val2 = o.GetAngularVelocity() + 15f * A_0 * 10f;
			val2 = Math.Min(val2, 6.28f);
			o.SetAngularVelocity(val2);
		}
	}
}
