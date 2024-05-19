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

namespace MentorLake.Gtk4.Gio;

[Flags]
public enum GAskPasswordFlags
{
	G_ASK_PASSWORD_NEED_PASSWORD = 0,
	G_ASK_PASSWORD_NEED_USERNAME = 1,
	G_ASK_PASSWORD_NEED_DOMAIN = 2,
	G_ASK_PASSWORD_SAVING_SUPPORTED = 4,
	G_ASK_PASSWORD_ANONYMOUS_SUPPORTED = 8,
	G_ASK_PASSWORD_TCRYPT = 16
}
