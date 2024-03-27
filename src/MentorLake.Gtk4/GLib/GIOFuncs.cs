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

namespace MentorLake.Gtk4.GLib;

public class GIOFuncsHandle : BaseSafeHandle
{
}

public struct GIOFuncs
{
	public IntPtr io_read;
	public IntPtr io_write;
	public IntPtr io_seek;
	public IntPtr io_close;
	public IntPtr io_create_watch;
	public IntPtr io_free;
	public IntPtr io_set_flags;
	public IntPtr io_get_flags;
}
