using UniversityListApp.Controls;
using UniversityListApp.Droid;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(MultiLineLabel), typeof(CustomMultiLineLabelRenderer))]
namespace UniversityListApp.Droid
{
    using Android.Content;
    using Xamarin.Forms.Platform.Android;

    public class CustomMultiLineLabelRenderer : LabelRenderer
    {
        public CustomMultiLineLabelRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            MultiLineLabel multiLineLabel = (MultiLineLabel)Element;

            if (multiLineLabel != null && multiLineLabel.Lines != -1)
            {
                Control.SetSingleLine(false);
                Control.SetLines(multiLineLabel.Lines);
            }
        }
    }
}