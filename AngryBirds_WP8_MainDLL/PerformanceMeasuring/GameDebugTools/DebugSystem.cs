using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace PerformanceMeasuring.GameDebugTools;

public class DebugSystem
{
	private static DebugSystem a;

	[CompilerGenerated]
	private DebugManager b;

	[CompilerGenerated]
	private DebugCommandUI c;

	[CompilerGenerated]
	private FpsCounter d;

	[CompilerGenerated]
	private TimeRuler e;

	public static DebugSystem Instance => a;

	public DebugManager DebugManager
	{
		[CompilerGenerated]
		get
		{
			return b;
		}
		[CompilerGenerated]
		private set
		{
			b = value;
		}
	}

	public DebugCommandUI DebugCommandUI
	{
		[CompilerGenerated]
		get
		{
			return c;
		}
		[CompilerGenerated]
		private set
		{
			c = value;
		}
	}

	public FpsCounter FpsCounter
	{
		[CompilerGenerated]
		get
		{
			return d;
		}
		[CompilerGenerated]
		private set
		{
			d = value;
		}
	}

	public TimeRuler TimeRuler
	{
		[CompilerGenerated]
		get
		{
			return e;
		}
		[CompilerGenerated]
		private set
		{
			e = value;
		}
	}

	public static DebugSystem Initialize(Game game, string debugFont)
	{
		if (a != null)
		{
			return a;
		}
		a = new DebugSystem();
		a.DebugManager = new DebugManager(game, debugFont);
		((Collection<IGameComponent>)(object)game.Components).Add((IGameComponent)(object)a.DebugManager);
		a.DebugCommandUI = new DebugCommandUI(game);
		((Collection<IGameComponent>)(object)game.Components).Add((IGameComponent)(object)a.DebugCommandUI);
		a.FpsCounter = new FpsCounter(game);
		((Collection<IGameComponent>)(object)game.Components).Add((IGameComponent)(object)a.FpsCounter);
		a.TimeRuler = new TimeRuler(game);
		((Collection<IGameComponent>)(object)game.Components).Add((IGameComponent)(object)a.TimeRuler);
		return a;
	}

	private DebugSystem()
	{
	}
}
