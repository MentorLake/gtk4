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

public class GtkColumnViewHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkScrollableHandle
{
	public static GtkColumnViewHandle New(GtkSelectionModelHandle model)
	{
		return GtkColumnViewExterns.gtk_column_view_new(model);
	}

}

public static class GtkColumnViewSignalExtensions
{
	public static GtkColumnViewHandle Signal_Activate(this GtkColumnViewHandle instance, GtkColumnViewSignalDelegates.Activate handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkColumnViewSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkColumnViewHandle>))] GtkColumnViewHandle self, uint position, IntPtr user_data);
}


public static class GtkColumnViewHandleExtensions
{
	public static GtkColumnViewHandle AppendColumn(this GtkColumnViewHandle self, GtkColumnViewColumnHandle column)
	{
		GtkColumnViewExterns.gtk_column_view_append_column(self, column);
		return self;
	}

	public static GListModelHandle GetColumns(this GtkColumnViewHandle self)
	{
		return GtkColumnViewExterns.gtk_column_view_get_columns(self);
	}

	public static bool GetEnableRubberband(this GtkColumnViewHandle self)
	{
		return GtkColumnViewExterns.gtk_column_view_get_enable_rubberband(self);
	}

	public static GtkListItemFactoryHandle GetHeaderFactory(this GtkColumnViewHandle self)
	{
		return GtkColumnViewExterns.gtk_column_view_get_header_factory(self);
	}

	public static GtkSelectionModelHandle GetModel(this GtkColumnViewHandle self)
	{
		return GtkColumnViewExterns.gtk_column_view_get_model(self);
	}

	public static bool GetReorderable(this GtkColumnViewHandle self)
	{
		return GtkColumnViewExterns.gtk_column_view_get_reorderable(self);
	}

	public static GtkListItemFactoryHandle GetRowFactory(this GtkColumnViewHandle self)
	{
		return GtkColumnViewExterns.gtk_column_view_get_row_factory(self);
	}

	public static bool GetShowColumnSeparators(this GtkColumnViewHandle self)
	{
		return GtkColumnViewExterns.gtk_column_view_get_show_column_separators(self);
	}

	public static bool GetShowRowSeparators(this GtkColumnViewHandle self)
	{
		return GtkColumnViewExterns.gtk_column_view_get_show_row_separators(self);
	}

	public static bool GetSingleClickActivate(this GtkColumnViewHandle self)
	{
		return GtkColumnViewExterns.gtk_column_view_get_single_click_activate(self);
	}

	public static GtkSorterHandle GetSorter(this GtkColumnViewHandle self)
	{
		return GtkColumnViewExterns.gtk_column_view_get_sorter(self);
	}

	public static GtkListTabBehavior GetTabBehavior(this GtkColumnViewHandle self)
	{
		return GtkColumnViewExterns.gtk_column_view_get_tab_behavior(self);
	}

	public static GtkColumnViewHandle InsertColumn(this GtkColumnViewHandle self, uint position, GtkColumnViewColumnHandle column)
	{
		GtkColumnViewExterns.gtk_column_view_insert_column(self, position, column);
		return self;
	}

	public static GtkColumnViewHandle RemoveColumn(this GtkColumnViewHandle self, GtkColumnViewColumnHandle column)
	{
		GtkColumnViewExterns.gtk_column_view_remove_column(self, column);
		return self;
	}

	public static GtkColumnViewHandle ScrollTo(this GtkColumnViewHandle self, uint pos, GtkColumnViewColumnHandle column, GtkListScrollFlags flags, GtkScrollInfoHandle scroll)
	{
		GtkColumnViewExterns.gtk_column_view_scroll_to(self, pos, column, flags, scroll);
		return self;
	}

	public static GtkColumnViewHandle SetEnableRubberband(this GtkColumnViewHandle self, bool enable_rubberband)
	{
		GtkColumnViewExterns.gtk_column_view_set_enable_rubberband(self, enable_rubberband);
		return self;
	}

