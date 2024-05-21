namespace MentorLake.Gtk4.Pango;

public class PangoScriptIterHandle : BaseSafeHandle
{
	public static PangoScriptIterHandle New(string text, int length)
	{
		return PangoScriptIterExterns.pango_script_iter_new(text, length);
	}

}


public static class PangoScriptIterHandleExtensions
{
	public static PangoScriptIterHandle Free(this PangoScriptIterHandle iter)
	{
		PangoScriptIterExterns.pango_script_iter_free(iter);
		return iter;
	}

	public static PangoScriptIterHandle GetRange(this PangoScriptIterHandle iter, out string start, out string end, out PangoScript script)
	{
		PangoScriptIterExterns.pango_script_iter_get_range(iter, out start, out end, out script);
		return iter;
	}

	public static bool Next(this PangoScriptIterHandle iter)
	{
		return PangoScriptIterExterns.pango_script_iter_next(iter);
	}

}
internal class PangoScriptIterExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoScriptIterHandle pango_script_iter_new(string text, int length);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_script_iter_free(PangoScriptIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_script_iter_get_range(PangoScriptIterHandle iter, out string start, out string end, out PangoScript script);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_script_iter_next(PangoScriptIterHandle iter);

}

public struct PangoScriptIter
{
}
