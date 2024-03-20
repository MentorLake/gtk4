using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;

public static class GtkStyleContextExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_render_check")]
	internal static extern void gtk_render_check(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_render_option")]
	internal static extern void gtk_render_option(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_render_arrow")]
	internal static extern void gtk_render_arrow(this GtkStyleContextHandle context, cairoHandle cr, double angle, double x, double y, double size);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_render_background")]
	internal static extern void gtk_render_background(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_render_frame")]
	internal static extern void gtk_render_frame(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_render_expander")]
	internal static extern void gtk_render_expander(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_render_focus")]
	internal static extern void gtk_render_focus(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_render_layout")]
	internal static extern void gtk_render_layout(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, PangoLayoutHandle layout);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_render_line")]
	internal static extern void gtk_render_line(this GtkStyleContextHandle context, cairoHandle cr, double x0, double y0, double x1, double y1);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_render_handle")]
	internal static extern void gtk_render_handle(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_render_activity")]
	internal static extern void gtk_render_activity(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_render_icon")]
	internal static extern void gtk_render_icon(this GtkStyleContextHandle context, cairoHandle cr, GdkTextureHandle texture, double x, double y);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_add_provider")]
	internal static extern void gtk_style_context_add_provider(this GtkStyleContextHandle context, GtkStyleProviderHandle provider, uint priority);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_remove_provider")]
	internal static extern void gtk_style_context_remove_provider(this GtkStyleContextHandle context, GtkStyleProviderHandle provider);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_save")]
	internal static extern void gtk_style_context_save(this GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_restore")]
	internal static extern void gtk_style_context_restore(this GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_set_state")]
	internal static extern void gtk_style_context_set_state(this GtkStyleContextHandle context, GtkStateFlags flags);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_get_state")]
	internal static extern GtkStateFlags gtk_style_context_get_state(this GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_set_scale")]
	internal static extern void gtk_style_context_set_scale(this GtkStyleContextHandle context, int scale);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_get_scale")]
	internal static extern int gtk_style_context_get_scale(this GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_add_class")]
	internal static extern void gtk_style_context_add_class(this GtkStyleContextHandle context, string class_name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_remove_class")]
	internal static extern void gtk_style_context_remove_class(this GtkStyleContextHandle context, string class_name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_has_class")]
	internal static extern int gtk_style_context_has_class(this GtkStyleContextHandle context, string class_name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_set_display")]
	internal static extern void gtk_style_context_set_display(this GtkStyleContextHandle context, GdkDisplayHandle display);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_get_display")]
	internal static extern GdkDisplayHandle gtk_style_context_get_display(this GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_lookup_color")]
	internal static extern int gtk_style_context_lookup_color(this GtkStyleContextHandle context, string color_name, GdkRGBAHandle color);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_get_color")]
	internal static extern void gtk_style_context_get_color(this GtkStyleContextHandle context, GdkRGBAHandle color);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_get_border")]
	internal static extern void gtk_style_context_get_border(this GtkStyleContextHandle context, GtkBorderHandle border);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_get_padding")]
	internal static extern void gtk_style_context_get_padding(this GtkStyleContextHandle context, GtkBorderHandle padding);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_get_margin")]
	internal static extern void gtk_style_context_get_margin(this GtkStyleContextHandle context, GtkBorderHandle margin);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_to_string")]
	internal static extern string gtk_style_context_to_string(this GtkStyleContextHandle context, GtkStyleContextPrintFlags flags);
}
