using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFlowBoxChildAdaptors
{
	public static GtkFlowBoxChildHandle SetChild(this GtkFlowBoxChildHandle self, GtkWidgetHandle child)
	{
		GtkFlowBoxChildExterns.gtk_flow_box_child_set_child(self, child);
		return self;
	}

	public static GtkWidgetHandle GetChild(this GtkFlowBoxChildHandle self)
	{
		return GtkFlowBoxChildExterns.gtk_flow_box_child_get_child(self);
	}

	public static int GetIndex(this GtkFlowBoxChildHandle child)
	{
		return GtkFlowBoxChildExterns.gtk_flow_box_child_get_index(child);
	}

	public static int IsSelected(this GtkFlowBoxChildHandle child)
	{
		return GtkFlowBoxChildExterns.gtk_flow_box_child_is_selected(child);
	}

	public static GtkFlowBoxChildHandle Changed(this GtkFlowBoxChildHandle child)
	{
		GtkFlowBoxChildExterns.gtk_flow_box_child_changed(child);
		return child;
	}
}
