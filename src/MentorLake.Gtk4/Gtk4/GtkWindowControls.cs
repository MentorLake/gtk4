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

namespace MentorLake.Gtk4.Gtk4;

public class GtkWindowControlsHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkWindowControlsHandle New(GtkPackType side)
	{
		return GtkWindowControlsExterns.gtk_window_controls_new(side);
	}

}

public static class GtkWindowControlsHandleExtensions
{
	public static string GetDecorationLayout(this GtkWindowControlsHandle self)
	{
		return GtkWindowControlsExterns.gtk_window_controls_get_decoration_layout(self);
	}

	public static bool GetEmpty(this GtkWindowControlsHandle self)
	{
		return GtkWindowControlsExterns.gtk_window_controls_get_empty(self);
	}

	public static GtkPackType GetSide(this GtkWindowControlsHandle self)
	{
		return GtkWindowControlsExterns.gtk_window_controls_get_side(self);
	}

	public static GtkWindowControlsHandle SetDecorationLayout(this GtkWindowControlsHandle self, string layout)
	{
		GtkWindowControlsExterns.gtk_window_controls_set_decoration_layout(self, layout);
		return self;
	}

	public static GtkWindowControlsHandle SetSide(this GtkWindowControlsHandle self, GtkPackType side)
	{
		GtkWindowControlsExterns.gtk_window_controls_set_side(self, side);
		return self;
	}

}

internal class GtkWindowControlsExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWindowControlsHandle gtk_window_controls_new(GtkPackType side);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_window_controls_get_decoration_layout(GtkWindowControlsHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_controls_get_empty(GtkWindowControlsHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPackType gtk_window_controls_get_side(GtkWindowControlsHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_controls_set_decoration_layout(GtkWindowControlsHandle self, string layout);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_controls_set_side(GtkWindowControlsHandle self, GtkPackType side);

}
