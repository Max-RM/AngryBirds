using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.GamerServices;

internal static class dc
{
	private static bool m_a = false;

	public static string b = "en_EN";

	public static string c = "ALL";

	public static readonly string[] d = new string[2] { "SPLASH_ROVIO", "SPLASH_ANGRY_BIRDS" };

	public static readonly string[] e = new string[7] { "BIRD_RED", "BIRD_BLUE", "BIRD_YELLOW", "BIRD_GREY", "BIRD_GREEN", "BIRD_BOOMERANG", "BIRD_BIG_BROTHER" };

	public static readonly string[] f = new string[7] { "EGG_SILHOUETTE_2", "EGG_SILHOUETTE_4", "EGG_SILHOUETTE_1", "EGG_SILHOUETTE_3", "EGG_SILHOUETTE_5", "EGG_SILHOUETTE_7", "EGG_SILHOUETTE_6" };

	public static readonly string[] g = new string[22]
	{
		"GOLDEN_EGG_3", "GOLDEN_EGG_2", "GOLDEN_EGG_1", "GOLDEN_EGG_5", "GOLDEN_EGG_3", "GOLDEN_EGG_2", "GOLDEN_EGG_4", "GOLDEN_EGG_2", "GOLDEN_EGG_3", "GOLDEN_EGG_3",
		"GOLDEN_EGG_3", "GOLDEN_EGG_1", "GOLDEN_EGG_3", "GOLDEN_EGG_1", "GOLDEN_EGG_1", "GOLDEN_EGG_1", "GOLDEN_EGG_3", "GOLDEN_EGG_1", "GOLDEN_EGG_1", "GOLDEN_EGG_1",
		"GOLDEN_EGG_3", "EGG_SUPER_BOWL"
	};

	public static readonly string[] h = new string[7] { "EGG_HINT_TUTORIAL", "EGG_HINT_ROCKET", "EGG_HINT_BEACH_BALL", "EGG_HINT_3STAR_EP1", "EGG_HINT_ABOUT", "EGG_HINT_TREASURE_CHEST", "EGG_HINT_3STAR_EP2" };

	public static readonly string[] i = new string[22]
	{
		"LevelGE_4", "LevelGE_3", "LevelGE_2", "SOUNDBOARD1", "LevelGE_14", "LevelGE_15", "RADIO", "LevelGE_1", "LevelGE_5", "LevelGE_6",
		"LevelGE_7", "KEYBOARD", "LevelGE_8", "LevelGE_9", "LevelGE_10", "LevelGE_11", "SEQUENCER", "LevelGE_16", "LevelGE_17", "LevelGE_18",
		"ACCORDION", "LevelGE_19"
	};

	public static readonly Color j = new Color(0f, 0f, 0f, 0.65f);

	public static readonly Vector2 k = new Vector2(0f, 20f);

	public static void Init()
	{
		dc.m_a = Guide.IsTrialMode;
	}

	public static bool IsTrial()
	{
		return dc.m_a;
	}

	public static string a()
	{
		string name = Thread.CurrentThread.CurrentCulture.Name;
		return name.Replace("-", "_");
	}
}
