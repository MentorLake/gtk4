using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gdk4;

public interface GdkToplevelHandle
{
}

internal class GdkToplevelHandleImpl : BaseSafeHandle, GdkToplevelHandle
{
}

public static class GdkToplevelHandleExtensions
{
	public static GdkToplevelHandle BeginMove(this GdkToplevelHandle toplevel, GdkDeviceHandle device, int button, double x, double y, uint timestamp)
	{
		GdkToplevelExterns.gdk_toplevel_begin_move(toplevel, device, button, x, y, timestamp);
		return toplevel;
	}

	public static GdkToplevelHandle BeginResize(this GdkToplevelHandle toplevel, GdkSurfaceEdge edge, GdkDeviceHandle device, int button, double x, double y, uint timestamp)
	{
		GdkToplevelExterns.gdk_toplevel_begin_resize(toplevel, edge, device, button, x, y, timestamp);
		return toplevel;
	}

	public static GdkToplevelHandle Focus(this GdkToplevelHandle toplevel, uint timestamp)
	{
		GdkToplevelExterns.gdk_toplevel_focus(toplevel, timestamp);
		return toplevel;
	}

	public static GdkToplevelState GetState(this GdkToplevelHandle toplevel)
	{
		return GdkToplevelExterns.gdk_toplevel_get_state(toplevel);
	}

	public static GdkToplevelHandle InhibitSystemShortcuts(this GdkToplevelHandle toplevel, GdkEventHandle @event)
	{
		GdkToplevelExterns.gdk_toplevel_inhibit_system_shortcuts(toplevel, @event);
		return toplevel;
	}

	public static bool Lower(this GdkToplevelHandle toplevel)
	{
		return GdkToplevelExterns.gdk_toplevel_lower(toplevel);
	}

	public static bool Minimize(this GdkToplevelHandle toplevel)
	{
		return GdkToplevelExterns.gdk_toplevel_minimize(toplevel);
	}

	public static GdkToplevelHandle Present(this GdkToplevelHandle toplevel, GdkToplevelLayoutHandle layout)
	{
		GdkToplevelExterns.gdk_toplevel_present(toplevel, layout);
		return toplevel;
	}

	public static GdkToplevelHandle RestoreSystemShortcuts(this GdkToplevelHandle toplevel)
	{
		GdkToplevelExterns.gdk_toplevel_restore_system_shortcuts(toplevel);
		return toplevel;
	}

	public static GdkToplevelHandle SetDecorated(this GdkToplevelHandle toplevel, bool decorated)
	{
		GdkToplevelExterns.gdk_toplevel_set_decorated(toplevel, decorated);
		return toplevel;
	}

	public static GdkToplevelHandle SetDeletable(this GdkToplevelHandle toplevel, bool deletable)
	{
		GdkToplevelExterns.gdk_toplevel_set_deletable(toplevel, deletable);
		return toplevel;
	}

	public static GdkToplevelHandle SetIconList(this GdkToplevelHandle toplevel, GListHandle surfaces)
	{
		GdkToplevelExterns.gdk_toplevel_set_icon_list(toplevel, surfaces);
		return toplevel;
	}

	public static GdkToplevelHandle SetModal(this GdkToplevelHandle toplevel, bool modal)
	{
		GdkToplevelExterns.gdk_toplevel_set_modal(toplevel, modal);
		return toplevel;
	}

	public static GdkToplevelHandle SetStartupId(this GdkToplevelHandle toplevel, string startup_id)
	{
		GdkToplevelExterns.gdk_toplevel_set_startup_id(toplevel, startup_id);
		return toplevel;
	}

	public static GdkToplevelHandle SetTitle(this GdkToplevelHandle toplevel, string title)
	{
		GdkToplevelExterns.gdk_toplevel_set_title(toplevel, title);
		return toplevel;
	}

	public static GdkToplevelHandle SetTransientFor(this GdkToplevelHandle toplevel, GdkSurfaceHandle parent)
	{
		GdkToplevelExterns.gdk_toplevel_set_transient_for(toplevel, parent);
		return toplevel;
	}

	public static bool ShowWindowMenu(this GdkToplevelHandle toplevel, GdkEventHandle @event)
	{
		return GdkToplevelExterns.gdk_toplevel_show_window_menu(toplevel, @event);
	}

	public static bool SupportsEdgeConstraints(this GdkToplevelHandle toplevel)
	{
		return GdkToplevelExterns.gdk_toplevel_supports_edge_constraints(toplevel);
	}

	public static bool TitlebarGesture(this GdkToplevelHandle toplevel, GdkTitlebarGesture gesture)
	{
		return GdkToplevelExterns.gdk_toplevel_titlebar_gesture(toplevel, gesture);
	}

}

internal class GdkToplevelExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_begin_move(GdkToplevelHandle toplevel, GdkDeviceHandle device, int button, double x, double y, uint timestamp);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_begin_resize(GdkToplevelHandle toplevel, GdkSurfaceEdge edge, GdkDeviceHandle device, int button, double x, double y, uint timestamp);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_focus(GdkToplevelHandle toplevel, uint timestamp);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkToplevelState gdk_toplevel_get_state(GdkToplevelHandle toplevel);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_inhibit_system_shortcuts(GdkToplevelHandle toplevel, GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_toplevel_lower(GdkToplevelHandle toplevel);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_toplevel_minimize(GdkToplevelHandle toplevel);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_present(GdkToplevelHandle toplevel, GdkToplevelLayoutHandle layout);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_restore_system_shortcuts(GdkToplevelHandle toplevel);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_set_decorated(GdkToplevelHandle toplevel, bool decorated);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_set_deletable(GdkToplevelHandle toplevel, bool deletable);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_set_icon_list(GdkToplevelHandle toplevel, GListHandle surfaces);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_set_modal(GdkToplevelHandle toplevel, bool modal);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_set_startup_id(GdkToplevelHandle toplevel, string startup_id);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_set_title(GdkToplevelHandle toplevel, string title);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_set_transient_for(GdkToplevelHandle toplevel, GdkSurfaceHandle parent);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_toplevel_show_window_menu(GdkToplevelHandle toplevel, GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_toplevel_supports_edge_constraints(GdkToplevelHandle toplevel);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_toplevel_titlebar_gesture(GdkToplevelHandle toplevel, GdkTitlebarGesture gesture);

}
