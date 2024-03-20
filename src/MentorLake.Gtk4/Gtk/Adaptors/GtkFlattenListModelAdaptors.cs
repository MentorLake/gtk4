using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFlattenListModelAdaptors
{
	public static GtkFlattenListModelHandle SetModel(this GtkFlattenListModelHandle self, GListModelHandle model)
	{
		GtkFlattenListModelExterns.gtk_flatten_list_model_set_model(self, model);
		return self;
	}

	public static GListModelHandle GetModel(this GtkFlattenListModelHandle self)
	{
		return GtkFlattenListModelExterns.gtk_flatten_list_model_get_model(self);
	}

	public static GListModelHandle GetModelForItem(this GtkFlattenListModelHandle self, uint position)
	{
		return GtkFlattenListModelExterns.gtk_flatten_list_model_get_model_for_item(self, position);
	}
}
