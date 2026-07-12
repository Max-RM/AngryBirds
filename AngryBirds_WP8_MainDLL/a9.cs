using AngryBirds;

internal class a9
{
	public b5 a;

	public b5 b;

	public a9(b5 A_0, b5 A_1)
	{
		a = A_0;
		b = A_1;
	}

	public float c(MaterialType A_0)
	{
		return A_0 switch
		{
			MaterialType.WOOD => a.a, 
			MaterialType.ROCK => a.b, 
			MaterialType.LIGHT => a.c, 
			MaterialType.IMMOVABLE => a.d, 
			MaterialType.STATIC_GROUND => a.e, 
			_ => 1f, 
		};
	}

	public float d(MaterialType A_0)
	{
		return A_0 switch
		{
			MaterialType.WOOD => b.a, 
			MaterialType.ROCK => b.b, 
			MaterialType.LIGHT => b.c, 
			MaterialType.IMMOVABLE => b.d, 
			MaterialType.STATIC_GROUND => b.e, 
			_ => 1f, 
		};
	}
}
