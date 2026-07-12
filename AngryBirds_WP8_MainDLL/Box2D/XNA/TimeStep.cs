namespace Box2D.XNA;

public struct TimeStep
{
	public float dt;

	public float inv_dt;

	public float dtRatio;

	public int velocityIterations;

	public int positionIterations;

	public bool warmStarting;
}
