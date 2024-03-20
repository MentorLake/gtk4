using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GVariantIterExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_variant_iter_init")]
	internal static extern nuint g_variant_iter_init(this GVariantIterHandle iter, GVariantHandle value);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_iter_copy")]
	internal static extern GVariantIterHandle g_variant_iter_copy(this GVariantIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_iter_n_children")]
	internal static extern nuint g_variant_iter_n_children(this GVariantIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_iter_free")]
	internal static extern void g_variant_iter_free(this GVariantIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_iter_next_value")]
	internal static extern GVariantHandle g_variant_iter_next_value(this GVariantIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_iter_next")]
	internal static extern int g_variant_iter_next(this GVariantIterHandle iter, string format_string, IntPtr @__argList);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_iter_loop")]
	internal static extern int g_variant_iter_loop(this GVariantIterHandle iter, string format_string, IntPtr @__argList);
}
