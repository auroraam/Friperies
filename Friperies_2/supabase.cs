using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase;
using System.Net.Http;

namespace Friperies_2
{
    internal class supabase
    {
        private static readonly HttpClient client = new HttpClient();

        private const string SupabaseUrl = "https://zlbsnnkwupvwnuhyovfm.supabase.co";
        private const string SupabaseApiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InpsYnNubmt3dXB2d251aHlvdmZtIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzI0OTAzODksImV4cCI6MjA0ODA2NjM4OX0.jGQ0rpOuWrGLiBWQ2KPGaZpj3j6nO9_98Ocil5ZxulQ";

        public supabase()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("apikey", SupabaseApiKey);
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {SupabaseApiKey}");
        }
    }
}
