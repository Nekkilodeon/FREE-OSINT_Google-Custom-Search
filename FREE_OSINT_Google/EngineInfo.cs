using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class EngineInfo : ICloneable
    {
        public string Api_key { get; set; }
        public Engine[] Engines { get; set; }
        public bool Expired { get; set; }


        public void Add_engine(int index, Engine engine)
        {
            Engines[index] = engine;
        }

        public object Clone()
        {
            List<Engine> engines = new List<Engine>();
            foreach (Engine engine in this.Engines)
            {
                engines.Add(engine.Clone());
            }
            return new EngineInfo(this.Api_key, this.Engines.Length)
            {
                Engines = engines.ToArray()
            };
        }

        public EngineInfo(string api_key, int engine_array_size)
        {
            this.Api_key = api_key;
            this.Engines = new Engine[engine_array_size];
        }
        public EngineInfo(string api_key, List<Engine> engine_list)
        {
            this.Api_key = api_key;
            this.Engines = engine_list.ToArray();
        }

        public EngineInfo()
        {
        }

        public class Engine
        {
            public string Title { get; set; }
            public string Cx { get; set; }
            public List<string> Filters { get; set; }

            bool Expired { get; set; }

            public Engine(string title, string cx, List<string> filters)
            {
                this.Title = title;
                this.Cx = cx;
                this.Filters = filters;
                Expired = false;

            }

            public override string ToString()
            {
                return Title + "-" + Cx;
            }

            internal Engine Clone()
            {
                List<string> filters = new List<string>();
                filters.AddRange(this.Filters);
                return new Engine(this.Title, this.Cx, filters)
                {
                    Expired = this.Expired
                };
            }
        }
    }
}
