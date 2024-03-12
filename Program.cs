using System.Net;

var url = "https://jsonplaceholder.typicode.com/todos/3";

var request = WebRequest.Create(url);
request.Method = "GET";

using var webResponse = request.GetResponse();
using var webStream = webResponse.GetResponseStream();

using var reader = new StreamReader(webStream);
var data = reader.ReadToEnd();

Console.WriteLine(data);