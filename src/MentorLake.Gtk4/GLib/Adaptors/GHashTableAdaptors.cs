using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GHashTableAdaptors
{
	public static GHashTableHandle NewSimilar(this GHashTableHandle other_hash_table)
	{
		return GHashTableExterns.g_hash_table_new_similar(other_hash_table);
	}

	public static GHashTableHandle Destroy(this GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_destroy(hash_table);
		return hash_table;
	}

	public static int Insert(this GHashTableHandle hash_table, IntPtr key, IntPtr value)
	{
		return GHashTableExterns.g_hash_table_insert(hash_table, key, value);
	}

	public static int Replace(this GHashTableHandle hash_table, IntPtr key, IntPtr value)
	{
		return GHashTableExterns.g_hash_table_replace(hash_table, key, value);
	}

	public static int Add(this GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_add(hash_table, key);
	}

	public static int Remove(this GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_remove(hash_table, key);
	}

	public static GHashTableHandle RemoveAll(this GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_remove_all(hash_table);
		return hash_table;
	}

	public static int Steal(this GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_steal(hash_table, key);
	}

	public static int StealExtended(this GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr stolen_key, out IntPtr stolen_value)
	{
		return GHashTableExterns.g_hash_table_steal_extended(hash_table, lookup_key, out stolen_key, out stolen_value);
	}

	public static GHashTableHandle StealAll(this GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_steal_all(hash_table);
		return hash_table;
	}

	public static IntPtr Lookup(this GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_lookup(hash_table, key);
	}

	public static int Contains(this GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_contains(hash_table, key);
	}

	public static int LookupExtended(this GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value)
	{
		return GHashTableExterns.g_hash_table_lookup_extended(hash_table, lookup_key, out orig_key, out value);
	}

	public static GHashTableHandle Foreach(this GHashTableHandle hash_table, GHFunc func, IntPtr user_data)
	{
		GHashTableExterns.g_hash_table_foreach(hash_table, func, user_data);
		return hash_table;
	}

	public static IntPtr Find(this GHashTableHandle hash_table, GHRFunc predicate, IntPtr user_data)
	{
		return GHashTableExterns.g_hash_table_find(hash_table, predicate, user_data);
	}

	public static uint ForeachRemove(this GHashTableHandle hash_table, GHRFunc func, IntPtr user_data)
	{
		return GHashTableExterns.g_hash_table_foreach_remove(hash_table, func, user_data);
	}

	public static uint ForeachSteal(this GHashTableHandle hash_table, GHRFunc func, IntPtr user_data)
	{
		return GHashTableExterns.g_hash_table_foreach_steal(hash_table, func, user_data);
	}

	public static uint Size(this GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_size(hash_table);
	}

	public static GListHandle GetKeys(this GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_keys(hash_table);
	}

	public static GListHandle GetValues(this GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_values(hash_table);
	}

	public static IntPtr[] GetKeysAsArray(this GHashTableHandle hash_table, out uint length)
	{
		return GHashTableExterns.g_hash_table_get_keys_as_array(hash_table, out length);
	}

	public static GHashTableHandle Ref(this GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_ref(hash_table);
	}

	public static GHashTableHandle Unref(this GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_unref(hash_table);
		return hash_table;
	}

	public static GHashTableHandle NewFull(GHashFunc hash_func, GEqualFunc key_equal_func, GDestroyNotify key_destroy_func, GDestroyNotify value_destroy_func)
	{
		return GHashTableExterns.g_hash_table_new_full(hash_func, key_equal_func, key_destroy_func, value_destroy_func);
	}
}
