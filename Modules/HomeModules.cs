using Nancy;
using Triangles.Objects;

namespace Triangles {
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => View["form.cshtml"];
      Get["/result"] = _ => {
        Triangle triangle = new Triangle(Request.Query["side1"], Request.Query["side2"], Request.Query["side3"]);
        return View["result.cshtml",triangle];
      };
    }
  }
}
