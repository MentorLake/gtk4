using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public struct cairo_rectangle
{
	public double x;
	public double y;
	public double width;
	public double height;
}

public struct cairo_surface { }
public struct cairo_device { }

[StructLayout(LayoutKind.Explicit)]
public struct cairo_path_data_t
{
	[FieldOffset(0)] public _header_e__Struct header;
	[FieldOffset(0)] public _point_e__Struct point;

	public struct _header_e__Struct
	{
		public _cairo_path_data_type type;
		public int length;
	}

	public struct _point_e__Struct
	{
		public double x;
		public double y;
	}
}

public struct cairo_rectangle_list
{
	public _cairo_status status;
	public cairo_rectangle[] rectangles;
	public int num_rectangles;
}

public struct cairo_font_extents_t
{
	public double ascent;
	public double descent;
	public double height;
	public double max_x_advance;
	public double max_y_advance;
}

public struct cairo_font_face { }

public struct cairo_user_data_key
{
	public int unused;
}

public struct cairo_text_extents_t
{
	public double x_bearing;
	public double y_bearing;
	public double width;
	public double height;
	public double x_advance;
	public double y_advance;
}

public struct cairo_font_options { }
public struct cairo { }

public struct cairo_rectangle_int
{
	public int x;
	public int y;
	public int width;
	public int height;
}

public struct cairo_path
{
	public _cairo_status status;
	public cairo_path_data_tHandle data;
	public int num_data;
}

public struct cairo_region { }
public struct cairo_pattern { }

public struct cairo_text_cluster_t
{
	public int num_bytes;
	public int num_glyphs;
}

public struct cairo_matrix
{
	public double xx;
	public double yx;
	public double xy;
	public double yy;
	public double x0;
	public double y0;
}

public struct cairo_glyph_t
{
	public double x;
	public double y;
}

public struct cairo_scaled_font { }
