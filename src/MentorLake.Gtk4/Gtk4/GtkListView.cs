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

public class GtkListViewHandle : GtkListBaseHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle, GtkScrollableHandle
{
	public static GtkListViewHandle New(GtkSelectionModelHandle model, GtkListItemFactoryHandle factory)
	{
		return GtkListViewExterns.gtk_list_view_new(model, factory);
	}

}

public static class GtkListViewSignalExtensions
{
	public static GtkListViewHandle Signal_Activate(this GtkListViewHandle instance, GtkListViewSignalDelegates.Activate handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkListViewSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListViewHandle>))] GtkListViewHandle self, uint position, IntPtr user_data);
}


public static class GtkListViewHandleExtensions
{
	public static bool GetEnableRubberband(this GtkListViewHandle self)
	{
		return GtkListViewExterns.gtk_list_view_get_enable_rubberband(self);
	}

	public static GtkListItemFactoryHandle GetFactory(this GtkListViewHandle self)
	{
		return GtkListViewExterns.gtk_list_view_get_factory(self);
	}

	public static GtkListItemFactoryHandle GetHeaderFactory(this GtkListViewHandle self)
	{
		return GtkListViewExterns.gtk_list_view_get_header_factory(self);
	}

	public static GtkSelectionModelHandle GetModel(this GtkListViewHandle self)
	{
		return GtkListViewExterns.gtk_list_view_get_model(self);
	}

	public static bool GetShowSeparators(this GtkListViewHandle self)
	{
		return GtkListViewExterns.gtk_list_view_get_show_separators(self);
	}

	public static bool GetSingleClickActivate(this GtkListViewHandle self)
	{
		return GtkListViewExterns.gtk_list_view_get_single_click_activate(self);
	}

	public static GtkListTabBehavior GetTabBehavior(this GtkListViewHandle self)
	{
		return GtkListViewExterns.gtk_list_view_get_tab_behavior(self);
	}

	public static GtkListViewHandle ScrollTo(this GtkListViewHandle self, uint pos, GtkListScrollFlags flags, GtkScrollInfoHandle scroll)
	{
		GtkListViewExterns.gtk_list_view_scroll_to(self, pos, flags, scroll);
		return self;
	}

	public static GtkListViewHandle SetEnableRubberband(this GtkListViewHandle self, bool enable_rubberband)
	{
		GtkListViewExterns.gtk_list_view_set_enable_rubberband(self, enable_rubberband);
		return self;
	}

	public static GtkListViewHandle SetFactory(this GtkListViewHandle self, GtkListItemFactoryHandle factory)
	{
		GtkListViewExterns.gtk_list_view_set_factory(self, factory);
		return self;
	}

	public static GtkListViewHandle SetHeaderFactory(this GtkListViewHandle self, GtkListItemFactoryHandle factory)
	{
		GtkListViewExterns.gtk_list_view_set_header_factory(self, factory);
		return self;
	}

	public static GtkListViewHandle SetModel(this GtkListViewHandle self, GtkSelectionModelHandle model)
	{
		GtkListViewExterns.gtk_list_view_set_model(self, model);
		return self;
	}

	public static GtkListViewHandle SetShowSeparators(this GtkListViewHandle self, bool show_separators)
	{
		GtkListViewExterns.gtk_list_view_set_show_separators(self, show_separators);
		return self;
	}

	public static GtkListViewHandle SetSingleClickActivate(this GtkListViewHandle self, bool single_click_activate)
	{
		GtkListViewExterns.gtk_list_view_set_single_click_activate(self, single_click_activate);
		return self;
	}

	public static GtkListViewHandle SetTabBehavior(this GtkListViewHandle self, GtkListTabBehavior tab_behavior)
	{
		GtkListViewExterns.gtk_list_view_set_tab_behavior(self, tab_behavior);
		return self;
	}

}

internal class GtkListViewExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListViewHandle gtk_list_view_new(GtkSelectionModelHandle model, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_view_get_enable_rubberband(GtkListViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListItemFactoryHandle gtk_list_view_get_factory(GtkListViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListItemFactoryHandle gtk_list_view_get_header_factory(GtkListViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSelectionModelHandle gtk_list_view_get_model(GtkListViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_view_get_show_separators(GtkListViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_view_get_single_click_activate(GtkListViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListTabBehavior gtk_list_view_get_tab_behavior(GtkListViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_view_scroll_to(GtkListViewHandle self, uint pos, GtkListScrollFlags flags, GtkScrollInfoHandle scroll);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_view_set_enable_rubberband(GtkListViewHandle self, bool enable_rubberband);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_view_set_factory(GtkListViewHandle self, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_view_set_header_factory(GtkListViewHandle self, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_view_set_model(GtkListViewHandle self, GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_view_set_show_separators(GtkListViewHandle self, bool show_separators);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_view_set_single_click_activate(GtkListViewHandle self, bool single_click_activate);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_view_set_tab_behavior(GtkListViewHandle self, GtkListTabBehavior tab_behavior);

}
