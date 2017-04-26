namespace XF.Features.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new XF.Features.App());
        }
    }
}