namespace MentorLake.Gtk4.Pango;

public class PangoItemHandle : BaseSafeHandle
{
	public static PangoItemHandle New()
	{
		return PangoItemExterns.pango_item_new();
	}

}


public static class PangoItemHandleExtensions
{
	public static PangoItemHandle ApplyAttrs(this PangoItemHandle item, PangoAttrIteratorHandle iter)
	{
		PangoItemExterns.pango_item_apply_attrs(item, iter);
		return item;
	}

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

}
internal class PangoItemExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoItemHandle pango_item_new();

	[DllImport(Libraries.Pango)]
	internal static extern void pango_item_apply_attrs(PangoItemHandle item, PangoAttrIteratorHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern PangoItemHandle pango_item_copy(PangoItemHandle item);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_item_free(PangoItemHandle item);

	[DllImport(Libraries.Pango)]
	internal static extern PangoItemHandle pango_item_split(PangoItemHandle orig, int split_index, int split_offset);

}

public struct PangoItem
{
	public int offset;
	public int length;
	public int num_chars;
	public PangoAnalysis analysis;
}
