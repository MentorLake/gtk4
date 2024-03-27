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

public enum GtkPrintStatus
{
	GTK_PRINT_STATUS_INITIAL,
	GTK_PRINT_STATUS_PREPARING,
	GTK_PRINT_STATUS_GENERATING_DATA,
	GTK_PRINT_STATUS_SENDING_DATA,
	GTK_PRINT_STATUS_PENDING,
	GTK_PRINT_STATUS_PENDING_ISSUE,
	GTK_PRINT_STATUS_PRINTING,
	GTK_PRINT_STATUS_FINISHED,
	GTK_PRINT_STATUS_FINISHED_ABORTED
}
