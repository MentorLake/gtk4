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

public enum GTlsChannelBindingError
{
	G_TLS_CHANNEL_BINDING_ERROR_NOT_IMPLEMENTED,
	G_TLS_CHANNEL_BINDING_ERROR_INVALID_STATE,
	G_TLS_CHANNEL_BINDING_ERROR_NOT_AVAILABLE,
	G_TLS_CHANNEL_BINDING_ERROR_NOT_SUPPORTED,
	G_TLS_CHANNEL_BINDING_ERROR_GENERAL_ERROR
}