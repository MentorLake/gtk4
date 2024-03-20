using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkNotebookAdaptors
{
	public static int AppendPage(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label)
	{
		return GtkNotebookExterns.gtk_notebook_append_page(notebook, child, tab_label);
	}

	public static int AppendPageMenu(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label)
	{
		return GtkNotebookExterns.gtk_notebook_append_page_menu(notebook, child, tab_label, menu_label);
	}

	public static int PrependPage(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label)
	{
		return GtkNotebookExterns.gtk_notebook_prepend_page(notebook, child, tab_label);
	}

	public static int PrependPageMenu(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label)
	{
		return GtkNotebookExterns.gtk_notebook_prepend_page_menu(notebook, child, tab_label, menu_label);
	}

	public static int InsertPage(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, int position)
	{
		return GtkNotebookExterns.gtk_notebook_insert_page(notebook, child, tab_label, position);
	}

	public static int InsertPageMenu(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label, int position)
	{
		return GtkNotebookExterns.gtk_notebook_insert_page_menu(notebook, child, tab_label, menu_label, position);
	}

	public static GtkNotebookHandle RemovePage(this GtkNotebookHandle notebook, int page_num)
	{
		GtkNotebookExterns.gtk_notebook_remove_page(notebook, page_num);
		return notebook;
	}

	public static GtkNotebookHandle SetGroupName(this GtkNotebookHandle notebook, string group_name)
	{
		GtkNotebookExterns.gtk_notebook_set_group_name(notebook, group_name);
		return notebook;
	}

	public static string GetGroupName(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_group_name(notebook);
	}

	public static int GetCurrentPage(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_current_page(notebook);
	}

	public static GtkWidgetHandle GetNthPage(this GtkNotebookHandle notebook, int page_num)
	{
		return GtkNotebookExterns.gtk_notebook_get_nth_page(notebook, page_num);
	}

	public static int GetNPages(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_n_pages(notebook);
	}

	public static int PageNum(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_page_num(notebook, child);
	}

	public static GtkNotebookHandle SetCurrentPage(this GtkNotebookHandle notebook, int page_num)
	{
		GtkNotebookExterns.gtk_notebook_set_current_page(notebook, page_num);
		return notebook;
	}

	public static GtkNotebookHandle NextPage(this GtkNotebookHandle notebook)
	{
		GtkNotebookExterns.gtk_notebook_next_page(notebook);
		return notebook;
	}

	public static GtkNotebookHandle PrevPage(this GtkNotebookHandle notebook)
	{
		GtkNotebookExterns.gtk_notebook_prev_page(notebook);
		return notebook;
	}

	public static GtkNotebookHandle SetShowBorder(this GtkNotebookHandle notebook, int show_border)
	{
		GtkNotebookExterns.gtk_notebook_set_show_border(notebook, show_border);
		return notebook;
	}

	public static int GetShowBorder(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_show_border(notebook);
	}

	public static GtkNotebookHandle SetShowTabs(this GtkNotebookHandle notebook, int show_tabs)
	{
		GtkNotebookExterns.gtk_notebook_set_show_tabs(notebook, show_tabs);
		return notebook;
	}

	public static int GetShowTabs(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_show_tabs(notebook);
	}

	public static GtkNotebookHandle SetTabPos(this GtkNotebookHandle notebook, GtkPositionType pos)
	{
		GtkNotebookExterns.gtk_notebook_set_tab_pos(notebook, pos);
		return notebook;
	}

	public static GtkPositionType GetTabPos(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_pos(notebook);
	}

	public static GtkNotebookHandle SetScrollable(this GtkNotebookHandle notebook, int scrollable)
	{
		GtkNotebookExterns.gtk_notebook_set_scrollable(notebook, scrollable);
		return notebook;
	}

	public static int GetScrollable(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_scrollable(notebook);
	}

	public static GtkNotebookHandle PopupEnable(this GtkNotebookHandle notebook)
	{
		GtkNotebookExterns.gtk_notebook_popup_enable(notebook);
		return notebook;
	}

	public static GtkNotebookHandle PopupDisable(this GtkNotebookHandle notebook)
	{
		GtkNotebookExterns.gtk_notebook_popup_disable(notebook);
		return notebook;
	}

	public static GtkWidgetHandle GetTabLabel(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_label(notebook, child);
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

	public static string GetTabLabelText(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_label_text(notebook, child);
	}

	public static GtkWidgetHandle GetMenuLabel(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_menu_label(notebook, child);
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

	public static string GetMenuLabelText(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_menu_label_text(notebook, child);
	}

	public static GtkNotebookHandle ReorderChild(this GtkNotebookHandle notebook, GtkWidgetHandle child, int position)
	{
		GtkNotebookExterns.gtk_notebook_reorder_child(notebook, child, position);
		return notebook;
	}

	public static int GetTabReorderable(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_reorderable(notebook, child);
	}

	public static GtkNotebookHandle SetTabReorderable(this GtkNotebookHandle notebook, GtkWidgetHandle child, int reorderable)
	{
		GtkNotebookExterns.gtk_notebook_set_tab_reorderable(notebook, child, reorderable);
		return notebook;
	}

	public static int GetTabDetachable(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_detachable(notebook, child);
	}

	public static GtkNotebookHandle SetTabDetachable(this GtkNotebookHandle notebook, GtkWidgetHandle child, int detachable)
	{
		GtkNotebookExterns.gtk_notebook_set_tab_detachable(notebook, child, detachable);
		return notebook;
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

	public static GtkNotebookHandle SetActionWidget(this GtkNotebookHandle notebook, GtkWidgetHandle widget, GtkPackType pack_type)
	{
		GtkNotebookExterns.gtk_notebook_set_action_widget(notebook, widget, pack_type);
		return notebook;
	}

	public static GtkNotebookPageHandle GetPage(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_page(notebook, child);
	}

	public static GListModelHandle GetPages(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_pages(notebook);
	}
}
