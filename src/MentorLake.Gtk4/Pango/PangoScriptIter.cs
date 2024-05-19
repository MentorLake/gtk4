namespace MentorLake.Gtk4.Pango;

public class PangoScriptIterHandle : BaseSafeHandle
{
	public static PangoScriptIterHandle New(string text, int length)
	{
		return PangoScriptIterExterns.pango_script_iter_new(text, length);
	}

}

internal class PangoScriptIterExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoScriptIterHandle pango_script_iter_new(string text, int length);

}

public struct PangoScriptIter
{
}
