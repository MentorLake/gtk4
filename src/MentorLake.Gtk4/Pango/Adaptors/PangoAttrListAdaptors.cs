using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;
public static class PangoAttrListAdaptors
{
	public static PangoAttrListHandle Ref(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_ref(list);
	}

	public static PangoAttrListHandle Unref(this PangoAttrListHandle list)
	{
		PangoAttrListExterns.pango_attr_list_unref(list);
		return list;
	}

	public static PangoAttrListHandle Copy(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_copy(list);
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

	public static PangoAttrListHandle Change(this PangoAttrListHandle list, PangoAttributeHandle attr)
	{
		PangoAttrListExterns.pango_attr_list_change(list, attr);
		return list;
	}

	public static PangoAttrListHandle Splice(this PangoAttrListHandle list, PangoAttrListHandle other, int pos, int len)
	{
		PangoAttrListExterns.pango_attr_list_splice(list, other, pos, len);
		return list;
	}

	public static PangoAttrListHandle Update(this PangoAttrListHandle list, int pos, int remove, int add)
	{
		PangoAttrListExterns.pango_attr_list_update(list, pos, remove, add);
		return list;
	}

	public static PangoAttrListHandle Filter(this PangoAttrListHandle list, PangoAttrFilterFunc func, IntPtr data)
	{
		return PangoAttrListExterns.pango_attr_list_filter(list, func, data);
	}

	public static GSListHandle GetAttributes(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_get_attributes(list);
	}

	public static int Equal(this PangoAttrListHandle list, PangoAttrListHandle other_list)
	{
		return PangoAttrListExterns.pango_attr_list_equal(list, other_list);
	}

	public static string ToString(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_to_string(list);
	}

	public static PangoAttrIteratorHandle GetIterator(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_get_iterator(list);
	}
}
