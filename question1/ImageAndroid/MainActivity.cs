using Android.App;
using Android.Widget;
using Android.OS;

namespace AsyncImageAndroid
{

	[Activity (Label = "AsyncImageAndroid", MainLauncher = true,
	           ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation)]
	public class MainActivity : Activity
	{
		int count = 1;
		Button downloadButton;
		Button clickButton;
		TextView infoLabel;
		ImageView imageview;
		ProgressBar downloadProgress;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			this.downloadButton = FindViewById<Button> (Resource.Id.downloadButton);
			this.clickButton = FindViewById<Button> (Resource.Id.clickButton);
			this.infoLabel = FindViewById<TextView> (Resource.Id.textView1);
			this.imageview = FindViewById<ImageView> (Resource.Id.imageView1);
			this.downloadProgress = FindViewById<ProgressBar> (Resource.Id.progressBar);

			// provide delegate to perform the download of the following image:
			// var url = "http://photojournal.jpl.nasa.gov/jpeg/PIA15416.jpg";
			// the delegate should do the following:
			// 1. Update the text of the download button to "Cancel".
			// 2. Provide the ability to cancel the request using the same button.
			// 3. Update the info label.
			// 4. Perform the download of the uri: http://photojournal.jpl.nasa.gov/jpeg/PIA15416.jpg
			// 5. Update the progress bar while the image downloads.
			// 6. Store the downloaded image in the file system.
			// 7. Use the BitmapFactory to resize the image. You can use the web to find information of the API.
			// 8. Set the image view image.
			//downloadButton.Click += downloadImage;

			clickButton.Click += delegate {
				clickButton.Text = string.Format ("{0} clicks!", count++);
			};
		}
	}
}


