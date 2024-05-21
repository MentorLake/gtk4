namespace MentorLake.Gtk4.Gtk4;

public class GtkRequisitionHandle : BaseSafeHandle
{
	public static GtkRequisitionHandle New()
	{
		return GtkRequisitionExterns.gtk_requisition_new();
	}

}


public static class GtkRequisitionHandleExtensions
{
	public static GtkRequisitionHandle Copy(this GtkRequisitionHandle requisition)
	{
		return GtkRequisitionExterns.gtk_requisition_copy(requisition);
	}

	public static GtkRequisitionHandle Free(this GtkRequisitionHandle requisition)
	{
		GtkRequisitionExterns.gtk_requisition_free(requisition);
		return requisition;
	}

}
internal class GtkRequisitionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkRequisitionHandle gtk_requisition_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkRequisitionHandle gtk_requisition_copy(GtkRequisitionHandle requisition);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_requisition_free(GtkRequisitionHandle requisition);

}

public struct GtkRequisition
{
	public int width;
	public int height;
}
