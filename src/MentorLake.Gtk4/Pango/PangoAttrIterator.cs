namespace MentorLake.Gtk4.Pango;

public class PangoAttrIteratorHandle : BaseSafeHandle
{
}


public static class PangoAttrIteratorHandleExtensions
{
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

	public static GSListHandle GetAttrs(this PangoAttrIteratorHandle iterator)
	{
		return PangoAttrIteratorExterns.pango_attr_iterator_get_attrs(iterator);
	}

	public static PangoAttrIteratorHandle GetFont(this PangoAttrIteratorHandle iterator, PangoFontDescriptionHandle desc, out PangoLanguageHandle language, out GSListHandle extra_attrs)
	{
		PangoAttrIteratorExterns.pango_attr_iterator_get_font(iterator, desc, out language, out extra_attrs);
		return iterator;
	}

	public static bool Next(this PangoAttrIteratorHandle iterator)
	{
		return PangoAttrIteratorExterns.pango_attr_iterator_next(iterator);
	}

	public static PangoAttrIteratorHandle Range(this PangoAttrIteratorHandle iterator, out int start, out int end)
	{
		PangoAttrIteratorExterns.pango_attr_iterator_range(iterator, out start, out end);
		return iterator;
	}

}
internal class PangoAttrIteratorExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrIteratorHandle pango_attr_iterator_copy(PangoAttrIteratorHandle iterator);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_iterator_destroy(PangoAttrIteratorHandle iterator);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_iterator_get(PangoAttrIteratorHandle iterator, PangoAttrType type);

	[DllImport(Libraries.Pango)]
	internal static extern GSListHandle pango_attr_iterator_get_attrs(PangoAttrIteratorHandle iterator);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_iterator_get_font(PangoAttrIteratorHandle iterator, PangoFontDescriptionHandle desc, out PangoLanguageHandle language, out GSListHandle extra_attrs);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_attr_iterator_next(PangoAttrIteratorHandle iterator);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_iterator_range(PangoAttrIteratorHandle iterator, out int start, out int end);

}

public struct PangoAttrIterator
{
}
