using Piranha.Extend;
using Piranha.Extend.Fields;

namespace davidsanchez.cr.Models.Regions
{
    public class Hero
    {
        [Field(Title = "Primary image")]
        public ImageField PrimaryImage { get; set; }

        [Field]
        public HtmlField Ingress { get; set; }
    }
}