using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AngryBirds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;

internal class bw
{
	public enum LiveState
	{
		Unknown,
		WaitingForLIVE,
		WaitingForProfile,
		WaitingForAvatar,
		WaitingForAchievements,
		WaitingForLeaderboard,
		UpdateRequired,
		Disabled,
		Ready,
		Error
	}

	public delegate void b(GameUpdateRequiredException A_0);

	private delegate void AsyncHandler(c2.LiveCallback A_0);

	private LiveState m_a = LiveState.WaitingForLIVE;

	private object m_b = new object();

	private AchievementCollection c;

	private object m_d = new object();

	private LeaderboardReader m_e;

	private object m_f = new object();

	private GraphicsDevice m_g;

	private static bw m_h;

	private List<string> m_i;

	private AsyncHandler m_j;

	private c2.LiveCallback k;

	private b l;

	[SpecialName]
	public LiveState e()
	{
		return this.m_a;
	}

	public static bw d()
	{
		if (bw.m_h == null)
		{
			bw.m_h = new bw();
		}
		return bw.m_h;
	}

	public void d(b A_0)
	{
		l = A_0;
		this.m_g = bu.a;
		SignedInGamer.SignedIn += d;
	}

	protected bw()
	{
		this.m_i = new List<string>();
	}

	private void EnsureDialogButtons()
	{
		if (this.m_i.Count == 0)
		{
			this.m_i.Add(u.a().e("SK_NO"));
			this.m_i.Add(u.a().e("SK_YES"));
		}
	}

	protected void d(object A_0, SignedInEventArgs A_1)
	{
		SignedInGamer gamer = A_1.Gamer;
		if (gamer != null)
		{
			if (this.m_a == LiveState.WaitingForLIVE)
			{
				this.m_a = LiveState.Ready;
			}
			e((c2.LiveCallback)null);
		}
	}

	protected void d(IAsyncResult A_0)
	{
		c2 c10 = A_0.AsyncState as c2;
		object obj = c10.b;
		SignedInGamer val = (SignedInGamer)((obj is SignedInGamer) ? obj : null);
		if (val == null)
		{
			return;
		}
		lock (this.m_b)
		{
			try
			{
				val.EndAwardAchievement(A_0);
				this.m_a = LiveState.Ready;
			}
			catch (Exception ex)
			{
				GameUpdateRequiredException val2 = (GameUpdateRequiredException)(object)((ex is GameUpdateRequiredException) ? ex : null);
				if (val2 != null)
				{
					this.m_a = LiveState.UpdateRequired;
					l(val2);
					return;
				}
				this.m_a = LiveState.Error;
			}
		}
		if (this.m_a == LiveState.Ready)
		{
			val.BeginGetAchievements((AsyncCallback)e, (object)c10);
			this.m_a = LiveState.WaitingForAchievements;
		}
		else if (this.m_a == LiveState.Error && c10.a != null)
		{
			c10.a(null);
		}
	}

	protected void e(IAsyncResult A_0)
	{
		c2 c10 = A_0.AsyncState as c2;
		object obj = c10.b;
		SignedInGamer val = (SignedInGamer)((obj is SignedInGamer) ? obj : null);
		if (val == null)
		{
			return;
		}
		lock (this.m_b)
		{
			try
			{
				c = val.EndGetAchievements(A_0);
				if (this.m_a != LiveState.Disabled)
				{
					this.m_a = LiveState.Ready;
				}
			}
			catch (Exception ex)
			{
				if (this.m_a != LiveState.Disabled)
				{
					GameUpdateRequiredException val2 = (GameUpdateRequiredException)(object)((ex is GameUpdateRequiredException) ? ex : null);
					if (val2 != null)
					{
						this.m_a = LiveState.UpdateRequired;
						l(val2);
						return;
					}
					this.m_a = LiveState.Error;
				}
			}
			if (this.m_a == LiveState.Error)
			{
				if (c10.a != null)
				{
					c10.a(null);
				}
			}
			else if (c10.a != null)
			{
				c10.a(c);
			}
		}
	}

