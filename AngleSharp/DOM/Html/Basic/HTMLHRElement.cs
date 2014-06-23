﻿namespace AngleSharp.DOM.Html
{
    using System;

    /// <summary>
    /// Represents the hr element.
    /// </summary>
    sealed class HTMLHRElement : HTMLElement, IHtmlHrElement
    {
        #region ctor

        /// <summary>
        /// Creates a new hr element.
        /// </summary>
        internal HTMLHRElement()
        {
            _name = Tags.Hr;
        }

        #endregion

        #region Internal properties

        /// <summary>
        /// Gets if the node is in the special category.
        /// </summary>
        protected internal override Boolean IsSpecial
        {
            get { return true; }
        }

        #endregion
    }
}
