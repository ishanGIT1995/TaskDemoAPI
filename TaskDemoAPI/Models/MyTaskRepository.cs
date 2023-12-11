namespace TaskDemoAPI.Models
{
    public static  class MyTaskRepository
    {
        public static  List<MyTask> MyTasks { get; set; } = new List<MyTask>
        {
            new MyTask
            {
                 Id = 1,
                 Title = "Go Shopping",
                 Description = "Go Shopping and buy some snacks",

            },
            new MyTask
            {
                Id = 2,
                Title = "Watch a movie",
                Description = "this saturday go and watch movie SpiderMan"
            },
            new MyTask
            {
                Id = 3,
                Title = "Ready for the exam",
                Description = "ready for the Algebra and Pure Maths exam"
            }
        };
    }
}
