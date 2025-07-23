using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiShares.Models;
using System.Text.Json;

namespace MauiShares.Services
{
    public class FileUploadService
    {
        private readonly HttpClient httpClient;

        public FileUploadService()
        {
            httpClient = new HttpClient();
        }

        public async Task<FileModel> UploadFile(string localFilePath)
        { 
            using(var formData = new MultipartFormDataContent())
            {
                var fileContent = new ByteArrayContent(File.ReadAllBytes(localFilePath));
                fileContent.Headers.ContentType =
                    new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                formData.Add(fileContent, "file", Path.GetFileName(localFilePath));
                formData.Add(new StringContent("true"), "autoDelete");

                var response =
                    await httpClient.PostAsync("https://file.io/", content: formData);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var fileModel = JsonSerializer.Deserialize<FileModel>(responseString);
                    if(fileModel.success)
                    {
                        return fileModel;
                    }
                    else
                    {
                        return null;
                    }
                }
                return null;
            }
        }

    }
}
