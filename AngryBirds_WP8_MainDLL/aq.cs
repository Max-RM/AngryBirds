using System.Runtime.CompilerServices;
using Innogiant;
using Microsoft.Xna.Framework;

internal class aq
{
	private ObjectPool<dd> m_a;

	[CompilerGenerated]
	private co b;

	[CompilerGenerated]
	private n m_c;

	[SpecialName]
	[CompilerGenerated]
	private co a()
	{
		return b;
	}

	[SpecialName]
	[CompilerGenerated]
	private void a(co A_0)
	{
		b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public n d()
	{
		return this.m_c;
	}

	[SpecialName]
	[CompilerGenerated]
	public void a(n A_0)
	{
		this.m_c = A_0;
	}

	public aq()
	{
		this.m_a = new ObjectPool<dd>(500);
		a(u.a().h("FONT_SCORE_N900.dat"));
	}

	public void a(float A_0)
	{
		int capacity = this.m_a._capacity;
		for (int num = 0; num < capacity; num++)
		{
			ObjectPool<dd>.Node node = this.m_a._nodes[num];
			if (this.m_a._activeNodes[node.Index])
			{
				dd @object = node.Object;
				@object.c += A_0;
				if (@object.c < 0.25f)
				{
					@object.f = @object.e * @object.c / 0.25f;
				}
				else if (@object.c < @object.d - 0.25f)
				{
					@object.f = @object.e;
				}
				else
				{
					@object.f = @object.e * (@object.d - @object.c) / 0.25f;
				}
				if (@object.c > @object.d)
				{
					this.m_a.Free(node);
				}
			}
		}
	}

	public void e()
	{
		foreach (ObjectPool<dd>.Node activeNode in this.m_a.ActiveNodes)
		{
			this.m_a.Free(activeNode);
		}
	}

	public void c()
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		int capacity = this.m_a._capacity;
		for (int num = 0; num < capacity; num++)
		{
			ObjectPool<dd>.Node node = this.m_a._nodes[num];
			if (this.m_a._activeNodes[node.Index])
			{
				dd @object = node.Object;
				if (@object.b != null)
				{
					float A_ = @object.a.X;
					float A_2 = @object.a.Y;
					d().f(ref A_, ref A_2);
					A_2 -= (float)@object.b.f;
					bu.b().b(@object.b, A_, A_2, @object.f, @object.f);
				}
				else if (@object.g != null)
				{
					Vector2 A_3 = new Vector2(@object.a.X, @object.a.Y);
					d().g(ref A_3);
					a().a(@object.g.ToString(), A_3, new a7(bn.b, dh.c), @object.f, @object.f);
				}
			}
		}
	}

	public void a(float A_0, float A_1, ae A_2, float A_3, float A_4, float A_5, float A_6)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (this.m_a.Count > 0)
		{
			ObjectPool<dd>.Node node = this.m_a.Alloc();
			node.Object.a = new Vector2(A_0, A_1);
			node.Object.b = A_2;
			node.Object.g = null;
			node.Object.c = A_3;
			node.Object.d = A_4;
			node.Object.e = A_5;
			node.Object.f = A_6;
		}
	}

	public void a(float A_0, float A_1, string A_2, float A_3, float A_4, float A_5, float A_6)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (this.m_a.Count > 0)
		{
			ObjectPool<dd>.Node node = this.m_a.Alloc();
			node.Object.a = new Vector2(A_0, A_1);
			node.Object.b = null;
			node.Object.g = A_2;
			node.Object.c = A_3;
			node.Object.d = A_4;
			node.Object.e = A_5;
			node.Object.f = A_6;
		}
	}
}
