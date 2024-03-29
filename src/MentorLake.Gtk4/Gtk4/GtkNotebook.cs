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

public class GtkNotebookHandle : GtkWidgetHandle
{
	public static GtkNotebookHandle New()
	{
		return GtkNotebookExterns.gtk_notebook_new();
	}

}

public class GtkNotebookSignal
{
	public string Value { get; set; }
	public GtkNotebookSignal(string value) => Value = value;
}

public static class GtkNotebookSignals
{
	public static GtkNotebookSignal ChangeCurrentPage = new("change-current-page");
	public static GtkNotebookSignal CreateWindow = new("create-window");
	public static GtkNotebookSignal FocusTab = new("focus-tab");
	public static GtkNotebookSignal MoveFocusOut = new("move-focus-out");
	public static GtkNotebookSignal PageAdded = new("page-added");
	public static GtkNotebookSignal PageRemoved = new("page-removed");
	public static GtkNotebookSignal PageReordered = new("page-reordered");
	public static GtkNotebookSignal ReorderTab = new("reorder-tab");
	public static GtkNotebookSignal SelectPage = new("select-page");
	public static GtkNotebookSignal SwitchPage = new("switch-page");
}

public static class GtkNotebookHandleExtensions
{
	public static int AppendPage(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label)
	{
		return GtkNotebookExterns.gtk_notebook_append_page(notebook, child, tab_label);
	}

	public static int AppendPageMenu(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label)
	{
		return GtkNotebookExterns.gtk_notebook_append_page_menu(notebook, child, tab_label, menu_label);
	}

	public static GtkNotebookHandle DetachTab(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		GtkNotebookExterns.gtk_notebook_detach_tab(notebook, child);
		return notebook;
	}

	public static GtkWidgetHandle GetActionWidget(this GtkNotebookHandle notebook, GtkPackType pack_type)
	{
		return GtkNotebookExterns.gtk_notebook_get_action_widget(notebook, pack_type);
	}

	public static int GetCurrentPage(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_current_page(notebook);
	}

	public static string GetGroupName(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_group_name(notebook);
	}

	public static GtkWidgetHandle GetMenuLabel(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_menu_label(notebook, child);
	}

	public static string GetMenuLabelText(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_menu_label_text(notebook, child);
	}

	public static int GetNPages(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_n_pages(notebook);
	}

	public static GtkWidgetHandle GetNthPage(this GtkNotebookHandle notebook, int page_num)
	{
		return GtkNotebookExterns.gtk_notebook_get_nth_page(notebook, page_num);
	}

	public static GtkNotebookPageHandle GetPage(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_page(notebook, child);
	}

	public static GListModelHandle GetPages(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_pages(notebook);
	}

	public static bool GetScrollable(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_scrollable(notebook);
	}

	public static bool GetShowBorder(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_show_border(notebook);
	}

	public static bool GetShowTabs(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_show_tabs(notebook);
	}

	public static bool GetTabDetachable(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_detachable(notebook, child);
	}

	public static GtkWidgetHandle GetTabLabel(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_label(notebook, child);
	}

	public static string GetTabLabelText(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_label_text(notebook, child);
	}

	public static GtkPositionType GetTabPos(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_pos(notebook);
	}

	public static bool GetTabReorderable(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_reorderable(notebook, child);
	}

	public static int InsertPage(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, int position)
	{
		return GtkNotebookExterns.gtk_notebook_insert_page(notebook, child, tab_label, position);
	}

	public static int InsertPageMenu(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label, int position)
	{
		return GtkNotebookExterns.gtk_notebook_insert_page_menu(notebook, child, tab_label, menu_label, position);
	}

	public static GtkNotebookHandle NextPage(this GtkNotebookHandle notebook)
	{
		GtkNotebookExterns.gtk_notebook_next_page(notebook);
		return notebook;
	}

	public static int PageNum(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_page_num(notebook, child);
	}

