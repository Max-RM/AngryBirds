using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;

namespace AngryBirds;

public sealed class Controls
{
	private static volatile Controls a;

	private static object b = new object();

	private TouchPanelCapabilities c;

	private bool useMouseEmulation;

	private bool mouseWasPressed;

	private Vector2 mousePosition;

	private Vector2 previousMousePosition;

	private Vector2 mouseDownPosition;

	private TimeSpan mouseDownTime;

	private int previousMouseWheelValue;

	private bool mouseWheelInitialized;

	private float viewportScale = 1f;

	private Vector2 viewportOffset;

	[CompilerGenerated]
	private List<GestureSample> d;

	[CompilerGenerated]
	private List<GestureSample> e;

	[CompilerGenerated]
	private List<GestureSample> f;

	[CompilerGenerated]
	private List<GestureSample> g;

	[CompilerGenerated]
	private List<GestureSample> h;

	[CompilerGenerated]
	private List<GestureSample> i;

	[CompilerGenerated]
	private List<GestureSample> j;

	[CompilerGenerated]
	private bool k;

	[CompilerGenerated]
	private bool l;

	[CompilerGenerated]
	private bool m;

	[CompilerGenerated]
	private bool n;

	[CompilerGenerated]
	private bool o;

	[CompilerGenerated]
	private bool p;

	[CompilerGenerated]
	private bool q;

	[CompilerGenerated]
	private bool r;

	[CompilerGenerated]
	private bool s;

	[CompilerGenerated]
	private bool t;

	[CompilerGenerated]
	private bool u;

	[CompilerGenerated]
	private List<TouchLocation> v;

	[CompilerGenerated]
	private int w;

	public List<GestureSample> TapGestures
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

	public List<GestureSample> DoubleTapGestures
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

	public List<GestureSample> HoldGestures
	{
		[CompilerGenerated]
		get
		{
			return f;
		}
		[CompilerGenerated]
		private set
		{
			f = value;
		}
	}

	public List<GestureSample> DragGestures
	{
		[CompilerGenerated]
		get
		{
			return g;
		}
		[CompilerGenerated]
		private set
		{
			g = value;
		}
	}

	public List<GestureSample> DragCompletedGestures
	{
		[CompilerGenerated]
		get
		{
			return h;
		}
		[CompilerGenerated]
		private set
		{
			h = value;
		}
	}

	public List<GestureSample> FlickGestures
	{
		[CompilerGenerated]
		get
		{
			return i;
		}
		[CompilerGenerated]
		private set
		{
			i = value;
		}
	}

	public List<GestureSample> PinchGestures
	{
		[CompilerGenerated]
		get
		{
			return j;
		}
		[CompilerGenerated]
		private set
		{
			j = value;
		}
	}

	public bool IsTapped
	{
		[CompilerGenerated]
		get
		{
			return k;
		}
		[CompilerGenerated]
		private set
		{
			k = value;
		}
	}

	public bool IsDoubleTapped
	{
		[CompilerGenerated]
		get
		{
			return l;
		}
		[CompilerGenerated]
		private set
		{
			l = value;
		}
	}

	public bool IsHold
	{
		[CompilerGenerated]
		get
		{
			return m;
		}
		[CompilerGenerated]
		private set
		{
			m = value;
		}
	}

	public bool IsDragged
	{
		[CompilerGenerated]
		get
		{
			return n;
		}
		[CompilerGenerated]
		private set
		{
			n = value;
		}
	}

	public bool IsDragCompleted
	{
		[CompilerGenerated]
		get
		{
			return o;
		}
		[CompilerGenerated]
		private set
		{
			o = value;
		}
	}

	public bool IsFlicked
	{
		[CompilerGenerated]
		get
		{
			return p;
		}
		[CompilerGenerated]
		private set
		{
			p = value;
		}
	}

	public bool IsPinched
	{
		[CompilerGenerated]
		get
		{
			return q;
		}
		[CompilerGenerated]
		private set
		{
			q = value;
		}
	}

	public bool IsPinchCompleted
	{
		[CompilerGenerated]
		get
		{
			return r;
		}
		[CompilerGenerated]
		private set
		{
			r = value;
		}
	}

	public bool IsBackPressed
	{
		[CompilerGenerated]
		get
		{
			return s;
		}
		[CompilerGenerated]
		private set
		{
			s = value;
		}
	}

	public bool IsTouchPressed
	{
		[CompilerGenerated]
		get
		{
			return t;
		}
		[CompilerGenerated]
		private set
		{
			t = value;
		}
	}

	public bool IsTouchReleased
	{
		[CompilerGenerated]
		get
		{
			return u;
		}
		[CompilerGenerated]
		private set
		{
			u = value;
		}
	}

	public List<TouchLocation> Touches
	{
		[CompilerGenerated]
		get
		{
			return v;
		}
		[CompilerGenerated]
		private set
		{
			v = value;
		}
	}

