using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public struct ManifoldPoint
{
	public Vector2 LocalPoint;

	public float NormalImpulse;

	public float TangentImpulse;

	public ContactID Id;
}
