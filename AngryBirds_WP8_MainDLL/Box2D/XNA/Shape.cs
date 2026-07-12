using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public abstract class Shape
{
	public float _radius;

	[CompilerGenerated]
	private ShapeType a;

	public ShapeType ShapeType
	{
		[CompilerGenerated]
		get
		{
			return a;
		}
		[CompilerGenerated]
		internal set
		{
			a = value;
		}
	}

	public Shape()
	{
		ShapeType = ShapeType.Unknown;
	}

	public abstract Shape Clone();

	public abstract int GetChildCount();

	public abstract bool TestPoint(ref Transform xf, Vector2 p);

	public abstract bool RayCast(out RayCastOutput output, ref RayCastInput input, ref Transform transform, int childIndex);

	public abstract void ComputeAABB(out AABB aabb, ref Transform xf, int childIndex);

	public abstract void ComputeMass(out MassData massData, float density);
}
