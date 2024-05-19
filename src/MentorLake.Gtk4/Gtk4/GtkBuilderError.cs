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

namespace MentorLake.Gtk4.Gtk4;

public enum GtkBuilderError
{
	GTK_BUILDER_ERROR_INVALID_TYPE_FUNCTION,
	GTK_BUILDER_ERROR_UNHANDLED_TAG,
	GTK_BUILDER_ERROR_MISSING_ATTRIBUTE,
	GTK_BUILDER_ERROR_INVALID_ATTRIBUTE,
	GTK_BUILDER_ERROR_INVALID_TAG,
	GTK_BUILDER_ERROR_MISSING_PROPERTY_VALUE,
	GTK_BUILDER_ERROR_INVALID_VALUE,
	GTK_BUILDER_ERROR_VERSION_MISMATCH,
	GTK_BUILDER_ERROR_DUPLICATE_ID,
	GTK_BUILDER_ERROR_OBJECT_TYPE_REFUSED,
	GTK_BUILDER_ERROR_TEMPLATE_MISMATCH,
	GTK_BUILDER_ERROR_INVALID_PROPERTY,
	GTK_BUILDER_ERROR_INVALID_SIGNAL,
	GTK_BUILDER_ERROR_INVALID_ID,
	GTK_BUILDER_ERROR_INVALID_FUNCTION
}
