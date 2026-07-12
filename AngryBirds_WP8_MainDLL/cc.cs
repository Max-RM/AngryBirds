using Innogiant;
using Microsoft.Xna.Framework;

internal class cc
{
	private ObjectPool<Vector2> m_a;

	private ObjectPool<Vector2> m_b;

	private ae[] c;

	private ae d;

	public cc()
	{
		this.m_a = new ObjectPool<Vector2>(500);
		this.m_b = new ObjectPool<Vector2>(10);
		c = new ae[3];
		c[0] = u.a().g("TRAIL_WHITE_1");
		c[1] = u.a().g("TRAIL_WHITE_2");
		c[2] = u.a().g("TRAIL_WHITE_3");
		d = u.a().g("BIRD_SPECIAL");
	}

	public void b(Vector2 A_0)
	{
		ObjectPool<Vector2>.Node node = this.m_a.Alloc();
		node.Object.X = A_0.X;
		node.Object.Y = A_0.Y;
	}

	public void a(Vector2 A_0)
	{
		ObjectPool<Vector2>.Node node = this.m_b.Alloc();
		node.Object.X = A_0.X;
		node.Object.Y = A_0.Y;
	}

	public void a(n A_0)
	{
		bu bu2 = bu.b();
		int num = 0;
		int capacity = this.m_a._capacity;
		for (int num2 = 0; num2 < capacity; num2++)
		{
			ObjectPool<Vector2>.Node node = this.m_a._nodes[num2];
			if (this.m_a._activeNodes[node.Index])
			{
				float A_ = node.Object.X;
				float A_2 = node.Object.Y;
				A_0.f(ref A_, ref A_2);
				bu2.b(c[num], A_, A_2, A_0.m(), A_0.m());
				num++;
				num %= 3;
			}
		}
		int capacity2 = this.m_b._capacity;
		for (int num3 = 0; num3 < capacity2; num3++)
		{
			ObjectPool<Vector2>.Node node2 = this.m_b._nodes[num3];
			if (this.m_b._activeNodes[node2.Index])
			{
				float A_3 = node2.Object.X;
				float A_4 = node2.Object.Y;
				A_0.f(ref A_3, ref A_4);
				bu2.b(d, A_3, A_4, A_0.m(), A_0.m());
			}
		}
	}
}
