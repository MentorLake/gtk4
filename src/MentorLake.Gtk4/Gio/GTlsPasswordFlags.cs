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
public enum GTlsPasswordFlags
{
	G_TLS_PASSWORD_NONE = 0,
	G_TLS_PASSWORD_RETRY = 1,
	G_TLS_PASSWORD_MANY_TRIES = 2,
	G_TLS_PASSWORD_FINAL_TRY = 4,
	G_TLS_PASSWORD_PKCS11_USER = 8,
	G_TLS_PASSWORD_PKCS11_SECURITY_OFFICER = 16,
	G_TLS_PASSWORD_PKCS11_CONTEXT_SPECIFIC = 32
}
