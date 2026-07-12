using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;

namespace AngryBirds;

public class GameMain : Game
{
	protected enum SigninStatus
	{
		None,
		SigningIn,
		Local,
		LIVE,
		Error,
		UpdateNeeded
	}

	public static GameMain Instance;

	private bool m_a;

	private GraphicsDeviceManager b;

	private b c = new b();

	private SpriteFont d;

	private GamerServicesComponent e;

	private short f;

	private bool g;

	private int h = 3;

	protected SigninStatus _signinStatus;

	protected bool _displayTitleUpdateMessage;

	protected List<string> _dialogButtons;

	private bool i;

	private bool _gameInitialized;

	private bool _pendingActivation;

	private bool _pendingViewportUpdate;

	public GameMain()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		Instance = this;
		b = new GraphicsDeviceManager((Game)(object)this);
		((Game)this).Content.RootDirectory = "Content";
		((Game)this).TargetElapsedTime = TimeSpan.FromTicks(333333L);
		b.PreferredBackBufferWidth = 800;
		b.PreferredBackBufferHeight = 480;
		b.IsFullScreen = false;
		((Game)this).IsMouseVisible = true;
		((Game)this).Window.AllowUserResizing = true;
		((Game)this).Window.ClientSizeChanged += OnClientSizeChanged;
		dc.Init();
		f = 0;
		g = false;
		Guide.IsScreenSaverEnabled = false;
		DisableApplicationIdleDetection();
		Exiting += OnGameExiting;
	}

	protected override void Initialize()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_0496: Expected O, but got Unknown
		try
		{
			al.a((IServiceProvider)((Game)this).Services);
			Controls.GetInstance().Initialize();
			u.a(new df((IServiceProvider)((Game)this).Services, ((Game)this).Content.RootDirectory), ((Game)this).GraphicsDevice);
			u.a();
			bu.b(((Game)this).GraphicsDevice);
			bu.b();
			bu.b().UpdateViewport(b.PreferredBackBufferWidth, b.PreferredBackBufferHeight);
			Controls.GetInstance().SetBackBufferSize(b.PreferredBackBufferWidth, b.PreferredBackBufferHeight);
			a1.a();
			_dialogButtons = new List<string>();
			_dialogButtons.Add(u.a().e("SK_NO"));
			_dialogButtons.Add(u.a().e("SK_YES"));
			bw.d().d((bw.b)HandleGameUpdateRequired);
			e = new GamerServicesComponent((Game)(object)this);
			((Collection<IGameComponent>)(object)((Game)this).Components).Add((IGameComponent)(object)e);
			c.c("splashScreen", new cj());
			c.c("mainMenu", new ac());
			c.c("loading", new cp());
			c.c("aboutPage", new bd(this));
			c.c("leaderboardPage", new b3(b3.B3Mode.a));
			c.c("achievementsPage", new ax());
			c.c("pauseGamePage", new PauseGamePage());
			c.c("tutorialPage", new bk());
			c.c("episodeSelectionPage", new br());
			c.c("episode1", new dj());
			c.c("episode2", new cx());
			c.c("episode3", new o());
			c.c("episode4", new dg());
			c.c("episode5", new w());
			c.c("goldenEggs", new a4());
			c.c("goldenEggStarPage", new aa());
			c.c("goldenEggSoundBoardPage", new c4());
			c.c("goldenEggEaglePage", new bm());
			c.c("goldenEggPiggyPage", new bj());
			c.c("goldenEggRadioPage", new b4());
			c.c("goldenEggKeyboardPage", new b2());
			c.c("goldenEggAccordionPage", new c8());
			c.c("goldenEggSequencerPage", new i());
			c.c("levelCompletedPage", new an());
			c.c("levelFailedPage", new bp());
			c.c("episodeCompletedPage", new bq());
			c.c("gameplayPage", new @as((Game)(object)this));
			c.c("CutSceneGameStart", new ao());
			c.c("CutSceneGameComplete", new aj());
			c.c("CutSceneTheme1Complete", new au());
			c.c("CutSceneTheme2Complete", new ak());
			c.c("CutSceneTheme4Start", new ay());
			c.c("CutSceneTheme4Complete", new a5());
			c.c("CutSceneTheme5Complete", new bx());
			c.c("CutSceneTheme6Start", new ai());
			c.c("CutSceneTheme6Complete", new ba());
			c.c("CutSceneTheme7Complete", new a0());
			c.c("CutSceneTheme8Complete", new j());
			c.c("CutSceneTheme9Start", new bb());
			c.c("CutSceneTheme9Complete", new ag());
			c.c("CutSceneTheme10Complete", new az());
			c.c("CutSceneTheme11Complete", new c7());
			c.c("CutSceneTheme12Start", new af());
			c.c("CutSceneTheme12Complete", new ap());
			c.c("CutSceneTheme13Complete", new cz());
			c.c("CutSceneTheme14Complete", new bz());
			base.Initialize();
			_gameInitialized = true;
			if (_pendingActivation)
			{
				_pendingActivation = false;
				RunOnActivatedLogic();
			}
		}
		catch (GameUpdateRequiredException val)
		{
			GameUpdateRequiredException val2 = val;
			HandleGameUpdateRequired(val2);
		}
	}

	protected override void LoadContent()
	{
		c.c("splashScreen");
		c.f().e();
		d = ((Game)this).Content.Load<SpriteFont>("Font");
	}

	protected override void UnloadContent()
	{
	}

	protected override void Update(GameTime gameTime)
	{
		//IL_00d0: Expected O, but got Unknown
		try
		{
			if (h > 0)
			{
				h--;
				if (h == 0)
				{
					b.SupportedOrientations = (DisplayOrientation)3;
					b.ApplyChanges();
				}
			}
			if (_pendingViewportUpdate)
			{
				_pendingViewportUpdate = false;
				ApplyViewportAndControls();
			}
			if (!i)
			{
				b0.d().d(gameTime, i);
				Controls.GetInstance().Update(gameTime);
				g = Controls.GetInstance().IsTapped;
				if (Controls.GetInstance().IsBackPressed && c.f().a7() == null && (c.f().be() == null || c.f().be().a7() == null))
				{
					((Game)this).Exit();
				}
				c.c(gameTime);
			}
			base.Update(gameTime);
		}
		catch (GameUpdateRequiredException val)
		{
			GameUpdateRequiredException val2 = val;
			HandleGameUpdateRequired(val2);
		}
		if (this.m_a && !Guide.IsVisible)
		{
			Guide.ShowMarketplace((PlayerIndex)0);
			this.m_a = false;
		}
	}

	protected override void Draw(GameTime gameTime)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		bu bu2 = bu.b();
		if (bu2 != null)
		{
			bu2.ClearBackBuffer(new Color(11, 101, 76));
			bu2.d();
			c.d();
			bu2.e();
		}
		if (_displayTitleUpdateMessage && !Guide.IsVisible)
		{
			_displayTitleUpdateMessage = false;
			Guide.BeginShowMessageBox(u.a().e("TEXT_TITLE_UPDATE_TITLE"), u.a().e("TEXT_TITLE_UPDATE_TEXT"), (IEnumerable<string>)_dialogButtons, 1, (MessageBoxIcon)3, (AsyncCallback)UpdateDialogGetMBResult, (object)null);
		}
		base.Draw(gameTime);
	}

	private void OnGameExiting(object sender, EventArgs args)
	{
		global::d.p().p(A_0: true);
		bo.a().a(A_0: true);
	}

	protected override void OnActivated(object sender, EventArgs args)
	{
		i = false;
		if (!_gameInitialized)
		{
			_pendingActivation = true;
			base.OnActivated(sender, args);
			return;
		}

		RunOnActivatedLogic();
		base.OnActivated(sender, args);
	}

	private void RunOnActivatedLogic()
	{
		dc.Init();
		if (b0.d().h())
		{
			b0.d().o();
		}
		else
		{
			b0.d().r();
		}
		if (!dc.IsTrial())
		{
			bw.d().f(a);
			ac ac = c.e()["mainMenu"] as ac;
			ac.au();
			z z = c.e()["episode1"] as z;
			z.az();
			bw.d().d(0, (long)bo.a().e(), (c2.LiveCallback)null);
			w w = c.e()["episode5"] as w;
			w.av();
		}
	}

	protected override void OnDeactivated(object sender, EventArgs args)
	{
		i = true;
		if (b0.d().h())
		{
			b0.d().m();
		}
		else
		{
			b0.d().j();
		}
		@as @as = c.e()["gameplayPage"] as @as;
		if (@as.Equals(c.f()))
		{
			@as.aw();
		}
		base.OnDeactivated(sender, args);
	}

	public void HandleGameUpdateRequired(GameUpdateRequiredException e)
	{
		((GameComponent)this.e).Enabled = false;
		_displayTitleUpdateMessage = true;
		_signinStatus = SigninStatus.UpdateNeeded;
	}

	protected void UpdateDialogGetMBResult(IAsyncResult userResult)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		int? num = Guide.EndShowMessageBox(userResult);
		if (!num.HasValue)
		{
			return;
		}
		if (num.Value > 0)
		{
			if (dc.IsTrial())
			{
				Instance.ShowMarket();
			}
			else
			{
				MarketplaceDetailTask val = new MarketplaceDetailTask();
				val.ContentType = (MarketplaceContentType)1;
				val.Show();
			}
			if (bw.d().e() == bw.LiveState.UpdateRequired)
			{
				bw.d().i();
			}
		}
		else if (bw.d().e() == bw.LiveState.UpdateRequired)
		{
			bw.d().f();
		}
	}

	public void DisableApplicationIdleDetection()
	{
		try
		{
			PhoneApplicationService.Current.ApplicationIdleDetectionMode = (IdleDetectionMode)1;
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void a(object A_0)
	{
	}

	private void ApplyViewportAndControls()
	{
		if (b == null)
		{
			return;
		}

		int width = Math.Max(1, ((Game)this).Window.ClientBounds.Width);
		int height = Math.Max(1, ((Game)this).Window.ClientBounds.Height);
		if (b.PreferredBackBufferWidth != width || b.PreferredBackBufferHeight != height)
		{
			b.PreferredBackBufferWidth = width;
			b.PreferredBackBufferHeight = height;
			b.ApplyChanges();
		}
		int actualWidth = Math.Max(1, ((Game)this).GraphicsDevice.PresentationParameters.BackBufferWidth);
		int actualHeight = Math.Max(1, ((Game)this).GraphicsDevice.PresentationParameters.BackBufferHeight);
		bu.b()?.UpdateViewport(actualWidth, actualHeight);
		Controls.GetInstance()?.SetBackBufferSize(actualWidth, actualHeight);
	}

	private void OnClientSizeChanged(object sender, EventArgs e)
	{
		if (b == null)
		{
			return;
		}

		_pendingViewportUpdate = true;
	}

	public void ShowMarket()
	{
		if (!this.m_a)
		{
			this.m_a = true;
		}
	}
}
