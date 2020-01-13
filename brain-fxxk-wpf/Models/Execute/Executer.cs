using BFCore.Config;
using BFCore.Execute;

namespace BFWpf.Models.Execute
{
    public class Executer : ExecuterBase
    {
        public string Output { get; private set; }

        public Executer(BFCommandConfig config) : base(config) { }

        protected override void Read()
        {
        }

        protected override void Write()
        {
            this.Output += (char)this._memory[this._index];
        }

        public void Reset()
        {
            this.Output = string.Empty;

            this._index = 0;

            this._memory = new int[this._memory.Length];
        }
    }
}
