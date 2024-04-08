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

namespace MentorLake.Gtk4.GdkPixbuf;

public class GdkPixbufFormatHandle : BaseSafeHandle
{
}

internal class GdkPixbufFormatExterns
{
}

public struct GdkPixbufFormat
{
	public string name;
	public GdkPixbufModulePatternHandle signature;
	public string domain;
	public string description;
	public string[] mime_types;
	public string[] extensions;
	public uint flags;
	public bool disabled;
	public string license;
}
