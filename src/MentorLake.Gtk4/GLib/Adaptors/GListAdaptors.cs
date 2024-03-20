using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GListAdaptors
{
    public static GListHandle Free(this GListHandle list)
    {
        GListExterns.g_list_free(list);
        return list;
    }

    public static GListHandle Free1(this GListHandle list)
    {
        GListExterns.g_list_free_1(list);
        return list;
    }

    public static GListHandle FreeFull(this GListHandle list, GDestroyNotify free_func)
    {
        GListExterns.g_list_free_full(list, free_func);
        return list;
    }

    public static GListHandle Append(this GListHandle list, IntPtr data)
    {
        return GListExterns.g_list_append(list, data);
    }

    public static GListHandle Prepend(this GListHandle list, IntPtr data)
    {
        return GListExterns.g_list_prepend(list, data);
    }

    public static GListHandle Insert(this GListHandle list, IntPtr data, int position)
    {
        return GListExterns.g_list_insert(list, data, position);
    }

    public static GListHandle InsertSorted(this GListHandle list, IntPtr data, GCompareFunc func)
    {
        return GListExterns.g_list_insert_sorted(list, data, func);
    }

    public static GListHandle InsertSortedWithData(this GListHandle list, IntPtr data, GCompareDataFunc func, IntPtr user_data)
    {
        return GListExterns.g_list_insert_sorted_with_data(list, data, func, user_data);
    }

    public static GListHandle InsertBefore(this GListHandle list, GListHandle sibling, IntPtr data)
    {
        return GListExterns.g_list_insert_before(list, sibling, data);
    }

    public static GListHandle InsertBeforeLink(this GListHandle list, GListHandle sibling, GListHandle link_)
    {
        return GListExterns.g_list_insert_before_link(list, sibling, link_);
    }

    public static GListHandle Concat(this GListHandle list1, GListHandle list2)
    {
        return GListExterns.g_list_concat(list1, list2);
    }

    public static GListHandle Remove(this GListHandle list, IntPtr data)
    {
        return GListExterns.g_list_remove(list, data);
    }

    public static GListHandle RemoveAll(this GListHandle list, IntPtr data)
    {
        return GListExterns.g_list_remove_all(list, data);
    }

    public static GListHandle RemoveLink(this GListHandle list, GListHandle llink)
    {
        return GListExterns.g_list_remove_link(list, llink);
    }

    public static GListHandle DeleteLink(this GListHandle list, GListHandle link_)
    {
        return GListExterns.g_list_delete_link(list, link_);
    }

    public static GListHandle Reverse(this GListHandle list)
    {
        return GListExterns.g_list_reverse(list);
    }

    public static GListHandle Copy(this GListHandle list)
    {
        return GListExterns.g_list_copy(list);
    }

    public static GListHandle CopyDeep(this GListHandle list, GCopyFunc func, IntPtr user_data)
    {
        return GListExterns.g_list_copy_deep(list, func, user_data);
    }

    public static GListHandle Nth(this GListHandle list, uint n)
    {
        return GListExterns.g_list_nth(list, n);
    }

    public static GListHandle NthPrev(this GListHandle list, uint n)
    {
        return GListExterns.g_list_nth_prev(list, n);
    }

    public static GListHandle Find(this GListHandle list, IntPtr data)
    {
        return GListExterns.g_list_find(list, data);
    }

    public static GListHandle FindCustom(this GListHandle list, IntPtr data, GCompareFunc func)
    {
        return GListExterns.g_list_find_custom(list, data, func);
    }

    public static int Position(this GListHandle list, GListHandle llink)
    {
        return GListExterns.g_list_position(list, llink);
    }

    public static int Index(this GListHandle list, IntPtr data)
    {
        return GListExterns.g_list_index(list, data);
    }

    public static GListHandle Last(this GListHandle list)
    {
        return GListExterns.g_list_last(list);
    }

    public static GListHandle First(this GListHandle list)
    {
        return GListExterns.g_list_first(list);
    }

    public static uint Length(this GListHandle list)
    {
        return GListExterns.g_list_length(list);
    }

    public static GListHandle Foreach(this GListHandle list, IntPtr func, IntPtr user_data)
    {
        GListExterns.g_list_foreach(list, func, user_data);
        return list;
    }

    public static GListHandle Sort(this GListHandle list, GCompareFunc compare_func)
    {
        return GListExterns.g_list_sort(list, compare_func);
    }

    public static GListHandle SortWithData(this GListHandle list, GCompareDataFunc compare_func, IntPtr user_data)
    {
        return GListExterns.g_list_sort_with_data(list, compare_func, user_data);
    }

    public static IntPtr NthData(this GListHandle list, uint n)
    {
        return GListExterns.g_list_nth_data(list, n);
    }
}
