using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB_WinForm
{
    public class Note
    {
        private DateTime _date;
        private static int _NoteNumber = 0;
        private string _text = "";
        private string _priority = "";

        public Note(string newText, string notePriority)  // constructor sets the Date field to "now"
        {
            _date = DateTime.UtcNow;
            _NoteNumber++; // bump up our count of Notes
            _text = newText; // set the text
            _priority = notePriority; // set the note's priority
        }

        //  Class Properties
        public string NoteNumber // each "record" gets a new, unique NoteNumber
        {
            get { return _NoteNumber.ToString(); }
        }
        public string Text // the text for our Note
        {
            get { return _text; }
        }
        public DateTime Date  // can read this property, but it is set only in constructor
        {
            get { return _date.ToLocalTime(); }
        }
        public string Priority
        {
            get { return _priority;  } //note Priority
        }
    }

}
