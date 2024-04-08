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

public class GValueArrayHandle : BaseSafeHandle
{
	public static GValueArrayHandle New(uint n_prealloced)
	{
		return GValueArrayExterns.g_value_array_new(n_prealloced);
	}

}

internal class GValueArrayExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GValueArrayHandle g_value_array_new(uint n_prealloced);
}

public struct GValueArray
{
	public uint n_values;
	public GValueHandle values;
}
