using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkRangeAdaptors
{
    public static GtkRangeHandle SetAdjustment(this GtkRangeHandle range, GtkAdjustmentHandle adjustment)
    {
        GtkRangeExterns.gtk_range_set_adjustment(range, adjustment);
        return range;
    }

    public static GtkAdjustmentHandle GetAdjustment(this GtkRangeHandle range)
    {
        return GtkRangeExterns.gtk_range_get_adjustment(range);
    }

    public static GtkRangeHandle SetInverted(this GtkRangeHandle range, int setting)
    {
        GtkRangeExterns.gtk_range_set_inverted(range, setting);
        return range;
    }

    public static int GetInverted(this GtkRangeHandle range)
    {
        return GtkRangeExterns.gtk_range_get_inverted(range);
    }

    public static GtkRangeHandle SetFlippable(this GtkRangeHandle range, int flippable)
    {
        GtkRangeExterns.gtk_range_set_flippable(range, flippable);
        return range;
    }

    public static int GetFlippable(this GtkRangeHandle range)
    {
        return GtkRangeExterns.gtk_range_get_flippable(range);
    }

    public static GtkRangeHandle SetSliderSizeFixed(this GtkRangeHandle range, int size_fixed)
    {
        GtkRangeExterns.gtk_range_set_slider_size_fixed(range, size_fixed);
        return range;
    }

    public static int GetSliderSizeFixed(this GtkRangeHandle range)
    {
        return GtkRangeExterns.gtk_range_get_slider_size_fixed(range);
    }

    public static GtkRangeHandle GetRangeRect(this GtkRangeHandle range, GdkRectangleHandle range_rect)
    {
        GtkRangeExterns.gtk_range_get_range_rect(range, range_rect);
        return range;
    }

    public static GtkRangeHandle GetSliderRange(this GtkRangeHandle range, out int slider_start, out int slider_end)
    {
        GtkRangeExterns.gtk_range_get_slider_range(range, out slider_start, out slider_end);
        return range;
    }

    public static GtkRangeHandle SetIncrements(this GtkRangeHandle range, double step, double page)
    {
        GtkRangeExterns.gtk_range_set_increments(range, step, page);
        return range;
    }

    public static GtkRangeHandle SetRange(this GtkRangeHandle range, double min, double max)
    {
        GtkRangeExterns.gtk_range_set_range(range, min, max);
        return range;
    }

    public static GtkRangeHandle SetValue(this GtkRangeHandle range, double value)
    {
        GtkRangeExterns.gtk_range_set_value(range, value);
        return range;
    }

    public static double GetValue(this GtkRangeHandle range)
    {
        return GtkRangeExterns.gtk_range_get_value(range);
    }

    public static GtkRangeHandle SetShowFillLevel(this GtkRangeHandle range, int show_fill_level)
    {
        GtkRangeExterns.gtk_range_set_show_fill_level(range, show_fill_level);
        return range;
    }

    public static int GetShowFillLevel(this GtkRangeHandle range)
    {
        return GtkRangeExterns.gtk_range_get_show_fill_level(range);
    }

    public static GtkRangeHandle SetRestrictToFillLevel(this GtkRangeHandle range, int restrict_to_fill_level)
    {
        GtkRangeExterns.gtk_range_set_restrict_to_fill_level(range, restrict_to_fill_level);
        return range;
    }

    public static int GetRestrictToFillLevel(this GtkRangeHandle range)
    {
        return GtkRangeExterns.gtk_range_get_restrict_to_fill_level(range);
    }

    public static GtkRangeHandle SetFillLevel(this GtkRangeHandle range, double fill_level)
    {
        GtkRangeExterns.gtk_range_set_fill_level(range, fill_level);
        return range;
    }

    public static double GetFillLevel(this GtkRangeHandle range)
    {
        return GtkRangeExterns.gtk_range_get_fill_level(range);
    }

    public static GtkRangeHandle SetRoundDigits(this GtkRangeHandle range, int round_digits)
    {
        GtkRangeExterns.gtk_range_set_round_digits(range, round_digits);
        return range;
    }

    public static int GetRoundDigits(this GtkRangeHandle range)
    {
        return GtkRangeExterns.gtk_range_get_round_digits(range);
    }
}
