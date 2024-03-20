using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAssistantAdaptors
{
	public static GtkAssistantHandle NextPage(this GtkAssistantHandle assistant)
	{
		GtkAssistantExterns.gtk_assistant_next_page(assistant);
		return assistant;
	}

	public static GtkAssistantHandle PreviousPage(this GtkAssistantHandle assistant)
	{
		GtkAssistantExterns.gtk_assistant_previous_page(assistant);
		return assistant;
	}

	public static int GetCurrentPage(this GtkAssistantHandle assistant)
	{
		return GtkAssistantExterns.gtk_assistant_get_current_page(assistant);
	}

	public static GtkAssistantHandle SetCurrentPage(this GtkAssistantHandle assistant, int page_num)
	{
		GtkAssistantExterns.gtk_assistant_set_current_page(assistant, page_num);
		return assistant;
	}

	public static int GetNPages(this GtkAssistantHandle assistant)
	{
		return GtkAssistantExterns.gtk_assistant_get_n_pages(assistant);
	}

	public static GtkWidgetHandle GetNthPage(this GtkAssistantHandle assistant, int page_num)
	{
		return GtkAssistantExterns.gtk_assistant_get_nth_page(assistant, page_num);
	}

	public static int PrependPage(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_prepend_page(assistant, page);
	}

	public static int AppendPage(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_append_page(assistant, page);
	}

	public static int InsertPage(this GtkAssistantHandle assistant, GtkWidgetHandle page, int position)
	{
		return GtkAssistantExterns.gtk_assistant_insert_page(assistant, page, position);
	}

	public static GtkAssistantHandle RemovePage(this GtkAssistantHandle assistant, int page_num)
	{
		GtkAssistantExterns.gtk_assistant_remove_page(assistant, page_num);
		return assistant;
	}

	public static GtkAssistantHandle SetForwardPageFunc(this GtkAssistantHandle assistant, GtkAssistantPageFunc page_func, IntPtr data, GDestroyNotify destroy)
	{
		GtkAssistantExterns.gtk_assistant_set_forward_page_func(assistant, page_func, data, destroy);
		return assistant;
	}

	public static GtkAssistantHandle SetPageType(this GtkAssistantHandle assistant, GtkWidgetHandle page, GtkAssistantPageType type)
	{
		GtkAssistantExterns.gtk_assistant_set_page_type(assistant, page, type);
		return assistant;
	}

	public static GtkAssistantPageType GetPageType(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_get_page_type(assistant, page);
	}

	public static GtkAssistantHandle SetPageTitle(this GtkAssistantHandle assistant, GtkWidgetHandle page, string title)
	{
		GtkAssistantExterns.gtk_assistant_set_page_title(assistant, page, title);
		return assistant;
	}

	public static string GetPageTitle(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_get_page_title(assistant, page);
	}

	public static GtkAssistantHandle SetPageComplete(this GtkAssistantHandle assistant, GtkWidgetHandle page, int complete)
	{
		GtkAssistantExterns.gtk_assistant_set_page_complete(assistant, page, complete);
		return assistant;
	}

	public static int GetPageComplete(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_get_page_complete(assistant, page);
	}

	public static GtkAssistantHandle AddActionWidget(this GtkAssistantHandle assistant, GtkWidgetHandle child)
	{
		GtkAssistantExterns.gtk_assistant_add_action_widget(assistant, child);
		return assistant;
	}

	public static GtkAssistantHandle RemoveActionWidget(this GtkAssistantHandle assistant, GtkWidgetHandle child)
	{
		GtkAssistantExterns.gtk_assistant_remove_action_widget(assistant, child);
		return assistant;
	}

	public static GtkAssistantHandle UpdateButtonsState(this GtkAssistantHandle assistant)
	{
		GtkAssistantExterns.gtk_assistant_update_buttons_state(assistant);
		return assistant;
	}

	public static GtkAssistantHandle Commit(this GtkAssistantHandle assistant)
	{
		GtkAssistantExterns.gtk_assistant_commit(assistant);
		return assistant;
	}

	public static GtkAssistantPageHandle GetPage(this GtkAssistantHandle assistant, GtkWidgetHandle child)
	{
		return GtkAssistantExterns.gtk_assistant_get_page(assistant, child);
	}

	public static GListModelHandle GetPages(this GtkAssistantHandle assistant)
	{
		return GtkAssistantExterns.gtk_assistant_get_pages(assistant);
	}
}
