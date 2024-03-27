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

public class GtkAssistantPageHandle : GObjectHandle
{
}

public static class GtkAssistantPageSignals
{
}

public static class GtkAssistantPageHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkAssistantPageHandle page)
	{
		return GtkAssistantPageExterns.gtk_assistant_page_get_child(page);
	}

}

internal class GtkAssistantPageExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_assistant_page_get_child(GtkAssistantPageHandle page);
}
