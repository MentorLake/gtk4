namespace MentorLake.Gtk4.Pango;

public class PangoFontDescriptionHandle : BaseSafeHandle
{
	public static PangoFontDescriptionHandle New()
	{
		return PangoFontDescriptionExterns.pango_font_description_new();
	}

}

internal class PangoFontDescriptionExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoFontDescriptionHandle pango_font_description_new();

}

public struct PangoFontDescription
{
}
