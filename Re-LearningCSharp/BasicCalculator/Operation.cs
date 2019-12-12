using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    /// <summary>
    /// Holds information about a single calculato operation
    /// </summary>
    public class Operation
    {
        #region Public Properties
        /// <summary>
        /// The left side of the operation
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// The right side of the operation
        /// </summary>
        public string RightSide { get; set; }

        /// <summary>
        /// The type of operation to perform
        /// </summary>
        public OperationType operationType { get; set; }

        /// <summary>
        /// The inner operation to be performed intially before this operation
        /// </summary>
        public Operation InnerOperation { get; set; }

        #endregion

        #region Constructor
        // Use  "ctor and double Tab to create a constructor"
        /// <summary>
        /// Default constructor
        /// </summary>
        public Operation()
        {
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }
        #endregion
    }
}
