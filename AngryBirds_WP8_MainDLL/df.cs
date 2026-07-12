using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

internal class df : ContentManager
{
	private Dictionary<string, object> m_a = new Dictionary<string, object>();

	private List<IDisposable> b = new List<IDisposable>();

	public df(IServiceProvider A_0, string A_1)
		: base(A_0, A_1)
	{
	}

	public override T Load<T>(string assetName)
	{
		if (this.m_a.ContainsKey(assetName))
		{
			return (T)this.m_a[assetName];
		}
		T val = base.ReadAsset<T>(assetName, (Action<IDisposable>)a);
		this.m_a.Add(assetName, val);
		return val;
	}

	private void a(IDisposable A_0)
	{
		b.Add(A_0);
	}

	public override void Unload()
	{
		foreach (IDisposable item in b)
		{
			item.Dispose();
		}
		this.m_a.Clear();
		b.Clear();
	}

	public bool a(string A_0)
	{
		A_0 = A_0.Replace("Content\\", "");
		if (this.m_a.ContainsKey(A_0))
		{
			if (this.m_a[A_0] is IDisposable && b.Contains((IDisposable)this.m_a[A_0]))
			{
				IDisposable disposable = (IDisposable)this.m_a[A_0];
				b.Remove(disposable);
				disposable.Dispose();
			}
			this.m_a.Remove(A_0);
			return true;
		}
		return false;
	}
}
