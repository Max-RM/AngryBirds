using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Microsoft.Xna.Framework;

namespace Microsoft.Xna.Framework.GamerServices;

public enum MessageBoxIcon
{
    Alert = 0,
    Error = 1,
    Warning = 2,
    None = 3
}

public enum LeaderboardKey
{
    Default = 0
}

public class GameUpdateRequiredException : Exception
{
    public GameUpdateRequiredException()
    {
    }

    public GameUpdateRequiredException(string message)
        : base(message)
    {
    }
}

public class Gamer
{
    private static readonly SignedInGamerCollection SignedInGamersInternal = new();
    private static readonly LocalSignedInGamer LocalGamer = new();

    static Gamer()
    {
        SignedInGamersInternal.Add(LocalGamer);
    }

    public static SignedInGamerCollection SignedInGamers => SignedInGamersInternal;

    public string Gamertag { get; protected set; } = "Player";

    public LeaderboardWriter LeaderboardWriter { get; } = new();
}

public class SignedInGamerCollection : IEnumerable<SignedInGamer>
{
    private readonly List<SignedInGamer> gamers = new();

    public SignedInGamer this[PlayerIndex index]
    {
        get
        {
            if (gamers.Count == 0)
            {
                return null;
            }

            int i = (int)index;
            return i >= 0 && i < gamers.Count ? gamers[i] : gamers[0];
        }
    }

    public int Count => gamers.Count;

    internal void Add(SignedInGamer gamer)
    {
        gamers.Add(gamer);
    }

