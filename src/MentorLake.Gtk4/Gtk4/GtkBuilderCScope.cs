namespace MentorLake.Gtk4.Gtk4;

public class GtkBuilderCScopeHandle : GObjectHandle, GtkBuilderScopeHandle
{
	public static GtkBuilderCScopeHandle GtkBuilderCscopeNew()
	{
		return GtkBuilderCScopeExterns.gtk_builder_cscope_new();
	}

}

public static class GtkBuilderCScopeHandleExtensions
{
	public static GtkBuilderCScopeHandle GtkBuilderCscopeAddCallbackSymbol(this GtkBuilderCScopeHandle self, string callback_name, IntPtr callback_symbol)
	{
		GtkBuilderCScopeExterns.gtk_builder_cscope_add_callback_symbol(self, callback_name, callback_symbol);
		return self;
	}

	public static GtkBuilderCScopeHandle GtkBuilderCscopeAddCallbackSymbols(this GtkBuilderCScopeHandle self, string first_callback_name, IntPtr first_callback_symbol, IntPtr @__arglist)
	{
		GtkBuilderCScopeExterns.gtk_builder_cscope_add_callback_symbols(self, first_callback_name, first_callback_symbol, @__arglist);
		return self;
	}

	public static IntPtr GtkBuilderCscopeLookupCallbackSymbol(this GtkBuilderCScopeHandle self, string callback_name)
	{
		return GtkBuilderCScopeExterns.gtk_builder_cscope_lookup_callback_symbol(self, callback_name);
	}

}

internal class GtkBuilderCScopeExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBuilderCScopeHandle gtk_builder_cscope_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_builder_cscope_add_callback_symbol(GtkBuilderCScopeHandle self, string callback_name, IntPtr callback_symbol);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_builder_cscope_add_callback_symbols(GtkBuilderCScopeHandle self, string first_callback_name, IntPtr first_callback_symbol, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern IntPtr gtk_builder_cscope_lookup_callback_symbol(GtkBuilderCScopeHandle self, string callback_name);

}
