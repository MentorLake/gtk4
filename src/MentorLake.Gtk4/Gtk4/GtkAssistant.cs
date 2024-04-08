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

public class GtkAssistantHandle : GtkWindowHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
	public static GtkAssistantHandle New()
	{
		return GtkAssistantExterns.gtk_assistant_new();
	}

}

public class GtkAssistantSignal
{
	public string Value { get; set; }
	public GtkAssistantSignal(string value) => Value = value;
}

public static class GtkAssistantSignals
{
	public static GtkAssistantSignal Apply = new("apply");
	public static GtkAssistantSignal Cancel = new("cancel");
	public static GtkAssistantSignal Close = new("close");
	public static GtkAssistantSignal Escape = new("escape");
	public static GtkAssistantSignal Prepare = new("prepare");
}

public static class GtkAssistantHandleExtensions
{
	public static GtkAssistantHandle AddActionWidget(this GtkAssistantHandle assistant, GtkWidgetHandle child)
	{
		GtkAssistantExterns.gtk_assistant_add_action_widget(assistant, child);
		return assistant;
	}

	public static int AppendPage(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_append_page(assistant, page);
	}

	public static GtkAssistantHandle Commit(this GtkAssistantHandle assistant)
	{
		GtkAssistantExterns.gtk_assistant_commit(assistant);
		return assistant;
	}

	public static int GetCurrentPage(this GtkAssistantHandle assistant)
	{
		return GtkAssistantExterns.gtk_assistant_get_current_page(assistant);
	}

	public static int GetNPages(this GtkAssistantHandle assistant)
	{
		return GtkAssistantExterns.gtk_assistant_get_n_pages(assistant);
	}

	public static GtkWidgetHandle GetNthPage(this GtkAssistantHandle assistant, int page_num)
	{
		return GtkAssistantExterns.gtk_assistant_get_nth_page(assistant, page_num);
	}

	public static GtkAssistantPageHandle GetPage(this GtkAssistantHandle assistant, GtkWidgetHandle child)
	{
		return GtkAssistantExterns.gtk_assistant_get_page(assistant, child);
	}

	public static bool GetPageComplete(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_get_page_complete(assistant, page);
	}

	public static string GetPageTitle(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_get_page_title(assistant, page);
	}

	public static GtkAssistantPageType GetPageType(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_get_page_type(assistant, page);
	}

	public static GListModelHandle GetPages(this GtkAssistantHandle assistant)
	{
		return GtkAssistantExterns.gtk_assistant_get_pages(assistant);
	}

	public static int InsertPage(this GtkAssistantHandle assistant, GtkWidgetHandle page, int position)
	{
		return GtkAssistantExterns.gtk_assistant_insert_page(assistant, page, position);
	}

	public static GtkAssistantHandle NextPage(this GtkAssistantHandle assistant)
	{
		GtkAssistantExterns.gtk_assistant_next_page(assistant);
		return assistant;
	}

	public static int PrependPage(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_prepend_page(assistant, page);
	}

	public static GtkAssistantHandle PreviousPage(this GtkAssistantHandle assistant)
	{
		GtkAssistantExterns.gtk_assistant_previous_page(assistant);
		return assistant;
	}

	public static GtkAssistantHandle RemoveActionWidget(this GtkAssistantHandle assistant, GtkWidgetHandle child)
	{
		GtkAssistantExterns.gtk_assistant_remove_action_widget(assistant, child);
		return assistant;
	}

	public static GtkAssistantHandle RemovePage(this GtkAssistantHandle assistant, int page_num)
	{
		GtkAssistantExterns.gtk_assistant_remove_page(assistant, page_num);
		return assistant;
	}

	public static GtkAssistantHandle SetCurrentPage(this GtkAssistantHandle assistant, int page_num)
	{
		GtkAssistantExterns.gtk_assistant_set_current_page(assistant, page_num);
		return assistant;
	}

	public static GtkAssistantHandle SetForwardPageFunc(this GtkAssistantHandle assistant, GtkAssistantPageFunc page_func, IntPtr data, GDestroyNotify destroy)
	{
		GtkAssistantExterns.gtk_assistant_set_forward_page_func(assistant, page_func, data, destroy);
		return assistant;
	}

	public static GtkAssistantHandle SetPageComplete(this GtkAssistantHandle assistant, GtkWidgetHandle page, bool complete)
	{
		GtkAssistantExterns.gtk_assistant_set_page_complete(assistant, page, complete);
		return assistant;
	}

	public static GtkAssistantHandle SetPageTitle(this GtkAssistantHandle assistant, GtkWidgetHandle page, string title)
	{
		GtkAssistantExterns.gtk_assistant_set_page_title(assistant, page, title);
		return assistant;
	}

	public static GtkAssistantHandle SetPageType(this GtkAssistantHandle assistant, GtkWidgetHandle page, GtkAssistantPageType type)
	{
		GtkAssistantExterns.gtk_assistant_set_page_type(assistant, page, type);
		return assistant;
	}

	public static GtkAssistantHandle UpdateButtonsState(this GtkAssistantHandle assistant)
	{
		GtkAssistantExterns.gtk_assistant_update_buttons_state(assistant);
		return assistant;
	}

	public static GtkAssistantHandle Connect(this GtkAssistantHandle instance, GtkAssistantSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkAssistantExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAssistantHandle gtk_assistant_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_add_action_widget(GtkAssistantHandle assistant, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_assistant_append_page(GtkAssistantHandle assistant, GtkWidgetHandle page);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_commit(GtkAssistantHandle assistant);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_assistant_get_current_page(GtkAssistantHandle assistant);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_assistant_get_n_pages(GtkAssistantHandle assistant);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_assistant_get_nth_page(GtkAssistantHandle assistant, int page_num);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAssistantPageHandle gtk_assistant_get_page(GtkAssistantHandle assistant, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_assistant_get_page_complete(GtkAssistantHandle assistant, GtkWidgetHandle page);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_assistant_get_page_title(GtkAssistantHandle assistant, GtkWidgetHandle page);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAssistantPageType gtk_assistant_get_page_type(GtkAssistantHandle assistant, GtkWidgetHandle page);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_assistant_get_pages(GtkAssistantHandle assistant);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_assistant_insert_page(GtkAssistantHandle assistant, GtkWidgetHandle page, int position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_next_page(GtkAssistantHandle assistant);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_assistant_prepend_page(GtkAssistantHandle assistant, GtkWidgetHandle page);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_previous_page(GtkAssistantHandle assistant);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_remove_action_widget(GtkAssistantHandle assistant, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_remove_page(GtkAssistantHandle assistant, int page_num);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_set_current_page(GtkAssistantHandle assistant, int page_num);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_set_forward_page_func(GtkAssistantHandle assistant, GtkAssistantPageFunc page_func, IntPtr data, GDestroyNotify destroy);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_set_page_complete(GtkAssistantHandle assistant, GtkWidgetHandle page, bool complete);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_set_page_title(GtkAssistantHandle assistant, GtkWidgetHandle page, string title);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_set_page_type(GtkAssistantHandle assistant, GtkWidgetHandle page, GtkAssistantPageType type);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_update_buttons_state(GtkAssistantHandle assistant);
}
