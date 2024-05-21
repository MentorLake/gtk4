namespace MentorLake.Gtk4.Pango;

public class PangoAttributeHandle : BaseSafeHandle
{
}


public static class PangoAttributeHandleExtensions
{
	public static PangoAttrColorHandle AsColor(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_color(attr);
	}

	public static PangoAttrFloatHandle AsFloat(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_float(attr);
	}

	public static PangoAttrFontDescHandle AsFontDesc(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_font_desc(attr);
	}

	public static PangoAttrFontFeaturesHandle AsFontFeatures(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_font_features(attr);
	}

	public static PangoAttrIntHandle AsInt(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_int(attr);
	}

	public static PangoAttrLanguageHandle AsLanguage(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_language(attr);
	}

	public static PangoAttrShapeHandle AsShape(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_shape(attr);
	}

	public static PangoAttrSizeHandle AsSize(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_size(attr);
	}

	public static PangoAttrStringHandle AsString(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_string(attr);
	}

	public static PangoAttributeHandle Copy(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_copy(attr);
	}

	public static PangoAttributeHandle Destroy(this PangoAttributeHandle attr)
	{
		PangoAttributeExterns.pango_attribute_destroy(attr);
		return attr;
	}

	public static bool Equal(this PangoAttributeHandle attr1, PangoAttributeHandle attr2)
	{
		return PangoAttributeExterns.pango_attribute_equal(attr1, attr2);
	}

	public static PangoAttributeHandle Init(this PangoAttributeHandle attr, PangoAttrClassHandle klass)
	{
		PangoAttributeExterns.pango_attribute_init(attr, klass);
		return attr;
	}

}
internal class PangoAttributeExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrColorHandle pango_attribute_as_color(PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrFloatHandle pango_attribute_as_float(PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrFontDescHandle pango_attribute_as_font_desc(PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrFontFeaturesHandle pango_attribute_as_font_features(PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrIntHandle pango_attribute_as_int(PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrLanguageHandle pango_attribute_as_language(PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrShapeHandle pango_attribute_as_shape(PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrSizeHandle pango_attribute_as_size(PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrStringHandle pango_attribute_as_string(PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attribute_copy(PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attribute_destroy(PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_attribute_equal(PangoAttributeHandle attr1, PangoAttributeHandle attr2);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attribute_init(PangoAttributeHandle attr, PangoAttrClassHandle klass);

}

public struct PangoAttribute
{
	public PangoAttrClass[] klass;
	public uint start_index;
	public uint end_index;
}
