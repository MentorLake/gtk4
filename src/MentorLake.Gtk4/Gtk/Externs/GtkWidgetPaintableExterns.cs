using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkWidgetPaintableExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_paintable_get_widget")]
	internal static extern GtkWidgetHandle gtk_widget_paintable_get_widget(this GtkWidgetPaintableHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_paintable_set_widget")]
	internal static extern void gtk_widget_paintable_set_widget(this GtkWidgetPaintableHandle self, GtkWidgetHandle widget);
}
