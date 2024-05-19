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

public class GtkCustomLayoutHandle : GtkLayoutManagerHandle
{
	public static GtkCustomLayoutHandle New(GtkCustomRequestModeFunc request_mode, GtkCustomMeasureFunc measure, GtkCustomAllocateFunc allocate)
	{
		return GtkCustomLayoutExterns.gtk_custom_layout_new(request_mode, measure, allocate);
	}

}

public static class GtkCustomLayoutHandleExtensions
{
}

internal class GtkCustomLayoutExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCustomLayoutHandle gtk_custom_layout_new(GtkCustomRequestModeFunc request_mode, GtkCustomMeasureFunc measure, GtkCustomAllocateFunc allocate);

}
