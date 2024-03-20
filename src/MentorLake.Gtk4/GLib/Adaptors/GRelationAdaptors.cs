using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GRelationAdaptors
{
	public static GRelationHandle Destroy(this GRelationHandle relation)
	{
		GRelationExterns.g_relation_destroy(relation);
		return relation;
	}

	public static GRelationHandle Index(this GRelationHandle relation, int field, GHashFunc hash_func, GEqualFunc key_equal_func)
	{
		GRelationExterns.g_relation_index(relation, field, hash_func, key_equal_func);
		return relation;
	}

	public static GRelationHandle Insert(this GRelationHandle relation, IntPtr @__argList)
	{
		GRelationExterns.g_relation_insert(relation, @__argList);
		return relation;
	}

	public static int Delete(this GRelationHandle relation, IntPtr key, int field)
	{
		return GRelationExterns.g_relation_delete(relation, key, field);
	}

	public static GTuplesHandle Select(this GRelationHandle relation, IntPtr key, int field)
	{
		return GRelationExterns.g_relation_select(relation, key, field);
	}

	public static int Count(this GRelationHandle relation, IntPtr key, int field)
	{
		return GRelationExterns.g_relation_count(relation, key, field);
	}

	public static int Exists(this GRelationHandle relation, IntPtr @__argList)
	{
		return GRelationExterns.g_relation_exists(relation, @__argList);
	}

	public static GRelationHandle Print(this GRelationHandle relation)
	{
		GRelationExterns.g_relation_print(relation);
		return relation;
	}
}
