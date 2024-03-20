using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBitsetAdaptors
{
	public static GtkBitsetHandle Ref(this GtkBitsetHandle self)
	{
		return GtkBitsetExterns.gtk_bitset_ref(self);
	}

	public static GtkBitsetHandle Unref(this GtkBitsetHandle self)
	{
		GtkBitsetExterns.gtk_bitset_unref(self);
		return self;
	}

	public static int Contains(this GtkBitsetHandle self, uint value)
	{
		return GtkBitsetExterns.gtk_bitset_contains(self, value);
	}

	public static int IsEmpty(this GtkBitsetHandle self)
	{
		return GtkBitsetExterns.gtk_bitset_is_empty(self);
	}

	public static int Equals(this GtkBitsetHandle self, GtkBitsetHandle other)
	{
		return GtkBitsetExterns.gtk_bitset_equals(self, other);
	}

	public static nuint GetSize(this GtkBitsetHandle self)
	{
		return GtkBitsetExterns.gtk_bitset_get_size(self);
	}

	public static nuint GetSizeInRange(this GtkBitsetHandle self, uint first, uint last)
	{
		return GtkBitsetExterns.gtk_bitset_get_size_in_range(self, first, last);
	}

	public static uint GetNth(this GtkBitsetHandle self, uint nth)
	{
		return GtkBitsetExterns.gtk_bitset_get_nth(self, nth);
	}

	public static uint GetMinimum(this GtkBitsetHandle self)
	{
		return GtkBitsetExterns.gtk_bitset_get_minimum(self);
	}

	public static uint GetMaximum(this GtkBitsetHandle self)
	{
		return GtkBitsetExterns.gtk_bitset_get_maximum(self);
	}

	public static GtkBitsetHandle Copy(this GtkBitsetHandle self)
	{
		return GtkBitsetExterns.gtk_bitset_copy(self);
	}

	public static GtkBitsetHandle RemoveAll(this GtkBitsetHandle self)
	{
		GtkBitsetExterns.gtk_bitset_remove_all(self);
		return self;
	}

	public static int Add(this GtkBitsetHandle self, uint value)
	{
		return GtkBitsetExterns.gtk_bitset_add(self, value);
	}

	public static int Remove(this GtkBitsetHandle self, uint value)
	{
		return GtkBitsetExterns.gtk_bitset_remove(self, value);
	}

	public static GtkBitsetHandle AddRange(this GtkBitsetHandle self, uint start, uint n_items)
	{
		GtkBitsetExterns.gtk_bitset_add_range(self, start, n_items);
		return self;
	}

	public static GtkBitsetHandle RemoveRange(this GtkBitsetHandle self, uint start, uint n_items)
	{
		GtkBitsetExterns.gtk_bitset_remove_range(self, start, n_items);
		return self;
	}

	public static GtkBitsetHandle AddRangeClosed(this GtkBitsetHandle self, uint first, uint last)
	{
		GtkBitsetExterns.gtk_bitset_add_range_closed(self, first, last);
		return self;
	}

	public static GtkBitsetHandle RemoveRangeClosed(this GtkBitsetHandle self, uint first, uint last)
	{
		GtkBitsetExterns.gtk_bitset_remove_range_closed(self, first, last);
		return self;
	}

	public static GtkBitsetHandle AddRectangle(this GtkBitsetHandle self, uint start, uint width, uint height, uint stride)
	{
		GtkBitsetExterns.gtk_bitset_add_rectangle(self, start, width, height, stride);
		return self;
	}

	public static GtkBitsetHandle RemoveRectangle(this GtkBitsetHandle self, uint start, uint width, uint height, uint stride)
	{
		GtkBitsetExterns.gtk_bitset_remove_rectangle(self, start, width, height, stride);
		return self;
	}

	public static GtkBitsetHandle Union(this GtkBitsetHandle self, GtkBitsetHandle other)
	{
		GtkBitsetExterns.gtk_bitset_union(self, other);
		return self;
	}

	public static GtkBitsetHandle Intersect(this GtkBitsetHandle self, GtkBitsetHandle other)
	{
		GtkBitsetExterns.gtk_bitset_intersect(self, other);
		return self;
	}

	public static GtkBitsetHandle Subtract(this GtkBitsetHandle self, GtkBitsetHandle other)
	{
		GtkBitsetExterns.gtk_bitset_subtract(self, other);
		return self;
	}

	public static GtkBitsetHandle Difference(this GtkBitsetHandle self, GtkBitsetHandle other)
	{
		GtkBitsetExterns.gtk_bitset_difference(self, other);
		return self;
	}

	public static GtkBitsetHandle ShiftLeft(this GtkBitsetHandle self, uint amount)
	{
		GtkBitsetExterns.gtk_bitset_shift_left(self, amount);
		return self;
	}

	public static GtkBitsetHandle ShiftRight(this GtkBitsetHandle self, uint amount)
	{
		GtkBitsetExterns.gtk_bitset_shift_right(self, amount);
		return self;
	}

	public static GtkBitsetHandle Splice(this GtkBitsetHandle self, uint position, uint removed, uint added)
	{
		GtkBitsetExterns.gtk_bitset_splice(self, position, removed, added);
		return self;
	}

	public static GtkBitsetHandle NewRange(uint start, uint n_items)
	{
		return GtkBitsetExterns.gtk_bitset_new_range(start, n_items);
	}
}
