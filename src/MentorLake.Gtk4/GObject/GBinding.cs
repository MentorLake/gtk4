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

public class GBindingHandle : GObjectHandle
{
}

public static class GBindingSignals
{
}

public static class GBindingHandleExtensions
{
	public static GObjectHandle DupSource(this GBindingHandle binding)
	{
		return GBindingExterns.g_binding_dup_source(binding);
	}

	public static GObjectHandle DupTarget(this GBindingHandle binding)
	{
		return GBindingExterns.g_binding_dup_target(binding);
	}

	public static GBindingFlags GetFlags(this GBindingHandle binding)
	{
		return GBindingExterns.g_binding_get_flags(binding);
	}

	public static GObjectHandle GetSource(this GBindingHandle binding)
	{
		return GBindingExterns.g_binding_get_source(binding);
	}

	public static string GetSourceProperty(this GBindingHandle binding)
	{
		return GBindingExterns.g_binding_get_source_property(binding);
	}

	public static GObjectHandle GetTarget(this GBindingHandle binding)
	{
		return GBindingExterns.g_binding_get_target(binding);
	}

	public static string GetTargetProperty(this GBindingHandle binding)
	{
		return GBindingExterns.g_binding_get_target_property(binding);
	}

	public static GBindingHandle Unbind(this GBindingHandle binding)
	{
		GBindingExterns.g_binding_unbind(binding);
		return binding;
	}

}

internal class GBindingExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_binding_dup_source(GBindingHandle binding);
	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_binding_dup_target(GBindingHandle binding);
	[DllImport(Libraries.GObject)]
	internal static extern GBindingFlags g_binding_get_flags(GBindingHandle binding);
	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_binding_get_source(GBindingHandle binding);
	[DllImport(Libraries.GObject)]
	internal static extern string g_binding_get_source_property(GBindingHandle binding);
	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_binding_get_target(GBindingHandle binding);
	[DllImport(Libraries.GObject)]
	internal static extern string g_binding_get_target_property(GBindingHandle binding);
	[DllImport(Libraries.GObject)]
	internal static extern void g_binding_unbind(GBindingHandle binding);
}
