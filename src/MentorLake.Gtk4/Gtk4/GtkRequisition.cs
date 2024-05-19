namespace MentorLake.Gtk4.Gtk4;

public class GtkRequisitionHandle : BaseSafeHandle
{
	public static GtkRequisitionHandle New()
	{
		return GtkRequisitionExterns.gtk_requisition_new();
	}

}

internal class GtkRequisitionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkRequisitionHandle gtk_requisition_new();

}

public struct GtkRequisition
{
	public int width;
	public int height;
}
