using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkScrollableExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_scrollable_get_hadjustment")]
	internal static extern GtkAdjustmentHandle gtk_scrollable_get_hadjustment(this GtkScrollableHandle scrollable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_scrollable_set_hadjustment")]
	internal static extern void gtk_scrollable_set_hadjustment(this GtkScrollableHandle scrollable, GtkAdjustmentHandle hadjustment);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_scrollable_get_vadjustment")]
	internal static extern GtkAdjustmentHandle gtk_scrollable_get_vadjustment(this GtkScrollableHandle scrollable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_scrollable_set_vadjustment")]
	internal static extern void gtk_scrollable_set_vadjustment(this GtkScrollableHandle scrollable, GtkAdjustmentHandle vadjustment);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_scrollable_get_hscroll_policy")]
	internal static extern GtkScrollablePolicy gtk_scrollable_get_hscroll_policy(this GtkScrollableHandle scrollable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_scrollable_set_hscroll_policy")]
	internal static extern void gtk_scrollable_set_hscroll_policy(this GtkScrollableHandle scrollable, GtkScrollablePolicy policy);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_scrollable_get_vscroll_policy")]
	internal static extern GtkScrollablePolicy gtk_scrollable_get_vscroll_policy(this GtkScrollableHandle scrollable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_scrollable_set_vscroll_policy")]
	internal static extern void gtk_scrollable_set_vscroll_policy(this GtkScrollableHandle scrollable, GtkScrollablePolicy policy);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_scrollable_get_border")]
	internal static extern int gtk_scrollable_get_border(this GtkScrollableHandle scrollable, GtkBorderHandle border);
}
