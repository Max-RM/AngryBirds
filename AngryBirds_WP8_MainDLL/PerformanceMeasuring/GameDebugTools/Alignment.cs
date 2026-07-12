using System;

namespace PerformanceMeasuring.GameDebugTools;

[Flags]
public enum Alignment
{
	None = 0,
	Left = 1,
	Right = 2,
	HorizontalCenter = 4,
	Top = 8,
	Bottom = 0x10,
	VerticalCenter = 0x20,
	TopLeft = 9,
	TopRight = 0xA,
	TopCenter = 0xC,
	BottomLeft = 0x11,
	BottomRight = 0x12,
	BottomCenter = 0x14,
	CenterLeft = 0x21,
	CenterRight = 0x22,
	Center = 0x24
}
