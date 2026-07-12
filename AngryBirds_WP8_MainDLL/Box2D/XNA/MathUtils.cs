using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public static class MathUtils
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct FloatIntUnion
	{
		[FieldOffset(0)]
		public float floatValue;

		[FieldOffset(0)]
		public int intValue;
	}

	public static float Cross(Vector2 a, Vector2 b)
	{
		return a.X * b.Y - a.Y * b.X;
	}

	public static Vector2 Cross(Vector2 a, float s)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2(s * a.Y, (0f - s) * a.X);
	}

	public static Vector2 Cross(float s, Vector2 a)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2((0f - s) * a.Y, s * a.X);
	}

	public static Vector2 Abs(Vector2 v)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2(Math.Abs(v.X), Math.Abs(v.Y));
	}

	public static Vector2 Multiply(ref Mat22 A, Vector2 v)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		float x = A.col1.X * v.X + A.col2.X * v.Y;
		v.Y = A.col1.Y * v.X + A.col2.Y * v.Y;
		v.X = x;
		return v;
	}

	public static Vector2 MultiplyT(ref Mat22 A, Vector2 v)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		float x = v.X * A.col1.X + v.Y * A.col1.Y;
		v.Y = v.X * A.col2.X + v.Y * A.col2.Y;
		v.X = x;
		return v;
	}

	public static Vector2 Multiply(ref Transform T, Vector2 v)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		float x = T.Position.X + T.R.col1.X * v.X + T.R.col2.X * v.Y;
		v.Y = T.Position.Y + T.R.col1.Y * v.X + T.R.col2.Y * v.Y;
		v.X = x;
		return v;
	}

	public static Vector2 MultiplyT(ref Transform T, Vector2 v)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		float num = v.X - T.Position.X;
		float num2 = v.Y - T.Position.Y;
		v.X = num * T.R.col1.X + num2 * T.R.col1.Y;
		v.Y = num * T.R.col2.X + num2 * T.R.col2.Y;
		return v;
	}

	public static void MultiplyT(ref Mat22 A, ref Mat22 B, out Mat22 C)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		Vector2 c = default(Vector2);
		c = new Vector2(Vector2.Dot(A.col1, B.col1), Vector2.Dot(A.col2, B.col1));
		Vector2 c2 = default(Vector2);
		c2 = new Vector2(Vector2.Dot(A.col1, B.col2), Vector2.Dot(A.col2, B.col2));
		C = new Mat22(c, c2);
	}

	public static void MultiplyT(ref Transform A, ref Transform B, out Transform C)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		MultiplyT(ref A.R, ref B.R, out var C2);
		C = new Transform(B.Position - A.Position, ref C2);
	}

	public static void Swap<T>(ref T a, ref T b)
	{
		T val = a;
		a = b;
		b = val;
	}

	public static bool IsValid(float x)
	{
		if (float.IsNaN(x))
		{
			return false;
		}
		return !float.IsInfinity(x);
	}

	public static bool IsValid(this Vector2 x)
	{
		if (IsValid(x.X))
		{
			return IsValid(x.Y);
		}
		return false;
	}

	public static float InvSqrt(float x)
	{
		FloatIntUnion u = default(FloatIntUnion);
		u.floatValue = x;
		float num = 0.5f * x;
		u.intValue = 1597463007 - (u.intValue >> 1);
		x = u.floatValue;
		x *= 1.5f - num * x * x;
		return x;
	}

	public static int Clamp(int a, int low, int high)
	{
		return Math.Max(low, Math.Min(a, high));
	}

	public static float Clamp(float a, float low, float high)
	{
		return Math.Max(low, Math.Min(a, high));
	}

	public static Vector2 Clamp(Vector2 a, Vector2 low, Vector2 high)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.Max(low, Vector2.Min(a, high));
	}
}
