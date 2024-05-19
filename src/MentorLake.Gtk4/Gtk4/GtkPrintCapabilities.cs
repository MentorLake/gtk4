using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

[Flags]
public enum GtkPrintCapabilities
{
	GTK_PRINT_CAPABILITY_PAGE_SET = 0,
	GTK_PRINT_CAPABILITY_COPIES = 1,
	GTK_PRINT_CAPABILITY_COLLATE = 2,
	GTK_PRINT_CAPABILITY_REVERSE = 4,
	GTK_PRINT_CAPABILITY_SCALE = 8,
	GTK_PRINT_CAPABILITY_GENERATE_PDF = 16,
	GTK_PRINT_CAPABILITY_GENERATE_PS = 32,
	GTK_PRINT_CAPABILITY_PREVIEW = 64,
	GTK_PRINT_CAPABILITY_NUMBER_UP = 128,
	GTK_PRINT_CAPABILITY_NUMBER_UP_LAYOUT = 256
}
