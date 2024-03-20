using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GSListAdaptors
{
    public static GSListHandle GSlistFree(this GSListHandle list)
    {
        GSListExterns.g_slist_free(list);
        return list;
    }

    public static GSListHandle GSlistFree1(this GSListHandle list)
    {
        GSListExterns.g_slist_free_1(list);
        return list;
    }

    public static GSListHandle GSlistFreeFull(this GSListHandle list, GDestroyNotify free_func)
    {
        GSListExterns.g_slist_free_full(list, free_func);
        return list;
    }

    public static GSListHandle GSlistAppend(this GSListHandle list, IntPtr data)
    {
        return GSListExterns.g_slist_append(list, data);
    }

    public static GSListHandle GSlistPrepend(this GSListHandle list, IntPtr data)
    {
        return GSListExterns.g_slist_prepend(list, data);
    }

    public static GSListHandle GSlistInsert(this GSListHandle list, IntPtr data, int position)
    {
        return GSListExterns.g_slist_insert(list, data, position);
    }

    public static GSListHandle GSlistInsertSorted(this GSListHandle list, IntPtr data, GCompareFunc func)
    {
        return GSListExterns.g_slist_insert_sorted(list, data, func);
    }

    public static GSListHandle GSlistInsertSortedWithData(this GSListHandle list, IntPtr data, GCompareDataFunc func, IntPtr user_data)
    {
        return GSListExterns.g_slist_insert_sorted_with_data(list, data, func, user_data);
    }

    public static GSListHandle GSlistInsertBefore(this GSListHandle slist, GSListHandle sibling, IntPtr data)
    {
        return GSListExterns.g_slist_insert_before(slist, sibling, data);
    }

    public static GSListHandle GSlistConcat(this GSListHandle list1, GSListHandle list2)
    {
        return GSListExterns.g_slist_concat(list1, list2);
    }

    public static GSListHandle GSlistRemove(this GSListHandle list, IntPtr data)
    {
        return GSListExterns.g_slist_remove(list, data);
    }

    public static GSListHandle GSlistRemoveAll(this GSListHandle list, IntPtr data)
    {
        return GSListExterns.g_slist_remove_all(list, data);
    }

    public static GSListHandle GSlistRemoveLink(this GSListHandle list, GSListHandle link_)
    {
        return GSListExterns.g_slist_remove_link(list, link_);
    }

    public static GSListHandle GSlistDeleteLink(this GSListHandle list, GSListHandle link_)
    {
        return GSListExterns.g_slist_delete_link(list, link_);
    }

    public static GSListHandle GSlistReverse(this GSListHandle list)
    {
        return GSListExterns.g_slist_reverse(list);
    }

    public static GSListHandle GSlistCopy(this GSListHandle list)
    {
        return GSListExterns.g_slist_copy(list);
    }

    public static GSListHandle GSlistCopyDeep(this GSListHandle list, GCopyFunc func, IntPtr user_data)
    {
        return GSListExterns.g_slist_copy_deep(list, func, user_data);
    }

    public static GSListHandle GSlistNth(this GSListHandle list, uint n)
    {
        return GSListExterns.g_slist_nth(list, n);
    }

    public static GSListHandle GSlistFind(this GSListHandle list, IntPtr data)
    {
        return GSListExterns.g_slist_find(list, data);
    }

    public static GSListHandle GSlistFindCustom(this GSListHandle list, IntPtr data, GCompareFunc func)
    {
        return GSListExterns.g_slist_find_custom(list, data, func);
    }

    public static int GSlistPosition(this GSListHandle list, GSListHandle llink)
    {
        return GSListExterns.g_slist_position(list, llink);
    }

    public static int GSlistIndex(this GSListHandle list, IntPtr data)
    {
        return GSListExterns.g_slist_index(list, data);
    }

    public static GSListHandle GSlistLast(this GSListHandle list)
    {
        return GSListExterns.g_slist_last(list);
    }

    public static uint GSlistLength(this GSListHandle list)
    {
        return GSListExterns.g_slist_length(list);
    }

    public static GSListHandle GSlistForeach(this GSListHandle list, IntPtr func, IntPtr user_data)
    {
        GSListExterns.g_slist_foreach(list, func, user_data);
        return list;
    }

    public static GSListHandle GSlistSort(this GSListHandle list, GCompareFunc compare_func)
    {
        return GSListExterns.g_slist_sort(list, compare_func);
    }

    public static GSListHandle GSlistSortWithData(this GSListHandle list, GCompareDataFunc compare_func, IntPtr user_data)
    {
        return GSListExterns.g_slist_sort_with_data(list, compare_func, user_data);
    }

    public static IntPtr GSlistNthData(this GSListHandle list, uint n)
    {
        return GSListExterns.g_slist_nth_data(list, n);
    }
}
