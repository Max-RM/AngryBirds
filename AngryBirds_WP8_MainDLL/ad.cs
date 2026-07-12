using Box2D.XNA;
using Microsoft.Xna.Framework;

internal struct ad
{
	private Vector2 m_a;

	internal Vector2 b;

	internal Vector2 c;

	internal float d;

	internal ad(ref ContactConstraint A_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		this.m_a = default(Vector2);
		b = default(Vector2);
		c = default(Vector2);
		d = 0f;
		switch (A_0.type)
		{
		case ManifoldType.Circles:
		{
			Vector2 val = MathUtils.Multiply(ref A_0.bodyA.d, A_0.localPoint);
			Vector2 val2 = MathUtils.Multiply(ref A_0.bodyB.d, A_0.points._value0.localPoint);
			if (Vector2.DistanceSquared(val, val2) > 1.4210855E-14f)
			{
				b = val2 - val;
				b.Normalize();
			}
			else
			{
				b = new Vector2(1f, 0f);
			}
			c = 0.5f * (val + val2);
			d = Vector2.Dot(val2 - val, b) - A_0.radius;
			break;
		}
		case ManifoldType.FaceA:
		{
			Vector2 col3 = A_0.bodyA.d.R.col1;
			Vector2 col4 = A_0.bodyA.d.R.col2;
			Vector2 position2 = A_0.bodyA.d.Position;
			b.X = col3.X * A_0.localNormal.X + col4.X * A_0.localNormal.Y;
			b.Y = col3.Y * A_0.localNormal.X + col4.Y * A_0.localNormal.Y;
			this.m_a.X = col3.X * A_0.localPoint.X + col4.X * A_0.localPoint.Y + position2.X;
			this.m_a.Y = col3.Y * A_0.localPoint.X + col4.Y * A_0.localPoint.Y + position2.Y;
			break;
		}
		case ManifoldType.FaceB:
		{
			Vector2 col = A_0.bodyB.d.R.col1;
			Vector2 col2 = A_0.bodyB.d.R.col2;
			Vector2 position = A_0.bodyB.d.Position;
			b.X = 0f - (col.X * A_0.localNormal.X + col2.X * A_0.localNormal.Y);
			b.Y = 0f - (col.Y * A_0.localNormal.X + col2.Y * A_0.localNormal.Y);
			this.m_a.X = col.X * A_0.localPoint.X + col2.X * A_0.localPoint.Y + position.X;
			this.m_a.Y = col.Y * A_0.localPoint.X + col2.Y * A_0.localPoint.Y + position.Y;
			break;
		}
		}
	}

	internal void a(ref ContactConstraint A_0, int A_1)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		switch (A_0.type)
		{
		case ManifoldType.FaceA:
		{
			Vector2 val2 = ((A_1 == 0) ? A_0.points._value0.localPoint : A_0.points._value1.localPoint);
			float num5 = A_0.bodyB.d.Position.X + A_0.bodyB.d.R.col1.X * val2.X + A_0.bodyB.d.R.col2.X * val2.Y;
			float num6 = A_0.bodyB.d.Position.Y + A_0.bodyB.d.R.col1.Y * val2.X + A_0.bodyB.d.R.col2.Y * val2.Y;
			float num7 = num5 - this.m_a.X;
			float num8 = num6 - this.m_a.Y;
			d = num7 * b.X + num8 * b.Y - A_0.radius;
			c.X = num5;
			c.Y = num6;
			break;
		}
		case ManifoldType.FaceB:
		{
			Vector2 val = ((A_1 == 0) ? A_0.points._value0.localPoint : A_0.points._value1.localPoint);
			float num = A_0.bodyA.d.Position.X + A_0.bodyA.d.R.col1.X * val.X + A_0.bodyA.d.R.col2.X * val.Y;
			float num2 = A_0.bodyA.d.Position.Y + A_0.bodyA.d.R.col1.Y * val.X + A_0.bodyA.d.R.col2.Y * val.Y;
			float num3 = num - this.m_a.X;
			float num4 = num2 - this.m_a.Y;
			d = num3 * (0f - b.X) + num4 * (0f - b.Y) - A_0.radius;
			c.X = num;
			c.Y = num2;
			break;
		}
		case ManifoldType.Circles:
			break;
		}
	}
}
