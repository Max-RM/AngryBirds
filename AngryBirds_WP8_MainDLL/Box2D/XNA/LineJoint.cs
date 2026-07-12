using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class LineJoint : Joint
{
	internal new Vector2 a;

	internal new Vector2 b;

	internal new Vector2 c;

	internal new Vector2 d;

	internal new Vector2 e;

	internal new Vector2 f;

	internal new float g;

	internal new float h;

	internal new float i;

	internal new float j;

	internal new Mat22 k;

	internal new Vector2 l;

	internal new float m;

	internal new float n;

	internal new float o;

	internal new float p;

	internal float q;

	internal float r;

	internal bool s;

	internal bool t;

	internal LimitState u;

	public override Vector2 GetAnchorA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return base.f.GetWorldPoint(a);
	}

	public override Vector2 GetAnchorB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return base.g.GetWorldPoint(b);
	}

	public override Vector2 GetReactionForce(float inv_dt)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		return inv_dt * (l.X * f + (n + l.Y) * e);
	}

	public override float GetReactionTorque(float inv_dt)
	{
		return 0f;
	}

	public float GetJointTranslation()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 worldPoint = body.GetWorldPoint(a);
		Vector2 worldPoint2 = body2.GetWorldPoint(b);
		Vector2 val = worldPoint2 - worldPoint;
		Vector2 worldVector = body.GetWorldVector(c);
		return Vector2.Dot(val, worldVector);
	}

	public float GetJointSpeed()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = MathUtils.Multiply(ref body.d.R, a - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, b - body2.e.localCenter);
		Vector2 val3 = body.e.c + val;
		Vector2 val4 = body2.e.c + val2;
		Vector2 val5 = val4 - val3;
		Vector2 worldVector = body.GetWorldVector(c);
		Vector2 val6 = body.f;
		Vector2 val7 = body2.f;
		float num = body.g;
		float num2 = body2.g;
		return Vector2.Dot(val5, MathUtils.Cross(num, worldVector)) + Vector2.Dot(worldVector, val7 + MathUtils.Cross(num2, val2) - val6 - MathUtils.Cross(num, val));
	}

	public bool IsLimitEnabled()
	{
		return s;
	}

	public void EnableLimit(bool flag)
	{
		base.f.SetAwake(flag: true);
		base.g.SetAwake(flag: true);
		s = flag;
	}

	public float GetLowerLimit()
	{
		return o;
	}

	public float GetUpperLimit()
	{
		return p;
	}

	public void SetLimits(float lower, float upper)
	{
		base.f.SetAwake(flag: true);
		base.g.SetAwake(flag: true);
		o = lower;
		p = upper;
	}

	public bool IsMotorEnabled()
	{
		return t;
	}

	public void EnableMotor(bool flag)
	{
		base.f.SetAwake(flag: true);
		base.g.SetAwake(flag: true);
		t = flag;
	}

	public void SetMotorSpeed(float speed)
	{
		base.f.SetAwake(flag: true);
		base.g.SetAwake(flag: true);
		r = speed;
	}

	public float GetMotorSpeed()
	{
		return r;
	}

	public float GetMaxMotorForce()
	{
		return q;
	}

	public void SetMaxMotorForce(float force)
	{
		base.f.SetAwake(flag: true);
		base.g.SetAwake(flag: true);
		q = force;
	}

	public float GetMotorForce()
	{
		return n;
	}

	internal LineJoint(LineJointDef A_0)
		: base(A_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		a = A_0.localAnchorA;
		b = A_0.localAnchorB;
		c = A_0.localAxisA;
		d = MathUtils.Cross(1f, c);
		l = Vector2.Zero;
		m = 0f;
		n = 0f;
		o = A_0.lowerTranslation;
		p = A_0.upperTranslation;
		q = A_0.maxMotorForce;
		r = A_0.motorSpeed;
		s = A_0.enableLimit;
		t = A_0.enableMotor;
		u = LimitState.Inactive;
		e = Vector2.Zero;
		f = Vector2.Zero;
	}

	internal override void InitVelocityConstraints(ref TimeStep step)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		base.k = body.e.localCenter;
		base.l = body2.e.localCenter;
		Vector2 val = MathUtils.Multiply(ref body.d.R, a - base.k);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, b - base.l);
		Vector2 val3 = body2.e.c + val2 - body.e.c - val;
		base.m = body.r;
		base.n = body.t;
		base.o = body2.r;
		base.p = body2.t;
		e = MathUtils.Multiply(ref body.d.R, c);
		i = MathUtils.Cross(val3 + val, e);
		j = MathUtils.Cross(val2, e);
		m = base.m + base.o + base.n * i * i + base.p * j * j;
		if (m > 1.1920929E-07f)
		{
			m = 1f / m;
		}
		else
		{
			m = 0f;
		}
		f = MathUtils.Multiply(ref body.d.R, d);
		g = MathUtils.Cross(val3 + val, f);
		h = MathUtils.Cross(val2, f);
		float num = base.m;
		float num2 = base.o;
		float num3 = base.n;
		float num4 = base.p;
		float num5 = num + num2 + num3 * g * g + num4 * h * h;
		float num6 = num3 * g * i + num4 * h * j;
		float num7 = num + num2 + num3 * i * i + num4 * j * j;
		k.col1 = new Vector2(num5, num6);
		k.col2 = new Vector2(num6, num7);
		if (s)
		{
			float num8 = Vector2.Dot(e, val3);
			if (Math.Abs(p - o) < 0.1f)
			{
				u = LimitState.Equal;
			}
			else if (num8 <= o)
			{
				if (u != LimitState.AtLower)
				{
					u = LimitState.AtLower;
					l.Y = 0f;
				}
			}
			else if (num8 >= p)
			{
				if (u != LimitState.AtUpper)
				{
					u = LimitState.AtUpper;
					l.Y = 0f;
				}
			}
			else
			{
				u = LimitState.Inactive;
				l.Y = 0f;
			}
		}
		else
		{
			u = LimitState.Inactive;
		}
		if (!t)
		{
			n = 0f;
		}
		if (step.warmStarting)
		{
			l *= step.dtRatio;
			n *= step.dtRatio;
			Vector2 val4 = l.X * f + (n + l.Y) * e;
			float num9 = l.X * g + (n + l.Y) * i;
			float num10 = l.X * h + (n + l.Y) * j;
			body.f -= base.m * val4;
			body.g -= base.n * num9;
			body2.f += base.o * val4;
			body2.g += base.p * num10;
		}
		else
		{
			l = Vector2.Zero;
			n = 0f;
		}
	}

	internal override void SolveVelocityConstraints(ref TimeStep step)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = body.f;
		float num = body.g;
		Vector2 val2 = body2.f;
		float num2 = body2.g;
		if (t && u != LimitState.Equal)
		{
			float num3 = Vector2.Dot(e, val2 - val) + j * num2 - i * num;
			float num4 = m * (r - num3);
			float num5 = n;
			float num6 = step.dt * q;
			n = MathUtils.Clamp(n + num4, 0f - num6, num6);
			num4 = n - num5;
			Vector2 val3 = num4 * e;
			float num7 = num4 * i;
			float num8 = num4 * j;
			val -= base.m * val3;
			num -= base.n * num7;
			val2 += base.o * val3;
			num2 += base.p * num8;
		}
		float num9 = Vector2.Dot(f, val2 - val) + h * num2 - g * num;
		if (s && u != 0)
		{
			float num10 = Vector2.Dot(e, val2 - val) + j * num2 - i * num;
			Vector2 val4 = default(Vector2);
			val4 = new Vector2(num9, num10);
			Vector2 val5 = l;
			Vector2 val6 = k.Solve(-val4);
			l += val6;
			if (u == LimitState.AtLower)
			{
				l.Y = Math.Max(l.Y, 0f);
			}
			else if (u == LimitState.AtUpper)
			{
				l.Y = Math.Min(l.Y, 0f);
			}
			float num11 = 0f - num9 - (l.Y - val5.Y) * k.col2.X;
			float x = ((k.col1.X == 0f) ? val5.X : (num11 / k.col1.X + val5.X));
			l.X = x;
			val6 = l - val5;
			Vector2 val7 = val6.X * f + val6.Y * e;
			float num12 = val6.X * g + val6.Y * i;
			float num13 = val6.X * h + val6.Y * j;
			val -= base.m * val7;
			num -= base.n * num12;
			val2 += base.o * val7;
			num2 += base.p * num13;
		}
		else
		{
			float num14 = ((k.col1.X == 0f) ? 0f : ((0f - num9) / k.col1.X));
			ref Vector2 reference = ref l;
			reference.X += num14;
			Vector2 val8 = num14 * f;
			float num15 = num14 * g;
			float num16 = num14 * h;
			val -= base.m * val8;
			num -= base.n * num15;
			val2 += base.o * val8;
			num2 += base.p * num16;
		}
		body.f = val;
		body.g = num;
		body2.f = val2;
		body2.g = num2;
	}

	internal override bool SolvePositionConstraints(float baumgarte)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = body.e.c;
		float num = body.e.a;
		Vector2 val2 = body2.e.c;
		float num2 = body2.e.a;
		float val3 = 0f;
		float num3 = 0f;
		bool flag = false;
		float num4 = 0f;
		Mat22 A = new Mat22(num);
		Mat22 A2 = new Mat22(num2);
		Vector2 val4 = MathUtils.Multiply(ref A, a - base.k);
		Vector2 val5 = MathUtils.Multiply(ref A2, b - base.l);
		Vector2 val6 = val2 + val5 - val - val4;
		if (s)
		{
			e = MathUtils.Multiply(ref A, c);
			i = MathUtils.Cross(val6 + val4, e);
			j = MathUtils.Cross(val5, e);
			float num5 = Vector2.Dot(e, val6);
			if (Math.Abs(p - o) < 0.1f)
			{
				num4 = MathUtils.Clamp(num5, -0.2f, 0.2f);
				val3 = Math.Abs(num5);
				flag = true;
			}
			else if (num5 <= o)
			{
				num4 = MathUtils.Clamp(num5 - o + 0.05f, -0.2f, 0f);
				val3 = o - num5;
				flag = true;
			}
			else if (num5 >= p)
			{
				num4 = MathUtils.Clamp(num5 - p - 0.05f, 0f, 0.2f);
				val3 = num5 - p;
				flag = true;
			}
		}
		f = MathUtils.Multiply(ref A, d);
		g = MathUtils.Cross(val6 + val4, f);
		h = MathUtils.Cross(val5, f);
		float num6 = Vector2.Dot(f, val6);
		val3 = Math.Max(val3, Math.Abs(num6));
		num3 = 0f;
		Vector2 val8 = default(Vector2);
		if (flag)
		{
			float num7 = base.m;
			float num8 = base.o;
			float num9 = base.n;
			float num10 = base.p;
			float num11 = num7 + num8 + num9 * g * g + num10 * h * h;
			float num12 = num9 * g * i + num10 * h * j;
			float num13 = num7 + num8 + num9 * i * i + num10 * j * j;
			k.col1 = new Vector2(num11, num12);
			k.col2 = new Vector2(num12, num13);
			Vector2 val7 = default(Vector2);
			val7 = new Vector2(0f - num6, 0f - num4);
			val8 = k.Solve(val7);
		}
		else
		{
			float num14 = base.m;
			float num15 = base.o;
			float num16 = base.n;
			float num17 = base.p;
			float num18 = num14 + num15 + num16 * g * g + num17 * h * h;
			float x = ((num18 == 0f) ? 0f : ((0f - num6) / num18));
			val8.X = x;
			val8.Y = 0f;
		}
		Vector2 val9 = val8.X * f + val8.Y * e;
		float num19 = val8.X * g + val8.Y * i;
		float num20 = val8.X * h + val8.Y * j;
		val -= base.m * val9;
		num -= base.n * num19;
		val2 += base.o * val9;
		num2 += base.p * num20;
		body.e.c = val;
		body.e.a = num;
		body2.e.c = val2;
		body2.e.a = num2;
		body.M_a();
		body2.M_a();
		if (val3 <= 0.05f)
		{
			return num3 <= (float)Math.PI / 90f;
		}
		return false;
	}
}
