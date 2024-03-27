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

public class GtkEditableHandle  : GtkWidgetHandle
{
}

public static class GtkEditableHandleExtensions
{
	public static bool DelegateGetAccessiblePlatformState(this GtkEditableHandle editable, GtkAccessiblePlatformState state)
	{
		return GtkEditableExterns.gtk_editable_delegate_get_accessible_platform_state(editable, state);
	}

	public static GtkEditableHandle DeleteSelection(this GtkEditableHandle editable)
	{
		GtkEditableExterns.gtk_editable_delete_selection(editable);
		return editable;
	}

	public static GtkEditableHandle DeleteText(this GtkEditableHandle editable, int start_pos, int end_pos)
	{
		GtkEditableExterns.gtk_editable_delete_text(editable, start_pos, end_pos);
		return editable;
	}

	public static GtkEditableHandle FinishDelegate(this GtkEditableHandle editable)
	{
		GtkEditableExterns.gtk_editable_finish_delegate(editable);
		return editable;
	}

	public static float GetAlignment(this GtkEditableHandle editable)
	{
		return GtkEditableExterns.gtk_editable_get_alignment(editable);
	}

	public static string GetChars(this GtkEditableHandle editable, int start_pos, int end_pos)
	{
		return GtkEditableExterns.gtk_editable_get_chars(editable, start_pos, end_pos);
	}

	public static GtkEditableHandle GetDelegate(this GtkEditableHandle editable)
	{
		return GtkEditableExterns.gtk_editable_get_delegate(editable);
	}

	public static bool GetEditable(this GtkEditableHandle editable)
	{
		return GtkEditableExterns.gtk_editable_get_editable(editable);
	}

	public static bool GetEnableUndo(this GtkEditableHandle editable)
	{
		return GtkEditableExterns.gtk_editable_get_enable_undo(editable);
	}

	public static int GetMaxWidthChars(this GtkEditableHandle editable)
	{
		return GtkEditableExterns.gtk_editable_get_max_width_chars(editable);
	}

	public static int GetPosition(this GtkEditableHandle editable)
	{
		return GtkEditableExterns.gtk_editable_get_position(editable);
	}

	public static bool GetSelectionBounds(this GtkEditableHandle editable, out int start_pos, out int end_pos)
	{
		return GtkEditableExterns.gtk_editable_get_selection_bounds(editable, out start_pos, out end_pos);
	}

	public static string GetText(this GtkEditableHandle editable)
	{
		return GtkEditableExterns.gtk_editable_get_text(editable);
	}

	public static int GetWidthChars(this GtkEditableHandle editable)
	{
		return GtkEditableExterns.gtk_editable_get_width_chars(editable);
	}

	public static GtkEditableHandle InitDelegate(this GtkEditableHandle editable)
	{
		GtkEditableExterns.gtk_editable_init_delegate(editable);
		return editable;
	}

	public static GtkEditableHandle InsertText(this GtkEditableHandle editable, string text, int length, ref int position)
	{
		GtkEditableExterns.gtk_editable_insert_text(editable, text, length, ref position);
		return editable;
	}

	public static GtkEditableHandle SelectRegion(this GtkEditableHandle editable, int start_pos, int end_pos)
	{
		GtkEditableExterns.gtk_editable_select_region(editable, start_pos, end_pos);
		return editable;
	}

	public static GtkEditableHandle SetAlignment(this GtkEditableHandle editable, float xalign)
	{
		GtkEditableExterns.gtk_editable_set_alignment(editable, xalign);
		return editable;
	}

	public static GtkEditableHandle SetEditable(this GtkEditableHandle editable, bool is_editable)
	{
		GtkEditableExterns.gtk_editable_set_editable(editable, is_editable);
		return editable;
	}

	public static GtkEditableHandle SetEnableUndo(this GtkEditableHandle editable, bool enable_undo)
	{
		GtkEditableExterns.gtk_editable_set_enable_undo(editable, enable_undo);
		return editable;
	}

	public static GtkEditableHandle SetMaxWidthChars(this GtkEditableHandle editable, int n_chars)
	{
		GtkEditableExterns.gtk_editable_set_max_width_chars(editable, n_chars);
		return editable;
	}

	public static GtkEditableHandle SetPosition(this GtkEditableHandle editable, int position)
	{
		GtkEditableExterns.gtk_editable_set_position(editable, position);
		return editable;
	}

	public static GtkEditableHandle SetText(this GtkEditableHandle editable, string text)
	{
		GtkEditableExterns.gtk_editable_set_text(editable, text);
		return editable;
	}

	public static GtkEditableHandle SetWidthChars(this GtkEditableHandle editable, int n_chars)
	{
		GtkEditableExterns.gtk_editable_set_width_chars(editable, n_chars);
		return editable;
	}

}

internal class GtkEditableExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_editable_delegate_get_accessible_platform_state(GtkEditableHandle editable, GtkAccessiblePlatformState state);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_delete_selection(GtkEditableHandle editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_delete_text(GtkEditableHandle editable, int start_pos, int end_pos);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_finish_delegate(GtkEditableHandle editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern float gtk_editable_get_alignment(GtkEditableHandle editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_editable_get_chars(GtkEditableHandle editable, int start_pos, int end_pos);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEditableHandle gtk_editable_get_delegate(GtkEditableHandle editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_editable_get_editable(GtkEditableHandle editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_editable_get_enable_undo(GtkEditableHandle editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_editable_get_max_width_chars(GtkEditableHandle editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_editable_get_position(GtkEditableHandle editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_editable_get_selection_bounds(GtkEditableHandle editable, out int start_pos, out int end_pos);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_editable_get_text(GtkEditableHandle editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_editable_get_width_chars(GtkEditableHandle editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_init_delegate(GtkEditableHandle editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_insert_text(GtkEditableHandle editable, string text, int length, ref int position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_select_region(GtkEditableHandle editable, int start_pos, int end_pos);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_set_alignment(GtkEditableHandle editable, float xalign);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_set_editable(GtkEditableHandle editable, bool is_editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_set_enable_undo(GtkEditableHandle editable, bool enable_undo);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_set_max_width_chars(GtkEditableHandle editable, int n_chars);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_set_position(GtkEditableHandle editable, int position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_set_text(GtkEditableHandle editable, string text);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_set_width_chars(GtkEditableHandle editable, int n_chars);
}
