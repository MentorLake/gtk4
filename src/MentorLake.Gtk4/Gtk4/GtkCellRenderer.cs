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

public class GtkCellRendererHandle : GInitiallyUnownedHandle
{
}

public static class GtkCellRendererSignalExtensions
{

	public static IObservable<GtkCellRendererSignalStructs.EditingCanceledSignal> Signal_EditingCanceled(this GtkCellRendererHandle instance)
	{
		return Observable.Create((IObserver<GtkCellRendererSignalStructs.EditingCanceledSignal> obs) =>
		{
			GtkCellRendererSignalDelegates.EditingCanceled handler = (GtkCellRendererHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererSignalStructs.EditingCanceledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "editing_canceled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkCellRendererSignalStructs.EditingStartedSignal> Signal_EditingStarted(this GtkCellRendererHandle instance)
	{
		return Observable.Create((IObserver<GtkCellRendererSignalStructs.EditingStartedSignal> obs) =>
		{
			GtkCellRendererSignalDelegates.EditingStarted handler = (GtkCellRendererHandle self, GtkCellEditableHandle editable, string path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererSignalStructs.EditingStartedSignal()
				{
					Self = self, Editable = editable, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "editing_started", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkCellRendererSignalStructs
{

public struct EditingCanceledSignal
{
	public GtkCellRendererHandle Self;
	public IntPtr UserData;
}

public struct EditingStartedSignal
{
	public GtkCellRendererHandle Self;
	public GtkCellEditableHandle Editable;
	public string Path;
	public IntPtr UserData;
}
}

public static class GtkCellRendererSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void EditingCanceled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererHandle>))] GtkCellRendererHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void EditingStarted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererHandle>))] GtkCellRendererHandle self, GtkCellEditableHandle editable, string path, IntPtr user_data);
}


public static class GtkCellRendererHandleExtensions
{
	public static bool Activate(this GtkCellRendererHandle cell, GdkEventHandle @event, GtkWidgetHandle widget, string path, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_activate(cell, @event, widget, path, background_area, cell_area, flags);
	}

	public static GtkCellRendererHandle GetAlignedArea(this GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkCellRendererState flags, GdkRectangleHandle cell_area, out GdkRectangle aligned_area)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_aligned_area(cell, widget, flags, cell_area, out aligned_area);
		return cell;
	}

	public static GtkCellRendererHandle GetAlignment(this GtkCellRendererHandle cell, out float xalign, out float yalign)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_alignment(cell, out xalign, out yalign);
		return cell;
	}

