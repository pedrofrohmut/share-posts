using Newtonsoft.Json.Linq;

namespace SharePosts.WebApi.Utils
{
  public class GraphQLQuery
  {
    public string OperationName { get; set; }
    public string Query { get; set; }
    public JObject Variables { get; set; }
  }
}
