using System.Reflection;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.StyleSheets;

[assembly: AssemblyTitle("Xamarin.Forms.Core")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The Page "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

//[assembly: AssemblyVersion("1.0.*")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

//[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.iOS")]
//[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.iOS.Classic")]
//[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.Android")]
//[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.UAP")]
//[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.WinRT")]
//[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.WinRT.Tablet")]
//[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.WinRT.Phone")]
//[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.WP8")]
//[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.macOS")]
[assembly: InternalsVisibleTo("iOSUnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Controls")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Design")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Android.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.WP8.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Xaml")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.iOS")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.iOS.Classic")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.Android")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Xaml.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.FlexLayout.UnitTests")]

[assembly: InternalsVisibleTo("Xamarin.Forms.Core.iOS.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Android.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Windows.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.macOS.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.iOS.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Android.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Loader")]
[assembly: InternalsVisibleTo("Xamarin.Forms.UITest.Validator")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Build.Tasks")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Pages")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Pages.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.CarouselView")]
[assembly: Preserve]

[assembly: XmlnsDefinition("http://xamarin.com/schemas/2014/forms", "Xamarin.Forms")]

[assembly: StyleProperty("background-color", typeof(VisualElement), nameof(VisualElement.BackgroundColorProperty))]
[assembly: StyleProperty("background-image", typeof(Page), nameof(Page.BackgroundImageProperty))]
[assembly: StyleProperty("border-color", typeof(Button), nameof(BorderElement.BorderColorProperty))]
[assembly: StyleProperty("border-width", typeof(Button), nameof(Button.BorderWidthProperty))]
[assembly: StyleProperty("color", typeof(ITextElement), nameof(TextElement.TextColorProperty))]
//[assembly:StyleProperty("direction", .., ..)]
[assembly: StyleProperty("font-family", typeof(IFontElement), nameof(FontElement.FontFamilyProperty))]
[assembly: StyleProperty("font-size", typeof(IFontElement), nameof(FontElement.FontSizeProperty))]
[assembly: StyleProperty("font-style", typeof(IFontElement), nameof(FontElement.FontAttributesProperty))]
[assembly: StyleProperty("height", typeof(VisualElement), nameof(VisualElement.HeightRequestProperty))]
[assembly: StyleProperty("margin", typeof(View), nameof(View.MarginProperty))]
[assembly: StyleProperty("min-height", typeof(VisualElement), nameof(VisualElement.MinimumHeightRequestProperty))]
[assembly: StyleProperty("min-width", typeof(VisualElement), nameof(VisualElement.MinimumWidthRequestProperty))]
[assembly: StyleProperty("opacity", typeof(VisualElement), nameof(VisualElement.OpacityProperty))]
[assembly: StyleProperty("padding", typeof(IPaddingElement), nameof(PaddingElement.PaddingProperty))]
[assembly: StyleProperty("padding-left", typeof(IPaddingElement), nameof(PaddingElement.PaddingProperty))]
[assembly: StyleProperty("padding-top", typeof(IPaddingElement), nameof(PaddingElement.PaddingProperty))]
[assembly: StyleProperty("padding-right", typeof(IPaddingElement), nameof(PaddingElement.PaddingProperty))]
[assembly: StyleProperty("padding-bottom", typeof(IPaddingElement), nameof(PaddingElement.PaddingProperty))]
[assembly: StyleProperty("visibility", typeof(VisualElement), nameof(VisualElement.IsVisibleProperty))]
[assembly: StyleProperty("width", typeof(VisualElement), nameof(VisualElement.WidthRequestProperty))]