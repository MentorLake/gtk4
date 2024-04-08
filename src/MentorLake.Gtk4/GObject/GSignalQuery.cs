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

public class GSignalQueryHandle : BaseSafeHandle
{
}

internal class GSignalQueryExterns
{
}

public struct GSignalQuery
{
	public uint signal_id;
	public string signal_name;
	public GType itype;
	public GSignalFlags signal_flags;
	public GType return_type;
	public uint n_params;
	public GType[] param_types;
}