	public static GtkCellRendererHandle GetFixedSize(this GtkCellRendererHandle cell, out int width, out int height)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_fixed_size(cell, out width, out height);
		return cell;
	}

	public static bool GetIsExpanded(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_is_expanded(cell);
	}

	public static bool GetIsExpander(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_is_expander(cell);
	}

	public static GtkCellRendererHandle GetPadding(this GtkCellRendererHandle cell, out int xpad, out int ypad)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_padding(cell, out xpad, out ypad);
		return cell;
	}

	public static GtkCellRendererHandle GetPreferredHeight(this GtkCellRendererHandle cell, GtkWidgetHandle widget, out int minimum_size, out int natural_size)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_height(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

	public static GtkCellRendererHandle GetPreferredHeightForWidth(this GtkCellRendererHandle cell, GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_height_for_width(cell, widget, width, out minimum_height, out natural_height);
		return cell;
	}

	public static GtkCellRendererHandle GetPreferredSize(this GtkCellRendererHandle cell, GtkWidgetHandle widget, out GtkRequisition minimum_size, out GtkRequisition natural_size)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_size(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

	public static GtkCellRendererHandle GetPreferredWidth(this GtkCellRendererHandle cell, GtkWidgetHandle widget, out int minimum_size, out int natural_size)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_width(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

	public static GtkCellRendererHandle GetPreferredWidthForHeight(this GtkCellRendererHandle cell, GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_width_for_height(cell, widget, height, out minimum_width, out natural_width);
		return cell;
	}

	public static GtkSizeRequestMode GetRequestMode(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_request_mode(cell);
	}

	public static bool GetSensitive(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_sensitive(cell);
	}

	public static GtkStateFlags GetState(this GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkCellRendererState cell_state)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_state(cell, widget, cell_state);
	}

	public static bool GetVisible(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_visible(cell);
	}

	public static bool IsActivatable(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_is_activatable(cell);
	}

	public static GtkCellRendererHandle SetAlignment(this GtkCellRendererHandle cell, float xalign, float yalign)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_alignment(cell, xalign, yalign);
		return cell;
	}

	public static GtkCellRendererHandle SetFixedSize(this GtkCellRendererHandle cell, int width, int height)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_fixed_size(cell, width, height);
		return cell;
	}

	public static GtkCellRendererHandle SetIsExpanded(this GtkCellRendererHandle cell, bool is_expanded)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_is_expanded(cell, is_expanded);
		return cell;
	}

	public static GtkCellRendererHandle SetIsExpander(this GtkCellRendererHandle cell, bool is_expander)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_is_expander(cell, is_expander);
		return cell;
	}

	public static GtkCellRendererHandle SetPadding(this GtkCellRendererHandle cell, int xpad, int ypad)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_padding(cell, xpad, ypad);
		return cell;
	}

	public static GtkCellRendererHandle SetSensitive(this GtkCellRendererHandle cell, bool sensitive)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_sensitive(cell, sensitive);
		return cell;
	}

	public static GtkCellRendererHandle SetVisible(this GtkCellRendererHandle cell, bool visible)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_visible(cell, visible);
		return cell;
	}

	public static GtkCellRendererHandle Snapshot(this GtkCellRendererHandle cell, GtkSnapshotHandle snapshot, GtkWidgetHandle widget, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		GtkCellRendererExterns.gtk_cell_renderer_snapshot(cell, snapshot, widget, background_area, cell_area, flags);
		return cell;
	}

	public static GtkCellEditableHandle StartEditing(this GtkCellRendererHandle cell, GdkEventHandle @event, GtkWidgetHandle widget, string path, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_start_editing(cell, @event, widget, path, background_area, cell_area, flags);
	}

	public static GtkCellRendererHandle StopEditing(this GtkCellRendererHandle cell, bool canceled)
	{
		GtkCellRendererExterns.gtk_cell_renderer_stop_editing(cell, canceled);
		return cell;
	}

}

internal class GtkCellRendererExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_renderer_activate(GtkCellRendererHandle cell, GdkEventHandle @event, GtkWidgetHandle widget, string path, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_get_aligned_area(GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkCellRendererState flags, GdkRectangleHandle cell_area, out GdkRectangle aligned_area);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_get_alignment(GtkCellRendererHandle cell, out float xalign, out float yalign);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_get_fixed_size(GtkCellRendererHandle cell, out int width, out int height);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_renderer_get_is_expanded(GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_renderer_get_is_expander(GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_get_padding(GtkCellRendererHandle cell, out int xpad, out int ypad);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_get_preferred_height(GtkCellRendererHandle cell, GtkWidgetHandle widget, out int minimum_size, out int natural_size);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_get_preferred_height_for_width(GtkCellRendererHandle cell, GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_get_preferred_size(GtkCellRendererHandle cell, GtkWidgetHandle widget, out GtkRequisition minimum_size, out GtkRequisition natural_size);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_get_preferred_width(GtkCellRendererHandle cell, GtkWidgetHandle widget, out int minimum_size, out int natural_size);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_get_preferred_width_for_height(GtkCellRendererHandle cell, GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSizeRequestMode gtk_cell_renderer_get_request_mode(GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_renderer_get_sensitive(GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStateFlags gtk_cell_renderer_get_state(GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkCellRendererState cell_state);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_renderer_get_visible(GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_renderer_is_activatable(GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_set_alignment(GtkCellRendererHandle cell, float xalign, float yalign);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_set_fixed_size(GtkCellRendererHandle cell, int width, int height);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_set_is_expanded(GtkCellRendererHandle cell, bool is_expanded);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_set_is_expander(GtkCellRendererHandle cell, bool is_expander);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_set_padding(GtkCellRendererHandle cell, int xpad, int ypad);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_set_sensitive(GtkCellRendererHandle cell, bool sensitive);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_set_visible(GtkCellRendererHandle cell, bool visible);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_snapshot(GtkCellRendererHandle cell, GtkSnapshotHandle snapshot, GtkWidgetHandle widget, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellEditableHandle gtk_cell_renderer_start_editing(GtkCellRendererHandle cell, GdkEventHandle @event, GtkWidgetHandle widget, string path, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_stop_editing(GtkCellRendererHandle cell, bool canceled);

}
