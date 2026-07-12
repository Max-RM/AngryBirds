using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public struct Manifold
{
	public FixedArray2<ManifoldPoint> _points;

	public Vector2 _localNormal;

	public Vector2 _localPoint;

	public ManifoldType _type;

	public int _pointCount;
}
