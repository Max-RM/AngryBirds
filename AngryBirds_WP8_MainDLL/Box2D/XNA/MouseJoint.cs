using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class MouseJoint : Joint
{
	public Vector2 _localAnchor;

	public Vector2 _target;

	public Vector2 _impulse;

	public Mat22 _mass;

	public Vector2 _C;

	public float _maxForce;

	public float _frequencyHz;

	public float _dampingRatio;

	public float _beta;

	public float _gamma;

	public override Vector2 GetAnchorA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _target;
	}

	public override Vector2 GetAnchorB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return g.GetWorldPoint(_localAnchor);
	}

	public override Vector2 GetReactionForce(float inv_dt)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return inv_dt * _impulse;
	}

	public override float GetReactionTorque(float inv_dt)
	{
		return inv_dt * 0f;
	}

	public void SetTarget(Vector2 target)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (!g.IsAwake())
		{
			g.SetAwake(flag: true);
		}
		_target = target;
	}

	public Vector2 GetTarget()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _target;
	}

	public void SetMaxForce(float force)
	{
		_maxForce = force;
	}

	public float GetMaxForce()
	{
		return _maxForce;
	}

	public void SetFrequency(float hz)
	{
		_frequencyHz = hz;
	}

	public float GetFrequency()
	{
		return _frequencyHz;
	}

	public void SetDampingRatio(float ratio)
	{
		_dampingRatio = ratio;
	}

	public float GetDampingRatio()
	{
		return _dampingRatio;
	}

	internal MouseJoint(MouseJointDef A_0)
		: base(A_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		_target = A_0.target;
		_localAnchor = MathUtils.MultiplyT(ref g.d, _target);
		_maxForce = A_0.maxForce;
		_impulse = Vector2.Zero;
		_frequencyHz = A_0.frequencyHz;
		_dampingRatio = A_0.dampingRatio;
		_beta = 0f;
		_gamma = 0f;
	}

	internal override void InitVelocityConstraints(ref TimeStep step)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		Body body = g;
		float mass = body.GetMass();
		float num = (float)Math.PI * 2f * _frequencyHz;
		float num2 = 2f * mass * _dampingRatio * num;
		float num3 = mass * (num * num);
		_gamma = step.dt * (num2 + step.dt * num3);
		if (_gamma != 0f)
		{
			_gamma = 1f / _gamma;
		}
		_beta = step.dt * num3 * _gamma;
		Vector2 val = MathUtils.Multiply(ref body.d.R, _localAnchor - body.e.localCenter);
		float r = body.r;
		float t = body.t;
		Mat22 A = new Mat22(new Vector2(r, 0f), new Vector2(0f, r));
		Mat22 B = new Mat22(new Vector2(t * val.Y * val.Y, (0f - t) * val.X * val.Y), new Vector2((0f - t) * val.X * val.Y, t * val.X * val.X));
		Mat22.Add(ref A, ref B, out var R);
		ref Vector2 col = ref R.col1;
		col.X += _gamma;
		ref Vector2 col2 = ref R.col2;
		col2.Y += _gamma;
		_mass = R.GetInverse();
		_C = body.e.c + val - _target;
		body.g *= 0.98f;
		_impulse *= step.dtRatio;
		body.f += r * _impulse;
		body.g += t * MathUtils.Cross(val, _impulse);
	}

	internal override void SolveVelocityConstraints(ref TimeStep step)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		Body body = g;
		Vector2 val = MathUtils.Multiply(ref body.d.R, _localAnchor - body.e.localCenter);
		Vector2 val2 = body.f + MathUtils.Cross(body.g, val);
		Vector2 val3 = MathUtils.Multiply(ref _mass, -(val2 + _beta * _C + _gamma * _impulse));
		Vector2 impulse = _impulse;
		_impulse += val3;
		float num = step.dt * _maxForce;
		if (_impulse.LengthSquared() > num * num)
		{
			_impulse *= num / _impulse.Length();
		}
		val3 = _impulse - impulse;
		body.f += body.r * val3;
		body.g += body.t * MathUtils.Cross(val, val3);
	}

	internal override bool SolvePositionConstraints(float baumgarte)
	{
		return true;
	}
}
