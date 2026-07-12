using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public struct AABB
{
	public Vector2 lowerBound;

	public Vector2 upperBound;

	public bool IsValid()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = upperBound - lowerBound;
		return val.X >= 0f && val.Y >= 0f && lowerBound.IsValid() && upperBound.IsValid();
	}

	public Vector2 GetCenter()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return 0.5f * (lowerBound + upperBound);
	}

	public Vector2 GetExtents()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return 0.5f * (upperBound - lowerBound);
	}

	public float GetPerimeter()
	{
		float num = upperBound.X - lowerBound.X;
		float num2 = upperBound.Y - lowerBound.Y;
		return 2f * (num + num2);
	}

	public void Combine(ref AABB aabb)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		lowerBound = Vector2.Min(lowerBound, aabb.lowerBound);
		upperBound = Vector2.Max(upperBound, aabb.upperBound);
	}

	public void Combine(ref AABB aabb1, ref AABB aabb2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		lowerBound = Vector2.Min(aabb1.lowerBound, aabb2.lowerBound);
		upperBound = Vector2.Max(aabb1.upperBound, aabb2.upperBound);
	}

	public bool Contains(ref AABB aabb)
	{
		return true && lowerBound.X <= aabb.lowerBound.X && lowerBound.Y <= aabb.lowerBound.Y && aabb.upperBound.X <= upperBound.X && aabb.upperBound.Y <= upperBound.Y;
	}

	public static bool TestOverlap(ref AABB a, ref AABB b)
	{
		if (b.lowerBound.X > a.upperBound.X || b.lowerBound.Y > a.upperBound.Y || a.lowerBound.X > b.upperBound.X || a.lowerBound.Y > b.upperBound.Y)
		{
			return false;
		}
		return true;
	}

	public static bool AFullyContainsB(ref AABB a, ref AABB b)
	{
		if ((b.lowerBound.X >= a.lowerBound.X && b.lowerBound.X <= a.upperBound.X && b.lowerBound.Y >= a.lowerBound.Y) || b.lowerBound.Y <= a.upperBound.Y)
		{
			return true;
		}
		return false;
	}

	public static bool TestOverlap(Shape ShapeA, int indexA, Shape ShapeB, int indexB, ref Transform xfA, ref Transform xfB)
	{
		DistanceInput input = default(DistanceInput);
		input.proxyA.Set(ShapeA, indexA);
		input.proxyB.Set(ShapeB, indexB);
		input.transformA = xfA;
		input.transformB = xfB;
		input.useRadii = true;
		Distance.ComputeDistance(out var output, out var _, ref input);
		return output.distance < 1.1920929E-06f;
	}

	public bool RayCast(out RayCastOutput output, ref RayCastInput input)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		output = default(RayCastOutput);
		float num = float.MinValue;
		float num2 = float.MaxValue;
		Vector2 p = input.p1;
		Vector2 v = input.p2 - input.p1;
		Vector2 val = MathUtils.Abs(v);
		Vector2 zero = Vector2.Zero;
		for (int i = 0; i < 2; i++)
		{
			float num3 = ((i == 0) ? val.X : val.Y);
			float num4 = ((i == 0) ? lowerBound.X : lowerBound.Y);
			float num5 = ((i == 0) ? upperBound.X : upperBound.Y);
			float num6 = ((i == 0) ? p.X : p.Y);
			if (num3 < 1.1920929E-07f)
			{
				if (num6 < num4 || num5 < num6)
				{
					return false;
				}
				continue;
			}
			float num7 = ((i == 0) ? v.X : v.Y);
			float num8 = 1f / num7;
			float a = (num4 - num6) * num8;
			float b = (num5 - num6) * num8;
			float num9 = -1f;
			if (a > b)
			{
				MathUtils.Swap(ref a, ref b);
				num9 = 1f;
			}
			if (a > num)
			{
				if (i == 0)
				{
					zero.X = num9;
				}
				else
				{
					zero.Y = num9;
				}
				num = a;
			}
			num2 = Math.Min(num2, b);
			if (num > num2)
			{
				return false;
			}
		}
		if (num < 0f || input.maxFraction < num)
		{
			return false;
		}
		output.fraction = num;
		output.normal = zero;
		return true;
	}
}
