using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public struct ContactConstraint
{
	public FixedArray2<ContactConstraintPoint> points;

	public Vector2 localNormal;

	public Vector2 localPoint;

	public Vector2 normal;

	public Mat22 normalMass;

	public Mat22 K;

	public Body bodyA;

	public Body bodyB;

	public ManifoldType type;

	public float radius;

	public float friction;

	public int pointCount;

	public Manifold manifold;
}
