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

public enum GFileAttributeType
{
	G_FILE_ATTRIBUTE_TYPE_INVALID,
	G_FILE_ATTRIBUTE_TYPE_STRING,
	G_FILE_ATTRIBUTE_TYPE_BYTE_STRING,
	G_FILE_ATTRIBUTE_TYPE_BOOLEAN,
	G_FILE_ATTRIBUTE_TYPE_UINT32,
	G_FILE_ATTRIBUTE_TYPE_INT32,
	G_FILE_ATTRIBUTE_TYPE_UINT64,
	G_FILE_ATTRIBUTE_TYPE_INT64,
	G_FILE_ATTRIBUTE_TYPE_OBJECT,
	G_FILE_ATTRIBUTE_TYPE_STRINGV
}
