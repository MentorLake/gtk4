using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkOverlayAdaptors
{
	public static GtkOverlayHandle AddOverlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget)
	{
		GtkOverlayExterns.gtk_overlay_add_overlay(overlay, widget);
		return overlay;
	}

	public static GtkOverlayHandle RemoveOverlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget)
	{
		GtkOverlayExterns.gtk_overlay_remove_overlay(overlay, widget);
		return overlay;
	}

	public static GtkOverlayHandle SetChild(this GtkOverlayHandle overlay, GtkWidgetHandle child)
	{
		GtkOverlayExterns.gtk_overlay_set_child(overlay, child);
		return overlay;
	}

	public static GtkWidgetHandle GetChild(this GtkOverlayHandle overlay)
	{
		return GtkOverlayExterns.gtk_overlay_get_child(overlay);
	}

	public static int GetMeasureOverlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget)
	{
		return GtkOverlayExterns.gtk_overlay_get_measure_overlay(overlay, widget);
	}

	public static GtkOverlayHandle SetMeasureOverlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget, int measure)
	{
		GtkOverlayExterns.gtk_overlay_set_measure_overlay(overlay, widget, measure);
		return overlay;
	}

	public static int GetClipOverlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget)
	{
		return GtkOverlayExterns.gtk_overlay_get_clip_overlay(overlay, widget);
	}

	public static GtkOverlayHandle SetClipOverlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget, int clip_overlay)
	{
		GtkOverlayExterns.gtk_overlay_set_clip_overlay(overlay, widget, clip_overlay);
		return overlay;
	}
}
