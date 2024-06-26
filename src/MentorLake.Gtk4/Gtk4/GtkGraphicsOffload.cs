namespace MentorLake.Gtk4.Gtk4;

public class GtkGraphicsOffloadHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkGraphicsOffloadHandle New(GtkWidgetHandle child)
	{
		return GtkGraphicsOffloadExterns.gtk_graphics_offload_new(child);
	}

}

public static class GtkGraphicsOffloadHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkGraphicsOffloadHandle self)
	{
		return GtkGraphicsOffloadExterns.gtk_graphics_offload_get_child(self);
	}

	public static GtkGraphicsOffloadEnabled GetEnabled(this GtkGraphicsOffloadHandle self)
	{
		return GtkGraphicsOffloadExterns.gtk_graphics_offload_get_enabled(self);
	}

	public static GtkGraphicsOffloadHandle SetChild(this GtkGraphicsOffloadHandle self, GtkWidgetHandle child)
	{
		GtkGraphicsOffloadExterns.gtk_graphics_offload_set_child(self, child);
		return self;
	}

	public static GtkGraphicsOffloadHandle SetEnabled(this GtkGraphicsOffloadHandle self, GtkGraphicsOffloadEnabled enabled)
	{
		GtkGraphicsOffloadExterns.gtk_graphics_offload_set_enabled(self, enabled);
		return self;
	}

}

internal class GtkGraphicsOffloadExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGraphicsOffloadHandle gtk_graphics_offload_new(GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_graphics_offload_get_child(GtkGraphicsOffloadHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGraphicsOffloadEnabled gtk_graphics_offload_get_enabled(GtkGraphicsOffloadHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_graphics_offload_set_child(GtkGraphicsOffloadHandle self, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_graphics_offload_set_enabled(GtkGraphicsOffloadHandle self, GtkGraphicsOffloadEnabled enabled);

}
