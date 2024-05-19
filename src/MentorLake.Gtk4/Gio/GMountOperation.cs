namespace MentorLake.Gtk4.Gio;

public class GMountOperationHandle : GObjectHandle
{
	public static GMountOperationHandle New()
	{
		return GMountOperationExterns.g_mount_operation_new();
	}

}

public static class GMountOperationSignalExtensions
{

	public static IObservable<GMountOperationSignalStructs.AbortedSignal> Signal_Aborted(this GMountOperationHandle instance)
	{
		return Observable.Create((IObserver<GMountOperationSignalStructs.AbortedSignal> obs) =>
		{
			GMountOperationSignalDelegates.Aborted handler = (GMountOperationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GMountOperationSignalStructs.AbortedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "aborted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GMountOperationSignalStructs.AskPasswordSignal> Signal_AskPassword(this GMountOperationHandle instance)
	{
		return Observable.Create((IObserver<GMountOperationSignalStructs.AskPasswordSignal> obs) =>
		{
			GMountOperationSignalDelegates.AskPassword handler = (GMountOperationHandle self, string message, string default_user, string default_domain, GAskPasswordFlags flags, IntPtr user_data) =>
			{
				

				var signalStruct = new GMountOperationSignalStructs.AskPasswordSignal()
				{
					Self = self, Message = message, DefaultUser = default_user, DefaultDomain = default_domain, Flags = flags, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "ask_password", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GMountOperationSignalStructs.AskQuestionSignal> Signal_AskQuestion(this GMountOperationHandle instance)
	{
		return Observable.Create((IObserver<GMountOperationSignalStructs.AskQuestionSignal> obs) =>
		{
			GMountOperationSignalDelegates.AskQuestion handler = (GMountOperationHandle self, string message, string[] choices, IntPtr user_data) =>
			{
				

				var signalStruct = new GMountOperationSignalStructs.AskQuestionSignal()
				{
					Self = self, Message = message, Choices = choices, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "ask_question", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GMountOperationSignalStructs.ReplySignal> Signal_Reply(this GMountOperationHandle instance)
	{
		return Observable.Create((IObserver<GMountOperationSignalStructs.ReplySignal> obs) =>
		{
			GMountOperationSignalDelegates.Reply handler = (GMountOperationHandle self, GMountOperationResult result, IntPtr user_data) =>
			{
				

				var signalStruct = new GMountOperationSignalStructs.ReplySignal()
				{
					Self = self, Result = result, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "reply", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GMountOperationSignalStructs.ShowProcessesSignal> Signal_ShowProcesses(this GMountOperationHandle instance)
	{
		return Observable.Create((IObserver<GMountOperationSignalStructs.ShowProcessesSignal> obs) =>
		{
			GMountOperationSignalDelegates.ShowProcesses handler = (GMountOperationHandle self, string message, GPid[] processes, string[] choices, IntPtr user_data) =>
			{
				

				var signalStruct = new GMountOperationSignalStructs.ShowProcessesSignal()
				{
					Self = self, Message = message, Processes = processes, Choices = choices, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "show_processes", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GMountOperationSignalStructs.ShowUnmountProgressSignal> Signal_ShowUnmountProgress(this GMountOperationHandle instance)
	{
		return Observable.Create((IObserver<GMountOperationSignalStructs.ShowUnmountProgressSignal> obs) =>
		{
			GMountOperationSignalDelegates.ShowUnmountProgress handler = (GMountOperationHandle self, string message, long time_left, long bytes_left, IntPtr user_data) =>
			{
				

				var signalStruct = new GMountOperationSignalStructs.ShowUnmountProgressSignal()
				{
					Self = self, Message = message, TimeLeft = time_left, BytesLeft = bytes_left, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "show_unmount_progress", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GMountOperationSignalStructs
{

public struct AbortedSignal
{
	public GMountOperationHandle Self;
	public IntPtr UserData;
}

public struct AskPasswordSignal
{
	public GMountOperationHandle Self;
	public string Message;
	public string DefaultUser;
	public string DefaultDomain;
	public GAskPasswordFlags Flags;
	public IntPtr UserData;
}

public struct AskQuestionSignal
{
	public GMountOperationHandle Self;
	public string Message;
	public string[] Choices;
	public IntPtr UserData;
}

public struct ReplySignal
{
	public GMountOperationHandle Self;
	public GMountOperationResult Result;
	public IntPtr UserData;
}

public struct ShowProcessesSignal
{
	public GMountOperationHandle Self;
	public string Message;
	public GPid[] Processes;
	public string[] Choices;
	public IntPtr UserData;
}

public struct ShowUnmountProgressSignal
{
	public GMountOperationHandle Self;
	public string Message;
	public long TimeLeft;
	public long BytesLeft;
	public IntPtr UserData;
}
}

public static class GMountOperationSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Aborted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GMountOperationHandle>))] GMountOperationHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AskPassword([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GMountOperationHandle>))] GMountOperationHandle self, string message, string default_user, string default_domain, GAskPasswordFlags flags, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AskQuestion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GMountOperationHandle>))] GMountOperationHandle self, string message, string[] choices, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Reply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GMountOperationHandle>))] GMountOperationHandle self, GMountOperationResult result, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ShowProcesses([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GMountOperationHandle>))] GMountOperationHandle self, string message, GPid[] processes, string[] choices, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ShowUnmountProgress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GMountOperationHandle>))] GMountOperationHandle self, string message, long time_left, long bytes_left, IntPtr user_data);
}


public static class GMountOperationHandleExtensions
{
	public static bool GetAnonymous(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_anonymous(op);
	}

	public static int GetChoice(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_choice(op);
	}

	public static string GetDomain(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_domain(op);
	}

	public static bool GetIsTcryptHiddenVolume(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_is_tcrypt_hidden_volume(op);
	}

	public static bool GetIsTcryptSystemVolume(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_is_tcrypt_system_volume(op);
	}

	public static string GetPassword(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_password(op);
	}

	public static GPasswordSave GetPasswordSave(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_password_save(op);
	}

	public static uint GetPim(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_pim(op);
	}

	public static string GetUsername(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_username(op);
	}

	public static GMountOperationHandle Reply(this GMountOperationHandle op, GMountOperationResult result)
	{
		GMountOperationExterns.g_mount_operation_reply(op, result);
		return op;
	}

	public static GMountOperationHandle SetAnonymous(this GMountOperationHandle op, bool anonymous)
	{
		GMountOperationExterns.g_mount_operation_set_anonymous(op, anonymous);
		return op;
	}

	public static GMountOperationHandle SetChoice(this GMountOperationHandle op, int choice)
	{
		GMountOperationExterns.g_mount_operation_set_choice(op, choice);
		return op;
	}

	public static GMountOperationHandle SetDomain(this GMountOperationHandle op, string domain)
	{
		GMountOperationExterns.g_mount_operation_set_domain(op, domain);
		return op;
	}

	public static GMountOperationHandle SetIsTcryptHiddenVolume(this GMountOperationHandle op, bool hidden_volume)
	{
		GMountOperationExterns.g_mount_operation_set_is_tcrypt_hidden_volume(op, hidden_volume);
		return op;
	}

	public static GMountOperationHandle SetIsTcryptSystemVolume(this GMountOperationHandle op, bool system_volume)
	{
		GMountOperationExterns.g_mount_operation_set_is_tcrypt_system_volume(op, system_volume);
		return op;
	}

	public static GMountOperationHandle SetPassword(this GMountOperationHandle op, string password)
	{
		GMountOperationExterns.g_mount_operation_set_password(op, password);
		return op;
	}

	public static GMountOperationHandle SetPasswordSave(this GMountOperationHandle op, GPasswordSave save)
	{
		GMountOperationExterns.g_mount_operation_set_password_save(op, save);
		return op;
	}

	public static GMountOperationHandle SetPim(this GMountOperationHandle op, uint pim)
	{
		GMountOperationExterns.g_mount_operation_set_pim(op, pim);
		return op;
	}

	public static GMountOperationHandle SetUsername(this GMountOperationHandle op, string username)
	{
		GMountOperationExterns.g_mount_operation_set_username(op, username);
		return op;
	}

}

internal class GMountOperationExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GMountOperationHandle g_mount_operation_new();

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_operation_get_anonymous(GMountOperationHandle op);

	[DllImport(Libraries.Gio)]
	internal static extern int g_mount_operation_get_choice(GMountOperationHandle op);

	[DllImport(Libraries.Gio)]
	internal static extern string g_mount_operation_get_domain(GMountOperationHandle op);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_operation_get_is_tcrypt_hidden_volume(GMountOperationHandle op);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_operation_get_is_tcrypt_system_volume(GMountOperationHandle op);

	[DllImport(Libraries.Gio)]
	internal static extern string g_mount_operation_get_password(GMountOperationHandle op);

	[DllImport(Libraries.Gio)]
	internal static extern GPasswordSave g_mount_operation_get_password_save(GMountOperationHandle op);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_mount_operation_get_pim(GMountOperationHandle op);

	[DllImport(Libraries.Gio)]
	internal static extern string g_mount_operation_get_username(GMountOperationHandle op);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_reply(GMountOperationHandle op, GMountOperationResult result);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_anonymous(GMountOperationHandle op, bool anonymous);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_choice(GMountOperationHandle op, int choice);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_domain(GMountOperationHandle op, string domain);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_is_tcrypt_hidden_volume(GMountOperationHandle op, bool hidden_volume);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_is_tcrypt_system_volume(GMountOperationHandle op, bool system_volume);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_password(GMountOperationHandle op, string password);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_password_save(GMountOperationHandle op, GPasswordSave save);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_pim(GMountOperationHandle op, uint pim);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_username(GMountOperationHandle op, string username);

}
