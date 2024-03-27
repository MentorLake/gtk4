using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.GObject;

public class GBindingGroupHandle : GObjectHandle
{
	public static GBindingGroupHandle New()
	{
		return GBindingGroupExterns.g_binding_group_new();
	}
}

public static class GBindingGroupSignals
{
}

public static class GBindingGroupHandleExtensions
{
	public static GBindingGroupHandle Bind(this GBindingGroupHandle self, string source_property, GObjectHandle target, string target_property, GBindingFlags flags)
	{
		GBindingGroupExterns.g_binding_group_bind(self, source_property, target, target_property, flags);
		return self;
	}

	public static GBindingGroupHandle BindFull(this GBindingGroupHandle self, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GBindingTransformFunc transform_to, GBindingTransformFunc transform_from, IntPtr user_data, GDestroyNotify user_data_destroy)
	{
		GBindingGroupExterns.g_binding_group_bind_full(self, source_property, target, target_property, flags, transform_to, transform_from, user_data, user_data_destroy);
		return self;
	}

	public static GBindingGroupHandle BindWithClosures(this GBindingGroupHandle self, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GClosureHandle transform_to, GClosureHandle transform_from)
	{
		GBindingGroupExterns.g_binding_group_bind_with_closures(self, source_property, target, target_property, flags, transform_to, transform_from);
		return self;
	}

	public static GObjectHandle DupSource(this GBindingGroupHandle self)
	{
		return GBindingGroupExterns.g_binding_group_dup_source(self);
	}

	public static GBindingGroupHandle SetSource(this GBindingGroupHandle self, GObjectHandle source)
	{
		GBindingGroupExterns.g_binding_group_set_source(self, source);
		return self;
	}

}

internal class GBindingGroupExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern void g_binding_group_bind(GBindingGroupHandle self, string source_property, GObjectHandle target, string target_property, GBindingFlags flags);
	[DllImport(Libraries.GObject)]
	internal static extern void g_binding_group_bind_full(GBindingGroupHandle self, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GBindingTransformFunc transform_to, GBindingTransformFunc transform_from, IntPtr user_data, GDestroyNotify user_data_destroy);
	[DllImport(Libraries.GObject)]
	internal static extern void g_binding_group_bind_with_closures(GBindingGroupHandle self, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GClosureHandle transform_to, GClosureHandle transform_from);
	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_binding_group_dup_source(GBindingGroupHandle self);
	[DllImport(Libraries.GObject)]
	internal static extern void g_binding_group_set_source(GBindingGroupHandle self, GObjectHandle source);
	[DllImport(Libraries.GObject)]
	internal static extern GBindingGroupHandle g_binding_group_new();
}
