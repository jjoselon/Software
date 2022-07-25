using System;
using System.Collections.Generic;

namespace EntityFrameworkManyToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var DbContext = new DerivedContext())
            {
                var Post = new Post
                {
                    PostName = "Post number 3",
                };
                var Tag = new Tag
                {
                    TagName = "Tecnologia 4",
                };

                Tag.PostTags = new List<PostTag>
                {
                    new PostTag
                    {
                        Post = Post,
                        Tag = Tag
                    }
                };

                DbContext.Tags.Add(Tag);

                var count = DbContext.SaveChanges();

                Console.WriteLine($"Records saved {count}");

                Console.ReadKey();
            }
        }
    }
}
