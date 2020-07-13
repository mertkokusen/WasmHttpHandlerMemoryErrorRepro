using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UnoWasmHttpTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var wc = new System.Net.Http.HttpClient(new Uno.UI.Wasm.WasmHttpHandler());

            var _500KbFileSampleUrl = "https://file-examples-com.github.io/uploads/2017/10/file-example_PDF_500_kB.pdf";
            var _1MbFileSampleUrl = "https://file-examples-com.github.io/uploads/2017/10/file-example_PDF_1MB.pdf";

            var bytes = await wc.GetByteArrayAsync(new Uri(_1MbFileSampleUrl));

            Console.WriteLine($"Array length: {(bytes?.Length.ToString() ?? "0")}");
        }
    }
}