	public static GtkColumnViewHandle SetHeaderFactory(this GtkColumnViewHandle self, GtkListItemFactoryHandle factory)
	{
		GtkColumnViewExterns.gtk_column_view_set_header_factory(self, factory);
		return self;
	}

	public static GtkColumnViewHandle SetModel(this GtkColumnViewHandle self, GtkSelectionModelHandle model)
	{
		GtkColumnViewExterns.gtk_column_view_set_model(self, model);
		return self;
	}

	public static GtkColumnViewHandle SetReorderable(this GtkColumnViewHandle self, bool reorderable)
	{
		GtkColumnViewExterns.gtk_column_view_set_reorderable(self, reorderable);
		return self;
	}

	public static GtkColumnViewHandle SetRowFactory(this GtkColumnViewHandle self, GtkListItemFactoryHandle factory)
	{
		GtkColumnViewExterns.gtk_column_view_set_row_factory(self, factory);
		return self;
	}

	public static GtkColumnViewHandle SetShowColumnSeparators(this GtkColumnViewHandle self, bool show_column_separators)
	{
		GtkColumnViewExterns.gtk_column_view_set_show_column_separators(self, show_column_separators);
		return self;
	}

	public static GtkColumnViewHandle SetShowRowSeparators(this GtkColumnViewHandle self, bool show_row_separators)
	{
		GtkColumnViewExterns.gtk_column_view_set_show_row_separators(self, show_row_separators);
		return self;
	}

	public static GtkColumnViewHandle SetSingleClickActivate(this GtkColumnViewHandle self, bool single_click_activate)
	{
		GtkColumnViewExterns.gtk_column_view_set_single_click_activate(self, single_click_activate);
		return self;
	}

	public static GtkColumnViewHandle SetTabBehavior(this GtkColumnViewHandle self, GtkListTabBehavior tab_behavior)
	{
		GtkColumnViewExterns.gtk_column_view_set_tab_behavior(self, tab_behavior);
		return self;
	}

	public static GtkColumnViewHandle SortByColumn(this GtkColumnViewHandle self, GtkColumnViewColumnHandle column, GtkSortType direction)
	{
		GtkColumnViewExterns.gtk_column_view_sort_by_column(self, column, direction);
		return self;
	}

}

internal class GtkColumnViewExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColumnViewHandle gtk_column_view_new(GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_append_column(GtkColumnViewHandle self, GtkColumnViewColumnHandle column);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_column_view_get_columns(GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_get_enable_rubberband(GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListItemFactoryHandle gtk_column_view_get_header_factory(GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSelectionModelHandle gtk_column_view_get_model(GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_get_reorderable(GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListItemFactoryHandle gtk_column_view_get_row_factory(GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_get_show_column_separators(GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_get_show_row_separators(GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_get_single_click_activate(GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSorterHandle gtk_column_view_get_sorter(GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListTabBehavior gtk_column_view_get_tab_behavior(GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_insert_column(GtkColumnViewHandle self, uint position, GtkColumnViewColumnHandle column);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_remove_column(GtkColumnViewHandle self, GtkColumnViewColumnHandle column);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_scroll_to(GtkColumnViewHandle self, uint pos, GtkColumnViewColumnHandle column, GtkListScrollFlags flags, GtkScrollInfoHandle scroll);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_set_enable_rubberband(GtkColumnViewHandle self, bool enable_rubberband);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_set_header_factory(GtkColumnViewHandle self, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_set_model(GtkColumnViewHandle self, GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_set_reorderable(GtkColumnViewHandle self, bool reorderable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_set_row_factory(GtkColumnViewHandle self, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_set_show_column_separators(GtkColumnViewHandle self, bool show_column_separators);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_set_show_row_separators(GtkColumnViewHandle self, bool show_row_separators);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_set_single_click_activate(GtkColumnViewHandle self, bool single_click_activate);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_set_tab_behavior(GtkColumnViewHandle self, GtkListTabBehavior tab_behavior);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_sort_by_column(GtkColumnViewHandle self, GtkColumnViewColumnHandle column, GtkSortType direction);

}
