using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public struct WorldManifold
{
	public Vector2 _normal;

	public FixedArray2<Vector2> _points;

	public WorldManifold(ref Manifold manifold, ref Transform xfA, float radiusA, ref Transform xfB, float radiusB)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		_points = default(FixedArray2<Vector2>);
		if (manifold._pointCount == 0)
		{
			_normal = Vector2.UnitY;
			return;
		}
		switch (manifold._type)
		{
		case ManifoldType.Circles:
		{
			float num23 = xfA.Position.X + xfA.R.col1.X * manifold._localPoint.X + xfA.R.col2.X * manifold._localPoint.Y;
			float num24 = xfA.Position.Y + xfA.R.col1.Y * manifold._localPoint.X + xfA.R.col2.Y * manifold._localPoint.Y;
			float num25 = xfB.Position.X + xfB.R.col1.X * manifold._points._value0.LocalPoint.X + xfB.R.col2.X * manifold._points._value0.LocalPoint.Y;
			float num26 = xfB.Position.Y + xfB.R.col1.Y * manifold._points._value0.LocalPoint.X + xfB.R.col2.Y * manifold._points._value0.LocalPoint.Y;
			float num27 = 1f;
			float num28 = 0f;
			float num29 = num25 - num23;
			float num30 = num26 - num24;
			float num31 = num29 * num29 + num30 * num30;
			if (num31 > 1.4210855E-14f)
			{
				float num32 = 1f / (float)Math.Sqrt(num31);
				num27 = num29 * num32;
				num28 = num30 * num32;
			}
			float num33 = num23 + radiusA * num27;
			float num34 = num24 + radiusA * num28;
			float num35 = num25 - radiusB * num27;
			float num36 = num26 - radiusB * num28;
			_points._value0.X = 0.5f * (num33 + num35);
			_points._value0.Y = 0.5f * (num34 + num36);
			_normal = new Vector2
			{
				X = num27,
				Y = num28
			};
			break;
		}
		case ManifoldType.FaceA:
		{
			_normal = new Vector2
			{
				X = xfA.R.col1.X * manifold._localNormal.X + xfA.R.col2.X * manifold._localNormal.Y,
				Y = xfA.R.col1.Y * manifold._localNormal.X + xfA.R.col2.Y * manifold._localNormal.Y
			};
			float num12 = xfA.Position.X + xfA.R.col1.X * manifold._localPoint.X + xfA.R.col2.X * manifold._localPoint.Y;
			float num13 = xfA.Position.Y + xfA.R.col1.Y * manifold._localPoint.X + xfA.R.col2.Y * manifold._localPoint.Y;
			if (manifold._pointCount > 0)
			{
				float num14 = xfB.Position.X + xfB.R.col1.X * manifold._points._value0.LocalPoint.X + xfB.R.col2.X * manifold._points._value0.LocalPoint.Y;
				float num15 = xfB.Position.Y + xfB.R.col1.Y * manifold._points._value0.LocalPoint.X + xfB.R.col2.Y * manifold._points._value0.LocalPoint.Y;
				float num16 = num14 - num12;
				float num17 = num15 - num13;
				float num18 = radiusA - (num16 * _normal.X + num17 * _normal.Y);
				float num19 = num14 + num18 * _normal.X;
				float num20 = num15 + num18 * _normal.Y;
				float num21 = num14 - radiusB * _normal.X;
				float num22 = num15 - radiusB * _normal.Y;
				_points._value0.X = 0.5f * (num19 + num21);
				_points._value0.Y = 0.5f * (num20 + num22);
				if (manifold._pointCount > 1)
				{
					num14 = xfB.Position.X + xfB.R.col1.X * manifold._points._value1.LocalPoint.X + xfB.R.col2.X * manifold._points._value1.LocalPoint.Y;
					num15 = xfB.Position.Y + xfB.R.col1.Y * manifold._points._value1.LocalPoint.X + xfB.R.col2.Y * manifold._points._value1.LocalPoint.Y;
					num16 = num14 - num12;
					num17 = num15 - num13;
					num18 = radiusA - (num16 * _normal.X + num17 * _normal.Y);
					num19 = num14 + num18 * _normal.X;
					num20 = num15 + num18 * _normal.Y;
					num21 = num14 - radiusB * _normal.X;
					num22 = num15 - radiusB * _normal.Y;
					_points._value1.X = 0.5f * (num19 + num21);
					_points._value1.Y = 0.5f * (num20 + num22);
				}
			}
			break;
		}
		case ManifoldType.FaceB:
		{
			_normal = new Vector2
			{
				X = xfB.R.col1.X * manifold._localNormal.X + xfB.R.col2.X * manifold._localNormal.Y,
				Y = xfB.R.col1.Y * manifold._localNormal.X + xfB.R.col2.Y * manifold._localNormal.Y
			};
			float num = xfB.Position.X + xfB.R.col1.X * manifold._localPoint.X + xfB.R.col2.X * manifold._localPoint.Y;
			float num2 = xfB.Position.Y + xfB.R.col1.Y * manifold._localPoint.X + xfB.R.col2.Y * manifold._localPoint.Y;
			if (manifold._pointCount > 0)
			{
				float num3 = xfA.Position.X + xfA.R.col1.X * manifold._points._value0.LocalPoint.X + xfA.R.col2.X * manifold._points._value0.LocalPoint.Y;
				float num4 = xfA.Position.Y + xfA.R.col1.Y * manifold._points._value0.LocalPoint.X + xfA.R.col2.Y * manifold._points._value0.LocalPoint.Y;
				float num5 = num3 - num;
				float num6 = num4 - num2;
				float num7 = radiusA - (num5 * _normal.X + num6 * _normal.Y);
				float num8 = num3 + num7 * _normal.X;
				float num9 = num4 + num7 * _normal.Y;
				float num10 = num3 - radiusB * _normal.X;
				float num11 = num4 - radiusB * _normal.Y;
				_points._value0.X = 0.5f * (num8 + num10);
				_points._value0.Y = 0.5f * (num9 + num11);
				if (manifold._pointCount > 1)
				{
					num3 = xfA.Position.X + xfA.R.col1.X * manifold._points._value1.LocalPoint.X + xfA.R.col2.X * manifold._points._value1.LocalPoint.Y;
					num4 = xfA.Position.Y + xfA.R.col1.Y * manifold._points._value1.LocalPoint.X + xfA.R.col2.Y * manifold._points._value1.LocalPoint.Y;
					num5 = num3 - num;
					num6 = num4 - num2;
					num7 = radiusA - (num5 * _normal.X + num6 * _normal.Y);
					num8 = num3 + num7 * _normal.X;
					num9 = num4 + num7 * _normal.Y;
					num10 = num3 - radiusB * _normal.X;
					num11 = num4 - radiusB * _normal.Y;
					_points._value1.X = 0.5f * (num8 + num10);
					_points._value1.Y = 0.5f * (num9 + num11);
				}
			}
			_normal.X = 0f - _normal.X;
			_normal.Y = 0f - _normal.Y;
			break;
		}
		default:
			_normal = Vector2.UnitY;
			break;
		}
	}
}
