using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Pixbuf;

namespace MentorLake.Gtk4.Gdk;
public class GdkToplevelLayoutHandle : GObjectHandle
{
	public static GdkToplevelLayoutHandle New()
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_new();
	}
}

public class GdkPaintableInterfaceHandle : GObjectHandle
{
}

public class GdkScrollEventHandle : GObjectHandle
{
}

public class GdkMemoryTextureHandle : GObjectHandle
{
}

public class GdkToplevelInterfaceHandle : GObjectHandle
{
}

public class GdkRGBAHandle : GObjectHandle
{
}

public class GdkGLContextHandle : GObjectHandle
{
}

public class GdkKeymapKeyHandle : GObjectHandle
{
}

public class GdkButtonEventHandle : GObjectHandle
{
}

public class GdkEventSequenceHandle : GObjectHandle
{
}

public class GdkFrameClockClassHandle : GObjectHandle
{
}

public class GdkToplevelSizeHandle : GObjectHandle
{
}

public class GdkAppLaunchContextHandle : GObjectHandle
{
}

public class GdkMemoryTextureClassHandle : GObjectHandle
{
}

public class GdkFocusEventHandle : GObjectHandle
{
}

public class GdkDropHandle : GObjectHandle
{
}

public class GdkVulkanContextHandle : GObjectHandle
{
}

public class GdkContentProviderClassHandle : GObjectHandle
{
}

public class GdkFrameClockHandle : GObjectHandle
{
}

public class GdkPopupHandle : GObjectHandle
{
}

public class GdkDeleteEventHandle : GObjectHandle
{
}

public class GdkContentDeserializerHandle : GObjectHandle
{
}

public class GdkTimeCoordHandle : GObjectHandle
{
}

public class GdkPopupLayoutHandle : GObjectHandle
{
}

public class GdkToplevelHandle : GObjectHandle
{
}

public class GdkProximityEventHandle : GObjectHandle
{
}

public class GdkGLTextureClassHandle : GObjectHandle
{
}

public class GdkSnapshotHandle : GObjectHandle
{
}

public class GdkDragSurfaceInterfaceHandle : GObjectHandle
{
}

public class GdkPadEventHandle : GObjectHandle
{
}

public class GdkDisplayManagerHandle : GObjectHandle
{
}

public class GdkContentFormatsHandle : GObjectHandle
{
	public static GdkContentFormatsHandle New(string[] mime_types, uint n_mime_types)
	{
		return GdkContentFormatsExterns.gdk_content_formats_new(mime_types, n_mime_types);
	}

	public static GdkContentFormatsHandle NewForGtype(GType type)
	{
		return GdkContentFormatsExterns.gdk_content_formats_new_for_gtype(type);
	}
}

public class GdkDNDEventHandle : GObjectHandle
{
}

public class GdkGrabBrokenEventHandle : GObjectHandle
{
}

public class GdkMonitorClassHandle : GObjectHandle
{
}

public class GdkContentSerializerHandle : GObjectHandle
{
}

public class GdkSnapshotClassHandle : GObjectHandle
{
}

public class GdkDevicePadHandle : GObjectHandle
{
}

public class GdkTouchEventHandle : GObjectHandle
{
}

public class GdkFrameClockPrivateHandle : GObjectHandle
{
}

public class GdkMonitorHandle : GObjectHandle
{
}

public class GdkSeatHandle : GObjectHandle
{
}

public class GdkContentFormatsBuilderHandle : GObjectHandle
{
	public static GdkContentFormatsBuilderHandle New()
	{
		return GdkContentFormatsBuilderExterns.gdk_content_formats_builder_new();
	}
}

public class GdkCursorHandle : GObjectHandle
{
	public static GdkCursorHandle NewFromName(string name, GdkCursorHandle fallback)
	{
		return GdkCursorExterns.gdk_cursor_new_from_name(name, fallback);
	}
}

public class GdkCairoContextHandle : GObjectHandle
{
}

public class GdkGLTextureHandle : GObjectHandle
{
}

