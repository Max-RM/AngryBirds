using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class WeldJoint : Joint
{
	internal new Vector2 a;

	internal new Vector2 b;

	internal new float c;

	internal new Vector3 d;

	internal new Mat33 e;

	public override Vector2 GetAnchorA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return f.GetWorldPoint(a);
	}

	public override Vector2 GetAnchorB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return g.GetWorldPoint(b);
	}

	public override Vector2 GetReactionForce(float inv_dt)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		return inv_dt * new Vector2(d.X, d.Y);
	}

	public override float GetReactionTorque(float inv_dt)
	{
		return inv_dt * d.Z;
	}

	internal WeldJoint(WeldJointDef A_0)
		: base(A_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		a = A_0.localAnchorA;
		b = A_0.localAnchorB;
		c = A_0.referenceAngle;
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
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		Body body = f;
		Body body2 = g;
		Vector2 val = MathUtils.Multiply(ref body.d.R, a - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, b - body2.e.localCenter);
		float r = body.r;
		float r2 = body2.r;
		float t = body.t;
		float t2 = body2.t;
		e.col1.X = r + r2 + val.Y * val.Y * t + val2.Y * val2.Y * t2;
		e.col2.X = (0f - val.Y) * val.X * t - val2.Y * val2.X * t2;
		e.col3.X = (0f - val.Y) * t - val2.Y * t2;
		e.col1.Y = e.col2.X;
		e.col2.Y = r + r2 + val.X * val.X * t + val2.X * val2.X * t2;
		e.col3.Y = val.X * t + val2.X * t2;
		e.col1.Z = e.col3.X;
		e.col2.Z = e.col3.Y;
		e.col3.Z = t + t2;
		if (step.warmStarting)
		{
			d *= step.dtRatio;
			Vector2 val3 = default(Vector2);
			val3 = new Vector2(d.X, d.Y);
			body.f -= r * val3;
			body.g -= t * (MathUtils.Cross(val, val3) + d.Z);
			body2.f += r2 * val3;
			body2.g += t2 * (MathUtils.Cross(val2, val3) + d.Z);
		}
		else
		{
			d = Vector3.Zero;
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
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		Body body = f;
		Body body2 = g;
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
		Vector2 val5 = val2 + MathUtils.Cross(num2, val4) - val - MathUtils.Cross(num, val3);
		float num3 = num2 - num;
		Vector3 val6 = default(Vector3);
		val6 = new Vector3(val5.X, val5.Y, num3);
		Vector3 val7 = e.Solve33(-val6);
		d += val7;
		Vector2 val8 = default(Vector2);
		val8 = new Vector2(val7.X, val7.Y);
		val -= r * val8;
		num -= t * (MathUtils.Cross(val3, val8) + val7.Z);
		val2 += r2 * val8;
		num2 += t2 * (MathUtils.Cross(val4, val8) + val7.Z);
		body.f = val;
		body.g = num;
		body2.f = val2;
		body2.g = num2;
	}

	internal override bool SolvePositionConstraints(float baumgarte)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		Body body = f;
		Body body2 = g;
		float r = body.r;
		float r2 = body2.r;
		float num = body.t;
		float num2 = body2.t;
		Vector2 val = MathUtils.Multiply(ref body.d.R, a - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, b - body2.e.localCenter);
		Vector2 val3 = body2.e.c + val2 - body.e.c - val;
		float num3 = body2.e.a - body.e.a - c;
		float num4 = val3.Length();
		float num5 = Math.Abs(num3);
		if (num4 > 0.5f)
		{
			num *= 1f;
			num2 *= 1f;
		}
		e.col1.X = r + r2 + val.Y * val.Y * num + val2.Y * val2.Y * num2;
		e.col2.X = (0f - val.Y) * val.X * num - val2.Y * val2.X * num2;
		e.col3.X = (0f - val.Y) * num - val2.Y * num2;
		e.col1.Y = e.col2.X;
		e.col2.Y = r + r2 + val.X * val.X * num + val2.X * val2.X * num2;
		e.col3.Y = val.X * num + val2.X * num2;
		e.col1.Z = e.col3.X;
		e.col2.Z = e.col3.Y;
		e.col3.Z = num + num2;
		Vector3 val4 = default(Vector3);
		val4 = new Vector3(val3.X, val3.Y, num3);
		Vector3 val5 = e.Solve33(-val4);
		Vector2 val6 = default(Vector2);
		val6 = new Vector2(val5.X, val5.Y);
		ref Sweep reference = ref body.e;
		reference.c -= r * val6;
		body.e.a -= num * (MathUtils.Cross(val, val6) + val5.Z);
		ref Sweep reference2 = ref body2.e;
		reference2.c += r2 * val6;
		body2.e.a += num2 * (MathUtils.Cross(val2, val6) + val5.Z);
		body.M_a();
		body2.M_a();
		if (num4 <= 0.05f)
		{
			return num5 <= (float)Math.PI / 90f;
		}
		return false;
	}
}
