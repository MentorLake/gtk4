using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkPaintableExterns
{
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_paintable_snapshot")]
    internal static extern void gdk_paintable_snapshot(this GdkPaintableHandle paintable, GdkSnapshotHandle snapshot, double width, double height);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_paintable_get_current_image")]
    internal static extern GdkPaintableHandle gdk_paintable_get_current_image(this GdkPaintableHandle paintable);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_paintable_get_flags")]
    internal static extern GdkPaintableFlags gdk_paintable_get_flags(this GdkPaintableHandle paintable);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_paintable_get_intrinsic_width")]
    internal static extern int gdk_paintable_get_intrinsic_width(this GdkPaintableHandle paintable);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_paintable_get_intrinsic_height")]
    internal static extern int gdk_paintable_get_intrinsic_height(this GdkPaintableHandle paintable);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_paintable_get_intrinsic_aspect_ratio")]
    internal static extern double gdk_paintable_get_intrinsic_aspect_ratio(this GdkPaintableHandle paintable);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_paintable_compute_concrete_size")]
    internal static extern void gdk_paintable_compute_concrete_size(this GdkPaintableHandle paintable, double specified_width, double specified_height, double default_width, double default_height, out double concrete_width, out double concrete_height);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_paintable_invalidate_contents")]
    internal static extern void gdk_paintable_invalidate_contents(this GdkPaintableHandle paintable);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_paintable_invalidate_size")]
    internal static extern void gdk_paintable_invalidate_size(this GdkPaintableHandle paintable);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPaintableHandle gdk_paintable_new_empty(int intrinsic_width, int intrinsic_height);
}
