using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class EngineInfo
    {
        public string api_key { get; set; }
        public Engine[] engines { get; set; }
        public bool expired { get; set; }


        public void add_engine(int index ,Engine engine)
        {
            engines[index] = engine;
        }

        public EngineInfo(string api_key, int engine_array_size)
        {
            this.api_key = api_key;
            this.engines = new Engine[engine_array_size];
        }
        public EngineInfo(string api_key, List<Engine> engine_list)
        {
            this.api_key = api_key;
            this.engines = engine_list.ToArray();
        }

        public class Engine
        {
            public string title { get; set; }
            public string cx { get; set; }

            bool expired { get; set; }

            public Engine(string title, string cx)
            {
                this.title = title;
                this.cx = cx;
                expired = false;
            }
            public override string ToString()
            {
                return title + "-" + cx;
            }

        }
    }
}
