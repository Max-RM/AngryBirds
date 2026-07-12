using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public struct ContactConstraintPoint
{
	public Vector2 localPoint;

	public Vector2 rA;

	public Vector2 rB;

	public float normalImpulse;

	public float tangentImpulse;

	public float normalMass;

	public float tangentMass;

	public float velocityBias;
}
