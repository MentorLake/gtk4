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

public class GTypeInfoHandle : BaseSafeHandle
{
}

public struct GTypeInfo
{
	public ushort class_size;
	public GBaseInitFunc base_init;
	public GBaseFinalizeFunc base_finalize;
	public GClassInitFunc class_init;
	public GClassFinalizeFunc class_finalize;
	public IntPtr class_data;
	public ushort instance_size;
	public ushort n_preallocs;
	public GInstanceInitFunc instance_init;
	public GTypeValueTable[] value_table;
}
