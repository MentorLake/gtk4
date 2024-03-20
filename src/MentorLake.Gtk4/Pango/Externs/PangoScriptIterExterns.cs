using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoScriptIterExterns
{
    [DllImport(Libraries.Pango, EntryPoint = "pango_script_iter_get_range")]
    internal static extern void pango_script_iter_get_range(this PangoScriptIterHandle iter, out string start, out string end, out PangoScript script);
    [DllImport(Libraries.Pango, EntryPoint = "pango_script_iter_next")]
    internal static extern int pango_script_iter_next(this PangoScriptIterHandle iter);
    [DllImport(Libraries.Pango, EntryPoint = "pango_script_iter_free")]
    internal static extern void pango_script_iter_free(this PangoScriptIterHandle iter);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoScriptIterHandle pango_script_iter_new(string text, int length);
}