	public int MaxPoints
	{
		[CompilerGenerated]
		get
		{
			return w;
		}
		[CompilerGenerated]
		private set
		{
			w = value;
		}
	}

	private Controls()
	{
	}

	public static Controls GetInstance()
	{
		if (a == null)
		{
			lock (b)
			{
				if (a == null)
				{
					a = new Controls();
				}
			}
		}
		return a;
	}

	public void Initialize()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MaxPoints = 0;
		c = TouchPanel.GetCapabilities();
		useMouseEmulation = true;
		MaxPoints = Math.Max(1, c.IsConnected ? c.MaximumTouchCount : 1);
		if (MaxPoints > 0)
		{
			TapGestures = new List<GestureSample>(MaxPoints);
			DoubleTapGestures = new List<GestureSample>(MaxPoints);
			HoldGestures = new List<GestureSample>(MaxPoints);
			DragGestures = new List<GestureSample>(MaxPoints);
			DragCompletedGestures = new List<GestureSample>(MaxPoints);
			FlickGestures = new List<GestureSample>(MaxPoints);
			PinchGestures = new List<GestureSample>(MaxPoints);
			Touches = new List<TouchLocation>(MaxPoints);
		}
		TouchPanel.EnabledGestures = GestureType.Tap | GestureType.DoubleTap | GestureType.Hold | GestureType.FreeDrag | GestureType.DragComplete | GestureType.Flick | GestureType.Pinch | GestureType.PinchComplete;
		SetBackBufferSize(800, 480);
		previousMouseWheelValue = Mouse.GetState().ScrollWheelValue;
		mouseWheelInitialized = true;
	}

	public void SetBackBufferSize(int width, int height)
	{
		const float logicalWidth = 800f;
		const float logicalHeight = 480f;
		viewportScale = MathHelper.Max(0.001f, MathHelper.Min(width / logicalWidth, height / logicalHeight));
		int viewportWidth = (int)(logicalWidth * viewportScale);
		int viewportHeight = (int)(logicalHeight * viewportScale);
		viewportOffset = new Vector2((width - viewportWidth) / 2f, (height - viewportHeight) / 2f);
	}

	private Vector2 MapToLogical(Vector2 screenPosition)
	{
		return (screenPosition - viewportOffset) / viewportScale;
	}

	public void Update(GameTime gameTime)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected I4, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Invalid comparison between Unknown and I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between Unknown and I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected I4, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Invalid comparison between Unknown and I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Invalid comparison between Unknown and I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Invalid comparison between Unknown and I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Invalid comparison between Unknown and I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		TapGestures.Clear();
		DoubleTapGestures.Clear();
		HoldGestures.Clear();
		DragGestures.Clear();
		FlickGestures.Clear();
		PinchGestures.Clear();
		DragCompletedGestures.Clear();
		Touches.Clear();
		IsTapped = false;
		IsDoubleTapped = false;
		IsHold = false;
		IsDragged = false;
		IsDragCompleted = false;
		IsFlicked = false;
		IsPinched = false;
		IsPinchCompleted = false;
		IsBackPressed = false;
		IsTouchPressed = false;
		IsTouchReleased = false;
		GamePadState state = GamePad.GetState((PlayerIndex)0);
		GamePadButtons buttons = state.Buttons;
		if ((int)buttons.Back == 1)
		{
			IsBackPressed = true;
		}
		KeyboardState keyboard = Keyboard.GetState();
		if (keyboard.IsKeyDown(Keys.Escape) || keyboard.IsKeyDown(Keys.Back))
		{
			IsBackPressed = true;
		}
		if (c.IsConnected)
		{
			UpdateTouchPanel();
		}
		if (useMouseEmulation || OperatingSystem.IsWindows())
		{
			UpdateMouseEmulation(gameTime, c.IsConnected);
		}
	}

	private void UpdateTouchPanel()
	{
		TouchCollection state2 = TouchPanel.GetState();
		for (int i = 0; i < state2.Count; i++)
		{
			TouchLocation item = state2[i];
			TouchLocationState state3 = item.State;
			switch (state3)
			{
			case TouchLocationState.Pressed:
				IsTouchPressed = true;
				IsTouchReleased = false;
				break;
			case TouchLocationState.Released:
				IsTouchPressed = false;
				IsTouchReleased = true;
				break;
			}
			Touches.Add(new TouchLocation(item.Id, item.State, MapToLogical(item.Position)));
		}
		while (TouchPanel.IsGestureAvailable)
		{
			GestureSample item2 = TouchPanel.ReadGesture();
			Vector2 logicalPosition = MapToLogical(item2.Position);
			Vector2 logicalPosition2 = MapToLogical(item2.Position2);
			Vector2 logicalDelta = item2.Delta / viewportScale;
			Vector2 logicalDelta2 = item2.Delta2 / viewportScale;
			GestureSample mapped = new GestureSample(item2.GestureType, item2.Timestamp, logicalPosition, logicalPosition2, logicalDelta, logicalDelta2);
			GestureType gestureType = mapped.GestureType;
			switch (gestureType)
			{
			case GestureType.DoubleTap:
				DoubleTapGestures.Add(mapped);
				IsDoubleTapped = true;
				continue;
			case GestureType.Tap:
				TapGestures.Add(mapped);
				IsTapped = true;
				continue;
			case GestureType.Hold:
				HoldGestures.Add(mapped);
				IsHold = true;
				continue;
			case GestureType.FreeDrag:
				DragGestures.Add(mapped);
				IsDragged = true;
				continue;
			case GestureType.Flick:
				FlickGestures.Add(mapped);
				IsFlicked = true;
				continue;
			case GestureType.DragComplete:
				DragCompletedGestures.Add(mapped);
				IsDragCompleted = true;
				continue;
			case GestureType.Pinch:
				IsPinched = true;
				PinchGestures.Add(mapped);
				continue;
			case GestureType.PinchComplete:
				IsPinchCompleted = true;
				PinchGestures.Add(mapped);
				continue;
			}
		}
	}

	private void UpdateMouseEmulation(GameTime gameTime, bool suppressWhenTouchTap)
	{
		MouseState mouse = Mouse.GetState();
		UpdateMouseWheelPinch(gameTime, mouse);

		if (suppressWhenTouchTap && (Touches.Count > 0 || IsTapped || IsDoubleTapped || IsDragged || IsDragCompleted))
		{
			mouseWasPressed = false;
			return;
		}

		mousePosition = MapToLogical(new Vector2(mouse.X, mouse.Y));
		bool mousePressed = mouse.LeftButton == ButtonState.Pressed;
		if (mousePressed)
		{
			if (!mouseWasPressed)
			{
				mouseDownPosition = mousePosition;
				mouseDownTime = gameTime.TotalGameTime;
				previousMousePosition = mousePosition;
				IsTouchPressed = true;
				Touches.Add(new TouchLocation(0, TouchLocationState.Pressed, mousePosition));
			}
			else
			{
				Vector2 delta = mousePosition - previousMousePosition;
				Touches.Add(new TouchLocation(0, TouchLocationState.Moved, mousePosition));
				IsDragged = true;
				DragGestures.Add(new GestureSample(GestureType.FreeDrag, gameTime.TotalGameTime, mousePosition, Vector2.Zero, delta, Vector2.Zero));
			}
		}
		else if (mouseWasPressed)
		{
			Vector2 totalDrag = mousePosition - mouseDownPosition;
			double elapsedSeconds = Math.Max(0.001, (gameTime.TotalGameTime - mouseDownTime).TotalSeconds);
			Touches.Add(new TouchLocation(0, TouchLocationState.Released, mousePosition));
			IsTouchReleased = true;
			IsDragCompleted = true;
			DragCompletedGestures.Add(new GestureSample(GestureType.DragComplete, gameTime.TotalGameTime, mousePosition, Vector2.Zero, mousePosition - previousMousePosition, Vector2.Zero));
			if (totalDrag.LengthSquared() >= 2500f && elapsedSeconds <= 0.8)
			{
				IsFlicked = true;
				FlickGestures.Add(new GestureSample(GestureType.Flick, gameTime.TotalGameTime, mousePosition, Vector2.Zero, totalDrag / (float)elapsedSeconds, Vector2.Zero));
			}
			if (totalDrag.LengthSquared() <= 100f && (gameTime.TotalGameTime - mouseDownTime).TotalMilliseconds <= 500.0)
			{
				IsTapped = true;
				TapGestures.Add(new GestureSample(GestureType.Tap, gameTime.TotalGameTime, mousePosition, Vector2.Zero, Vector2.Zero, Vector2.Zero));
			}
		}
		previousMousePosition = mousePosition;
		mouseWasPressed = mousePressed;
	}

	private void UpdateMouseWheelPinch(GameTime gameTime, MouseState mouse)
	{
		if (!mouseWheelInitialized)
		{
			previousMouseWheelValue = mouse.ScrollWheelValue;
			mouseWheelInitialized = true;
			return;
		}

		int wheelDelta = mouse.ScrollWheelValue - previousMouseWheelValue;
		previousMouseWheelValue = mouse.ScrollWheelValue;
		if (wheelDelta == 0)
		{
			return;
		}

		Vector2 center = MapToLogical(new Vector2(mouse.X, mouse.Y));
		Vector2 left = center + new Vector2(-50f, 0f);
		Vector2 right = center + new Vector2(50f, 0f);
		float amount = MathHelper.Clamp(wheelDelta / 120f, -4f, 4f) * 15f;
		Vector2 delta = new Vector2(-amount, 0f);
		Vector2 delta2 = new Vector2(amount, 0f);
		IsPinched = true;
		PinchGestures.Add(new GestureSample(GestureType.Pinch, gameTime.TotalGameTime, left, right, delta, delta2));
	}
}
