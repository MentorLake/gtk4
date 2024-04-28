using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_path_data_tHandle : BaseSafeHandle { }

[StructLayout(LayoutKind.Explicit)]
public struct cairo_path_data_t
{
	[FieldOffset(0)] public _header_e__Struct header;
	[FieldOffset(0)] public _point_e__Struct point;

	public struct _header_e__Struct
	{
		public cairo_path_data_type_t type;
		public int length;
	}

	public struct _point_e__Struct
	{
		public double x;
		public double y;
	}
}
