using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public struct Mat33
{
	public Vector3 col1;

	public Vector3 col2;

	public Vector3 col3;

	public Mat33(Vector3 c1, Vector3 c2, Vector3 c3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		col1 = c1;
		col2 = c2;
		col3 = c3;
	}

	public void SetZero()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		col1 = Vector3.Zero;
		col2 = Vector3.Zero;
		col3 = Vector3.Zero;
	}

	public Vector3 Solve33(Vector3 b)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		float num = Vector3.Dot(col1, Vector3.Cross(col2, col3));
		if (num != 0f)
		{
			num = 1f / num;
		}
		return new Vector3(num * Vector3.Dot(b, Vector3.Cross(col2, col3)), num * Vector3.Dot(col1, Vector3.Cross(b, col3)), num * Vector3.Dot(col1, Vector3.Cross(col2, b)));
	}

	public Vector2 Solve22(Vector2 b)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		float x = col1.X;
		float x2 = col2.X;
		float y = col1.Y;
		float y2 = col2.Y;
		float num = x * y2 - x2 * y;
		if (num != 0f)
		{
			num = 1f / num;
		}
		return new Vector2(num * (y2 * b.X - x2 * b.Y), num * (x * b.Y - y * b.X));
	}
}
