using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public struct DistanceProxy
{
	internal FixedArray8<Vector2> a;

	internal FixedArray2<Vector2> b;

	internal int c;

	internal float d;

	public void Set(Shape shape, int index)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		switch (shape.ShapeType)
		{
		case ShapeType.Circle:
		{
			CircleShape circleShape = (CircleShape)shape;
			a._value0 = circleShape._p;
			c = 1;
			d = circleShape._radius;
			break;
		}
		case ShapeType.Polygon:
		{
			PolygonShape polygonShape = (PolygonShape)shape;
			a = polygonShape._vertices;
			c = polygonShape._vertexCount;
			d = polygonShape._radius;
			break;
		}
		case ShapeType.Loop:
		{
			LoopShape loopShape = (LoopShape)shape;
			b._value0 = loopShape._vertices[index];
			if (index + 1 < loopShape._count)
			{
				b._value1 = loopShape._vertices[index + 1];
			}
			else
			{
				b._value1 = loopShape._vertices[0];
			}
			a._value0 = b._value0;
			a._value1 = b._value1;
			c = 2;
			d = loopShape._radius;
			break;
		}
		case ShapeType.Edge:
		{
			EdgeShape edgeShape = (EdgeShape)shape;
			a._value0 = edgeShape._vertex1;
			a._value1 = edgeShape._vertex2;
			c = 2;
			d = edgeShape._radius;
			break;
		}
		}
	}

	public static int GetVertWithMaxDot(ref FixedArray8<Vector2> _vertices, int _count, Vector2 d)
	{
		float num = _vertices._value0.X * d.X + _vertices._value0.Y * d.Y;
		int result = 0;
		if (_count == 1)
		{
			return result;
		}
		float num2 = _vertices._value1.X * d.X + _vertices._value1.Y * d.Y;
		if (num < num2)
		{
			num = num2;
			result = 1;
		}
		if (_count == 2)
		{
			return result;
		}
		float num3 = _vertices._value2.X * d.X + _vertices._value2.Y * d.Y;
		if (num < num3)
		{
			num = num3;
			result = 2;
		}
		if (_count == 3)
		{
			return result;
		}
		float num4 = _vertices._value3.X * d.X + _vertices._value3.Y * d.Y;
		if (num < num4)
		{
			num = num4;
			result = 3;
		}
		if (_count == 4)
		{
			return result;
		}
		float num5 = _vertices._value4.X * d.X + _vertices._value4.Y * d.Y;
		if (num < num5)
		{
			num = num5;
			result = 4;
		}
		if (_count == 5)
		{
			return result;
		}
		float num6 = _vertices._value5.X * d.X + _vertices._value5.Y * d.Y;
		if (num < num6)
		{
			num = num6;
			result = 5;
		}
		if (_count == 6)
		{
			return result;
		}
		float num7 = _vertices._value6.X * d.X + _vertices._value6.Y * d.Y;
		if (num < num7)
		{
			num = num7;
			result = 6;
		}
		if (_count == 7)
		{
			return result;
		}
		float num8 = _vertices._value7.X * d.X + _vertices._value7.Y * d.Y;
		if (num < num8)
		{
			num = num8;
			result = 7;
		}
		return result;
	}

	public static int GetVertWithMinDot(ref FixedArray8<Vector2> _vertices, int _count, Vector2 d)
	{
		float num = _vertices._value0.X * d.X + _vertices._value0.Y * d.Y;
		int result = 0;
		if (_count == 1)
		{
			return result;
		}
		float num2 = _vertices._value1.X * d.X + _vertices._value1.Y * d.Y;
		if (num > num2)
		{
			num = num2;
			result = 1;
		}
		if (_count == 2)
		{
			return result;
		}
		float num3 = _vertices._value2.X * d.X + _vertices._value2.Y * d.Y;
		if (num > num3)
		{
			num = num3;
			result = 2;
		}
		if (_count == 3)
		{
			return result;
		}
		float num4 = _vertices._value3.X * d.X + _vertices._value3.Y * d.Y;
		if (num > num4)
		{
			num = num4;
			result = 3;
		}
		if (_count == 4)
		{
			return result;
		}
		float num5 = _vertices._value4.X * d.X + _vertices._value4.Y * d.Y;
		if (num > num5)
		{
			num = num5;
			result = 4;
		}
		if (_count == 5)
		{
			return result;
		}
		float num6 = _vertices._value5.X * d.X + _vertices._value5.Y * d.Y;
		if (num > num6)
		{
			num = num6;
			result = 5;
		}
		if (_count == 6)
		{
			return result;
		}
		float num7 = _vertices._value6.X * d.X + _vertices._value6.Y * d.Y;
		if (num > num7)
		{
			num = num7;
			result = 6;
		}
		if (_count == 7)
		{
			return result;
		}
		float num8 = _vertices._value7.X * d.X + _vertices._value7.Y * d.Y;
		if (num > num8)
		{
			num = num8;
			result = 7;
		}
		return result;
	}

	public int GetSupport(Vector2 d)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return GetVertWithMaxDot(ref a, c, d);
	}

	public int GetSupportSpecial(Vector2 d, out Vector2 best)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		best = a._value0;
		int result = 0;
		float num = best.X * d.X + best.Y * d.Y;
		if (c == 1)
		{
			return result;
		}
		float num2 = a._value1.X * d.X + a._value1.Y * d.Y;
		if (num < num2)
		{
			result = 1;
			num = num2;
			best = a._value1;
		}
		if (c == 2)
		{
			return result;
		}
		float num3 = a._value2.X * d.X + a._value2.Y * d.Y;
		if (num < num3)
		{
			result = 2;
			num = num3;
			best = a._value2;
		}
		if (c == 3)
		{
			return result;
		}
		float num4 = a._value3.X * d.X + a._value3.Y * d.Y;
		if (num < num4)
		{
			result = 3;
			num = num4;
			best = a._value3;
		}
		if (c == 4)
		{
			return result;
		}
		float num5 = a._value4.X * d.X + a._value4.Y * d.Y;
		if (num < num5)
		{
			result = 4;
			num = num5;
			best = a._value4;
		}
		if (c == 5)
		{
			return result;
		}
		float num6 = a._value5.X * d.X + a._value5.Y * d.Y;
		if (num < num6)
		{
			result = 5;
			num = num6;
			best = a._value5;
		}
		if (c == 6)
		{
			return result;
		}
		float num7 = a._value6.X * d.X + a._value6.Y * d.Y;
		if (num < num7)
		{
			result = 6;
			num = num7;
			best = a._value6;
		}
		if (c == 7)
		{
			return result;
		}
		float num8 = a._value7.X * d.X + a._value7.Y * d.Y;
		if (num < num8)
		{
			result = 7;
			num = num8;
			best = a._value7;
		}
		return result;
	}

	public Vector2 GetSupportVertex(Vector2 d)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return a[GetVertWithMaxDot(ref a, c, d)];
	}

	public int GetVertexCount()
	{
		return c;
	}

	public Vector2 GetVertex(int index)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return a[index];
	}
}
