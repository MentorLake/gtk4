using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;

public static class GtkBuilderCScopeExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_cscope_add_callback_symbol")]
	internal static extern void gtk_builder_cscope_add_callback_symbol(this GtkBuilderCScopeHandle self, string callback_name, GCallback callback_symbol);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_cscope_add_callback_symbols")]
	internal static extern void gtk_builder_cscope_add_callback_symbols(this GtkBuilderCScopeHandle self, string first_callback_name, GCallback first_callback_symbol, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_cscope_lookup_callback_symbol")]
	internal static extern GCallback gtk_builder_cscope_lookup_callback_symbol(this GtkBuilderCScopeHandle self, string callback_name);
}
