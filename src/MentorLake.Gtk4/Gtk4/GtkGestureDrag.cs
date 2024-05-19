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

public class GtkGestureDragHandle : GtkGestureSingleHandle
{
	public static GtkGestureDragHandle New()
	{
		return GtkGestureDragExterns.gtk_gesture_drag_new();
	}

}

public static class GtkGestureDragSignalExtensions
{

	public static IObservable<GtkGestureDragSignalStructs.DragBeginSignal> Signal_DragBegin(this GtkGestureDragHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureDragSignalStructs.DragBeginSignal> obs) =>
		{
			GtkGestureDragSignalDelegates.DragBegin handler = (GtkGestureDragHandle self, double start_x, double start_y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureDragSignalStructs.DragBeginSignal()
				{
					Self = self, StartX = start_x, StartY = start_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureDragSignalStructs.DragEndSignal> Signal_DragEnd(this GtkGestureDragHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureDragSignalStructs.DragEndSignal> obs) =>
		{
			GtkGestureDragSignalDelegates.DragEnd handler = (GtkGestureDragHandle self, double offset_x, double offset_y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureDragSignalStructs.DragEndSignal()
				{
					Self = self, OffsetX = offset_x, OffsetY = offset_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureDragSignalStructs.DragUpdateSignal> Signal_DragUpdate(this GtkGestureDragHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureDragSignalStructs.DragUpdateSignal> obs) =>
		{
			GtkGestureDragSignalDelegates.DragUpdate handler = (GtkGestureDragHandle self, double offset_x, double offset_y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureDragSignalStructs.DragUpdateSignal()
				{
					Self = self, OffsetX = offset_x, OffsetY = offset_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_update", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkGestureDragSignalStructs
{

public struct DragBeginSignal
{
	public GtkGestureDragHandle Self;
	public double StartX;
	public double StartY;
	public IntPtr UserData;
}

public struct DragEndSignal
{
	public GtkGestureDragHandle Self;
	public double OffsetX;
	public double OffsetY;
	public IntPtr UserData;
}

public struct DragUpdateSignal
{
	public GtkGestureDragHandle Self;
	public double OffsetX;
	public double OffsetY;
	public IntPtr UserData;
}
}

public static class GtkGestureDragSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DragBegin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureDragHandle>))] GtkGestureDragHandle self, double start_x, double start_y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DragEnd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureDragHandle>))] GtkGestureDragHandle self, double offset_x, double offset_y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DragUpdate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureDragHandle>))] GtkGestureDragHandle self, double offset_x, double offset_y, IntPtr user_data);
}


public static class GtkGestureDragHandleExtensions
{
	public static bool GetOffset(this GtkGestureDragHandle gesture, out double x, out double y)
	{
		return GtkGestureDragExterns.gtk_gesture_drag_get_offset(gesture, out x, out y);
	}

	public static bool GetStartPoint(this GtkGestureDragHandle gesture, out double x, out double y)
	{
		return GtkGestureDragExterns.gtk_gesture_drag_get_start_point(gesture, out x, out y);
	}

}

internal class GtkGestureDragExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureDragHandle gtk_gesture_drag_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_drag_get_offset(GtkGestureDragHandle gesture, out double x, out double y);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_drag_get_start_point(GtkGestureDragHandle gesture, out double x, out double y);

}
