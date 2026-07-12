using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class World
{
	private static Color m_a = new Color(0.5f, 0.5f, 0.3f);

	private static Color b = new Color(0.5f, 0.9f, 0.5f);

	private static Color c = new Color(0.5f, 0.5f, 0.9f);

	private static Color d = new Color(0.6f, 0.6f, 0.6f);

	private static Color e = new Color(0.9f, 0.7f, 0.7f);

	private Func<FixtureProxy, bool> f;

	private Func<short, bool> g;

	private RayCastCallback h;

	private am i;

	public bool ContinuousPhysics;

	private ab j = new ab();

	private Contact[] k = new Contact[32];

	internal dl l = new dl();

	internal WorldFlags m;

	internal ContactManager n = new ContactManager();

	internal static int o = 300;

	internal Queue<Contact> p = new Queue<Contact>(o);

	internal Body q;

	internal Joint r;

	internal int s;

	internal int t;

	internal bool u;

	internal float v;

	private Body[] w = new Body[64];

	[CompilerGenerated]
	private IDestructionListener x;

	[CompilerGenerated]
	private DebugDraw y;

	[CompilerGenerated]
	private bool z;

	[CompilerGenerated]
	private bool aa;

	[CompilerGenerated]
	private Vector2 ab;

	public IDestructionListener DestructionListener
	{
		[CompilerGenerated]
		get
		{
			return x;
		}
		[CompilerGenerated]
		set
		{
			x = value;
		}
	}

	public IContactFilter ContactFilter
	{
		get
		{
			return n.ContactFilter;
		}
		set
		{
			n.ContactFilter = value;
		}
	}

	public IContactListener ContactListener
	{
		get
		{
			return n.ContactListener;
		}
		set
		{
			n.ContactListener = value;
		}
	}

	public DebugDraw DebugDraw
	{
		[CompilerGenerated]
		get
		{
			return y;
		}
		[CompilerGenerated]
		set
		{
			y = value;
		}
	}

	public bool WarmStarting
	{
		[CompilerGenerated]
		get
		{
			return z;
		}
		[CompilerGenerated]
		set
		{
			z = value;
		}
	}

	public bool ForceWakeUp
	{
		[CompilerGenerated]
		get
		{
			return aa;
		}
		[CompilerGenerated]
		set
		{
			aa = value;
		}
	}

	public int ProxyCount => n._broadPhase.ProxyCount;

	public int BodyCount => s;

	public int JointCount => t;

	public int ContactCount => n._contactCount;

	public Vector2 Gravity
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ab;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			ab = value;
		}
	}

	public bool IsLocked
	{
		get
		{
			return (m & WorldFlags.Locked) == WorldFlags.Locked;
		}
		set
		{
			if (value)
			{
				m |= WorldFlags.Locked;
			}
			else
			{
				m &= ~WorldFlags.Locked;
			}
		}
	}

	public World(Vector2 gravity, bool doSleep)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		WarmStarting = true;
		ContinuousPhysics = true;
		u = doSleep;
		Gravity = gravity;
		m = WorldFlags.ClearForces;
		g = M_a;
		i = M_a;
	}

	public Body CreateBody(BodyDef def)
	{
		if (IsLocked)
		{
			return null;
		}
		Body body = new Body(def, this);
		body.k = null;
		body.l = q;
		if (q != null)
		{
			q.k = body;
		}
		q = body;
		s++;
		return body;
	}

	public void DestroyBody(Body b)
	{
		if (IsLocked)
		{
			return;
		}
		JointEdge next = b.o;
		while (next != null)
		{
			JointEdge jointEdge = next;
			next = next.Next;
			if (DestructionListener != null)
			{
				DestructionListener.SayGoodbye(jointEdge.Joint);
			}
			DestroyJoint(jointEdge.Joint);
		}
		b.o = null;
		ContactEdge next2 = b.p;
		while (next2 != null)
		{
			ContactEdge contactEdge = next2;
			next2 = next2.Next;
			n.M_a(contactEdge.Contact);
		}
		b.p = null;
		Fixture fixture = b.m;
		while (fixture != null)
		{
			Fixture fixture2 = fixture;
			fixture = fixture.d;
			if (DestructionListener != null)
			{
				DestructionListener.SayGoodbye(fixture2);
			}
			fixture2.M_a(n._broadPhase);
			fixture2.M_a();
		}
		b.m = null;
		b.n = 0;
		if (b.k != null)
		{
			b.k.l = b.l;
		}
		if (b.l != null)
		{
			b.l.k = b.k;
		}
		if (b == q)
		{
			q = b.l;
		}
		s--;
	}

	public Joint CreateJoint(JointDef def)
	{
		if (IsLocked)
		{
			return null;
		}
		Joint joint = Joint.M_a(def);
		joint.b = null;
		joint.c = r;
		if (r != null)
		{
			r.b = joint;
		}
		r = joint;
		t++;
		joint.d.Joint = joint;
		joint.d.Other = joint.g;
		joint.d.Prev = null;
		joint.d.Next = joint.f.o;
		if (joint.f.o != null)
		{
			joint.f.o.Prev = joint.d;
		}
		joint.f.o = joint.d;
		joint.e.Joint = joint;
		joint.e.Other = joint.f;
		joint.e.Prev = null;
		joint.e.Next = joint.g.o;
		if (joint.g.o != null)
		{
			joint.g.o.Prev = joint.e;
		}
		joint.g.o = joint.e;
		Body bodyA = def.bodyA;
		Body bodyB = def.bodyB;
		bodyA.GetType();
		bodyB.GetType();
		if (!def.collideConnected)
		{
			for (ContactEdge contactEdge = bodyB.GetContactList(); contactEdge != null; contactEdge = contactEdge.Next)
			{
				if (contactEdge.Other == bodyA)
				{
					contactEdge.Contact.FlagForFiltering();
				}
			}
		}
		return joint;
	}

	public void DestroyJoint(Joint j)
	{
		if (IsLocked)
		{
			return;
		}
		bool flag = j.i;
		if (j.b != null)
		{
			j.b.c = j.c;
		}
		if (j.c != null)
		{
			j.c.b = j.b;
		}
		if (j == r)
		{
			r = j.c;
		}
		Body body = j.f;
		Body body2 = j.g;
		body.SetAwake(flag: true);
		body2.SetAwake(flag: true);
		if (j.d.Prev != null)
		{
			j.d.Prev.Next = j.d.Next;
		}
		if (j.d.Next != null)
		{
			j.d.Next.Prev = j.d.Prev;
		}
		if (j.d == body.o)
		{
			body.o = j.d.Next;
		}
		j.d.Prev = null;
		j.d.Next = null;
		if (j.e.Prev != null)
		{
			j.e.Prev.Next = j.e.Next;
		}
		if (j.e.Next != null)
		{
			j.e.Next.Prev = j.e.Prev;
		}
		if (j.e == body2.o)
		{
			body2.o = j.e.Next;
		}
		j.e.Prev = null;
		j.e.Next = null;
		t--;
		if (flag)
		{
			return;
		}
		for (ContactEdge contactEdge = body2.GetContactList(); contactEdge != null; contactEdge = contactEdge.Next)
		{
			if (contactEdge.Other == body)
			{
				contactEdge.Contact.FlagForFiltering();
			}
		}
	}

	public void Step(float dt, int velocityIterations, int positionIterations)
	{
		if ((m & WorldFlags.NewFixture) == WorldFlags.NewFixture)
		{
			n.M_c();
			m &= ~WorldFlags.NewFixture;
		}
		m |= WorldFlags.Locked;
		TimeStep A_ = default(TimeStep);
		A_.dt = dt;
		A_.velocityIterations = velocityIterations;
		A_.positionIterations = positionIterations;
		if (dt > 0f)
		{
			A_.inv_dt = 1f / dt;
		}
		else
		{
			A_.inv_dt = 0f;
		}
		A_.dtRatio = v * dt;
		A_.warmStarting = WarmStarting;
		n.M_b();
		bool flag = A_.dt > 0f;
		if (flag)
		{
			M_a(ref A_);
		}
		if (ContinuousPhysics && flag)
		{
			M_a();
		}
		if (flag)
		{
			v = A_.inv_dt;
		}
		if ((m & WorldFlags.ClearForces) != 0)
		{
			ClearForces();
		}
		m &= ~WorldFlags.Locked;
	}

	public void ClearForces()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		for (Body next = q; next != null; next = next.GetNext())
		{
			next.h = Vector2.Zero;
			next.i = 0f;
		}
	}

	public ContactManager GetContactManager()
	{
		return n;
	}

	public void DrawDebugData()
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		if (DebugDraw == null)
		{
			return;
		}
		DebugDrawFlags flags = DebugDraw.Flags;
		if ((flags & DebugDrawFlags.Shape) == DebugDrawFlags.Shape)
		{
			for (Body next = q; next != null; next = next.GetNext())
			{
				for (Fixture fixture = next.GetFixtureList(); fixture != null; fixture = fixture.GetNext())
				{
					if (!next.IsActive())
					{
						M_a(fixture, next.d, World.m_a);
					}
					else if (next.GetType() == BodyType.Static)
					{
						M_a(fixture, next.d, b);
					}
					else if (next.GetType() == BodyType.Kinematic)
					{
						M_a(fixture, next.d, c);
					}
					else if (!next.IsAwake())
					{
						M_a(fixture, next.d, d);
					}
					else
					{
						M_a(fixture, next.d, e);
					}
				}
			}
		}
		if ((flags & DebugDrawFlags.Joint) == DebugDrawFlags.Joint)
		{
			for (Joint next2 = r; next2 != null; next2 = next2.GetNext())
			{
				M_a(next2);
			}
		}
		if ((flags & DebugDrawFlags.Pair) == DebugDrawFlags.Pair)
		{
			new Color(0.3f, 0.9f, 0.9f);
			for (Contact contact = n._contacts; contact != null; contact = contact.f)
			{
			}
		}
		if ((flags & DebugDrawFlags.AABB) == DebugDrawFlags.AABB)
		{
			Color color = default(Color);
			color = new Color(0.9f, 0.3f, 0.9f);
			BroadPhase broadPhase = n._broadPhase;
			for (Body next3 = q; next3 != null; next3 = next3.GetNext())
			{
				if (next3.IsActive())
				{
					for (Fixture fixture2 = next3.GetFixtureList(); fixture2 != null; fixture2 = fixture2.GetNext())
					{
						for (int i = 0; i < fixture2.b; i++)
						{
							FixtureProxy fixtureProxy = fixture2.a[i];
							broadPhase.GetFatAABB(fixtureProxy.proxyId, out var aabb);
							FixedArray8<Vector2> vertices = default(FixedArray8<Vector2>);
							vertices[0] = new Vector2(aabb.lowerBound.X, aabb.lowerBound.Y);
							vertices[1] = new Vector2(aabb.upperBound.X, aabb.lowerBound.Y);
							vertices[2] = new Vector2(aabb.upperBound.X, aabb.upperBound.Y);
							vertices[3] = new Vector2(aabb.lowerBound.X, aabb.upperBound.Y);
							DebugDraw.DrawPolygon(ref vertices, 4, color);
						}
					}
				}
			}
		}
		if ((flags & DebugDrawFlags.CenterOfMass) == DebugDrawFlags.CenterOfMass)
		{
			for (Body next4 = q; next4 != null; next4 = next4.GetNext())
			{
				Transform xf = next4.d;
				xf.Position = next4.e.c;
				DebugDraw.DrawTransform(ref xf);
			}
		}
	}

	public void QueryAABB(Func<FixtureProxy, bool> callback, ref AABB aabb)
	{
		f = callback;
		n._broadPhase.Query(g, ref aabb);
		f = null;
	}

	private bool M_a(short A_0)
	{
		FixtureProxy fixtureProxy = (FixtureProxy)n._broadPhase.GetUserData(A_0);
		return f.Invoke(fixtureProxy);
	}

	public void RayCast(RayCastCallback callback, Vector2 point1, Vector2 point2)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		RayCastInput A_ = default(RayCastInput);
		A_.maxFraction = 1f;
		A_.p1 = point1;
		A_.p2 = point2;
		h = callback;
		n._broadPhase.M_a(i, ref A_);
		h = null;
	}

	private float M_a(ref RayCastInput A_0, int A_1)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		object userData = n._broadPhase.GetUserData(A_1);
		FixtureProxy fixtureProxy = (FixtureProxy)userData;
		Fixture fixture = fixtureProxy.fixture;
		int childIndex = fixtureProxy.childIndex;
		if (fixture.RayCast(out var output, ref A_0, childIndex))
		{
			float fraction = output.fraction;
			Vector2 point = (1f - fraction) * A_0.p1 + fraction * A_0.p2;
			return h(fixture, point, output.normal, fraction);
		}
		return A_0.maxFraction;
	}

	public Body GetBodyList()
	{
		return q;
	}

	public Joint GetJointList()
	{
		return r;
	}

	public Contact GetContactList()
	{
		return n._contacts;
	}

	private void M_a(ref TimeStep A_0)
	{
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		l.a(s, n._contactCount, t, n.ContactListener);
		for (Body body = q; body != null; body = body.l)
		{
			body.a &= ~BodyFlags.Island;
		}
		for (Contact contact = n._contacts; contact != null; contact = contact.f)
		{
			contact.d &= ~ContactFlags.Island;
		}
		for (Joint joint = r; joint != null; joint = joint.c)
		{
			joint.h = false;
		}
		int num = s;
		if (num > w.Length)
		{
			w = new Body[Math.Max(w.Length * 2, num)];
		}
		for (Body body2 = q; body2 != null; body2 = body2.l)
		{
			if ((body2.a & BodyFlags.Island) == 0 && body2.IsAwake() && body2.IsActive() && body2.GetType() != 0)
			{
				l.a();
				int num2 = 0;
				w[num2++] = body2;
				body2.a |= BodyFlags.Island;
				while (num2 > 0)
				{
					Body body3 = w[--num2];
					l.a(body3);
					if (!body3.IsAwake())
					{
						body3.SetAwake(flag: true);
					}
					if (body3.GetType() == BodyType.Static)
					{
						continue;
					}
					for (ContactEdge next = body3.p; next != null; next = next.Next)
					{
						Contact contact2 = next.Contact;
						if ((contact2.d & ContactFlags.Island) == 0 && (next.Contact.d & ContactFlags.Enabled) == ContactFlags.Enabled && (next.Contact.d & ContactFlags.Touching) == ContactFlags.Touching)
						{
							bool flag = contact2.i.k;
							bool flag2 = contact2.j.k;
							if (!flag && !flag2)
							{
								l.a(contact2);
								contact2.d |= ContactFlags.Island;
								Body other = next.Other;
								if ((other.a & BodyFlags.Island) == 0)
								{
									w[num2++] = other;
									other.a |= BodyFlags.Island;
								}
							}
						}
					}
					for (JointEdge next2 = body3.o; next2 != null; next2 = next2.Next)
					{
						if (!next2.Joint.h)
						{
							Body other2 = next2.Other;
							if (other2.IsActive())
							{
								l.a(next2.Joint);
								next2.Joint.h = true;
								if ((other2.a & BodyFlags.Island) == 0)
								{
									w[num2++] = other2;
									other2.a |= BodyFlags.Island;
								}
							}
						}
					}
				}
				l.a(ref A_0, Gravity, u);
				for (int i = 0; i < l.f; i++)
				{
					Body body4 = l.c[i];
					if (body4.GetType() == BodyType.Static)
					{
						body4.a &= ~BodyFlags.Island;
					}
				}
			}
		}
		for (Body next3 = q; next3 != null; next3 = next3.GetNext())
		{
			if ((next3.a & BodyFlags.Island) == BodyFlags.Island && next3.GetType() != 0)
			{
				next3.M_b();
			}
		}
		n.M_c();
	}

	private void M_a(Body A_0)
	{
		Contact contact = null;
		float num = 1f;
		Body body = null;
		int num2 = 0;
		bool isBullet = A_0.IsBullet;
		if (ForceWakeUp)
		{
			for (ContactEdge next = A_0.p; next != null; next = next.Next)
			{
				if ((next.Contact.i.e.a & BodyFlags.Awake) == 0)
				{
					next.Contact.i.e.a |= BodyFlags.Awake;
					next.Contact.i.e.w = 0f;
				}
				if ((next.Contact.j.e.a & BodyFlags.Awake) == 0)
				{
					next.Contact.j.e.a |= BodyFlags.Awake;
					next.Contact.j.e.w = 0f;
				}
			}
		}
		bool flag;
		int num3;
		do
		{
			num3 = 0;
			flag = false;
			for (ContactEdge next2 = A_0.p; next2 != null; next2 = next2.Next)
			{
				if (next2.Contact == contact)
				{
					continue;
				}
				Body other = next2.Other;
				BodyType type = other.GetType();
				if (isBullet)
				{
					if ((other.a & BodyFlags.Toi) == 0 || (type != 0 && (next2.Contact.d & ContactFlags.BulletHit) != 0))
					{
						continue;
					}
				}
				else if (type == BodyType.Dynamic)
				{
					continue;
				}
				Contact contact2 = next2.Contact;
				if ((contact2.d & ContactFlags.Enabled) != ContactFlags.Enabled || contact2.n > 10)
				{
					continue;
				}
				Fixture fixture = contact2.i;
				Fixture fixture2 = contact2.j;
				int index = contact2.k;
				int index2 = contact2.l;
				if (!fixture.k && !fixture2.k)
				{
					Body body2 = fixture.e;
					Body body3 = fixture2.e;
					TOIInput input = default(TOIInput);
					input.proxyA.Set(fixture.f, index);
					input.proxyB.Set(fixture2.f, index2);
					input.sweepA = body2.e;
					input.sweepB = body3.e;
					input.tMax = num;
					TimeOfImpact.CalculateTimeOfImpact(out var output, ref input);
					if (output.State == TOIOutputState.Touching && output.t < num)
					{
						contact = contact2;
						num = output.t;
						body = other;
						flag = true;
					}
					num3++;
				}
			}
			num2++;
		}
		while (flag && num3 > 1 && num2 < 50);
		if (contact == null)
		{
			A_0.M_a(1f);
			return;
		}
		Sweep sweep = A_0.e;
		A_0.M_a(num);
		contact.M_a(n.ContactListener);
		if ((contact.d & ContactFlags.Enabled) != ContactFlags.Enabled)
		{
			A_0.e = sweep;
			M_a(A_0);
		}
		contact.n++;
		num3 = 0;
		ContactEdge next3 = A_0.p;
		while (next3 != null && num3 < 32)
		{
			Body other2 = next3.Other;
			BodyType type2 = other2.GetType();
			if (type2 != BodyType.Dynamic)
			{
				Contact contact3 = next3.Contact;
				if ((contact3.d & ContactFlags.Enabled) == ContactFlags.Enabled)
				{
					Fixture fixture3 = contact3.i;
					Fixture fixture4 = contact3.j;
					if (!fixture3.k && !fixture4.k)
					{
						if (contact3 != contact)
						{
							contact3.M_a(n.ContactListener);
						}
						if ((contact3.d & (ContactFlags.Touching | ContactFlags.Enabled)) == (ContactFlags.Touching | ContactFlags.Enabled))
						{
							k[num3] = contact3;
							num3++;
						}
					}
				}
			}
			next3 = next3.Next;
		}
		j.a(k, num3, A_0);
		float a_ = 0.75f;
		for (int i = 0; i < 20; i++)
		{
			if (j.a(a_))
			{
				break;
			}
		}
		if (body.GetType() != 0)
		{
			contact.d |= ContactFlags.BulletHit;
		}
	}

	private void M_a()
	{
		for (Contact contact = n._contacts; contact != null; contact = contact.f)
		{
			contact.d |= ContactFlags.Enabled;
			contact.n = 0;
		}
		for (Body body = q; body != null; body = body.l)
		{
			if ((body.a & BodyFlags.Island) == 0 || body.GetType() == BodyType.Kinematic || body.GetType() == BodyType.Static)
			{
				body.a |= BodyFlags.Toi;
			}
			else
			{
				body.a &= ~BodyFlags.Toi;
			}
		}
		for (Body body2 = q; body2 != null; body2 = body2.l)
		{
			if ((body2.a & BodyFlags.Toi) == 0 && !body2.IsBullet)
			{
				M_a(body2);
				body2.a |= BodyFlags.Toi;
			}
		}
		for (Body body3 = q; body3 != null; body3 = body3.l)
		{
			if ((body3.a & BodyFlags.Toi) == 0 && body3.IsBullet)
			{
				M_a(body3);
				body3.a |= BodyFlags.Toi;
			}
		}
	}

	private void M_a(Joint A_0)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		Body bodyA = A_0.GetBodyA();
		Body bodyB = A_0.GetBodyB();
		Vector2 position = bodyA.d.Position;
		Vector2 position2 = bodyB.d.Position;
		Vector2 anchorA = A_0.GetAnchorA();
		Vector2 anchorB = A_0.GetAnchorB();
		Color color = default(Color);
		color = new Color(0.5f, 0.8f, 0.8f);
		switch (A_0.JointType)
		{
		case JointType.Distance:
			DebugDraw.DrawSegment(anchorA, anchorB, color);
			break;
		case JointType.Pulley:
		{
			PulleyJoint pulleyJoint = (PulleyJoint)A_0;
			Vector2 groundAnchorA = pulleyJoint.GetGroundAnchorA();
			Vector2 groundAnchorB = pulleyJoint.GetGroundAnchorB();
			DebugDraw.DrawSegment(groundAnchorA, anchorA, color);
			DebugDraw.DrawSegment(groundAnchorB, anchorB, color);
			DebugDraw.DrawSegment(groundAnchorA, groundAnchorB, color);
			break;
		}
		default:
			DebugDraw.DrawSegment(position, anchorA, color);
			DebugDraw.DrawSegment(anchorA, anchorB, color);
			DebugDraw.DrawSegment(position2, anchorB, color);
			break;
		case JointType.Mouse:
			break;
		}
	}

	private void M_a(Fixture A_0, Transform A_1, Color A_2)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		switch (A_0.f.ShapeType)
		{
		case ShapeType.Circle:
		{
			CircleShape circleShape = (CircleShape)A_0.f;
			Vector2 center = MathUtils.Multiply(ref A_1, circleShape._p);
			float radius = circleShape._radius;
			Vector2 col = A_1.R.col1;
			DebugDraw.DrawSolidCircle(center, radius, col, A_2);
			break;
		}
		case ShapeType.Polygon:
		{
			PolygonShape polygonShape = (PolygonShape)A_0.f;
			int vertexCount = polygonShape._vertexCount;
			FixedArray8<Vector2> vertices = default(FixedArray8<Vector2>);
			for (int j = 0; j < vertexCount; j++)
			{
				vertices[j] = MathUtils.Multiply(ref A_1, polygonShape._vertices[j]);
			}
			DebugDraw.DrawSolidPolygon(ref vertices, vertexCount, A_2);
			break;
		}
		case ShapeType.Edge:
		{
			EdgeShape edgeShape = (EdgeShape)A_0.f;
			Vector2 p2 = MathUtils.Multiply(ref A_1, edgeShape._vertex1);
			Vector2 p3 = MathUtils.Multiply(ref A_1, edgeShape._vertex2);
			DebugDraw.DrawSegment(p2, p3, A_2);
			break;
		}
		case ShapeType.Loop:
		{
			LoopShape loopShape = (LoopShape)A_0.f;
			int count = loopShape._count;
			Vector2 p = MathUtils.Multiply(ref A_1, loopShape._vertices[count - 1]);
			for (int i = 0; i < count; i++)
			{
				Vector2 val = MathUtils.Multiply(ref A_1, loopShape._vertices[i]);
				DebugDraw.DrawSegment(p, val, A_2);
				p = val;
			}
			break;
		}
		}
	}
}
