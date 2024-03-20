using System.Runtime.CompilerServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;

public struct GdkToplevelLayout { }

public struct GdkPaintableInterface
{
	public GTypeInterface g_iface;
	public IntPtr snapshot;
	public IntPtr get_current_image;
	public IntPtr get_flags;
	public IntPtr get_intrinsic_width;
	public IntPtr get_intrinsic_height;
	public IntPtr get_intrinsic_aspect_ratio;
}

public struct GdkScrollEvent { }
public struct GdkMemoryTexture { }
public struct GdkToplevelInterface { }

public struct GdkRGBA
{
	public float red;
	public float green;
	public float blue;
	public float alpha;
}

public struct GdkGLContext { }

public struct GdkKeymapKey
{
	public uint keycode;
	public int group;
	public int level;
}

public struct GdkButtonEvent { }
public struct GdkEventSequence { }
public struct GdkFrameClockClass { }
public struct GdkToplevelSize { }
public struct GdkAppLaunchContext { }
public struct GdkMemoryTextureClass { }
public struct GdkFocusEvent { }
public struct GdkDrop { }
public struct GdkVulkanContext { }

public struct GdkContentProviderClass
{
	public GObjectClass parent_class;
	public IntPtr content_changed;
	public IntPtr attach_clipboard;
	public IntPtr detach_clipboard;
	public IntPtr ref_formats;
	public IntPtr ref_storable_formats;
	public IntPtr write_mime_type_async;
	public IntPtr write_mime_type_finish;
	public IntPtr get_value;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GdkFrameClock { }
public struct GdkPopup { }
public struct GdkDeleteEvent { }
public struct GdkContentDeserializer { }

public struct GdkTimeCoord
{
	public uint time;
	public GdkAxisFlags flags;
	public _axes_e__FixedBuffer axes;

	[InlineArray(12)]
	public struct _axes_e__FixedBuffer
	{
		public double e0;
	}
}

public struct GdkPopupLayout { }
public struct GdkToplevel { }
public struct GdkProximityEvent { }
public struct GdkGLTextureClass { }
public struct GdkSnapshot { }
public struct GdkDragSurfaceInterface { }
public struct GdkPadEvent { }
public struct GdkDisplayManager { }
public struct GdkContentFormats { }
public struct GdkDNDEvent { }
public struct GdkGrabBrokenEvent { }
public struct GdkMonitorClass { }
public struct GdkContentSerializer { }
public struct GdkSnapshotClass { }
public struct GdkDevicePad { }
public struct GdkTouchEvent { }
public struct GdkFrameClockPrivate { }
public struct GdkMonitor { }

public struct GdkSeat
{
	public GObject.GObject parent_instance;
}

public struct GdkContentFormatsBuilder { }
public struct GdkCursor { }
public struct GdkCairoContext { }
public struct GdkGLTexture { }
public struct GdkSurfaceClass { }

public struct GdkContentProvider
{
	public GObject.GObject parent;
}

public struct GdkClipboard { }
public struct GdkPaintable { }
public struct GdkCrossingEvent { }
public struct GdkDrag { }
public struct GdkDragSurface { }
public struct GdkMotionEvent { }
public struct GdkDevicePadInterface { }
public struct GdkDeviceTool { }
public struct GdkSurface { }
public struct GdkKeyEvent { }
public struct GdkTouchpadEvent { }
public struct GdkDisplay { }
public struct GdkTexture { }
public struct GdkFrameTimings { }
public struct GdkDrawContext { }
public struct GdkDevice { }
public struct GdkEvent { }
public struct GdkPopupInterface { }
public struct GdkFileList { }
public struct GdkTextureClass { }

public struct GdkRectangle
{
	public int x;
	public int y;
	public int width;
	public int height;
}
