using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class LoopShape : Shape
{
	public Vector2[] _vertices;

	public int _count;

	public static EdgeShape s_edgeShape = new EdgeShape();

	public LoopShape()
	{
		base.ShapeType = ShapeType.Loop;
		_radius = 0.1f;
		_vertices = null;
		_count = 0;
	}

	public override Shape Clone()
	{
		LoopShape loopShape = new LoopShape();
		loopShape._count = _count;
		loopShape._radius = _radius;
		loopShape._vertices = (Vector2[])_vertices.Clone();
		return loopShape;
	}

	public override int GetChildCount()
	{
		return _count;
	}

	public void GetChildEdge(ref EdgeShape edge, int index)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		edge.ShapeType = ShapeType.Edge;
		edge._radius = _radius;
		edge._hasVertex0 = true;
		edge._hasVertex3 = true;
		int num = ((index - 1 >= 0) ? (index - 1) : (_count - 1));
		int num2 = ((index + 1 < _count) ? (index + 1) : 0);
		int num3;
		for (num3 = index + 2; num3 >= _count; num3 -= _count)
		{
		}
		edge._vertex0 = _vertices[num];
		edge._vertex1 = _vertices[index];
		edge._vertex2 = _vertices[num2];
		edge._vertex3 = _vertices[num3];
	}

	public override bool TestPoint(ref Transform transform, Vector2 p)
	{
		return false;
	}

	public override bool RayCast(out RayCastOutput output, ref RayCastInput input, ref Transform transform, int childIndex)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		int num = childIndex + 1;
		if (num == _count)
		{
			num = 0;
		}
		s_edgeShape._vertex1 = _vertices[childIndex];
		s_edgeShape._vertex2 = _vertices[num];
		return s_edgeShape.RayCast(out output, ref input, ref transform, 0);
	}

	public override void ComputeAABB(out AABB aabb, ref Transform transform, int childIndex)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		aabb = default(AABB);
		int num = childIndex + 1;
		if (num == _count)
		{
			num = 0;
		}
		Vector2 val = MathUtils.Multiply(ref transform, _vertices[childIndex]);
		Vector2 val2 = MathUtils.Multiply(ref transform, _vertices[num]);
		aabb.lowerBound = Vector2.Min(val, val2);
		aabb.upperBound = Vector2.Max(val, val2);
	}

	public override void ComputeMass(out MassData massData, float density)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		massData = default(MassData);
		massData.mass = 0f;
		massData.center = Vector2.Zero;
		massData.I = 0f;
	}
}
