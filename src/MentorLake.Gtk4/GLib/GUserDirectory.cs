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

namespace MentorLake.Gtk4.GLib;

public enum GUserDirectory
{
	G_USER_DIRECTORY_DESKTOP,
	G_USER_DIRECTORY_DOCUMENTS,
	G_USER_DIRECTORY_DOWNLOAD,
	G_USER_DIRECTORY_MUSIC,
	G_USER_DIRECTORY_PICTURES,
	G_USER_DIRECTORY_PUBLIC_SHARE,
	G_USER_DIRECTORY_TEMPLATES,
	G_USER_DIRECTORY_VIDEOS,
	G_USER_N_DIRECTORIES
}
