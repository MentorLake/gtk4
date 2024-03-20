using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;

public static class GdkToplevelExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_present")]
	internal static extern void gdk_toplevel_present(this GdkToplevelHandle toplevel, GdkToplevelLayoutHandle layout);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_minimize")]
	internal static extern int gdk_toplevel_minimize(this GdkToplevelHandle toplevel);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_lower")]
	internal static extern int gdk_toplevel_lower(this GdkToplevelHandle toplevel);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_focus")]
	internal static extern void gdk_toplevel_focus(this GdkToplevelHandle toplevel, uint timestamp);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_get_state")]
	internal static extern GdkToplevelState gdk_toplevel_get_state(this GdkToplevelHandle toplevel);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_set_title")]
	internal static extern void gdk_toplevel_set_title(this GdkToplevelHandle toplevel, string title);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_set_startup_id")]
	internal static extern void gdk_toplevel_set_startup_id(this GdkToplevelHandle toplevel, string startup_id);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_set_transient_for")]
	internal static extern void gdk_toplevel_set_transient_for(this GdkToplevelHandle toplevel, GdkSurfaceHandle parent);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_set_modal")]
	internal static extern void gdk_toplevel_set_modal(this GdkToplevelHandle toplevel, int modal);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_set_icon_list")]
	internal static extern void gdk_toplevel_set_icon_list(this GdkToplevelHandle toplevel, GListHandle surfaces);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_show_window_menu")]
	internal static extern int gdk_toplevel_show_window_menu(this GdkToplevelHandle toplevel, GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_set_decorated")]
	internal static extern void gdk_toplevel_set_decorated(this GdkToplevelHandle toplevel, int decorated);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_set_deletable")]
	internal static extern void gdk_toplevel_set_deletable(this GdkToplevelHandle toplevel, int deletable);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_supports_edge_constraints")]
	internal static extern int gdk_toplevel_supports_edge_constraints(this GdkToplevelHandle toplevel);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_inhibit_system_shortcuts")]
	internal static extern void gdk_toplevel_inhibit_system_shortcuts(this GdkToplevelHandle toplevel, GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_restore_system_shortcuts")]
	internal static extern void gdk_toplevel_restore_system_shortcuts(this GdkToplevelHandle toplevel);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_begin_resize")]
	internal static extern void gdk_toplevel_begin_resize(this GdkToplevelHandle toplevel, GdkSurfaceEdge edge, GdkDeviceHandle device, int button, double x, double y, uint timestamp);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_begin_move")]
	internal static extern void gdk_toplevel_begin_move(this GdkToplevelHandle toplevel, GdkDeviceHandle device, int button, double x, double y, uint timestamp);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_titlebar_gesture")]
	internal static extern int gdk_toplevel_titlebar_gesture(this GdkToplevelHandle toplevel, GdkTitlebarGesture gesture);
}
