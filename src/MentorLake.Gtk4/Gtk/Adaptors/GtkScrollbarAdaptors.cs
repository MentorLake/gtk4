using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkScrollbarAdaptors
{
	public static GtkScrollbarHandle SetAdjustment(this GtkScrollbarHandle self, GtkAdjustmentHandle adjustment)
	{
		GtkScrollbarExterns.gtk_scrollbar_set_adjustment(self, adjustment);
		return self;
	}

	public static GtkAdjustmentHandle GetAdjustment(this GtkScrollbarHandle self)
	{
		return GtkScrollbarExterns.gtk_scrollbar_get_adjustment(self);
	}
}
