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

namespace MentorLake.Gtk4.GObject;

public class GSignalGroupHandle : GObjectHandle
{
	public static GSignalGroupHandle New(GType target_type)
	{
		return GSignalGroupExterns.g_signal_group_new(target_type);
	}

}

public static class GSignalGroupSignalExtensions
{

	public static IObservable<GSignalGroupSignalStructs.BindSignal> Signal_Bind(this GSignalGroupHandle instance)
	{
		return Observable.Create((IObserver<GSignalGroupSignalStructs.BindSignal> obs) =>
		{
			GSignalGroupSignalDelegates.Bind handler = (GSignalGroupHandle self, GObjectHandle instance, IntPtr user_data) =>
			{
				

				var signalStruct = new GSignalGroupSignalStructs.BindSignal()
				{
					Self = self, Instance = instance, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "bind", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GSignalGroupSignalStructs.UnbindSignal> Signal_Unbind(this GSignalGroupHandle instance)
	{
		return Observable.Create((IObserver<GSignalGroupSignalStructs.UnbindSignal> obs) =>
		{
			GSignalGroupSignalDelegates.Unbind handler = (GSignalGroupHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GSignalGroupSignalStructs.UnbindSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "unbind", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GSignalGroupSignalStructs
{

public struct BindSignal
{
	public GSignalGroupHandle Self;
	public GObjectHandle Instance;
	public IntPtr UserData;
}

public struct UnbindSignal
{
	public GSignalGroupHandle Self;
	public IntPtr UserData;
}
}

public static class GSignalGroupSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Bind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSignalGroupHandle>))] GSignalGroupHandle self, GObjectHandle instance, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Unbind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSignalGroupHandle>))] GSignalGroupHandle self, IntPtr user_data);
}


public static class GSignalGroupHandleExtensions
{
	public static GSignalGroupHandle Block(this GSignalGroupHandle self)
	{
		GSignalGroupExterns.g_signal_group_block(self);
		return self;
	}

	public static GSignalGroupHandle Connect(this GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr data)
	{
		GSignalGroupExterns.g_signal_group_connect(self, detailed_signal, c_handler, data);
		return self;
	}

	public static GSignalGroupHandle ConnectAfter(this GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr data)
	{
		GSignalGroupExterns.g_signal_group_connect_after(self, detailed_signal, c_handler, data);
		return self;
	}

	public static GSignalGroupHandle ConnectClosure(this GSignalGroupHandle self, string detailed_signal, GClosureHandle closure, bool after)
	{
		GSignalGroupExterns.g_signal_group_connect_closure(self, detailed_signal, closure, after);
		return self;
	}

	public static GSignalGroupHandle ConnectData(this GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr data, GClosureNotify notify, GConnectFlags flags)
	{
		GSignalGroupExterns.g_signal_group_connect_data(self, detailed_signal, c_handler, data, notify, flags);
		return self;
	}

	public static GSignalGroupHandle ConnectObject(this GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr @object, GConnectFlags flags)
	{
		GSignalGroupExterns.g_signal_group_connect_object(self, detailed_signal, c_handler, @object, flags);
		return self;
	}

	public static GSignalGroupHandle ConnectSwapped(this GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr data)
	{
		GSignalGroupExterns.g_signal_group_connect_swapped(self, detailed_signal, c_handler, data);
		return self;
	}

	public static GObjectHandle DupTarget(this GSignalGroupHandle self)
	{
		return GSignalGroupExterns.g_signal_group_dup_target(self);
	}

	public static GSignalGroupHandle SetTarget(this GSignalGroupHandle self, GObjectHandle target)
	{
		GSignalGroupExterns.g_signal_group_set_target(self, target);
		return self;
	}

	public static GSignalGroupHandle Unblock(this GSignalGroupHandle self)
	{
		GSignalGroupExterns.g_signal_group_unblock(self);
		return self;
	}

}

internal class GSignalGroupExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GSignalGroupHandle g_signal_group_new(GType target_type);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_block(GSignalGroupHandle self);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect(GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_after(GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_closure(GSignalGroupHandle self, string detailed_signal, GClosureHandle closure, bool after);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_data(GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr data, GClosureNotify notify, GConnectFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_object(GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr @object, GConnectFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_swapped(GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_signal_group_dup_target(GSignalGroupHandle self);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_set_target(GSignalGroupHandle self, GObjectHandle target);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_unblock(GSignalGroupHandle self);

}
