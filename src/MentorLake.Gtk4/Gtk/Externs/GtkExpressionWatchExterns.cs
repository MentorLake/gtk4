using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;

public static class GtkExpressionWatchExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_expression_watch_ref")]
	internal static extern GtkExpressionWatchHandle gtk_expression_watch_ref(this GtkExpressionWatchHandle watch);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_expression_watch_unref")]
	internal static extern void gtk_expression_watch_unref(this GtkExpressionWatchHandle watch);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_expression_watch_evaluate")]
	internal static extern int gtk_expression_watch_evaluate(this GtkExpressionWatchHandle watch, GValueHandle value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_expression_watch_unwatch")]
	internal static extern void gtk_expression_watch_unwatch(this GtkExpressionWatchHandle watch);
}
