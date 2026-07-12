using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public static class Collision
{
	public enum EPAxisType
	{
		Unknown,
		EdgeA,
		EdgeB
	}

	public struct EPAxis
	{
		public EPAxisType type;

		public int index;

		public float separation;
	}

	private static PolygonShape m_a = new PolygonShape();

	private static PolygonShape m_b = new PolygonShape();

	public static void GetPointStates(out FixedArray2<PointState> state1, out FixedArray2<PointState> state2, ref Manifold manifold1, ref Manifold manifold2)
	{
		state1 = default(FixedArray2<PointState>);
		state2 = default(FixedArray2<PointState>);
		for (int i = 0; i < manifold1._pointCount; i++)
		{
			ContactID id = manifold1._points[i].Id;
			state1[i] = PointState.Remove;
			for (int j = 0; j < manifold2._pointCount; j++)
			{
				if (manifold2._points[j].Id.Key == id.Key)
				{
					state1[i] = PointState.Persist;
					break;
				}
			}
		}
		for (int k = 0; k < manifold2._pointCount; k++)
		{
			ContactID id2 = manifold2._points[k].Id;
			state2[k] = PointState.Add;
			for (int l = 0; l < manifold1._pointCount; l++)
			{
				if (manifold1._points[l].Id.Key == id2.Key)
				{
					state2[k] = PointState.Persist;
					break;
				}
			}
		}
	}

	public static void CollideCircles(ref Manifold manifold, CircleShape circleA, ref Transform xfA, CircleShape circleB, ref Transform xfB)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		manifold._pointCount = 0;
		Vector2 val = MathUtils.Multiply(ref xfA, circleA._p);
		Vector2 val2 = MathUtils.Multiply(ref xfB, circleB._p);
		Vector2 val3 = val2 - val;
		float num = Vector2.Dot(val3, val3);
		float radius = circleA._radius;
		float radius2 = circleB._radius;
		float num2 = radius + radius2;
		if (!(num > num2 * num2))
		{
			manifold._type = ManifoldType.Circles;
			manifold._localPoint = circleA._p;
			manifold._localNormal = Vector2.Zero;
			manifold._pointCount = 1;
			ManifoldPoint value = manifold._points[0];
			value.LocalPoint = circleB._p;
			value.Id.Key = 0u;
			manifold._points[0] = value;
		}
	}

	public static void CollidePolygonAndCircle(ref Manifold manifold, PolygonShape polygonA, ref Transform xfA, CircleShape circleB, ref Transform xfB)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		manifold._pointCount = 0;
		Vector2 v = MathUtils.Multiply(ref xfB, circleB._p);
		Vector2 val = MathUtils.MultiplyT(ref xfA, v);
		int num = 0;
		float num2 = float.MinValue;
		float num3 = polygonA._radius + circleB._radius;
		int vertexCount = polygonA._vertexCount;
		float x = val.X;
		float y = val.Y;
		if (vertexCount > 0)
		{
			float num4 = x - polygonA._vertices._value0.X;
			float num5 = y - polygonA._vertices._value0.Y;
			float num6 = polygonA._normals._value0.X * num4 + polygonA._normals._value0.Y * num5;
			if (num6 > num3)
			{
				return;
			}
			if (num6 > num2)
			{
				num2 = num6;
				num = 0;
			}
			if (vertexCount > 1)
			{
				num4 = x - polygonA._vertices._value1.X;
				num5 = y - polygonA._vertices._value1.Y;
				num6 = polygonA._normals._value1.X * num4 + polygonA._normals._value1.Y * num5;
				if (num6 > num3)
				{
					return;
				}
				if (num6 > num2)
				{
					num2 = num6;
					num = 1;
				}
				if (vertexCount > 2)
				{
					num4 = x - polygonA._vertices._value2.X;
					num5 = y - polygonA._vertices._value2.Y;
					num6 = polygonA._normals._value2.X * num4 + polygonA._normals._value2.Y * num5;
					if (num6 > num3)
					{
						return;
					}
					if (num6 > num2)
					{
						num2 = num6;
						num = 2;
					}
					if (vertexCount > 3)
					{
						num4 = x - polygonA._vertices._value3.X;
						num5 = y - polygonA._vertices._value3.Y;
						num6 = polygonA._normals._value3.X * num4 + polygonA._normals._value3.Y * num5;
						if (num6 > num3)
						{
							return;
						}
						if (num6 > num2)
						{
							num2 = num6;
							num = 3;
						}
						if (vertexCount > 4)
						{
							num4 = x - polygonA._vertices._value4.X;
							num5 = y - polygonA._vertices._value4.Y;
							num6 = polygonA._normals._value4.X * num4 + polygonA._normals._value4.Y * num5;
							if (num6 > num3)
							{
								return;
							}
							if (num6 > num2)
							{
								num2 = num6;
								num = 4;
							}
							if (vertexCount > 5)
							{
								num4 = x - polygonA._vertices._value5.X;
								num5 = y - polygonA._vertices._value5.Y;
								num6 = polygonA._normals._value5.X * num4 + polygonA._normals._value5.Y * num5;
								if (num6 > num3)
								{
									return;
								}
								if (num6 > num2)
								{
									num2 = num6;
									num = 5;
								}
								if (vertexCount > 6)
								{
									num4 = x - polygonA._vertices._value6.X;
									num5 = y - polygonA._vertices._value6.Y;
									num6 = polygonA._normals._value6.X * num4 + polygonA._normals._value6.Y * num5;
									if (num6 > num3)
									{
										return;
									}
									if (num6 > num2)
									{
										num2 = num6;
										num = 6;
									}
									if (vertexCount > 7)
									{
										num4 = x - polygonA._vertices._value7.X;
										num5 = y - polygonA._vertices._value7.Y;
										num6 = polygonA._normals._value7.X * num4 + polygonA._normals._value7.Y * num5;
										if (num6 > num3)
										{
											return;
										}
										if (num6 > num2)
										{
											num2 = num6;
											num = 7;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		int num7 = num;
		int index = ((num7 + 1 < vertexCount) ? (num7 + 1) : 0);
		Vector2 val2 = polygonA._vertices[num7];
		Vector2 val3 = polygonA._vertices[index];
		if (num2 < 1.1920929E-07f)
		{
			manifold._pointCount = 1;
			manifold._type = ManifoldType.FaceA;
			manifold._localNormal = polygonA._normals[num];
			manifold._localPoint = 0.5f * (val2 + val3);
			ManifoldPoint value = manifold._points._value0;
			value.LocalPoint = circleB._p;
			value.Id.Key = 0u;
			manifold._points._value0 = value;
			return;
		}
		float num8 = Vector2.Dot(val - val2, val3 - val2);
		float num9 = Vector2.Dot(val - val3, val2 - val3);
		if (num8 <= 0f)
		{
			if (!(Vector2.DistanceSquared(val, val2) > num3 * num3))
			{
				manifold._pointCount = 1;
				manifold._type = ManifoldType.FaceA;
				manifold._localNormal = val - val2;
				manifold._localNormal.Normalize();
				manifold._localPoint = val2;
				ManifoldPoint value2 = manifold._points._value0;
				value2.LocalPoint = circleB._p;
				value2.Id.Key = 0u;
				manifold._points._value0 = value2;
			}
			return;
		}
		if (num9 <= 0f)
		{
			if (!(Vector2.DistanceSquared(val, val3) > num3 * num3))
			{
				manifold._pointCount = 1;
				manifold._type = ManifoldType.FaceA;
				manifold._localNormal = val - val3;
				manifold._localNormal.Normalize();
				manifold._localPoint = val3;
				ManifoldPoint value3 = manifold._points._value0;
				value3.LocalPoint = circleB._p;
				value3.Id.Key = 0u;
				manifold._points._value0 = value3;
			}
			return;
		}
		Vector2 val4 = 0.5f * (val2 + val3);
		float num10 = Vector2.Dot(val - val4, polygonA._normals[num7]);
		if (!(num10 > num3))
		{
			manifold._pointCount = 1;
			manifold._type = ManifoldType.FaceA;
			manifold._localNormal = polygonA._normals[num7];
			manifold._localPoint = val4;
			ManifoldPoint value4 = manifold._points._value0;
			value4.LocalPoint = circleB._p;
			value4.Id.Key = 0u;
			manifold._points._value0 = value4;
		}
	}

	public static void CollidePolygons(ref Manifold manifold, PolygonShape polyA, ref Transform xfA, PolygonShape polyB, ref Transform xfB)
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		manifold._pointCount = 0;
		float num = polyA._radius + polyB._radius;
		int A_ = 0;
		float num2 = a(out A_, polyA, ref xfA, polyB, ref xfB);
		if (num2 > num)
		{
			return;
		}
		int A_2 = 0;
		float num3 = a(out A_2, polyB, ref xfB, polyA, ref xfA);
		if (num3 > num)
		{
			return;
		}
		float num4 = 0.98f;
		float num5 = 0.001f;
		PolygonShape polygonShape;
		PolygonShape a_;
		Transform A_3;
		Transform A_4;
		int num6;
		bool flag;
		if (num3 > num4 * num2 + num5)
		{
			polygonShape = polyB;
			a_ = polyA;
			A_3 = xfB;
			A_4 = xfA;
			num6 = A_2;
			manifold._type = ManifoldType.FaceB;
			flag = true;
		}
		else
		{
			polygonShape = polyA;
			a_ = polyB;
			A_3 = xfA;
			A_4 = xfB;
			num6 = A_;
			manifold._type = ManifoldType.FaceA;
			flag = false;
		}
		a(out var A_5, polygonShape, ref A_3, num6, a_, ref A_4);
		int vertexCount = polygonShape._vertexCount;
		int num7 = num6;
		int num8 = ((num6 + 1 < vertexCount) ? (num6 + 1) : 0);
		Vector2 val = polygonShape._vertices[num7];
		Vector2 val2 = polygonShape._vertices[num8];
		Vector2 val3 = default(Vector2);
		val3.X = val2.X - val.X;
		val3.Y = val2.Y - val.Y;
		Vector2 val4 = val3;
		val4.Normalize();
		Vector2 val5 = default(Vector2);
		val5.X = 0.5f * (val.X + val2.X);
		val5.Y = 0.5f * (val.Y + val2.Y);
		Vector2 localPoint = val5;
		Vector2 val6 = default(Vector2);
		val6.X = A_3.R.col1.X * val4.X + A_3.R.col2.X * val4.Y;
		val6.Y = A_3.R.col1.Y * val4.X + A_3.R.col2.Y * val4.Y;
		Vector2 val7 = val6;
		float x = A_3.Position.X + A_3.R.col1.X * val.X + A_3.R.col2.X * val.Y;
		val.Y = A_3.Position.Y + A_3.R.col1.Y * val.X + A_3.R.col2.Y * val.Y;
		val.X = x;
		float offset = 0f - (val7.X * val.X + val7.Y * val.Y) + num;
		int num9 = ClipSegmentToLine(out var vOut, ref A_5, -val7, offset, num7);
		if (num9 < 2)
		{
			return;
		}
		x = A_3.Position.X + A_3.R.col1.X * val2.X + A_3.R.col2.X * val2.Y;
		val2.Y = A_3.Position.Y + A_3.R.col1.Y * val2.X + A_3.R.col2.Y * val2.Y;
		val2.X = x;
		float offset2 = val7.X * val2.X + val7.Y * val2.Y + num;
		num9 = ClipSegmentToLine(out var vOut2, ref vOut, val7, offset2, num8);
		if (num9 < 2)
		{
			return;
		}
		manifold._localNormal.X = val4.Y;
		manifold._localNormal.Y = 0f - val4.X;
		manifold._localPoint = localPoint;
		int num10 = 0;
		float num11 = val7.Y * val.X - val7.X * val.Y;
		float num12 = val7.Y * vOut2._value0.v.X - val7.X * vOut2._value0.v.Y - num11;
		if (num12 <= num)
		{
			ManifoldPoint value = manifold._points._value0;
			value.LocalPoint = MathUtils.MultiplyT(ref A_4, vOut2._value0.v);
			value.Id = vOut2._value0.id;
			if (flag)
			{
				ContactFeature features = value.Id.Features;
				value.Id.Features.a = features.b;
				value.Id.Features.b = features.a;
				value.Id.Features.c = features.d;
				value.Id.Features.d = features.c;
			}
			manifold._points._value0 = value;
			num10++;
		}
		float num13 = val7.Y * vOut2._value1.v.X - val7.X * vOut2._value1.v.Y - num11;
		if (num13 <= num)
		{
			ManifoldPoint value2 = default(ManifoldPoint);
			value2.LocalPoint = MathUtils.MultiplyT(ref A_4, vOut2._value1.v);
			value2.Id = vOut2._value1.id;
			if (flag)
			{
				ContactFeature features2 = value2.Id.Features;
				value2.Id.Features.a = features2.b;
				value2.Id.Features.b = features2.a;
				value2.Id.Features.c = features2.d;
				value2.Id.Features.d = features2.c;
			}
			manifold._points[num10] = value2;
			num10++;
		}
		manifold._pointCount = num10;
	}

	public static void CollideEdgeAndCircle(ref Manifold manifold, EdgeShape edgeA, ref Transform xfA, CircleShape circleB, ref Transform xfB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		manifold._pointCount = 0;
		Vector2 val = MathUtils.MultiplyT(ref xfA, MathUtils.Multiply(ref xfB, circleB._p));
		Vector2 vertex = edgeA._vertex1;
		Vector2 vertex2 = edgeA._vertex2;
		Vector2 val2 = vertex2 - vertex;
		float num = Vector2.Dot(val2, vertex2 - val);
		float num2 = Vector2.Dot(val2, val - vertex);
		float num3 = edgeA._radius + circleB._radius;
		ContactFeature features = default(ContactFeature);
		features.b = 0;
		features.d = 0;
		Vector2 val3;
		Vector2 val4;
		if (num2 <= 0f)
		{
			val3 = vertex;
			val4 = val - val3;
			float num4 = Vector2.Dot(val4, val4);
			if (num4 > num3 * num3)
			{
				return;
			}
			if (edgeA._hasVertex0)
			{
				Vector2 vertex3 = edgeA._vertex0;
				Vector2 val5 = vertex;
				Vector2 val6 = val5 - vertex3;
				float num5 = Vector2.Dot(val6, val5 - val);
				if (num5 > 0f)
				{
					return;
				}
			}
			features.a = 0;
			features.c = 0;
			manifold._pointCount = 1;
			manifold._type = ManifoldType.Circles;
			manifold._localNormal = Vector2.Zero;
			manifold._localPoint = val3;
			ManifoldPoint value = default(ManifoldPoint);
			value.Id.Key = 0u;
			value.Id.Features = features;
			value.LocalPoint = circleB._p;
			manifold._points[0] = value;
			return;
		}
		if (num <= 0f)
		{
			val3 = vertex2;
			val4 = val - val3;
			float num6 = Vector2.Dot(val4, val4);
			if (num6 > num3 * num3)
			{
				return;
			}
			if (edgeA._hasVertex3)
			{
				Vector2 vertex4 = edgeA._vertex3;
				Vector2 val7 = vertex2;
				Vector2 val8 = vertex4 - val7;
				float num7 = Vector2.Dot(val8, val - val7);
				if (num7 > 0f)
				{
					return;
				}
			}
			features.a = 1;
			features.c = 0;
			manifold._pointCount = 1;
			manifold._type = ManifoldType.Circles;
			manifold._localNormal = Vector2.Zero;
			manifold._localPoint = val3;
			ManifoldPoint value2 = default(ManifoldPoint);
			value2.Id.Key = 0u;
			value2.Id.Features = features;
			value2.LocalPoint = circleB._p;
			manifold._points[0] = value2;
			return;
		}
		float num8 = Vector2.Dot(val2, val2);
		val3 = 1f / num8 * (num * vertex + num2 * vertex2);
		val4 = val - val3;
		float num9 = Vector2.Dot(val4, val4);
		if (!(num9 > num3 * num3))
		{
			Vector2 val9 = default(Vector2);
			val9 = new Vector2(0f - val2.Y, val2.X);
			if (Vector2.Dot(val9, val - vertex) < 0f)
			{
				val9 = new Vector2(0f - val9.X, 0f - val9.Y);
			}
			val9.Normalize();
			features.a = 0;
			features.c = 1;
			manifold._pointCount = 1;
			manifold._type = ManifoldType.FaceA;
			manifold._localNormal = val9;
			manifold._localPoint = vertex;
			ManifoldPoint value3 = default(ManifoldPoint);
			value3.Id.Key = 0u;
			value3.Id.Features = features;
			value3.LocalPoint = circleB._p;
			manifold._points[0] = value3;
		}
	}

	private static EPAxis b(Vector2 A_0, Vector2 A_1, Vector2 A_2, PolygonShape A_3, float A_4)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		EPAxis result = default(EPAxis);
		result.type = EPAxisType.EdgeA;
		result.index = 0;
		result.separation = Vector2.Dot(A_2, A_3._vertices[0] - A_0);
		for (int i = 1; i < A_3._vertexCount; i++)
		{
			float num = Vector2.Dot(A_2, A_3._vertices[i] - A_0);
			if (num < result.separation)
			{
				result.separation = num;
			}
		}
		return result;
	}

	private static EPAxis a(Vector2 A_0, Vector2 A_1, Vector2 A_2, PolygonShape A_3, float A_4)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		EPAxis result = default(EPAxis);
		result.type = EPAxisType.EdgeB;
		result.index = 0;
		result.separation = float.MinValue;
		for (int i = 0; i < A_3._vertexCount; i++)
		{
			float val = Vector2.Dot(A_3._normals[i], A_0 - A_3._vertices[i]);
			float val2 = Vector2.Dot(A_3._normals[i], A_1 - A_3._vertices[i]);
			float num = Math.Min(val, val2);
			if (num > result.separation)
			{
				result.index = i;
				result.separation = num;
				if (num > A_4)
				{
					return result;
				}
			}
		}
		return result;
	}

	private static void a(ref FixedArray2<ClipVertex> A_0, PolygonShape A_1, int A_2, PolygonShape A_3)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		_ = A_1._vertexCount;
		int vertexCount = A_3._vertexCount;
		Vector2 val = A_1._normals[A_2];
		int num = 0;
		float num2 = float.MaxValue;
		for (int i = 0; i < vertexCount; i++)
		{
			float num3 = Vector2.Dot(val, A_3._normals[i]);
			if (num3 < num2)
			{
				num2 = num3;
				num = i;
			}
		}
		int num4 = num;
		int num5 = ((num4 + 1 < vertexCount) ? (num4 + 1) : 0);
		ClipVertex value = default(ClipVertex);
		value.v = A_3._vertices[num4];
		value.id.Features.a = (byte)A_2;
		value.id.Features.b = (byte)num4;
		value.id.Features.c = 1;
		value.id.Features.d = 0;
		A_0[0] = value;
		value.v = A_3._vertices[num5];
		value.id.Features.a = (byte)A_2;
		value.id.Features.b = (byte)num5;
		value.id.Features.c = 1;
		value.id.Features.d = 0;
		A_0[1] = value;
	}

	public static void CollideEdgeAndPolygon(ref Manifold manifold, EdgeShape edgeA, ref Transform xfA, PolygonShape polygonB_in, ref Transform xfB)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		manifold._pointCount = 0;
		MathUtils.MultiplyT(ref xfA, ref xfB, out var C);
		Collision.m_a.SetAsEdge(edgeA._vertex1, edgeA._vertex2);
		Collision.m_b._radius = polygonB_in._radius;
		Collision.m_b._vertexCount = polygonB_in._vertexCount;
		Collision.m_b._centroid = MathUtils.Multiply(ref C, polygonB_in._centroid);
		for (int i = 0; i < Collision.m_b._vertexCount; i++)
		{
			Collision.m_b._vertices[i] = MathUtils.Multiply(ref C, polygonB_in._vertices[i]);
			Collision.m_b._normals[i] = MathUtils.Multiply(ref C.R, polygonB_in._normals[i]);
		}
		float num = Collision.m_a._radius + Collision.m_b._radius;
		Vector2 vertex = edgeA._vertex1;
		Vector2 vertex2 = edgeA._vertex2;
		Vector2 val = vertex2 - vertex;
		Vector2 val2 = default(Vector2);
		val2 = new Vector2(val.Y, 0f - val.X);
		val2.Normalize();
		bool flag = Vector2.Dot(val2, Collision.m_b._centroid - vertex) >= 0f;
		if (!flag)
		{
			val2 = -val2;
		}
		EPAxis ePAxis = b(vertex, vertex2, val2, Collision.m_b, num);
		if (ePAxis.separation > num)
		{
			return;
		}
		FixedArray2<EdgeType> fixedArray = default(FixedArray2<EdgeType>);
		if (edgeA._hasVertex0)
		{
			Vector2 vertex3 = edgeA._vertex0;
			float num2 = Vector2.Dot(val2, vertex3 - vertex);
			if (num2 > 0.0050000004f)
			{
				fixedArray[0] = EdgeType.Concave;
			}
			else if (num2 >= -0.0050000004f)
			{
				fixedArray[0] = EdgeType.Flat;
			}
			else
			{
				fixedArray[0] = EdgeType.Convex;
			}
		}
		if (edgeA._hasVertex3)
		{
			Vector2 vertex4 = edgeA._vertex3;
			float num3 = Vector2.Dot(val2, vertex4 - vertex2);
			if (num3 > 0.0050000004f)
			{
				fixedArray[1] = EdgeType.Concave;
			}
			else if (num3 >= -0.0050000004f)
			{
				fixedArray[1] = EdgeType.Flat;
			}
			else
			{
				fixedArray[1] = EdgeType.Convex;
			}
		}
		if (fixedArray[0] == EdgeType.Convex)
		{
			Vector2 vertex5 = edgeA._vertex0;
			Vector2 val3 = vertex - vertex5;
			Vector2 val4 = default(Vector2);
			val4 = new Vector2(val3.Y, 0f - val3.X);
			val4.Normalize();
			if (!flag)
			{
				val4 = -val4;
			}
			if (b(vertex5, vertex, val4, Collision.m_b, num).separation > ePAxis.separation)
			{
				return;
			}
		}
		if (fixedArray[1] == EdgeType.Convex)
		{
			Vector2 vertex6 = edgeA._vertex3;
			Vector2 val5 = vertex6 - vertex2;
			Vector2 val6 = default(Vector2);
			val6 = new Vector2(val5.Y, 0f - val5.X);
			val6.Normalize();
			if (!flag)
			{
				val6 = -val6;
			}
			if (b(vertex2, vertex6, val6, Collision.m_b, num).separation > ePAxis.separation)
			{
				return;
			}
		}
		EPAxis ePAxis2 = a(vertex, vertex2, val2, Collision.m_b, num);
		if (ePAxis2.separation > num)
		{
			return;
		}
		float num4 = 0.98f;
		float num5 = 0.001f;
		EPAxis ePAxis3 = ((!(ePAxis2.separation > num4 * ePAxis.separation + num5)) ? ePAxis : ePAxis2);
		PolygonShape polygonShape;
		PolygonShape a_;
		if (ePAxis3.type == EPAxisType.EdgeA)
		{
			polygonShape = Collision.m_a;
			a_ = Collision.m_b;
			if (!flag)
			{
				ePAxis3.index = 1;
			}
			manifold._type = ManifoldType.FaceA;
		}
		else
		{
			polygonShape = Collision.m_b;
			a_ = Collision.m_a;
			manifold._type = ManifoldType.FaceB;
		}
		int index = ePAxis3.index;
		FixedArray2<ClipVertex> A_ = default(FixedArray2<ClipVertex>);
		a(ref A_, polygonShape, ePAxis3.index, a_);
		int vertexCount = polygonShape._vertexCount;
		int num6 = index;
		int num7 = ((index + 1 < vertexCount) ? (index + 1) : 0);
		Vector2 val7 = polygonShape._vertices[num6];
		Vector2 val8 = polygonShape._vertices[num7];
		Vector2 val9 = val8 - val7;
		val9.Normalize();
		Vector2 val10 = MathUtils.Cross(val9, 1f);
		Vector2 val11 = 0.5f * (val7 + val8);
		float num8 = Vector2.Dot(val10, val7);
		float offset = 0f - Vector2.Dot(val9, val7) + num;
		float offset2 = Vector2.Dot(val9, val8) + num;
		int num9 = ClipSegmentToLine(out var vOut, ref A_, -val9, offset, num6);
		if (num9 < 2)
		{
			return;
		}
		num9 = ClipSegmentToLine(out var vOut2, ref vOut, val9, offset2, num7);
		if (num9 < 2)
		{
			return;
		}
		if (ePAxis3.type == EPAxisType.EdgeA)
		{
			manifold._localNormal = val10;
			manifold._localPoint = val11;
		}
		else
		{
			manifold._localNormal = MathUtils.MultiplyT(ref C.R, val10);
			manifold._localPoint = MathUtils.MultiplyT(ref C, val11);
		}
		int num10 = 0;
		for (int j = 0; j < 2; j++)
		{
			float num11 = Vector2.Dot(val10, vOut2[j].v) - num8;
			if (num11 <= num)
			{
				ManifoldPoint value = manifold._points[num10];
				if (ePAxis3.type == EPAxisType.EdgeA)
				{
					value.LocalPoint = MathUtils.MultiplyT(ref C, vOut2[j].v);
					value.Id = vOut2[j].id;
				}
				else
				{
					value.LocalPoint = vOut2[j].v;
					value.Id.Features.c = vOut2[j].id.Features.d;
					value.Id.Features.d = vOut2[j].id.Features.c;
					value.Id.Features.a = vOut2[j].id.Features.b;
					value.Id.Features.b = vOut2[j].id.Features.a;
				}
				manifold._points[num10] = value;
				if (value.Id.Features.c != 0 || fixedArray[value.Id.Features.a] != EdgeType.Flat)
				{
					num10++;
				}
			}
		}
		manifold._pointCount = num10;
	}

	public static int ClipSegmentToLine(out FixedArray2<ClipVertex> vOut, ref FixedArray2<ClipVertex> vIn, Vector2 normal, float offset, int vertexIndexA)
	{
		vOut = default(FixedArray2<ClipVertex>);
		int num = 0;
		float num2 = normal.X * vIn._value0.v.X + normal.Y * vIn._value0.v.Y - offset;
		float num3 = normal.X * vIn._value1.v.X + normal.Y * vIn._value1.v.Y - offset;
		if (num2 <= 0f)
		{
			vOut[num++] = vIn._value0;
		}
		if (num3 <= 0f)
		{
			vOut[num++] = vIn._value1;
		}
		if (num2 * num3 < 0f)
		{
			float num4 = num2 / (num2 - num3);
			ClipVertex value = vOut[num];
			value.v.X = vIn._value0.v.X + num4 * (vIn._value1.v.X - vIn._value0.v.X);
			value.v.Y = vIn._value0.v.Y + num4 * (vIn._value1.v.Y - vIn._value0.v.Y);
			value.id.Features.a = (byte)vertexIndexA;
			value.id.Features.b = vIn._value0.id.Features.b;
			value.id.Features.c = 0;
			value.id.Features.d = 1;
			vOut[num] = value;
			num++;
		}
		return num;
	}

	private static float a(PolygonShape A_0, ref Transform A_1, int A_2, PolygonShape A_3, ref Transform A_4)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		_ = A_0._vertexCount;
		int vertexCount = A_3._vertexCount;
		Vector2 val;
		Vector2 val2;
		switch (A_2)
		{
		default:
			val = A_0._normals._value0;
			val2 = A_0._vertices._value0;
			break;
		case 1:
			val = A_0._normals._value1;
			val2 = A_0._vertices._value1;
			break;
		case 2:
			val = A_0._normals._value2;
			val2 = A_0._vertices._value2;
			break;
		case 3:
			val = A_0._normals._value3;
			val2 = A_0._vertices._value3;
			break;
		case 4:
			val = A_0._normals._value4;
			val2 = A_0._vertices._value4;
			break;
		case 5:
			val = A_0._normals._value5;
			val2 = A_0._vertices._value5;
			break;
		case 6:
			val = A_0._normals._value6;
			val2 = A_0._vertices._value6;
			break;
		case 7:
			val = A_0._normals._value7;
			val2 = A_0._vertices._value7;
			break;
		}
		float num = A_1.R.col1.X * val.X + A_1.R.col2.X * val.Y;
		float num2 = A_1.R.col1.Y * val.X + A_1.R.col2.Y * val.Y;
		Vector2 val3 = default(Vector2);
		val3.X = num * A_4.R.col1.X + num2 * A_4.R.col1.Y;
		val3.Y = num * A_4.R.col2.X + num2 * A_4.R.col2.Y;
		Vector2 val4 = val3;
		Vector2 val5 = A_3._vertices._value0;
		float num3 = val5.X * val4.X + val5.Y * val4.Y;
		if (vertexCount > 1)
		{
			float num4 = A_3._vertices._value1.X * val4.X + A_3._vertices._value1.Y * val4.Y;
			if (num3 > num4)
			{
				num3 = num4;
				val5 = A_3._vertices._value1;
			}
			if (vertexCount > 2)
			{
				num4 = A_3._vertices._value2.X * val4.X + A_3._vertices._value2.Y * val4.Y;
				if (num3 > num4)
				{
					num3 = num4;
					val5 = A_3._vertices._value2;
				}
				if (vertexCount > 3)
				{
					num4 = A_3._vertices._value3.X * val4.X + A_3._vertices._value3.Y * val4.Y;
					if (num3 > num4)
					{
						num3 = num4;
						val5 = A_3._vertices._value3;
					}
					if (vertexCount > 4)
					{
						num4 = A_3._vertices._value4.X * val4.X + A_3._vertices._value4.Y * val4.Y;
						if (num3 > num4)
						{
							num3 = num4;
							val5 = A_3._vertices._value4;
						}
						if (vertexCount > 5)
						{
							num4 = A_3._vertices._value5.X * val4.X + A_3._vertices._value5.Y * val4.Y;
							if (num3 > num4)
							{
								num3 = num4;
								val5 = A_3._vertices._value5;
							}
							if (vertexCount > 6)
							{
								num4 = A_3._vertices._value6.X * val4.X + A_3._vertices._value6.Y * val4.Y;
								if (num3 > num4)
								{
									num3 = num4;
									val5 = A_3._vertices._value6;
								}
								if (vertexCount > 7)
								{
									num4 = A_3._vertices._value7.X * val4.X + A_3._vertices._value7.Y * val4.Y;
									if (num3 > num4)
									{
										num3 = num4;
										val5 = A_3._vertices._value7;
									}
								}
							}
						}
					}
				}
			}
		}
		Vector2 val6 = default(Vector2);
		val6.X = A_1.Position.X + A_1.R.col1.X * val2.X + A_1.R.col2.X * val2.Y;
		val6.Y = A_1.Position.Y + A_1.R.col1.Y * val2.X + A_1.R.col2.Y * val2.Y;
		Vector2 val7 = val6;
		Vector2 val8 = default(Vector2);
		val8.X = A_4.Position.X + A_4.R.col1.X * val5.X + A_4.R.col2.X * val5.Y;
		val8.Y = A_4.Position.Y + A_4.R.col1.Y * val5.X + A_4.R.col2.Y * val5.Y;
		Vector2 val9 = val8;
		return (val9.X - val7.X) * num + (val9.Y - val7.Y) * num2;
	}

	private static float a(out int A_0, PolygonShape A_1, ref Transform A_2, PolygonShape A_3, ref Transform A_4)
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		A_0 = -1;
		int vertexCount = A_1._vertexCount;
		float num = A_4.Position.X + A_4.R.col1.X * A_3._centroid.X + A_4.R.col2.X * A_3._centroid.Y - A_2.Position.X + A_2.R.col1.X * A_1._centroid.X + A_2.R.col2.X * A_1._centroid.Y;
		float num2 = A_4.Position.Y + A_4.R.col1.Y * A_3._centroid.X + A_4.R.col2.Y * A_3._centroid.Y - A_2.Position.Y + A_2.R.col1.Y * A_1._centroid.X + A_2.R.col2.Y * A_1._centroid.Y;
		Vector2 val = default(Vector2);
		val.X = num * A_2.R.col1.X + num2 * A_2.R.col1.Y;
		val.Y = num * A_2.R.col2.X + num2 * A_2.R.col2.Y;
		Vector2 d = val;
		int vertWithMaxDot = DistanceProxy.GetVertWithMaxDot(ref A_1._normals, vertexCount, d);
		float num3 = a(A_1, ref A_2, vertWithMaxDot, A_3, ref A_4);
		int num4 = ((vertWithMaxDot - 1 >= 0) ? (vertWithMaxDot - 1) : (vertexCount - 1));
		float num5 = a(A_1, ref A_2, num4, A_3, ref A_4);
		int num6 = ((vertWithMaxDot + 1 < vertexCount) ? (vertWithMaxDot + 1) : 0);
		float num7 = a(A_1, ref A_2, num6, A_3, ref A_4);
		int num8;
		int num9;
		float num10;
		if (num5 > num3 && num5 > num7)
		{
			num8 = -1;
			num9 = num4;
			num10 = num5;
		}
		else
		{
			if (!(num7 > num3))
			{
				A_0 = vertWithMaxDot;
				return num3;
			}
			num8 = 1;
			num9 = num6;
			num10 = num7;
		}
		while (true)
		{
			vertWithMaxDot = ((num8 != -1) ? ((num9 + 1 < vertexCount) ? (num9 + 1) : 0) : ((num9 - 1 >= 0) ? (num9 - 1) : (vertexCount - 1)));
			num3 = a(A_1, ref A_2, vertWithMaxDot, A_3, ref A_4);
			if (!(num3 > num10))
			{
				break;
			}
			num9 = vertWithMaxDot;
			num10 = num3;
		}
		A_0 = num9;
		return num10;
	}

	private static void a(out FixedArray2<ClipVertex> A_0, PolygonShape A_1, ref Transform A_2, int A_3, PolygonShape A_4, ref Transform A_5)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		A_0 = default(FixedArray2<ClipVertex>);
		_ = A_1._vertexCount;
		int vertexCount = A_4._vertexCount;
		Vector2 d = MathUtils.MultiplyT(ref A_5.R, MathUtils.Multiply(ref A_2.R, A_1._normals[A_3]));
		int vertWithMinDot = DistanceProxy.GetVertWithMinDot(ref A_4._normals, vertexCount, d);
		int num = vertWithMinDot;
		int num2 = ((num + 1 < vertexCount) ? (num + 1) : 0);
		ClipVertex value = A_0._value0;
		value.v = MathUtils.Multiply(ref A_5, A_4._vertices[num]);
		value.id.Features.a = (byte)A_3;
		value.id.Features.b = (byte)num;
		value.id.Features.c = 1;
		value.id.Features.d = 0;
		A_0._value0 = value;
		ClipVertex value2 = A_0._value1;
		value2.v = MathUtils.Multiply(ref A_5, A_4._vertices[num2]);
		value2.id.Features.a = (byte)A_3;
		value2.id.Features.b = (byte)num2;
		value2.id.Features.c = 1;
		value2.id.Features.d = 0;
		A_0._value1 = value2;
	}
}
