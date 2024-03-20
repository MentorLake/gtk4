using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkComboBoxAdaptors
{
	public static int GetActive(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_active(combo_box);
	}

	public static GtkComboBoxHandle SetActive(this GtkComboBoxHandle combo_box, int index_)
	{
		GtkComboBoxExterns.gtk_combo_box_set_active(combo_box, index_);
		return combo_box;
	}

	public static int GetActiveIter(this GtkComboBoxHandle combo_box, GtkTreeIterHandle iter)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_active_iter(combo_box, iter);
	}

	public static GtkComboBoxHandle SetActiveIter(this GtkComboBoxHandle combo_box, GtkTreeIterHandle iter)
	{
		GtkComboBoxExterns.gtk_combo_box_set_active_iter(combo_box, iter);
		return combo_box;
	}

	public static GtkComboBoxHandle SetModel(this GtkComboBoxHandle combo_box, GtkTreeModelHandle model)
	{
		GtkComboBoxExterns.gtk_combo_box_set_model(combo_box, model);
		return combo_box;
	}

	public static GtkTreeModelHandle GetModel(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_model(combo_box);
	}

	public static GtkTreeViewRowSeparatorFunc GetRowSeparatorFunc(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_row_separator_func(combo_box);
	}

	public static GtkComboBoxHandle SetRowSeparatorFunc(this GtkComboBoxHandle combo_box, GtkTreeViewRowSeparatorFunc func, IntPtr data, GDestroyNotify destroy)
	{
		GtkComboBoxExterns.gtk_combo_box_set_row_separator_func(combo_box, func, data, destroy);
		return combo_box;
	}

	public static GtkComboBoxHandle SetButtonSensitivity(this GtkComboBoxHandle combo_box, GtkSensitivityType sensitivity)
	{
		GtkComboBoxExterns.gtk_combo_box_set_button_sensitivity(combo_box, sensitivity);
		return combo_box;
	}

	public static GtkSensitivityType GetButtonSensitivity(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_button_sensitivity(combo_box);
	}

	public static int GetHasEntry(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_has_entry(combo_box);
	}

	public static GtkComboBoxHandle SetEntryTextColumn(this GtkComboBoxHandle combo_box, int text_column)
	{
		GtkComboBoxExterns.gtk_combo_box_set_entry_text_column(combo_box, text_column);
		return combo_box;
	}

	public static int GetEntryTextColumn(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_entry_text_column(combo_box);
	}

	public static GtkComboBoxHandle SetPopupFixedWidth(this GtkComboBoxHandle combo_box, int @fixed)
	{
		GtkComboBoxExterns.gtk_combo_box_set_popup_fixed_width(combo_box, @fixed);
		return combo_box;
	}

	public static int GetPopupFixedWidth(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_popup_fixed_width(combo_box);
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

	public static GtkComboBoxHandle Popdown(this GtkComboBoxHandle combo_box)
	{
		GtkComboBoxExterns.gtk_combo_box_popdown(combo_box);
		return combo_box;
	}

	public static int GetIdColumn(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_id_column(combo_box);
	}

	public static GtkComboBoxHandle SetIdColumn(this GtkComboBoxHandle combo_box, int id_column)
	{
		GtkComboBoxExterns.gtk_combo_box_set_id_column(combo_box, id_column);
		return combo_box;
	}

	public static string GetActiveId(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_active_id(combo_box);
	}

	public static int SetActiveId(this GtkComboBoxHandle combo_box, string active_id)
	{
		return GtkComboBoxExterns.gtk_combo_box_set_active_id(combo_box, active_id);
	}

	public static GtkComboBoxHandle SetChild(this GtkComboBoxHandle combo_box, GtkWidgetHandle child)
	{
		GtkComboBoxExterns.gtk_combo_box_set_child(combo_box, child);
		return combo_box;
	}

	public static GtkWidgetHandle GetChild(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_child(combo_box);
	}

	public static GtkComboBoxHandle NewWithEntry()
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_entry();
	}
}
