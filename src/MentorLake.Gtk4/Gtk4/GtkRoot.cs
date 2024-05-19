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

public interface GtkRootHandle
{
}

internal class GtkRootHandleImpl : BaseSafeHandle, GtkRootHandle
{
}

public static class GtkRootHandleExtensions
{
	public static GdkDisplayHandle GetDisplay(this GtkRootHandle self)
	{
		return GtkRootExterns.gtk_root_get_display(self);
	}

	public static GtkWidgetHandle GetFocus(this GtkRootHandle self)
	{
		return GtkRootExterns.gtk_root_get_focus(self);
	}

	public static GtkRootHandle SetFocus(this GtkRootHandle self, GtkWidgetHandle focus)
	{
		GtkRootExterns.gtk_root_set_focus(self, focus);
		return self;
	}

}

internal class GtkRootExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDisplayHandle gtk_root_get_display(GtkRootHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_root_get_focus(GtkRootHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_root_set_focus(GtkRootHandle self, GtkWidgetHandle focus);

}
