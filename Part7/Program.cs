using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a request for the URL. 
            List<Comment> comments= GetComments();

        }

        private List<Comment>GetComments(List<Comment> comments, int id)
        {
            return comments.Where(a => a.PostId == id).ToList();
        }
        private static List<Comment> GetComments()
        {
            WebRequest request = WebRequest.Create(
              "https://jsonplaceholder.typicode.com/comments");

           
            WebResponse response = request.GetResponse();
           
        
            Stream dataStream = response.GetResponseStream();
           
            StreamReader reader = new StreamReader(dataStream);
          
            string responseFromServer = reader.ReadToEnd();
           

            List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(responseFromServer);
            reader.Close();
            response.Close();
            return comments;
        }
    }

    public class Comment
    {
        public int PostId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
    }
}
