using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Views
{
    internal class Message
    {
        public static void EmptySelection()
        {
            string message = "Please choose the genre to this action";
            string title = "Empty selection";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void DeleteError(string title, string message) {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InputFaild()
        {
            string message = "Please enter all informatio above.";
            string title = "Some input is empty";
            MessageBox.Show(message,title,MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
