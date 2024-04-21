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

namespace MentorLake.Gtk4.Gdk4;

internal class GlobalFunctionExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_cairo_set_source_rgba(cairo_tHandle cr, GdkRGBAHandle rgba);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkPixbufHandle gdk_pixbuf_get_from_surface(cairo_surface_tHandle surface, int src_x, int src_y, int width, int height);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_unicode_to_keyval(uint wc);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_keyval_to_unicode(uint keyval);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_cairo_draw_from_gl(cairo_tHandle cr, GdkSurfaceHandle surface, int source, int source_type, int buffer_scale, int x, int y, int width, int height);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_cairo_rectangle(cairo_tHandle cr, GdkRectangleHandle rectangle);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_cairo_set_source_pixbuf(cairo_tHandle cr, GdkPixbufHandle pixbuf, double pixbuf_x, double pixbuf_y);

	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_intern_mime_type(string @string);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_keyval_to_upper(uint keyval);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_set_allowed_backends(string backends);

	[DllImport(Libraries.Gdk4)]
	internal static extern cairo_region_tHandle gdk_pango_layout_get_clip_region(PangoLayoutHandle layout, int x_origin, int y_origin, ref int index_ranges, int n_ranges);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_register_serializer(GType type, string mime_type, GdkContentSerializeFunc serialize, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.Gdk4)]
	internal static extern cairo_region_tHandle gdk_cairo_region_create_from_surface(cairo_surface_tHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_keyval_is_upper(uint keyval);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_register_deserializer(string mime_type, GType type, GdkContentDeserializeFunc deserialize, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.Gdk4)]
	internal static extern cairo_region_tHandle gdk_pango_layout_line_get_clip_region(PangoLayoutLineHandle line, int x_origin, int y_origin, int[] index_ranges, int n_ranges);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_deserialize_async(GInputStreamHandle stream, string mime_type, GType type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk4)]
	internal static extern GType gdk_toplevel_size_get_type();

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_content_deserialize_finish(GAsyncResultHandle result, out GValue value, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_content_serialize_finish(GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_cairo_region(cairo_tHandle cr, cairo_region_tHandle region);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_keyval_is_lower(uint keyval);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_keyval_convert_case(uint symbol, out uint lower, out uint upper);

	[DllImport(Libraries.Gdk4)]
	internal static extern GType gdk_drag_surface_size_get_type();

	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_keyval_name(uint keyval);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_keyval_to_lower(uint keyval);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_serialize_async(GOutputStreamHandle stream, string mime_type, GValueHandle value, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_keyval_from_name(string keyval_name);

}
