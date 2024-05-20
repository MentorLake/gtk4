namespace MentorLake.Gtk4.Gtk4;

public class GtkEntryBufferHandle : GObjectHandle
{
	public static GtkEntryBufferHandle New(string initial_chars, int n_initial_chars)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_new(initial_chars, n_initial_chars);
	}

}

public static class GtkEntryBufferSignalExtensions
{

	public static IObservable<GtkEntryBufferSignalStructs.DeletedTextSignal> Signal_DeletedText(this GtkEntryBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkEntryBufferSignalStructs.DeletedTextSignal> obs) =>
		{
			GtkEntryBufferSignalDelegates.deleted_text handler = (GtkEntryBufferHandle self, uint position, uint n_chars, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryBufferSignalStructs.DeletedTextSignal()
				{
					Self = self, Position = position, NChars = n_chars, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "deleted_text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntryBufferSignalStructs.InsertedTextSignal> Signal_InsertedText(this GtkEntryBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkEntryBufferSignalStructs.InsertedTextSignal> obs) =>
		{
			GtkEntryBufferSignalDelegates.inserted_text handler = (GtkEntryBufferHandle self, uint position, string chars, uint n_chars, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryBufferSignalStructs.InsertedTextSignal()
				{
					Self = self, Position = position, Chars = chars, NChars = n_chars, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "inserted_text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkEntryBufferSignalStructs
{

public struct DeletedTextSignal
{
	public GtkEntryBufferHandle Self;
	public uint Position;
	public uint NChars;
	public IntPtr UserData;
}

public struct InsertedTextSignal
{
	public GtkEntryBufferHandle Self;
	public uint Position;
	public string Chars;
	public uint NChars;
	public IntPtr UserData;
}
}

public static class GtkEntryBufferSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deleted_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryBufferHandle>))] GtkEntryBufferHandle self, uint position, uint n_chars, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void inserted_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryBufferHandle>))] GtkEntryBufferHandle self, uint position, string chars, uint n_chars, IntPtr user_data);

}


public static class GtkEntryBufferHandleExtensions
{
	public static uint DeleteText(this GtkEntryBufferHandle buffer, uint position, int n_chars)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_delete_text(buffer, position, n_chars);
	}

	public static GtkEntryBufferHandle EmitDeletedText(this GtkEntryBufferHandle buffer, uint position, uint n_chars)
	{
		GtkEntryBufferExterns.gtk_entry_buffer_emit_deleted_text(buffer, position, n_chars);
		return buffer;
	}

	public static GtkEntryBufferHandle EmitInsertedText(this GtkEntryBufferHandle buffer, uint position, string chars, uint n_chars)
	{
		GtkEntryBufferExterns.gtk_entry_buffer_emit_inserted_text(buffer, position, chars, n_chars);
		return buffer;
	}

	public static UIntPtr GetBytes(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_get_bytes(buffer);
	}

	public static uint GetLength(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_get_length(buffer);
	}

	public static int GetMaxLength(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_get_max_length(buffer);
	}

	public static string GetText(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_get_text(buffer);
	}

	public static uint InsertText(this GtkEntryBufferHandle buffer, uint position, string chars, int n_chars)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_insert_text(buffer, position, chars, n_chars);
	}

	public static GtkEntryBufferHandle SetMaxLength(this GtkEntryBufferHandle buffer, int max_length)
	{
		GtkEntryBufferExterns.gtk_entry_buffer_set_max_length(buffer, max_length);
		return buffer;
	}

	public static GtkEntryBufferHandle SetText(this GtkEntryBufferHandle buffer, string chars, int n_chars)
	{
		GtkEntryBufferExterns.gtk_entry_buffer_set_text(buffer, chars, n_chars);
		return buffer;
	}

}

internal class GtkEntryBufferExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEntryBufferHandle gtk_entry_buffer_new(string initial_chars, int n_initial_chars);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_entry_buffer_delete_text(GtkEntryBufferHandle buffer, uint position, int n_chars);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_buffer_emit_deleted_text(GtkEntryBufferHandle buffer, uint position, uint n_chars);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_buffer_emit_inserted_text(GtkEntryBufferHandle buffer, uint position, string chars, uint n_chars);

	[DllImport(Libraries.Gtk4)]
	internal static extern UIntPtr gtk_entry_buffer_get_bytes(GtkEntryBufferHandle buffer);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_entry_buffer_get_length(GtkEntryBufferHandle buffer);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_entry_buffer_get_max_length(GtkEntryBufferHandle buffer);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_buffer_get_text(GtkEntryBufferHandle buffer);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_entry_buffer_insert_text(GtkEntryBufferHandle buffer, uint position, string chars, int n_chars);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_buffer_set_max_length(GtkEntryBufferHandle buffer, int max_length);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_buffer_set_text(GtkEntryBufferHandle buffer, string chars, int n_chars);

}
