using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GParamSpecPoolAdaptors
{
	public static GParamSpecPoolHandle Insert(this GParamSpecPoolHandle pool, GParamSpecHandle pspec, GType owner_type)
	{
		GParamSpecPoolExterns.g_param_spec_pool_insert(pool, pspec, owner_type);
		return pool;
	}

	public static GParamSpecPoolHandle Remove(this GParamSpecPoolHandle pool, GParamSpecHandle pspec)
	{
		GParamSpecPoolExterns.g_param_spec_pool_remove(pool, pspec);
		return pool;
	}

	public static GParamSpecHandle Lookup(this GParamSpecPoolHandle pool, string param_name, GType owner_type, int walk_ancestors)
	{
		return GParamSpecPoolExterns.g_param_spec_pool_lookup(pool, param_name, owner_type, walk_ancestors);
	}

	public static GListHandle ListOwned(this GParamSpecPoolHandle pool, GType owner_type)
	{
		return GParamSpecPoolExterns.g_param_spec_pool_list_owned(pool, owner_type);
	}

	public static GParamSpecHandle[] List(this GParamSpecPoolHandle pool, GType owner_type, out uint n_pspecs_p)
	{
		return GParamSpecPoolExterns.g_param_spec_pool_list(pool, owner_type, out n_pspecs_p);
	}
}
