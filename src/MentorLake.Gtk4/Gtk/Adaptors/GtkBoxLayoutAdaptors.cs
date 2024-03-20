using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBoxLayoutAdaptors
{
    public static GtkBoxLayoutHandle SetHomogeneous(this GtkBoxLayoutHandle box_layout, int homogeneous)
    {
        GtkBoxLayoutExterns.gtk_box_layout_set_homogeneous(box_layout, homogeneous);
        return box_layout;
    }

    public static int GetHomogeneous(this GtkBoxLayoutHandle box_layout)
    {
        return GtkBoxLayoutExterns.gtk_box_layout_get_homogeneous(box_layout);
    }

    public static GtkBoxLayoutHandle SetSpacing(this GtkBoxLayoutHandle box_layout, uint spacing)
    {
        GtkBoxLayoutExterns.gtk_box_layout_set_spacing(box_layout, spacing);
        return box_layout;
    }

    public static uint GetSpacing(this GtkBoxLayoutHandle box_layout)
    {
        return GtkBoxLayoutExterns.gtk_box_layout_get_spacing(box_layout);
    }

    public static GtkBoxLayoutHandle SetBaselinePosition(this GtkBoxLayoutHandle box_layout, GtkBaselinePosition position)
    {
        GtkBoxLayoutExterns.gtk_box_layout_set_baseline_position(box_layout, position);
        return box_layout;
    }

    public static GtkBaselinePosition GetBaselinePosition(this GtkBoxLayoutHandle box_layout)
    {
        return GtkBoxLayoutExterns.gtk_box_layout_get_baseline_position(box_layout);
    }
}
