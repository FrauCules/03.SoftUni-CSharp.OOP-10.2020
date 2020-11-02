using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Demo1
{
    class Engine
    {
        private Oil oil;
        private Turbo turbo;
        private Karter karter;
        private Cilindri cilindri;

        public void Start()
        {
            oil.Use();
            turbo.Start();
            // karter Start
            // cilindri Start
            // butala Start
           
        }
        public void Stop()
        {
            oil.Stop();
            turbo.Stop();
            // karter Stop
            // cilindri Sto 
            // butala Stop
        }
        public void Accelerate()
        {

        }
    }
}
