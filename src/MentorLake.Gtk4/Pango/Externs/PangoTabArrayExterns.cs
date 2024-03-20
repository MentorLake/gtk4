using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoTabArrayExterns
{
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_copy")]
    internal static extern PangoTabArrayHandle pango_tab_array_copy(this PangoTabArrayHandle src);
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_free")]
    internal static extern void pango_tab_array_free(this PangoTabArrayHandle tab_array);
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_get_size")]
    internal static extern int pango_tab_array_get_size(this PangoTabArrayHandle tab_array);
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_resize")]
    internal static extern void pango_tab_array_resize(this PangoTabArrayHandle tab_array, int new_size);
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_set_tab")]
    internal static extern void pango_tab_array_set_tab(this PangoTabArrayHandle tab_array, int tab_index, PangoTabAlign alignment, int location);
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_get_tab")]
    internal static extern void pango_tab_array_get_tab(this PangoTabArrayHandle tab_array, int tab_index, out PangoTabAlign alignment, out int location);
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_get_tabs")]
    internal static extern void pango_tab_array_get_tabs(this PangoTabArrayHandle tab_array, out PangoTabAlign[] alignments, out int[] locations);
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_get_positions_in_pixels")]
    internal static extern int pango_tab_array_get_positions_in_pixels(this PangoTabArrayHandle tab_array);
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_set_positions_in_pixels")]
    internal static extern void pango_tab_array_set_positions_in_pixels(this PangoTabArrayHandle tab_array, int positions_in_pixels);
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_to_string")]
    internal static extern string pango_tab_array_to_string(this PangoTabArrayHandle tab_array);
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_set_decimal_point")]
    internal static extern void pango_tab_array_set_decimal_point(this PangoTabArrayHandle tab_array, int tab_index, uint decimal_point);
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_get_decimal_point")]
    internal static extern uint pango_tab_array_get_decimal_point(this PangoTabArrayHandle tab_array, int tab_index);
    [DllImport(Libraries.Pango, EntryPoint = "pango_tab_array_sort")]
    internal static extern void pango_tab_array_sort(this PangoTabArrayHandle tab_array);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoTabArrayHandle pango_tab_array_new(int initial_size, int positions_in_pixels);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoTabArrayHandle pango_tab_array_new_with_positions(int size, int positions_in_pixels, PangoTabAlign first_alignment, int first_position, IntPtr @__arglist);
}
