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

public class GtkPasswordEntryBufferHandle : GtkEntryBufferHandle
{
	public static GtkPasswordEntryBufferHandle New()
	{
		return GtkPasswordEntryBufferExterns.gtk_password_entry_buffer_new();
	}

}

public static class GtkPasswordEntryBufferHandleExtensions
{
}

internal class GtkPasswordEntryBufferExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPasswordEntryBufferHandle gtk_password_entry_buffer_new();
}
