using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkOverlayLayoutChildExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_overlay_layout_child_set_measure")]
	internal static extern void gtk_overlay_layout_child_set_measure(this GtkOverlayLayoutChildHandle child, int measure);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_overlay_layout_child_get_measure")]
	internal static extern int gtk_overlay_layout_child_get_measure(this GtkOverlayLayoutChildHandle child);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_overlay_layout_child_set_clip_overlay")]
	internal static extern void gtk_overlay_layout_child_set_clip_overlay(this GtkOverlayLayoutChildHandle child, int clip_overlay);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_overlay_layout_child_get_clip_overlay")]
	internal static extern int gtk_overlay_layout_child_get_clip_overlay(this GtkOverlayLayoutChildHandle child);
}
