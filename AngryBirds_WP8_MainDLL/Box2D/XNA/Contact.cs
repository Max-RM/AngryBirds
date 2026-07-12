using System.Collections.Generic;

namespace Box2D.XNA;

public class Contact
{
	internal enum ContactType
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g
	}

	private static EdgeShape m_a = new EdgeShape();

	internal static ContactType[,] b = new ContactType[4, 4]
	{
		{
			ContactType.c,
			ContactType.e,
			ContactType.b,
			ContactType.g
		},
		{
			ContactType.e,
			ContactType.e,
			ContactType.d,
			ContactType.d
		},
		{
			ContactType.b,
			ContactType.d,
			ContactType.a,
			ContactType.f
		},
		{
			ContactType.g,
			ContactType.g,
			ContactType.f,
			ContactType.f
		}
	};

	private ContactType contactType;

	internal ContactFlags d;

	internal Contact e;

	internal Contact f;

	internal ContactEdge g = new ContactEdge();

	internal ContactEdge h = new ContactEdge();

	internal Fixture i;

	internal Fixture j;

	internal int k;

	internal int l;

	internal Manifold m;

	internal int n;

	public void GetManifold(out Manifold manifold)
	{
		manifold = m;
	}

	public void GetWorldManifold(out WorldManifold worldManifold)
	{
		Body body = i.e;
		Body body2 = j.e;
		Shape shape = i.f;
		Shape shape2 = j.f;
		worldManifold = new WorldManifold(ref m, ref body.d, shape._radius, ref body2.d, shape2._radius);
	}

	public void SetEnabled(bool flag)
	{
		if (flag)
		{
			d |= ContactFlags.Enabled;
		}
		else
		{
			d &= ~ContactFlags.Enabled;
		}
	}

	public void FlagForFiltering()
	{
		d |= ContactFlags.Filter;
	}

	internal Contact(Fixture A_0, int A_1, Fixture A_2, int A_3)
	{
		M_b(A_0, A_1, A_2, A_3);
	}

	internal void M_b(Fixture A_0, int A_1, Fixture A_2, int A_3)
	{
		d = ContactFlags.Enabled;
		i = A_0;
		j = A_2;
		k = A_1;
		l = A_3;
		m._pointCount = 0;
		e = null;
		f = null;
		g.Contact = null;
		g.Prev = null;
		g.Next = null;
		g.Other = null;
		h.Contact = null;
		h.Prev = null;
		h.Next = null;
		h.Other = null;
		n = 0;
	}

	internal void M_a(IContactListener A_0)
	{
		Manifold oldManifold = m;
		d |= ContactFlags.Enabled;
		bool flag = false;
		bool flag2 = (d & ContactFlags.Touching) == ContactFlags.Touching;
		bool flag3 = this.i.k;
		bool flag4 = j.k;
		bool flag5 = flag3 || flag4;
		Body body = this.i.e;
		Body body2 = j.e;
		if (flag5)
		{
			Shape shapeA = this.i.f;
			Shape shapeB = j.f;
			flag = AABB.TestOverlap(shapeA, k, shapeB, l, ref body.d, ref body2.d);
			m._pointCount = 0;
		}
		else
		{
			M_a(ref m, ref body.d, ref body2.d);
			flag = m._pointCount > 0;
			for (int i = 0; i < m._pointCount; i++)
			{
				ManifoldPoint value = m._points[i];
				value.NormalImpulse = 0f;
				value.TangentImpulse = 0f;
				ContactID id = value.Id;
				if (oldManifold._pointCount > 0)
				{
					if (oldManifold._points._value0.Id.Key == id.Key)
					{
						value.NormalImpulse = oldManifold._points._value0.NormalImpulse;
						value.TangentImpulse = oldManifold._points._value0.TangentImpulse;
					}
					else if (oldManifold._pointCount > 1 && oldManifold._points._value1.Id.Key == id.Key)
					{
						value.NormalImpulse = oldManifold._points._value1.NormalImpulse;
						value.TangentImpulse = oldManifold._points._value1.TangentImpulse;
					}
				}
				m._points[i] = value;
			}
			if (flag != flag2)
			{
				if (!body.IsAwake())
				{
					body.SetAwake(flag: true);
				}
				if (!body2.IsAwake())
				{
					body2.SetAwake(flag: true);
				}
			}
		}
		if (flag)
		{
			d |= ContactFlags.Touching;
		}
		else
		{
			d &= ~ContactFlags.Touching;
		}
		if (!flag2 && flag)
		{
			A_0?.BeginContact(this);
		}
		if (flag2 && !flag)
		{
			A_0?.EndContact(this);
		}
		if (!flag5)
		{
			A_0?.PreSolve(this, ref oldManifold);
		}
	}

	internal void M_a(ref Manifold A_0, ref Transform A_1, ref Transform A_2)
	{
		switch (contactType)
		{
		case ContactType.a:
			Collision.CollidePolygons(ref A_0, (PolygonShape)i.f, ref A_1, (PolygonShape)j.f, ref A_2);
			break;
		case ContactType.b:
			Collision.CollidePolygonAndCircle(ref A_0, (PolygonShape)i.f, ref A_1, (CircleShape)j.f, ref A_2);
			break;
		case ContactType.e:
			Collision.CollideEdgeAndCircle(ref A_0, (EdgeShape)i.f, ref A_1, (CircleShape)j.f, ref A_2);
			break;
		case ContactType.d:
			Collision.CollideEdgeAndPolygon(ref A_0, (EdgeShape)i.f, ref A_1, (PolygonShape)j.f, ref A_2);
			break;
		case ContactType.g:
		{
			LoopShape loopShape2 = (LoopShape)i.f;
			loopShape2.GetChildEdge(ref Contact.m_a, k);
			Collision.CollideEdgeAndCircle(ref A_0, Contact.m_a, ref A_1, (CircleShape)j.f, ref A_2);
			break;
		}
		case ContactType.f:
		{
			LoopShape loopShape = (LoopShape)i.f;
			loopShape.GetChildEdge(ref Contact.m_a, k);
			Collision.CollideEdgeAndPolygon(ref A_0, Contact.m_a, ref A_1, (PolygonShape)j.f, ref A_2);
			break;
		}
		case ContactType.c:
			Collision.CollideCircles(ref A_0, (CircleShape)i.f, ref A_1, (CircleShape)j.f, ref A_2);
			break;
		}
	}

	internal static Contact M_a(Fixture A_0, int A_1, Fixture A_2, int A_3)
	{
		ShapeType shapeType = A_0.f.ShapeType;
		ShapeType shapeType2 = A_2.f.ShapeType;
		Queue<Contact> p = A_0.e.j.p;
		Contact contact;
		if (p.Count <= 0)
		{
			contact = (((shapeType < shapeType2 && (shapeType != ShapeType.Edge || shapeType2 != ShapeType.Polygon)) || (shapeType2 == ShapeType.Edge && shapeType == ShapeType.Polygon)) ? new Contact(A_2, A_3, A_0, A_1) : new Contact(A_0, A_1, A_2, A_3));
		}
		else
		{
			contact = p.Dequeue();
			if ((shapeType >= shapeType2 || (shapeType == ShapeType.Edge && shapeType2 == ShapeType.Polygon)) && (shapeType2 != ShapeType.Edge || shapeType != ShapeType.Polygon))
			{
				contact.M_b(A_0, A_1, A_2, A_3);
			}
			else
			{
				contact.M_b(A_2, A_3, A_0, A_1);
			}
		}
		contact.contactType = Contact.b[(int)shapeType, (int)shapeType2];
		return contact;
	}

	internal void M_a()
	{
		i.e.j.p.Enqueue(this);
		M_b(null, 0, null, 0);
	}
}
