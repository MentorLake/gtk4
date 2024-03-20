using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Pixbuf;

public struct GdkPixbufAnimationIter { }
public struct GdkPixbufSimpleAnim { }
public struct GdkPixbuf { }

public struct GdkPixbufLoaderClass
{
	public GObjectClass parent_class;
	public IntPtr size_prepared;
	public IntPtr area_prepared;
	public IntPtr area_updated;
	public IntPtr closed;
}

public struct GdkPixbufAnimation { }
public struct GdkPixbufFormat { }
public struct GdkPixbufSimpleAnimClass { }

public struct GdkPixbufLoader
{
	public GObject.GObject parent_instance;
	public IntPtr priv;
}
