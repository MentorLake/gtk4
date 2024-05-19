using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkColumnViewColumnHandle : GObjectHandle
{
	public static GtkColumnViewColumnHandle New(string title, GtkListItemFactoryHandle factory)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_new(title, factory);
	}

}

public static class GtkColumnViewColumnHandleExtensions
{
	public static GtkColumnViewHandle GetColumnView(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_column_view(self);
	}

	public static bool GetExpand(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_expand(self);
	}

	public static GtkListItemFactoryHandle GetFactory(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_factory(self);
	}

	public static int GetFixedWidth(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_fixed_width(self);
	}

	public static GMenuModelHandle GetHeaderMenu(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_header_menu(self);
	}

	public static string GetId(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_id(self);
	}

	public static bool GetResizable(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_resizable(self);
	}

	public static GtkSorterHandle GetSorter(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_sorter(self);
	}

	public static string GetTitle(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_title(self);
	}

	public static bool GetVisible(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_visible(self);
	}

	public static GtkColumnViewColumnHandle SetExpand(this GtkColumnViewColumnHandle self, bool expand)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_expand(self, expand);
		return self;
	}

	public static GtkColumnViewColumnHandle SetFactory(this GtkColumnViewColumnHandle self, GtkListItemFactoryHandle factory)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_factory(self, factory);
		return self;
	}

	public static GtkColumnViewColumnHandle SetFixedWidth(this GtkColumnViewColumnHandle self, int fixed_width)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_fixed_width(self, fixed_width);
		return self;
	}

	public static GtkColumnViewColumnHandle SetHeaderMenu(this GtkColumnViewColumnHandle self, GMenuModelHandle menu)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_header_menu(self, menu);
		return self;
	}

	public static GtkColumnViewColumnHandle SetId(this GtkColumnViewColumnHandle self, string id)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_id(self, id);
		return self;
	}

	public static GtkColumnViewColumnHandle SetResizable(this GtkColumnViewColumnHandle self, bool resizable)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_resizable(self, resizable);
		return self;
	}

	public static GtkColumnViewColumnHandle SetSorter(this GtkColumnViewColumnHandle self, GtkSorterHandle sorter)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_sorter(self, sorter);
		return self;
	}

	public static GtkColumnViewColumnHandle SetTitle(this GtkColumnViewColumnHandle self, string title)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_title(self, title);
		return self;
	}

	public static GtkColumnViewColumnHandle SetVisible(this GtkColumnViewColumnHandle self, bool visible)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_visible(self, visible);
		return self;
	}

}

internal class GtkColumnViewColumnExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColumnViewColumnHandle gtk_column_view_column_new(string title, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColumnViewHandle gtk_column_view_column_get_column_view(GtkColumnViewColumnHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_column_get_expand(GtkColumnViewColumnHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListItemFactoryHandle gtk_column_view_column_get_factory(GtkColumnViewColumnHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_column_view_column_get_fixed_width(GtkColumnViewColumnHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuModelHandle gtk_column_view_column_get_header_menu(GtkColumnViewColumnHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_column_view_column_get_id(GtkColumnViewColumnHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_column_get_resizable(GtkColumnViewColumnHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSorterHandle gtk_column_view_column_get_sorter(GtkColumnViewColumnHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_column_view_column_get_title(GtkColumnViewColumnHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_column_get_visible(GtkColumnViewColumnHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_column_set_expand(GtkColumnViewColumnHandle self, bool expand);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_column_set_factory(GtkColumnViewColumnHandle self, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_column_set_fixed_width(GtkColumnViewColumnHandle self, int fixed_width);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_column_set_header_menu(GtkColumnViewColumnHandle self, GMenuModelHandle menu);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_column_set_id(GtkColumnViewColumnHandle self, string id);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_column_set_resizable(GtkColumnViewColumnHandle self, bool resizable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_column_set_sorter(GtkColumnViewColumnHandle self, GtkSorterHandle sorter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_column_set_title(GtkColumnViewColumnHandle self, string title);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_column_set_visible(GtkColumnViewColumnHandle self, bool visible);

}
