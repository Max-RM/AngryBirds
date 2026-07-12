using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class Fixture
{
	internal FixtureProxy[] a;

	internal int b;

	internal float c;

	internal Fixture d;

	internal Body e;

	internal Shape f;

	internal float g;

	internal float h;

	internal int i;

	internal Filter j;

	internal bool k;

	internal object l;

	public void SetFilterData(ref Filter filter)
	{
		j = filter;
		if (e == null)
		{
			return;
		}
		for (ContactEdge contactEdge = e.GetContactList(); contactEdge != null; contactEdge = contactEdge.Next)
		{
			Contact contact = contactEdge.Contact;
			Fixture fixture = contact.i;
			Fixture fixture2 = contact.j;
			if (fixture == this || fixture2 == this)
			{
				contact.FlagForFiltering();
			}
		}
	}

	public void GetFilterData(out Filter filter)
	{
		filter = j;
	}

	public Fixture GetNext()
	{
		return d;
	}

	public object GetUserData()
	{
		return l;
	}

	public void SetUserData(object data)
	{
		l = data;
	}

	public void SetDensity(float density)
	{
		c = density;
	}

	public float GetDensity()
	{
		return c;
	}

	public bool TestPoint(Vector2 p)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return f.TestPoint(ref e.d, p);
	}

	public bool RayCast(out RayCastOutput output, ref RayCastInput input, int childIndex)
	{
		return f.RayCast(out output, ref input, ref e.d, childIndex);
	}

	public void GetMassData(out MassData massData)
	{
		f.ComputeMass(out massData, c);
	}

	public void SetFriction(float friction)
	{
		g = friction;
	}

	public void SetRestitution(float restitution)
	{
		h = restitution;
	}

	public void GetAABB(out AABB aabb, int childIndex)
	{
		aabb = this.a[childIndex].aabb;
	}

	internal Fixture()
	{
		l = null;
		e = null;
		d = null;
		i = -1;
		f = null;
	}

	internal void M_a(Body A_0, FixtureDef A_1)
	{
		l = A_1.userData;
		g = A_1.friction;
		h = A_1.restitution;
		e = A_0;
		d = null;
		j = A_1.filter;
		k = A_1.isSensor;
		f = A_1.shape.Clone();
		int childCount = f.GetChildCount();
		this.a = new FixtureProxy[childCount];
		for (int i = 0; i < childCount; i++)
		{
			this.a[i] = new FixtureProxy();
			this.a[i].fixture = null;
			this.a[i].proxyId = -1;
		}
		b = 0;
		c = A_1.density;
	}

	internal void M_a()
	{
		this.a = null;
		f = null;
	}

	internal void M_a(BroadPhase A_0, ref Transform A_1)
	{
		b = f.GetChildCount();
		for (int i = 0; i < b; i++)
		{
			FixtureProxy fixtureProxy = this.a[i];
			f.ComputeAABB(out fixtureProxy.aabb, ref A_1, i);
			fixtureProxy.fixture = this;
			fixtureProxy.childIndex = i;
			fixtureProxy.proxyId = A_0.CreateProxy(ref fixtureProxy.aabb, fixtureProxy);
			this.a[i] = fixtureProxy;
		}
	}

	internal void M_a(BroadPhase A_0)
	{
		for (int i = 0; i < b; i++)
		{
			A_0.DestroyProxy(this.a[i].proxyId);
			this.a[i].proxyId = -1;
		}
		b = 0;
	}

	internal void M_a(BroadPhase A_0, ref Transform A_1, ref Transform A_2)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (b != 0)
		{
			for (int i = 0; i < b; i++)
			{
				FixtureProxy fixtureProxy = this.a[i];
				f.ComputeAABB(out var aabb, ref A_1, fixtureProxy.childIndex);
				f.ComputeAABB(out var aabb2, ref A_2, fixtureProxy.childIndex);
				fixtureProxy.aabb.Combine(ref aabb, ref aabb2);
				Vector2 displacement = A_2.Position - A_1.Position;
				A_0.MoveProxy(fixtureProxy.proxyId, ref fixtureProxy.aabb, displacement);
			}
		}
	}
}
