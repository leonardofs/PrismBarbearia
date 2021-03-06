﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrismBarbearia.Models
{
    class Repository
    {
        public async Task<List<BarberService>> GetServices()
        {
            List<BarberService> services;
            var URLwebAPI = "http://barbearia8ball.azurewebsites.net/tables/servicos?zumo-api-version=2.0.0";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLwebAPI);
                services = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BarberService>>(JSON);
            }
            return services;
        }

        public async Task<List<BarberHour>> GetHours()
        {
            List<BarberHour> hours;
            var URLwebAPI = "http://barbearia8ball.azurewebsites.net/tables/horarios?zumo-api-version=2.0.0";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLwebAPI);
                hours = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BarberHour>>(JSON);
            }
            return hours;
        }

        public async Task<List<BarberSchedule>> GetSchedule()
        {
            List<BarberSchedule> schedules;
            //var URLwebAPI = "http://appxamarindemo.azurewebsites.net/tables/Agendamento?zumo-api-version=2.0.0";
            var URLwebAPI = "http://barbearia8ball.azurewebsites.net/tables/agendamentos?zumo-api-version=2.0.0";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLwebAPI);
                schedules = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BarberSchedule>>(JSON);
            }
            return schedules;
        }

    }
}