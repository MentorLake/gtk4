namespace MentorLake.Gtk4.GLib;

public class GRelationHandle : BaseSafeHandle
{
}


public static class GRelationHandleExtensions
{
	public static int Count(this GRelationHandle relation, IntPtr key, int field)
	{
		return GRelationExterns.g_relation_count(relation, key, field);
	}

	public static int Delete(this GRelationHandle relation, IntPtr key, int field)
	{
		return GRelationExterns.g_relation_delete(relation, key, field);
	}

	public static GRelationHandle Destroy(this GRelationHandle relation)
	{
		GRelationExterns.g_relation_destroy(relation);
		return relation;
	}

	public static bool Exists(this GRelationHandle relation, IntPtr @__arglist)
	{
		return GRelationExterns.g_relation_exists(relation, @__arglist);
	}

	public static GRelationHandle Index(this GRelationHandle relation, int field, GHashFunc hash_func, GEqualFunc key_equal_func)
	{
		GRelationExterns.g_relation_index(relation, field, hash_func, key_equal_func);
		return relation;
	}

	public static GRelationHandle Insert(this GRelationHandle relation, IntPtr @__arglist)
	{
		GRelationExterns.g_relation_insert(relation, @__arglist);
		return relation;
	}

	public static GRelationHandle Print(this GRelationHandle relation)
	{
		GRelationExterns.g_relation_print(relation);
		return relation;
	}

	public static GTuplesHandle Select(this GRelationHandle relation, IntPtr key, int field)
	{
		return GRelationExterns.g_relation_select(relation, key, field);
	}

}
internal class GRelationExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern int g_relation_count(GRelationHandle relation, IntPtr key, int field);

	[DllImport(Libraries.GLib)]
	internal static extern int g_relation_delete(GRelationHandle relation, IntPtr key, int field);

	[DllImport(Libraries.GLib)]
	internal static extern void g_relation_destroy(GRelationHandle relation);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_relation_exists(GRelationHandle relation, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_relation_index(GRelationHandle relation, int field, GHashFunc hash_func, GEqualFunc key_equal_func);

	[DllImport(Libraries.GLib)]
	internal static extern void g_relation_insert(GRelationHandle relation, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_relation_print(GRelationHandle relation);

	[DllImport(Libraries.GLib)]
	internal static extern GTuplesHandle g_relation_select(GRelationHandle relation, IntPtr key, int field);

}

public struct GRelation
{
}
