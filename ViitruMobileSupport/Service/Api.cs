using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using RestSharp;
using ViitruMobileSupport.Models;

namespace ViitruMobileSupport.Service
{
    public class Api
    {
       
        private string AppKey = "qUiARBaZayqlVykJogXZPcdfpkSfAl87";

        public void AddPlan(Plan plan) 
        {
            RestRequest request = new RestRequest("https://viitrumobileproduct.azure-mobile.net/tables/plan");
            request.Method = Method.POST;
            request.AddHeader("X-ZUMO-APPLICATION", AppKey);

            string jasonPlan = JsonConvert.SerializeObject(plan, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            request.AddParameter("application/json", jasonPlan, ParameterType.RequestBody);

            RestClient client = new RestClient();
            var response = client.Execute(request);
        }

        public List<Plan> GetPlans() 
        {
            RestRequest request = new RestRequest("https://viitrumobileproduct.azure-mobile.net/tables/plan");
            request.AddHeader("X-ZUMO-APPLICATION", AppKey);
            request.Method = Method.GET; 
            RestClient client = new RestClient();
            var plansToView = new List<Plan>();
            var response = client.Execute(request);
           
            
            string json =  response.Content;
            var plans = JsonConvert.DeserializeObject<IEnumerable<Plan>>(json);
            plansToView = plans.ToList();
            return plansToView;
        }

        public List<Activity> GetActivitiesByPlanId(int planId) 
        {
            RestRequest request = new RestRequest("https://viitrumobileproduct.azure-mobile.net/tables/activity");
            request.AddHeader("X-ZUMO-APPLICATION", AppKey);
            request.Method = Method.GET;
            RestClient client = new RestClient();
            var activitiesToView = new List<Activity>();
            var response = client.Execute(request);

            string json = response.Content;
            var activities = JsonConvert.DeserializeObject<IEnumerable<Activity>>(json);
            activitiesToView = activities.ToList();
            return activitiesToView;
        }
    }
}