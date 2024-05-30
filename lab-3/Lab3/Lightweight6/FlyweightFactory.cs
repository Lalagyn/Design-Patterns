using Composer5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightweight6
{
    public class FlyweightFactory
    {
        private readonly Dictionary<string, LightElementNode> _flyweights = new Dictionary<string, LightElementNode>();

        public LightElementNode GetFlyweight(string tagName, DisplayType display, CloseType close)
        {
            string key = $"{tagName}_{display}_{close}";
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new LightElementNode(tagName, display, close);
            }
            return _flyweights[key];
        }
    }
}
