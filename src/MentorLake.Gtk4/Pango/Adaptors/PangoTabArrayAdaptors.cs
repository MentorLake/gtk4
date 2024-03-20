using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoTabArrayAdaptors
{
	public static PangoTabArrayHandle Copy(this PangoTabArrayHandle src)
	{
		return PangoTabArrayExterns.pango_tab_array_copy(src);
	}

	public static PangoTabArrayHandle Free(this PangoTabArrayHandle tab_array)
	{
		PangoTabArrayExterns.pango_tab_array_free(tab_array);
		return tab_array;
	}

	public static int GetSize(this PangoTabArrayHandle tab_array)
	{
		return PangoTabArrayExterns.pango_tab_array_get_size(tab_array);
	}

	public static PangoTabArrayHandle Resize(this PangoTabArrayHandle tab_array, int new_size)
	{
		PangoTabArrayExterns.pango_tab_array_resize(tab_array, new_size);
		return tab_array;
	}

	public static PangoTabArrayHandle SetTab(this PangoTabArrayHandle tab_array, int tab_index, PangoTabAlign alignment, int location)
	{
		PangoTabArrayExterns.pango_tab_array_set_tab(tab_array, tab_index, alignment, location);
		return tab_array;
	}

	public static PangoTabArrayHandle GetTab(this PangoTabArrayHandle tab_array, int tab_index, out PangoTabAlign alignment, out int location)
	{
		PangoTabArrayExterns.pango_tab_array_get_tab(tab_array, tab_index, out alignment, out location);
		return tab_array;
	}

	public static PangoTabArrayHandle GetTabs(this PangoTabArrayHandle tab_array, out PangoTabAlign[] alignments, out int[] locations)
	{
		PangoTabArrayExterns.pango_tab_array_get_tabs(tab_array, out alignments, out locations);
		return tab_array;
	}

	public static int GetPositionsInPixels(this PangoTabArrayHandle tab_array)
	{
		return PangoTabArrayExterns.pango_tab_array_get_positions_in_pixels(tab_array);
	}

	public static PangoTabArrayHandle SetPositionsInPixels(this PangoTabArrayHandle tab_array, int positions_in_pixels)
	{
		PangoTabArrayExterns.pango_tab_array_set_positions_in_pixels(tab_array, positions_in_pixels);
		return tab_array;
	}

	public static string ToString(this PangoTabArrayHandle tab_array)
	{
		return PangoTabArrayExterns.pango_tab_array_to_string(tab_array);
	}

	public static PangoTabArrayHandle SetDecimalPoint(this PangoTabArrayHandle tab_array, int tab_index, uint decimal_point)
	{
		PangoTabArrayExterns.pango_tab_array_set_decimal_point(tab_array, tab_index, decimal_point);
		return tab_array;
	}

	public static uint GetDecimalPoint(this PangoTabArrayHandle tab_array, int tab_index)
	{
		return PangoTabArrayExterns.pango_tab_array_get_decimal_point(tab_array, tab_index);
	}

	public static PangoTabArrayHandle Sort(this PangoTabArrayHandle tab_array)
	{
		PangoTabArrayExterns.pango_tab_array_sort(tab_array);
		return tab_array;
	}

	public static PangoTabArrayHandle NewWithPositions(int size, int positions_in_pixels, PangoTabAlign first_alignment, int first_position, IntPtr @__arglist)
	{
		return PangoTabArrayExterns.pango_tab_array_new_with_positions(size, positions_in_pixels, first_alignment, first_position, @__arglist);
	}
}
