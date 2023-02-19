using myResumeUI.Models;
using System.Text.Json;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Collections.ObjectModel;

namespace myResumeUI.Service
{
    public  class MyResumeSercive
    {
        public static string BaseAddress =
        DeviceInfo.Platform == DevicePlatform.Android ? "https://10.0.2.2:7043" : "https://localhost:7043";
        public static string myResumeUrl = "/api/myResumeAPI";

        public async Task<AboutMe> GetAboutMe()
        {
                
            try
            {
                int userID = 6;
                var devSslHelper = new DevHttpsConnectionHelper(sslPort: 7043);
                var http = devSslHelper.HttpClient;
                HttpResponseMessage response = await http.GetAsync(devSslHelper.DevServerRootUrl + $"{myResumeUrl}/AboutMe/{userID}");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var results = JObject.Parse(content).ToString();
                    var serializedItem = JsonSerializer.Deserialize<AboutMe>(results);
                    if (serializedItem != null)
                        return serializedItem;
                }
                return new AboutMe(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                return new AboutMe();
            }
        }

        public async Task<IEnumerable<Education>> GetAcademicsByUserId(long userID)
        {
            try
            {
                var devSslHelper = new DevHttpsConnectionHelper(sslPort: 7043);
                var http = devSslHelper.HttpClient;
                HttpResponseMessage response = await http.GetAsync(devSslHelper.DevServerRootUrl + $"{myResumeUrl}/Educations/GetByUserId/{userID}");

                if (response.IsSuccessStatusCode)
                {
                    string content =  await response.Content.ReadAsStringAsync();
                    //var results = JObject.Parse(content);
                    var serializedItem = JsonSerializer.Deserialize<IEnumerable<Education>>(content);
                    if (serializedItem != null)

                        //foreach (var item in serializedItem)
                        //    Academics.Add(item);

                        return serializedItem;
                }
                return Enumerable.Empty<Education>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Enumerable.Empty<Education>();
            }
        }
        public async Task<Education> GetAcademicById(long id)
        {
            try
            {
                var devSslHelper = new DevHttpsConnectionHelper(sslPort: 7043);
                var http = devSslHelper.HttpClient;
                HttpResponseMessage response =  http.GetAsync(devSslHelper.DevServerRootUrl + $"{myResumeUrl}/Educations/GetById/{id}").Result;

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var serializedItem = JsonSerializer.Deserialize<Education>(content);
                    if (serializedItem != null)
                        return serializedItem;
                }
                return new Education();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Education();
            }
        }

        public async Task<IEnumerable<WorkHistory>> GetWorkHistiry(long userID)
        {
            try
            {
                var devSslHelper = new DevHttpsConnectionHelper(sslPort: 7043);
                var http = devSslHelper.HttpClient;
                HttpResponseMessage response = await http.GetAsync(devSslHelper.DevServerRootUrl + $"{myResumeUrl}/WorkHistories/GetByUserId/{userID}");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var serializedItem = JsonSerializer.Deserialize<IEnumerable<WorkHistory>>(content);
                    if (serializedItem != null)
                        return serializedItem;
                }
                return Enumerable.Empty<WorkHistory>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Enumerable.Empty<WorkHistory>();
            }
        }
    }
}
