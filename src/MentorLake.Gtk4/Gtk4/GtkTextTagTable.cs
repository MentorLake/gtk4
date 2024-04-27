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

namespace MentorLake.Gtk4.Gtk4;

public class GtkTextTagTableHandle : GObjectHandle, GtkBuildableHandle
{
	public static GtkTextTagTableHandle New()
	{
		return GtkTextTagTableExterns.gtk_text_tag_table_new();
	}

}

public static class GtkTextTagTableSignalExtensions
{
	public static GtkTextTagTableHandle Signal_TagAdded(this GtkTextTagTableHandle instance, GtkTextTagTableSignalDelegates.TagAdded handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "tag_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkTextTagTableHandle Signal_TagChanged(this GtkTextTagTableHandle instance, GtkTextTagTableSignalDelegates.TagChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "tag_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkTextTagTableHandle Signal_TagRemoved(this GtkTextTagTableHandle instance, GtkTextTagTableSignalDelegates.TagRemoved handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "tag_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkTextTagTableSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void TagAdded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextTagTableHandle>))] GtkTextTagTableHandle self, GtkTextTagHandle tag, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void TagChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextTagTableHandle>))] GtkTextTagTableHandle self, GtkTextTagHandle tag, bool size_changed, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void TagRemoved([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextTagTableHandle>))] GtkTextTagTableHandle self, GtkTextTagHandle tag, IntPtr user_data);
}


public static class GtkTextTagTableHandleExtensions
{
	public static bool Add(this GtkTextTagTableHandle table, GtkTextTagHandle tag)
	{
		return GtkTextTagTableExterns.gtk_text_tag_table_add(table, tag);
	}

	public static GtkTextTagTableHandle Foreach(this GtkTextTagTableHandle table, GtkTextTagTableForeach func, IntPtr data)
	{
		GtkTextTagTableExterns.gtk_text_tag_table_foreach(table, func, data);
		return table;
	}

	public static int GetSize(this GtkTextTagTableHandle table)
	{
		return GtkTextTagTableExterns.gtk_text_tag_table_get_size(table);
	}

	public static GtkTextTagHandle Lookup(this GtkTextTagTableHandle table, string name)
	{
		return GtkTextTagTableExterns.gtk_text_tag_table_lookup(table, name);
	}

	public static GtkTextTagTableHandle Remove(this GtkTextTagTableHandle table, GtkTextTagHandle tag)
	{
		GtkTextTagTableExterns.gtk_text_tag_table_remove(table, tag);
		return table;
	}

}

internal class GtkTextTagTableExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextTagTableHandle gtk_text_tag_table_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_tag_table_add(GtkTextTagTableHandle table, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_tag_table_foreach(GtkTextTagTableHandle table, GtkTextTagTableForeach func, IntPtr data);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_tag_table_get_size(GtkTextTagTableHandle table);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextTagHandle gtk_text_tag_table_lookup(GtkTextTagTableHandle table, string name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_tag_table_remove(GtkTextTagTableHandle table, GtkTextTagHandle tag);

}
