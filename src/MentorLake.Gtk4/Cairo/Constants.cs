namespace MentorLake.Gtk4.Cairo;

public static class Constants
{
	public const int CAIRO_VERSION_MAJOR = 1;
	public const int CAIRO_VERSION_MINOR = 16;
	public const int CAIRO_VERSION_MICRO = 0;
	public const int CAIRO_HAS_FC_FONT = 1;
	public const int CAIRO_HAS_FT_FONT = 1;
	public const int CAIRO_HAS_GOBJECT_FUNCTIONS = 1;
	public const int CAIRO_HAS_IMAGE_SURFACE = 1;
	public const int CAIRO_HAS_MIME_SURFACE = 1;
	public const int CAIRO_HAS_OBSERVER_SURFACE = 1;
	public const int CAIRO_HAS_PDF_SURFACE = 1;
	public const int CAIRO_HAS_PNG_FUNCTIONS = 1;
	public const int CAIRO_HAS_PS_SURFACE = 1;
	public const int CAIRO_HAS_RECORDING_SURFACE = 1;
	public const int CAIRO_HAS_SCRIPT_SURFACE = 1;
	public const int CAIRO_HAS_SVG_SURFACE = 1;
	public const int CAIRO_HAS_TEE_SURFACE = 1;
	public const int CAIRO_HAS_USER_FONT = 1;
	public const int CAIRO_HAS_XCB_SHM_FUNCTIONS = 1;
	public const int CAIRO_HAS_XCB_SURFACE = 1;
	public const int CAIRO_HAS_XLIB_SURFACE = 1;
	public const int CAIRO_HAS_XLIB_XRENDER_SURFACE = 1;
	public const _cairo_font_type CAIRO_FONT_TYPE_ATSUI = _cairo_font_type.CAIRO_FONT_TYPE_QUARTZ;
	public const int CAIRO_VERSION = 1 * 10000 + 16 * 100 + 0 * 1;
	public static ReadOnlySpan<byte> CAIRO_VERSION_STRING => "1.16.0"u8;
	public static ReadOnlySpan<byte> CAIRO_TAG_DEST => "cairo.dest"u8;
	public static ReadOnlySpan<byte> CAIRO_TAG_LINK => "Link"u8;
	public static ReadOnlySpan<byte> CAIRO_MIME_TYPE_JPEG => "image/jpeg"u8;
	public static ReadOnlySpan<byte> CAIRO_MIME_TYPE_PNG => "image/png"u8;
	public static ReadOnlySpan<byte> CAIRO_MIME_TYPE_JP2 => "image/jp2"u8;
	public static ReadOnlySpan<byte> CAIRO_MIME_TYPE_URI => "text/x-uri"u8;
	public static ReadOnlySpan<byte> CAIRO_MIME_TYPE_UNIQUE_ID => "application/x-cairo.uuid"u8;
	public static ReadOnlySpan<byte> CAIRO_MIME_TYPE_JBIG2 => "application/x-cairo.jbig2"u8;
	public static ReadOnlySpan<byte> CAIRO_MIME_TYPE_JBIG2_GLOBAL => "application/x-cairo.jbig2-global"u8;
	public static ReadOnlySpan<byte> CAIRO_MIME_TYPE_JBIG2_GLOBAL_ID => "application/x-cairo.jbig2-global-id"u8;
	public static ReadOnlySpan<byte> CAIRO_MIME_TYPE_CCITT_FAX => "image/g3fax"u8;
	public static ReadOnlySpan<byte> CAIRO_MIME_TYPE_CCITT_FAX_PARAMS => "application/x-cairo.ccitt.params"u8;
	public static ReadOnlySpan<byte> CAIRO_MIME_TYPE_EPS => "application/postscript"u8;
	public static ReadOnlySpan<byte> CAIRO_MIME_TYPE_EPS_PARAMS => "application/x-cairo.eps.params"u8;
}
