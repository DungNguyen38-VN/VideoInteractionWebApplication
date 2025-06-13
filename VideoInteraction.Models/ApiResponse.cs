using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoInteraction.Models
{
    public class ApiResponse
    {
        public string Code { get; set; }
        public string Msg { get; set; }
        public SceneData Data { get; set; }
    }

    public class SceneData
    {
        public List<TvWallScene> Scene_List { get; set; }
    }

}
