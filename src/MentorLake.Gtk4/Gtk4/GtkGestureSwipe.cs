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

public class GtkGestureSwipeHandle : GtkGestureSingleHandle
{
	public static GtkGestureSwipeHandle New()
	{
		return GtkGestureSwipeExterns.gtk_gesture_swipe_new();
	}

}

public static class GtkGestureSwipeSignalExtensions
{

	public static IObservable<GtkGestureSwipeSignalStructs.SwipeSignal> Signal_Swipe(this GtkGestureSwipeHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureSwipeSignalStructs.SwipeSignal> obs) =>
		{
			GtkGestureSwipeSignalDelegates.Swipe handler = (GtkGestureSwipeHandle self, double velocity_x, double velocity_y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureSwipeSignalStructs.SwipeSignal()
				{
					Self = self, VelocityX = velocity_x, VelocityY = velocity_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "swipe", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkGestureSwipeSignalStructs
{

public struct SwipeSignal
{
	public GtkGestureSwipeHandle Self;
	public double VelocityX;
	public double VelocityY;
	public IntPtr UserData;
}
}

public static class GtkGestureSwipeSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Swipe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureSwipeHandle>))] GtkGestureSwipeHandle self, double velocity_x, double velocity_y, IntPtr user_data);
}


public static class GtkGestureSwipeHandleExtensions
{
	public static bool GetVelocity(this GtkGestureSwipeHandle gesture, out double velocity_x, out double velocity_y)
	{
		return GtkGestureSwipeExterns.gtk_gesture_swipe_get_velocity(gesture, out velocity_x, out velocity_y);
	}

}

internal class GtkGestureSwipeExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureSwipeHandle gtk_gesture_swipe_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_swipe_get_velocity(GtkGestureSwipeHandle gesture, out double velocity_x, out double velocity_y);

}
