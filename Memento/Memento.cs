using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Memento
    {
        public string Buffer { get; set; }

        public Memento(string Buffer)
        {
            this.Buffer = Buffer.Clone().ToString();
        }
    }

    class TextBoxHistory
    {
        private List<Memento> Storage { get; set; }
        private int _currenIndex;

        public TextBoxHistory()
        {
            Storage = new List<Memento>();
            _currenIndex = -1;
        }

        public void Add(Memento buffer)
        {
            if (_currenIndex == Storage.Count - 1)
                Storage.Add(buffer);
            else
            {
                Storage.RemoveRange(_currenIndex + 1, Storage.Count - _currenIndex - 1);
                Storage.Add(buffer);
            }
            _currenIndex++;
        }

        public Memento Undo()
        {
            if (_currenIndex == 0) return Storage[_currenIndex];
            else
                return Storage[--_currenIndex];
        }

        public Memento Redo()
        {
            if (_currenIndex == Storage.Count - 1) return Storage[_currenIndex];
            else return Storage[++_currenIndex];
        }
    }
}
