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

public class GtkDropTargetHandle : GtkEventControllerHandle
{
	public static GtkDropTargetHandle New(GType type, GdkDragAction actions)
	{
		return GtkDropTargetExterns.gtk_drop_target_new(type, actions);
	}

}

public static class GtkDropTargetSignalExtensions
{

	public static IObservable<GtkDropTargetSignalStructs.AcceptSignal> Signal_Accept(this GtkDropTargetHandle instance)
	{
		return Observable.Create((IObserver<GtkDropTargetSignalStructs.AcceptSignal> obs) =>
		{
			GtkDropTargetSignalDelegates.Accept handler = (GtkDropTargetHandle self, GdkDropHandle drop, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropTargetSignalStructs.AcceptSignal()
				{
					Self = self, Drop = drop, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "accept", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkDropTargetSignalStructs.DropSignal> Signal_Drop(this GtkDropTargetHandle instance)
	{
		return Observable.Create((IObserver<GtkDropTargetSignalStructs.DropSignal> obs) =>
		{
			GtkDropTargetSignalDelegates.Drop handler = (GtkDropTargetHandle self, GValueHandle value, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropTargetSignalStructs.DropSignal()
				{
					Self = self, Value = value, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drop", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkDropTargetSignalStructs.EnterSignal> Signal_Enter(this GtkDropTargetHandle instance)
	{
		return Observable.Create((IObserver<GtkDropTargetSignalStructs.EnterSignal> obs) =>
		{
			GtkDropTargetSignalDelegates.Enter handler = (GtkDropTargetHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropTargetSignalStructs.EnterSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "enter", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkDropTargetSignalStructs.LeaveSignal> Signal_Leave(this GtkDropTargetHandle instance)
	{
		return Observable.Create((IObserver<GtkDropTargetSignalStructs.LeaveSignal> obs) =>
		{
			GtkDropTargetSignalDelegates.Leave handler = (GtkDropTargetHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropTargetSignalStructs.LeaveSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkDropTargetSignalStructs.MotionSignal> Signal_Motion(this GtkDropTargetHandle instance)
	{
		return Observable.Create((IObserver<GtkDropTargetSignalStructs.MotionSignal> obs) =>
		{
			GtkDropTargetSignalDelegates.Motion handler = (GtkDropTargetHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropTargetSignalStructs.MotionSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkDropTargetSignalStructs
{

public struct AcceptSignal
{
	public GtkDropTargetHandle Self;
	public GdkDropHandle Drop;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct DropSignal
{
	public GtkDropTargetHandle Self;
	public GValueHandle Value;
	public double X;
	public double Y;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct EnterSignal
{
	public GtkDropTargetHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
	public GdkDragAction ReturnValue;
}

public struct LeaveSignal
{
	public GtkDropTargetHandle Self;
	public IntPtr UserData;
}

public struct MotionSignal
{
	public GtkDropTargetHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
	public GdkDragAction ReturnValue;
}
}

public static class GtkDropTargetSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Accept([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetHandle>))] GtkDropTargetHandle self, GdkDropHandle drop, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Drop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetHandle>))] GtkDropTargetHandle self, GValueHandle value, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GdkDragAction Enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetHandle>))] GtkDropTargetHandle self, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetHandle>))] GtkDropTargetHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GdkDragAction Motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetHandle>))] GtkDropTargetHandle self, double x, double y, IntPtr user_data);
}


public static class GtkDropTargetHandleExtensions
{
	public static GdkDragAction GetActions(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_actions(self);
	}

	public static GdkDropHandle GetCurrentDrop(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_current_drop(self);
	}

	public static GdkDropHandle GetDrop(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_drop(self);
	}

	public static GdkContentFormatsHandle GetFormats(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_formats(self);
	}

	public static GType[] GetGtypes(this GtkDropTargetHandle self, out int n_types)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_gtypes(self, out n_types);
	}

	public static bool GetPreload(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_preload(self);
	}

	public static GValueHandle GetValue(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_value(self);
	}

	public static GtkDropTargetHandle Reject(this GtkDropTargetHandle self)
	{
		GtkDropTargetExterns.gtk_drop_target_reject(self);
		return self;
	}

	public static GtkDropTargetHandle SetActions(this GtkDropTargetHandle self, GdkDragAction actions)
	{
		GtkDropTargetExterns.gtk_drop_target_set_actions(self, actions);
		return self;
	}

	public static GtkDropTargetHandle SetGtypes(this GtkDropTargetHandle self, GType[] types, int n_types)
	{
		GtkDropTargetExterns.gtk_drop_target_set_gtypes(self, types, n_types);
		return self;
	}

	public static GtkDropTargetHandle SetPreload(this GtkDropTargetHandle self, bool preload)
	{
		GtkDropTargetExterns.gtk_drop_target_set_preload(self, preload);
		return self;
	}

}

internal class GtkDropTargetExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDropTargetHandle gtk_drop_target_new(GType type, GdkDragAction actions);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDragAction gtk_drop_target_get_actions(GtkDropTargetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDropHandle gtk_drop_target_get_current_drop(GtkDropTargetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDropHandle gtk_drop_target_get_drop(GtkDropTargetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkContentFormatsHandle gtk_drop_target_get_formats(GtkDropTargetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GType[] gtk_drop_target_get_gtypes(GtkDropTargetHandle self, out int n_types);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_drop_target_get_preload(GtkDropTargetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GValueHandle gtk_drop_target_get_value(GtkDropTargetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_reject(GtkDropTargetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_set_actions(GtkDropTargetHandle self, GdkDragAction actions);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_set_gtypes(GtkDropTargetHandle self, GType[] types, int n_types);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_set_preload(GtkDropTargetHandle self, bool preload);

}
