using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class GearJoint : Joint
{
	internal new Body a;

	internal new Body b;

	internal new RevoluteJoint c;

	internal new PrismaticJoint d;

	internal new RevoluteJoint e;

	internal new PrismaticJoint f;

	internal new Vector2 g;

	internal new Vector2 h;

	internal new Vector2 i;

	internal new Vector2 j;

	internal new bv k;

	internal new float l;

	internal new float m;

	internal new float n;

	internal new float o;

	public override Vector2 GetAnchorA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return base.f.GetWorldPoint(i);
	}

	public override Vector2 GetAnchorB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return base.g.GetWorldPoint(j);
	}

	public override Vector2 GetReactionForce(float inv_dt)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = o * k.c;
		return inv_dt * val;
	}

	public override float GetReactionTorque(float inv_dt)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = MathUtils.Multiply(ref base.g.d.R, j - base.g.e.localCenter);
		Vector2 val2 = o * k.c;
		float num = o * k.d - MathUtils.Cross(val, val2);
		return inv_dt * num;
	}

	public float GetRatio()
	{
		return m;
	}

	public void SetRatio(float ratio)
	{
		m = ratio;
	}

	internal GearJoint(GearJointDef A_0)
		: base(A_0)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		JointType jointType = A_0.joint1.JointType;
		JointType jointType2 = A_0.joint2.JointType;
		c = null;
		d = null;
		e = null;
		f = null;
		a = A_0.joint1.GetBodyA();
		base.f = A_0.joint1.GetBodyB();
		float num;
		if (jointType == JointType.Revolute)
		{
			c = (RevoluteJoint)A_0.joint1;
			g = c._localAnchor1;
			i = c._localAnchor2;
			num = c.GetJointAngle();
		}
		else
		{
			d = (PrismaticJoint)A_0.joint1;
			g = d._localAnchor1;
			i = d._localAnchor2;
			num = d.GetJointTranslation();
		}
		b = A_0.joint2.GetBodyA();
		base.g = A_0.joint2.GetBodyB();
		float num2;
		if (jointType2 == JointType.Revolute)
		{
			e = (RevoluteJoint)A_0.joint2;
			h = e._localAnchor1;
			j = e._localAnchor2;
			num2 = e.GetJointAngle();
		}
		else
		{
			f = (PrismaticJoint)A_0.joint2;
			h = f._localAnchor1;
			j = f._localAnchor2;
			num2 = f.GetJointTranslation();
		}
		m = A_0.ratio;
		l = num + m * num2;
		o = 0f;
	}

	internal override void InitVelocityConstraints(ref TimeStep step)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		Body body = a;
		Body body2 = base.f;
		Body body3 = base.g;
		float num = 0f;
		k.e();
		if (c != null)
		{
			k.b = -1f;
			num += body2.t;
		}
		else
		{
			Vector2 val = MathUtils.Multiply(ref body.d.R, d._localXAxis1);
			Vector2 val2 = MathUtils.Multiply(ref body2.d.R, i - body2.e.localCenter);
			float num2 = MathUtils.Cross(val2, val);
			k.a = -val;
			k.b = 0f - num2;
			num += body2.r + body2.t * num2 * num2;
		}
		if (e != null)
		{
			k.d = 0f - m;
			num += m * m * body3.t;
		}
		else
		{
			Vector2 val3 = MathUtils.Multiply(ref body.d.R, f._localXAxis1);
			Vector2 val4 = MathUtils.Multiply(ref body3.d.R, j - body3.e.localCenter);
			float num3 = MathUtils.Cross(val4, val3);
			k.c = (0f - m) * val3;
			k.d = (0f - m) * num3;
			num += m * m * (body3.r + body3.t * num3 * num3);
		}
		n = ((num > 0f) ? (1f / num) : 0f);
		if (step.warmStarting)
		{
			body2.f += body2.r * o * k.a;
			body2.g += body2.t * o * k.b;
			body3.f += body3.r * o * k.c;
			body3.g += body3.t * o * k.d;
		}
		else
		{
			o = 0f;
		}
	}

	internal override void SolveVelocityConstraints(ref TimeStep step)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		Body body = base.f;
		Body body2 = base.g;
		float num = k.e(body.f, body.g, body2.f, body2.g);
		float num2 = n * (0f - num);
		o += num2;
		body.f += body.r * num2 * k.a;
		body.g += body.t * num2 * k.b;
		body2.f += body2.r * num2 * k.c;
		body2.g += body2.t * num2 * k.d;
	}

	internal override bool SolvePositionConstraints(float baumgarte)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		float num = 0f;
		Body body = base.f;
		Body body2 = base.g;
		float num2 = ((c == null) ? d.GetJointTranslation() : c.GetJointAngle());
		float num3 = ((e == null) ? f.GetJointTranslation() : e.GetJointAngle());
		float num4 = l - (num2 + m * num3);
		float num5 = n * (0f - num4);
		ref Sweep reference = ref body.e;
		reference.c += body.r * num5 * k.a;
		body.e.a += body.t * num5 * k.b;
		ref Sweep reference2 = ref body2.e;
		reference2.c += body2.r * num5 * k.c;
		body2.e.a += body2.t * num5 * k.d;
		body.M_a();
		body2.M_a();
		return num < 0.05f;
	}
}
