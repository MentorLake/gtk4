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

public class GtkDropDownHandle : GtkWidgetHandle
{
	public static GtkDropDownHandle New(GListModelHandle model, GtkExpressionHandle expression)
	{
		return GtkDropDownExterns.gtk_drop_down_new(model, expression);
	}
	public static GtkDropDownHandle NewFromStrings(string strings)
	{
		return GtkDropDownExterns.gtk_drop_down_new_from_strings(strings);
	}
}

public class GtkDropDownSignal
{
	public string Value { get; set; }
	public GtkDropDownSignal(string value) => Value = value;
}

public static class GtkDropDownSignals
{
	public static GtkDropDownSignal Activate = new("activate");
}

public static class GtkDropDownHandleExtensions
{
	public static bool GetEnableSearch(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_enable_search(self);
	}

	public static GtkExpressionHandle GetExpression(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_expression(self);
	}

	public static GtkListItemFactoryHandle GetFactory(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_factory(self);
	}

	public static GtkListItemFactoryHandle GetHeaderFactory(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_header_factory(self);
	}

	public static GtkListItemFactoryHandle GetListFactory(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_list_factory(self);
	}

	public static GListModelHandle GetModel(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_model(self);
	}

	public static GtkStringFilterMatchMode GetSearchMatchMode(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_search_match_mode(self);
	}

	public static uint GetSelected(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_selected(self);
	}

	public static GObjectHandle GetSelectedItem(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_selected_item(self);
	}

	public static bool GetShowArrow(this GtkDropDownHandle self)
	{
		return GtkDropDownExterns.gtk_drop_down_get_show_arrow(self);
	}

	public static GtkDropDownHandle SetEnableSearch(this GtkDropDownHandle self, bool enable_search)
	{
		GtkDropDownExterns.gtk_drop_down_set_enable_search(self, enable_search);
		return self;
	}

	public static GtkDropDownHandle SetExpression(this GtkDropDownHandle self, GtkExpressionHandle expression)
	{
		GtkDropDownExterns.gtk_drop_down_set_expression(self, expression);
		return self;
	}

	public static GtkDropDownHandle SetFactory(this GtkDropDownHandle self, GtkListItemFactoryHandle factory)
	{
		GtkDropDownExterns.gtk_drop_down_set_factory(self, factory);
		return self;
	}

	public static GtkDropDownHandle SetHeaderFactory(this GtkDropDownHandle self, GtkListItemFactoryHandle factory)
	{
		GtkDropDownExterns.gtk_drop_down_set_header_factory(self, factory);
		return self;
	}

	public static GtkDropDownHandle SetListFactory(this GtkDropDownHandle self, GtkListItemFactoryHandle factory)
	{
		GtkDropDownExterns.gtk_drop_down_set_list_factory(self, factory);
		return self;
	}

	public static GtkDropDownHandle SetModel(this GtkDropDownHandle self, GListModelHandle model)
	{
		GtkDropDownExterns.gtk_drop_down_set_model(self, model);
		return self;
	}

	public static GtkDropDownHandle SetSearchMatchMode(this GtkDropDownHandle self, GtkStringFilterMatchMode search_match_mode)
	{
		GtkDropDownExterns.gtk_drop_down_set_search_match_mode(self, search_match_mode);
		return self;
	}

	public static GtkDropDownHandle SetSelected(this GtkDropDownHandle self, uint position)
	{
		GtkDropDownExterns.gtk_drop_down_set_selected(self, position);
		return self;
	}

	public static GtkDropDownHandle SetShowArrow(this GtkDropDownHandle self, bool show_arrow)
	{
		GtkDropDownExterns.gtk_drop_down_set_show_arrow(self, show_arrow);
		return self;
	}

	public static GtkDropDownHandle Connect(this GtkDropDownHandle instance, GtkDropDownSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkDropDownExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_drop_down_get_enable_search(GtkDropDownHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpressionHandle gtk_drop_down_get_expression(GtkDropDownHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListItemFactoryHandle gtk_drop_down_get_factory(GtkDropDownHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListItemFactoryHandle gtk_drop_down_get_header_factory(GtkDropDownHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListItemFactoryHandle gtk_drop_down_get_list_factory(GtkDropDownHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_drop_down_get_model(GtkDropDownHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStringFilterMatchMode gtk_drop_down_get_search_match_mode(GtkDropDownHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_drop_down_get_selected(GtkDropDownHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_drop_down_get_selected_item(GtkDropDownHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_drop_down_get_show_arrow(GtkDropDownHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_down_set_enable_search(GtkDropDownHandle self, bool enable_search);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_down_set_expression(GtkDropDownHandle self, GtkExpressionHandle expression);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_down_set_factory(GtkDropDownHandle self, GtkListItemFactoryHandle factory);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_down_set_header_factory(GtkDropDownHandle self, GtkListItemFactoryHandle factory);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_down_set_list_factory(GtkDropDownHandle self, GtkListItemFactoryHandle factory);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_down_set_model(GtkDropDownHandle self, GListModelHandle model);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_down_set_search_match_mode(GtkDropDownHandle self, GtkStringFilterMatchMode search_match_mode);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_down_set_selected(GtkDropDownHandle self, uint position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_down_set_show_arrow(GtkDropDownHandle self, bool show_arrow);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDropDownHandle gtk_drop_down_new(GListModelHandle model, GtkExpressionHandle expression);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDropDownHandle gtk_drop_down_new_from_strings(string strings);
}