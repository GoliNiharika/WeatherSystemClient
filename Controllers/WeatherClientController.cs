using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WeatherClient.Models;

namespace WeatherClient.Controllers
{
    public class WeatherClientController : Controller
    {
        string Baseurl = "https://localhost:44380/";
        //static HttpClient httpClient = new HttpClient();
        //HttpContext context = System.Web.HttpContext.Current;
        //string baseUrl = context.Request.Url.Authority + context.Request.ApplicationPath.TrimEnd('/');
    
        public IActionResult Register()
        {
            ViewBag.Initial = "In Register Page";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserDetail p)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(Baseurl);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                StringContent content = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("api/Users", content))
                {
                    var result = response;

                    //If success received   
                    if (result.IsSuccessStatusCode)
                    {
                        ViewBag.Msg = "Login Success";
                    }
                    else
                    {
                        ViewBag.Msg = "Login Failed";
                    }

                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var status = JsonConvert.DeserializeObject<UserDetail>(apiResponse);
                }
            }
            return RedirectToAction("Login");
        }


        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string email, string pass)
        {
            UserDetail Pobj = new UserDetail();
            //Login l = new Login();
            //l.Email = email;
            //l.Password = pass;
            
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(Baseurl);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //StringContent content = new StringContent(JsonConvert.SerializeObject(l), Encoding.UTF8, "application/json");

                //using (var response = await httpClient.GetAsync("​api/Users",ngoli%40uworld.in/12  ))
                using (var response = await httpClient.GetAsync("​api/Users/"+ email +"/"+pass ))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Pobj = JsonConvert.DeserializeObject<UserDetail>(apiResponse);

                }
            }
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult EditDetail()
        {
            return View();
        }

        [HttpPut]
        public async Task<IActionResult> EditDetail(UserDetail ud)
        {
            using(var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(Baseurl);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                StringContent content = new StringContent(JsonConvert.SerializeObject(ud), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("api/Users", content))
                {
                    var result = response;

                    

                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var status = JsonConvert.DeserializeObject<UserDetail>(apiResponse);
                }
            }
            return View();
        }
        public IActionResult CreateWeather()
        {
            ViewBag.page = "Adding Weather Details";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateWeather(WeatherDetail wd)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(Baseurl);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                StringContent content = new StringContent(JsonConvert.SerializeObject(wd), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("api/Weather", content))
                {
                    var result = response;

                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //var status = JsonConvert.DeserializeObject<WeatherDetail>(apiResponse);
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllWeatherDetails()
        {
            List<WeatherDetail> li = new List<WeatherDetail>();
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(Baseurl);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                using (var response = await httpClient.GetAsync("api/Weather"))
                {
                    var result = response;
                    string apiResponse = await result.Content.ReadAsStringAsync();
                    li = JsonConvert.DeserializeObject<List<WeatherDetail>>(apiResponse);
                }
            }
            return View(li);
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Search(IFormCollection fc)
        {
            string city = fc["cityName"];
            List<WeatherDetail> li = new List<WeatherDetail>();
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(Baseurl);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                using (var response = await httpClient.GetAsync("api/Weather"))
                {
                    var result = response;
                    string apiResponse = await result.Content.ReadAsStringAsync();
                    li = JsonConvert.DeserializeObject<List<WeatherDetail>>(apiResponse);
                }
            }
            List<WeatherDetail> cityList = new List<WeatherDetail>();
            cityList = li.Where(x => x.City == city).ToList();
            //using (var httpClient = new HttpClient())
            //{
            //    httpClient.BaseAddress = new Uri(Baseurl);
            //    httpClient.DefaultRequestHeaders.Accept.Clear();

            //    System.Net.Http.StringContent cityName = new System.Net.Http.StringContent(city);
            //    using (var response = await httpClient.PostAsync("api/Weather/ListByCity?city=", city))
            //    {
            //        var result = response;
            //        string apiResponse = await result.Content.ReadAsStringAsync();
            //        cityList = JsonConvert.DeserializeObject<List<WeatherDetail>>(apiResponse);
            //    }
            //}
            return View("SearchResult", cityList);
        }

        public ActionResult WeatherDetail(WeatherDetail weather)
        {
            return View(weather);
        }

        public ActionResult EditWeather(WeatherDetail wd)
        {
            return View();
        }
        [HttpDelete]
        public ActionResult DeleteWeather()
        {

            return View();
        }

        //[HttpGet]
        //public async Task<ActionResult> GetWeatherDetails()
        //{
        //    List<WeatherDetail> Pobj = new List<WeatherDetail>();
            
        //    using (var httpClient = new HttpClient())
        //    {
        //        httpClient.BaseAddress = new Uri(Baseurl);
        //        httpClient.DefaultRequestHeaders.Accept.Clear();
                
        //        using (var response = await httpClient.GetAsync("​api/Weather"))
        //        {
        //            var result = response;
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            Pobj = JsonConvert.DeserializeObject<List<WeatherDetail>>(apiResponse);

        //        }
        //    }
        //    //return RedirectToAction("Login");

        //    return View(Pobj);
        //}


    }
}