    public IEnumerator<SignedInGamer> GetEnumerator()
    {
        return gamers.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class SignedInEventArgs : EventArgs
{
    public SignedInGamer Gamer { get; }

    public SignedInEventArgs(SignedInGamer gamer)
    {
        Gamer = gamer;
    }
}

public class SignedInGamer : Gamer
{
    public static event SignedInEventHandler SignedIn;

    public SignedInGamer()
    {
        Gamertag = "Player";
    }

    internal static void RaiseSignedIn()
    {
        SignedIn?.Invoke(null, new SignedInEventArgs((SignedInGamer)Gamer.SignedInGamers[PlayerIndex.One]));
    }

    public IEnumerable<Gamer> GetFriends()
    {
        yield return this;
    }

    public IAsyncResult BeginGetAchievements(AsyncCallback callback, object state)
    {
        return AsyncStub.Run(callback, state, _ => new AchievementCollection());
    }

    public AchievementCollection EndGetAchievements(IAsyncResult result)
    {
        return AsyncStub.GetResult<AchievementCollection>(result);
    }

    public IAsyncResult BeginAwardAchievement(string achievementId, AsyncCallback callback, object state)
    {
        return AsyncStub.Run(callback, state, _ => { });
    }

    public void EndAwardAchievement(IAsyncResult result)
    {
        AsyncStub.Complete(result);
    }
}

public delegate void SignedInEventHandler(object sender, SignedInEventArgs e);

internal sealed class LocalSignedInGamer : SignedInGamer
{
}

public class Achievement
{
    public string Key { get; set; } = string.Empty;
    public bool IsEarned { get; set; }
    public int GamerScore { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public byte[] GetPicture() => Array.Empty<byte>();

    public Stream GetPictureStream() => new MemoryStream(GetPicture());
    public string HowToEarn { get; set; } = string.Empty;
}

public class AchievementCollection : IEnumerable<Achievement>
{
    private readonly List<Achievement> achievements = new();

    public int Count => achievements.Count;

    public void Add(Achievement achievement)
    {
        achievements.Add(achievement);
    }

    public IEnumerator<Achievement> GetEnumerator()
    {
        return achievements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class LeaderboardIdentity
{
    public static LeaderboardIdentity Create(LeaderboardKey key, int leaderboardId)
    {
        return new LeaderboardIdentity { Key = key, Id = leaderboardId };
    }

    public LeaderboardKey Key { get; private set; }
    public int Id { get; private set; }
}

public class LeaderboardEntry
{
    public Gamer Gamer { get; set; } = new Gamer();
    public long Rating { get; set; }
}

public class LeaderboardWriter
{
    private readonly Dictionary<string, LeaderboardEntry> entries = new();

    public LeaderboardEntry GetLeaderboard(LeaderboardIdentity identity)
    {
        string id = identity.Id.ToString();
        if (!entries.TryGetValue(id, out LeaderboardEntry entry))
        {
            entry = new LeaderboardEntry();
            entries[id] = entry;
        }

        return entry;
    }
}

public class LeaderboardReader
{
    private readonly List<LeaderboardEntry> entries = new();

    public bool CanPageUp { get; set; }
    public bool CanPageDown { get; set; }
    public int PageStart { get; set; }
    public IList<LeaderboardEntry> Entries => entries;

    public static void BeginRead(
        LeaderboardIdentity identity,
        IEnumerable<Gamer> gamers,
        Gamer currentGamer,
        int page,
        AsyncCallback callback,
        object state)
    {
        var reader = new LeaderboardReader();
        AsyncStub.Run(callback, state, _ => reader);
    }

    public static LeaderboardReader EndRead(IAsyncResult result)
    {
        return AsyncStub.GetResult<LeaderboardReader>(result);
    }

    public IAsyncResult BeginPageUp(AsyncCallback callback, object state)
    {
        return AsyncStub.Run(callback, state, _ => { });
    }

    public void EndPageUp(IAsyncResult result)
    {
        AsyncStub.Complete(result);
    }

    public IAsyncResult BeginPageDown(AsyncCallback callback, object state)
    {
        return AsyncStub.Run(callback, state, _ => { });
    }

    public void EndPageDown(IAsyncResult result)
    {
        AsyncStub.Complete(result);
    }
}

public static class Guide
{
    private static readonly Dictionary<IAsyncResult, int> MessageBoxResults = new();
    private static int messageBoxCounter;

    public static bool IsVisible { get; private set; }
    public static bool IsTrialMode { get; set; }
    public static bool IsScreenSaverEnabled { get; set; }

    public static void ShowMarketplace(PlayerIndex player)
    {
    }

    public static IAsyncResult BeginShowMessageBox(
        string title,
        string text,
        IEnumerable<string> buttons,
        int focusButton,
        MessageBoxIcon icon,
        AsyncCallback callback,
        object state)
    {
        IsVisible = true;
        int result = 0;
        try
        {
            var buttonList = new List<string>(buttons ?? Array.Empty<string>());
            if (buttonList.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show(text, title);
            }
            else if (buttonList.Count == 1)
            {
                System.Windows.Forms.MessageBox.Show(text, title);
                result = 0;
            }
            else
            {
                var dialogResult = System.Windows.Forms.MessageBox.Show(
                    text,
                    title,
                    System.Windows.Forms.MessageBoxButtons.YesNo);
                result = dialogResult == System.Windows.Forms.DialogResult.Yes ? 1 : 0;
            }
        }
        finally
        {
            IsVisible = false;
        }

        var asyncResult = new MessageBoxAsyncResult(++messageBoxCounter, state, result);
        MessageBoxResults[asyncResult] = result;
        callback?.Invoke(asyncResult);
        return asyncResult;
    }

    public static int? EndShowMessageBox(IAsyncResult result)
    {
        if (result is MessageBoxAsyncResult messageBoxResult)
        {
            return messageBoxResult.SelectedButton;
        }

        if (MessageBoxResults.TryGetValue(result, out int value))
        {
            MessageBoxResults.Remove(result);
            return value;
        }

        return 0;
    }

    private sealed class MessageBoxAsyncResult : IAsyncResult
    {
        public MessageBoxAsyncResult(int id, object asyncState, int selectedButton)
        {
            Id = id;
            AsyncState = asyncState;
            SelectedButton = selectedButton;
            IsCompleted = true;
            CompletedSynchronously = true;
        }

        public int Id { get; }
        public int SelectedButton { get; }
        public object AsyncState { get; }
        public bool IsCompleted { get; }
        public bool CompletedSynchronously { get; }
        public WaitHandle AsyncWaitHandle => null;
    }
}

public class GamerServicesComponent : GameComponent
{
    private bool signedInRaised;

    public GamerServicesComponent(Game game)
        : base(game)
    {
    }

    public override void Update(GameTime gameTime)
    {
        if (!signedInRaised)
        {
            signedInRaised = true;
            SignedInGamer.RaiseSignedIn();
        }

        base.Update(gameTime);
    }
}

internal static class AsyncStub
{
    public static IAsyncResult Run<T>(AsyncCallback callback, object state, Func<IAsyncResult, T> work)
    {
        var result = new SimpleAsyncResult(state);
        ThreadPool.QueueUserWorkItem(_ =>
        {
            try
            {
                result.Result = work(result);
                result.MarkCompleted();
                callback?.Invoke(result);
            }
            catch (Exception ex)
            {
                result.Error = ex;
                result.MarkCompleted();
                callback?.Invoke(result);
            }
        });
        return result;
    }

    public static IAsyncResult Run(AsyncCallback callback, object state, Action<IAsyncResult> work)
    {
        return Run(callback, state, ar =>
        {
            work(ar);
            return true;
        });
    }

    public static T GetResult<T>(IAsyncResult result)
    {
        Complete(result);
        return ((SimpleAsyncResult)result).GetResult<T>();
    }

    public static void Complete(IAsyncResult result)
    {
        var simple = (SimpleAsyncResult)result;
        simple.Wait();
        if (simple.Error != null)
        {
            throw simple.Error;
        }
    }

    private sealed class SimpleAsyncResult : IAsyncResult
    {
        private readonly ManualResetEvent handle = new(false);

        public SimpleAsyncResult(object asyncState)
        {
            AsyncState = asyncState;
        }

        public object Result { get; set; }
        public Exception Error { get; set; }
        public object AsyncState { get; }
        public bool IsCompleted { get; private set; }
        public bool CompletedSynchronously => false;
        public WaitHandle AsyncWaitHandle => handle;

        public void MarkCompleted()
        {
            IsCompleted = true;
            handle.Set();
        }

        public void Wait()
        {
            if (!IsCompleted)
            {
                handle.WaitOne();
            }
        }

        public T GetResult<T>()
        {
            return Result is T typed ? typed : default;
        }
    }
}
