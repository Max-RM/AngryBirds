using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public abstract class DebugDraw
{
	[CompilerGenerated]
	private DebugDrawFlags a;

	public DebugDrawFlags Flags
	{
		[CompilerGenerated]
		get
		{
			return a;
		}
		[CompilerGenerated]
		set
		{
			a = value;
		}
	}

	public void AppendFlags(DebugDrawFlags flags)
	{
		Flags |= flags;
	}

	public void ClearFlags(DebugDrawFlags flags)
	{
		Flags &= ~flags;
	}

	public abstract void DrawPolygon(ref FixedArray8<Vector2> vertices, int count, Color color);

	public abstract void DrawSolidPolygon(ref FixedArray8<Vector2> vertices, int count, Color color);

	public abstract void DrawCircle(Vector2 center, float radius, Color color);

	public abstract void DrawSolidCircle(Vector2 center, float radius, Vector2 axis, Color color);

	public abstract void DrawSegment(Vector2 p1, Vector2 p2, Color color);

	public abstract void DrawTransform(ref Transform xf);
}
