using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEditableAdaptors
{
    public static string GetText(this GtkEditableHandle editable)
    {
        return GtkEditableExterns.gtk_editable_get_text(editable);
    }

    public static GtkEditableHandle SetText(this GtkEditableHandle editable, string text)
    {
        GtkEditableExterns.gtk_editable_set_text(editable, text);
        return editable;
    }

    public static string GetChars(this GtkEditableHandle editable, int start_pos, int end_pos)
    {
        return GtkEditableExterns.gtk_editable_get_chars(editable, start_pos, end_pos);
    }

    public static GtkEditableHandle InsertText(this GtkEditableHandle editable, string text, int length, ref int position)
    {
        GtkEditableExterns.gtk_editable_insert_text(editable, text, length, ref position);
        return editable;
    }

    public static GtkEditableHandle DeleteText(this GtkEditableHandle editable, int start_pos, int end_pos)
    {
        GtkEditableExterns.gtk_editable_delete_text(editable, start_pos, end_pos);
        return editable;
    }

    public static int GetSelectionBounds(this GtkEditableHandle editable, out int start_pos, out int end_pos)
    {
        return GtkEditableExterns.gtk_editable_get_selection_bounds(editable, out start_pos, out end_pos);
    }

    public static GtkEditableHandle DeleteSelection(this GtkEditableHandle editable)
    {
        GtkEditableExterns.gtk_editable_delete_selection(editable);
        return editable;
    }

    public static GtkEditableHandle SelectRegion(this GtkEditableHandle editable, int start_pos, int end_pos)
    {
        GtkEditableExterns.gtk_editable_select_region(editable, start_pos, end_pos);
        return editable;
    }

    public static GtkEditableHandle SetPosition(this GtkEditableHandle editable, int position)
    {
        GtkEditableExterns.gtk_editable_set_position(editable, position);
        return editable;
    }

    public static int GetPosition(this GtkEditableHandle editable)
    {
        return GtkEditableExterns.gtk_editable_get_position(editable);
    }

    public static int GetEditable(this GtkEditableHandle editable)
    {
        return GtkEditableExterns.gtk_editable_get_editable(editable);
    }

    public static GtkEditableHandle SetEditable(this GtkEditableHandle editable, int is_editable)
    {
        GtkEditableExterns.gtk_editable_set_editable(editable, is_editable);
        return editable;
    }

    public static float GetAlignment(this GtkEditableHandle editable)
    {
        return GtkEditableExterns.gtk_editable_get_alignment(editable);
    }

    public static GtkEditableHandle SetAlignment(this GtkEditableHandle editable, float xalign)
    {
        GtkEditableExterns.gtk_editable_set_alignment(editable, xalign);
        return editable;
    }

    public static int GetWidthChars(this GtkEditableHandle editable)
    {
        return GtkEditableExterns.gtk_editable_get_width_chars(editable);
    }

    public static GtkEditableHandle SetWidthChars(this GtkEditableHandle editable, int n_chars)
    {
        GtkEditableExterns.gtk_editable_set_width_chars(editable, n_chars);
        return editable;
    }

    public static int GetMaxWidthChars(this GtkEditableHandle editable)
    {
        return GtkEditableExterns.gtk_editable_get_max_width_chars(editable);
    }

    public static GtkEditableHandle SetMaxWidthChars(this GtkEditableHandle editable, int n_chars)
    {
        GtkEditableExterns.gtk_editable_set_max_width_chars(editable, n_chars);
        return editable;
    }

    public static int GetEnableUndo(this GtkEditableHandle editable)
    {
        return GtkEditableExterns.gtk_editable_get_enable_undo(editable);
    }

    public static GtkEditableHandle SetEnableUndo(this GtkEditableHandle editable, int enable_undo)
    {
        GtkEditableExterns.gtk_editable_set_enable_undo(editable, enable_undo);
        return editable;
    }

    public static GtkEditableHandle GetDelegate(this GtkEditableHandle editable)
    {
        return GtkEditableExterns.gtk_editable_get_delegate(editable);
    }

    public static GtkEditableHandle InitDelegate(this GtkEditableHandle editable)
    {
        GtkEditableExterns.gtk_editable_init_delegate(editable);
        return editable;
    }

    public static GtkEditableHandle FinishDelegate(this GtkEditableHandle editable)
    {
        GtkEditableExterns.gtk_editable_finish_delegate(editable);
        return editable;
    }
}
