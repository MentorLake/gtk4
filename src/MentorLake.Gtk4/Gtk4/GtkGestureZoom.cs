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

public class GtkGestureZoomHandle : GtkGestureHandle
{
	public static GtkGestureZoomHandle New()
	{
		return GtkGestureZoomExterns.gtk_gesture_zoom_new();
	}

}

public static class GtkGestureZoomSignalExtensions
{

	public static IObservable<GtkGestureZoomSignalStructs.ScaleChangedSignal> Signal_ScaleChanged(this GtkGestureZoomHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureZoomSignalStructs.ScaleChangedSignal> obs) =>
		{
			GtkGestureZoomSignalDelegates.ScaleChanged handler = (GtkGestureZoomHandle self, double scale, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureZoomSignalStructs.ScaleChangedSignal()
				{
					Self = self, Scale = scale, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "scale_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkGestureZoomSignalStructs
{

public struct ScaleChangedSignal
{
	public GtkGestureZoomHandle Self;
	public double Scale;
	public IntPtr UserData;
}
}

public static class GtkGestureZoomSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ScaleChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureZoomHandle>))] GtkGestureZoomHandle self, double scale, IntPtr user_data);
}


public static class GtkGestureZoomHandleExtensions
{
	public static double GetScaleDelta(this GtkGestureZoomHandle gesture)
	{
		return GtkGestureZoomExterns.gtk_gesture_zoom_get_scale_delta(gesture);
	}

}

internal class GtkGestureZoomExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureZoomHandle gtk_gesture_zoom_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_gesture_zoom_get_scale_delta(GtkGestureZoomHandle gesture);

}
