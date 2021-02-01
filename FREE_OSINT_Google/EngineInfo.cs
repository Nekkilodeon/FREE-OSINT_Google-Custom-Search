using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class EngineInfo : ICloneable
    {
        public string api_key { get; set; }
        public Engine[] engines { get; set; }
        public bool expired { get; set; }


        public void add_engine(int index, Engine engine)
        {
            engines[index] = engine;
        }

        public object Clone()
        {
            List<Engine> engines = new List<Engine>();
            foreach (Engine engine in this.engines)
            {
                engines.Add(engine.Clone());
            }
            return new EngineInfo(this.api_key, this.engines.Length)
            {
                engines = engines.ToArray()
            };
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

        public EngineInfo()
        {
        }

        public class Engine
        {
            public string title { get; set; }
            public string cx { get; set; }
            public List<string> filters { get; set; }

            bool expired { get; set; }

            public Engine(string title, string cx, List<string> filters)
            {
                this.title = title;
                this.cx = cx;
                this.filters = filters;
                expired = false;

            }

            public override string ToString()
            {
                return title + "-" + cx;
            }

            internal Engine Clone()
            {
                List<string> filters = new List<string>();
                filters.AddRange(this.filters);
                return new Engine(this.title, this.cx, filters)
                {
                    expired = this.expired
                };
            }
        }
    }
}
