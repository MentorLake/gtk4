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

public class GtkStackSidebarHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkStackSidebarHandle New()
	{
		return GtkStackSidebarExterns.gtk_stack_sidebar_new();
	}

}

public static class GtkStackSidebarHandleExtensions
{
	public static GtkStackHandle GetStack(this GtkStackSidebarHandle self)
	{
		return GtkStackSidebarExterns.gtk_stack_sidebar_get_stack(self);
	}

	public static GtkStackSidebarHandle SetStack(this GtkStackSidebarHandle self, GtkStackHandle stack)
	{
		GtkStackSidebarExterns.gtk_stack_sidebar_set_stack(self, stack);
		return self;
	}

}

internal class GtkStackSidebarExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStackSidebarHandle gtk_stack_sidebar_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStackHandle gtk_stack_sidebar_get_stack(GtkStackSidebarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_sidebar_set_stack(GtkStackSidebarHandle self, GtkStackHandle stack);

}
