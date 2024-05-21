namespace MentorLake.Gtk4.Pango;

public class PangoFontDescriptionHandle : BaseSafeHandle
{
	public static PangoFontDescriptionHandle New()
	{
		return PangoFontDescriptionExterns.pango_font_description_new();
	}

}


public static class PangoFontDescriptionHandleExtensions
{
	public static bool BetterMatch(this PangoFontDescriptionHandle desc, PangoFontDescriptionHandle old_match, PangoFontDescriptionHandle new_match)
	{
		return PangoFontDescriptionExterns.pango_font_description_better_match(desc, old_match, new_match);
	}

	public static PangoFontDescriptionHandle Copy(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_copy(desc);
	}

	public static PangoFontDescriptionHandle CopyStatic(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_copy_static(desc);
	}

	public static bool Equal(this PangoFontDescriptionHandle desc1, PangoFontDescriptionHandle desc2)
	{
		return PangoFontDescriptionExterns.pango_font_description_equal(desc1, desc2);
	}

	public static PangoFontDescriptionHandle Free(this PangoFontDescriptionHandle desc)
	{
		PangoFontDescriptionExterns.pango_font_description_free(desc);
		return desc;
	}

	public static string GetFamily(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_family(desc);
	}

	public static PangoGravity GetGravity(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_gravity(desc);
	}

	public static PangoFontMask GetSetFields(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_set_fields(desc);
	}

	public static int GetSize(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_size(desc);
	}

	public static bool GetSizeIsAbsolute(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_size_is_absolute(desc);
	}

	public static PangoStretch GetStretch(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_stretch(desc);
	}

	public static PangoStyle GetStyle(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_style(desc);
	}

	public static PangoVariant GetVariant(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_variant(desc);
	}

	public static string GetVariations(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_variations(desc);
	}

	public static PangoWeight GetWeight(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_weight(desc);
	}

	public static uint Hash(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_hash(desc);
	}

	public static PangoFontDescriptionHandle Merge(this PangoFontDescriptionHandle desc, PangoFontDescriptionHandle desc_to_merge, bool replace_existing)
	{
		PangoFontDescriptionExterns.pango_font_description_merge(desc, desc_to_merge, replace_existing);
		return desc;
	}

	public static PangoFontDescriptionHandle MergeStatic(this PangoFontDescriptionHandle desc, PangoFontDescriptionHandle desc_to_merge, bool replace_existing)
	{
		PangoFontDescriptionExterns.pango_font_description_merge_static(desc, desc_to_merge, replace_existing);
		return desc;
	}

	public static PangoFontDescriptionHandle SetAbsoluteSize(this PangoFontDescriptionHandle desc, double size)
	{
		PangoFontDescriptionExterns.pango_font_description_set_absolute_size(desc, size);
		return desc;
	}

	public static PangoFontDescriptionHandle SetFamily(this PangoFontDescriptionHandle desc, string family)
	{
		PangoFontDescriptionExterns.pango_font_description_set_family(desc, family);
		return desc;
	}

	public static PangoFontDescriptionHandle SetFamilyStatic(this PangoFontDescriptionHandle desc, string family)
	{
		PangoFontDescriptionExterns.pango_font_description_set_family_static(desc, family);
		return desc;
	}

	public static PangoFontDescriptionHandle SetGravity(this PangoFontDescriptionHandle desc, PangoGravity gravity)
	{
		PangoFontDescriptionExterns.pango_font_description_set_gravity(desc, gravity);
		return desc;
	}

	public static PangoFontDescriptionHandle SetSize(this PangoFontDescriptionHandle desc, int size)
	{
		PangoFontDescriptionExterns.pango_font_description_set_size(desc, size);
		return desc;
	}

	public static PangoFontDescriptionHandle SetStretch(this PangoFontDescriptionHandle desc, PangoStretch stretch)
	{
		PangoFontDescriptionExterns.pango_font_description_set_stretch(desc, stretch);
		return desc;
	}

