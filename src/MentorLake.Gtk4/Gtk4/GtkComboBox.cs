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

public class GtkComboBoxHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle, GtkConstraintTargetHandle
{
	public static GtkComboBoxHandle New()
	{
		return GtkComboBoxExterns.gtk_combo_box_new();
	}

	public static GtkComboBoxHandle NewWithEntry()
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_entry();
	}

	public static GtkComboBoxHandle NewWithModel(GtkTreeModelHandle model)
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_model(model);
	}

	public static GtkComboBoxHandle NewWithModelAndEntry(GtkTreeModelHandle model)
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_model_and_entry(model);
	}

}

public class GtkComboBoxSignal
{
	public string Value { get; set; }
	public GtkComboBoxSignal(string value) => Value = value;
}

public static class GtkComboBoxSignals
{
	public static GtkComboBoxSignal Activate = new("activate");
	public static GtkComboBoxSignal Changed = new("changed");
	public static GtkComboBoxSignal FormatEntryText = new("format-entry-text");
	public static GtkComboBoxSignal MoveActive = new("move-active");
	public static GtkComboBoxSignal Popdown = new("popdown");
	public static GtkComboBoxSignal Popup = new("popup");
}

public static class GtkComboBoxHandleExtensions
{
	public static int GetActive(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_active(combo_box);
	}

	public static string GetActiveId(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_active_id(combo_box);
	}

