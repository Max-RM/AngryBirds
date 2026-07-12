using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class PrismaticJoint : Joint
{
	public Vector2 _localAnchor1;

	public Vector2 _localAnchor2;

	public Vector2 _localXAxis1;

	public Vector2 _localYAxis1;

	public float _refAngle;

	public Vector2 _axis;

	public Vector2 _perp;

	public float _s1;

	public float _s2;

	public float _a1;

	public float _a2;

	public Mat33 _K;

	public Vector3 _impulse;

	public float _motorMass;

	public float _motorImpulse;

	public float _lowerTranslation;

	public float _upperTranslation;

	public float _maxMotorForce;

	public float _motorSpeed;

	public bool _enableLimit;

	public bool _enableMotor;

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
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		return inv_dt * (_impulse.X * _perp + (_motorImpulse + _impulse.Z) * _axis);
	}

	public override float GetReactionTorque(float inv_dt)
	{
		return inv_dt * _impulse.Y;
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
		Body body = f;
		Body body2 = g;
		Vector2 worldPoint = body.GetWorldPoint(_localAnchor1);
		Vector2 worldPoint2 = body2.GetWorldPoint(_localAnchor2);
		Vector2 val = worldPoint2 - worldPoint;
		Vector2 worldVector = body.GetWorldVector(_localXAxis1);
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
		Body body = f;
		Body body2 = g;
		Vector2 val = MathUtils.Multiply(ref body.d.R, _localAnchor1 - body.e.localCenter);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, _localAnchor2 - body2.e.localCenter);
		Vector2 val3 = body.e.c + val;
		Vector2 val4 = body2.e.c + val2;
		Vector2 val5 = val4 - val3;
		Vector2 worldVector = body.GetWorldVector(_localXAxis1);
		Vector2 val6 = body.f;
		Vector2 val7 = body2.f;
		float s = body.g;
		float s2 = body2.g;
		return Vector2.Dot(val5, MathUtils.Cross(s, worldVector)) + Vector2.Dot(worldVector, val7 + MathUtils.Cross(s2, val2) - val6 - MathUtils.Cross(s, val));
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
		return _lowerTranslation;
	}

	public float GetUpperLimit()
	{
		return _upperTranslation;
	}

	public void SetLimits(float lower, float upper)
	{
		f.SetAwake(flag: true);
		g.SetAwake(flag: true);
		_lowerTranslation = lower;
		_upperTranslation = upper;
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

	public void SetMaxMotorForce(float force)
	{
		f.SetAwake(flag: true);
		g.SetAwake(flag: true);
		_maxMotorForce = force;
	}

	public float GetMotorForce()
	{
		return _motorImpulse;
	}

	internal PrismaticJoint(PrismaticJointDef A_0)
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		_localAnchor1 = A_0.localAnchorA;
		_localAnchor2 = A_0.localAnchorB;
		_localXAxis1 = A_0.localAxis1;
		_localYAxis1 = MathUtils.Cross(1f, _localXAxis1);
		_refAngle = A_0.referenceAngle;
		_impulse = Vector3.Zero;
		_motorMass = 0f;
		_motorImpulse = 0f;
		_lowerTranslation = A_0.lowerTranslation;
		_upperTranslation = A_0.upperTranslation;
		_maxMotorForce = A_0.maxMotorForce;
		_motorSpeed = A_0.motorSpeed;
		_enableLimit = A_0.enableLimit;
		_enableMotor = A_0.enableMotor;
		_limitState = LimitState.Inactive;
		_axis = Vector2.Zero;
		_perp = Vector2.Zero;
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
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		Body body = f;
		Body body2 = g;
		k = body.e.localCenter;
		l = body2.e.localCenter;
		Vector2 val = MathUtils.Multiply(ref body.d.R, _localAnchor1 - k);
		Vector2 val2 = MathUtils.Multiply(ref body2.d.R, _localAnchor2 - l);
		Vector2 val3 = body2.e.c + val2 - body.e.c - val;
		m = body.r;
		n = body.t;
		o = body2.r;
		p = body2.t;
		_axis = MathUtils.Multiply(ref body.d.R, _localXAxis1);
		_a1 = MathUtils.Cross(val3 + val, _axis);
		_a2 = MathUtils.Cross(val2, _axis);
		_motorMass = m + o + n * _a1 * _a1 + p * _a2 * _a2;
		if (_motorMass > 1.1920929E-07f)
		{
			_motorMass = 1f / _motorMass;
		}
		_perp = MathUtils.Multiply(ref body.d.R, _localYAxis1);
		_s1 = MathUtils.Cross(val3 + val, _perp);
		_s2 = MathUtils.Cross(val2, _perp);
		float num = m;
		float num2 = o;
		float num3 = n;
		float num4 = p;
		float num5 = num + num2 + num3 * _s1 * _s1 + num4 * _s2 * _s2;
		float num6 = num3 * _s1 + num4 * _s2;
		float num7 = num3 * _s1 * _a1 + num4 * _s2 * _a2;
		float num8 = num3 + num4;
		float num9 = num3 * _a1 + num4 * _a2;
		float num10 = num + num2 + num3 * _a1 * _a1 + num4 * _a2 * _a2;
		_K.col1 = new Vector3(num5, num6, num7);
		_K.col2 = new Vector3(num6, num8, num9);
		_K.col3 = new Vector3(num7, num9, num10);
		if (_enableLimit)
		{
			float num11 = Vector2.Dot(_axis, val3);
			if (Math.Abs(_upperTranslation - _lowerTranslation) < 0.1f)
			{
				_limitState = LimitState.Equal;
			}
			else if (num11 <= _lowerTranslation)
			{
				if (_limitState != LimitState.AtLower)
				{
					_limitState = LimitState.AtLower;
					_impulse.Z = 0f;
				}
			}
			else if (num11 >= _upperTranslation)
			{
				if (_limitState != LimitState.AtUpper)
				{
					_limitState = LimitState.AtUpper;
					_impulse.Z = 0f;
				}
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
		if (!_enableMotor)
		{
			_motorImpulse = 0f;
		}
		if (step.warmStarting)
		{
			_impulse *= step.dtRatio;
			_motorImpulse *= step.dtRatio;
			Vector2 val4 = _impulse.X * _perp + (_motorImpulse + _impulse.Z) * _axis;
			float num12 = _impulse.X * _s1 + _impulse.Y + (_motorImpulse + _impulse.Z) * _a1;
			float num13 = _impulse.X * _s2 + _impulse.Y + (_motorImpulse + _impulse.Z) * _a2;
			body.f -= m * val4;
			body.g -= n * num12;
			body2.f += o * val4;
			body2.g += p * num13;
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
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		Body body = f;
		Body body2 = g;
		Vector2 val = body.f;
		float num = body.g;
		Vector2 val2 = body2.f;
		float num2 = body2.g;
		if (_enableMotor && _limitState != LimitState.Equal)
		{
			float num3 = Vector2.Dot(_axis, val2 - val) + _a2 * num2 - _a1 * num;
			float num4 = _motorMass * (_motorSpeed - num3);
			float motorImpulse = _motorImpulse;
			float num5 = step.dt * _maxMotorForce;
			_motorImpulse = MathUtils.Clamp(_motorImpulse + num4, 0f - num5, num5);
			num4 = _motorImpulse - motorImpulse;
			Vector2 val3 = num4 * _axis;
			float num6 = num4 * _a1;
			float num7 = num4 * _a2;
			val -= m * val3;
			num -= n * num6;
			val2 += o * val3;
			num2 += p * num7;
		}
		Vector2 val4 = default(Vector2);
		val4 = new Vector2(Vector2.Dot(_perp, val2 - val) + _s2 * num2 - _s1 * num, num2 - num);
		if (_enableLimit && _limitState != 0)
		{
			float num8 = Vector2.Dot(_axis, val2 - val) + _a2 * num2 - _a1 * num;
			Vector3 val5 = default(Vector3);
			val5 = new Vector3(val4.X, val4.Y, num8);
			Vector3 impulse = _impulse;
			Vector3 val6 = _K.Solve33(-val5);
			_impulse += val6;
			if (_limitState == LimitState.AtLower)
			{
				_impulse.Z = Math.Max(_impulse.Z, 0f);
			}
			else if (_limitState == LimitState.AtUpper)
			{
				_impulse.Z = Math.Min(_impulse.Z, 0f);
			}
			Vector2 val7 = -val4 - (_impulse.Z - impulse.Z) * new Vector2(_K.col3.X, _K.col3.Y);
			Vector2 val8 = _K.Solve22(val7) + new Vector2(impulse.X, impulse.Y);
			_impulse.X = val8.X;
			_impulse.Y = val8.Y;
			val6 = _impulse - impulse;
			Vector2 val9 = val6.X * _perp + val6.Z * _axis;
			float num9 = val6.X * _s1 + val6.Y + val6.Z * _a1;
			float num10 = val6.X * _s2 + val6.Y + val6.Z * _a2;
			val -= m * val9;
			num -= n * num9;
			val2 += o * val9;
			num2 += p * num10;
		}
		else
		{
			Vector2 val10 = _K.Solve22(-val4);
			ref Vector3 impulse2 = ref _impulse;
			impulse2.X += val10.X;
			ref Vector3 impulse3 = ref _impulse;
			impulse3.Y += val10.Y;
			Vector2 val11 = val10.X * _perp;
			float num11 = val10.X * _s1 + val10.Y;
			float num12 = val10.X * _s2 + val10.Y;
			val -= m * val11;
			num -= n * num11;
			val2 += o * val11;
			num2 += p * num12;
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
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		Body body = f;
		Body body2 = g;
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
		Vector2 val4 = MathUtils.Multiply(ref A, _localAnchor1 - k);
		Vector2 val5 = MathUtils.Multiply(ref A2, _localAnchor2 - l);
		Vector2 val6 = val2 + val5 - val - val4;
		if (_enableLimit)
		{
			_axis = MathUtils.Multiply(ref A, _localXAxis1);
			_a1 = MathUtils.Cross(val6 + val4, _axis);
			_a2 = MathUtils.Cross(val5, _axis);
			float num5 = Vector2.Dot(_axis, val6);
			if (Math.Abs(_upperTranslation - _lowerTranslation) < 0.1f)
			{
				num4 = MathUtils.Clamp(num5, -0.2f, 0.2f);
				val3 = Math.Abs(num5);
				flag = true;
			}
			else if (num5 <= _lowerTranslation)
			{
				num4 = MathUtils.Clamp(num5 - _lowerTranslation + 0.05f, -0.2f, 0f);
				val3 = _lowerTranslation - num5;
				flag = true;
			}
			else if (num5 >= _upperTranslation)
			{
				num4 = MathUtils.Clamp(num5 - _upperTranslation - 0.05f, 0f, 0.2f);
				val3 = num5 - _upperTranslation;
				flag = true;
			}
		}
		_perp = MathUtils.Multiply(ref A, _localYAxis1);
		_s1 = MathUtils.Cross(val6 + val4, _perp);
		_s2 = MathUtils.Cross(val5, _perp);
		Vector2 val7 = default(Vector2);
		val7 = new Vector2(Vector2.Dot(_perp, val6), num2 - num - _refAngle);
		val3 = Math.Max(val3, Math.Abs(val7.X));
		num3 = Math.Abs(val7.Y);
		Vector3 val9 = default(Vector3);
		if (flag)
		{
			float num6 = m;
			float num7 = o;
			float num8 = n;
			float num9 = p;
			float num10 = num6 + num7 + num8 * _s1 * _s1 + num9 * _s2 * _s2;
			float num11 = num8 * _s1 + num9 * _s2;
			float num12 = num8 * _s1 * _a1 + num9 * _s2 * _a2;
			float num13 = num8 + num9;
			float num14 = num8 * _a1 + num9 * _a2;
			float num15 = num6 + num7 + num8 * _a1 * _a1 + num9 * _a2 * _a2;
			_K.col1 = new Vector3(num10, num11, num12);
			_K.col2 = new Vector3(num11, num13, num14);
			_K.col3 = new Vector3(num12, num14, num15);
			Vector3 val8 = default(Vector3);
			val8 = new Vector3(0f - val7.X, 0f - val7.Y, 0f - num4);
			val9 = _K.Solve33(val8);
		}
		else
		{
			float num16 = m;
			float num17 = o;
			float num18 = n;
			float num19 = p;
			float num20 = num16 + num17 + num18 * _s1 * _s1 + num19 * _s2 * _s2;
			float num21 = num18 * _s1 + num19 * _s2;
			float num22 = num18 + num19;
			_K.col1 = new Vector3(num20, num21, 0f);
			_K.col2 = new Vector3(num21, num22, 0f);
			Vector2 val10 = _K.Solve22(-val7);
			val9.X = val10.X;
			val9.Y = val10.Y;
			val9.Z = 0f;
		}
		Vector2 val11 = val9.X * _perp + val9.Z * _axis;
		float num23 = val9.X * _s1 + val9.Y + val9.Z * _a1;
		float num24 = val9.X * _s2 + val9.Y + val9.Z * _a2;
		val -= m * val11;
		num -= n * num23;
		val2 += o * val11;
		num2 += p * num24;
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
