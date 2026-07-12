using System;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class Body
{
	internal BodyFlags a;

	internal BodyType b;

	internal int c;

	internal Transform d;

	internal Sweep e;

	internal Vector2 f;

	internal float g;

	internal Vector2 h;

	internal float i;

	internal World j;

	internal Body k;

	internal Body l;

	internal Fixture m;

	internal int n;

	internal JointEdge o;

	internal ContactEdge p;

	internal float q;

	internal float r;

	internal float s;

	internal float t;

	internal float u;

	internal float v;

	internal float w;

	internal object x;

	public bool IsBullet => (this.a & BodyFlags.Bullet) == BodyFlags.Bullet;

	public bool IsSleepingAllowed => (this.a & BodyFlags.AutoSleep) == BodyFlags.AutoSleep;

	public Vector2 Position
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return d.Position;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			SetTransform(value, Rotation);
		}
	}

	public float Rotation
	{
		get
		{
			return e.a;
		}
		set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			SetTransform(Position, value);
		}
	}

	public void SetType(BodyType type)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (this.b != type)
		{
			this.b = type;
			ResetMassData();
			if (this.b == BodyType.Static)
			{
				f = Vector2.Zero;
				g = 0f;
			}
			SetAwake(flag: true);
			h = Vector2.Zero;
			i = 0f;
			for (ContactEdge next = p; next != null; next = next.Next)
			{
				next.Contact.FlagForFiltering();
			}
		}
	}

	public new BodyType GetType()
	{
		return this.b;
	}

	public Fixture CreateFixture(FixtureDef def)
	{
		if (j.IsLocked)
		{
			return null;
		}
		Fixture fixture = new Fixture();
		fixture.M_a(this, def);
		if ((this.a & BodyFlags.Active) == BodyFlags.Active)
		{
			BroadPhase a_ = j.n._broadPhase;
			fixture.M_a(a_, ref d);
		}
		fixture.d = m;
		m = fixture;
		n++;
		fixture.e = this;
		if (fixture.c > 0f)
		{
			ResetMassData();
		}
		j.m |= WorldFlags.NewFixture;
		return fixture;
	}

	public Fixture CreateFixture(Shape shape, float density)
	{
		FixtureDef fixtureDef = new FixtureDef();
		fixtureDef.shape = shape;
		fixtureDef.density = density;
		return CreateFixture(fixtureDef);
	}

	public void DestroyFixture(Fixture fixture)
	{
		if (j.IsLocked)
		{
			return;
		}
		for (Fixture fixture2 = m; fixture2 != null; fixture2 = fixture2.d)
		{
			if (fixture2 == fixture)
			{
				m = fixture.d;
				break;
			}
		}
		ContactEdge next = p;
		while (next != null)
		{
			Contact contact = next.Contact;
			next = next.Next;
			Fixture fixture3 = contact.i;
			Fixture fixture4 = contact.j;
			if (fixture == fixture3 || fixture == fixture4)
			{
				j.n.M_a(contact);
			}
		}
		if ((this.a & BodyFlags.Active) == BodyFlags.Active)
		{
			BroadPhase a_ = j.n._broadPhase;
			fixture.M_a(a_);
		}
		fixture.M_a();
		fixture.e = null;
		fixture.d = null;
		n--;
		ResetMassData();
	}

	public void SetTransform(Vector2 position, float angle)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (!j.IsLocked)
		{
			d.R.Set(angle);
			d.Position = position;
			e.c0 = (e.c = MathUtils.Multiply(ref d, e.localCenter));
			e.a0 = (e.a = angle);
			BroadPhase a_ = j.n._broadPhase;
			for (Fixture fixture = m; fixture != null; fixture = fixture.d)
			{
				fixture.M_a(a_, ref d, ref d);
			}
			j.n.M_c();
		}
	}

	public void SetTransformIgnoreContacts(Vector2 position, float angle)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (!j.IsLocked)
		{
			d.R.Set(angle);
			d.Position = position;
			e.c0 = (e.c = MathUtils.Multiply(ref d, e.localCenter));
			e.a0 = (e.a = angle);
			BroadPhase a_ = j.n._broadPhase;
			for (Fixture fixture = m; fixture != null; fixture = fixture.d)
			{
				fixture.M_a(a_, ref d, ref d);
			}
		}
	}

	public void SetLinearVelocity(Vector2 v)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (this.b != 0)
		{
			if (!IsAwake() && Vector2.Dot(v, v) > 0f)
			{
				SetAwake(flag: true);
			}
			f = v;
		}
	}

	public Vector2 GetLinearVelocity()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return f;
	}

	public void SetAngularVelocity(float w)
	{
		if (this.b != 0)
		{
			if (w * w > 0f)
			{
				SetAwake(flag: true);
			}
			g = w;
		}
	}

	public float GetAngularVelocity()
	{
		return g;
	}

	public void ApplyForce(Vector2 force, Vector2 point)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (this.b == BodyType.Dynamic)
		{
			if (!IsAwake())
			{
				SetAwake(flag: true);
			}
			h += force;
			i += MathUtils.Cross(point - e.c, force);
		}
	}

	public void ApplyTorque(float torque)
	{
		if (this.b == BodyType.Dynamic)
		{
			if (!IsAwake())
			{
				SetAwake(flag: true);
			}
			i += torque;
		}
	}

	public void ApplyLinearImpulse(Vector2 impulse, Vector2 point)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (this.b == BodyType.Dynamic)
		{
			if (!IsAwake())
			{
				SetAwake(flag: true);
			}
			f += r * impulse;
			g += t * MathUtils.Cross(point - e.c, impulse);
		}
	}

	public void ApplyAngularImpulse(float impulse)
	{
		if (this.b == BodyType.Dynamic)
		{
			if (!IsAwake())
			{
				SetAwake(flag: true);
			}
			g += t * impulse;
		}
	}

	public float GetMass()
	{
		return q;
	}

	public float GetInertia()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return s + q * Vector2.Dot(e.localCenter, e.localCenter);
	}

	public void GetMassData(out MassData massData)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		massData = default(MassData);
		massData.mass = q;
		massData.I = s + q * Vector2.Dot(e.localCenter, e.localCenter);
		massData.center = e.localCenter;
	}

	public void SetMassData(ref MassData massData)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if (!j.IsLocked && this.b == BodyType.Dynamic)
		{
			r = 0f;
			s = 0f;
			t = 0f;
			q = massData.mass;
			if (q <= 0f)
			{
				q = 1f;
			}
			r = 1f / q;
			if (massData.I > 0f && (this.a & BodyFlags.FixedRotation) == 0)
			{
				s = massData.I - q * Vector2.Dot(massData.center, massData.center);
				t = 1f / s;
			}
			Vector2 val = e.c;
			e.localCenter = massData.center;
			e.c0 = (e.c = MathUtils.Multiply(ref d, e.localCenter));
			f += MathUtils.Cross(g, e.c - val);
		}
	}

	public void ResetMassData()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		q = 0f;
		r = 0f;
		s = 0f;
		t = 0f;
		e.localCenter = Vector2.Zero;
		if (this.b == BodyType.Static || this.b == BodyType.Kinematic)
		{
			e.c0 = (e.c = d.Position);
			return;
		}
		Vector2 val = Vector2.Zero;
		for (Fixture fixture = m; fixture != null; fixture = fixture.d)
		{
			if (fixture.c != 0f)
			{
				fixture.GetMassData(out var massData);
				q += massData.mass;
				val += massData.mass * massData.center;
				s += massData.I;
			}
		}
		if (q > 0f)
		{
			r = 1f / q;
			val *= r;
		}
		else
		{
			q = 1f;
			r = 1f;
		}
		if (s > 0f && (this.a & BodyFlags.FixedRotation) == 0)
		{
			s -= q * Vector2.Dot(val, val);
			t = 1f / s;
		}
		else
		{
			s = 0f;
			t = 0f;
		}
		Vector2 val2 = e.c;
		e.localCenter = val;
		e.c0 = (e.c = MathUtils.Multiply(ref d, e.localCenter));
		f += MathUtils.Cross(g, e.c - val2);
	}

	public Vector2 GetWorldPoint(Vector2 localPoint)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return MathUtils.Multiply(ref d, localPoint);
	}

	public Vector2 GetWorldVector(Vector2 localVector)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return MathUtils.Multiply(ref d.R, localVector);
	}

	public Vector2 GetLocalPoint(Vector2 worldPoint)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return MathUtils.MultiplyT(ref d, worldPoint);
	}

	public Vector2 GetLocalVector(Vector2 worldVector)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return MathUtils.MultiplyT(ref d.R, worldVector);
	}

	public Vector2 GetLinearVelocityFromWorldPoint(Vector2 worldPoint)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		return f + MathUtils.Cross(g, worldPoint - e.c);
	}

	public Vector2 GetLinearVelocityFromLocalPoint(Vector2 localPoint)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return GetLinearVelocityFromWorldPoint(GetWorldPoint(localPoint));
	}

	public float GetLinearDamping()
	{
		return u;
	}

	public void SetLinearDamping(float linearDamping)
	{
		u = linearDamping;
	}

	public float GetAngularDamping()
	{
		return v;
	}

	public void SetAngularDamping(float angularDamping)
	{
		v = angularDamping;
	}

	public void SetBullet(bool flag)
	{
		if (flag)
		{
			this.a |= BodyFlags.Bullet;
		}
		else
		{
			this.a &= ~BodyFlags.Bullet;
		}
	}

	public void AllowSleeping(bool flag)
	{
		if (flag)
		{
			this.a |= BodyFlags.AutoSleep;
			return;
		}
		this.a &= ~BodyFlags.AutoSleep;
		SetAwake(flag: true);
	}

	public void SetAwake(bool flag)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (flag)
		{
			if ((this.a & BodyFlags.Awake) == 0)
			{
				this.a |= BodyFlags.Awake;
				w = 0f;
			}
		}
		else
		{
			this.a &= ~BodyFlags.Awake;
			w = 0f;
			f = Vector2.Zero;
			g = 0f;
			h = Vector2.Zero;
			i = 0f;
		}
	}

	public bool IsAwake()
	{
		return (this.a & BodyFlags.Awake) == BodyFlags.Awake;
	}

	public void SetActive(bool flag)
	{
		if (flag == IsActive())
		{
			return;
		}
		if (flag)
		{
			this.a |= BodyFlags.Active;
			BroadPhase a_ = j.n._broadPhase;
			for (Fixture fixture = m; fixture != null; fixture = fixture.d)
			{
				fixture.M_a(a_, ref d);
			}
			return;
		}
		this.a &= ~BodyFlags.Active;
		BroadPhase a_2 = j.n._broadPhase;
		for (Fixture fixture2 = m; fixture2 != null; fixture2 = fixture2.d)
		{
			fixture2.M_a(a_2);
		}
		ContactEdge next = p;
		while (next != null)
		{
			ContactEdge contactEdge = next;
			next = next.Next;
			j.n.M_a(contactEdge.Contact);
		}
		p = null;
	}

	public bool IsActive()
	{
		return (this.a & BodyFlags.Active) == BodyFlags.Active;
	}

	public void SetFixedRotation(bool flag)
	{
		if (flag)
		{
			this.a |= BodyFlags.FixedRotation;
		}
		else
		{
			this.a &= ~BodyFlags.FixedRotation;
		}
		ResetMassData();
	}

	public bool IsFixedRotation()
	{
		return (this.a & BodyFlags.FixedRotation) == BodyFlags.FixedRotation;
	}

	public Fixture GetFixtureList()
	{
		return m;
	}

	public JointEdge GetJointList()
	{
		return o;
	}

	public ContactEdge GetContactList()
	{
		return p;
	}

	public Body GetNext()
	{
		return l;
	}

	public object GetUserData()
	{
		return x;
	}

	public void SetUserData(object data)
	{
		x = data;
	}

	public World GetWorld()
	{
		return j;
	}

	internal Body(BodyDef A_0, World A_1)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		if (A_0.bullet)
		{
			this.a |= BodyFlags.Bullet;
		}
		if (A_0.fixedRotation)
		{
			this.a |= BodyFlags.FixedRotation;
		}
		if (A_0.allowSleep)
		{
			this.a |= BodyFlags.AutoSleep;
		}
		if (A_0.awake)
		{
			this.a |= BodyFlags.Awake;
		}
		if (A_0.active)
		{
			this.a |= BodyFlags.Active;
		}
		j = A_1;
		d.Position = A_0.position;
		d.R.Set(A_0.angle);
		e.a0 = (e.a = A_0.angle);
		e.c0 = (e.c = MathUtils.Multiply(ref d, e.localCenter));
		f = A_0.linearVelocity;
		g = A_0.angularVelocity;
		u = A_0.linearDamping;
		v = A_0.angularDamping;
		this.b = A_0.type;
		if (this.b == BodyType.Dynamic)
		{
			q = 1f;
			r = 1f;
		}
		x = A_0.userData;
	}

	internal void M_b()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		Transform A_ = default(Transform);
		A_.R.Set(e.a0);
		A_.Position = e.c0 - MathUtils.Multiply(ref A_.R, e.localCenter);
		BroadPhase a_ = j.n._broadPhase;
		for (Fixture fixture = m; fixture != null; fixture = fixture.d)
		{
			fixture.M_a(a_, ref A_, ref d);
		}
	}

	internal void M_a()
	{
		float num;
		for (num = e.a; (double)num < -3.14159265; num += (float)Math.PI * 2f)
		{
		}
		while ((double)num > 3.14159265)
		{
			num -= (float)Math.PI * 2f;
		}
		float num2;
		if (num < 0f)
		{
			num2 = 4f / (float)Math.PI * num + 0.40528473f * num * num;
			num2 = ((!(num2 < 0f)) ? (0.225f * (num2 * num2 - num2) + num2) : (0.225f * (num2 * (0f - num2) - num2) + num2));
		}
		else
		{
			num2 = 4f / (float)Math.PI * num - 0.40528473f * num * num;
			num2 = ((!(num2 < 0f)) ? (0.225f * (num2 * num2 - num2) + num2) : (0.225f * (num2 * (0f - num2) - num2) + num2));
		}
		num += (float)Math.PI / 2f;
		if ((double)num > 3.14159265)
		{
			num -= (float)Math.PI * 2f;
		}
		float num3;
		if (num < 0f)
		{
			num3 = 4f / (float)Math.PI * num + 0.40528473f * num * num;
			num3 = ((!(num3 < 0f)) ? (0.225f * (num3 * num3 - num3) + num3) : (0.225f * (num3 * (0f - num3) - num3) + num3));
		}
		else
		{
			num3 = 4f / (float)Math.PI * num - 0.40528473f * num * num;
			num3 = ((!(num3 < 0f)) ? (0.225f * (num3 * num3 - num3) + num3) : (0.225f * (num3 * (0f - num3) - num3) + num3));
		}
		d.R.col1.X = num3;
		d.R.col2.X = 0f - num2;
		d.R.col1.Y = num2;
		d.R.col2.Y = num3;
		d.Position.X = e.c.X - (d.R.col1.X * e.localCenter.X + d.R.col2.X * e.localCenter.Y);
		d.Position.Y = e.c.Y - (d.R.col1.Y * e.localCenter.X + d.R.col2.Y * e.localCenter.Y);
	}

	internal bool M_a(Body A_0)
	{
		if (this.b != BodyType.Dynamic && A_0.b != BodyType.Dynamic)
		{
			return false;
		}
		for (JointEdge next = o; next != null; next = next.Next)
		{
			if (next.Other == A_0 && !next.Joint.i)
			{
				return false;
			}
		}
		return true;
	}

	internal void M_a(float A_0)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		e.Advance(A_0);
		e.c = e.c0;
		e.a = e.a0;
		M_a();
	}
}
