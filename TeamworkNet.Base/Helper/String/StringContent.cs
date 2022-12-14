using System.Net.Http;
using System.Text;

namespace TeamWorkNet.Base.Helper.String
{
  public class JsonContent : StringContent
  {
    private string ObjectName;
    public JsonContent(string objectName, string content, Encoding encoding)
      : base(content, encoding)
    {
      ObjectName = objectName;
    }

    public override string ToString()
    {
      return "{" + ObjectName + ":" + base.ToString() + "}";
    }
  }
}
