using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GVariantBuilderExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_variant_builder_unref")]
	internal static extern void g_variant_builder_unref(this GVariantBuilderHandle builder);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_builder_ref")]
	internal static extern GVariantBuilderHandle g_variant_builder_ref(this GVariantBuilderHandle builder);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_builder_init")]
	internal static extern void g_variant_builder_init(this GVariantBuilderHandle builder, GVariantTypeHandle type);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_builder_end")]
	internal static extern GVariantHandle g_variant_builder_end(this GVariantBuilderHandle builder);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_builder_clear")]
	internal static extern void g_variant_builder_clear(this GVariantBuilderHandle builder);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_builder_open")]
	internal static extern void g_variant_builder_open(this GVariantBuilderHandle builder, GVariantTypeHandle type);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_builder_close")]
	internal static extern void g_variant_builder_close(this GVariantBuilderHandle builder);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_builder_add_value")]
	internal static extern void g_variant_builder_add_value(this GVariantBuilderHandle builder, GVariantHandle value);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_builder_add")]
	internal static extern void g_variant_builder_add(this GVariantBuilderHandle builder, string format_string, IntPtr @__argList);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_builder_add_parsed")]
	internal static extern void g_variant_builder_add_parsed(this GVariantBuilderHandle builder, string format, IntPtr @__argList);
}
