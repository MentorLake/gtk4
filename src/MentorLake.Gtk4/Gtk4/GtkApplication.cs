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

public class GtkApplicationHandle : GApplicationHandle, GActionGroupHandle, GActionMapHandle
{
	public static GtkApplicationHandle New(string application_id, GApplicationFlags flags)
	{
		return GtkApplicationExterns.gtk_application_new(application_id, flags);
	}

}

public static class GtkApplicationSignalExtensions
{

	public static IObservable<GtkApplicationSignalStructs.QueryEndSignal> Signal_QueryEnd(this GtkApplicationHandle instance)
	{
		return Observable.Create((IObserver<GtkApplicationSignalStructs.QueryEndSignal> obs) =>
		{
			GtkApplicationSignalDelegates.QueryEnd handler = (GtkApplicationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationSignalStructs.QueryEndSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "query_end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkApplicationSignalStructs.WindowAddedSignal> Signal_WindowAdded(this GtkApplicationHandle instance)
	{
		return Observable.Create((IObserver<GtkApplicationSignalStructs.WindowAddedSignal> obs) =>
		{
			GtkApplicationSignalDelegates.WindowAdded handler = (GtkApplicationHandle self, GtkWindowHandle window, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationSignalStructs.WindowAddedSignal()
				{
					Self = self, Window = window, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "window_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkApplicationSignalStructs.WindowRemovedSignal> Signal_WindowRemoved(this GtkApplicationHandle instance)
	{
		return Observable.Create((IObserver<GtkApplicationSignalStructs.WindowRemovedSignal> obs) =>
		{
			GtkApplicationSignalDelegates.WindowRemoved handler = (GtkApplicationHandle self, GtkWindowHandle window, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationSignalStructs.WindowRemovedSignal()
				{
					Self = self, Window = window, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "window_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkApplicationSignalStructs
{

public struct QueryEndSignal
{
	public GtkApplicationHandle Self;
	public IntPtr UserData;
}

public struct WindowAddedSignal
{
	public GtkApplicationHandle Self;
	public GtkWindowHandle Window;
	public IntPtr UserData;
}

public struct WindowRemovedSignal
{
	public GtkApplicationHandle Self;
	public GtkWindowHandle Window;
	public IntPtr UserData;
}
}

public static class GtkApplicationSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void QueryEnd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkApplicationHandle>))] GtkApplicationHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void WindowAdded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkApplicationHandle>))] GtkApplicationHandle self, GtkWindowHandle window, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void WindowRemoved([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkApplicationHandle>))] GtkApplicationHandle self, GtkWindowHandle window, IntPtr user_data);
}


public static class GtkApplicationHandleExtensions
{
	public static GtkApplicationHandle AddWindow(this GtkApplicationHandle application, GtkWindowHandle window)
	{
		GtkApplicationExterns.gtk_application_add_window(application, window);
		return application;
	}

	public static string[] GetAccelsForAction(this GtkApplicationHandle application, string detailed_action_name)
	{
		return GtkApplicationExterns.gtk_application_get_accels_for_action(application, detailed_action_name);
	}

	public static string[] GetActionsForAccel(this GtkApplicationHandle application, string accel)
	{
		return GtkApplicationExterns.gtk_application_get_actions_for_accel(application, accel);
	}

	public static GtkWindowHandle GetActiveWindow(this GtkApplicationHandle application)
	{
		return GtkApplicationExterns.gtk_application_get_active_window(application);
	}

	public static GMenuHandle GetMenuById(this GtkApplicationHandle application, string id)
	{
		return GtkApplicationExterns.gtk_application_get_menu_by_id(application, id);
	}

	public static GMenuModelHandle GetMenubar(this GtkApplicationHandle application)
	{
		return GtkApplicationExterns.gtk_application_get_menubar(application);
	}

	public static GtkWindowHandle GetWindowById(this GtkApplicationHandle application, uint id)
	{
		return GtkApplicationExterns.gtk_application_get_window_by_id(application, id);
	}

	public static GListHandle GetWindows(this GtkApplicationHandle application)
	{
		return GtkApplicationExterns.gtk_application_get_windows(application);
	}

	public static uint Inhibit(this GtkApplicationHandle application, GtkWindowHandle window, GtkApplicationInhibitFlags flags, string reason)
	{
		return GtkApplicationExterns.gtk_application_inhibit(application, window, flags, reason);
	}

	public static string[] ListActionDescriptions(this GtkApplicationHandle application)
	{
		return GtkApplicationExterns.gtk_application_list_action_descriptions(application);
	}

	public static GtkApplicationHandle RemoveWindow(this GtkApplicationHandle application, GtkWindowHandle window)
	{
		GtkApplicationExterns.gtk_application_remove_window(application, window);
		return application;
	}

	public static GtkApplicationHandle SetAccelsForAction(this GtkApplicationHandle application, string detailed_action_name, string accels)
	{
		GtkApplicationExterns.gtk_application_set_accels_for_action(application, detailed_action_name, accels);
		return application;
	}

	public static GtkApplicationHandle SetMenubar(this GtkApplicationHandle application, GMenuModelHandle menubar)
	{
		GtkApplicationExterns.gtk_application_set_menubar(application, menubar);
		return application;
	}

	public static GtkApplicationHandle Uninhibit(this GtkApplicationHandle application, uint cookie)
	{
		GtkApplicationExterns.gtk_application_uninhibit(application, cookie);
		return application;
	}

}

internal class GtkApplicationExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkApplicationHandle gtk_application_new(string application_id, GApplicationFlags flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_application_add_window(GtkApplicationHandle application, GtkWindowHandle window);

	[DllImport(Libraries.Gtk4)]
	internal static extern string[] gtk_application_get_accels_for_action(GtkApplicationHandle application, string detailed_action_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern string[] gtk_application_get_actions_for_accel(GtkApplicationHandle application, string accel);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWindowHandle gtk_application_get_active_window(GtkApplicationHandle application);

	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuHandle gtk_application_get_menu_by_id(GtkApplicationHandle application, string id);

	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuModelHandle gtk_application_get_menubar(GtkApplicationHandle application);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWindowHandle gtk_application_get_window_by_id(GtkApplicationHandle application, uint id);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_application_get_windows(GtkApplicationHandle application);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_application_inhibit(GtkApplicationHandle application, GtkWindowHandle window, GtkApplicationInhibitFlags flags, string reason);

	[DllImport(Libraries.Gtk4)]
	internal static extern string[] gtk_application_list_action_descriptions(GtkApplicationHandle application);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_application_remove_window(GtkApplicationHandle application, GtkWindowHandle window);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_application_set_accels_for_action(GtkApplicationHandle application, string detailed_action_name, string accels);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_application_set_menubar(GtkApplicationHandle application, GMenuModelHandle menubar);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_application_uninhibit(GtkApplicationHandle application, uint cookie);

}
