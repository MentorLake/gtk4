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

public class GtkEventControllerScrollHandle : GtkEventControllerHandle
{
	public static GtkEventControllerScrollHandle New(GtkEventControllerScrollFlags flags)
	{
		return GtkEventControllerScrollExterns.gtk_event_controller_scroll_new(flags);
	}

}

public static class GtkEventControllerScrollSignalExtensions
{

	public static IObservable<GtkEventControllerScrollSignalStructs.DecelerateSignal> Signal_Decelerate(this GtkEventControllerScrollHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerScrollSignalStructs.DecelerateSignal> obs) =>
		{
			GtkEventControllerScrollSignalDelegates.Decelerate handler = (GtkEventControllerScrollHandle self, double vel_x, double vel_y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerScrollSignalStructs.DecelerateSignal()
				{
					Self = self, VelX = vel_x, VelY = vel_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "decelerate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerScrollSignalStructs.ScrollSignal> Signal_Scroll(this GtkEventControllerScrollHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerScrollSignalStructs.ScrollSignal> obs) =>
		{
			GtkEventControllerScrollSignalDelegates.Scroll handler = (GtkEventControllerScrollHandle self, double dx, double dy, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerScrollSignalStructs.ScrollSignal()
				{
					Self = self, Dx = dx, Dy = dy, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "scroll", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerScrollSignalStructs.ScrollBeginSignal> Signal_ScrollBegin(this GtkEventControllerScrollHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerScrollSignalStructs.ScrollBeginSignal> obs) =>
		{
			GtkEventControllerScrollSignalDelegates.ScrollBegin handler = (GtkEventControllerScrollHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerScrollSignalStructs.ScrollBeginSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "scroll_begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerScrollSignalStructs.ScrollEndSignal> Signal_ScrollEnd(this GtkEventControllerScrollHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerScrollSignalStructs.ScrollEndSignal> obs) =>
		{
			GtkEventControllerScrollSignalDelegates.ScrollEnd handler = (GtkEventControllerScrollHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerScrollSignalStructs.ScrollEndSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "scroll_end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkEventControllerScrollSignalStructs
{

public struct DecelerateSignal
{
	public GtkEventControllerScrollHandle Self;
	public double VelX;
	public double VelY;
	public IntPtr UserData;
}

public struct ScrollSignal
{
	public GtkEventControllerScrollHandle Self;
	public double Dx;
	public double Dy;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ScrollBeginSignal
{
	public GtkEventControllerScrollHandle Self;
	public IntPtr UserData;
}

public struct ScrollEndSignal
{
	public GtkEventControllerScrollHandle Self;
	public IntPtr UserData;
}
}

public static class GtkEventControllerScrollSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Decelerate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerScrollHandle>))] GtkEventControllerScrollHandle self, double vel_x, double vel_y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Scroll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerScrollHandle>))] GtkEventControllerScrollHandle self, double dx, double dy, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ScrollBegin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerScrollHandle>))] GtkEventControllerScrollHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ScrollEnd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerScrollHandle>))] GtkEventControllerScrollHandle self, IntPtr user_data);
}


public static class GtkEventControllerScrollHandleExtensions
{
	public static GtkEventControllerScrollFlags GetFlags(this GtkEventControllerScrollHandle scroll)
	{
		return GtkEventControllerScrollExterns.gtk_event_controller_scroll_get_flags(scroll);
	}

	public static GdkScrollUnit GetUnit(this GtkEventControllerScrollHandle scroll)
	{
		return GtkEventControllerScrollExterns.gtk_event_controller_scroll_get_unit(scroll);
	}

	public static GtkEventControllerScrollHandle SetFlags(this GtkEventControllerScrollHandle scroll, GtkEventControllerScrollFlags flags)
	{
		GtkEventControllerScrollExterns.gtk_event_controller_scroll_set_flags(scroll, flags);
		return scroll;
	}

}

internal class GtkEventControllerScrollExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerScrollHandle gtk_event_controller_scroll_new(GtkEventControllerScrollFlags flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerScrollFlags gtk_event_controller_scroll_get_flags(GtkEventControllerScrollHandle scroll);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkScrollUnit gtk_event_controller_scroll_get_unit(GtkEventControllerScrollHandle scroll);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_event_controller_scroll_set_flags(GtkEventControllerScrollHandle scroll, GtkEventControllerScrollFlags flags);

}
