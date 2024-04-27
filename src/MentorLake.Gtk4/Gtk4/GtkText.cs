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

public class GtkTextHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAccessibleTextHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkEditableHandle
{
	public static GtkTextHandle New()
	{
		return GtkTextExterns.gtk_text_new();
	}

	public static GtkTextHandle NewWithBuffer(GtkEntryBufferHandle buffer)
	{
		return GtkTextExterns.gtk_text_new_with_buffer(buffer);
	}

}

public static class GtkTextSignalExtensions
{
	public static GtkTextHandle Signal_Activate(this GtkTextHandle instance, GtkTextSignalDelegates.Activate handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkTextHandle Signal_Backspace(this GtkTextHandle instance, GtkTextSignalDelegates.Backspace handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "backspace", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkTextHandle Signal_CopyClipboard(this GtkTextHandle instance, GtkTextSignalDelegates.CopyClipboard handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "copy_clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkTextHandle Signal_CutClipboard(this GtkTextHandle instance, GtkTextSignalDelegates.CutClipboard handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "cut_clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkTextHandle Signal_DeleteFromCursor(this GtkTextHandle instance, GtkTextSignalDelegates.DeleteFromCursor handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "delete_from_cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkTextHandle Signal_InsertAtCursor(this GtkTextHandle instance, GtkTextSignalDelegates.InsertAtCursor handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "insert_at_cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkTextHandle Signal_InsertEmoji(this GtkTextHandle instance, GtkTextSignalDelegates.InsertEmoji handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "insert_emoji", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkTextHandle Signal_MoveCursor(this GtkTextHandle instance, GtkTextSignalDelegates.MoveCursor handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "move_cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkTextHandle Signal_PasteClipboard(this GtkTextHandle instance, GtkTextSignalDelegates.PasteClipboard handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "paste_clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkTextHandle Signal_PreeditChanged(this GtkTextHandle instance, GtkTextSignalDelegates.PreeditChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "preedit_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkTextHandle Signal_ToggleOverwrite(this GtkTextHandle instance, GtkTextSignalDelegates.ToggleOverwrite handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "toggle_overwrite", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkTextSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Backspace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void CopyClipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void CutClipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DeleteFromCursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, ref GtkDeleteType type, int count, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void InsertAtCursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, string @string, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void InsertEmoji([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MoveCursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, ref GtkMovementStep step, int count, bool extend, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void PasteClipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void PreeditChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, string preedit, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ToggleOverwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);
}


public static class GtkTextHandleExtensions
{
	public static GtkTextHandle ComputeCursorExtents(this GtkTextHandle self, int position, out graphene_rect_t strong, out graphene_rect_t weak)
	{
		GtkTextExterns.gtk_text_compute_cursor_extents(self, position, out strong, out weak);
		return self;
	}

	public static bool GetActivatesDefault(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_activates_default(self);
	}

	public static PangoAttrListHandle GetAttributes(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_attributes(self);
	}

	public static GtkEntryBufferHandle GetBuffer(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_buffer(self);
	}

	public static bool GetEnableEmojiCompletion(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_enable_emoji_completion(self);
	}

	public static GMenuModelHandle GetExtraMenu(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_extra_menu(self);
	}

	public static GtkInputHints GetInputHints(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_input_hints(self);
	}

	public static GtkInputPurpose GetInputPurpose(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_input_purpose(self);
	}

	public static char GetInvisibleChar(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_invisible_char(self);
	}

	public static int GetMaxLength(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_max_length(self);
	}

	public static bool GetOverwriteMode(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_overwrite_mode(self);
	}

	public static string GetPlaceholderText(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_placeholder_text(self);
	}

	public static bool GetPropagateTextWidth(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_propagate_text_width(self);
	}

	public static PangoTabArrayHandle GetTabs(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_tabs(self);
	}

	public static ushort GetTextLength(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_text_length(self);
	}

	public static bool GetTruncateMultiline(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_truncate_multiline(self);
	}

	public static bool GetVisibility(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_visibility(self);
	}

	public static bool GrabFocusWithoutSelecting(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_grab_focus_without_selecting(self);
	}

	public static GtkTextHandle SetActivatesDefault(this GtkTextHandle self, bool activates)
	{
		GtkTextExterns.gtk_text_set_activates_default(self, activates);
		return self;
	}

	public static GtkTextHandle SetAttributes(this GtkTextHandle self, PangoAttrListHandle attrs)
	{
		GtkTextExterns.gtk_text_set_attributes(self, attrs);
		return self;
	}

	public static GtkTextHandle SetBuffer(this GtkTextHandle self, GtkEntryBufferHandle buffer)
	{
		GtkTextExterns.gtk_text_set_buffer(self, buffer);
		return self;
	}

	public static GtkTextHandle SetEnableEmojiCompletion(this GtkTextHandle self, bool enable_emoji_completion)
	{
		GtkTextExterns.gtk_text_set_enable_emoji_completion(self, enable_emoji_completion);
		return self;
	}

	public static GtkTextHandle SetExtraMenu(this GtkTextHandle self, GMenuModelHandle model)
	{
		GtkTextExterns.gtk_text_set_extra_menu(self, model);
		return self;
	}

	public static GtkTextHandle SetInputHints(this GtkTextHandle self, GtkInputHints hints)
	{
		GtkTextExterns.gtk_text_set_input_hints(self, hints);
		return self;
	}

	public static GtkTextHandle SetInputPurpose(this GtkTextHandle self, GtkInputPurpose purpose)
	{
		GtkTextExterns.gtk_text_set_input_purpose(self, purpose);
		return self;
	}

	public static GtkTextHandle SetInvisibleChar(this GtkTextHandle self, char ch)
	{
		GtkTextExterns.gtk_text_set_invisible_char(self, ch);
		return self;
	}

	public static GtkTextHandle SetMaxLength(this GtkTextHandle self, int length)
	{
		GtkTextExterns.gtk_text_set_max_length(self, length);
		return self;
	}

	public static GtkTextHandle SetOverwriteMode(this GtkTextHandle self, bool overwrite)
	{
		GtkTextExterns.gtk_text_set_overwrite_mode(self, overwrite);
		return self;
	}

	public static GtkTextHandle SetPlaceholderText(this GtkTextHandle self, string text)
	{
		GtkTextExterns.gtk_text_set_placeholder_text(self, text);
		return self;
	}

	public static GtkTextHandle SetPropagateTextWidth(this GtkTextHandle self, bool propagate_text_width)
	{
		GtkTextExterns.gtk_text_set_propagate_text_width(self, propagate_text_width);
		return self;
	}

	public static GtkTextHandle SetTabs(this GtkTextHandle self, PangoTabArrayHandle tabs)
	{
		GtkTextExterns.gtk_text_set_tabs(self, tabs);
		return self;
	}

	public static GtkTextHandle SetTruncateMultiline(this GtkTextHandle self, bool truncate_multiline)
	{
		GtkTextExterns.gtk_text_set_truncate_multiline(self, truncate_multiline);
		return self;
	}

	public static GtkTextHandle SetVisibility(this GtkTextHandle self, bool visible)
	{
		GtkTextExterns.gtk_text_set_visibility(self, visible);
		return self;
	}

	public static GtkTextHandle UnsetInvisibleChar(this GtkTextHandle self)
	{
		GtkTextExterns.gtk_text_unset_invisible_char(self);
		return self;
	}

}

internal class GtkTextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextHandle gtk_text_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextHandle gtk_text_new_with_buffer(GtkEntryBufferHandle buffer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_compute_cursor_extents(GtkTextHandle self, int position, out graphene_rect_t strong, out graphene_rect_t weak);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_get_activates_default(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoAttrListHandle gtk_text_get_attributes(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEntryBufferHandle gtk_text_get_buffer(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_get_enable_emoji_completion(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuModelHandle gtk_text_get_extra_menu(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputHints gtk_text_get_input_hints(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputPurpose gtk_text_get_input_purpose(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern char gtk_text_get_invisible_char(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_get_max_length(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_get_overwrite_mode(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_text_get_placeholder_text(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_get_propagate_text_width(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoTabArrayHandle gtk_text_get_tabs(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern ushort gtk_text_get_text_length(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_get_truncate_multiline(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_get_visibility(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_grab_focus_without_selecting(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_activates_default(GtkTextHandle self, bool activates);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_attributes(GtkTextHandle self, PangoAttrListHandle attrs);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_buffer(GtkTextHandle self, GtkEntryBufferHandle buffer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_enable_emoji_completion(GtkTextHandle self, bool enable_emoji_completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_extra_menu(GtkTextHandle self, GMenuModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_input_hints(GtkTextHandle self, GtkInputHints hints);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_input_purpose(GtkTextHandle self, GtkInputPurpose purpose);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_invisible_char(GtkTextHandle self, char ch);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_max_length(GtkTextHandle self, int length);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_overwrite_mode(GtkTextHandle self, bool overwrite);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_placeholder_text(GtkTextHandle self, string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_propagate_text_width(GtkTextHandle self, bool propagate_text_width);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_tabs(GtkTextHandle self, PangoTabArrayHandle tabs);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_truncate_multiline(GtkTextHandle self, bool truncate_multiline);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_visibility(GtkTextHandle self, bool visible);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_unset_invisible_char(GtkTextHandle self);

}
