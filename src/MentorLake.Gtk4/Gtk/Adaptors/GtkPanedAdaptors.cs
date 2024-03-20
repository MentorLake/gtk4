using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPanedAdaptors
{
	public static GtkPanedHandle SetStartChild(this GtkPanedHandle paned, GtkWidgetHandle child)
	{
		GtkPanedExterns.gtk_paned_set_start_child(paned, child);
		return paned;
	}

	public static GtkWidgetHandle GetStartChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_start_child(paned);
	}

	public static GtkPanedHandle SetResizeStartChild(this GtkPanedHandle paned, int resize)
	{
		GtkPanedExterns.gtk_paned_set_resize_start_child(paned, resize);
		return paned;
	}

	public static int GetResizeStartChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_resize_start_child(paned);
	}

	public static GtkPanedHandle SetEndChild(this GtkPanedHandle paned, GtkWidgetHandle child)
	{
		GtkPanedExterns.gtk_paned_set_end_child(paned, child);
		return paned;
	}

	public static GtkWidgetHandle GetEndChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_end_child(paned);
	}

	public static GtkPanedHandle SetShrinkStartChild(this GtkPanedHandle paned, int resize)
	{
		GtkPanedExterns.gtk_paned_set_shrink_start_child(paned, resize);
		return paned;
	}

	public static int GetShrinkStartChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_shrink_start_child(paned);
	}

	public static GtkPanedHandle SetResizeEndChild(this GtkPanedHandle paned, int resize)
	{
		GtkPanedExterns.gtk_paned_set_resize_end_child(paned, resize);
		return paned;
	}

	public static int GetResizeEndChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_resize_end_child(paned);
	}

	public static GtkPanedHandle SetShrinkEndChild(this GtkPanedHandle paned, int resize)
	{
		GtkPanedExterns.gtk_paned_set_shrink_end_child(paned, resize);
		return paned;
	}

	public static int GetShrinkEndChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_shrink_end_child(paned);
	}

	public static int GetPosition(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_position(paned);
	}

	public static GtkPanedHandle SetPosition(this GtkPanedHandle paned, int position)
	{
		GtkPanedExterns.gtk_paned_set_position(paned, position);
		return paned;
	}

	public static GtkPanedHandle SetWideHandle(this GtkPanedHandle paned, int wide)
	{
		GtkPanedExterns.gtk_paned_set_wide_handle(paned, wide);
		return paned;
	}

	public static int GetWideHandle(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_wide_handle(paned);
	}
}
