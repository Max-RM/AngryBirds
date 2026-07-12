using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public struct Transform
{
	public Vector2 Position;

	public Mat22 R;

	public Transform(Vector2 position, ref Mat22 r)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Position = position;
		R = r;
	}

	public void SetIdentity()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Position = Vector2.Zero;
		R.SetIdentity();
	}

	public void Set(Vector2 p, float angle)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Position = p;
		R.Set(angle);
	}

	public float GetAngle()
	{
		return (float)Math.Atan2(R.col1.Y, R.col1.X);
	}
}
