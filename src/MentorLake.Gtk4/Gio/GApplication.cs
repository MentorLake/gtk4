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

namespace MentorLake.Gtk4.Gio;

public class GApplicationHandle : GObjectHandle, GActionGroupHandle, GActionMapHandle
{
	public static GApplicationHandle New(string application_id, GApplicationFlags flags)
	{
		return GApplicationExterns.g_application_new(application_id, flags);
	}

	public static GApplicationHandle GetDefault()
	{
		return GApplicationExterns.g_application_get_default();
	}

	public static bool IdIsValid(string application_id)
	{
		return GApplicationExterns.g_application_id_is_valid(application_id);
	}

}

public static class GApplicationSignalExtensions
{

	public static IObservable<GApplicationSignalStructs.ActivateSignal> Signal_Activate(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.ActivateSignal> obs) =>
		{
			GApplicationSignalDelegates.Activate handler = (GApplicationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GApplicationSignalStructs.CommandLineSignal> Signal_CommandLine(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.CommandLineSignal> obs) =>
		{
			GApplicationSignalDelegates.CommandLine handler = (GApplicationHandle self, GApplicationCommandLineHandle command_line, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.CommandLineSignal()
				{
					Self = self, CommandLine = command_line, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "command_line", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GApplicationSignalStructs.HandleLocalOptionsSignal> Signal_HandleLocalOptions(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.HandleLocalOptionsSignal> obs) =>
		{
			GApplicationSignalDelegates.HandleLocalOptions handler = (GApplicationHandle self, GVariantDictHandle options, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.HandleLocalOptionsSignal()
				{
					Self = self, Options = options, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "handle_local_options", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GApplicationSignalStructs.NameLostSignal> Signal_NameLost(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.NameLostSignal> obs) =>
		{
			GApplicationSignalDelegates.NameLost handler = (GApplicationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.NameLostSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "name_lost", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GApplicationSignalStructs.OpenSignal> Signal_Open(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.OpenSignal> obs) =>
		{
			GApplicationSignalDelegates.Open handler = (GApplicationHandle self, IntPtr files, int n_files, string hint, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.OpenSignal()
				{
					Self = self, Files = files, NFiles = n_files, Hint = hint, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "open", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GApplicationSignalStructs.ShutdownSignal> Signal_Shutdown(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.ShutdownSignal> obs) =>
		{
			GApplicationSignalDelegates.Shutdown handler = (GApplicationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.ShutdownSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "shutdown", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GApplicationSignalStructs.StartupSignal> Signal_Startup(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.StartupSignal> obs) =>
		{
			GApplicationSignalDelegates.Startup handler = (GApplicationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.StartupSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "startup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GApplicationSignalStructs
{

public struct ActivateSignal
{
	public GApplicationHandle Self;
	public IntPtr UserData;
}

public struct CommandLineSignal
{
	public GApplicationHandle Self;
	public GApplicationCommandLineHandle CommandLine;
	public IntPtr UserData;
	public int ReturnValue;
}

public struct HandleLocalOptionsSignal
{
	public GApplicationHandle Self;
	public GVariantDictHandle Options;
	public IntPtr UserData;
	public int ReturnValue;
}

public struct NameLostSignal
{
	public GApplicationHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct OpenSignal
{
	public GApplicationHandle Self;
	public IntPtr Files;
	public int NFiles;
	public string Hint;
	public IntPtr UserData;
}

public struct ShutdownSignal
{
	public GApplicationHandle Self;
	public IntPtr UserData;
}

public struct StartupSignal
{
	public GApplicationHandle Self;
	public IntPtr UserData;
}
}

public static class GApplicationSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int CommandLine([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, GApplicationCommandLineHandle command_line, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int HandleLocalOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, GVariantDictHandle options, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool NameLost([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Open([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, IntPtr files, int n_files, string hint, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Shutdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Startup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, IntPtr user_data);
}


public static class GApplicationHandleExtensions
{
	public static GApplicationHandle Activate(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_activate(application);
		return application;
	}

	public static GApplicationHandle AddMainOption(this GApplicationHandle application, string long_name, char short_name, GOptionFlags flags, GOptionArg arg, string description, string arg_description)
	{
		GApplicationExterns.g_application_add_main_option(application, long_name, short_name, flags, arg, description, arg_description);
		return application;
	}

	public static GApplicationHandle AddMainOptionEntries(this GApplicationHandle application, GOptionEntry[] entries)
	{
		GApplicationExterns.g_application_add_main_option_entries(application, entries);
		return application;
	}

	public static GApplicationHandle AddOptionGroup(this GApplicationHandle application, GOptionGroupHandle group)
	{
		GApplicationExterns.g_application_add_option_group(application, group);
		return application;
	}

	public static GApplicationHandle BindBusyProperty(this GApplicationHandle application, GObjectHandle @object, string property)
	{
		GApplicationExterns.g_application_bind_busy_property(application, @object, property);
		return application;
	}

	public static string GetApplicationId(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_application_id(application);
	}

	public static GDBusConnectionHandle GetDbusConnection(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_dbus_connection(application);
	}

	public static string GetDbusObjectPath(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_dbus_object_path(application);
	}

	public static GApplicationFlags GetFlags(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_flags(application);
	}

	public static uint GetInactivityTimeout(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_inactivity_timeout(application);
	}

	public static bool GetIsBusy(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_is_busy(application);
	}

	public static bool GetIsRegistered(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_is_registered(application);
	}

	public static bool GetIsRemote(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_is_remote(application);
	}

	public static string GetResourceBasePath(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_resource_base_path(application);
	}

	public static string GetVersion(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_version(application);
	}

	public static GApplicationHandle Hold(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_hold(application);
		return application;
	}

	public static GApplicationHandle MarkBusy(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_mark_busy(application);
		return application;
	}

	public static GApplicationHandle Open(this GApplicationHandle application, GFileHandle[] files, int n_files, string hint)
	{
		GApplicationExterns.g_application_open(application, files, n_files, hint);
		return application;
	}

	public static GApplicationHandle Quit(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_quit(application);
		return application;
	}

	public static bool Register(this GApplicationHandle application, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GApplicationExterns.g_application_register(application, cancellable, out error);
	}

	public static GApplicationHandle Release(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_release(application);
		return application;
	}

	public static int Run(this GApplicationHandle application, int argc, string[] argv)
	{
		return GApplicationExterns.g_application_run(application, argc, argv);
	}

	public static GApplicationHandle SendNotification(this GApplicationHandle application, string id, GNotificationHandle notification)
	{
		GApplicationExterns.g_application_send_notification(application, id, notification);
		return application;
	}

	public static GApplicationHandle SetActionGroup(this GApplicationHandle application, GActionGroupHandle action_group)
	{
		GApplicationExterns.g_application_set_action_group(application, action_group);
		return application;
	}

	public static GApplicationHandle SetApplicationId(this GApplicationHandle application, string application_id)
	{
		GApplicationExterns.g_application_set_application_id(application, application_id);
		return application;
	}

	public static GApplicationHandle SetDefault(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_set_default(application);
		return application;
	}

	public static GApplicationHandle SetFlags(this GApplicationHandle application, GApplicationFlags flags)
	{
		GApplicationExterns.g_application_set_flags(application, flags);
		return application;
	}

	public static GApplicationHandle SetInactivityTimeout(this GApplicationHandle application, uint inactivity_timeout)
	{
		GApplicationExterns.g_application_set_inactivity_timeout(application, inactivity_timeout);
		return application;
	}

	public static GApplicationHandle SetOptionContextDescription(this GApplicationHandle application, string description)
	{
		GApplicationExterns.g_application_set_option_context_description(application, description);
		return application;
	}

	public static GApplicationHandle SetOptionContextParameterString(this GApplicationHandle application, string parameter_string)
	{
		GApplicationExterns.g_application_set_option_context_parameter_string(application, parameter_string);
		return application;
	}

	public static GApplicationHandle SetOptionContextSummary(this GApplicationHandle application, string summary)
	{
		GApplicationExterns.g_application_set_option_context_summary(application, summary);
		return application;
	}

	public static GApplicationHandle SetResourceBasePath(this GApplicationHandle application, string resource_path)
	{
		GApplicationExterns.g_application_set_resource_base_path(application, resource_path);
		return application;
	}

	public static GApplicationHandle SetVersion(this GApplicationHandle application, string version)
	{
		GApplicationExterns.g_application_set_version(application, version);
		return application;
	}

	public static GApplicationHandle UnbindBusyProperty(this GApplicationHandle application, GObjectHandle @object, string property)
	{
		GApplicationExterns.g_application_unbind_busy_property(application, @object, property);
		return application;
	}

	public static GApplicationHandle UnmarkBusy(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_unmark_busy(application);
		return application;
	}

	public static GApplicationHandle WithdrawNotification(this GApplicationHandle application, string id)
	{
		GApplicationExterns.g_application_withdraw_notification(application, id);
		return application;
	}

}

internal class GApplicationExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GApplicationHandle g_application_new(string application_id, GApplicationFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_activate(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_add_main_option(GApplicationHandle application, string long_name, char short_name, GOptionFlags flags, GOptionArg arg, string description, string arg_description);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_add_main_option_entries(GApplicationHandle application, GOptionEntry[] entries);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_add_option_group(GApplicationHandle application, GOptionGroupHandle group);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_bind_busy_property(GApplicationHandle application, GObjectHandle @object, string property);

	[DllImport(Libraries.Gio)]
	internal static extern string g_application_get_application_id(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_application_get_dbus_connection(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern string g_application_get_dbus_object_path(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern GApplicationFlags g_application_get_flags(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_application_get_inactivity_timeout(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_get_is_busy(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_get_is_registered(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_get_is_remote(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern string g_application_get_resource_base_path(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern string g_application_get_version(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_hold(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_mark_busy(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_open(GApplicationHandle application, GFileHandle[] files, int n_files, string hint);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_quit(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_register(GApplicationHandle application, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_release(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern int g_application_run(GApplicationHandle application, int argc, string[] argv);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_send_notification(GApplicationHandle application, string id, GNotificationHandle notification);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_action_group(GApplicationHandle application, GActionGroupHandle action_group);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_application_id(GApplicationHandle application, string application_id);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_default(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_flags(GApplicationHandle application, GApplicationFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_inactivity_timeout(GApplicationHandle application, uint inactivity_timeout);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_option_context_description(GApplicationHandle application, string description);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_option_context_parameter_string(GApplicationHandle application, string parameter_string);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_option_context_summary(GApplicationHandle application, string summary);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_resource_base_path(GApplicationHandle application, string resource_path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_version(GApplicationHandle application, string version);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_unbind_busy_property(GApplicationHandle application, GObjectHandle @object, string property);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_unmark_busy(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_withdraw_notification(GApplicationHandle application, string id);

	[DllImport(Libraries.Gio)]
	internal static extern GApplicationHandle g_application_get_default();

	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_id_is_valid(string application_id);

}
