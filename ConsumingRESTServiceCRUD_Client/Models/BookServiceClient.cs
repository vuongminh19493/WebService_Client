using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace ConsumingRESTServiceCRUD_Client.Models
{
    public class BookServiceClient
    {
        private String BASE_URL = "http://localhost:55133/BookServices.svc/";
        // I just call one method "GetAllBooks" only
        public List<Book> getAllBook()
        {
            var syncClinet = new WebClient();
            var content = syncClinet.DownloadString(BASE_URL + "Books");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<Book>>(content);
        }
    }
}