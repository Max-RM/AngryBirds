using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class DistanceJoint : Joint
{
	internal new Vector2 a;

	internal new Vector2 b;

	internal new Vector2 c;

	internal new float d;

	internal new float e;

	internal new float f;

	internal new float g;

	internal new float h;

	internal new float i;

	internal new float j;

	public void SetLength(float length)
	{
		j = length;
	}

	public float GetLength()
	{
		return j;
	}

	public void SetFrequency(float hz)
	{
		d = hz;
	}

	public float GetFrequency()
	{
		return d;
	}

	public void SetDampingRatio(float ratio)
	{
		e = ratio;
	}

	public float GetDampingRatio()
	{
		return e;
	}

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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return inv_dt * h * c;
	}

	public override float GetReactionTorque(float inv_dt)
	{
		return 0f;
	}

	internal DistanceJoint(DistanceJointDef A_0)
		: base(A_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		a = A_0.localAnchorA;
		b = A_0.localAnchorB;
		j = A_0.length;
		d = A_0.frequencyHz;
		e = A_0.dampingRatio;
		h = 0f;
		f = 0f;
		g = 0f;
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
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = MathUtils.Multiply(ref body.d.R, a - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, b - body2.e.localCenter);
		c = body2.e.c + val2 - body.e.c - val;
		float num = c.Length();
		if (num > 0.05f)
		{
			c *= 1f / num;
		}
		else
		{
			c = new Vector2(0f, 0f);
		}
		float num2 = MathUtils.Cross(val, c);
		float num3 = MathUtils.Cross(val2, c);
		float num4 = body.r + body.t * num2 * num2 + body2.r + body2.t * num3 * num3;
		i = ((num4 != 0f) ? (1f / num4) : 0f);
		if (d > 0f)
		{
			float num5 = num - j;
			float num6 = (float)Math.PI * 2f * d;
			float num7 = 2f * i * e * num6;
			float num8 = i * num6 * num6;
			f = step.dt * (num7 + step.dt * num8);
			f = ((f != 0f) ? (1f / f) : 0f);
			g = num5 * step.dt * num8 * f;
			i = num4 + f;
			i = ((i != 0f) ? (1f / i) : 0f);
		}
		if (step.warmStarting)
		{
			h *= step.dtRatio;
			Vector2 val3 = h * c;
			body.f -= body.r * val3;
			body.g -= body.t * MathUtils.Cross(val, val3);
			body2.f += body2.r * val3;
			body2.g += body2.t * MathUtils.Cross(val2, val3);
		}
		else
		{
			h = 0f;
		}
	}

	internal override void SolveVelocityConstraints(ref TimeStep step)
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
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = MathUtils.Multiply(ref body.d.R, a - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, b - body2.e.localCenter);
		Vector2 val3 = body.f + MathUtils.Cross(body.g, val);
		Vector2 val4 = body2.f + MathUtils.Cross(body2.g, val2);
		float num = Vector2.Dot(c, val4 - val3);
		float num2 = (0f - i) * (num + g + f * h);
		h += num2;
		Vector2 val5 = num2 * c;
		body.f -= body.r * val5;
		body.g -= body.t * MathUtils.Cross(val, val5);
		body2.f += body2.r * val5;
		body2.g += body2.t * MathUtils.Cross(val2, val5);
	}

	internal override bool SolvePositionConstraints(float baumgarte)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		if (d > 0f)
		{
			return true;
		}
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = MathUtils.Multiply(ref body.d.R, a - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, b - body2.e.localCenter);
		Vector2 val3 = body2.e.c + val2 - body.e.c - val;
		float num = val3.Length();
		if (num == 0f)
		{
			return true;
		}
		val3 /= num;
		float num2 = num - j;
		num2 = MathUtils.Clamp(num2, -0.2f, 0.2f);
		float num3 = (0f - i) * num2;
		c = val3;
		Vector2 val4 = num3 * c;
		ref Sweep reference = ref body.e;
		reference.c -= body.r * val4;
		body.e.a -= body.t * MathUtils.Cross(val, val4);
		ref Sweep reference2 = ref body2.e;
		reference2.c += body2.r * val4;
		body2.e.a += body2.t * MathUtils.Cross(val2, val4);
		body.M_a();
		body2.M_a();
		return Math.Abs(num2) < 0.05f;
	}
}
