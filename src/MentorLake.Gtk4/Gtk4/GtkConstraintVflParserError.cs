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

public enum GtkConstraintVflParserError
{
	GTK_CONSTRAINT_VFL_PARSER_ERROR_INVALID_SYMBOL,
	GTK_CONSTRAINT_VFL_PARSER_ERROR_INVALID_ATTRIBUTE,
	GTK_CONSTRAINT_VFL_PARSER_ERROR_INVALID_VIEW,
	GTK_CONSTRAINT_VFL_PARSER_ERROR_INVALID_METRIC,
	GTK_CONSTRAINT_VFL_PARSER_ERROR_INVALID_PRIORITY,
	GTK_CONSTRAINT_VFL_PARSER_ERROR_INVALID_RELATION
}
