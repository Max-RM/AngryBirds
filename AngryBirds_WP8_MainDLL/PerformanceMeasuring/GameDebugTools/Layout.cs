using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PerformanceMeasuring.GameDebugTools;

public struct Layout
{
	public Rectangle ClientArea;

	public Rectangle SafeArea;

	public Layout(Rectangle clientArea, Rectangle safeArea)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		ClientArea = clientArea;
		SafeArea = safeArea;
	}

	public Layout(Rectangle clientArea)
		: this(clientArea, clientArea)
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)
	//IL_0002: Unknown result type (might be due to invalid IL or missing references)


	public Layout(Viewport viewport)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		ClientArea = new Rectangle(viewport.X, viewport.Y, viewport.Width, viewport.Height);
		SafeArea = viewport.TitleSafeArea;
	}

	public Vector2 Place(Vector2 size, float horizontalMargin, float verticalMargine, Alignment alignment)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		Rectangle region = default(Rectangle);
		region = new Rectangle(0, 0, (int)size.X, (int)size.Y);
		region = Place(region, horizontalMargin, verticalMargine, alignment);
		return new Vector2((float)region.X, (float)region.Y);
	}

	public Rectangle Place(Rectangle region, float horizontalMargin, float verticalMargine, Alignment alignment)
	{
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		if ((alignment & Alignment.Left) != 0)
		{
			region.X = ClientArea.X + (int)((float)ClientArea.Width * horizontalMargin);
		}
		else if ((alignment & Alignment.Right) != 0)
		{
			region.X = ClientArea.X + (int)((float)ClientArea.Width * (1f - horizontalMargin)) - region.Width;
		}
		else if ((alignment & Alignment.HorizontalCenter) != 0)
		{
			region.X = ClientArea.X + (ClientArea.Width - region.Width) / 2 + (int)(horizontalMargin * (float)ClientArea.Width);
		}
		if ((alignment & Alignment.Top) != 0)
		{
			region.Y = ClientArea.Y + (int)((float)ClientArea.Height * verticalMargine);
		}
		else if ((alignment & Alignment.Bottom) != 0)
		{
			region.Y = ClientArea.Y + (int)((float)ClientArea.Height * (1f - verticalMargine)) - region.Height;
		}
		else if ((alignment & Alignment.VerticalCenter) != 0)
		{
			region.Y = ClientArea.Y + (ClientArea.Height - region.Height) / 2 + (int)(verticalMargine * (float)ClientArea.Height);
		}
		if (region.Left < SafeArea.Left)
		{
			region.X = SafeArea.Left;
		}
		if (region.Right > SafeArea.Right)
		{
			region.X = SafeArea.Right - region.Width;
		}
		if (region.Top < SafeArea.Top)
		{
			region.Y = SafeArea.Top;
		}
		if (region.Bottom > SafeArea.Bottom)
		{
			region.Y = SafeArea.Bottom - region.Height;
		}
		return region;
	}
}
