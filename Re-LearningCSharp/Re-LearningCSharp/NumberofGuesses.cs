using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_LearningCSharp
{
    /// <summary>
    ///  Ask the user to think of a number between a 
    ///  certain range and then guesses number in the fewest possible guesses
    /// </summary>

    public class NumberofGuesses
    {
        #region Public Properties

        /// <summary>
        /// The largest number we ask the user to guess, between 0 and this number
        /// </summary>
        /// Define maximum number the user can guess
        public int MaximumNumber { get; set; }

        /// <summary>
        /// Current number of guesses the computer has had
        /// </summary>
        /// Keep track of the number of guesses
        public int CurrentNumberofGuesses { get; private set; }

        /// <summary>
        /// The current known minimum number the user is thinking of
        /// </summary>
        /// The start guess from
        public int CurrentGuessMinimum { get; private set; }

        /// <summary>
        /// The current known number the user ir thinking of
        /// </summary>
        /// The start guess to (half of the max)
        public int CurrentGuessMaximum { get; private set; }

        #endregion

        #region .ctor
        /// <summary>
        /// Default Constructur
        /// </summary>
        public NumberofGuesses()
        {
            // Set default maximum number
            this.MaximumNumber = 100;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Ask the user to think of a number and the maximum number
        /// </summary>
        public void InformUser()
        {
            // Ask user to think of a number between 0 and MaximumNumber
            Console.WriteLine($"Select a number between 0 and {MaximumNumber}");
            Console.ReadLine();
        }

        /// <summary>
        /// Ask the user a series of question to discover the number they are thinking about
        /// </summary>
        public void DiscoverNumber()
        {
            // Clear variables to their initiual values before a discovery
            this.CurrentGuessMinimum = 0;
            this.CurrentNumberofGuesses = 0;
            this.CurrentGuessMaximum = this.MaximumNumber / 2;

            // While the guess isn't the same as the known maximun value
            while (this.CurrentGuessMinimum != this.CurrentGuessMaximum)
            {
                // Increase guess amount (by 1)
                this.CurrentNumberofGuesses++;

                // Ask the user if their number is between the guess range
                Console.WriteLine($"Is your number between {this.CurrentGuessMinimum} and {this.CurrentGuessMaximum}");
                string response = Console.ReadLine();

                //bool hasResponse = (response != null && response.Length > 0);
                //if (hasResponse && (response[0] == 'y' || response[0] == 'Y'))

                // if the user confirmed their number is within the current range...
                if (response?.ToLower().FirstOrDefault() == 'y')
                {
                    Console.WriteLine($"You answeed yes");

                    // We know the number is between guessFrom and guessTo
                    //So set the new maximum number

                    this.MaximumNumber = this.CurrentGuessMaximum;

                    //Change the next guess range to be half of the new maximum range
                    this.CurrentGuessMaximum = this.CurrentGuessMaximum - (this.CurrentGuessMaximum - this.CurrentGuessMinimum) / 2;
                }
                // The number is greater than guessMax and less than or equal to max
                else
                {
                    // The new guess minimum is one above the old maximum
                    this.CurrentGuessMinimum = this.CurrentGuessMaximum + 1;

                    // Guess the bottom of the new range
                    int remainingDifference = this.MaximumNumber - this.CurrentGuessMaximum;

                    // Set the guess max to half way between the guess min and max
                    // NOTE: Math.Celling will round up the remaining difference to 2, if the difference is 3
                    this.CurrentGuessMaximum += (int)Math.Ceiling(remainingDifference / 2f);
                }

                // If we only have 2 numbers left, guess one of them
                if (this.CurrentGuessMinimum + 1 == this.MaximumNumber)
                {
                    // Increase guess amount (by 1)
                    this.CurrentNumberofGuesses++;

                    // Ask the user if their number is the lower number
                    Console.WriteLine($"Is your number {this.CurrentGuessMinimum}?");
                    response = Console.ReadLine();

                    // If the user confirmed their number is the lower number....
                    if (response?.ToLower().FirstOrDefault() == 'y')
                    {
                        break;
                    }
                    else
                    {
                        // Tha means the number must be the higher of the two
                        this.CurrentGuessMinimum = this.CurrentGuessMaximum;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Announces the number the user was thinking of and the number of guesses it took
        /// </summary>
        public void AnnounceResults()
        {
            // Tell the user their number
            Console.WriteLine($"** Your number is {this.CurrentGuessMinimum} **");

            //Let the user know how many guess it took
            Console.WriteLine($"Guessed in {this.CurrentNumberofGuesses} guesses");

            Console.ReadLine();
        }

        #endregion
    }
}