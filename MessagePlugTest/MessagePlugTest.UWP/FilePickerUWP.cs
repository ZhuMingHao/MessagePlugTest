using MessagePlugTest.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

[assembly: Xamarin.Forms.Dependency(typeof(FilePickerUWP))]

namespace MessagePlugTest.UWP
{
    public class FilePickerUWP : IFilePicker
    {
        public async Task<StorageFile> getFileAsync()
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker
            {
                ViewMode = Windows.Storage.Pickers.PickerViewMode.List,
                SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary
            };
            picker.FileTypeFilter.Add("*");

            var file = await picker.PickSingleFileAsync();

            if (file != null)
            {
                return file;
            }

            return null;
        }
    }
}