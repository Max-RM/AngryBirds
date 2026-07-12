using Microsoft.Xna.Framework;

internal struct bv
{
	public Vector2 a;

	public float b;

	public Vector2 c;

	public float d;

	public void e()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		a = Vector2.Zero;
		b = 0f;
		c = Vector2.Zero;
		d = 0f;
	}

	public void f(Vector2 A_0, float A_1, Vector2 A_2, float A_3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		a = A_0;
		b = A_1;
		c = A_2;
		d = A_3;
	}

	public float e(Vector2 A_0, float A_1, Vector2 A_2, float A_3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.Dot(a, A_0) + b * A_1 + Vector2.Dot(c, A_2) + d * A_3;
	}
}
