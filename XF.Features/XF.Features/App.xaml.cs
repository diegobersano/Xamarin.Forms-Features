using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Features.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XF.Features
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }

        public static void SetMainPage()
        {
            var useTab = false;

            Current.MainPage = useTab ? (Page)GetTabbedPage() : GetMasterDetailPage();
        }

        private static TabbedPage GetTabbedPage()
        {
            return new TabbedPage
            {
                BarTextColor = Color.Black,
                Children =
                {
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse",
                        Icon = Device.OnPlatform("tab_feed.png",null,null),
                        BarTextColor = Color.Black
                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About",
                        Icon = Device.OnPlatform("tab_about.png",null,null),
                        BarTextColor = Color.Black
                    }
                }
            };
        }

        private static MasterDetailPage GetMasterDetailPage()
        {
            return new MasterDetailPage
            {
                Title = "Demo",
                Detail = new ContentPage
                {
                    Content = new StackLayout
                    {
                        VerticalOptions = LayoutOptions.Center,
                        Children =
                        {
                            new Label
                            {
                                HorizontalTextAlignment = TextAlignment.Center,
                                Text = "Hola mundo desde Xamarin Forms!",
                                FontSize = 30
                            }
                        }
                    }
                },
                Master = new ContentPage
                {
                    Title = "Demo App",
                    Content = new StackLayout
                    {
                        BackgroundColor = Color.Yellow,
                        Children =
                        {
                            new Label
                            {
                                HorizontalTextAlignment= TextAlignment.Center,
                                Text = "Menú lateral",
                                FontSize = 26,
                                TextColor = Color.Black
                            }
                        }
                    }
                }
            };
        }
    }
}