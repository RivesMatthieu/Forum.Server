using Forum.Server.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicController : ControllerBase
    {

        private readonly ILogger<TopicController> _logger;

        public TopicController(ILogger<TopicController> logger) 
        { 
            _logger = logger;
        }

        [HttpGet("/topic/{id}")]
        public Topic GetTopicById(int id) 
        {
            return new Topic()
            {
                Id = id,
                Title = "First topic",
                Description = "Lorem ipsum",
                Tags = new[] 
                {
                    new TopicTag() {Id = 1, Code = "Auto", Name = "Voiture"},
                    new TopicTag() {Id = 2, Code = "Audi", Name = "Audi"}
                }
            };
        }

        [HttpPost("/topic")]
        public Topic PostTopic([FromBody]Topic topic)
        {

            return topic;
        }
    }
}
