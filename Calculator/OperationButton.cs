using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public class OperationButton : Button
    {
        /// <summary>
        /// The operation the button preforms
        /// </summary>
        public Operation Operation { get; set; } = Operation.None;
    }
}