	public static GtkNotebookHandle PopupDisable(this GtkNotebookHandle notebook)
	{
		GtkNotebookExterns.gtk_notebook_popup_disable(notebook);
		return notebook;
	}

	public static GtkNotebookHandle PopupEnable(this GtkNotebookHandle notebook)
	{
		GtkNotebookExterns.gtk_notebook_popup_enable(notebook);
		return notebook;
	}

	public static int PrependPage(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label)
	{
		return GtkNotebookExterns.gtk_notebook_prepend_page(notebook, child, tab_label);
	}

	public static int PrependPageMenu(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label)
	{
		return GtkNotebookExterns.gtk_notebook_prepend_page_menu(notebook, child, tab_label, menu_label);
	}

	public static GtkNotebookHandle PrevPage(this GtkNotebookHandle notebook)
	{
		GtkNotebookExterns.gtk_notebook_prev_page(notebook);
		return notebook;
	}

	public static GtkNotebookHandle RemovePage(this GtkNotebookHandle notebook, int page_num)
	{
		GtkNotebookExterns.gtk_notebook_remove_page(notebook, page_num);
		return notebook;
	}

	public static GtkNotebookHandle ReorderChild(this GtkNotebookHandle notebook, GtkWidgetHandle child, int position)
	{
		GtkNotebookExterns.gtk_notebook_reorder_child(notebook, child, position);
		return notebook;
	}

	public static GtkNotebookHandle SetActionWidget(this GtkNotebookHandle notebook, GtkWidgetHandle widget, GtkPackType pack_type)
	{
		GtkNotebookExterns.gtk_notebook_set_action_widget(notebook, widget, pack_type);
		return notebook;
	}

	public static GtkNotebookHandle SetCurrentPage(this GtkNotebookHandle notebook, int page_num)
	{
		GtkNotebookExterns.gtk_notebook_set_current_page(notebook, page_num);
		return notebook;
	}

	public static GtkNotebookHandle SetGroupName(this GtkNotebookHandle notebook, string group_name)
	{
		GtkNotebookExterns.gtk_notebook_set_group_name(notebook, group_name);
		return notebook;
	}

	public static GtkNotebookHandle SetMenuLabel(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle menu_label)
	{
		GtkNotebookExterns.gtk_notebook_set_menu_label(notebook, child, menu_label);
		return notebook;
	}

	public static GtkNotebookHandle SetMenuLabelText(this GtkNotebookHandle notebook, GtkWidgetHandle child, string menu_text)
	{
		GtkNotebookExterns.gtk_notebook_set_menu_label_text(notebook, child, menu_text);
		return notebook;
	}

	public static GtkNotebookHandle SetScrollable(this GtkNotebookHandle notebook, bool scrollable)
	{
		GtkNotebookExterns.gtk_notebook_set_scrollable(notebook, scrollable);
		return notebook;
	}

	public static GtkNotebookHandle SetShowBorder(this GtkNotebookHandle notebook, bool show_border)
	{
		GtkNotebookExterns.gtk_notebook_set_show_border(notebook, show_border);
		return notebook;
	}

	public static GtkNotebookHandle SetShowTabs(this GtkNotebookHandle notebook, bool show_tabs)
	{
		GtkNotebookExterns.gtk_notebook_set_show_tabs(notebook, show_tabs);
		return notebook;
	}

	public static GtkNotebookHandle SetTabDetachable(this GtkNotebookHandle notebook, GtkWidgetHandle child, bool detachable)
	{
		GtkNotebookExterns.gtk_notebook_set_tab_detachable(notebook, child, detachable);
		return notebook;
	}

	public static GtkNotebookHandle SetTabLabel(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label)
	{
		GtkNotebookExterns.gtk_notebook_set_tab_label(notebook, child, tab_label);
		return notebook;
	}

