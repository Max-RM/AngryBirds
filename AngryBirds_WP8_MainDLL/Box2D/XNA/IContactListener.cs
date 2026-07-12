namespace Box2D.XNA;

public interface IContactListener
{
	void BeginContact(Contact contact);

	void EndContact(Contact contact);

	void PreSolve(Contact contact, ref Manifold oldManifold);

	void PostSolve(Contact contact, ref ContactImpulse impulse);
}
