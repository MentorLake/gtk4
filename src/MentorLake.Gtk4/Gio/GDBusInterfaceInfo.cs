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

namespace MentorLake.Gtk4.Gio;

public class GDBusInterfaceInfoHandle : BaseSafeHandle
{
}

internal class GDBusInterfaceInfoExterns
{
}

public struct GDBusInterfaceInfo
{
	public int ref_count;
	public string name;
	public GDBusMethodInfoHandle[] methods;
	public GDBusSignalInfoHandle[] signals;
	public GDBusPropertyInfoHandle[] properties;
	public GDBusAnnotationInfoHandle[] annotations;
}
