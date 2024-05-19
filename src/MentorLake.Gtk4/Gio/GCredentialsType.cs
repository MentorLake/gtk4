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

public enum GCredentialsType
{
	G_CREDENTIALS_TYPE_INVALID,
	G_CREDENTIALS_TYPE_LINUX_UCRED,
	G_CREDENTIALS_TYPE_FREEBSD_CMSGCRED,
	G_CREDENTIALS_TYPE_OPENBSD_SOCKPEERCRED,
	G_CREDENTIALS_TYPE_SOLARIS_UCRED,
	G_CREDENTIALS_TYPE_NETBSD_UNPCBID,
	G_CREDENTIALS_TYPE_APPLE_XUCRED,
	G_CREDENTIALS_TYPE_WIN32_PID
}
