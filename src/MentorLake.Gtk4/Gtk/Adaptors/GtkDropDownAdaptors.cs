using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDropDownAdaptors
{
	public static GtkDropDownHandle SetModel(this GtkDropDownHandle self, GListModelHandle model)
	{
		GtkDropDownExterns.gtk_drop_down_set_model(self, model);
		return self;
	}

	public static GListModelHandle GetModel(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_model(self);
	}

	public static GtkDropDownHandle SetSelected(this GtkDropDownHandle self, uint position)
	{
		GtkDropDownExterns.gtk_drop_down_set_selected(self, position);
		return self;
	}

	public static uint GetSelected(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_selected(self);
	}

	public static IntPtr GetSelectedItem(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_selected_item(self);
	}

	public static GtkDropDownHandle SetFactory(this GtkDropDownHandle self, GtkListItemFactoryHandle factory)
	{
		GtkDropDownExterns.gtk_drop_down_set_factory(self, factory);
		return self;
	}

	public static GtkListItemFactoryHandle GetFactory(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_factory(self);
	}

	public static GtkDropDownHandle SetListFactory(this GtkDropDownHandle self, GtkListItemFactoryHandle factory)
	{
		GtkDropDownExterns.gtk_drop_down_set_list_factory(self, factory);
		return self;
	}

	public static GtkListItemFactoryHandle GetListFactory(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_list_factory(self);
	}

	public static GtkDropDownHandle SetExpression(this GtkDropDownHandle self, GtkExpressionHandle expression)
	{
		GtkDropDownExterns.gtk_drop_down_set_expression(self, expression);
		return self;
	}

	public static GtkExpressionHandle GetExpression(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_expression(self);
	}

	public static GtkDropDownHandle SetEnableSearch(this GtkDropDownHandle self, int enable_search)
	{
		GtkDropDownExterns.gtk_drop_down_set_enable_search(self, enable_search);
		return self;
	}

	public static int GetEnableSearch(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_enable_search(self);
	}

	public static GtkDropDownHandle SetShowArrow(this GtkDropDownHandle self, int show_arrow)
	{
		GtkDropDownExterns.gtk_drop_down_set_show_arrow(self, show_arrow);
		return self;
	}

	public static int GetShowArrow(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_show_arrow(self);
	}

	public static GtkDropDownHandle NewFromStrings(string strings)
	{
		return GtkDropDownExterns.gtk_drop_down_new_from_strings(strings);
	}
}
