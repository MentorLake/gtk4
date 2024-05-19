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

public enum GtkInputPurpose
{
	GTK_INPUT_PURPOSE_FREE_FORM,
	GTK_INPUT_PURPOSE_ALPHA,
	GTK_INPUT_PURPOSE_DIGITS,
	GTK_INPUT_PURPOSE_NUMBER,
	GTK_INPUT_PURPOSE_PHONE,
	GTK_INPUT_PURPOSE_URL,
	GTK_INPUT_PURPOSE_EMAIL,
	GTK_INPUT_PURPOSE_NAME,
	GTK_INPUT_PURPOSE_PASSWORD,
	GTK_INPUT_PURPOSE_PIN,
	GTK_INPUT_PURPOSE_TERMINAL
}
