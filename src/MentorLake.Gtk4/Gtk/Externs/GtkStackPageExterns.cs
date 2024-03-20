using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkStackPageExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_get_child")]
	internal static extern GtkWidgetHandle gtk_stack_page_get_child(this GtkStackPageHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_get_visible")]
	internal static extern int gtk_stack_page_get_visible(this GtkStackPageHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_set_visible")]
	internal static extern void gtk_stack_page_set_visible(this GtkStackPageHandle self, int visible);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_get_needs_attention")]
	internal static extern int gtk_stack_page_get_needs_attention(this GtkStackPageHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_set_needs_attention")]
	internal static extern void gtk_stack_page_set_needs_attention(this GtkStackPageHandle self, int setting);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_get_use_underline")]
	internal static extern int gtk_stack_page_get_use_underline(this GtkStackPageHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_set_use_underline")]
	internal static extern void gtk_stack_page_set_use_underline(this GtkStackPageHandle self, int setting);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_get_name")]
	internal static extern string gtk_stack_page_get_name(this GtkStackPageHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_set_name")]
	internal static extern void gtk_stack_page_set_name(this GtkStackPageHandle self, string setting);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_get_title")]
	internal static extern string gtk_stack_page_get_title(this GtkStackPageHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_set_title")]
	internal static extern void gtk_stack_page_set_title(this GtkStackPageHandle self, string setting);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_get_icon_name")]
	internal static extern string gtk_stack_page_get_icon_name(this GtkStackPageHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_page_set_icon_name")]
	internal static extern void gtk_stack_page_set_icon_name(this GtkStackPageHandle self, string setting);
}
