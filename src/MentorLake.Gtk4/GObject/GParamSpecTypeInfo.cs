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

namespace MentorLake.Gtk4.GObject;

public class GParamSpecTypeInfoHandle : BaseSafeHandle
{
}

internal class GParamSpecTypeInfoExterns
{
}

public struct GParamSpecTypeInfo
{
	public ushort instance_size;
	public ushort n_preallocs;
	public IntPtr instance_init;
	public GType value_type;
	public IntPtr finalize;
	public IntPtr value_set_default;
	public IntPtr value_validate;
	public IntPtr values_cmp;
}
