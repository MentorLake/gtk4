using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;
public static class PangoAttrIteratorAdaptors
{
    public static PangoAttrIteratorHandle Range(this PangoAttrIteratorHandle iterator, out int start, out int end)
    {
        PangoAttrIteratorExterns.pango_attr_iterator_range(iterator, out start, out end);
        return iterator;
    }

    public static int Next(this PangoAttrIteratorHandle iterator)
    {
        return PangoAttrIteratorExterns.pango_attr_iterator_next(iterator);
    }

    public static PangoAttrIteratorHandle Copy(this PangoAttrIteratorHandle iterator)
    {
        return PangoAttrIteratorExterns.pango_attr_iterator_copy(iterator);
    }

    public static PangoAttrIteratorHandle Destroy(this PangoAttrIteratorHandle iterator)
    {
        PangoAttrIteratorExterns.pango_attr_iterator_destroy(iterator);
        return iterator;
    }

    public static PangoAttributeHandle Get(this PangoAttrIteratorHandle iterator, PangoAttrType type)
    {
        return PangoAttrIteratorExterns.pango_attr_iterator_get(iterator, type);
    }

    public static PangoAttrIteratorHandle GetFont(this PangoAttrIteratorHandle iterator, PangoFontDescriptionHandle desc, out PangoLanguageHandle language, out GSListHandle extra_attrs)
    {
        PangoAttrIteratorExterns.pango_attr_iterator_get_font(iterator, desc, out language, out extra_attrs);
        return iterator;
    }

    public static GSListHandle GetAttrs(this PangoAttrIteratorHandle iterator)
    {
        return PangoAttrIteratorExterns.pango_attr_iterator_get_attrs(iterator);
    }
}
