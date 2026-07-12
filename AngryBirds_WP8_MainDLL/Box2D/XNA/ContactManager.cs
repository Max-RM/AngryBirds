using System;
using System.Runtime.CompilerServices;

namespace Box2D.XNA;

public class ContactManager
{
	internal BroadPhase _broadPhase = new BroadPhase();

	internal Contact _contacts;

	internal int _contactCount;

	private Action<FixtureProxy, FixtureProxy> d;

	[CompilerGenerated]
	private IContactFilter e;

	[CompilerGenerated]
	private IContactListener f;

	internal IContactFilter ContactFilter
	{
		[CompilerGenerated]
		get
		{
			return e;
		}
		[CompilerGenerated]
		set
		{
			e = value;
		}
	}

	internal IContactListener ContactListener
	{
		[CompilerGenerated]
		get
		{
			return f;
		}
		[CompilerGenerated]
		set
		{
			f = value;
		}
	}

	internal ContactManager()
	{
		d = M_a;
		this._contacts = null;
		this._contactCount = 0;
		ContactFilter = new DefaultContactFilter();
		ContactListener = new DefaultContactListener();
	}

	internal void M_a(FixtureProxy A_0, FixtureProxy A_1)
	{
		Fixture fixture = A_0.fixture;
		Fixture fixture2 = A_1.fixture;
		Body body = fixture.e;
		Body body2 = fixture2.e;
		if (body == body2)
		{
			return;
		}
		int childIndex = A_0.childIndex;
		int childIndex2 = A_1.childIndex;
		for (ContactEdge contactEdge = body2.GetContactList(); contactEdge != null; contactEdge = contactEdge.Next)
		{
			if (contactEdge.Other == body)
			{
				Fixture i = contactEdge.Contact.i;
				Fixture j = contactEdge.Contact.j;
				int k = contactEdge.Contact.k;
				int l = contactEdge.Contact.l;
				if ((i == fixture && j == fixture2 && k == childIndex && l == childIndex2) || (i == fixture2 && j == fixture && k == childIndex2 && l == childIndex))
				{
					return;
				}
			}
		}
		if (body2.M_a(body) && (ContactFilter == null || ContactFilter.ShouldCollide(fixture, fixture2)))
		{
			Contact contact = Contact.M_a(fixture, childIndex, fixture2, childIndex2);
			fixture = contact.i;
			fixture2 = contact.j;
			childIndex = contact.k;
			childIndex2 = contact.l;
			body = fixture.e;
			body2 = fixture2.e;
			contact.e = null;
			contact.f = this._contacts;
			if (this._contacts != null)
			{
				this._contacts.e = contact;
			}
			this._contacts = contact;
			contact.g.Contact = contact;
			contact.g.Other = body2;
			contact.g.Prev = null;
			contact.g.Next = body.p;
			if (body.p != null)
			{
				body.p.Prev = contact.g;
			}
			body.p = contact.g;
			contact.h.Contact = contact;
			contact.h.Other = body;
			contact.h.Prev = null;
			contact.h.Next = body2.p;
			if (body2.p != null)
			{
				body2.p.Prev = contact.h;
			}
			body2.p = contact.h;
			this._contactCount++;
		}
	}

	internal void M_c()
	{
		this._broadPhase.UpdatePairs<FixtureProxy>(d);
	}

	internal void M_a(Contact A_0)
	{
		Fixture i = A_0.i;
		Fixture j = A_0.j;
		Body body = i.e;
		Body body2 = j.e;
		if (ContactListener != null && (A_0.d & ContactFlags.Touching) == ContactFlags.Touching)
		{
			ContactListener.EndContact(A_0);
		}
		if (A_0.e != null)
		{
			A_0.e.f = A_0.f;
		}
		if (A_0.f != null)
		{
			A_0.f.e = A_0.e;
		}
		if (A_0 == this._contacts)
		{
			this._contacts = A_0.f;
		}
		if (A_0.g.Prev != null)
		{
			A_0.g.Prev.Next = A_0.g.Next;
		}
		if (A_0.g.Next != null)
		{
			A_0.g.Next.Prev = A_0.g.Prev;
		}
		if (A_0.g == body.p)
		{
			body.p = A_0.g.Next;
		}
		if (A_0.h.Prev != null)
		{
			A_0.h.Prev.Next = A_0.h.Next;
		}
		if (A_0.h.Next != null)
		{
			A_0.h.Next.Prev = A_0.h.Prev;
		}
		if (A_0.h == body2.p)
		{
			body2.p = A_0.h.Next;
		}
		A_0.M_a();
		this._contactCount--;
	}

	internal void M_b()
	{
		Contact contact = this._contacts;
		while (contact != null)
		{
			Fixture i = contact.i;
			Fixture j = contact.j;
			int k = contact.k;
			int l = contact.l;
			Body body = i.e;
			Body body2 = j.e;
			if (!body.IsAwake() && !body2.IsAwake())
			{
				contact = contact.f;
				continue;
			}
			if ((contact.d & ContactFlags.Filter) == ContactFlags.Filter)
			{
				if (!body2.M_a(body))
				{
					Contact contact2 = contact;
					contact = contact2.f;
					M_a(contact2);
					continue;
				}
				if (ContactFilter != null && !ContactFilter.ShouldCollide(i, j))
				{
					Contact contact3 = contact;
					contact = contact3.f;
					M_a(contact3);
					continue;
				}
				contact.d &= ~ContactFlags.Filter;
			}
			int proxyId = i.a[k].proxyId;
			int proxyId2 = j.a[l].proxyId;
			if (!this._broadPhase.TestOverlap(proxyId, proxyId2))
			{
				Contact contact4 = contact;
				contact = contact4.f;
				M_a(contact4);
			}
			else
			{
				contact.M_a(ContactListener);
				contact = contact.f;
			}
		}
	}
}
