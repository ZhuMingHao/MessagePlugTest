using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.FilePicker;
using Windows.Storage;

namespace MessagePlugTest
{
    public partial class MainPage : ContentPage
    {
        private StorageFile attachment;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (attachment != null)
            {
                DependencyService.Get<IMessageEmail>().SendEmailMehod("799573337@qq.com", "HelloWorld", "Hello Customer", attachment);
            }
            else
            {
                DependencyService.Get<IMessageEmail>().SendEmailMehod("799573337@qq.com", "HelloWorld", "Hello Customer");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            attachment = await DependencyService.Get<IFilePicker>().getFileAsync();
        }
    }
}