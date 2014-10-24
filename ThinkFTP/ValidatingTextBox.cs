using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThinkFTP
{
    public class ValidatingTextBox : TextBox
    {
        private Control _cntr;

        // Property
        public Control ControlToValidate
        {
            get { return _cntr; }
            set { _cntr = value; }
        }

        // Constructor
        public ValidatingTextBox(): base()
        {
            this.Validated += new EventHandler(HandleValidating);
        }

        // Event Handler
        void HandleValidating(object sender, EventArgs e)
        {
            // If no associated control, ignore
            if (ControlToValidate == null)
                return;

            int emptyTextCount = 0;
            ValidatingTextBox currTxtBox;

            // Checks all controls in the parent 
            foreach (Control ctrl in Parent.Controls)
            {
                currTxtBox = ctrl as ValidatingTextBox;

                if (currTxtBox != null && // If the correct object type
                    currTxtBox.ControlToValidate == this.ControlToValidate && // and validates the same control
                    currTxtBox.Text.Trim() == string.Empty) // and is empty, or contains only spaces
                {
                    emptyTextCount++;
                }

            }

            // Enable control only if no text boxes are empty
            if (emptyTextCount == 0)
                ControlToValidate.Enabled = true;
               
            else
                ControlToValidate.Enabled = false;
        }
    }
}
