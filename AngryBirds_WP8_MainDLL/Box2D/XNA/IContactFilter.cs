namespace Box2D.XNA;

public interface IContactFilter
{
	bool ShouldCollide(Fixture fixtureA, Fixture fixtureB);
}