	protected void g(IAsyncResult A_0)
	{
		c2 c10 = A_0.AsyncState as c2;
		object obj = c10.b;
		SignedInGamer val = (SignedInGamer)((obj is SignedInGamer) ? obj : null);
		if (val == null)
		{
			return;
		}
		lock (this.m_d)
		{
			try
			{
				this.m_e = LeaderboardReader.EndRead(A_0);
				this.m_a = LiveState.Ready;
			}
			catch (Exception ex)
			{
				GameUpdateRequiredException val2 = (GameUpdateRequiredException)(object)((ex is GameUpdateRequiredException) ? ex : null);
				if (val2 != null)
				{
					if (this.m_a != LiveState.Disabled)
					{
						this.m_a = LiveState.UpdateRequired;
						l(val2);
						if (c10.a != null)
						{
							c10.a(null);
						}
						return;
					}
					this.m_a = LiveState.Error;
				}
				else
				{
					_ = ex.Message;
					this.m_a = LiveState.Error;
				}
			}
		}
		if (this.m_a == LiveState.Error || this.m_a == LiveState.UpdateRequired)
		{
			string a_ = this.m_a.ToString();
			if (c10.a != null)
			{
				c10.a(a_);
			}
		}
		else if (c10.a != null)
		{
			c10.a(this.m_e);
		}
	}

	protected void f(IAsyncResult A_0)
	{
		c2 c10 = A_0.AsyncState as c2;
		object obj = c10.b;
		SignedInGamer val = (SignedInGamer)((obj is SignedInGamer) ? obj : null);
		if (val == null)
		{
			return;
		}
		lock (this.m_d)
		{
			try
			{
				this.m_e.EndPageUp(A_0);
				this.m_a = LiveState.Ready;
			}
			catch (Exception ex)
			{
				GameUpdateRequiredException val2 = (GameUpdateRequiredException)(object)((ex is GameUpdateRequiredException) ? ex : null);
				if (val2 != null)
				{
					this.m_a = LiveState.UpdateRequired;
					l(val2);
					return;
				}
				this.m_a = LiveState.Error;
			}
		}
		if (this.m_a == LiveState.Error)
		{
			if (c10.a != null)
			{
				c10.a(null);
			}
		}
		else if (c10.a != null)
		{
			c10.a(this.m_e);
		}
	}

	protected void h(IAsyncResult A_0)
	{
		c2 c10 = A_0.AsyncState as c2;
		object obj = c10.b;
		SignedInGamer val = (SignedInGamer)((obj is SignedInGamer) ? obj : null);
		if (val == null)
		{
			return;
		}
		lock (this.m_d)
		{
			try
			{
				this.m_e.EndPageDown(A_0);
				if (c10.a != null)
				{
					c10.a(this.m_e);
				}
			}
			catch (Exception ex)
			{
				GameUpdateRequiredException val2 = (GameUpdateRequiredException)(object)((ex is GameUpdateRequiredException) ? ex : null);
				if (val2 != null)
				{
					this.m_a = LiveState.UpdateRequired;
					l(val2);
					return;
				}
				this.m_a = LiveState.Error;
				if (c10.a != null)
				{
					c10.a(null);
				}
			}
		}
		if (this.m_a == LiveState.Error)
		{
			if (c10.a != null)
			{
				c10.a(null);
			}
		}
		else if (c10.a != null)
		{
			c10.a(this.m_e);
		}
	}

	[SpecialName]
	public bool h()
	{
		if (this.m_e == null)
		{
			return false;
		}
		return this.m_e.CanPageUp;
	}

	[SpecialName]
	public bool g()
	{
		if (this.m_e == null)
		{
			return false;
		}
		return this.m_e.CanPageDown;
	}

	public void e(c2.LiveCallback A_0)
	{
		SignedInGamer val = Gamer.SignedInGamers[(PlayerIndex)0];
		if (val != null)
		{
			c2 c10 = new c2();
			c10.a = A_0;
			c10.b = val;
			val.BeginGetAchievements((AsyncCallback)e, (object)c10);
		}
	}

