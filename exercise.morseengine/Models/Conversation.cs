using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.morseengine.Models
{
    public class Conversation
    {
        public int Id { get; set; } 
        public DateTime ConversationStart { get; set; } 
        public DateTime? ConversationEnd { get; set; } = null;

    }
}
