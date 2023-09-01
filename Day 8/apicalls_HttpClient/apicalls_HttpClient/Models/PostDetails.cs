namespace apicalls_HttpClient.Models
{
    public class PostDetails
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string body { get; set; }
        public string title { get; set; }

        List<PostDetails> postList = new List<PostDetails>();

        public List<PostDetails> GetPostDetails()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var call = client.GetAsync(url).Result;

            if (call.IsSuccessStatusCode)
            {
                var data = call.Content.ReadAsAsync<List<PostDetails>>();
                data.Wait();
                postList = data.Result;

            }
            else
            {
                throw new Exception("Could not get data, please contact admin");
            }


            return postList;
        }
    }
}


