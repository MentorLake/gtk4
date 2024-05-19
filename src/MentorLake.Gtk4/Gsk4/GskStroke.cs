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

namespace MentorLake.Gtk4.Gsk4;

public class GskStrokeHandle : BaseSafeHandle
{
	public static GskStrokeHandle New(float line_width)
	{
		return GskStrokeExterns.gsk_stroke_new(line_width);
	}

}

internal class GskStrokeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskStrokeHandle gsk_stroke_new(float line_width);

}

public struct GskStroke
{
}
