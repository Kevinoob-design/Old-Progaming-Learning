using System;
using System.Linq;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A basic calculator.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clear the user input text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCEButton_Click(object sender, EventArgs e)
        {
            // Clears the text from the user input text box.
           this.txtUserInputText.Clear();
            // Focus the user input text.
            FocusInputText();

        }

        /// <summary>
        /// Will delete the text one by one in the user input from the higher index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelButton_Click(object sender, EventArgs e)
        {
            //if (this.txtUserInputText.Text.Length >= this.txtUserInputText.SelectionStart + 1)
            //    this.txtUserInputText.Text = this.txtUserInputText.Text.Remove(
            //        this.txtUserInputText.SelectionLength, 1);

            if (this.txtUserInputText.Text.Length < this.txtUserInputText.SelectionStart + 1)
                return;

            //this.txtUserInputText.Text = this.txtUserInputText.Text.Remove(
            //    this.txtUserInputText.Text.Length - 1);


            var selectionStart = this.txtUserInputText.SelectionStart;

            this.txtUserInputText.Text = this.txtUserInputText.Text.Remove(
                this.txtUserInputText.SelectionStart, 1);

            this.txtUserInputText.SelectionStart = selectionStart;

            this.txtUserInputText.SelectionLength = 0;
        }

        #endregion

        #region Number Methods
        /// <summary>
        ///  Will grab the object that was click and return its text value to the user input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumbersClick(object sender, EventArgs e)
        {
            // Create a copy of the object that was sent as a button.
            Button btn = (Button)sender;

            // Will asing the value to the first index of the user input.
            //this.txtUserInputText.Text = this.txtUserInputText.Text.Insert(
            //    this.txtUserInputText.SelectionStart, btn.Text);

            //this.txtUserInputText.Text = this.txtUserInputText.Text + btn.Text;

            var selectionStart = this.txtUserInputText.SelectionStart;

            this.txtUserInputText.Text = this.txtUserInputText.Text.Insert(
                this.txtUserInputText.SelectionStart, btn.Text);

            this.txtUserInputText.SelectionStart = selectionStart + btn.Text.Length;

            this.txtUserInputText.SelectionLength = 0;

            txtUserInputText.Focus();
        }
        #endregion

        #region Private Helpers
        /// <summary>
        /// Focus the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.txtUserInputText.Focus();
        }
        #endregion

        private void btnEqualButton_Click(object sender, EventArgs e)
        {

            // 3. Recursive functions

            //var myEnum = (int)OperationType.Multiply;

            this.lblCalculationResults.Text = ParseOperation();

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Parses the user equation and calculate the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                // Assing the text in the usert input
                var input = this.txtUserInputText.Text;

                // Remove all spaces
                input = input.Replace(" ", "");

                // Create a new top-lever operation
                var operation = new Operation();
                var lefsSide = true;

                // Loop trhough each character of the input
                for(int i = 0; i < input.Length; i++)
                {
                    // Check if the current character is a number
                    if ("0123456789.".Any(c => input[i] == c))
                    {
                        if (lefsSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        else
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                    }
                    // If it is an operator set the operator type
                    else if ("+-*/.".Any(c => input[i] == c))
                    {
                        // If we are on the right side already, we now need to calculate our current operation
                        // And set the result to the left side of the next operation

                        if (!lefsSide)
                        {
                            // Get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // Check if we actually have a right side number
                            if (operation.RightSide.Length == 0)
                            {
                                // Check the operator is not a minus (as they could be a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator ( + * / or more thea one - ) specified without an right side number");

                                // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                                operation.RightSide += input[i];
                            }
                            else
                            {
                                // Calculate previous equation and set to the left side
                                operation.LeftSide = CalculateOperation(operation);

                                // Set new operator
                                operation.operationType = operatorType;

                                // Clear the previous right number
                                operation.RightSide = string.Empty;
                            }
                        }
                        else
                        {
                            // Get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // Check if we actually have a left side number
                            if(operation.LeftSide.Length == 0)
                            {
                                // Check the operator is not a minus (as they could be a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator ( + * / or more thea one - ) specified without an left side number");

                                // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                                operation.LeftSide += input[i];
                            }
                            else
                            {
                                // If we get here, we have a left number and now an operator, so we want to move to the right side

                                // Set the operation type
                                operation.operationType = operatorType;

                                // Move to the right side
                                lefsSide = false;
                            }
                        }
                    }
                }

                // If we are done parsing, and there were no exceptions
                // Calculate the current operation
                return CalculateOperation(operation);
            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Calculate a <see cref="Operation"/> and return the result
        /// </summary>
        /// <param name="operation">The operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            // Store the numbervalues of the string representation
            decimal left = 0;
            decimal right = 0;

            // Check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.LeftSide}");

            // Check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Right side of the operation was not a number. {operation.RightSide}");


            try
            {
                switch (operation.operationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation. {operation.operationType}");
                }
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.operationType} {operation.RightSide}. {ex.Message}");

            }
        }

        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">The character to parse</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;

                case '-':
                    return OperationType.Minus;

                case '/':
                    return OperationType.Divide;
                case '*':
                    return OperationType.Multiply;

                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");
            }
        }

        /// <summary>
        /// Atemps to add a new character to the current number, checking for valid character as it goes
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="newtCharacter">The new charcter to append to the string</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newtCharacter)
        {
            // Check if there is already a . in the number
            if (newtCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a .");

            return currentNumber + newtCharacter;
        }
    }
}
