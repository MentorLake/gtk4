using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkEmojiChooserHandle : GtkPopoverHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkShortcutManagerHandle
{
	public static GtkEmojiChooserHandle New()
	{
		return GtkEmojiChooserExterns.gtk_emoji_chooser_new();
	}

}

public class GtkEmojiChooserSignal
{
	public string Value { get; set; }
	public GtkEmojiChooserSignal(string value) => Value = value;
}

public static class GtkEmojiChooserSignals
{
	public static GtkEmojiChooserSignal EmojiPicked = new("BindingTransform.MethodDeclaration");
}

public static class GtkEmojiChooserHandleExtensions
{
	public static GtkEmojiChooserHandle Signal_EmojiPicked(this GtkEmojiChooserHandle instance, GtkEmojiChooserDelegates.EmojiPicked handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "emoji_picked", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkEmojiChooserDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void EmojiPicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEmojiChooserHandle>))] GtkEmojiChooserHandle self, string text, IntPtr user_data);
}

internal class GtkEmojiChooserExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEmojiChooserHandle gtk_emoji_chooser_new();

}
