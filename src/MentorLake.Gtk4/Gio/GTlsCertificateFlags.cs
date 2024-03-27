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

namespace MentorLake.Gtk4.Gio;

[Flags]
public enum GTlsCertificateFlags
{
	G_TLS_CERTIFICATE_NO_FLAGS = 0,
	G_TLS_CERTIFICATE_UNKNOWN_CA = 1,
	G_TLS_CERTIFICATE_BAD_IDENTITY = 2,
	G_TLS_CERTIFICATE_NOT_ACTIVATED = 4,
	G_TLS_CERTIFICATE_EXPIRED = 8,
	G_TLS_CERTIFICATE_REVOKED = 16,
	G_TLS_CERTIFICATE_INSECURE = 32,
	G_TLS_CERTIFICATE_GENERIC_ERROR = 64,
	G_TLS_CERTIFICATE_VALIDATE_ALL = 128
}