	public static bool GetActiveIter(this GtkComboBoxHandle combo_box, out GtkTreeIter iter)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_active_iter(combo_box, out iter);
	}

	public static GtkSensitivityType GetButtonSensitivity(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_button_sensitivity(combo_box);
	}

	public static GtkWidgetHandle GetChild(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_child(combo_box);
	}

	public static int GetEntryTextColumn(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_entry_text_column(combo_box);
	}

	public static bool GetHasEntry(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_has_entry(combo_box);
	}

	public static int GetIdColumn(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_id_column(combo_box);
	}

	public static GtkTreeModelHandle GetModel(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_model(combo_box);
	}

	public static bool GetPopupFixedWidth(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_popup_fixed_width(combo_box);
	}

	public static GtkTreeViewRowSeparatorFunc GetRowSeparatorFunc(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_row_separator_func(combo_box);
	}

	public static GtkComboBoxHandle Popdown(this GtkComboBoxHandle combo_box)
	{
		GtkComboBoxExterns.gtk_combo_box_popdown(combo_box);
		return combo_box;
	}

	public static GtkComboBoxHandle Popup(this GtkComboBoxHandle combo_box)
	{
		GtkComboBoxExterns.gtk_combo_box_popup(combo_box);
		return combo_box;
	}

	public static GtkComboBoxHandle PopupForDevice(this GtkComboBoxHandle combo_box, GdkDeviceHandle device)
	{
		GtkComboBoxExterns.gtk_combo_box_popup_for_device(combo_box, device);
		return combo_box;
	}

	public static GtkComboBoxHandle SetActive(this GtkComboBoxHandle combo_box, int index_)
	{
		GtkComboBoxExterns.gtk_combo_box_set_active(combo_box, index_);
		return combo_box;
	}

	public static bool SetActiveId(this GtkComboBoxHandle combo_box, string active_id)
	{
		return GtkComboBoxExterns.gtk_combo_box_set_active_id(combo_box, active_id);
	}

	public static GtkComboBoxHandle SetActiveIter(this GtkComboBoxHandle combo_box, GtkTreeIterHandle iter)
	{
		GtkComboBoxExterns.gtk_combo_box_set_active_iter(combo_box, iter);
		return combo_box;
	}

	public static GtkComboBoxHandle SetButtonSensitivity(this GtkComboBoxHandle combo_box, GtkSensitivityType sensitivity)
	{
		GtkComboBoxExterns.gtk_combo_box_set_button_sensitivity(combo_box, sensitivity);
		return combo_box;
	}

	public static GtkComboBoxHandle SetChild(this GtkComboBoxHandle combo_box, GtkWidgetHandle child)
	{
		GtkComboBoxExterns.gtk_combo_box_set_child(combo_box, child);
		return combo_box;
	}

	public static GtkComboBoxHandle SetEntryTextColumn(this GtkComboBoxHandle combo_box, int text_column)
	{
		GtkComboBoxExterns.gtk_combo_box_set_entry_text_column(combo_box, text_column);
		return combo_box;
	}

	public static GtkComboBoxHandle SetIdColumn(this GtkComboBoxHandle combo_box, int id_column)
	{
		GtkComboBoxExterns.gtk_combo_box_set_id_column(combo_box, id_column);
		return combo_box;
	}

	public static GtkComboBoxHandle SetModel(this GtkComboBoxHandle combo_box, GtkTreeModelHandle model)
	{
		GtkComboBoxExterns.gtk_combo_box_set_model(combo_box, model);
		return combo_box;
	}

	public static GtkComboBoxHandle SetPopupFixedWidth(this GtkComboBoxHandle combo_box, bool @fixed)
	{
		GtkComboBoxExterns.gtk_combo_box_set_popup_fixed_width(combo_box, @fixed);
		return combo_box;
	}

	public static GtkComboBoxHandle SetRowSeparatorFunc(this GtkComboBoxHandle combo_box, GtkTreeViewRowSeparatorFunc func, IntPtr data, GDestroyNotify destroy)
	{
		GtkComboBoxExterns.gtk_combo_box_set_row_separator_func(combo_box, func, data, destroy);
		return combo_box;
	}

	public static GtkComboBoxHandle Connect(this GtkComboBoxHandle instance, GtkComboBoxSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkComboBoxExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_entry();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_model(GtkTreeModelHandle model);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_model_and_entry(GtkTreeModelHandle model);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_combo_box_get_active(GtkComboBoxHandle combo_box);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_combo_box_get_active_id(GtkComboBoxHandle combo_box);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_combo_box_get_active_iter(GtkComboBoxHandle combo_box, out GtkTreeIter iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSensitivityType gtk_combo_box_get_button_sensitivity(GtkComboBoxHandle combo_box);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_combo_box_get_child(GtkComboBoxHandle combo_box);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_combo_box_get_entry_text_column(GtkComboBoxHandle combo_box);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_combo_box_get_has_entry(GtkComboBoxHandle combo_box);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_combo_box_get_id_column(GtkComboBoxHandle combo_box);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeModelHandle gtk_combo_box_get_model(GtkComboBoxHandle combo_box);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_combo_box_get_popup_fixed_width(GtkComboBoxHandle combo_box);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeViewRowSeparatorFunc gtk_combo_box_get_row_separator_func(GtkComboBoxHandle combo_box);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_popdown(GtkComboBoxHandle combo_box);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_popup(GtkComboBoxHandle combo_box);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_popup_for_device(GtkComboBoxHandle combo_box, GdkDeviceHandle device);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_active(GtkComboBoxHandle combo_box, int index_);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_combo_box_set_active_id(GtkComboBoxHandle combo_box, string active_id);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_active_iter(GtkComboBoxHandle combo_box, GtkTreeIterHandle iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_button_sensitivity(GtkComboBoxHandle combo_box, GtkSensitivityType sensitivity);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_child(GtkComboBoxHandle combo_box, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_entry_text_column(GtkComboBoxHandle combo_box, int text_column);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_id_column(GtkComboBoxHandle combo_box, int id_column);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_model(GtkComboBoxHandle combo_box, GtkTreeModelHandle model);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_popup_fixed_width(GtkComboBoxHandle combo_box, bool @fixed);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_row_separator_func(GtkComboBoxHandle combo_box, GtkTreeViewRowSeparatorFunc func, IntPtr data, GDestroyNotify destroy);
}
