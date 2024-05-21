namespace MentorLake.Gtk4.GObject;

public class GParamSpecPoolHandle : BaseSafeHandle
{
}


public static class GParamSpecPoolHandleExtensions
{
	public static GParamSpecPoolHandle Free(this GParamSpecPoolHandle pool)
	{
		GParamSpecPoolExterns.g_param_spec_pool_free(pool);
		return pool;
	}

	public static GParamSpecPoolHandle Insert(this GParamSpecPoolHandle pool, GParamSpecHandle pspec, GType owner_type)
	{
		GParamSpecPoolExterns.g_param_spec_pool_insert(pool, pspec, owner_type);
		return pool;
	}

	public static IntPtr List(this GParamSpecPoolHandle pool, GType owner_type, out uint n_pspecs_p)
	{
		return GParamSpecPoolExterns.g_param_spec_pool_list(pool, owner_type, out n_pspecs_p);
	}

	public static GListHandle ListOwned(this GParamSpecPoolHandle pool, GType owner_type)
	{
		return GParamSpecPoolExterns.g_param_spec_pool_list_owned(pool, owner_type);
	}

	public static GParamSpecHandle Lookup(this GParamSpecPoolHandle pool, string param_name, GType owner_type, bool walk_ancestors)
	{
		return GParamSpecPoolExterns.g_param_spec_pool_lookup(pool, param_name, owner_type, walk_ancestors);
	}

	public static GParamSpecPoolHandle Remove(this GParamSpecPoolHandle pool, GParamSpecHandle pspec)
	{
		GParamSpecPoolExterns.g_param_spec_pool_remove(pool, pspec);
		return pool;
	}

}
internal class GParamSpecPoolExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern void g_param_spec_pool_free(GParamSpecPoolHandle pool);

	[DllImport(Libraries.GObject)]
	internal static extern void g_param_spec_pool_insert(GParamSpecPoolHandle pool, GParamSpecHandle pspec, GType owner_type);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_param_spec_pool_list(GParamSpecPoolHandle pool, GType owner_type, out uint n_pspecs_p);

	[DllImport(Libraries.GObject)]
	internal static extern GListHandle g_param_spec_pool_list_owned(GParamSpecPoolHandle pool, GType owner_type);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_pool_lookup(GParamSpecPoolHandle pool, string param_name, GType owner_type, bool walk_ancestors);

	[DllImport(Libraries.GObject)]
	internal static extern void g_param_spec_pool_remove(GParamSpecPoolHandle pool, GParamSpecHandle pspec);

}

public struct GParamSpecPool
{
}
