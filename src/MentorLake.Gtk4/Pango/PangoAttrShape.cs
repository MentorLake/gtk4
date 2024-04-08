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

namespace MentorLake.Gtk4.Pango;

public class PangoAttrShapeHandle : BaseSafeHandle
{
}

internal class PangoAttrShapeExterns
{
}

public struct PangoAttrShape
{
	public PangoAttribute attr;
	public PangoRectangle ink_rect;
	public PangoRectangle logical_rect;
	public IntPtr data;
	public PangoAttrDataCopyFunc copy_func;
	public GDestroyNotify destroy_func;
}
