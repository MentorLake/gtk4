using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GSequenceIterAdaptors
{
    public static GSequenceIterHandle GSequenceForeachRange(this GSequenceIterHandle begin, GSequenceIterHandle end, IntPtr func, IntPtr user_data)
    {
        GSequenceIterExterns.g_sequence_foreach_range(begin, end, func, user_data);
        return begin;
    }

    public static GSequenceIterHandle GSequenceInsertBefore(this GSequenceIterHandle iter, IntPtr data)
    {
        return GSequenceIterExterns.g_sequence_insert_before(iter, data);
    }

    public static GSequenceIterHandle GSequenceMove(this GSequenceIterHandle src, GSequenceIterHandle dest)
    {
        GSequenceIterExterns.g_sequence_move(src, dest);
        return src;
    }

    public static GSequenceIterHandle GSequenceSwap(this GSequenceIterHandle a, GSequenceIterHandle b)
    {
        GSequenceIterExterns.g_sequence_swap(a, b);
        return a;
    }

    public static GSequenceIterHandle GSequenceSortChanged(this GSequenceIterHandle iter, GCompareDataFunc cmp_func, IntPtr cmp_data)
    {
        GSequenceIterExterns.g_sequence_sort_changed(iter, cmp_func, cmp_data);
        return iter;
    }

    public static GSequenceIterHandle GSequenceSortChangedIter(this GSequenceIterHandle iter, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
    {
        GSequenceIterExterns.g_sequence_sort_changed_iter(iter, iter_cmp, cmp_data);
        return iter;
    }

    public static GSequenceIterHandle GSequenceRemove(this GSequenceIterHandle iter)
    {
        GSequenceIterExterns.g_sequence_remove(iter);
        return iter;
    }

    public static GSequenceIterHandle GSequenceRemoveRange(this GSequenceIterHandle begin, GSequenceIterHandle end)
    {
        GSequenceIterExterns.g_sequence_remove_range(begin, end);
        return begin;
    }

    public static GSequenceIterHandle GSequenceMoveRange(this GSequenceIterHandle dest, GSequenceIterHandle begin, GSequenceIterHandle end)
    {
        GSequenceIterExterns.g_sequence_move_range(dest, begin, end);
        return dest;
    }

    public static IntPtr GSequenceGet(this GSequenceIterHandle iter)
    {
        return GSequenceIterExterns.g_sequence_get(iter);
    }

    public static GSequenceIterHandle GSequenceSet(this GSequenceIterHandle iter, IntPtr data)
    {
        GSequenceIterExterns.g_sequence_set(iter, data);
        return iter;
    }

    public static int IsBegin(this GSequenceIterHandle iter)
    {
        return GSequenceIterExterns.g_sequence_iter_is_begin(iter);
    }

    public static int IsEnd(this GSequenceIterHandle iter)
    {
        return GSequenceIterExterns.g_sequence_iter_is_end(iter);
    }

    public static GSequenceIterHandle Next(this GSequenceIterHandle iter)
    {
        return GSequenceIterExterns.g_sequence_iter_next(iter);
    }

    public static GSequenceIterHandle Prev(this GSequenceIterHandle iter)
    {
        return GSequenceIterExterns.g_sequence_iter_prev(iter);
    }

    public static int GetPosition(this GSequenceIterHandle iter)
    {
        return GSequenceIterExterns.g_sequence_iter_get_position(iter);
    }

    public static GSequenceIterHandle Move(this GSequenceIterHandle iter, int delta)
    {
        return GSequenceIterExterns.g_sequence_iter_move(iter, delta);
    }

    public static GSequenceHandle GetSequence(this GSequenceIterHandle iter)
    {
        return GSequenceIterExterns.g_sequence_iter_get_sequence(iter);
    }

    public static int Compare(this GSequenceIterHandle a, GSequenceIterHandle b)
    {
        return GSequenceIterExterns.g_sequence_iter_compare(a, b);
    }

    public static GSequenceIterHandle GSequenceRangeGetMidpoint(this GSequenceIterHandle begin, GSequenceIterHandle end)
    {
        return GSequenceIterExterns.g_sequence_range_get_midpoint(begin, end);
    }
}
