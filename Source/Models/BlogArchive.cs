using Piranha.AttributeBuilder;
using Piranha.Models;

namespace davidsanchez.cr.Models
{
    [PageType(Title = "Blog archive", UseBlocks = false, IsArchive = true)]
    public class BlogArchive  : Page<BlogArchive>
    {
        /// <summary>
        /// Gets/sets the post archive.
        /// </summary>
        public PostArchive<DynamicPost> Archive { get; set; }
    }
}