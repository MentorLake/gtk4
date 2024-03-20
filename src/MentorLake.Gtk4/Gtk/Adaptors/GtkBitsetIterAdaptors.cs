using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBitsetIterAdaptors
{
    public static int InitFirst(this GtkBitsetIterHandle iter, GtkBitsetHandle set, out uint value)
    {
        return GtkBitsetIterExterns.gtk_bitset_iter_init_first(iter, set, out value);
    }

    public static int InitLast(this GtkBitsetIterHandle iter, GtkBitsetHandle set, out uint value)
    {
        return GtkBitsetIterExterns.gtk_bitset_iter_init_last(iter, set, out value);
    }

    public static int InitAt(this GtkBitsetIterHandle iter, GtkBitsetHandle set, uint target, out uint value)
    {
        return GtkBitsetIterExterns.gtk_bitset_iter_init_at(iter, set, target, out value);
    }

    public static int Next(this GtkBitsetIterHandle iter, out uint value)
    {
        return GtkBitsetIterExterns.gtk_bitset_iter_next(iter, out value);
    }

    public static int Previous(this GtkBitsetIterHandle iter, out uint value)
    {
        return GtkBitsetIterExterns.gtk_bitset_iter_previous(iter, out value);
    }

    public static uint GetValue(this GtkBitsetIterHandle iter)
    {
        return GtkBitsetIterExterns.gtk_bitset_iter_get_value(iter);
    }

    public static int IsValid(this GtkBitsetIterHandle iter)
    {
        return GtkBitsetIterExterns.gtk_bitset_iter_is_valid(iter);
    }
}
