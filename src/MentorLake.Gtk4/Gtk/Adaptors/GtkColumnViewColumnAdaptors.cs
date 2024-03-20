using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkColumnViewColumnAdaptors
{
	public static GtkColumnViewHandle GetColumnView(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_column_view(self);
	}

	public static GtkColumnViewColumnHandle SetFactory(this GtkColumnViewColumnHandle self, GtkListItemFactoryHandle factory)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_factory(self, factory);
		return self;
	}

	public static GtkListItemFactoryHandle GetFactory(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_factory(self);
	}

	public static GtkColumnViewColumnHandle SetTitle(this GtkColumnViewColumnHandle self, string title)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_title(self, title);
		return self;
	}

	public static string GetTitle(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_title(self);
	}

	public static GtkColumnViewColumnHandle SetSorter(this GtkColumnViewColumnHandle self, GtkSorterHandle sorter)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_sorter(self, sorter);
		return self;
	}

	public static GtkSorterHandle GetSorter(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_sorter(self);
	}

	public static GtkColumnViewColumnHandle SetVisible(this GtkColumnViewColumnHandle self, int visible)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_visible(self, visible);
		return self;
	}

	public static int GetVisible(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_visible(self);
	}

	public static GtkColumnViewColumnHandle SetHeaderMenu(this GtkColumnViewColumnHandle self, GMenuModelHandle menu)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_header_menu(self, menu);
		return self;
	}

	public static GMenuModelHandle GetHeaderMenu(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_header_menu(self);
	}

	public static GtkColumnViewColumnHandle SetFixedWidth(this GtkColumnViewColumnHandle self, int fixed_width)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_fixed_width(self, fixed_width);
		return self;
	}

	public static int GetFixedWidth(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_fixed_width(self);
	}

	public static GtkColumnViewColumnHandle SetResizable(this GtkColumnViewColumnHandle self, int resizable)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_resizable(self, resizable);
		return self;
	}

	public static int GetResizable(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_resizable(self);
	}

	public static GtkColumnViewColumnHandle SetExpand(this GtkColumnViewColumnHandle self, int expand)
	{
		GtkColumnViewColumnExterns.gtk_column_view_column_set_expand(self, expand);
		return self;
	}

	public static int GetExpand(this GtkColumnViewColumnHandle self)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_get_expand(self);
	}
}
