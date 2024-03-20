using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;
public static class PangoAttrListExterns
{
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_ref")]
    internal static extern PangoAttrListHandle pango_attr_list_ref(this PangoAttrListHandle list);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_unref")]
    internal static extern void pango_attr_list_unref(this PangoAttrListHandle list);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_copy")]
    internal static extern PangoAttrListHandle pango_attr_list_copy(this PangoAttrListHandle list);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_insert")]
    internal static extern void pango_attr_list_insert(this PangoAttrListHandle list, PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_insert_before")]
    internal static extern void pango_attr_list_insert_before(this PangoAttrListHandle list, PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_change")]
    internal static extern void pango_attr_list_change(this PangoAttrListHandle list, PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_splice")]
    internal static extern void pango_attr_list_splice(this PangoAttrListHandle list, PangoAttrListHandle other, int pos, int len);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_update")]
    internal static extern void pango_attr_list_update(this PangoAttrListHandle list, int pos, int remove, int add);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_filter")]
    internal static extern PangoAttrListHandle pango_attr_list_filter(this PangoAttrListHandle list, PangoAttrFilterFunc func, IntPtr data);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_get_attributes")]
    internal static extern GSListHandle pango_attr_list_get_attributes(this PangoAttrListHandle list);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_equal")]
    internal static extern int pango_attr_list_equal(this PangoAttrListHandle list, PangoAttrListHandle other_list);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_to_string")]
    internal static extern string pango_attr_list_to_string(this PangoAttrListHandle list);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_list_get_iterator")]
    internal static extern PangoAttrIteratorHandle pango_attr_list_get_iterator(this PangoAttrListHandle list);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttrListHandle pango_attr_list_new();
}
