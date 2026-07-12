using System.Collections.Generic;
using AngryBirds;

internal class cv
{
	public MaterialType a;

	public float b;

	public float c;

	public float d;

	public float e;

	public float f;

	public bool g;

	public string h;

	public cw i;

	public cw j;

	public cw k;

	public cw l;

	public static readonly Dictionary<string, MaterialType> m = new Dictionary<string, MaterialType>
	{
		{
			"wood",
			MaterialType.WOOD
		},
		{
			"rock",
			MaterialType.ROCK
		},
		{
			"light",
			MaterialType.LIGHT
		},
		{
			"piglette",
			MaterialType.PIGLETTE
		},
		{
			"staticGround",
			MaterialType.STATIC_GROUND
		},
		{
			"immovable",
			MaterialType.IMMOVABLE
		},
		{
			"immovableRubber",
			MaterialType.IMMOVABLE_RUBBER
		},
		{
			"immovableFragile",
			MaterialType.IMMOVABLE_FRAGILE
		},
		{
			"clouds",
			MaterialType.CLOUDS
		},
		{
			"extras",
			MaterialType.EXTRAS
		},
		{
			"rubber",
			MaterialType.RUBBER
		},
		{
			"decoration",
			MaterialType.DECORATION
		}
	};

	public cv(MaterialType A_0, float A_1, float A_2, float A_3, float A_4, float A_5, bool A_6, string A_7, string A_8, string A_9, string A_10, string A_11)
	{
		a = A_0;
		b = A_1;
		c = A_2;
		d = A_3;
		e = A_4;
		f = A_5;
		g = A_6;
		h = A_7;
		i = u.a().f(A_8);
		j = u.a().f(A_9);
		k = u.a().f(A_10);
		l = u.a().f(A_11);
	}

	public cv()
	{
		b = float.NaN;
		c = float.NaN;
		d = float.NaN;
		e = float.NaN;
		f = float.NaN;
		g = false;
		h = null;
		i = null;
		j = null;
		k = null;
		l = null;
	}
}
