namespace Box2D.XNA;

public class FixtureDef
{
	public Shape shape;

	public object userData;

	public float friction;

	public float restitution;

	public float density;

	public bool isSensor;

	public Filter filter;

	public FixtureDef()
	{
		shape = null;
		userData = null;
		friction = 0.2f;
		restitution = 0f;
		density = 0f;
		filter.categoryBits = 1;
		filter.maskBits = ushort.MaxValue;
		filter.groupIndex = 0;
		isSensor = false;
	}
}