	public static GtkNotebookHandle SetTabLabelText(this GtkNotebookHandle notebook, GtkWidgetHandle child, string tab_text)
	{
		GtkNotebookExterns.gtk_notebook_set_tab_label_text(notebook, child, tab_text);
		return notebook;
	}

	public static GtkNotebookHandle SetTabPos(this GtkNotebookHandle notebook, GtkPositionType pos)
	{
		GtkNotebookExterns.gtk_notebook_set_tab_pos(notebook, pos);
		return notebook;
	}

	public static GtkNotebookHandle SetTabReorderable(this GtkNotebookHandle notebook, GtkWidgetHandle child, bool reorderable)
	{
		GtkNotebookExterns.gtk_notebook_set_tab_reorderable(notebook, child, reorderable);
		return notebook;
	}

	public static GtkNotebookHandle Connect(this GtkNotebookHandle instance, GtkNotebookSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkNotebookExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkNotebookHandle gtk_notebook_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_notebook_append_page(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_notebook_append_page_menu(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_detach_tab(GtkNotebookHandle notebook, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_notebook_get_action_widget(GtkNotebookHandle notebook, GtkPackType pack_type);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_notebook_get_current_page(GtkNotebookHandle notebook);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_notebook_get_group_name(GtkNotebookHandle notebook);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_notebook_get_menu_label(GtkNotebookHandle notebook, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_notebook_get_menu_label_text(GtkNotebookHandle notebook, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_notebook_get_n_pages(GtkNotebookHandle notebook);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_notebook_get_nth_page(GtkNotebookHandle notebook, int page_num);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkNotebookPageHandle gtk_notebook_get_page(GtkNotebookHandle notebook, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_notebook_get_pages(GtkNotebookHandle notebook);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_notebook_get_scrollable(GtkNotebookHandle notebook);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_notebook_get_show_border(GtkNotebookHandle notebook);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_notebook_get_show_tabs(GtkNotebookHandle notebook);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_notebook_get_tab_detachable(GtkNotebookHandle notebook, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_notebook_get_tab_label(GtkNotebookHandle notebook, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_notebook_get_tab_label_text(GtkNotebookHandle notebook, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPositionType gtk_notebook_get_tab_pos(GtkNotebookHandle notebook);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_notebook_get_tab_reorderable(GtkNotebookHandle notebook, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_notebook_insert_page(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, int position);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_notebook_insert_page_menu(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label, int position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_next_page(GtkNotebookHandle notebook);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_notebook_page_num(GtkNotebookHandle notebook, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_popup_disable(GtkNotebookHandle notebook);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_popup_enable(GtkNotebookHandle notebook);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_notebook_prepend_page(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_notebook_prepend_page_menu(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_prev_page(GtkNotebookHandle notebook);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_remove_page(GtkNotebookHandle notebook, int page_num);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_reorder_child(GtkNotebookHandle notebook, GtkWidgetHandle child, int position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_action_widget(GtkNotebookHandle notebook, GtkWidgetHandle widget, GtkPackType pack_type);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_current_page(GtkNotebookHandle notebook, int page_num);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_group_name(GtkNotebookHandle notebook, string group_name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_menu_label(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle menu_label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_menu_label_text(GtkNotebookHandle notebook, GtkWidgetHandle child, string menu_text);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_scrollable(GtkNotebookHandle notebook, bool scrollable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_show_border(GtkNotebookHandle notebook, bool show_border);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_show_tabs(GtkNotebookHandle notebook, bool show_tabs);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_tab_detachable(GtkNotebookHandle notebook, GtkWidgetHandle child, bool detachable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_tab_label(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_tab_label_text(GtkNotebookHandle notebook, GtkWidgetHandle child, string tab_text);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_tab_pos(GtkNotebookHandle notebook, GtkPositionType pos);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_notebook_set_tab_reorderable(GtkNotebookHandle notebook, GtkWidgetHandle child, bool reorderable);
}