public class GdkSurfaceClassHandle : GObjectHandle
{
}

public class GdkContentProviderHandle : GObjectHandle
{
	public static GdkContentProviderHandle NewForValue(GValueHandle value)
	{
		return GdkContentProviderExterns.gdk_content_provider_new_for_value(value);
	}

	public static GdkContentProviderHandle NewTyped(GType type, IntPtr @__arglist)
	{
		return GdkContentProviderExterns.gdk_content_provider_new_typed(type, @__arglist);
	}

	public static GdkContentProviderHandle NewForBytes(string mime_type, GBytesHandle bytes)
	{
		return GdkContentProviderExterns.gdk_content_provider_new_for_bytes(mime_type, bytes);
	}
}

public class GdkClipboardHandle : GObjectHandle
{
}

public class GdkPaintableHandle : GObjectHandle
{
	public static GdkPaintableHandle NewEmpty(int intrinsic_width, int intrinsic_height)
	{
		return GdkPaintableExterns.gdk_paintable_new_empty(intrinsic_width, intrinsic_height);
	}
}

public class GdkCrossingEventHandle : GObjectHandle
{
}

public class GdkDragHandle : GObjectHandle
{
}

public class GdkDragSurfaceHandle : GObjectHandle
{
}

public class GdkMotionEventHandle : GObjectHandle
{
}

public class GdkDevicePadInterfaceHandle : GObjectHandle
{
}

public class GdkDeviceToolHandle : GObjectHandle
{
}

public class GdkSurfaceHandle : GObjectHandle
{
	public static GdkSurfaceHandle NewToplevel(GdkDisplayHandle display)
	{
		return GdkSurfaceExterns.gdk_surface_new_toplevel(display);
	}
}

public class GdkKeyEventHandle : GObjectHandle
{
}

public class GdkTouchpadEventHandle : GObjectHandle
{
}

public class GdkDisplayHandle : GObjectHandle
{
}

public class GdkTextureHandle : GObjectHandle
{
	public static GdkTextureHandle NewForPixbuf(GdkPixbufHandle pixbuf)
	{
		return GdkTextureExterns.gdk_texture_new_for_pixbuf(pixbuf);
	}

	public static GdkTextureHandle NewFromResource(string resource_path)
	{
		return GdkTextureExterns.gdk_texture_new_from_resource(resource_path);
	}

	public static GdkTextureHandle NewFromFile(GFileHandle file, out GErrorHandle error)
	{
		return GdkTextureExterns.gdk_texture_new_from_file(file, out error);
	}

	public static GdkTextureHandle NewFromFilename(string path, out GErrorHandle error)
	{
		return GdkTextureExterns.gdk_texture_new_from_filename(path, out error);
	}

	public static GdkTextureHandle NewFromBytes(GBytesHandle bytes, out GErrorHandle error)
	{
		return GdkTextureExterns.gdk_texture_new_from_bytes(bytes, out error);
	}

	public static GdkTextureHandle GdkGlTextureNew(GdkGLContextHandle context, uint id, int width, int height, GDestroyNotify destroy, IntPtr data)
	{
		return GdkTextureExterns.gdk_gl_texture_new(context, id, width, height, destroy, data);
	}

	public static GdkTextureHandle GdkMemoryTextureNew(int width, int height, GdkMemoryFormat format, GBytesHandle bytes, nuint stride)
	{
		return GdkTextureExterns.gdk_memory_texture_new(width, height, format, bytes, stride);
	}
}

public class GdkFrameTimingsHandle : GObjectHandle
{
}

public class GdkDrawContextHandle : GObjectHandle
{
}

public class GdkDeviceHandle : GObjectHandle
{
}

public class GdkEventHandle : GObjectHandle
{
}

public class GdkPopupInterfaceHandle : GObjectHandle
{
}

public class GdkFileListHandle : GObjectHandle
{
}

public class GdkTextureClassHandle : GObjectHandle
{
}

public class GdkRectangleHandle : GObjectHandle
{
}
