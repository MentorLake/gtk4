using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPasswordEntryAdaptors
{
	public static GtkPasswordEntryHandle SetShowPeekIcon(this GtkPasswordEntryHandle entry, int show_peek_icon)
	{
		GtkPasswordEntryExterns.gtk_password_entry_set_show_peek_icon(entry, show_peek_icon);
		return entry;
	}

	public static int GetShowPeekIcon(this GtkPasswordEntryHandle entry)
	{
		return GtkPasswordEntryExterns.gtk_password_entry_get_show_peek_icon(entry);
	}

	public static GtkPasswordEntryHandle SetExtraMenu(this GtkPasswordEntryHandle entry, GMenuModelHandle model)
	{
		GtkPasswordEntryExterns.gtk_password_entry_set_extra_menu(entry, model);
		return entry;
	}

	public static GMenuModelHandle GetExtraMenu(this GtkPasswordEntryHandle entry)
	{
		return GtkPasswordEntryExterns.gtk_password_entry_get_extra_menu(entry);
	}
}
