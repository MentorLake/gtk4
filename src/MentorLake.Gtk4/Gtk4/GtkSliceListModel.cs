using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkSliceListModelHandle : GObjectHandle, GListModelHandle, GtkSectionModelHandle
{
	public static GtkSliceListModelHandle New(GListModelHandle model, uint offset, uint size)
	{
		return GtkSliceListModelExterns.gtk_slice_list_model_new(model, offset, size);
	}

}

public static class GtkSliceListModelHandleExtensions
{
	public static GListModelHandle GetModel(this GtkSliceListModelHandle self)
	{
		return GtkSliceListModelExterns.gtk_slice_list_model_get_model(self);
	}

	public static uint GetOffset(this GtkSliceListModelHandle self)
	{
		return GtkSliceListModelExterns.gtk_slice_list_model_get_offset(self);
	}

	public static uint GetSize(this GtkSliceListModelHandle self)
	{
		return GtkSliceListModelExterns.gtk_slice_list_model_get_size(self);
	}

	public static GtkSliceListModelHandle SetModel(this GtkSliceListModelHandle self, GListModelHandle model)
	{
		GtkSliceListModelExterns.gtk_slice_list_model_set_model(self, model);
		return self;
	}

	public static GtkSliceListModelHandle SetOffset(this GtkSliceListModelHandle self, uint offset)
	{
		GtkSliceListModelExterns.gtk_slice_list_model_set_offset(self, offset);
		return self;
	}

	public static GtkSliceListModelHandle SetSize(this GtkSliceListModelHandle self, uint size)
	{
		GtkSliceListModelExterns.gtk_slice_list_model_set_size(self, size);
		return self;
	}

}

internal class GtkSliceListModelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSliceListModelHandle gtk_slice_list_model_new(GListModelHandle model, uint offset, uint size);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_slice_list_model_get_model(GtkSliceListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_slice_list_model_get_offset(GtkSliceListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_slice_list_model_get_size(GtkSliceListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_slice_list_model_set_model(GtkSliceListModelHandle self, GListModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_slice_list_model_set_offset(GtkSliceListModelHandle self, uint offset);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_slice_list_model_set_size(GtkSliceListModelHandle self, uint size);

}
