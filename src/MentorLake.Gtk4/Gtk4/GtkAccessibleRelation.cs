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

public enum GtkAccessibleRelation
{
	GTK_ACCESSIBLE_RELATION_ACTIVE_DESCENDANT,
	GTK_ACCESSIBLE_RELATION_COL_COUNT,
	GTK_ACCESSIBLE_RELATION_COL_INDEX,
	GTK_ACCESSIBLE_RELATION_COL_INDEX_TEXT,
	GTK_ACCESSIBLE_RELATION_COL_SPAN,
	GTK_ACCESSIBLE_RELATION_CONTROLS,
	GTK_ACCESSIBLE_RELATION_DESCRIBED_BY,
	GTK_ACCESSIBLE_RELATION_DETAILS,
	GTK_ACCESSIBLE_RELATION_ERROR_MESSAGE,
	GTK_ACCESSIBLE_RELATION_FLOW_TO,
	GTK_ACCESSIBLE_RELATION_LABELLED_BY,
	GTK_ACCESSIBLE_RELATION_OWNS,
	GTK_ACCESSIBLE_RELATION_POS_IN_SET,
	GTK_ACCESSIBLE_RELATION_ROW_COUNT,
	GTK_ACCESSIBLE_RELATION_ROW_INDEX,
	GTK_ACCESSIBLE_RELATION_ROW_INDEX_TEXT,
	GTK_ACCESSIBLE_RELATION_ROW_SPAN,
	GTK_ACCESSIBLE_RELATION_SET_SIZE
}
