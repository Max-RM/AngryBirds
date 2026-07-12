using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class EdgeShape : Shape
{
	public Vector2 _vertex1;

	public Vector2 _vertex2;

	public Vector2 _vertex0;

	public Vector2 _vertex3;

	public bool _hasVertex0;

	public bool _hasVertex3;

	public EdgeShape()
	{
		base.ShapeType = ShapeType.Edge;
		_radius = 0.1f;
		_hasVertex0 = false;
		_hasVertex3 = false;
	}

	public void Set(Vector2 v1, Vector2 v2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		_vertex1 = v1;
		_vertex2 = v2;
		_hasVertex0 = false;
		_hasVertex3 = false;
	}

	public override Shape Clone()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		EdgeShape edgeShape = new EdgeShape();
		edgeShape._hasVertex0 = _hasVertex0;
		edgeShape._hasVertex3 = _hasVertex3;
		edgeShape._radius = _radius;
		edgeShape._vertex0 = _vertex0;
		edgeShape._vertex1 = _vertex1;
		edgeShape._vertex2 = _vertex2;
		edgeShape._vertex3 = _vertex3;
		return edgeShape;
	}

	public override int GetChildCount()
	{
		return 1;
	}

	public override bool TestPoint(ref Transform transform, Vector2 p)
	{
		return false;
	}

	public override bool RayCast(out RayCastOutput output, ref RayCastInput input, ref Transform transform, int childIndex)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		output = default(RayCastOutput);
		Vector2 val = MathUtils.MultiplyT(ref transform.R, input.p1 - transform.Position);
		Vector2 val2 = MathUtils.MultiplyT(ref transform.R, input.p2 - transform.Position);
		Vector2 val3 = val2 - val;
		Vector2 vertex = _vertex1;
		Vector2 vertex2 = _vertex2;
		Vector2 val4 = vertex2 - vertex;
		Vector2 val5 = default(Vector2);
		val5 = new Vector2(val4.Y, 0f - val4.X);
		val5.Normalize();
		float num = Vector2.Dot(val5, vertex - val);
		float num2 = Vector2.Dot(val5, val3);
		if (num2 == 0f)
		{
			return false;
		}
		float num3 = num / num2;
		if (num3 < 0f || 1f < num3)
		{
			return false;
		}
		Vector2 val6 = val + num3 * val3;
		Vector2 val7 = vertex2 - vertex;
		float num4 = Vector2.Dot(val7, val7);
		if (num4 == 0f)
		{
			return false;
		}
		float num5 = Vector2.Dot(val6 - vertex, val7) / num4;
		if (num5 < 0f || 1f < num5)
		{
			return false;
		}
		output.fraction = num3;
		if (num > 0f)
		{
			output.normal = -val5;
		}
		else
		{
			output.normal = val5;
		}
		return true;
	}

	public override void ComputeAABB(out AABB aabb, ref Transform transform, int childIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		aabb = default(AABB);
		Vector2 val = MathUtils.Multiply(ref transform, _vertex1);
		Vector2 val2 = MathUtils.Multiply(ref transform, _vertex2);
		Vector2 val3 = Vector2.Min(val, val2);
		Vector2 val4 = Vector2.Max(val, val2);
		Vector2 val5 = default(Vector2);
		val5 = new Vector2(_radius, _radius);
		aabb.lowerBound = val3 - val5;
		aabb.upperBound = val4 + val5;
	}

	public override void ComputeMass(out MassData massData, float density)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		massData = default(MassData);
		massData.mass = 0f;
		massData.center = 0.5f * (_vertex1 + _vertex2);
		massData.I = 0f;
	}
}
