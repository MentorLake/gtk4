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

namespace MentorLake.Gtk4.Gio;

public class GMenuModelHandle : GObjectHandle
{
}

public class GMenuModelSignal
{
	public string Value { get; set; }
	public GMenuModelSignal(string value) => Value = value;
}

public static class GMenuModelSignals
{
	public static GMenuModelSignal ItemsChanged = new("items-changed");
}

public static class GMenuModelHandleExtensions
{
	public static bool GetItemAttribute(this GMenuModelHandle model, int item_index, string attribute, string format_string, IntPtr @__arglist)
	{
		return GMenuModelExterns.g_menu_model_get_item_attribute(model, item_index, attribute, format_string, @__arglist);
	}

	public static GVariantHandle GetItemAttributeValue(this GMenuModelHandle model, int item_index, string attribute, GVariantTypeHandle expected_type)
	{
		return GMenuModelExterns.g_menu_model_get_item_attribute_value(model, item_index, attribute, expected_type);
	}

	public static GMenuModelHandle GetItemLink(this GMenuModelHandle model, int item_index, string link)
	{
		return GMenuModelExterns.g_menu_model_get_item_link(model, item_index, link);
	}

	public static int GetNItems(this GMenuModelHandle model)
	{
		return GMenuModelExterns.g_menu_model_get_n_items(model);
	}

	public static bool IsMutable(this GMenuModelHandle model)
	{
		return GMenuModelExterns.g_menu_model_is_mutable(model);
	}

	public static GMenuModelHandle ItemsChanged(this GMenuModelHandle model, int position, int removed, int added)
	{
		GMenuModelExterns.g_menu_model_items_changed(model, position, removed, added);
		return model;
	}

	public static GMenuAttributeIterHandle IterateItemAttributes(this GMenuModelHandle model, int item_index)
	{
		return GMenuModelExterns.g_menu_model_iterate_item_attributes(model, item_index);
	}

	public static GMenuLinkIterHandle IterateItemLinks(this GMenuModelHandle model, int item_index)
	{
		return GMenuModelExterns.g_menu_model_iterate_item_links(model, item_index);
	}

	public static GMenuModelHandle Connect(this GMenuModelHandle instance, GMenuModelSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GMenuModelExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_menu_model_get_item_attribute(GMenuModelHandle model, int item_index, string attribute, string format_string, IntPtr @__arglist);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_menu_model_get_item_attribute_value(GMenuModelHandle model, int item_index, string attribute, GVariantTypeHandle expected_type);
	[DllImport(Libraries.Gio)]
	internal static extern GMenuModelHandle g_menu_model_get_item_link(GMenuModelHandle model, int item_index, string link);
	[DllImport(Libraries.Gio)]
	internal static extern int g_menu_model_get_n_items(GMenuModelHandle model);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_menu_model_is_mutable(GMenuModelHandle model);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_model_items_changed(GMenuModelHandle model, int position, int removed, int added);
	[DllImport(Libraries.Gio)]
	internal static extern GMenuAttributeIterHandle g_menu_model_iterate_item_attributes(GMenuModelHandle model, int item_index);
	[DllImport(Libraries.Gio)]
	internal static extern GMenuLinkIterHandle g_menu_model_iterate_item_links(GMenuModelHandle model, int item_index);
}
