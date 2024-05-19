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

namespace MentorLake.Gtk4.Gio;

public class GSimpleIOStreamHandle : GIOStreamHandle
{
	public static GSimpleIOStreamHandle GSimpleIoStreamNew(GInputStreamHandle input_stream, GOutputStreamHandle output_stream)
	{
		return GSimpleIOStreamExterns.g_simple_io_stream_new(input_stream, output_stream);
	}

}

public static class GSimpleIOStreamHandleExtensions
{
}

internal class GSimpleIOStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSimpleIOStreamHandle g_simple_io_stream_new(GInputStreamHandle input_stream, GOutputStreamHandle output_stream);

}
