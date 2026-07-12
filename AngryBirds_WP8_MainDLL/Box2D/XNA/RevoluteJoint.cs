using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class RevoluteJoint : Joint
{
	public Vector2 _localAnchor1;

	public Vector2 _localAnchor2;

	public Vector3 _impulse;

	public float _motorImpulse;

	public Mat33 _mass;

	public float _motorMass;

	public bool _enableMotor;

	public float _maxMotorTorque;

	public float _motorSpeed;

	public bool _enableLimit;

	public float _referenceAngle;

	public float _lowerAngle;

	public float _upperAngle;

	public LimitState _limitState;

	public override Vector2 GetAnchorA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return f.GetWorldPoint(_localAnchor1);
	}

	public override Vector2 GetAnchorB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return g.GetWorldPoint(_localAnchor2);
	}

	public override Vector2 GetReactionForce(float inv_dt)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
		val = new Vector2(_impulse.X, _impulse.Y);
		return inv_dt * val;
	}

	public override float GetReactionTorque(float inv_dt)
	{
		return inv_dt * _impulse.Z;
	}

	public float GetJointAngle()
	{
		Body body = f;
		Body body2 = g;
		return body2.e.a - body.e.a - _referenceAngle;
	}

	public float GetJointSpeed()
	{
		Body body = f;
		Body body2 = g;
		return body2.g - body.g;
	}

	public bool IsLimitEnabled()
	{
		return _enableLimit;
	}

	public void EnableLimit(bool flag)
	{
		f.SetAwake(flag: true);
		g.SetAwake(flag: true);
		_enableLimit = flag;
	}

	public float GetLowerLimit()
	{
		return _lowerAngle;
	}

	public float GetUpperLimit()
	{
		return _upperAngle;
	}

	public void SetLimits(float lower, float upper)
	{
		f.SetAwake(flag: true);
		g.SetAwake(flag: true);
		_lowerAngle = lower;
		_upperAngle = upper;
	}

	public bool IsMotorEnabled()
	{
		return _enableMotor;
	}

	public void EnableMotor(bool flag)
	{
		f.SetAwake(flag: true);
		g.SetAwake(flag: true);
		_enableMotor = flag;
	}

	public void SetMotorSpeed(float speed)
	{
		f.SetAwake(flag: true);
		g.SetAwake(flag: true);
		_motorSpeed = speed;
	}

	public float GetMotorSpeed()
	{
		return _motorSpeed;
	}

	public void SetMaxMotorTorque(float torque)
	{
		f.SetAwake(flag: true);
		g.SetAwake(flag: true);
		_maxMotorTorque = torque;
	}

	public float GetMotorTorque()
	{
		return _motorImpulse;
	}

	internal RevoluteJoint(RevoluteJointDef A_0)
		: base(A_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		_localAnchor1 = A_0.localAnchorA;
		_localAnchor2 = A_0.localAnchorB;
		_referenceAngle = A_0.referenceAngle;
		_impulse = Vector3.Zero;
		_motorImpulse = 0f;
		_lowerAngle = A_0.lowerAngle;
		_upperAngle = A_0.upperAngle;
		_maxMotorTorque = A_0.maxMotorTorque;
		_motorSpeed = A_0.motorSpeed;
		_enableLimit = A_0.enableLimit;
		_enableMotor = A_0.enableMotor;
		_limitState = LimitState.Inactive;
	}

	internal override void InitVelocityConstraints(ref TimeStep step)
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
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		Body body = f;
		Body body2 = g;
		if (!_enableMotor)
		{
			_ = _enableLimit;
		}
		Vector2 val = MathUtils.Multiply(ref body.d.R, _localAnchor1 - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, _localAnchor2 - body2.e.localCenter);
		float r = body.r;
		float r2 = body2.r;
		float t = body.t;
		float t2 = body2.t;
		_mass.col1.X = r + r2 + val.Y * val.Y * t + val2.Y * val2.Y * t2;
		_mass.col2.X = (0f - val.Y) * val.X * t - val2.Y * val2.X * t2;
		_mass.col3.X = (0f - val.Y) * t - val2.Y * t2;
		_mass.col1.Y = _mass.col2.X;
		_mass.col2.Y = r + r2 + val.X * val.X * t + val2.X * val2.X * t2;
		_mass.col3.Y = val.X * t + val2.X * t2;
		_mass.col1.Z = _mass.col3.X;
		_mass.col2.Z = _mass.col3.Y;
		_mass.col3.Z = t + t2;
		_motorMass = t + t2;
		if (_motorMass > 0f)
		{
			_motorMass = 1f / _motorMass;
		}
		if (!_enableMotor)
		{
			_motorImpulse = 0f;
		}
		if (_enableLimit)
		{
			float num = body2.e.a - body.e.a - _referenceAngle;
			if (Math.Abs(_upperAngle - _lowerAngle) < (float)Math.PI / 45f)
			{
				_limitState = LimitState.Equal;
			}
			else if (num <= _lowerAngle)
			{
				if (_limitState != LimitState.AtLower)
				{
					_impulse.Z = 0f;
				}
				_limitState = LimitState.AtLower;
			}
			else if (num >= _upperAngle)
			{
				if (_limitState != LimitState.AtUpper)
				{
					_impulse.Z = 0f;
				}
				_limitState = LimitState.AtUpper;
			}
			else
			{
				_limitState = LimitState.Inactive;
				_impulse.Z = 0f;
			}
		}
		else
		{
			_limitState = LimitState.Inactive;
		}
		if (step.warmStarting)
		{
			_impulse *= step.dtRatio;
			_motorImpulse *= step.dtRatio;
			Vector2 val3 = default(Vector2);
			val3 = new Vector2(_impulse.X, _impulse.Y);
			body.f -= r * val3;
			body.g -= t * (MathUtils.Cross(val, val3) + _motorImpulse + _impulse.Z);
			body2.f += r2 * val3;
			body2.g += t2 * (MathUtils.Cross(val2, val3) + _motorImpulse + _impulse.Z);
		}
		else
		{
			_impulse = Vector3.Zero;
			_motorImpulse = 0f;
		}
	}

	internal override void SolveVelocityConstraints(ref TimeStep step)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
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
		if (_enableMotor && _limitState != LimitState.Equal)
		{
			float num3 = num2 - num - _motorSpeed;
			float num4 = _motorMass * (0f - num3);
			float motorImpulse = _motorImpulse;
			float num5 = step.dt * _maxMotorTorque;
			_motorImpulse = MathUtils.Clamp(_motorImpulse + num4, 0f - num5, num5);
			num4 = _motorImpulse - motorImpulse;
			num -= t * num4;
			num2 += t2 * num4;
		}
		if (_enableLimit && _limitState != 0)
		{
			Vector2 val3 = MathUtils.Multiply(ref body.d.R, _localAnchor1 - body.e.localCenter);
			Vector2 val4 = MathUtils.Multiply(ref body2.d.R, _localAnchor2 - body2.e.localCenter);
			Vector2 val5 = val2 + MathUtils.Cross(num2, val4) - val - MathUtils.Cross(num, val3);
			float num6 = num2 - num;
			Vector3 val6 = default(Vector3);
			val6 = new Vector3(val5.X, val5.Y, num6);
			Vector3 val7 = _mass.Solve33(-val6);
			if (_limitState == LimitState.Equal)
			{
				_impulse += val7;
			}
			else if (_limitState == LimitState.AtLower)
			{
				float num7 = _impulse.Z + val7.Z;
				if (num7 < 0f)
				{
					Vector2 val8 = _mass.Solve22(-val5);
					val7.X = val8.X;
					val7.Y = val8.Y;
					val7.Z = 0f - _impulse.Z;
					ref Vector3 impulse = ref _impulse;
					impulse.X += val8.X;
					ref Vector3 impulse2 = ref _impulse;
					impulse2.Y += val8.Y;
					_impulse.Z = 0f;
				}
			}
			else if (_limitState == LimitState.AtUpper)
			{
				float num8 = _impulse.Z + val7.Z;
				if (num8 > 0f)
				{
					Vector2 val9 = _mass.Solve22(-val5);
					val7.X = val9.X;
					val7.Y = val9.Y;
					val7.Z = 0f - _impulse.Z;
					ref Vector3 impulse3 = ref _impulse;
					impulse3.X += val9.X;
					ref Vector3 impulse4 = ref _impulse;
					impulse4.Y += val9.Y;
					_impulse.Z = 0f;
				}
			}
			Vector2 val10 = default(Vector2);
			val10 = new Vector2(val7.X, val7.Y);
			val -= r * val10;
			num -= t * (MathUtils.Cross(val3, val10) + val7.Z);
			val2 += r2 * val10;
			num2 += t2 * (MathUtils.Cross(val4, val10) + val7.Z);
		}
		else
		{
			Vector2 val11 = MathUtils.Multiply(ref body.d.R, _localAnchor1 - body.e.localCenter);
			Vector2 val12 = MathUtils.Multiply(ref body2.d.R, _localAnchor2 - body2.e.localCenter);
			Vector2 val13 = val2 + MathUtils.Cross(num2, val12) - val - MathUtils.Cross(num, val11);
			Vector2 val14 = _mass.Solve22(-val13);
			ref Vector3 impulse5 = ref _impulse;
			impulse5.X += val14.X;
			ref Vector3 impulse6 = ref _impulse;
			impulse6.Y += val14.Y;
			val -= r * val14;
			num -= t * MathUtils.Cross(val11, val14);
			val2 += r2 * val14;
			num2 += t2 * MathUtils.Cross(val12, val14);
		}
		body.f = val;
		body.g = num;
		body2.f = val2;
		body2.g = num2;
	}

	internal override bool SolvePositionConstraints(float baumgarte)
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		Body body = f;
		Body body2 = g;
		float num = 0f;
		float num2 = 0f;
		if (_enableLimit && _limitState != 0)
		{
			float num3 = body2.e.a - body.e.a - _referenceAngle;
			float num4 = 0f;
			if (_limitState == LimitState.Equal)
			{
				float num5 = MathUtils.Clamp(num3 - _lowerAngle, (float)Math.PI * -2f / 45f, (float)Math.PI * 2f / 45f);
				num4 = (0f - _motorMass) * num5;
				num = Math.Abs(num5);
			}
			else if (_limitState == LimitState.AtLower)
			{
				float num6 = num3 - _lowerAngle;
				num = 0f - num6;
				num6 = MathUtils.Clamp(num6 + (float)Math.PI / 90f, (float)Math.PI * -2f / 45f, 0f);
				num4 = (0f - _motorMass) * num6;
			}
			else if (_limitState == LimitState.AtUpper)
			{
				float num7 = num3 - _upperAngle;
				num = num7;
				num7 = MathUtils.Clamp(num7 - (float)Math.PI / 90f, 0f, (float)Math.PI * 2f / 45f);
				num4 = (0f - _motorMass) * num7;
			}
			body.e.a -= body.t * num4;
			body2.e.a += body2.t * num4;
			body.M_a();
			body2.M_a();
		}
		Vector2 val = MathUtils.Multiply(ref body.d.R, _localAnchor1 - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, _localAnchor2 - body2.e.localCenter);
		Vector2 val3 = body2.e.c + val2 - body.e.c - val;
		num2 = val3.Length();
		float r = body.r;
		float r2 = body2.r;
		float t = body.t;
		float t2 = body2.t;
		if (val3.LengthSquared() > 0.25f)
		{
			Vector2 val4 = val3;
			val4.Normalize();
			float num8 = r + r2;
			float num9 = 1f / num8;
			Vector2 val5 = num9 * -val3;
			ref Sweep reference = ref body.e;
			reference.c -= 0.5f * r * val5;
			ref Sweep reference2 = ref body2.e;
			reference2.c += 0.5f * r2 * val5;
			val3 = body2.e.c + val2 - body.e.c - val;
		}
		Mat22 A = new Mat22(new Vector2(r + r2, 0f), new Vector2(0f, r + r2));
		Mat22 B = new Mat22(new Vector2(t * val.Y * val.Y, (0f - t) * val.X * val.Y), new Vector2((0f - t) * val.X * val.Y, t * val.X * val.X));
		Mat22 B2 = new Mat22(new Vector2(t2 * val2.Y * val2.Y, (0f - t2) * val2.X * val2.Y), new Vector2((0f - t2) * val2.X * val2.Y, t2 * val2.X * val2.X));
		Mat22.Add(ref A, ref B, out var R);
		Mat22.Add(ref R, ref B2, out var R2);
		Vector2 val6 = R2.Solve(-val3);
		ref Sweep reference3 = ref body.e;
		reference3.c -= body.r * val6;
		body.e.a -= body.t * MathUtils.Cross(val, val6);
		ref Sweep reference4 = ref body2.e;
		reference4.c += body2.r * val6;
		body2.e.a += body2.t * MathUtils.Cross(val2, val6);
		body.M_a();
		body2.M_a();
		if (num2 <= 0.05f)
		{
			return num <= (float)Math.PI / 90f;
		}
		return false;
	}
}
