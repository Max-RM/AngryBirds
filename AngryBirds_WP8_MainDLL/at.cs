using System.Runtime.CompilerServices;
using AngryBirds;
using Microsoft.Xna.Framework;

internal class at : cb
{
	[CompilerGenerated]
	private bool a;

	[SpecialName]
	[CompilerGenerated]
	public bool ar()
	{
		return a;
	}

	[SpecialName]
	[CompilerGenerated]
	private void ar(bool A_0)
	{
		a = A_0;
	}

	public at(BlockBasicType A_0, Vector2[] A_1, string A_2, string A_3, string A_4, BlockGroup A_5, float A_6, int A_7, bool A_8, int A_9, bl[] A_10, float A_11, float A_12, float A_13, float A_14, bool A_15, int A_16, string A_17, float A_18, float A_19, float A_20, float A_21, float A_22, bool A_23, bool A_24)
		: base(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12, A_13, A_14, A_15, A_16, A_17, A_18, A_19, A_20, A_21, A_22, A_23)
	{
		h = BlockGroup.PIGLETTES;
		ar(A_24);
	}
}
