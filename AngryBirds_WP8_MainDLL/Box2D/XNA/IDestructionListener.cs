namespace Box2D.XNA;

public interface IDestructionListener
{
	void SayGoodbye(Joint joint);

	void SayGoodbye(Fixture fixture);
}
