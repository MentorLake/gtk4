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

public class PangoTabArrayHandle : BaseSafeHandle
{
	public static PangoTabArrayHandle New(int initial_size, bool positions_in_pixels)
	{
		return PangoTabArrayExterns.pango_tab_array_new(initial_size, positions_in_pixels);
	}

	public static PangoTabArrayHandle NewWithPositions(int size, bool positions_in_pixels, PangoTabAlign first_alignment, int first_position, IntPtr @__arglist)
	{
		return PangoTabArrayExterns.pango_tab_array_new_with_positions(size, positions_in_pixels, first_alignment, first_position, @__arglist);
	}

}

internal class PangoTabArrayExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoTabArrayHandle pango_tab_array_new(int initial_size, bool positions_in_pixels);
	[DllImport(Libraries.Pango)]
	internal static extern PangoTabArrayHandle pango_tab_array_new_with_positions(int size, bool positions_in_pixels, PangoTabAlign first_alignment, int first_position, IntPtr @__arglist);
}

public struct PangoTabArray
{
}
