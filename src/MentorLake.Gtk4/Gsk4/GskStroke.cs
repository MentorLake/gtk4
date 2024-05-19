namespace MentorLake.Gtk4.Gsk4;

public class GskStrokeHandle : BaseSafeHandle
{
	public static GskStrokeHandle New(float line_width)
	{
		return GskStrokeExterns.gsk_stroke_new(line_width);
	}

}

internal class GskStrokeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskStrokeHandle gsk_stroke_new(float line_width);

}

public struct GskStroke
{
}
