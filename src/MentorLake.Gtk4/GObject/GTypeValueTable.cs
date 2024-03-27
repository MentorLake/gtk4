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

namespace MentorLake.Gtk4.GObject;

public class GTypeValueTableHandle : BaseSafeHandle
{
}

public struct GTypeValueTable
{
	public GTypeValueInitFunc value_init;
	public GTypeValueFreeFunc value_free;
	public GTypeValueCopyFunc value_copy;
	public GTypeValuePeekPointerFunc value_peek_pointer;
	public string collect_format;
	public GTypeValueCollectFunc collect_value;
	public string lcopy_format;
	public GTypeValueLCopyFunc lcopy_value;
}
