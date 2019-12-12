using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Members
        /// <summary>
        /// Holds the current results of cells in the active game
        /// </summary>
        private MarkType[] mResults;

        /// <summary>
        /// True if it is player 1's turn (X) or player 2's turn (O)
        /// </summary>
        private bool mPLayer1Turn;

        /// <summary>
        /// True if the game has ended
        /// </summary>
        private bool mGameOver;
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor for the <see cref="MainWindow"/>
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }
        #endregion

        #region NewGame
        /// <summary>
        /// Starts a new game and clears all values back to the start
        /// </summary>
        private void NewGame()
        {
            // Create a new blank array of free cells
            mResults = new MarkType[9];

            for (var i = 0; i < mResults.Length; i++)
                mResults[i] = MarkType.Free;

            // Make sure Player 1 starts the game
            mPLayer1Turn = true;

            // Iterate every button on the grid...
            Container.Children.Cast<Button>().ToList().ForEach(button => 
            {
                button.Content = string.Empty;
                button.Background = Brushes.White;
                button.Foreground = Brushes.Blue;
            });

            // Make sure the game hasn't finished
            mGameOver = false;
        }
        #endregion

        #region ButtonClick
        /// <summary>
        /// Handles a button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Start a new game after the last click if there is no more buttons to click
            if (mGameOver)
            {
                NewGame();
                return;
            }

            // Cast the sender to a button
            var button = (Button)sender;

            // Get the position of the current button that was clicked
            var column = Grid.GetColumn(button);    //Get the Column
            var row = Grid.GetRow(button);          //Get the Row
            var index = column + (row * 3);         //Get the Index

            // Don't do anything if the cell already has a value in it
            if (mResults[index] != MarkType.Free)           
                return;

            // Set the cell value based on which players turn it is
            mResults[index] = mPLayer1Turn ? MarkType.Cross : MarkType.Nought;

            // Set button text to the result
            button.Content = mPLayer1Turn ? "X" : "O";

            // Change noughts to green
            if (!mPLayer1Turn)
                button.Foreground = Brushes.Red;

            // Toggle the players turns
            mPLayer1Turn ^= true;

            // Check for a winner
            CheckForWinner();
        }
        #endregion

        #region Verifications
        /// <summary>
        /// Will verify if there is a winner.
        /// </summary>
        private void CheckForWinner()
        {
            #region Horizontal Wins
            // Check for horizontal wins
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[1] & mResults[2]) == mResults[0])
            {
                // Game ends
                mGameOver = true;

                // Highlight winnig cells in green
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.Green;
            }
            else if (mResults[3] != MarkType.Free && (mResults[3] & mResults[4] & mResults[5]) == mResults[3])
            {
                // Game ends
                mGameOver = true;

                // Highlight winnig cells in green
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.Green;
            }
            else if(mResults[6] != MarkType.Free && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
            {
                // Game ends
                mGameOver = true;

                // Highlight winnig cells in green
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.Green;
            }
            #endregion

            #region Vertical Wins
            else
            {
                // Check for vertical wins
                if (mResults[0] != MarkType.Free && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
                {
                    // Game ends
                    mGameOver = true;

                    // Highlight winnig cells in green
                    Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.Green;
                }
                else if (mResults[1] != MarkType.Free && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
                {
                    // Game ends
                    mGameOver = true;

                    // Highlight winnig cells in green
                    Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.Green;
                }
                else if (mResults[2] != MarkType.Free && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
                {
                    // Game ends
                    mGameOver = true;

                    // Highlight winnig cells in green
                    Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.Green;
                }
                #endregion

                #region Diagonal Wins
                else
                {
                    // Check for diagonal wins
                    if (mResults[0] != MarkType.Free && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
                    {
                        // Game ends
                        mGameOver = true;

                        // Highlight winnig cells in green
                        Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.Green;
                    }
                    else if (mResults[2] != MarkType.Free && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
                    {
                        // Game ends
                        mGameOver = true;

                        // Highlight winnig cells in green
                        Button0_2.Background = Button1_1.Background = Button2_0.Background = Brushes.Green;
                    }
                }
                #endregion

            }

            if (!mResults.Any(f => f == MarkType.Free))
            {
                // The game is over as there is no more cells free
                mGameOver = true;

                // Turn all cells orange
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Background = Brushes.Orange;
                });
            }
        }
        #endregion
    }
}
