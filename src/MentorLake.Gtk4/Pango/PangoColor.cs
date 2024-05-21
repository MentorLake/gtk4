namespace MentorLake.Gtk4.Pango;

public class PangoColorHandle : BaseSafeHandle
{
}


public static class PangoColorHandleExtensions
{
	public static PangoColorHandle Copy(this PangoColorHandle src)
	{
		return PangoColorExterns.pango_color_copy(src);
	}

	public static PangoColorHandle Free(this PangoColorHandle color)
	{
		PangoColorExterns.pango_color_free(color);
		return color;
	}

	public static bool Parse(this PangoColorHandle color, string spec)
	{
		return PangoColorExterns.pango_color_parse(color, spec);
	}

	public static bool ParseWithAlpha(this PangoColorHandle color, out ushort alpha, string spec)
	{
		return PangoColorExterns.pango_color_parse_with_alpha(color, out alpha, spec);
	}

	public static string ToString(this PangoColorHandle color)
	{
		return PangoColorExterns.pango_color_to_string(color);
	}

}
internal class PangoColorExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoColorHandle pango_color_copy(PangoColorHandle src);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_color_free(PangoColorHandle color);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_color_parse(PangoColorHandle color, string spec);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_color_parse_with_alpha(PangoColorHandle color, out ushort alpha, string spec);

	[DllImport(Libraries.Pango)]
	internal static extern string pango_color_to_string(PangoColorHandle color);

}

public struct PangoColor
{
	public ushort red;
	public ushort green;
	public ushort blue;
}
