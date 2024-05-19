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

namespace MentorLake.Gtk4.GdkPixbuf;

public class GdkPixbufNonAnimHandle : GdkPixbufAnimationHandle
{
	public static GdkPixbufNonAnimHandle New(GdkPixbufHandle pixbuf)
	{
		return GdkPixbufNonAnimExterns.gdk_pixbuf_non_anim_new(pixbuf);
	}

}

public static class GdkPixbufNonAnimHandleExtensions
{
}

internal class GdkPixbufNonAnimExterns
{
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufNonAnimHandle gdk_pixbuf_non_anim_new(GdkPixbufHandle pixbuf);

}
