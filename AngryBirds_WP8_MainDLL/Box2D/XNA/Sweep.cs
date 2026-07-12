using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public struct Sweep
{
	public Vector2 localCenter;

	public Vector2 c0;

	public Vector2 c;

	public float a0;

	public float a;

	public void GetTransform(out Transform xf, float alpha)
	{
		xf = default(Transform);
		float num = a0 + (a - a0) * alpha;
		float num2;
		for (num2 = num; (double)num2 < -3.14159265; num2 += (float)Math.PI * 2f)
		{
		}
		while ((double)num2 > 3.14159265)
		{
			num2 -= (float)Math.PI * 2f;
		}
		float num3;
		if (num2 < 0f)
		{
			num3 = 4f / (float)Math.PI * num2 + 0.40528473f * num2 * num2;
			num3 = ((!(num3 < 0f)) ? (0.225f * (num3 * num3 - num3) + num3) : (0.225f * (num3 * (0f - num3) - num3) + num3));
		}
		else
		{
			num3 = 4f / (float)Math.PI * num2 - 0.40528473f * num2 * num2;
			num3 = ((!(num3 < 0f)) ? (0.225f * (num3 * num3 - num3) + num3) : (0.225f * (num3 * (0f - num3) - num3) + num3));
		}
		num2 += (float)Math.PI / 2f;
		if ((double)num2 > 3.14159265)
		{
			num2 -= (float)Math.PI * 2f;
		}
		float num4;
		if (num2 < 0f)
		{
			num4 = 4f / (float)Math.PI * num2 + 0.40528473f * num2 * num2;
			num4 = ((!(num4 < 0f)) ? (0.225f * (num4 * num4 - num4) + num4) : (0.225f * (num4 * (0f - num4) - num4) + num4));
		}
		else
		{
			num4 = 4f / (float)Math.PI * num2 - 0.40528473f * num2 * num2;
			num4 = ((!(num4 < 0f)) ? (0.225f * (num4 * num4 - num4) + num4) : (0.225f * (num4 * (0f - num4) - num4) + num4));
		}
		float num5 = c0.X + (c.X - c0.X) * alpha;
		float num6 = c0.Y + (c.Y - c0.Y) * alpha;
		xf.R.col1.X = num4;
		xf.R.col2.X = 0f - num3;
		xf.R.col1.Y = num3;
		xf.R.col2.Y = num4;
		xf.Position.X = num5 - (num4 * localCenter.X - num3 * localCenter.Y);
		xf.Position.Y = num6 - (num3 * localCenter.X + num4 * localCenter.Y);
	}

	public void Advance(float t)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		c0 = (1f - t) * c0 + t * c;
		a0 = (1f - t) * a0 + t * a;
	}

	public void Normalize()
	{
		float num = (float)Math.PI * 2f;
		float num2 = num * (float)Math.Floor(a0 / num);
		a0 -= num2;
		a -= num2;
	}
}
