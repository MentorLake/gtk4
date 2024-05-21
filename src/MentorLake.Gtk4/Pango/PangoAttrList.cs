namespace MentorLake.Gtk4.Pango;

public class PangoAttrListHandle : BaseSafeHandle
{
	public static PangoAttrListHandle New()
	{
		return PangoAttrListExterns.pango_attr_list_new();
	}

}


public static class PangoAttrListHandleExtensions
{
	public static PangoAttrListHandle Change(this PangoAttrListHandle list, PangoAttributeHandle attr)
	{
		PangoAttrListExterns.pango_attr_list_change(list, attr);
		return list;
	}

	public static PangoAttrListHandle Copy(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_copy(list);
	}

	public static bool Equal(this PangoAttrListHandle list, PangoAttrListHandle other_list)
	{
		return PangoAttrListExterns.pango_attr_list_equal(list, other_list);
	}

	public static PangoAttrListHandle Filter(this PangoAttrListHandle list, PangoAttrFilterFunc func, IntPtr data)
	{
		return PangoAttrListExterns.pango_attr_list_filter(list, func, data);
	}

	public static GSListHandle GetAttributes(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_get_attributes(list);
	}

	public static PangoAttrIteratorHandle GetIterator(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_get_iterator(list);
	}

	public static PangoAttrListHandle Insert(this PangoAttrListHandle list, PangoAttributeHandle attr)
	{
		PangoAttrListExterns.pango_attr_list_insert(list, attr);
		return list;
	}

	public static PangoAttrListHandle InsertBefore(this PangoAttrListHandle list, PangoAttributeHandle attr)
	{
		PangoAttrListExterns.pango_attr_list_insert_before(list, attr);
		return list;
	}

	public static PangoAttrListHandle Ref(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_ref(list);
	}

	public static PangoAttrListHandle Splice(this PangoAttrListHandle list, PangoAttrListHandle other, int pos, int len)
	{
		PangoAttrListExterns.pango_attr_list_splice(list, other, pos, len);
		return list;
	}

	public static string ToString(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_to_string(list);
	}

	public static PangoAttrListHandle Unref(this PangoAttrListHandle list)
	{
		PangoAttrListExterns.pango_attr_list_unref(list);
		return list;
	}

	public static PangoAttrListHandle Update(this PangoAttrListHandle list, int pos, int remove, int add)
	{
		PangoAttrListExterns.pango_attr_list_update(list, pos, remove, add);
		return list;
	}

}
internal class PangoAttrListExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrListHandle pango_attr_list_new();

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_list_change(PangoAttrListHandle list, PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrListHandle pango_attr_list_copy(PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_attr_list_equal(PangoAttrListHandle list, PangoAttrListHandle other_list);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrListHandle pango_attr_list_filter(PangoAttrListHandle list, PangoAttrFilterFunc func, IntPtr data);

	[DllImport(Libraries.Pango)]
	internal static extern GSListHandle pango_attr_list_get_attributes(PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrIteratorHandle pango_attr_list_get_iterator(PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_list_insert(PangoAttrListHandle list, PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_list_insert_before(PangoAttrListHandle list, PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrListHandle pango_attr_list_ref(PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_list_splice(PangoAttrListHandle list, PangoAttrListHandle other, int pos, int len);

	[DllImport(Libraries.Pango)]
	internal static extern string pango_attr_list_to_string(PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_list_unref(PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_list_update(PangoAttrListHandle list, int pos, int remove, int add);

}

public struct PangoAttrList
{
}
