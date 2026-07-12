using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class CircleShape : Shape
{
	public Vector2 _p;

	public CircleShape()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		base.ShapeType = ShapeType.Circle;
		_radius = 0f;
		_p = Vector2.Zero;
	}

	public override Shape Clone()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		CircleShape circleShape = new CircleShape();
		circleShape.ShapeType = base.ShapeType;
		circleShape._radius = _radius;
		circleShape._p = _p;
		return circleShape;
	}

	public override int GetChildCount()
	{
		return 1;
	}

	public override bool TestPoint(ref Transform transform, Vector2 p)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = transform.Position + MathUtils.Multiply(ref transform.R, _p);
		Vector2 val2 = p - val;
		return Vector2.Dot(val2, val2) <= _radius * _radius;
	}

	public override bool RayCast(out RayCastOutput output, ref RayCastInput input, ref Transform transform, int childIndex)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		output = default(RayCastOutput);
		Vector2 val = transform.Position + MathUtils.Multiply(ref transform.R, _p);
		Vector2 val2 = input.p1 - val;
		float num = Vector2.Dot(val2, val2) - _radius * _radius;
		Vector2 val3 = input.p2 - input.p1;
		float num2 = Vector2.Dot(val2, val3);
		float num3 = Vector2.Dot(val3, val3);
		float num4 = num2 * num2 - num3 * num;
		if (num4 < 0f || num3 < 1.1920929E-07f)
		{
			return false;
		}
		float num5 = 0f - (num2 + (float)Math.Sqrt(num4));
		if (0f <= num5 && num5 <= input.maxFraction * num3)
		{
			Vector2 normal = val2 + (output.fraction = num5 / num3) * val3;
			normal.Normalize();
			output.normal = normal;
			return true;
		}
		return false;
	}

	public override void ComputeAABB(out AABB aabb, ref Transform transform, int childIndex)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = transform.Position + MathUtils.Multiply(ref transform.R, _p);
		aabb.lowerBound = new Vector2(val.X - _radius, val.Y - _radius);
		aabb.upperBound = new Vector2(val.X + _radius, val.Y + _radius);
	}

	public override void ComputeMass(out MassData massData, float density)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		massData.mass = density * (float)Math.PI * _radius * _radius;
		massData.center = _p;
		massData.I = massData.mass * (0.5f * _radius * _radius + Vector2.Dot(_p, _p));
	}

	public int GetVertexCount()
	{
		return 1;
	}

	public Vector2 GetVertex(int index)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _p;
	}
}
