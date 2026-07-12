using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class PulleyJoint : Joint
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

	internal new float k;

	internal new float l;

	internal new float m;

	internal new float n;

	internal new float o;

	internal new float p;

	internal LimitState q;

	internal LimitState r;

	internal LimitState s;

	public override Vector2 GetAnchorA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return base.f.GetWorldPoint(c);
	}

	public override Vector2 GetAnchorB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return base.g.GetWorldPoint(d);
	}

	public override Vector2 GetReactionForce(float inv_dt)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = n * f;
		return inv_dt * val;
	}

	public override float GetReactionTorque(float inv_dt)
	{
		return 0f;
	}

	public Vector2 GetGroundAnchorA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return a;
	}

	public Vector2 GetGroundAnchorB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return b;
	}

	public float GetLength1()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		Vector2 worldPoint = base.f.GetWorldPoint(c);
		Vector2 val = a;
		Vector2 val2 = worldPoint - val;
		return val2.Length();
	}

	public float GetLength2()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		Vector2 worldPoint = base.g.GetWorldPoint(d);
		Vector2 val = b;
		Vector2 val2 = worldPoint - val;
		return val2.Length();
	}

	public float GetRatio()
	{
		return h;
	}

	internal PulleyJoint(PulleyJointDef A_0)
		: base(A_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		a = A_0.groundAnchorA;
		b = A_0.groundAnchorB;
		c = A_0.localAnchorA;
		d = A_0.localAnchorB;
		h = A_0.ratio;
		g = A_0.lengthA + h * A_0.lengthB;
		i = Math.Min(A_0.maxLengthA, g - h * 2f);
		j = Math.Min(A_0.maxLengthB, (g - 2f) / h);
		n = 0f;
		o = 0f;
		p = 0f;
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
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = MathUtils.Multiply(ref body.d.R, c - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, d - body2.e.localCenter);
		Vector2 val3 = body.e.c + val;
		Vector2 val4 = body2.e.c + val2;
		Vector2 val5 = a;
		Vector2 val6 = b;
		e = val3 - val5;
		f = val4 - val6;
		float num = e.Length();
		float num2 = f.Length();
		if (num > 0.05f)
		{
			e *= 1f / num;
		}
		else
		{
			e = Vector2.Zero;
		}
		if (num2 > 0.05f)
		{
			f *= 1f / num2;
		}
		else
		{
			f = Vector2.Zero;
		}
		float num3 = g - num - h * num2;
		if (num3 > 0f)
		{
			q = LimitState.Inactive;
			n = 0f;
		}
		else
		{
			q = LimitState.AtUpper;
		}
		if (num < i)
		{
			r = LimitState.Inactive;
			o = 0f;
		}
		else
		{
			r = LimitState.AtUpper;
		}
		if (num2 < j)
		{
			s = LimitState.Inactive;
			p = 0f;
		}
		else
		{
			s = LimitState.AtUpper;
		}
		float num4 = MathUtils.Cross(val, e);
		float num5 = MathUtils.Cross(val2, f);
		l = body.r + body.t * num4 * num4;
		m = body2.r + body2.t * num5 * num5;
		k = l + h * h * m;
		l = 1f / l;
		m = 1f / m;
		k = 1f / k;
		if (step.warmStarting)
		{
			n *= step.dtRatio;
			o *= step.dtRatio;
			p *= step.dtRatio;
			Vector2 val7 = (0f - (n + o)) * e;
			Vector2 val8 = ((0f - h) * n - p) * f;
			body.f += body.r * val7;
			body.g += body.t * MathUtils.Cross(val, val7);
			body2.f += body2.r * val8;
			body2.g += body2.t * MathUtils.Cross(val2, val8);
		}
		else
		{
			n = 0f;
			o = 0f;
			p = 0f;
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = MathUtils.Multiply(ref body.d.R, c - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, d - body2.e.localCenter);
		if (q == LimitState.AtUpper)
		{
			Vector2 val3 = body.f + MathUtils.Cross(body.g, val);
			Vector2 val4 = body2.f + MathUtils.Cross(body2.g, val2);
			float num = 0f - Vector2.Dot(e, val3) - h * Vector2.Dot(f, val4);
			float num2 = k * (0f - num);
			float num3 = n;
			n = Math.Max(0f, n + num2);
			num2 = n - num3;
			Vector2 val5 = (0f - num2) * e;
			Vector2 val6 = (0f - h) * num2 * f;
			body.f += body.r * val5;
			body.g += body.t * MathUtils.Cross(val, val5);
			body2.f += body2.r * val6;
			body2.g += body2.t * MathUtils.Cross(val2, val6);
		}
		if (r == LimitState.AtUpper)
		{
			Vector2 val7 = body.f + MathUtils.Cross(body.g, val);
			float num4 = 0f - Vector2.Dot(e, val7);
			float num5 = (0f - l) * num4;
			float num6 = o;
			o = Math.Max(0f, o + num5);
			num5 = o - num6;
			Vector2 val8 = (0f - num5) * e;
			body.f += body.r * val8;
			body.g += body.t * MathUtils.Cross(val, val8);
		}
		if (s == LimitState.AtUpper)
		{
			Vector2 val9 = body2.f + MathUtils.Cross(body2.g, val2);
			float num7 = 0f - Vector2.Dot(f, val9);
			float num8 = (0f - m) * num7;
			float num9 = p;
			p = Math.Max(0f, p + num8);
			num8 = p - num9;
			Vector2 val10 = (0f - num8) * f;
			body2.f += body2.r * val10;
			body2.g += body2.t * MathUtils.Cross(val2, val10);
		}
	}

	internal override bool SolvePositionConstraints(float baumgarte)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		Vector2 val = a;
		Vector2 val2 = b;
		float num = 0f;
		if (q == LimitState.AtUpper)
		{
			Vector2 val3 = MathUtils.Multiply(ref body.d.R, c - body.e.localCenter);
			Vector2 val4 = MathUtils.Multiply(ref body2.d.R, d - body2.e.localCenter);
			Vector2 val5 = body.e.c + val3;
			Vector2 val6 = body2.e.c + val4;
			e = val5 - val;
			f = val6 - val2;
			float num2 = e.Length();
			float num3 = f.Length();
			if (num2 > 0.05f)
			{
				e *= 1f / num2;
			}
			else
			{
				e = Vector2.Zero;
			}
			if (num3 > 0.05f)
			{
				f *= 1f / num3;
			}
			else
			{
				f = Vector2.Zero;
			}
			float num4 = g - num2 - h * num3;
			num = Math.Max(num, 0f - num4);
			num4 = MathUtils.Clamp(num4 + 0.05f, -0.2f, 0f);
			float num5 = (0f - k) * num4;
			Vector2 val7 = (0f - num5) * e;
			Vector2 val8 = (0f - h) * num5 * f;
			ref Sweep reference = ref body.e;
			reference.c += body.r * val7;
			body.e.a += body.t * MathUtils.Cross(val3, val7);
			ref Sweep reference2 = ref body2.e;
			reference2.c += body2.r * val8;
			body2.e.a += body2.t * MathUtils.Cross(val4, val8);
			body.M_a();
			body2.M_a();
		}
		if (r == LimitState.AtUpper)
		{
			Vector2 val9 = MathUtils.Multiply(ref body.d.R, c - body.e.localCenter);
			Vector2 val10 = body.e.c + val9;
			e = val10 - val;
			float num6 = e.Length();
			if (num6 > 0.05f)
			{
				e *= 1f / num6;
			}
			else
			{
				e = Vector2.Zero;
			}
			float num7 = i - num6;
			num = Math.Max(num, 0f - num7);
			num7 = MathUtils.Clamp(num7 + 0.05f, -0.2f, 0f);
			float num8 = (0f - l) * num7;
			Vector2 val11 = (0f - num8) * e;
			ref Sweep reference3 = ref body.e;
			reference3.c += body.r * val11;
			body.e.a += body.t * MathUtils.Cross(val9, val11);
			body.M_a();
		}
		if (s == LimitState.AtUpper)
		{
			Vector2 val12 = MathUtils.Multiply(ref body2.d.R, d - body2.e.localCenter);
			Vector2 val13 = body2.e.c + val12;
			f = val13 - val2;
			float num9 = f.Length();
			if (num9 > 0.05f)
			{
				f *= 1f / num9;
			}
			else
			{
				f = Vector2.Zero;
			}
			float num10 = j - num9;
			num = Math.Max(num, 0f - num10);
			num10 = MathUtils.Clamp(num10 + 0.05f, -0.2f, 0f);
			float num11 = (0f - m) * num10;
			Vector2 val14 = (0f - num11) * f;
			ref Sweep reference4 = ref body2.e;
			reference4.c += body2.r * val14;
			body2.e.a += body2.t * MathUtils.Cross(val12, val14);
			body2.M_a();
		}
		return num < 0.05f;
	}
}
