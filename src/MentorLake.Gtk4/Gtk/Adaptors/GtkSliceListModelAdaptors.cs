using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSliceListModelAdaptors
{
	public static GtkSliceListModelHandle SetModel(this GtkSliceListModelHandle self, GListModelHandle model)
	{
		GtkSliceListModelExterns.gtk_slice_list_model_set_model(self, model);
		return self;
	}

	public static GListModelHandle GetModel(this GtkSliceListModelHandle self)
	{
		return GtkSliceListModelExterns.gtk_slice_list_model_get_model(self);
	}

	public static GtkSliceListModelHandle SetOffset(this GtkSliceListModelHandle self, uint offset)
	{
		GtkSliceListModelExterns.gtk_slice_list_model_set_offset(self, offset);
		return self;
	}

	public static uint GetOffset(this GtkSliceListModelHandle self)
	{
		return GtkSliceListModelExterns.gtk_slice_list_model_get_offset(self);
	}

	public static GtkSliceListModelHandle SetSize(this GtkSliceListModelHandle self, uint size)
	{
		GtkSliceListModelExterns.gtk_slice_list_model_set_size(self, size);
		return self;
	}

	public static uint GetSize(this GtkSliceListModelHandle self)
	{
		return GtkSliceListModelExterns.gtk_slice_list_model_get_size(self);
	}
}
