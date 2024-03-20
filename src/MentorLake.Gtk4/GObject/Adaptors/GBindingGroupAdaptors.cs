using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GBindingGroupAdaptors
{
	public static IntPtr DupSource(this GBindingGroupHandle self)
	{
		return GBindingGroupExterns.g_binding_group_dup_source(self);
	}

	public static GBindingGroupHandle SetSource(this GBindingGroupHandle self, IntPtr source)
	{
		GBindingGroupExterns.g_binding_group_set_source(self, source);
		return self;
	}

	public static GBindingGroupHandle Bind(this GBindingGroupHandle self, string source_property, IntPtr target, string target_property, GBindingFlags flags)
	{
		GBindingGroupExterns.g_binding_group_bind(self, source_property, target, target_property, flags);
		return self;
	}

	public static GBindingGroupHandle BindFull(this GBindingGroupHandle self, string source_property, IntPtr target, string target_property, GBindingFlags flags, GBindingTransformFunc transform_to, GBindingTransformFunc transform_from, IntPtr user_data, GDestroyNotify user_data_destroy)
	{
		GBindingGroupExterns.g_binding_group_bind_full(self, source_property, target, target_property, flags, transform_to, transform_from, user_data, user_data_destroy);
		return self;
	}

	public static GBindingGroupHandle BindWithClosures(this GBindingGroupHandle self, string source_property, IntPtr target, string target_property, GBindingFlags flags, GClosureHandle transform_to, GClosureHandle transform_from)
	{
		GBindingGroupExterns.g_binding_group_bind_with_closures(self, source_property, target, target_property, flags, transform_to, transform_from);
		return self;
	}
}
