using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStackPageAdaptors
{
    public static GtkWidgetHandle GetChild(this GtkStackPageHandle self)
    {
        return GtkStackPageExterns.gtk_stack_page_get_child(self);
    }

    public static int GetVisible(this GtkStackPageHandle self)
    {
        return GtkStackPageExterns.gtk_stack_page_get_visible(self);
    }

    public static GtkStackPageHandle SetVisible(this GtkStackPageHandle self, int visible)
    {
        GtkStackPageExterns.gtk_stack_page_set_visible(self, visible);
        return self;
    }

    public static int GetNeedsAttention(this GtkStackPageHandle self)
    {
        return GtkStackPageExterns.gtk_stack_page_get_needs_attention(self);
    }

    public static GtkStackPageHandle SetNeedsAttention(this GtkStackPageHandle self, int setting)
    {
        GtkStackPageExterns.gtk_stack_page_set_needs_attention(self, setting);
        return self;
    }

    public static int GetUseUnderline(this GtkStackPageHandle self)
    {
        return GtkStackPageExterns.gtk_stack_page_get_use_underline(self);
    }

    public static GtkStackPageHandle SetUseUnderline(this GtkStackPageHandle self, int setting)
    {
        GtkStackPageExterns.gtk_stack_page_set_use_underline(self, setting);
        return self;
    }

    public static string GetName(this GtkStackPageHandle self)
    {
        return GtkStackPageExterns.gtk_stack_page_get_name(self);
    }

    public static GtkStackPageHandle SetName(this GtkStackPageHandle self, string setting)
    {
        GtkStackPageExterns.gtk_stack_page_set_name(self, setting);
        return self;
    }

    public static string GetTitle(this GtkStackPageHandle self)
    {
        return GtkStackPageExterns.gtk_stack_page_get_title(self);
    }

    public static GtkStackPageHandle SetTitle(this GtkStackPageHandle self, string setting)
    {
        GtkStackPageExterns.gtk_stack_page_set_title(self, setting);
        return self;
    }

    public static string GetIconName(this GtkStackPageHandle self)
    {
        return GtkStackPageExterns.gtk_stack_page_get_icon_name(self);
    }

    public static GtkStackPageHandle SetIconName(this GtkStackPageHandle self, string setting)
    {
        GtkStackPageExterns.gtk_stack_page_set_icon_name(self, setting);
        return self;
    }
}
