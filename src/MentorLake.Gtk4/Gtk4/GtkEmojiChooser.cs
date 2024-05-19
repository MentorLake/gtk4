namespace MentorLake.Gtk4.Gtk4;

public class GtkEmojiChooserHandle : GtkPopoverHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkShortcutManagerHandle
{
	public static GtkEmojiChooserHandle New()
	{
		return GtkEmojiChooserExterns.gtk_emoji_chooser_new();
	}

}

public static class GtkEmojiChooserSignalExtensions
{

	public static IObservable<GtkEmojiChooserSignalStructs.EmojiPickedSignal> Signal_EmojiPicked(this GtkEmojiChooserHandle instance)
	{
		return Observable.Create((IObserver<GtkEmojiChooserSignalStructs.EmojiPickedSignal> obs) =>
		{
			GtkEmojiChooserSignalDelegates.EmojiPicked handler = (GtkEmojiChooserHandle self, string text, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEmojiChooserSignalStructs.EmojiPickedSignal()
				{
					Self = self, Text = text, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "emoji_picked", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkEmojiChooserSignalStructs
{

public struct EmojiPickedSignal
{
	public GtkEmojiChooserHandle Self;
	public string Text;
	public IntPtr UserData;
}
}

public static class GtkEmojiChooserSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void EmojiPicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEmojiChooserHandle>))] GtkEmojiChooserHandle self, string text, IntPtr user_data);
}


public static class GtkEmojiChooserHandleExtensions
{
}

internal class GtkEmojiChooserExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEmojiChooserHandle gtk_emoji_chooser_new();

}
