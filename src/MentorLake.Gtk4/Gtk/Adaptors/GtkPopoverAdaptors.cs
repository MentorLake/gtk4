using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPopoverAdaptors
{
	public static GtkPopoverHandle SetChild(this GtkPopoverHandle popover, GtkWidgetHandle child)
	{
		GtkPopoverExterns.gtk_popover_set_child(popover, child);
		return popover;
	}

	public static GtkWidgetHandle GetChild(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_child(popover);
	}

	public static GtkPopoverHandle SetPointingTo(this GtkPopoverHandle popover, GdkRectangleHandle rect)
	{
		GtkPopoverExterns.gtk_popover_set_pointing_to(popover, rect);
		return popover;
	}

	public static int GetPointingTo(this GtkPopoverHandle popover, GdkRectangleHandle rect)
	{
		return GtkPopoverExterns.gtk_popover_get_pointing_to(popover, rect);
	}

	public static GtkPopoverHandle SetPosition(this GtkPopoverHandle popover, GtkPositionType position)
	{
		GtkPopoverExterns.gtk_popover_set_position(popover, position);
		return popover;
	}

	public static GtkPositionType GetPosition(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_position(popover);
	}

	public static GtkPopoverHandle SetAutohide(this GtkPopoverHandle popover, int autohide)
	{
		GtkPopoverExterns.gtk_popover_set_autohide(popover, autohide);
		return popover;
	}

	public static int GetAutohide(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_autohide(popover);
	}

	public static GtkPopoverHandle SetHasArrow(this GtkPopoverHandle popover, int has_arrow)
	{
		GtkPopoverExterns.gtk_popover_set_has_arrow(popover, has_arrow);
		return popover;
	}

	public static int GetHasArrow(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_has_arrow(popover);
	}

	public static GtkPopoverHandle SetMnemonicsVisible(this GtkPopoverHandle popover, int mnemonics_visible)
	{
		GtkPopoverExterns.gtk_popover_set_mnemonics_visible(popover, mnemonics_visible);
		return popover;
	}

	public static int GetMnemonicsVisible(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_mnemonics_visible(popover);
	}

	public static GtkPopoverHandle Popup(this GtkPopoverHandle popover)
	{
		GtkPopoverExterns.gtk_popover_popup(popover);
		return popover;
	}

	public static GtkPopoverHandle Popdown(this GtkPopoverHandle popover)
	{
		GtkPopoverExterns.gtk_popover_popdown(popover);
		return popover;
	}

	public static GtkPopoverHandle SetOffset(this GtkPopoverHandle popover, int x_offset, int y_offset)
	{
		GtkPopoverExterns.gtk_popover_set_offset(popover, x_offset, y_offset);
		return popover;
	}

	public static GtkPopoverHandle GetOffset(this GtkPopoverHandle popover, out int x_offset, out int y_offset)
	{
		GtkPopoverExterns.gtk_popover_get_offset(popover, out x_offset, out y_offset);
		return popover;
	}

	public static GtkPopoverHandle SetCascadePopdown(this GtkPopoverHandle popover, int cascade_popdown)
	{
		GtkPopoverExterns.gtk_popover_set_cascade_popdown(popover, cascade_popdown);
		return popover;
	}

	public static int GetCascadePopdown(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_cascade_popdown(popover);
	}

	public static GtkPopoverHandle SetDefaultWidget(this GtkPopoverHandle popover, GtkWidgetHandle widget)
	{
		GtkPopoverExterns.gtk_popover_set_default_widget(popover, widget);
		return popover;
	}

	public static GtkPopoverHandle Present(this GtkPopoverHandle popover)
	{
		GtkPopoverExterns.gtk_popover_present(popover);
		return popover;
	}
}
