using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class PolygonShape : Shape
{
	public Vector2 _centroid;

	public FixedArray8<Vector2> _vertices;

	public FixedArray8<Vector2> _normals;

	public int _vertexCount;

	public PolygonShape()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		base.ShapeType = ShapeType.Polygon;
		_radius = 0.1f;
		_vertexCount = 0;
		_centroid = Vector2.Zero;
	}

	public override Shape Clone()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		PolygonShape polygonShape = new PolygonShape();
		polygonShape.ShapeType = base.ShapeType;
		polygonShape._radius = _radius;
		polygonShape._vertexCount = _vertexCount;
		polygonShape._centroid = _centroid;
		polygonShape._vertices = _vertices;
		polygonShape._normals = _normals;
		return polygonShape;
	}

	public override int GetChildCount()
	{
		return 1;
	}

	public void Set(Vector2[] vertices, int count)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		_vertexCount = count;
		for (int i = 0; i < _vertexCount; i++)
		{
			_vertices[i] = vertices[i];
		}
		for (int j = 0; j < _vertexCount; j++)
		{
			int index = j;
			int index2 = ((j + 1 < _vertexCount) ? (j + 1) : 0);
			Vector2 val = _vertices[index2] - _vertices[index];
			Vector2 value = MathUtils.Cross(val, 1f);
			value.Normalize();
			_normals[j] = value;
		}
		_centroid = a(ref _vertices, _vertexCount);
	}

	private static Vector2 a(ref FixedArray8<Vector2> A_0, int A_1)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
		val = new Vector2(0f, 0f);
		float num = 0f;
		if (A_1 == 2)
		{
			val = 0.5f * (A_0[0] + A_0[1]);
			return val;
		}
		Vector2 val2 = default(Vector2);
		val2 = new Vector2(0f, 0f);
		for (int i = 0; i < A_1; i++)
		{
			Vector2 val3 = val2;
			Vector2 val4 = A_0[i];
			Vector2 val5 = ((i + 1 < A_1) ? A_0[i + 1] : A_0[0]);
			Vector2 val6 = val4 - val3;
			Vector2 b = val5 - val3;
			float num2 = MathUtils.Cross(val6, b);
			float num3 = 0.5f * num2;
			num += num3;
			val += num3 * (1f / 3f) * (val3 + val4 + val5);
		}
		val *= 1f / num;
		return val;
	}

	public void SetAsBox(float hx, float hy)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		_vertexCount = 4;
		_vertices[0] = new Vector2(0f - hx, 0f - hy);
		_vertices[1] = new Vector2(hx, 0f - hy);
		_vertices[2] = new Vector2(hx, hy);
		_vertices[3] = new Vector2(0f - hx, hy);
		_normals[0] = new Vector2(0f, -1f);
		_normals[1] = new Vector2(1f, 0f);
		_normals[2] = new Vector2(0f, 1f);
		_normals[3] = new Vector2(-1f, 0f);
		_centroid = Vector2.Zero;
	}

	public void SetAsBox(float hx, float hy, Vector2 center, float angle)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		_vertexCount = 4;
		_vertices[0] = new Vector2(0f - hx, 0f - hy);
		_vertices[1] = new Vector2(hx, 0f - hy);
		_vertices[2] = new Vector2(hx, hy);
		_vertices[3] = new Vector2(0f - hx, hy);
		_normals[0] = new Vector2(0f, -1f);
		_normals[1] = new Vector2(1f, 0f);
		_normals[2] = new Vector2(0f, 1f);
		_normals[3] = new Vector2(-1f, 0f);
		_centroid = center;
		Transform T = default(Transform);
		T.Position = center;
		T.R.Set(angle);
		for (int i = 0; i < _vertexCount; i++)
		{
			_vertices[i] = MathUtils.Multiply(ref T, _vertices[i]);
			_normals[i] = MathUtils.Multiply(ref T.R, _normals[i]);
		}
	}

	public void SetAsEdge(Vector2 v1, Vector2 v2)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		_vertexCount = 2;
		_vertices[0] = v1;
		_vertices[1] = v2;
		_centroid = 0.5f * (v1 + v2);
		Vector2 value = MathUtils.Cross(v2 - v1, 1f);
		value.Normalize();
		_normals[0] = value;
		_normals[1] = -_normals[0];
	}

	public override bool TestPoint(ref Transform xf, Vector2 p)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = MathUtils.MultiplyT(ref xf.R, p - xf.Position);
		for (int i = 0; i < _vertexCount; i++)
		{
			float num = Vector2.Dot(_normals[i], val - _vertices[i]);
			if (num > 0f)
			{
				return false;
			}
		}
		return true;
	}

	public override bool RayCast(out RayCastOutput output, ref RayCastInput input, ref Transform xf, int childIndex)
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
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		output = default(RayCastOutput);
		Vector2 val = MathUtils.MultiplyT(ref xf.R, input.p1 - xf.Position);
		Vector2 val2 = MathUtils.MultiplyT(ref xf.R, input.p2 - xf.Position);
		Vector2 val3 = val2 - val;
		if (_vertexCount == 2)
		{
			Vector2 val4 = _vertices[0];
			Vector2 val5 = _vertices[1];
			Vector2 val6 = _normals[0];
			float num = Vector2.Dot(val6, val4 - val);
			float num2 = Vector2.Dot(val6, val3);
			if (num2 == 0f)
			{
				return false;
			}
			float num3 = num / num2;
			if (num3 < 0f || 1f < num3)
			{
				return false;
			}
			Vector2 val7 = val + num3 * val3;
			Vector2 val8 = val5 - val4;
			float num4 = Vector2.Dot(val8, val8);
			if (num4 == 0f)
			{
				return false;
			}
			float num5 = Vector2.Dot(val7 - val4, val8) / num4;
			if (num5 < 0f || 1f < num5)
			{
				return false;
			}
			output.fraction = num3;
			if (num > 0f)
			{
				output.normal = -val6;
			}
			else
			{
				output.normal = val6;
			}
			return true;
		}
		float num6 = 0f;
		float num7 = input.maxFraction;
		int num8 = -1;
		for (int i = 0; i < _vertexCount; i++)
		{
			float num9 = Vector2.Dot(_normals[i], _vertices[i] - val);
			float num10 = Vector2.Dot(_normals[i], val3);
			if (num10 == 0f)
			{
				if (num9 < 0f)
				{
					return false;
				}
			}
			else if (num10 < 0f && num9 < num6 * num10)
			{
				num6 = num9 / num10;
				num8 = i;
			}
			else if (num10 > 0f && num9 < num7 * num10)
			{
				num7 = num9 / num10;
			}
			if (num7 < num6)
			{
				return false;
			}
		}
		if (num8 >= 0)
		{
			output.fraction = num6;
			output.normal = MathUtils.Multiply(ref xf.R, _normals[num8]);
			return true;
		}
		return false;
	}

	public override void ComputeAABB(out AABB aabb, ref Transform xf, int childIndex)
	{
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		float x = xf.Position.X;
		float y = xf.Position.Y;
		float x2 = xf.R.col1.X;
		float y2 = xf.R.col1.Y;
		float x3 = xf.R.col2.X;
		float y3 = xf.R.col2.Y;
		float num = x + x2 * _vertices._value0.X + x3 * _vertices._value0.Y;
		float num2 = y + y2 * _vertices._value0.X + y3 * _vertices._value0.Y;
		float num3 = num;
		float num4 = num2;
		if (_vertexCount > 1)
		{
			float num5 = x + x2 * _vertices._value1.X + x3 * _vertices._value1.Y;
			float num6 = y + y2 * _vertices._value1.X + y3 * _vertices._value1.Y;
			if (num > num5)
			{
				num = num5;
			}
			if (num2 > num6)
			{
				num2 = num6;
			}
			if (num3 < num5)
			{
				num3 = num5;
			}
			if (num4 < num6)
			{
				num4 = num6;
			}
			if (_vertexCount > 2)
			{
				num5 = x + x2 * _vertices._value2.X + x3 * _vertices._value2.Y;
				num6 = y + y2 * _vertices._value2.X + y3 * _vertices._value2.Y;
				if (num > num5)
				{
					num = num5;
				}
				if (num2 > num6)
				{
					num2 = num6;
				}
				if (num3 < num5)
				{
					num3 = num5;
				}
				if (num4 < num6)
				{
					num4 = num6;
				}
				if (_vertexCount > 3)
				{
					num5 = x + x2 * _vertices._value3.X + x3 * _vertices._value3.Y;
					num6 = y + y2 * _vertices._value3.X + y3 * _vertices._value3.Y;
					if (num > num5)
					{
						num = num5;
					}
					if (num2 > num6)
					{
						num2 = num6;
					}
					if (num3 < num5)
					{
						num3 = num5;
					}
					if (num4 < num6)
					{
						num4 = num6;
					}
					if (_vertexCount > 4)
					{
						num5 = x + x2 * _vertices._value4.X + x3 * _vertices._value4.Y;
						num6 = y + y2 * _vertices._value4.X + y3 * _vertices._value4.Y;
						if (num > num5)
						{
							num = num5;
						}
						if (num2 > num6)
						{
							num2 = num6;
						}
						if (num3 < num5)
						{
							num3 = num5;
						}
						if (num4 < num6)
						{
							num4 = num6;
						}
						if (_vertexCount > 5)
						{
							num5 = x + x2 * _vertices._value5.X + x3 * _vertices._value5.Y;
							num6 = y + y2 * _vertices._value5.X + y3 * _vertices._value5.Y;
							if (num > num5)
							{
								num = num5;
							}
							if (num2 > num6)
							{
								num2 = num6;
							}
							if (num3 < num5)
							{
								num3 = num5;
							}
							if (num4 < num6)
							{
								num4 = num6;
							}
							if (_vertexCount > 6)
							{
								num5 = x + x2 * _vertices._value6.X + x3 * _vertices._value6.Y;
								num6 = y + y2 * _vertices._value6.X + y3 * _vertices._value6.Y;
								if (num > num5)
								{
									num = num5;
								}
								if (num2 > num6)
								{
									num2 = num6;
								}
								if (num3 < num5)
								{
									num3 = num5;
								}
								if (num4 < num6)
								{
									num4 = num6;
								}
								if (_vertexCount > 7)
								{
									num5 = x + x2 * _vertices._value7.X + x3 * _vertices._value7.Y;
									num6 = y + y2 * _vertices._value7.X + y3 * _vertices._value7.Y;
									if (num > num5)
									{
										num = num5;
									}
									if (num2 > num6)
									{
										num2 = num6;
									}
									if (num3 < num5)
									{
										num3 = num5;
									}
									if (num4 < num6)
									{
										num4 = num6;
									}
								}
							}
						}
					}
				}
			}
		}
		aabb.lowerBound = new Vector2
		{
			X = num - _radius,
			Y = num2 - _radius
		};
		aabb.upperBound = new Vector2
		{
			X = num3 + _radius,
			Y = num4 + _radius
		};
	}

	public override void ComputeMass(out MassData massData, float density)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		if (_vertexCount == 2)
		{
			massData.center = 0.5f * (_vertices[0] + _vertices[1]);
			massData.mass = 0f;
			massData.I = 0f;
			return;
		}
		Vector2 val = default(Vector2);
		val = new Vector2(0f, 0f);
		float num = 0f;
		float num2 = 0f;
		Vector2 val2 = default(Vector2);
		val2 = new Vector2(0f, 0f);
		for (int i = 0; i < _vertexCount; i++)
		{
			Vector2 val3 = val2;
			Vector2 val4 = _vertices[i];
			Vector2 val5 = ((i + 1 < _vertexCount) ? _vertices[i + 1] : _vertices[0]);
			Vector2 val6 = val4 - val3;
			Vector2 b = val5 - val3;
			float num3 = MathUtils.Cross(val6, b);
			float num4 = 0.5f * num3;
			num += num4;
			val += num4 * (1f / 3f) * (val3 + val4 + val5);
			float x = val3.X;
			float y = val3.Y;
			float x2 = val6.X;
			float y2 = val6.Y;
			float x3 = b.X;
			float y3 = b.Y;
			float num5 = 1f / 3f * (0.25f * (x2 * x2 + x3 * x2 + x3 * x3) + (x * x2 + x * x3)) + 0.5f * x * x;
			float num6 = 1f / 3f * (0.25f * (y2 * y2 + y3 * y2 + y3 * y3) + (y * y2 + y * y3)) + 0.5f * y * y;
			num2 += num3 * (num5 + num6);
		}
		massData.mass = density * num;
		val = (massData.center = val * (1f / num));
		massData.I = density * num2;
	}

	public int GetVertexCount()
	{
		return _vertexCount;
	}

	public Vector2 GetVertex(int index)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return _vertices[index];
	}
}
