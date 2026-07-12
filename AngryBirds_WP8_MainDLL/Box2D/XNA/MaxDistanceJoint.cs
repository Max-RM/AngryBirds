using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class MaxDistanceJoint : Joint
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

	public float _length;

	public void SetLength(float length)
	{
		_length = length;
	}

	public float GetLength()
	{
		return _length;
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

	internal MaxDistanceJoint(MaxDistanceJointDef A_0)
		: base(A_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		a = A_0.localAnchorA;
		b = A_0.localAnchorB;
		_length = A_0.length;
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
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = MathUtils.Multiply(ref body.d.R, a - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, b - body2.e.localCenter);
		c = body2.e.c + val2 - body.e.c - val;
		float num = c.Length();
		if (!(num < _length))
		{
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
				float num5 = num - _length;
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
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = MathUtils.Multiply(ref body.d.R, a - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, b - body2.e.localCenter);
		Vector2 val3 = body2.e.c + val2 - body.e.c - val;
		float num = val3.Length();
		if (!(num < _length))
		{
			Vector2 val4 = body.f + MathUtils.Cross(body.g, val);
			Vector2 val5 = body2.f + MathUtils.Cross(body2.g, val2);
			float num2 = Vector2.Dot(c, val5 - val4);
			float num3 = (0f - i) * (num2 + g + f * h);
			h += num3;
			Vector2 val6 = num3 * c;
			body.f -= body.r * val6;
			body.g -= body.t * MathUtils.Cross(val, val6);
			body2.f += body2.r * val6;
			body2.g += body2.t * MathUtils.Cross(val2, val6);
		}
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
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
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
		if (num < _length)
		{
			return true;
		}
		if (num == 0f)
		{
			return true;
		}
		val3 /= num;
		float num2 = num - _length;
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
