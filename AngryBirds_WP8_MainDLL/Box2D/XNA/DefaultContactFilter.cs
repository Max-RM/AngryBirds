namespace Box2D.XNA;

public class DefaultContactFilter : IContactFilter
{
	public bool ShouldCollide(Fixture fixtureA, Fixture fixtureB)
	{
		fixtureA.GetFilterData(out var filter);
		fixtureB.GetFilterData(out var filter2);
		if (filter.groupIndex == filter2.groupIndex && filter.groupIndex != 0)
		{
			return filter.groupIndex > 0;
		}
		return (filter.maskBits & filter2.categoryBits) != 0 && (filter.categoryBits & filter2.maskBits) != 0;
	}
}
