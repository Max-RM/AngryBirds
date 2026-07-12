using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class FrictionJoint : Joint
{
	internal new Vector2 a;

	internal new Vector2 b;

	internal new Mat22 c;

	internal new float d;

	internal new Vector2 e;

	internal new float f;

	internal new float g;

	internal new float h;

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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return inv_dt * e;
	}

	public override float GetReactionTorque(float inv_dt)
	{
		return inv_dt * f;
	}

	public void SetMaxForce(float force)
	{
		g = force;
	}

	public float GetMaxForce()
	{
		return g;
	}

	public void SetMaxTorque(float torque)
	{
		h = torque;
	}

	public float GetMaxTorque()
	{
		return h;
	}

	internal FrictionJoint(FrictionJointDef A_0)
		: base(A_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		a = A_0.localAnchorA;
		b = A_0.localAnchorB;
		g = A_0.maxForce;
		h = A_0.maxTorque;
	}

	internal override void InitVelocityConstraints(ref TimeStep step)
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
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = MathUtils.Multiply(ref body.d.R, a - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, b - body2.e.localCenter);
		float r = body.r;
		float r2 = body2.r;
		float t = body.t;
		float t2 = body2.t;
		Mat22 A = default(Mat22);
		A.col1.X = r + r2;
		A.col2.X = 0f;
		A.col1.Y = 0f;
		A.col2.Y = r + r2;
		Mat22 B = default(Mat22);
		B.col1.X = t * val.Y * val.Y;
		B.col2.X = (0f - t) * val.X * val.Y;
		B.col1.Y = (0f - t) * val.X * val.Y;
		B.col2.Y = t * val.X * val.X;
		Mat22 B2 = default(Mat22);
		B2.col1.X = t2 * val2.Y * val2.Y;
		B2.col2.X = (0f - t2) * val2.X * val2.Y;
		B2.col1.Y = (0f - t2) * val2.X * val2.Y;
		B2.col2.Y = t2 * val2.X * val2.X;
		Mat22.Add(ref A, ref B, out var R);
		Mat22.Add(ref R, ref B2, out var R2);
		c = R2.GetInverse();
		d = t + t2;
		if (d > 0f)
		{
			d = 1f / d;
		}
		if (step.warmStarting)
		{
			e *= step.dtRatio;
			f *= step.dtRatio;
			Vector2 val3 = default(Vector2);
			val3 = new Vector2(e.X, e.Y);
			body.f -= r * val3;
			body.g -= t * (MathUtils.Cross(val, val3) + f);
			body2.f += r2 * val3;
			body2.g += t2 * (MathUtils.Cross(val2, val3) + f);
		}
		else
		{
			e = Vector2.Zero;
			f = 0f;
		}
	}

	internal override void SolveVelocityConstraints(ref TimeStep step)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = body.f;
		float num = body.g;
		Vector2 val2 = body2.f;
		float num2 = body2.g;
		float r = body.r;
		float r2 = body2.r;
		float t = body.t;
		float t2 = body2.t;
		Vector2 val3 = MathUtils.Multiply(ref body.d.R, a - body.e.localCenter);
		Vector2 val4 = MathUtils.Multiply(ref body2.d.R, b - body2.e.localCenter);
		float num3 = num2 - num;
		float num4 = (0f - d) * num3;
		float num5 = f;
		float num6 = step.dt * h;
		f = MathUtils.Clamp(f + num4, 0f - num6, num6);
		num4 = f - num5;
		num -= t * num4;
		num2 += t2 * num4;
		Vector2 v = val2 + MathUtils.Cross(num2, val4) - val - MathUtils.Cross(num, val3);
		Vector2 val5 = -MathUtils.Multiply(ref c, v);
		Vector2 val6 = e;
		e += val5;
		float num7 = step.dt * g;
		if (e.LengthSquared() > num7 * num7)
		{
			e.Normalize();
			e *= num7;
		}
		val5 = e - val6;
		val -= r * val5;
		num -= t * MathUtils.Cross(val3, val5);
		val2 += r2 * val5;
		num2 += t2 * MathUtils.Cross(val4, val5);
		body.f = val;
		body.g = num;
		body2.f = val2;
		body2.g = num2;
	}

	internal override bool SolvePositionConstraints(float baumgarte)
	{
		return true;
	}
}
