using Microsoft.AspNetCore.Mvc;
using NetCoreTestInnovar.BusinessService;
using NetCoreTestInnovar.Models;

namespace NetCoreTestInnovar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScoreController
    {
        public ScoreBusinessService _scoreBusinessService;
        public ScoreController(ScoreBusinessService scoreBusinessService){
            _scoreBusinessService = scoreBusinessService;
        }

        [HttpGet("[action]")]
        public List<Score> GetScores(){
            return _scoreBusinessService.GetScores();
        }

        [HttpPost("[action]")]
        public Score CreateScore(Score score){
            return _scoreBusinessService.CreateScore(score);
        }
        
        //fhighestscore
        [HttpGet("[action]")]
        public int GetHiguetScore()
        {
            var max = _scoreBusinessService.GetHiguetScore();

            return max;
        }
        
    }
}