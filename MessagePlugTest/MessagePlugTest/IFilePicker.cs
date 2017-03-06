using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace MessagePlugTest
{
    public interface IFilePicker
    {
        Task<StorageFile> getFileAsync();
    }
}