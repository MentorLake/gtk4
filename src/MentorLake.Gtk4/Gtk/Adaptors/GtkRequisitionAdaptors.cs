using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkRequisitionAdaptors
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
