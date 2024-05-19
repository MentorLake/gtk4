namespace MentorLake.Gtk4.Gtk4;

public class GtkIMMulticontextHandle : GtkIMContextHandle
{
	public static GtkIMMulticontextHandle GtkImMulticontextNew()
	{
		return GtkIMMulticontextExterns.gtk_im_multicontext_new();
	}

}

public static class GtkIMMulticontextHandleExtensions
{
	public static string GtkImMulticontextGetContextId(this GtkIMMulticontextHandle context)
	{
		return GtkIMMulticontextExterns.gtk_im_multicontext_get_context_id(context);
	}

	public static GtkIMMulticontextHandle GtkImMulticontextSetContextId(this GtkIMMulticontextHandle context, string context_id)
	{
		GtkIMMulticontextExterns.gtk_im_multicontext_set_context_id(context, context_id);
		return context;
	}

}

internal class GtkIMMulticontextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkIMMulticontextHandle gtk_im_multicontext_new();

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_im_multicontext_get_context_id(GtkIMMulticontextHandle context);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_multicontext_set_context_id(GtkIMMulticontextHandle context, string context_id);

}
