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

public class GtkEntryCompletionHandle : GObjectHandle
{
	public static GtkEntryCompletionHandle New()
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_new();
	}

	public static GtkEntryCompletionHandle NewWithArea(GtkCellAreaHandle area)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_new_with_area(area);
	}

}

public class GtkEntryCompletionSignal
{
	public string Value { get; set; }
	public GtkEntryCompletionSignal(string value) => Value = value;
}

public static class GtkEntryCompletionSignals
{
	public static GtkEntryCompletionSignal CursorOnMatch = new("cursor-on-match");
	public static GtkEntryCompletionSignal InsertPrefix = new("insert-prefix");
	public static GtkEntryCompletionSignal MatchSelected = new("match-selected");
	public static GtkEntryCompletionSignal NoMatches = new("no-matches");
}

public static class GtkEntryCompletionHandleExtensions
{
	public static GtkEntryCompletionHandle Complete(this GtkEntryCompletionHandle completion)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_complete(completion);
		return completion;
	}

	public static string ComputePrefix(this GtkEntryCompletionHandle completion, string key)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_compute_prefix(completion, key);
	}

	public static string GetCompletionPrefix(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_completion_prefix(completion);
	}

	public static GtkWidgetHandle GetEntry(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_entry(completion);
	}

	public static bool GetInlineCompletion(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_inline_completion(completion);
	}

	public static bool GetInlineSelection(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_inline_selection(completion);
	}

	public static int GetMinimumKeyLength(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_minimum_key_length(completion);
	}

	public static GtkTreeModelHandle GetModel(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_model(completion);
	}

	public static bool GetPopupCompletion(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_popup_completion(completion);
	}

	public static bool GetPopupSetWidth(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_popup_set_width(completion);
	}

	public static bool GetPopupSingleMatch(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_popup_single_match(completion);
	}

	public static int GetTextColumn(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_text_column(completion);
	}

	public static GtkEntryCompletionHandle InsertPrefix(this GtkEntryCompletionHandle completion)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_insert_prefix(completion);
		return completion;
	}

	public static GtkEntryCompletionHandle SetInlineCompletion(this GtkEntryCompletionHandle completion, bool inline_completion)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_inline_completion(completion, inline_completion);
		return completion;
	}

	public static GtkEntryCompletionHandle SetInlineSelection(this GtkEntryCompletionHandle completion, bool inline_selection)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_inline_selection(completion, inline_selection);
		return completion;
	}

	public static GtkEntryCompletionHandle SetMatchFunc(this GtkEntryCompletionHandle completion, GtkEntryCompletionMatchFunc func, IntPtr func_data, GDestroyNotify func_notify)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_match_func(completion, func, func_data, func_notify);
		return completion;
	}

	public static GtkEntryCompletionHandle SetMinimumKeyLength(this GtkEntryCompletionHandle completion, int length)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_minimum_key_length(completion, length);
		return completion;
	}

	public static GtkEntryCompletionHandle SetModel(this GtkEntryCompletionHandle completion, GtkTreeModelHandle model)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_model(completion, model);
		return completion;
	}

	public static GtkEntryCompletionHandle SetPopupCompletion(this GtkEntryCompletionHandle completion, bool popup_completion)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_popup_completion(completion, popup_completion);
		return completion;
	}

	public static GtkEntryCompletionHandle SetPopupSetWidth(this GtkEntryCompletionHandle completion, bool popup_set_width)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_popup_set_width(completion, popup_set_width);
		return completion;
	}

	public static GtkEntryCompletionHandle SetPopupSingleMatch(this GtkEntryCompletionHandle completion, bool popup_single_match)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_popup_single_match(completion, popup_single_match);
		return completion;
	}

	public static GtkEntryCompletionHandle SetTextColumn(this GtkEntryCompletionHandle completion, int column)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_text_column(completion, column);
		return completion;
	}

	public static GtkEntryCompletionHandle Connect(this GtkEntryCompletionHandle instance, GtkEntryCompletionSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkEntryCompletionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEntryCompletionHandle gtk_entry_completion_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEntryCompletionHandle gtk_entry_completion_new_with_area(GtkCellAreaHandle area);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_complete(GtkEntryCompletionHandle completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_entry_completion_compute_prefix(GtkEntryCompletionHandle completion, string key);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_entry_completion_get_completion_prefix(GtkEntryCompletionHandle completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_entry_completion_get_entry(GtkEntryCompletionHandle completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_completion_get_inline_completion(GtkEntryCompletionHandle completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_completion_get_inline_selection(GtkEntryCompletionHandle completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_entry_completion_get_minimum_key_length(GtkEntryCompletionHandle completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeModelHandle gtk_entry_completion_get_model(GtkEntryCompletionHandle completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_completion_get_popup_completion(GtkEntryCompletionHandle completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_completion_get_popup_set_width(GtkEntryCompletionHandle completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_completion_get_popup_single_match(GtkEntryCompletionHandle completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_entry_completion_get_text_column(GtkEntryCompletionHandle completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_insert_prefix(GtkEntryCompletionHandle completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_inline_completion(GtkEntryCompletionHandle completion, bool inline_completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_inline_selection(GtkEntryCompletionHandle completion, bool inline_selection);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_match_func(GtkEntryCompletionHandle completion, GtkEntryCompletionMatchFunc func, IntPtr func_data, GDestroyNotify func_notify);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_minimum_key_length(GtkEntryCompletionHandle completion, int length);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_model(GtkEntryCompletionHandle completion, GtkTreeModelHandle model);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_popup_completion(GtkEntryCompletionHandle completion, bool popup_completion);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_popup_set_width(GtkEntryCompletionHandle completion, bool popup_set_width);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_popup_single_match(GtkEntryCompletionHandle completion, bool popup_single_match);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_text_column(GtkEntryCompletionHandle completion, int column);
}
