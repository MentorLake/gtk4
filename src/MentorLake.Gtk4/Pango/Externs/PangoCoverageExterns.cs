using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoCoverageExterns
{
    [DllImport(Libraries.Pango, EntryPoint = "pango_coverage_ref")]
    internal static extern PangoCoverageHandle pango_coverage_ref(this PangoCoverageHandle coverage);
    [DllImport(Libraries.Pango, EntryPoint = "pango_coverage_unref")]
    internal static extern void pango_coverage_unref(this PangoCoverageHandle coverage);
    [DllImport(Libraries.Pango, EntryPoint = "pango_coverage_copy")]
    internal static extern PangoCoverageHandle pango_coverage_copy(this PangoCoverageHandle coverage);
    [DllImport(Libraries.Pango, EntryPoint = "pango_coverage_get")]
    internal static extern PangoCoverageLevel pango_coverage_get(this PangoCoverageHandle coverage, int index_);
    [DllImport(Libraries.Pango, EntryPoint = "pango_coverage_set")]
    internal static extern void pango_coverage_set(this PangoCoverageHandle coverage, int index_, PangoCoverageLevel level);
    [DllImport(Libraries.Pango, EntryPoint = "pango_coverage_max")]
    [Obsolete]
    internal static extern void pango_coverage_max(this PangoCoverageHandle coverage, PangoCoverageHandle other);
    [DllImport(Libraries.Pango, EntryPoint = "pango_coverage_to_bytes")]
    [Obsolete]
    internal static extern void pango_coverage_to_bytes(this PangoCoverageHandle coverage, byte[] bytes, out int n_bytes);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoCoverageHandle pango_coverage_new();
}
