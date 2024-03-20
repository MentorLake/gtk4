using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStatusbarAdaptors
{
	public static uint GetContextId(this GtkStatusbarHandle statusbar, string context_description)
	{
		return GtkStatusbarExterns.gtk_statusbar_get_context_id(statusbar, context_description);
	}

	public static uint Push(this GtkStatusbarHandle statusbar, uint context_id, string text)
	{
		return GtkStatusbarExterns.gtk_statusbar_push(statusbar, context_id, text);
	}

	public static GtkStatusbarHandle Pop(this GtkStatusbarHandle statusbar, uint context_id)
	{
		GtkStatusbarExterns.gtk_statusbar_pop(statusbar, context_id);
		return statusbar;
	}

	public static GtkStatusbarHandle Remove(this GtkStatusbarHandle statusbar, uint context_id, uint message_id)
	{
		GtkStatusbarExterns.gtk_statusbar_remove(statusbar, context_id, message_id);
		return statusbar;
	}

	public static GtkStatusbarHandle RemoveAll(this GtkStatusbarHandle statusbar, uint context_id)
	{
		GtkStatusbarExterns.gtk_statusbar_remove_all(statusbar, context_id);
		return statusbar;
	}
}
