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

namespace MentorLake.Gtk4.Gsk4;

public enum GskTransformCategory
{
	GSK_TRANSFORM_CATEGORY_UNKNOWN,
	GSK_TRANSFORM_CATEGORY_ANY,
	GSK_TRANSFORM_CATEGORY_3D,
	GSK_TRANSFORM_CATEGORY_2D,
	GSK_TRANSFORM_CATEGORY_2D_AFFINE,
	GSK_TRANSFORM_CATEGORY_2D_TRANSLATE,
	GSK_TRANSFORM_CATEGORY_IDENTITY
}
