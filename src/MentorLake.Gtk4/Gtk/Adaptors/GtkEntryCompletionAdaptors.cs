using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEntryCompletionAdaptors
{
	public static GtkWidgetHandle GetEntry(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_entry(completion);
	}

	public static GtkEntryCompletionHandle SetModel(this GtkEntryCompletionHandle completion, GtkTreeModelHandle model)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_model(completion, model);
		return completion;
	}

	public static GtkTreeModelHandle GetModel(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_model(completion);
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

	public static int GetMinimumKeyLength(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_minimum_key_length(completion);
	}

	public static string ComputePrefix(this GtkEntryCompletionHandle completion, string key)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_compute_prefix(completion, key);
	}

	public static GtkEntryCompletionHandle Complete(this GtkEntryCompletionHandle completion)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_complete(completion);
		return completion;
	}

	public static GtkEntryCompletionHandle InsertPrefix(this GtkEntryCompletionHandle completion)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_insert_prefix(completion);
		return completion;
	}

	public static GtkEntryCompletionHandle SetInlineCompletion(this GtkEntryCompletionHandle completion, int inline_completion)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_inline_completion(completion, inline_completion);
		return completion;
	}

	public static int GetInlineCompletion(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_inline_completion(completion);
	}

	public static GtkEntryCompletionHandle SetInlineSelection(this GtkEntryCompletionHandle completion, int inline_selection)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_inline_selection(completion, inline_selection);
		return completion;
	}

	public static int GetInlineSelection(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_inline_selection(completion);
	}

	public static GtkEntryCompletionHandle SetPopupCompletion(this GtkEntryCompletionHandle completion, int popup_completion)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_popup_completion(completion, popup_completion);
		return completion;
	}

	public static int GetPopupCompletion(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_popup_completion(completion);
	}

	public static GtkEntryCompletionHandle SetPopupSetWidth(this GtkEntryCompletionHandle completion, int popup_set_width)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_popup_set_width(completion, popup_set_width);
		return completion;
	}

	public static int GetPopupSetWidth(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_popup_set_width(completion);
	}

	public static GtkEntryCompletionHandle SetPopupSingleMatch(this GtkEntryCompletionHandle completion, int popup_single_match)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_popup_single_match(completion, popup_single_match);
		return completion;
	}

	public static int GetPopupSingleMatch(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_popup_single_match(completion);
	}

	public static string GetCompletionPrefix(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_completion_prefix(completion);
	}

	public static GtkEntryCompletionHandle SetTextColumn(this GtkEntryCompletionHandle completion, int column)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_text_column(completion, column);
		return completion;
	}

	public static int GetTextColumn(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_text_column(completion);
	}
}
