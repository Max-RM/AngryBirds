using System;
using Box2D.XNA;
using Microsoft.Xna.Framework;

internal class dl
{
	private ContactSolver m_a = new ContactSolver();

	public IContactListener b;

	public Body[] c;

	public Contact[] d;

	public Joint[] e;

	public int f;

	public int g;

	public int h;

	public int i;

	public int j;

	public int k;

	public void a(int A_0, int A_1, int A_2, IContactListener A_3)
	{
		i = A_0;
		j = A_1;
		k = A_2;
		f = 0;
		h = 0;
		b = A_3;
		if (c == null || c.Length < A_0)
		{
			c = new Body[A_0];
		}
		if (d == null || d.Length < A_1)
		{
			d = new Contact[A_1 * 2];
		}
		if (e == null || e.Length < A_2)
		{
			e = new Joint[A_2 * 2];
		}
	}

	public void a()
	{
		f = 0;
		g = 0;
		h = 0;
	}

	public void a(ref TimeStep A_0, Vector2 A_1, bool A_2)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		for (int num = 0; num < f; num++)
		{
			Body body = c[num];
			if (body.GetType() == BodyType.Dynamic)
			{
				body.f += A_0.dt * (A_1 + body.r * body.h);
				body.g += A_0.dt * body.t * body.i;
				body.f *= MathUtils.Clamp(1f - A_0.dt * body.u, 0f, 1f);
				body.g *= MathUtils.Clamp(1f - A_0.dt * body.v, 0f, 1f);
			}
		}
		int num2 = -1;
		for (int num3 = 0; num3 < g; num3++)
		{
			Fixture fixture = d[num3].i;
			Fixture fixture2 = d[num3].j;
			Body body2 = fixture.e;
			Body body3 = fixture2.e;
			if (body2.GetType() != 0 && body3.GetType() != 0)
			{
				num2++;
				Contact contact = d[num2];
				d[num2] = d[num3];
				d[num3] = contact;
			}
		}
		this.m_a.Reset(d, g, A_0.dtRatio);
		this.m_a.WarmStart();
		for (int num4 = 0; num4 < h; num4++)
		{
			e[num4].InitVelocityConstraints(ref A_0);
		}
		for (int num5 = 0; num5 < A_0.velocityIterations; num5++)
		{
			for (int num6 = 0; num6 < h; num6++)
			{
				e[num6].SolveVelocityConstraints(ref A_0);
			}
			this.m_a.SolveVelocityConstraints();
		}
		this.m_a.StoreImpulses();
		for (int num7 = 0; num7 < f; num7++)
		{
			Body body4 = c[num7];
			if (body4.GetType() != 0)
			{
				Vector2 val = A_0.dt * body4.f;
				if (Vector2.Dot(val, val) > Settings.b2_maxTranslationSquared)
				{
					float num8 = Settings.b2_maxTranslation / val.Length();
					body4.f *= num8;
				}
				float num9 = A_0.dt * body4.g;
				if (num9 * num9 > Settings.b2_maxRotationSquared)
				{
					float num10 = Settings.b2_maxRotation / Math.Abs(num9);
					body4.g *= num10;
				}
				body4.e.c0 = body4.e.c;
				body4.e.a0 = body4.e.a;
				ref Sweep reference = ref body4.e;
				reference.c += A_0.dt * body4.f;
				body4.e.a += A_0.dt * body4.g;
				body4.M_a();
			}
		}
		for (int num11 = 0; num11 < A_0.positionIterations; num11++)
		{
			bool flag = this.m_a.SolvePositionConstraints(0.2f);
			bool flag2 = true;
			for (int num12 = 0; num12 < h; num12++)
			{
				bool flag3 = e[num12].SolvePositionConstraints(0.2f);
				flag2 = flag2 && flag3;
			}
			if (flag && flag2)
			{
				break;
			}
		}
		a(this.m_a._constraints);
		if (!A_2)
		{
			return;
		}
		float num13 = float.MaxValue;
		for (int num14 = 0; num14 < f; num14++)
		{
			Body body5 = c[num14];
			if (body5.GetType() != 0)
			{
				if ((body5.a & BodyFlags.AutoSleep) == 0)
				{
					body5.w = 0f;
					num13 = 0f;
				}
				if ((body5.a & BodyFlags.AutoSleep) == 0 || body5.g * body5.g > 0.0012184697f || Vector2.Dot(body5.f, body5.f) > 0.010000001f)
				{
					body5.w = 0f;
					num13 = 0f;
				}
				else
				{
					body5.w += A_0.dt;
					num13 = Math.Min(num13, body5.w);
				}
			}
		}
		if (num13 >= 0.25f)
		{
			for (int num15 = 0; num15 < f; num15++)
			{
				Body body6 = c[num15];
				body6.SetAwake(flag: false);
			}
		}
	}

	public void a(Body A_0)
	{
		A_0.c = f;
		c[f++] = A_0;
	}

	public void a(Contact A_0)
	{
		d[g++] = A_0;
	}

	public void a(Joint A_0)
	{
		e[h++] = A_0;
	}

	public void a(ContactConstraint[] A_0)
	{
		if (b == null)
		{
			return;
		}
		ContactImpulse impulse = default(ContactImpulse);
		for (int num = 0; num < g; num++)
		{
			Contact contact = d[num];
			ContactConstraint contactConstraint = A_0[num];
			if (contactConstraint.pointCount > 0)
			{
				impulse.normalImpulses._value0 = contactConstraint.points._value0.normalImpulse;
				impulse.tangentImpulses._value0 = contactConstraint.points._value0.tangentImpulse;
				if (contactConstraint.pointCount > 1)
				{
					impulse.normalImpulses._value1 = contactConstraint.points._value1.normalImpulse;
					impulse.tangentImpulses._value1 = contactConstraint.points._value1.tangentImpulse;
				}
			}
			b.PostSolve(contact, ref impulse);
		}
	}
}
