namespace MentorLake.Gtk4.Gtk4;

public class GtkComboBoxTextHandle : GtkComboBoxHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle, GtkConstraintTargetHandle
{
	public static GtkComboBoxTextHandle New()
	{
		return GtkComboBoxTextExterns.gtk_combo_box_text_new();
	}

	public static GtkComboBoxTextHandle NewWithEntry()
	{
		return GtkComboBoxTextExterns.gtk_combo_box_text_new_with_entry();
	}

}

public static class GtkComboBoxTextHandleExtensions
{
	public static GtkComboBoxTextHandle Append(this GtkComboBoxTextHandle combo_box, string id, string text)
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_append(combo_box, id, text);
		return combo_box;
	}

	public static GtkComboBoxTextHandle AppendText(this GtkComboBoxTextHandle combo_box, string text)
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_append_text(combo_box, text);
		return combo_box;
	}

	public static string GetActiveText(this GtkComboBoxTextHandle combo_box)
	{
		return GtkComboBoxTextExterns.gtk_combo_box_text_get_active_text(combo_box);
	}

	public static GtkComboBoxTextHandle Insert(this GtkComboBoxTextHandle combo_box, int position, string id, string text)
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_insert(combo_box, position, id, text);
		return combo_box;
	}

	public static GtkComboBoxTextHandle InsertText(this GtkComboBoxTextHandle combo_box, int position, string text)
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_insert_text(combo_box, position, text);
		return combo_box;
	}

	public static GtkComboBoxTextHandle Prepend(this GtkComboBoxTextHandle combo_box, string id, string text)
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_prepend(combo_box, id, text);
		return combo_box;
	}

	public static GtkComboBoxTextHandle PrependText(this GtkComboBoxTextHandle combo_box, string text)
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_prepend_text(combo_box, text);
		return combo_box;
	}

	public static GtkComboBoxTextHandle Remove(this GtkComboBoxTextHandle combo_box, int position)
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_remove(combo_box, position);
		return combo_box;
	}

	public static GtkComboBoxTextHandle RemoveAll(this GtkComboBoxTextHandle combo_box)
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_remove_all(combo_box);
		return combo_box;
	}

}

internal class GtkComboBoxTextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkComboBoxTextHandle gtk_combo_box_text_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkComboBoxTextHandle gtk_combo_box_text_new_with_entry();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_text_append(GtkComboBoxTextHandle combo_box, string id, string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_text_append_text(GtkComboBoxTextHandle combo_box, string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_combo_box_text_get_active_text(GtkComboBoxTextHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_text_insert(GtkComboBoxTextHandle combo_box, int position, string id, string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_text_insert_text(GtkComboBoxTextHandle combo_box, int position, string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_text_prepend(GtkComboBoxTextHandle combo_box, string id, string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_text_prepend_text(GtkComboBoxTextHandle combo_box, string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_text_remove(GtkComboBoxTextHandle combo_box, int position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_text_remove_all(GtkComboBoxTextHandle combo_box);

}
