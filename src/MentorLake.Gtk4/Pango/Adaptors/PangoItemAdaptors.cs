using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoItemAdaptors
{
	public static PangoItemHandle Copy(this PangoItemHandle item)
	{
		return PangoItemExterns.pango_item_copy(item);
	}

	public static PangoItemHandle Free(this PangoItemHandle item)
	{
		PangoItemExterns.pango_item_free(item);
		return item;
	}

	public static PangoItemHandle Split(this PangoItemHandle orig, int split_index, int split_offset)
	{
		return PangoItemExterns.pango_item_split(orig, split_index, split_offset);
	}

	public static PangoItemHandle ApplyAttrs(this PangoItemHandle item, PangoAttrIteratorHandle iter)
	{
		PangoItemExterns.pango_item_apply_attrs(item, iter);
		return item;
	}

	public static PangoItemHandle PangoShapeItem(this PangoItemHandle item, string paragraph_text, int paragraph_length, PangoLogAttrHandle log_attrs, PangoGlyphStringHandle glyphs, PangoShapeFlags flags)
	{
		PangoItemExterns.pango_shape_item(item, paragraph_text, paragraph_length, log_attrs, glyphs, flags);
		return item;
	}
}
