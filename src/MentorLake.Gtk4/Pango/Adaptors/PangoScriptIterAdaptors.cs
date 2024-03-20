using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoScriptIterAdaptors
{
	public static PangoScriptIterHandle GetRange(this PangoScriptIterHandle iter, out string start, out string end, out PangoScript script)
	{
		PangoScriptIterExterns.pango_script_iter_get_range(iter, out start, out end, out script);
		return iter;
	}

	public static int Next(this PangoScriptIterHandle iter)
	{
		return PangoScriptIterExterns.pango_script_iter_next(iter);
	}

	public static PangoScriptIterHandle Free(this PangoScriptIterHandle iter)
	{
		PangoScriptIterExterns.pango_script_iter_free(iter);
		return iter;
	}
}
