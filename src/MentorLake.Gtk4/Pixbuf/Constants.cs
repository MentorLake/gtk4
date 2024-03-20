namespace MentorLake.Gtk4.Pixbuf;

public static class Constants
{
	public const int GDK_PIXBUF_MAJOR = 2;
	public const int GDK_PIXBUF_MINOR = 42;
	public const int GDK_PIXBUF_MICRO = 8;
	public const int GDK_PIXBUF_VERSION_2_0 = (2 << 16) | (0 << 8);
	public const int GDK_PIXBUF_VERSION_2_2 = (2 << 16) | (2 << 8);
	public const int GDK_PIXBUF_VERSION_2_4 = (2 << 16) | (4 << 8);
	public const int GDK_PIXBUF_VERSION_2_6 = (2 << 16) | (6 << 8);
	public const int GDK_PIXBUF_VERSION_2_8 = (2 << 16) | (8 << 8);
	public const int GDK_PIXBUF_VERSION_2_10 = (2 << 16) | (10 << 8);
	public const int GDK_PIXBUF_VERSION_2_12 = (2 << 16) | (12 << 8);
	public const int GDK_PIXBUF_VERSION_2_14 = (2 << 16) | (14 << 8);
	public const int GDK_PIXBUF_VERSION_2_16 = (2 << 16) | (16 << 8);
	public const int GDK_PIXBUF_VERSION_2_18 = (2 << 16) | (18 << 8);
	public const int GDK_PIXBUF_VERSION_2_20 = (2 << 16) | (20 << 8);
	public const int GDK_PIXBUF_VERSION_2_22 = (2 << 16) | (22 << 8);
	public const int GDK_PIXBUF_VERSION_2_24 = (2 << 16) | (24 << 8);
	public const int GDK_PIXBUF_VERSION_2_26 = (2 << 16) | (26 << 8);
	public const int GDK_PIXBUF_VERSION_2_28 = (2 << 16) | (28 << 8);
	public const int GDK_PIXBUF_VERSION_2_30 = (2 << 16) | (30 << 8);
	public const int GDK_PIXBUF_VERSION_2_32 = (2 << 16) | (32 << 8);
	public const int GDK_PIXBUF_VERSION_2_34 = (2 << 16) | (34 << 8);
	public const int GDK_PIXBUF_VERSION_2_36 = (2 << 16) | (36 << 8);
	public const int GDK_PIXBUF_VERSION_2_38 = (2 << 16) | (38 << 8);
	public const int GDK_PIXBUF_VERSION_2_40 = (2 << 16) | (40 << 8);
	public const int GDK_PIXBUF_VERSION_CUR_STABLE = (2 << 16) | (42 << 8);
	public const int GDK_PIXBUF_VERSION_PREV_STABLE = (2 << 16) | ((42 - 2) << 8);
	public const int GDK_PIXBUF_VERSION_MIN_REQUIRED = (2 << 16) | (42 << 8);
	public const int GDK_PIXBUF_VERSION_MAX_ALLOWED = (2 << 16) | (42 << 8);
	public static ReadOnlySpan<byte> GDK_PIXBUF_VERSION => "2.42.8"u8;
	public static nuint GDK_TYPE_PIXBUF => Methods.gdk_pixbuf_get_type();
	public static uint GDK_PIXBUF_ERROR => Methods.gdk_pixbuf_error_quark();
	public static nuint GDK_TYPE_PIXBUF_ANIMATION => Methods.gdk_pixbuf_animation_get_type();
	public static nuint GDK_TYPE_PIXBUF_ANIMATION_ITER => Methods.gdk_pixbuf_animation_iter_get_type();
	public static nuint GDK_TYPE_PIXBUF_SIMPLE_ANIM => Methods.gdk_pixbuf_simple_anim_get_type();
	public static nuint GDK_TYPE_PIXBUF_LOADER => Methods.gdk_pixbuf_loader_get_type();
	public static nuint GDK_TYPE_PIXBUF_ALPHA_MODE => Methods.gdk_pixbuf_alpha_mode_get_type();
	public static nuint GDK_TYPE_COLORSPACE => Methods.gdk_colorspace_get_type();
	public static nuint GDK_TYPE_PIXBUF_ERROR => Methods.gdk_pixbuf_error_get_type();
	public static nuint GDK_TYPE_INTERP_TYPE => Methods.gdk_interp_type_get_type();
	public static nuint GDK_TYPE_PIXBUF_ROTATION => Methods.gdk_pixbuf_rotation_get_type();
}