	public static PangoFontDescriptionHandle SetStyle(this PangoFontDescriptionHandle desc, PangoStyle style)
	{
		PangoFontDescriptionExterns.pango_font_description_set_style(desc, style);
		return desc;
	}

	public static PangoFontDescriptionHandle SetVariant(this PangoFontDescriptionHandle desc, PangoVariant variant)
	{
		PangoFontDescriptionExterns.pango_font_description_set_variant(desc, variant);
		return desc;
	}

	public static PangoFontDescriptionHandle SetVariations(this PangoFontDescriptionHandle desc, string variations)
	{
		PangoFontDescriptionExterns.pango_font_description_set_variations(desc, variations);
		return desc;
	}

	public static PangoFontDescriptionHandle SetVariationsStatic(this PangoFontDescriptionHandle desc, string variations)
	{
		PangoFontDescriptionExterns.pango_font_description_set_variations_static(desc, variations);
		return desc;
	}

	public static PangoFontDescriptionHandle SetWeight(this PangoFontDescriptionHandle desc, PangoWeight weight)
	{
		PangoFontDescriptionExterns.pango_font_description_set_weight(desc, weight);
		return desc;
	}

	public static string ToFilename(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_to_filename(desc);
	}

	public static string ToString(this PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_to_string(desc);
	}

	public static PangoFontDescriptionHandle UnsetFields(this PangoFontDescriptionHandle desc, PangoFontMask to_unset)
	{
		PangoFontDescriptionExterns.pango_font_description_unset_fields(desc, to_unset);
		return desc;
	}

}
internal class PangoFontDescriptionExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoFontDescriptionHandle pango_font_description_new();

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_font_description_better_match(PangoFontDescriptionHandle desc, PangoFontDescriptionHandle old_match, PangoFontDescriptionHandle new_match);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontDescriptionHandle pango_font_description_copy(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontDescriptionHandle pango_font_description_copy_static(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_font_description_equal(PangoFontDescriptionHandle desc1, PangoFontDescriptionHandle desc2);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_free(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_description_get_family(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern PangoGravity pango_font_description_get_gravity(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontMask pango_font_description_get_set_fields(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_font_description_get_size(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_font_description_get_size_is_absolute(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern PangoStretch pango_font_description_get_stretch(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern PangoStyle pango_font_description_get_style(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern PangoVariant pango_font_description_get_variant(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_description_get_variations(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern PangoWeight pango_font_description_get_weight(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern uint pango_font_description_hash(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_merge(PangoFontDescriptionHandle desc, PangoFontDescriptionHandle desc_to_merge, bool replace_existing);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_merge_static(PangoFontDescriptionHandle desc, PangoFontDescriptionHandle desc_to_merge, bool replace_existing);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_set_absolute_size(PangoFontDescriptionHandle desc, double size);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_set_family(PangoFontDescriptionHandle desc, string family);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_set_family_static(PangoFontDescriptionHandle desc, string family);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_set_gravity(PangoFontDescriptionHandle desc, PangoGravity gravity);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_set_size(PangoFontDescriptionHandle desc, int size);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_set_stretch(PangoFontDescriptionHandle desc, PangoStretch stretch);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_set_style(PangoFontDescriptionHandle desc, PangoStyle style);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_set_variant(PangoFontDescriptionHandle desc, PangoVariant variant);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_set_variations(PangoFontDescriptionHandle desc, string variations);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_set_variations_static(PangoFontDescriptionHandle desc, string variations);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_set_weight(PangoFontDescriptionHandle desc, PangoWeight weight);

	[DllImport(Libraries.Pango)]
	internal static extern string pango_font_description_to_filename(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern string pango_font_description_to_string(PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_description_unset_fields(PangoFontDescriptionHandle desc, PangoFontMask to_unset);

}

public struct PangoFontDescription
{
}
