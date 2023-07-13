namespace blazorblog.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Created {get;set;} = "";
        public string Title { get; set; } = "";
        public string Introduction { get; set; } = "";
        public string Body { get; set; } = "";
        public string Preview { get; set; } = "";
        public string Image {get;set;} = "";
    }
}