	public void d(int A_0, long A_1, c2.LiveCallback A_2)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (this.m_a == LiveState.Disabled || this.m_a == LiveState.UpdateRequired)
		{
			A_2?.Invoke(null);
			return;
		}
		SignedInGamer val = Gamer.SignedInGamers[(PlayerIndex)0];
		if (val == null || dc.IsTrial())
		{
			return;
		}
		lock (this.m_d)
		{
			this.m_a = LiveState.WaitingForLeaderboard;
			LeaderboardKey val2 = (LeaderboardKey)0;
			if (A_0 == 0)
			{
				val2 = (LeaderboardKey)0;
			}
			LeaderboardIdentity val3 = LeaderboardIdentity.Create(val2, A_0);
			LeaderboardEntry leaderboard = ((Gamer)val).LeaderboardWriter.GetLeaderboard(val3);
			leaderboard.Rating = A_1;
		}
		A_2?.Invoke(null);
	}

	public void d(int A_0, int A_1, c2.LiveCallback A_2)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (this.m_a == LiveState.Disabled || this.m_a == LiveState.UpdateRequired)
		{
			A_2?.Invoke(null);
			return;
		}
		SignedInGamer val = Gamer.SignedInGamers[(PlayerIndex)0];
		if (val == null)
		{
			return;
		}
		lock (this.m_d)
		{
			this.m_a = LiveState.WaitingForLeaderboard;
			c2 c10 = new c2();
			c10.a = A_2;
			c10.b = val;
			LeaderboardKey val2 = (LeaderboardKey)0;
			if (A_0 == 0)
			{
				val2 = (LeaderboardKey)0;
			}
			LeaderboardIdentity val3 = LeaderboardIdentity.Create(val2, A_0);
			LeaderboardReader.BeginRead(val3, (IEnumerable<Gamer>)val.GetFriends(), (Gamer)(object)val, A_1, (AsyncCallback)g, (object)c10);
		}
	}

	public void d(c2.LiveCallback A_0)
	{
		if (this.m_a == LiveState.Disabled || this.m_a == LiveState.UpdateRequired)
		{
			A_0?.Invoke(null);
			return;
		}
		SignedInGamer val = Gamer.SignedInGamers[(PlayerIndex)0];
		if (val == null || this.m_e == null)
		{
			return;
		}
		lock (this.m_d)
		{
			this.m_a = LiveState.WaitingForLeaderboard;
			c2 c10 = new c2();
			c10.a = A_0;
			c10.b = val;
			this.m_e.BeginPageUp((AsyncCallback)f, (object)c10);
		}
	}

	public void i(c2.LiveCallback A_0)
	{
		if (this.m_a == LiveState.Disabled || this.m_a == LiveState.UpdateRequired)
		{
			A_0?.Invoke(null);
			return;
		}
		SignedInGamer val = Gamer.SignedInGamers[(PlayerIndex)0];
		if (val == null || this.m_e == null)
		{
			return;
		}
		lock (this.m_d)
		{
			this.m_a = LiveState.WaitingForLeaderboard;
			c2 c10 = new c2();
			c10.a = A_0;
			c10.b = val;
			this.m_e.BeginPageDown((AsyncCallback)h, (object)c10);
		}
	}

	public void d(string A_0, c2.LiveCallback A_1)
	{
		if (this.m_a == LiveState.Disabled || this.m_a == LiveState.UpdateRequired)
		{
			A_1?.Invoke(null);
			return;
		}
		if (dc.IsTrial())
		{
			if (!global::d.p().t(A_0))
			{
				global::d.p().q(A_0);
				if (!Guide.IsVisible)
				{
					EnsureDialogButtons();
					Guide.BeginShowMessageBox(u.a().e("TEXT_PURCHASE_FULL_GAME"), u.a().e("TEXT_TRIAL_ACHIEVEMENT"), (IEnumerable<string>)this.m_i, 1, (MessageBoxIcon)3, (AsyncCallback)i, (object)null);
				}
			}
			return;
		}
		SignedInGamer val = Gamer.SignedInGamers[(PlayerIndex)0];
		if (val == null)
		{
			return;
		}
		if (c != null)
		{
			lock (this.m_b)
			{
				foreach (Achievement item in c)
				{
					if (item.Key == A_0)
					{
						if (!item.IsEarned)
						{
							c2 c10 = new c2();
							c10.a = A_1;
							c10.b = val;
							val.BeginAwardAchievement(A_0, (AsyncCallback)d, (object)c10);
							this.m_a = LiveState.WaitingForAchievements;
						}
						break;
					}
				}
				return;
			}
		}
		this.m_j = f;
		k = A_1;
		e(d);
	}

	public void g(c2.LiveCallback A_0)
	{
		if (this.m_a == LiveState.Disabled || this.m_a == LiveState.UpdateRequired)
		{
			A_0?.Invoke(null);
			return;
		}
		d d2 = global::d.p();
		bo.a();
		di.d();
		int num = 0;
		num += d2.b;
		num += d2.c;
		num += d2.d_value;
		if (d2.b >= 5000)
		{
			d("Woodpecker", A_0);
		}
		if (d2.d_value >= 5000)
		{
			d("Stonecutter", A_0);
		}
		if (d2.c >= 5000)
		{
			d("Icepicker", A_0);
		}
		if (d2.e >= 1000)
		{
			d("Pig Popper", A_0);
		}
		if (num >= 50000)
		{
			d("Block Smasher", A_0);
		}
		if (num >= 250000)
		{
			d("Smash Maniac", A_0);
		}
		if (d2.ae() >= 10)
		{
			d("Egg Hunter", A_0);
		}
	}

	public void j(c2.LiveCallback A_0)
	{
		if (this.m_a == LiveState.Disabled || this.m_a == LiveState.UpdateRequired)
		{
			A_0?.Invoke(null);
			return;
		}
		d d2 = global::d.p();
		bo.a();
		di.d();
		if (d2.p("BIRD_BLUE"))
		{
			d("Split it", A_0);
		}
		if (d2.p("BIRD_YELLOW"))
		{
			d("Speed is the Essence", A_0);
		}
		if (d2.p("BIRD_GREY"))
		{
			d("Boom Boom", A_0);
		}
		if (d2.p("BIRD_GREEN"))
		{
			d("Mother of all Bombs", A_0);
		}
		if (d2.p("BIRD_BOOMERANG"))
		{
			d("Return to Sender", A_0);
		}
		if (d2.p("BIRD_BIG_BROTHER"))
		{
			d("Seeing Red", A_0);
		}
	}

	public void h(c2.LiveCallback A_0)
	{
		if (this.m_a == LiveState.Disabled || this.m_a == LiveState.UpdateRequired)
		{
			A_0?.Invoke(null);
			return;
		}
		global::d.p();
		bo bo2 = bo.a();
		di.d();
		if (bo2.a("pack1"))
		{
			d("Just Getting Started", A_0);
		}
		if (bo2.a("pack3"))
		{
			d("Defeat of The King", A_0);
		}
		if (bo2.a("pack5"))
		{
			d("The Mysterious Escape", A_0);
		}
		if (bo2.a("pack8"))
		{
			d("Green Baron", A_0);
		}
		if (bo2.c("episode1"))
		{
			d("Episode 1 Total Destruction", A_0);
		}
		if (bo2.c("episode2"))
		{
			d("Episode 2 Total Destruction", A_0);
		}
		if (bo2.c("episode3"))
		{
			d("Episode 3 Total Destruction", A_0);
		}
	}

	public void f(c2.LiveCallback A_0)
	{
		if (this.m_a == LiveState.Disabled || this.m_a == LiveState.UpdateRequired)
		{
			A_0?.Invoke(null);
			return;
		}
		j(A_0);
		h(A_0);
		g(A_0);
	}

	protected void i(IAsyncResult A_0)
	{
		int? num = Guide.EndShowMessageBox(A_0);
		if (num.HasValue && num.Value > 0)
		{
			GameMain.Instance.ShowMarket();
		}
	}

	private void d(object A_0)
	{
		AsyncHandler asyncHandler = this.m_j;
		c2.LiveCallback liveCallback = k;
		this.m_j = null;
		k = null;
		if (asyncHandler == null)
		{
			return;
		}
		asyncHandler(liveCallback);
	}

	public void i()
	{
		this.m_a = LiveState.Ready;
	}

	public void f()
	{
		this.m_a = LiveState.Disabled;
	}
}
