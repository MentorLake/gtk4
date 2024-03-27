using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkStackSwitcherHandle : GtkWidgetHandle
{
	public static GtkStackSwitcherHandle New()
	{
		return GtkStackSwitcherExterns.gtk_stack_switcher_new();
	}
}

public static class GtkStackSwitcherSignals
{
}

public static class GtkStackSwitcherHandleExtensions
{
	public static GtkStackHandle GetStack(this GtkStackSwitcherHandle switcher)
	{
		return GtkStackSwitcherExterns.gtk_stack_switcher_get_stack(switcher);
	}

	public static GtkStackSwitcherHandle SetStack(this GtkStackSwitcherHandle switcher, GtkStackHandle stack)
	{
		GtkStackSwitcherExterns.gtk_stack_switcher_set_stack(switcher, stack);
		return switcher;
	}

}

internal class GtkStackSwitcherExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStackHandle gtk_stack_switcher_get_stack(GtkStackSwitcherHandle switcher);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_switcher_set_stack(GtkStackSwitcherHandle switcher, GtkStackHandle stack);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStackSwitcherHandle gtk_stack_switcher_new();
}
