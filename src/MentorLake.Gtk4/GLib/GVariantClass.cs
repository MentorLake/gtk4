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

namespace MentorLake.Gtk4.GLib;

public enum GVariantClass
{
	G_VARIANT_CLASS_BOOLEAN,
	G_VARIANT_CLASS_BYTE,
	G_VARIANT_CLASS_INT16,
	G_VARIANT_CLASS_UINT16,
	G_VARIANT_CLASS_INT32,
	G_VARIANT_CLASS_UINT32,
	G_VARIANT_CLASS_INT64,
	G_VARIANT_CLASS_UINT64,
	G_VARIANT_CLASS_HANDLE,
	G_VARIANT_CLASS_DOUBLE,
	G_VARIANT_CLASS_STRING,
	G_VARIANT_CLASS_OBJECT_PATH,
	G_VARIANT_CLASS_SIGNATURE,
	G_VARIANT_CLASS_VARIANT,
	G_VARIANT_CLASS_MAYBE,
	G_VARIANT_CLASS_ARRAY,
	G_VARIANT_CLASS_TUPLE,
	G_VARIANT_CLASS_DICT_ENTRY
}
