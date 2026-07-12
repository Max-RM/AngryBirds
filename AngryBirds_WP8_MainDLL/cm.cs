using System.Runtime.CompilerServices;

internal class cm : c
{
	public new delegate void SceneCallback();

	public new enum CutScenePhase
	{
		a = 0,
		b = 1,
		c = 2,
		d = 255
	}

	public CutScenePhase ar = CutScenePhase.d;

	public bool @as;

	[CompilerGenerated]
	private SceneCallback at;

	[SpecialName]
	[CompilerGenerated]
	public SceneCallback av()
	{
		return at;
	}

	[SpecialName]
	[CompilerGenerated]
	public void a(SceneCallback A_0)
	{
		at = A_0;
	}

	public override void c()
	{
		if (@as)
		{
			base.c();
		}
	}
}
