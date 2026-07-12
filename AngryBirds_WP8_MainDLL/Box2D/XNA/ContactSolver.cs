using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class ContactSolver
{
	public ContactConstraint[] _constraints;

	public int _constraintCount;

	private Contact[] m_a;

	public void Reset(Contact[] contacts, int contactCount, float impulseRatio)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		this.m_a = contacts;
		_constraintCount = contactCount;
		if (_constraints == null || _constraints.Length < _constraintCount)
		{
			_constraints = new ContactConstraint[_constraintCount * 2];
		}
		for (int i = 0; i < _constraintCount; i++)
		{
			Contact contact = contacts[i];
			Fixture i2 = contact.i;
			Fixture j = contact.j;
			Shape f = i2.f;
			Shape f2 = j.f;
			float radius = f._radius;
			float radius2 = f2._radius;
			Body e = i2.e;
			Body e2 = j.e;
			contact.GetManifold(out var manifold);
			float a_ = Settings.b2MixFriction(i2.g, j.g);
			float a_2 = Settings.b2MixRestitution(i2.h, j.h);
			Vector2 A_ = e.f;
			Vector2 A_2 = e2.f;
			float g = e.g;
			float g2 = e2.g;
			WorldManifold A_3 = new WorldManifold(ref manifold, ref e.d, radius, ref e2.d, radius2);
			a(impulseRatio, radius, radius2, e, e2, ref manifold, a_, a_2, ref A_, ref A_2, g, g2, ref A_3, ref _constraints[i]);
		}
	}

	private static void a(float A_0, float A_1, float A_2, Body A_3, Body A_4, ref Manifold A_5, float A_6, float A_7, ref Vector2 A_8, ref Vector2 A_9, float A_10, float A_11, ref WorldManifold A_12, ref ContactConstraint A_13)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		A_13.bodyA = A_3;
		A_13.bodyB = A_4;
		A_13.manifold = A_5;
		A_13.normal = A_12._normal;
		A_13.pointCount = A_5._pointCount;
		A_13.friction = A_6;
		A_13.localNormal = A_5._localNormal;
		A_13.localPoint = A_5._localPoint;
		A_13.radius = A_1 + A_2;
		A_13.type = A_5._type;
		if (A_13.pointCount > 0)
		{
			a(ref A_5._points._value0, A_12._points._value0, A_0, A_3, A_4, A_7, ref A_8, ref A_9, A_10, A_11, ref A_13, ref A_13.points._value0);
			if (A_13.pointCount > 1)
			{
				a(ref A_5._points._value1, A_12._points._value1, A_0, A_3, A_4, A_7, ref A_8, ref A_9, A_10, A_11, ref A_13, ref A_13.points._value1);
			}
		}
		if (A_13.pointCount == 2)
		{
			Vector2 rA = A_13.points._value0.rA;
			Vector2 rB = A_13.points._value0.rB;
			Vector2 rA2 = A_13.points._value1.rA;
			Vector2 rB2 = A_13.points._value1.rB;
			float r = A_3.r;
			float t = A_3.t;
			float r2 = A_4.r;
			float t2 = A_4.t;
			float x = A_13.normal.X;
			float y = A_13.normal.Y;
			float num = rA.X * y - rA.Y * x;
			float num2 = rB.X * y - rB.Y * x;
			float num3 = rA2.X * y - rA2.Y * x;
			float num4 = rB2.X * y - rB2.Y * x;
			float num5 = r + r2 + t * num * num + t2 * num2 * num2;
			float num6 = r + r2 + t * num3 * num3 + t2 * num4 * num4;
			float num7 = r + r2 + t * num * num3 + t2 * num2 * num4;
			float num8 = num5 * num6 - num7 * num7;
			if (num5 * num5 < 100f * num8)
			{
				A_13.K.col1.X = num5;
				A_13.K.col1.Y = num7;
				A_13.K.col2.X = num7;
				A_13.K.col2.Y = num6;
				num8 = 1f / num8;
				A_13.normalMass.col1.X = num8 * num6;
				A_13.normalMass.col1.Y = (0f - num8) * num7;
				A_13.normalMass.col2.X = (0f - num8) * num7;
				A_13.normalMass.col2.Y = num8 * num5;
			}
			else
			{
				A_13.pointCount = 1;
			}
		}
	}

	private static void a(ref ManifoldPoint A_0, Vector2 A_1, float A_2, Body A_3, Body A_4, float A_5, ref Vector2 A_6, ref Vector2 A_7, float A_8, float A_9, ref ContactConstraint A_10, ref ContactConstraintPoint A_11)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		A_11.normalImpulse = A_2 * A_0.NormalImpulse;
		A_11.tangentImpulse = A_2 * A_0.TangentImpulse;
		A_11.localPoint = A_0.LocalPoint;
		A_11.rA = new Vector2
		{
			X = A_1.X - A_3.e.c.X,
			Y = A_1.Y - A_3.e.c.Y
		};
		A_11.rB = new Vector2
		{
			X = A_1.X - A_4.e.c.X,
			Y = A_1.Y - A_4.e.c.Y
		};
		float num = A_11.rA.X * A_10.normal.Y - A_11.rA.Y * A_10.normal.X;
		float num2 = A_11.rB.X * A_10.normal.Y - A_11.rB.Y * A_10.normal.X;
		num *= num;
		num2 *= num2;
		float num3 = A_3.r + A_4.r + A_3.t * num + A_4.t * num2;
		A_11.normalMass = 1f / num3;
		float num4 = A_11.rA.X * (0f - A_10.normal.X) - A_11.rA.Y * A_10.normal.Y;
		float num5 = A_11.rB.X * (0f - A_10.normal.X) - A_11.rB.Y * A_10.normal.Y;
		num4 *= num4;
		num5 *= num5;
		float num6 = A_3.r + A_4.r + A_3.t * num4 + A_4.t * num5;
		A_11.tangentMass = 1f / num6;
		A_11.velocityBias = 0f;
		float num7 = (0f - A_9) * A_11.rB.Y;
		float num8 = A_9 * A_11.rB.X;
		float num9 = (0f - A_8) * A_11.rA.Y;
		float num10 = A_8 * A_11.rA.X;
		float num11 = A_7.X + num7 - A_6.X - num9;
		float num12 = A_7.Y + num8 - A_6.Y - num10;
		float num13 = A_10.normal.X * num11 + A_10.normal.Y * num12;
		if (num13 < -1f)
		{
			A_11.velocityBias = (0f - A_5) * num13;
		}
	}

	public void WarmStart()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
		Vector2 val2 = default(Vector2);
		for (int i = 0; i < _constraintCount; i++)
		{
			ContactConstraint contactConstraint = _constraints[i];
			Body bodyA = contactConstraint.bodyA;
			Body bodyB = contactConstraint.bodyB;
			float r = bodyA.r;
			float t = bodyA.t;
			float r2 = bodyB.r;
			float t2 = bodyB.t;
			Vector2 normal = contactConstraint.normal;
			val = new Vector2(normal.Y, 0f - normal.X);
			for (int j = 0; j < contactConstraint.pointCount; j++)
			{
				ContactConstraintPoint value = contactConstraint.points[j];
				val2 = new Vector2(value.normalImpulse * normal.X + value.tangentImpulse * val.X, value.normalImpulse * normal.Y + value.tangentImpulse * val.Y);
				bodyA.g -= t * (value.rA.X * val2.Y - value.rA.Y * val2.X);
				ref Vector2 f = ref bodyA.f;
				f.X -= r * val2.X;
				ref Vector2 f2 = ref bodyA.f;
				f2.Y -= r * val2.Y;
				bodyB.g += t2 * (value.rB.X * val2.Y - value.rB.Y * val2.X);
				ref Vector2 f3 = ref bodyB.f;
				f3.X += r2 * val2.X;
				ref Vector2 f4 = ref bodyB.f;
				f4.Y += r2 * val2.Y;
				contactConstraint.points[j] = value;
			}
			_constraints[i] = contactConstraint;
		}
	}

	public void SolveVelocityConstraints()
	{
		for (int i = 0; i < _constraintCount; i++)
		{
			if (_constraints[i].pointCount == 1)
			{
				a(ref _constraints[i], ref _constraints[i].points._value0);
			}
			else
			{
				a(ref _constraints[i], ref _constraints[i].points._value0, ref _constraints[i].points._value1);
			}
		}
	}

	private static void a(ref ContactConstraint A_0, ref float A_1, ref float A_2, ref Vector2 A_3, ref Vector2 A_4, float A_5, float A_6, float A_7, float A_8, Vector2 A_9, ref ContactConstraintPoint A_10, ref ContactConstraintPoint A_11)
	{
		float normalImpulse = A_10.normalImpulse;
		float normalImpulse2 = A_11.normalImpulse;
		float num = A_4.X + (0f - A_2) * A_10.rB.Y - A_3.X - (0f - A_1) * A_10.rA.Y;
		float num2 = A_4.Y + A_2 * A_10.rB.X - A_3.Y - A_1 * A_10.rA.X;
		float num3 = A_4.X + (0f - A_2) * A_11.rB.Y - A_3.X - (0f - A_1) * A_11.rA.Y;
		float num4 = A_4.Y + A_2 * A_11.rB.X - A_3.Y - A_1 * A_11.rA.X;
		float num5 = num * A_9.X + num2 * A_9.Y;
		float num6 = num3 * A_9.X + num4 * A_9.Y;
		float num7 = num5 - A_10.velocityBias - (A_0.K.col1.X * normalImpulse + A_0.K.col2.X * normalImpulse2);
		float num8 = num6 - A_11.velocityBias - (A_0.K.col1.Y * normalImpulse + A_0.K.col2.Y * normalImpulse2);
		float num9 = 0f - (A_0.normalMass.col1.X * num7 + A_0.normalMass.col2.X * num8);
		float num10 = 0f - (A_0.normalMass.col1.Y * num7 + A_0.normalMass.col2.Y * num8);
		if (num9 >= 0f && num10 >= 0f)
		{
			float num11 = num9 - normalImpulse;
			float num12 = num10 - normalImpulse2;
			float num13 = num11 * A_9.X;
			float num14 = num11 * A_9.Y;
			float num15 = num12 * A_9.X;
			float num16 = num12 * A_9.Y;
			float num17 = num13 + num15;
			float num18 = num14 + num16;
			A_3.X -= A_5 * num17;
			A_3.Y -= A_5 * num18;
			A_1 -= A_6 * (A_10.rA.X * num14 - A_10.rA.Y * num13 + (A_11.rA.X * num16 - A_11.rA.Y * num15));
			A_4.X += A_7 * num17;
			A_4.Y += A_7 * num18;
			A_2 += A_8 * (A_10.rB.X * num14 - A_10.rB.Y * num13 + (A_11.rB.X * num16 - A_11.rB.Y * num15));
			A_0.points._value0.normalImpulse = num9;
			A_0.points._value1.normalImpulse = num10;
			return;
		}
		num9 = (0f - A_10.normalMass) * num7;
		num10 = 0f;
		num5 = 0f;
		num6 = A_0.K.col1.Y * num9 + num8;
		if (num9 >= 0f && num6 >= 0f)
		{
			float num19 = num9 - normalImpulse;
			float num20 = num10 - normalImpulse2;
			float num21 = num19 * A_9.X;
			float num22 = num19 * A_9.Y;
			float num23 = num20 * A_9.X;
			float num24 = num20 * A_9.Y;
			float num25 = num21 + num23;
			float num26 = num22 + num24;
			A_3.X -= A_5 * num25;
			A_3.Y -= A_5 * num26;
			A_1 -= A_6 * (A_10.rA.X * num22 - A_10.rA.Y * num21 + (A_11.rA.X * num24 - A_11.rA.Y * num23));
			A_4.X += A_7 * num25;
			A_4.Y += A_7 * num26;
			A_2 += A_8 * (A_10.rB.X * num22 - A_10.rB.Y * num21 + (A_11.rB.X * num24 - A_11.rB.Y * num23));
			A_0.points._value0.normalImpulse = num9;
			A_0.points._value1.normalImpulse = num10;
			return;
		}
		num9 = 0f;
		num10 = (0f - A_11.normalMass) * num8;
		num5 = A_0.K.col2.X * num10 + num7;
		num6 = 0f;
		if (num10 >= 0f && num5 >= 0f)
		{
			float num27 = num9 - normalImpulse;
			float num28 = num10 - normalImpulse2;
			float num29 = num27 * A_9.X;
			float num30 = num27 * A_9.Y;
			float num31 = num28 * A_9.X;
			float num32 = num28 * A_9.Y;
			float num33 = num29 + num31;
			float num34 = num30 + num32;
			A_3.X -= A_5 * num33;
			A_3.Y -= A_5 * num34;
			A_1 -= A_6 * (A_10.rA.X * num30 - A_10.rA.Y * num29 + (A_11.rA.X * num32 - A_11.rA.Y * num31));
			A_4.X += A_7 * num33;
			A_4.Y += A_7 * num34;
			A_2 += A_8 * (A_10.rB.X * num30 - A_10.rB.Y * num29 + (A_11.rB.X * num32 - A_11.rB.Y * num31));
			A_0.points._value0.normalImpulse = num9;
			A_0.points._value1.normalImpulse = num10;
			return;
		}
		num9 = 0f;
		num10 = 0f;
		num5 = num7;
		num6 = num8;
		if (num5 >= 0f && num6 >= 0f)
		{
			float num35 = num9 - normalImpulse;
			float num36 = num10 - normalImpulse2;
			float num37 = num35 * A_9.X;
			float num38 = num35 * A_9.Y;
			float num39 = num36 * A_9.X;
			float num40 = num36 * A_9.Y;
			float num41 = num37 + num39;
			float num42 = num38 + num40;
			A_3.X -= A_5 * num41;
			A_3.Y -= A_5 * num42;
			A_1 -= A_6 * (A_10.rA.X * num38 - A_10.rA.Y * num37 + (A_11.rA.X * num40 - A_11.rA.Y * num39));
			A_4.X += A_7 * num41;
			A_4.Y += A_7 * num42;
			A_2 += A_8 * (A_10.rB.X * num38 - A_10.rB.Y * num37 + (A_11.rB.X * num40 - A_11.rB.Y * num39));
			A_0.points._value0.normalImpulse = num9;
			A_0.points._value1.normalImpulse = num10;
		}
	}

	private static void a(ref ContactConstraint A_0, ref ContactConstraintPoint A_1)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		Body bodyA = A_0.bodyA;
		Body bodyB = A_0.bodyB;
		float g = bodyA.g;
		float g2 = bodyB.g;
		Vector2 f = bodyA.f;
		Vector2 f2 = bodyB.f;
		float r = bodyA.r;
		float t = bodyA.t;
		float r2 = bodyB.r;
		float t2 = bodyB.t;
		Vector2 normal = A_0.normal;
		float y = normal.Y;
		float num = 0f - normal.X;
		float friction = A_0.friction;
		float num2 = f2.X + (0f - g2) * A_1.rB.Y - f.X - (0f - g) * A_1.rA.Y;
		float num3 = f2.Y + g2 * A_1.rB.X - f.Y - g * A_1.rA.X;
		float num4 = num2 * y + num3 * num;
		float num5 = A_1.tangentMass * (0f - num4);
		float num6 = friction * A_1.normalImpulse;
		float num7 = A_1.tangentImpulse + num5;
		if (num7 < 0f - num6)
		{
			num7 = 0f - num6;
		}
		if (num7 > num6)
		{
			num7 = num6;
		}
		num5 = num7 - A_1.tangentImpulse;
		float num8 = num5 * y;
		float num9 = num5 * num;
		f.X -= r * num8;
		f.Y -= r * num9;
		g -= t * (A_1.rA.X * num9 - A_1.rA.Y * num8);
		f2.X += r2 * num8;
		f2.Y += r2 * num9;
		g2 += t2 * (A_1.rB.X * num9 - A_1.rB.Y * num8);
		A_1.tangentImpulse = num7;
		num2 = f2.X + (0f - g2) * A_1.rB.Y - f.X - (0f - g) * A_1.rA.Y;
		num3 = f2.Y + g2 * A_1.rB.X - f.Y - g * A_1.rA.X;
		float num10 = num2 * normal.X + num3 * normal.Y;
		num5 = (0f - A_1.normalMass) * (num10 - A_1.velocityBias);
		num7 = A_1.normalImpulse + num5;
		if (num7 < 0f)
		{
			num7 = 0f;
		}
		num5 = num7 - A_1.normalImpulse;
		num8 = num5 * normal.X;
		num9 = num5 * normal.Y;
		f.X -= r * num8;
		f.Y -= r * num9;
		g -= t * (A_1.rA.X * num9 - A_1.rA.Y * num8);
		f2.X += r2 * num8;
		f2.Y += r2 * num9;
		g2 += t2 * (A_1.rB.X * num9 - A_1.rB.Y * num8);
		A_0.points._value0.normalImpulse = num7;
		A_0.bodyA.f = f;
		A_0.bodyA.g = g;
		A_0.bodyB.f = f2;
		A_0.bodyB.g = g2;
	}

	private static void a(ref ContactConstraint A_0, ref ContactConstraintPoint A_1, ref ContactConstraintPoint A_2)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		Body bodyA = A_0.bodyA;
		Body bodyB = A_0.bodyB;
		float g = bodyA.g;
		float g2 = bodyB.g;
		Vector2 A_3 = bodyA.f;
		Vector2 A_4 = bodyB.f;
		float r = bodyA.r;
		float t = bodyA.t;
		float r2 = bodyB.r;
		float t2 = bodyB.t;
		Vector2 normal = A_0.normal;
		float y = normal.Y;
		float num = 0f - normal.X;
		float friction = A_0.friction;
		float num2 = A_4.X + (0f - g2) * A_1.rB.Y - A_3.X - (0f - g) * A_1.rA.Y;
		float num3 = A_4.Y + g2 * A_1.rB.X - A_3.Y - g * A_1.rA.X;
		float num4 = num2 * y + num3 * num;
		float num5 = A_1.tangentMass * (0f - num4);
		float num6 = friction * A_1.normalImpulse;
		float num7 = A_1.tangentImpulse + num5;
		if (num7 < 0f - num6)
		{
			num7 = 0f - num6;
		}
		if (num7 > num6)
		{
			num7 = num6;
		}
		num5 = num7 - A_1.tangentImpulse;
		float num8 = num5 * y;
		float num9 = num5 * num;
		A_3.X -= r * num8;
		A_3.Y -= r * num9;
		g -= t * (A_1.rA.X * num9 - A_1.rA.Y * num8);
		A_4.X += r2 * num8;
		A_4.Y += r2 * num9;
		g2 += t2 * (A_1.rB.X * num9 - A_1.rB.Y * num8);
		A_1.tangentImpulse = num7;
		num2 = A_4.X + (0f - g2) * A_2.rB.Y - A_3.X - (0f - g) * A_2.rA.Y;
		num3 = A_4.Y + g2 * A_2.rB.X - A_3.Y - g * A_2.rA.X;
		num4 = num2 * y + num3 * num;
		num5 = A_2.tangentMass * (0f - num4);
		num6 = friction * A_2.normalImpulse;
		num7 = A_2.tangentImpulse + num5;
		if (num7 < 0f - num6)
		{
			num7 = 0f - num6;
		}
		if (num7 > num6)
		{
			num7 = num6;
		}
		num5 = num7 - A_2.tangentImpulse;
		num8 = num5 * y;
		num9 = num5 * num;
		A_3.X -= r * num8;
		A_3.Y -= r * num9;
		g -= t * (A_2.rA.X * num9 - A_2.rA.Y * num8);
		A_4.X += r2 * num8;
		A_4.Y += r2 * num9;
		g2 += t2 * (A_2.rB.X * num9 - A_2.rB.Y * num8);
		A_2.tangentImpulse = num7;
		a(ref A_0, ref g, ref g2, ref A_3, ref A_4, r, t, r2, t2, normal, ref A_1, ref A_2);
		A_0.bodyA.f = A_3;
		A_0.bodyA.g = g;
		A_0.bodyB.f = A_4;
		A_0.bodyB.g = g2;
	}

	public void StoreImpulses()
	{
		for (int i = 0; i < _constraintCount; i++)
		{
			ContactConstraint contactConstraint = _constraints[i];
			Manifold manifold = contactConstraint.manifold;
			if (contactConstraint.pointCount > 0)
			{
				manifold._points._value0.NormalImpulse = contactConstraint.points._value0.normalImpulse;
				manifold._points._value0.TangentImpulse = contactConstraint.points._value0.tangentImpulse;
				if (contactConstraint.pointCount > 1)
				{
					manifold._points._value1.NormalImpulse = contactConstraint.points._value1.normalImpulse;
					manifold._points._value1.TangentImpulse = contactConstraint.points._value1.tangentImpulse;
				}
			}
			_constraints[i].manifold = manifold;
			this.m_a[i].m = manifold;
		}
	}

	public bool SolvePositionConstraints(float baumgarte)
	{
		float A_ = 0f;
		for (int i = 0; i < _constraintCount; i++)
		{
			a(baumgarte, ref A_, ref _constraints[i]);
		}
		return A_ >= -0.075f;
	}

	private static void a(float A_0, ref float A_1, ref ContactConstraint A_2)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		ad ad = new ad(ref A_2);
		Body bodyA = A_2.bodyA;
		Body bodyB = A_2.bodyB;
		float num = bodyA.q * bodyA.r;
		float num2 = bodyA.q * bodyA.t;
		float num3 = bodyB.q * bodyB.r;
		float num4 = bodyB.q * bodyB.t;
		for (int i = 0; i < A_2.pointCount; i++)
		{
			ad.a(ref A_2, i);
			Vector2 b = ad.b;
			Vector2 c = ad.c;
			float d = ad.d;
			if (A_1 > d)
			{
				A_1 = d;
			}
			float num5 = A_0 * (d + 0.05f);
			if (num5 < -0.2f)
			{
				num5 = -0.2f;
			}
			if (num5 <= 0f)
			{
				float num6 = c.X - bodyA.e.c.X;
				float num7 = c.Y - bodyA.e.c.Y;
				float num8 = c.X - bodyB.e.c.X;
				float num9 = c.Y - bodyB.e.c.Y;
				float num10 = num6 * b.Y - num7 * b.X;
				float num11 = num8 * b.Y - num9 * b.X;
				float num12 = num + num3 + num2 * num10 * num10 + num4 * num11 * num11;
				if (num12 > 0f)
				{
					float num13 = (0f - num5) / num12;
					float num14 = num13 * b.X;
					float num15 = num13 * b.Y;
					ref Vector2 c2 = ref bodyA.e.c;
					c2.X -= num * num14;
					ref Vector2 c3 = ref bodyA.e.c;
					c3.Y -= num * num15;
					bodyA.e.a -= num2 * (num6 * num15 - num7 * num14);
					bodyA.M_a();
					ref Vector2 c4 = ref bodyB.e.c;
					c4.X += num3 * num14;
					ref Vector2 c5 = ref bodyB.e.c;
					c5.Y += num3 * num15;
					bodyB.e.a += num4 * (num8 * num15 - num9 * num14);
					bodyB.M_a();
				}
			}
		}
	}
}
